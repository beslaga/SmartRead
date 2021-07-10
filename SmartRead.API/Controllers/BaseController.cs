using Microsoft.AspNetCore.Mvc;
using SmartRead.API.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartRead.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T, TSearch> : ControllerBase
    {
        private readonly IBaseService<T, TSearch> _service;
        public BaseController(IBaseService<T, TSearch> service)
        {
            _service = service;
        }


        [HttpGet]
        public async Task<List<T>> Get([FromQuery] TSearch request)
        {
            return await _service.Get(request);
        }

        [HttpGet("{id}")]
        public async Task<T> GetById(int id)
        {
            return await _service.GetById(id);
        }
    }
}
