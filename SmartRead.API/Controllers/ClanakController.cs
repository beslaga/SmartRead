using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartRead.API.Helpers;
using SmartRead.API.Services;
using SmartRead.Model;
using SmartRead.Model.Requests;
using System.Threading.Tasks;

namespace SmartRead.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClanakController : CrudController<Clanak, ClanakSearchRequest, ClanakInsertRequest, ClanakUpdateRequest>
    {
        private readonly IClanakService _service;
        public ClanakController(IClanakService service) 
            : base(service)
        {
            _service = service;
        }

        [Authorize(Roles = Security.Roles.Administrator)]
        [HttpPost("{id}/odobri")]
        public async Task<IActionResult> Odobri(int id)
        {
            var adminId = HttpContext.GetUserId();
            if (adminId == null)
            {
                return BadRequest();
            }

            var response = await _service.Odobri(id, (int)adminId);
            if(response != null)
            {
                return Ok(response);
            }

            return NotFound();
        }

        [Authorize(Roles = Security.Roles.Administrator)]
        [HttpPost("{id}/odbij")]
        public async Task<IActionResult> Odbij(int id)
        {
            var adminId = HttpContext.GetUserId();
            if (adminId == null)
            {
                return BadRequest();
            }

            var response = await _service.Odbij(id, (int)adminId);
            if (response != null)
            {
                return Ok(response);
            }

            return NotFound();
        }

        [HttpPost("{id}/like")]
        [Authorize]
        public async Task<IActionResult> Like(int id)
        {
            var korisnikId = HttpContext.GetUserId();
            if (korisnikId == null)
            {
                return BadRequest();
            }

            var response = await _service.Like(id, (int)korisnikId);
            if (response != null)
            {
                return Ok(response);
            }

            return NoContent();
        }

        [HttpPost("{id}/dislike")]
        [Authorize]
        public async Task<IActionResult> Disike(int id)
        {
            var korisnikId = HttpContext.GetUserId();
            if (korisnikId == null)
            {
                return BadRequest();
            }

            var response = await _service.Dislike(id, (int)korisnikId);
            if (response)
            {
                return Ok(response);
            }

            return NoContent();
        }

    }
}
