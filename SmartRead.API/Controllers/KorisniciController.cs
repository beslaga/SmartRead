using Microsoft.AspNetCore.Mvc;
using SmartRead.API.Services;
using SmartRead.Model;

namespace SmartRead.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KorisniciController : BaseController<Korisnik, KorisnikSearchRequest>
    {
        private readonly IKorisniciService _service;

        public KorisniciController(IKorisniciService service) : base(service)
        {
        }
    }
}
