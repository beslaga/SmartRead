using Microsoft.AspNetCore.Mvc;
using SmartRead.API.Services;

namespace SmartRead.API.Controllers
{
    [Route("api/login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IKorisniciService _service;

        public LoginController(IKorisniciService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<Model.Korisnik> Login([FromQuery] string username, [FromQuery] string password)
        {
            return _service.Autentifikacija(username, password);
        }
    }
}
