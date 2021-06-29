using Microsoft.AspNetCore.Mvc;
using SmartRead.API.Services;
using SmartRead.Model;

namespace SmartRead.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UlogaController : BaseController<Uloga, object>
    {
        public UlogaController(IBaseService<Uloga, object> service) : base(service)
        {
        }
    }
}
