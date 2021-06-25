using Microsoft.AspNetCore.Mvc;
using SmartRead.API.Services;
using System.Threading.Tasks;

namespace SmartRead.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IKorisniciService _service;

        public LoginController(IKorisniciService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult<Model.Korisnik>> Login([FromBody] Model.Requests.LoginRequest request)
        {
            return await _service.Autentifikacija(request.username, request.password);
        }
    }
}
