using SmartRead.Model;
using SmartRead.Model.Requests;
using System.Threading.Tasks;

namespace SmartRead.API.Services
{
    public interface IClanakService : ICrudService<Clanak, ClanakSearchRequest, ClanakInsertRequest, ClanakUpdateRequest>
    {
        Task<Clanak> Odobri(int clanakId, int adminId);
        Task<Clanak> Odbij(int clanakId, int adminId);
    }
}
