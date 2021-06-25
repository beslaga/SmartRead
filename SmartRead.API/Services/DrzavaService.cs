using AutoMapper;
using SmartRead.API.Database.Context;
using SmartRead.Model;

namespace SmartRead.API.Services
{
    public class DrzavaService : BaseService<Drzava, object, Database.Drzava>
    { 
        public DrzavaService(SmartReadContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
