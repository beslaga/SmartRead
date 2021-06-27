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
    public class ClanakService :
        CrudService<Clanak, ClanakSearchRequest, Database.Clanak, ClanakInsertRequest, ClanakUpdateRequest>,
        IClanakService
    {
        public ClanakService(SmartReadContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override async Task<bool> Delete(int id)
        {
            var entity = await _context.Clanci.FindAsync(id);

            if (entity != null)
            {
                entity.Obrisan = true;

                await _context.SaveChangesAsync();

                return true;
            }

            return false;
        }

        public override async Task<List<Clanak>> Get(ClanakSearchRequest search)
        {
            var list = await _context.Set<Database.Clanak>()
               .AsNoTracking()
               .Include(i => i.Kategorije)
               .ThenInclude(i => i.Kategorija)
               .ToListAsync();

            return _mapper.Map<List<Clanak>>(list);
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

            return _mapper.Map<Clanak>(entity);
        }

        public async Task<Clanak> Odbij(int clanakId, int adminId)
        {
            var entity = await _context.Clanci.FindAsync(clanakId);

            if (entity != null)
            {
                entity.Odobren = false;
                entity.OdobravateljId = adminId;

                await _context.SaveChangesAsync();

                return _mapper.Map<Clanak>(entity);
            }

            return null;

        }

        public async Task<Clanak> Odobri(int clanakId, int adminId)
        {
            var entity = await _context.Clanci.FindAsync(clanakId);

            if (entity != null)
            {
                entity.Odobren = true;
                entity.OdobravateljId = adminId;

                await _context.SaveChangesAsync();

                return _mapper.Map<Clanak>(entity);
            }

            return null;
        }

        public override async Task<Clanak> Update(int id, ClanakUpdateRequest request)
        {
            var entity = await _context.Clanci.FindAsync(id);
            

            entity.Naslov = request.Naslov;
            entity.Text = request.Text;
            entity.Cijena = request.Cijena;
            entity.Slika = request.Slika;

            await _context.SaveChangesAsync();

            foreach (var kategorijaId in request.ObrisaneKategorije)
            {
                var kategorija = await _context.ClanakKategorije
                    .Where(i => i.ClanakId == id && i.KategorijaId == kategorijaId)
                    .SingleOrDefaultAsync();

                if (kategorija != null)
                {
                    _context.ClanakKategorije.Remove(kategorija);
                }
            }
            await _context.SaveChangesAsync();

            foreach (var kategorijaId in request.Kategorije)
            {
                var kategorija = await _context.ClanakKategorije
                    .Where(i => i.ClanakId == id && i.KategorijaId == kategorijaId)
                    .SingleOrDefaultAsync();

                if (kategorija == null)
                {
                    var newTrackArtist = new Database.ClanakKategorija
                    {
                        ClanakId = id,
                        KategorijaId = kategorijaId,
                    };
                    await _context.ClanakKategorije.AddAsync(newTrackArtist);
                }
            }
            await _context.SaveChangesAsync();

            return _mapper.Map<Clanak>(entity);
        }
    }
}
