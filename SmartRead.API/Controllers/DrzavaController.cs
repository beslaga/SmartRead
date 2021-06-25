using Microsoft.AspNetCore.Mvc;
using SmartRead.API.Services;
using SmartRead.Model;

namespace SmartRead.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrzavaController : BaseController<Drzava, object>
    {
        public DrzavaController(IBaseService<Drzava, object> service) : base(service)
        {
        }
    }
}
