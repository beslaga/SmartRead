using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartRead.API.Helpers;
using SmartRead.API.Services;
using SmartRead.Model;
using SmartRead.Model.Requests;
using System.Threading.Tasks;

namespace SmartRead.API.Controllers
{
    [Authorize]
    public class KategorijeController : 
        CrudController<Kategorija, KategorijaSearchRequest, KategorijaUpsertRequest, KategorijaUpsertRequest>
    {
        private readonly IKategorijeService _service;
        public KategorijeController(IKategorijeService service) : base(service)
        {
            _service = service;
        }

        [HttpPost("{id}/subscribe")]
        [Authorize]
        public async Task<IActionResult> Subscribe(int id)
        {
            var korisnikId = HttpContext.GetUserId();
            if (korisnikId == null)
            {
                return BadRequest();
            }

            var response = await _service.Subscribe(id, (int)korisnikId);
            if (response != null)
            {
                return Ok(response);
            }

            return NoContent();
        }

        [HttpPost("{id}/unsubscribe")]
        [Authorize]
        public async Task<IActionResult> Unsubscribe(int id)
        {
            var korisnikId = HttpContext.GetUserId();
            if (korisnikId == null)
            {
                return BadRequest();
            }

            var response = await _service.Unsubscribe(id, (int)korisnikId);
            if (response)
            {
                return Ok(response);
            }

            return NoContent();
        }
    }
}
