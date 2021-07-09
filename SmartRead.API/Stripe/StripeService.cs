using AutoMapper;
using SmartRead.API.Database.Context;
using SmartRead.Model;
using SmartRead.Model.Requests;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartRead.API.Stripe
{
    public class StripeService : IStripeService
    {
        private readonly SmartReadContext _context;
        private readonly StripeOptions _stripeOptions;
        private readonly IMapper _mapper;

        public StripeService(SmartReadContext context, StripeOptions stripeOptions, IMapper mapper)
        {
            _context = context;
            _stripeOptions = stripeOptions;
            _mapper = mapper;
        }

        public async Task<Uplata> KupiKredit(int id, UplataRequest request)
        {
            var korisnik = await _context.Korisnici.FindAsync(id);

            if (korisnik == null)
            {
                return null;
            }

            StripeConfiguration.ApiKey = _stripeOptions.ApiKey;
            
            var tokenOptions = new TokenCreateOptions
            {
                Card = new TokenCardOptions
                {
                    Number = request.BrojKartice,
                    ExpMonth = request.MjesecIsteka,
                    ExpYear = request.GodinaIsteka,
                    Cvc = request.Cvc,
                },
            };
            var tokenService = new TokenService();
            var stripeToken = await tokenService.CreateAsync(tokenOptions);


            var chargeOptions = new ChargeCreateOptions
            {
                Amount = request.IznosUplate,
                Currency = "bam",
                Description = "Uplata za SmartRead kredit",
                Source = stripeToken.Id
            };

            var chargeService = new ChargeService();
            var charge = await chargeService.CreateAsync(chargeOptions);

            if (charge.Paid)
            {
                var uplata = new Database.Uplata
                {
                    Iznos = (float)(request.IznosUplate / 100),
                    Opis = chargeOptions.Description,
                    KorisnikId = korisnik.Id
                };

                await _context.Uplate.AddAsync(uplata);
                await _context.SaveChangesAsync();

                korisnik.Kredit += (float)(request.IznosUplate / 100);
                await _context.SaveChangesAsync();

                return _mapper.Map<Uplata>(uplata);
            }


            return null;
        }
    }
}
