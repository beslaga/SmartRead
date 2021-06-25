using AutoMapper;
using SmartRead.API.Database.Context;
using SmartRead.Model;
using SmartRead.Model.Requests;

namespace SmartRead.API.Services
{
    public class ClanakService :
        CrudService<Clanak, ClanakSearchRequest, Database.Clanak, ClanakInsertRequest, ClanakUpdateRequest>,
        IClanakService
    {
        public ClanakService(SmartReadContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
