using AutoMapper;
using SmartRead.API.Database.Context;
using SmartRead.Model;

namespace SmartRead.API.Services
{
    public class UlogaService : BaseService<Uloga, object, Database.Uloga>
    {
        public UlogaService(SmartReadContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
