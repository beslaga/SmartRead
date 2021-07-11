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
        CrudService<Kategorija, KategorijaSearchRequest, Database.Kategorija, KategorijaUpsertRequest, KategorijaUpsertRequest>,
        IKategorijeService
    {
        public KategorijeService(SmartReadContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override async Task<List<Kategorija>> Get(KategorijaSearchRequest search)
        {
            var query = _context.Set<Database.Kategorija>()
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

        public async Task<KorisnikKategorija> Subscribe(int kategorijaId, int korisnikId)
        {
            var sub = await _context.KorisnikKategorije.FindAsync(korisnikId, kategorijaId);

            if (sub == null)
            {
                var newSub = new Database.KorisnikKategorija { KorisnikId = korisnikId, KategorijaId = kategorijaId };
                await _context.KorisnikKategorije.AddAsync(newSub);
                await _context.SaveChangesAsync();

                return _mapper.Map<KorisnikKategorija>(newSub);
            }

            return null;
        }

        public async Task<bool> Unsubscribe(int kategorijaId, int korisnikId)
        {
            var sub = await _context.KorisnikKategorije.FindAsync(korisnikId, kategorijaId);

            if (sub != null)
            {
                _context.KorisnikKategorije.Remove(sub);
                await _context.SaveChangesAsync();

                return true;
            }

            return false;
        }
    }
}
