using AutoMapper;
using SmartRead.API.Database.Context;
using SmartRead.Model;
using SmartRead.Model.Requests;
using System.Threading.Tasks;

namespace SmartRead.API.Services
{
    public class ClanakService :
        CrudService<Clanak, ClanakSearchRequest, Database.Clanak, ClanakInsertRequest, ClanakUpdateRequest>,
        IClanakService
    {
        public ClanakService(SmartReadContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override async Task<Clanak> Insert(ClanakInsertRequest request)
        {
            var entity = _mapper.Map<Database.Clanak>(request);

            await _context.Clanci.AddAsync(entity);
            await _context.SaveChangesAsync();

            foreach (var kategorijaId in request.Kategorije)
            {
                var clanakKategorija = new Database.ClanakKategorija
                {
                    ClanakId = entity.Id,
                    KategorijaId = kategorijaId
                };
                await _context.ClanakKategorije.AddAsync(clanakKategorija);
            }

            await _context.SaveChangesAsync();

            return _mapper.Map<Model.Clanak>(entity);
        }
    }
}
