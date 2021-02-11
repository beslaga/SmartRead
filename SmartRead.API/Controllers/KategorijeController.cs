using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartRead.API.Services;
using System.Collections.Generic;

namespace SmartRead.API.Controllers
{
    [Route("api/kategorije")]
    [Authorize]
    [ApiController]
    public class KategorijeController : ControllerBase
    {
        private readonly IKategorijeService _service;

        public KategorijeController(IKategorijeService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Model.Kategorija>> Get([FromQuery] Model.Requests.KategorijaInsertRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        public ActionResult<Model.Kategorija> Insert([FromBody] string naziv)
        {
            return _service.Insert(naziv);
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult<Model.Kategorija> Update(int id, [FromBody] Model.Requests.KategorijaInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            if (_service.Delete(id))
            {
                return NoContent();
            } else
            {
                return BadRequest();
            }
        }
    }
}
