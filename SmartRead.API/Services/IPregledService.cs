using SmartRead.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartRead.API.Services
{
    public interface IPregledService
    {
        Task<KorisnikClanak> LogujPregled(int korisnikId, int clanakId);
        List<AktivnostKorisnik> GetAktivnostKorisnik();
    }
}
