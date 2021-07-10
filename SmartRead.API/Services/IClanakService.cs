using SmartRead.Model;
using SmartRead.Model.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartRead.API.Services
{
    public interface IClanakService : ICrudService<Clanak, ClanakSearchRequest, ClanakInsertRequest, ClanakUpdateRequest>
    {
        Task<Clanak> Odobri(int clanakId, int adminId);
        Task<Clanak> Odbij(int clanakId, int adminId);
        Task<Like> Like(int clanakId, int korisnikId);
        Task<bool> Dislike(int clanakId, int korisnikId);
        Task<List<Clanak>> GetRecommended(int korisnikId);
        Task<KorisnikClanak> Ocijeni(int clanakId, int korisnikId, int ocjena);
        Task<KorisnikClanak> GetOcjenu(int clanakId, int korisnikId);
    }
}
