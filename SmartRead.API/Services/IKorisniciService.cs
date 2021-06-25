using SmartRead.Model;
using System.Threading.Tasks;

namespace SmartRead.API.Services
{
    public interface IKorisniciService : IBaseService<Korisnik, KorisnikSearchRequest>
    {
        Task<Korisnik> Autentifikacija(string username, string password);
    }
}
