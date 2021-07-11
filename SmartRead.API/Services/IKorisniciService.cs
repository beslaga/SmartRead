using SmartRead.Model;
using SmartRead.Model.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartRead.API.Services
{
    public interface IKorisniciService : ICrudService<Korisnik, KorisnikSearchRequest, KorisnikInsertRequest, KorisnikUpdateRequest>
    {
        Task<Korisnik> Autentifikacija(string username, string password);
        Task<PasswordReset> ResetPassword(int id);
        Task<List<Clanak>> Likes(int id);
        Task<List<Clanak>> Notifikacije(int id);
    }
}
