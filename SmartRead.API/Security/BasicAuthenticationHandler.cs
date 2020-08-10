using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SmartRead.API.Helpers;
using SmartRead.API.Services;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace SmartRead.API.Security
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly IKorisniciService _korisniciService;

        public BasicAuthenticationHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock,
            IKorisniciService userService)
            : base(options, logger, encoder, clock)
        {
            _korisniciService = userService;
        }

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            if (!Request.Headers.ContainsKey("Authorization"))
                return AuthenticateResult.Fail("Missing Authorization Header");

            Model.Korisnik PrijavljeniKorisnik = null;

            try
            {
                var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
                var credentialBytes = Convert.FromBase64String(authHeader.Parameter);
                var credentials = Encoding.UTF8.GetString(credentialBytes).Split(':');
                var username = credentials.First();
                var password = credentials.Second();
                PrijavljeniKorisnik = _korisniciService.Autentifikacija(username, password);
            }
            catch
            {
                return AuthenticateResult.Fail("Invalid Authorization Header");
            }

            if (PrijavljeniKorisnik == null)
                return AuthenticateResult.Fail("Invalid Username or Password");

            _korisniciService.SetPrijavljeniKorisnik(PrijavljeniKorisnik);

            var claims = new List<Claim> {
                new Claim(ClaimTypes.NameIdentifier, PrijavljeniKorisnik.Username),
                new Claim(ClaimTypes.Name, PrijavljeniKorisnik.ImePrezime),
            };

            if (PrijavljeniKorisnik.Administrator != null)
            {
                claims.Add(new Claim(ClaimTypes.Role, "Administrator"));
            } else
            {
                claims.Add(new Claim(ClaimTypes.Role, "BasicUser"));
            }

            var identity = new ClaimsIdentity(claims, Scheme.Name);
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, Scheme.Name);

            return AuthenticateResult.Success(ticket);
        }
    }
}

