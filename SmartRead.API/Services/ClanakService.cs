using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SmartRead.API.Database.Context;
using SmartRead.API.Recommender;
using SmartRead.Model;
using SmartRead.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartRead.API.Services
{
    public class ClanakService :
        CrudService<Clanak, ClanakSearchRequest, Database.Clanak, ClanakInsertRequest, ClanakUpdateRequest>,
        IClanakService
    {
        private readonly IRecommender _recommender;
        public ClanakService(SmartReadContext context, IMapper mapper, IRecommender recommender) : base(context, mapper)
        {
            _recommender = recommender;
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
            var query = _context.Set<Database.Clanak>()
               .AsNoTracking()
               .Include(i => i.Kategorije)
               .ThenInclude(i => i.Kategorija)
               .Include(i => i.Autor)
               .AsQueryable();

            if(!string.IsNullOrEmpty(search.Search))
            {
                query = query.Where(i => i.Naslov.Contains(search.Search) ||
                    i.Autor.Ime.Contains(search.Search) || 
                    i.Autor.Prezime.Contains(search.Search)
                );
            }

            if(search.KategorijaId > 0)
            {
                query = query.Where(i => i.Kategorije.Any(j => j.KategorijaId == search.KategorijaId));
            }

            var list = await query.ToListAsync();

            return _mapper.Map<List<Clanak>>(list);
        }

        public override async Task<Clanak> GetById(int id)
        {
            var list = await _context.Set<Database.Clanak>()
               .AsNoTracking()
               .Include(i => i.Kategorije)
               .ThenInclude(i => i.Kategorija)
               .Include(i => i.Autor)
               .Where(i => i.Id == id)
               .SingleOrDefaultAsync();

            return _mapper.Map<Clanak>(list);
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

            var korisnici = await _context.KorisnikKategorije
                .Where(i => request.Kategorije.Contains(i.KategorijaId))
                .Select(i => i.KorisnikId)
                .Distinct()
                .ToListAsync();

            foreach (var korisnikId in korisnici)
            {
                if (korisnikId != entity.AutorId)
                {
                    var notifikacija = new Database.Notifikacija
                    {
                        KorisnikId = korisnikId,
                        ClanakId = entity.Id
                    };

                    await _context.Notifikacije.AddAsync(notifikacija);
                }
            }

            await _context.SaveChangesAsync();

            return _mapper.Map<Clanak>(entity);
        }

        public async Task<Like> Like(int clanakId, int korisnikId)
        {
            var like = await _context.Likes.FindAsync(korisnikId, clanakId);

            if (like == null)
            {
                var newLike = new Database.Like { KorisnikId = korisnikId, ClanakId = clanakId };
                await _context.Likes.AddAsync(newLike);
                await _context.SaveChangesAsync();

                return _mapper.Map<Like>(newLike);
            }

            return null;
        }

        public async Task<bool> Dislike(int clanakId, int korisnikId)
        {
            var like = await _context.Likes.FindAsync(korisnikId, clanakId);

            if (like != null)
            {
                _context.Likes.Remove(like);
                await _context.SaveChangesAsync();

                return true;
            }

            return false;
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

        public async Task<List<Clanak>> GetRecommended(int korisnikId)
        {
            var clanci = await _context.Set<Database.Clanak>()
              .AsNoTracking()
              .Include(i => i.Kategorije)
                .ThenInclude(i => i.Kategorija)
              .Include(i => i.Autor)
              .ToListAsync();

            var list = new List<Database.Clanak>();
            foreach (var clanak in clanci)
            {
                var score = _recommender.PredictScore(korisnikId, clanak.Id);
                if (Math.Round(score, 1) > 3.5)
                {
                    list.Add(clanak);
                }
            }
            

            return _mapper.Map<List<Clanak>>(list);
        }

        public async Task<KorisnikClanak> Ocijeni(int clanakId, int korisnikId, int ocjena)
        {
            var korisnikClanak = await _context.KorisnikClanci.FindAsync(korisnikId, clanakId);

            if(korisnikClanak != null)
            {
                korisnikClanak.Ocjena = ocjena;
            }
            else
            {
                korisnikClanak = new Database.KorisnikClanak
                {
                    KorisnikId = korisnikId,
                    ClanakId = clanakId,
                    Ocjena = ocjena
                };

                await _context.AddAsync(korisnikClanak);
            }

            await _context.SaveChangesAsync();
            return _mapper.Map<KorisnikClanak>(korisnikClanak);
        }

        public async Task<KorisnikClanak> GetOcjenu(int clanakId, int korisnikId)
        {
            var korisnikClanak = await _context.KorisnikClanci.FindAsync(korisnikId, clanakId);
            return _mapper.Map<KorisnikClanak>(korisnikClanak);
        }

        public async Task<bool> Kupi(int clanakId, int korisnikId)
        {
            var clanak = await _context.Clanci.FindAsync(clanakId);

            if (clanak != null && clanak.Cijena > 0)
            {
                var korisnik = await _context.Korisnici.FindAsync(korisnikId);

                if (korisnik != null && korisnik.Kredit > 0)
                {
                    var korisnikClanak = await _context.KorisnikClanci.FindAsync(korisnikId, clanakId);

                    if (korisnikClanak == null)
                    {
                        korisnik.Kredit -= clanak.Cijena;
                        korisnikClanak = new Database.KorisnikClanak
                        {
                            KorisnikId = korisnikId,
                            ClanakId = clanakId,
                            Kupljen = true
                        };

                        await _context.AddAsync(korisnikClanak);
                        await _context.SaveChangesAsync();
                        return true;
                    }
                }
            }

            return false;
        }

        public async Task<KorisnikPrijava> Prijavi(int clanakId, int korisnikId, ClanakPrijavaRequest request)
        {
            var korisnikPrijava = new Database.KorisnikPrijava
            {
                ClanakId = clanakId,
                KorisnikId = korisnikId,
                Opis = request.Opis,
                VrijemePrijave = DateTime.Now
            };

            await _context.KorisnikPrijave.AddAsync(korisnikPrijava);
            await _context.SaveChangesAsync();

            return _mapper.Map<KorisnikPrijava>(korisnikPrijava);
        }
    }
}
