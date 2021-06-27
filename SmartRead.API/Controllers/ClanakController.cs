using Microsoft.AspNetCore.Mvc;
using SmartRead.API.Services;
using SmartRead.Model;
using SmartRead.Model.Requests;

namespace SmartRead.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClanakController : CrudController<Clanak, ClanakSearchRequest, ClanakInsertRequest, ClanakUpdateRequest>
    {
        public ClanakController(IClanakService service) 
            : base(service)
        {
        }
    }
}
