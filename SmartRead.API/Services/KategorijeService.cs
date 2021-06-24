using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SmartRead.API.Database.Context;
using SmartRead.Model;
using SmartRead.Model.Requests;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartRead.API.Services
{
    public class KategorijeService : 
        CrudService<Kategorija, KategorijaSearchRequest, Database.Kategorija, KategorijaUpsertRequest, KategorijaUpsertRequest>
    {
        public KategorijeService(SmartReadContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override async Task<List<Kategorija>> Get(KategorijaSearchRequest search)
        {
            var query = _context.Set<Kategorija>()
                .AsNoTracking()
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.Naziv))
            {
                query = query.Where(x => x.Naziv.Contains(search.Naziv));
            }

            query = query.Where(x => x.Obrisan == search.Obrisan);

            var list = await query.ToListAsync();
            return _mapper.Map<List<Kategorija>>(list);
        }
    }
}
