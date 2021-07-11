using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartRead.API.Helpers;
using SmartRead.API.Services;
using System.Threading.Tasks;

namespace SmartRead.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PregledController : ControllerBase
    {
        private readonly IPregledService _service;

        public PregledController(IPregledService service)
        {
            _service = service;
        }

        [HttpPost("clanak/{id}")]
        [Authorize]
        public async Task<IActionResult> LogujPregled(int id)
        {
            var korisnikId = HttpContext.GetUserId();
            if (korisnikId == null)
            {
                return BadRequest();
            }

            var response = await _service.LogujPregled((int)korisnikId, id);
            return Ok(response);
        }

        [HttpGet("korisnik-aktivnost")]
        public IActionResult GetKorisnikAktivnost()
        {
            var response = _service.GetAktivnostKorisnik();
            return Ok(response);
        }
    }
}
