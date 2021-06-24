using Microsoft.AspNetCore.Authorization;
using SmartRead.API.Services;
using SmartRead.Model;
using SmartRead.Model.Requests;

namespace SmartRead.API.Controllers
{
    [Authorize]
    public class KategorijeController : 
        CrudController<Kategorija, KategorijaSearchRequest, KategorijaUpsertRequest, KategorijaUpsertRequest>
    {

        public KategorijeController(
            ICrudService<Kategorija, KategorijaSearchRequest, KategorijaUpsertRequest, KategorijaUpsertRequest> service) : base(service)
        {

        }
    }
}
