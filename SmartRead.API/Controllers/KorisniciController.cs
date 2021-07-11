using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartRead.API.Helpers;
using SmartRead.API.Services;
using SmartRead.API.Stripe;
using SmartRead.Model;
using SmartRead.Model.Requests;
using System.Threading.Tasks;

namespace SmartRead.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KorisniciController : CrudController<Korisnik, KorisnikSearchRequest, KorisnikInsertRequest, KorisnikUpdateRequest>
    {
        private readonly IKorisniciService _service;
        private readonly IStripeService _stripeService;

        public KorisniciController(IKorisniciService service, IStripeService stripeService) : base(service)
        {
            _service = service;
            _stripeService = stripeService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(KorisnikInsertRequest request)
        {
            var response = await _service.Insert(request);

            if(response != null)
            {
                return Ok(response);
            }

            return BadRequest();
        }

        [HttpPost("{id}/reset-password")]
        public async Task<IActionResult> ResetPassword(int id)
        {
            var response = await _service.ResetPassword(id);

            if(response == default(PasswordReset))
            {
                return NotFound();
            }

            return Ok(response);
        }

        [HttpGet("{id}/likes")]
        public async Task<IActionResult> GetLikes(int id)
        {
            var response = await _service.Likes(id);
            return Ok(response);
        }

        [HttpPost("kredit")]
        public async Task<IActionResult> KupiKredit(UplataRequest request)
        {
            var id = HttpContext.GetUserId();
            if (id == null)
            {
                return BadRequest();
            }

            var response = await _stripeService.KupiKredit((int)id, request);
            if (response != null)
            {
                return Ok(response);
            }

            return NotFound();
        }

        [HttpGet("notifikacije")]
        [Authorize]
        public async Task<IActionResult> GetNotifikacije()
        {
            var id = HttpContext.GetUserId();
            if (id == null)
            {
                return BadRequest();
            }

            var response = await _service.Notifikacije((int)id);
            return Ok(response);
        }
    }
}
