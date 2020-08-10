using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartRead.API.Services;
using System.Collections.Generic;

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
        public ActionResult<List<Model.Korisnik>> GetBesla()
        {
            return _service.Get();
        }
    }
}
