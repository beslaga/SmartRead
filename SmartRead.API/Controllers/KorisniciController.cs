using Microsoft.AspNetCore.Mvc;
using SmartRead.API.Services;
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

        public KorisniciController(IKorisniciService service) : base(service)
        {
            _service = service;
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
    }
}
