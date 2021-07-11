using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartRead.API.Helpers;
using SmartRead.API.Recommender;
using SmartRead.API.Services;
using SmartRead.Model;
using SmartRead.Model.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartRead.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClanakController : CrudController<Clanak, ClanakSearchRequest, ClanakInsertRequest, ClanakUpdateRequest>
    {
        private readonly IClanakService _service;
        private readonly IRecommender _recommender;
        public ClanakController(IClanakService service, IRecommender recommender)
            : base(service)
        {
            _service = service;
            _recommender = recommender;
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

        [HttpPost("train-model")]
        public IActionResult TrainModel()
        {
            return Ok(_recommender.TrainModel());
        }

        [HttpGet("recommend")]
        [Authorize]
        public async Task<IActionResult> GetRecommendations()
        {
            var korisnikId = HttpContext.GetUserId();
            if (korisnikId == null)
            {
                return BadRequest();
            }

            var response = await _service.GetRecommended((int)korisnikId);
            return Ok(response);
        }

        [HttpPost("{id}/ocijeni/{ocjena}")]
        [Authorize]
        public async Task<IActionResult> Ocijeni(int id, int ocjena)
        {
            var korisnikId = HttpContext.GetUserId();
            if (korisnikId == null)
            {
                return BadRequest();
            }

            var response = await _service.Ocijeni(id, (int)korisnikId, ocjena);
            return Ok(response);
        }

        [HttpGet("{id}/ocjena")]
        [Authorize]
        public async Task<IActionResult> GetOcjenu(int id)
        {
            var korisnikId = HttpContext.GetUserId();
            if (korisnikId == null)
            {
                return BadRequest();
            }

            var response = await _service.GetOcjenu(id, (int)korisnikId);
            return Ok(response);
        }

        [HttpPost("{id}/kupi")]
        [Authorize]
        public async Task<IActionResult> Kupi(int id)
        {
            var korisnikId = HttpContext.GetUserId();
            if (korisnikId == null)
            {
                return BadRequest();
            }

            var response = await _service.Kupi(id, (int)korisnikId);
            
            if (response)
            {
                return Ok(response);
            }

            return BadRequest();
        }

        [HttpPost("{id}/prijavi")]
        [Authorize]
        public async Task<IActionResult> Prijavi(int id, ClanakPrijavaRequest request)
        {
            var korisnikId = HttpContext.GetUserId();
            if (korisnikId == null)
            {
                return BadRequest();
            }

            var response = await _service.Prijavi(id, (int)korisnikId, request);

            if (response != null)
            {
                return Ok(response);
            }

            return BadRequest();
        }

        [HttpGet("prijave")]
        [Authorize(Roles = Security.Roles.Administrator)]
        public async Task<IActionResult> GetPrijave()
        {
            var response = await _service.GetPrijave();
            return Ok(response);
        }

        [HttpPost("{id}/uvazi")]
        [Authorize(Roles = Security.Roles.Administrator)]
        public async Task<IActionResult> Uvazi(int id)
        {
            var response = await _service.Uvazi(id);

            if (response != null)
            {
                return Ok(response);
            }

            return BadRequest();
        }

        [HttpPost("{id}/pregledano")]
        [Authorize(Roles = Security.Roles.Administrator)]
        public async Task<IActionResult> Pregledano(int id)
        {
            var response = await _service.Pregledano(id);

            if (response != null)
            {
                return Ok(response);
            }

            return BadRequest();
        }
    }
}
