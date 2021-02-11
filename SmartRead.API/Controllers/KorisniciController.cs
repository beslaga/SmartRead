using Microsoft.AspNetCore.Mvc;
using SmartRead.API.Services;

namespace SmartRead.API.Controllers
{
    [Route("api/korisnici")]
    [ApiController]
    public class KorisniciController : ControllerBase
    {
        private readonly IKorisniciService _service;

        public KorisniciController(IKorisniciService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<Model.Korisnik> Get()
        {
            return _service.GetTrenutniKorisnik();
        }
    }
}
