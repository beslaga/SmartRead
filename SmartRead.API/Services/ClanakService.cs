﻿using AutoMapper;
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
            var list = await _context.Set<Database.Clanak>()
               .AsNoTracking()
               .Include(i => i.Kategorije)
               .ThenInclude(i => i.Kategorija)
               .Include(i => i.Autor)
               .ToListAsync();

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
            var clanci = await _context.Clanci.ToListAsync();

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
    }
}
