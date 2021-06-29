using Microsoft.AspNetCore.Mvc;
using SmartRead.API.Services;
using SmartRead.Model;
using SmartRead.Model.Requests;

namespace SmartRead.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KorisniciController : CrudController<Korisnik, KorisnikSearchRequest, KorisnikInsertRequest, KorisnikUpdateRequest>
    {
        private readonly IKorisniciService _service;

        public KorisniciController(IKorisniciService service) : base(service)
        {
        }
    }
}
