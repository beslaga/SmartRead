using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartRead.API.Services;

namespace SmartRead.API.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IKorisniciService _service;

        public WeatherForecastController(IKorisniciService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<Model.Korisnik> GetBesla()
        {
            return _service.GetTrenutniKorisnik();
        }
    }
}
