using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartRead.API.Services;
using System.Threading.Tasks;

namespace SmartRead.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrudController<T, TSearch, TInsert, TUpdate> : BaseController<T, TSearch>
    {
        private readonly ICrudService<T, TSearch, TInsert, TUpdate> _service = null;
        public CrudController(ICrudService<T, TSearch, TInsert, TUpdate> service) : base(service)
        {
            _service = service;
        }

        [Authorize(Roles = Security.Roles.Administrator)]
        [HttpPost]
        public async Task<T> Insert(TInsert request)
        {
            return await _service.Insert(request);
        }

        [Authorize(Roles = Security.Roles.Administrator)]
        [HttpPut("{id}")]
        public async Task<T> Update(int id, [FromBody] TUpdate request)
        {
            return await _service.Update(id, request);
        }

        [Authorize(Roles = Security.Roles.Administrator)]
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _service.Delete(id);
        }
    }
}
