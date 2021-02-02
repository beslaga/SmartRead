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

        [HttpPost]
        public ActionResult<Model.Korisnik> Login([FromBody] Model.Requests.LoginRequest request)
        {
            return _service.Autentifikacija(request.username, request.password);
        }
    }
}
