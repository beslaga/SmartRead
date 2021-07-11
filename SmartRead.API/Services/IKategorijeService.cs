using SmartRead.Model;
using SmartRead.Model.Requests;
using System.Threading.Tasks;

namespace SmartRead.API.Services
{
    public interface IKategorijeService
        : ICrudService<Kategorija, KategorijaSearchRequest, KategorijaUpsertRequest, KategorijaUpsertRequest>
    {
        Task<KorisnikKategorija> Subscribe(int kategorijaId, int korisnikId);
        Task<bool> Unsubscribe(int kategorijaId, int korisnikId);
    }
}
