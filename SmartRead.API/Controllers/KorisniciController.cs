using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
        [Route("login")]
        public ActionResult<Model.Korisnik> Login([FromQuery] string username, [FromQuery] string password)
        {
            return _service.Autentifikacija(username, password);
        }
    }
}
