using SmartRead.Model;
using SmartRead.Model.Requests;

namespace SmartRead.API.Services
{
    public interface IClanakService : ICrudService<Clanak, ClanakSearchRequest, ClanakInsertRequest, ClanakUpdateRequest>
    {
    }
}
