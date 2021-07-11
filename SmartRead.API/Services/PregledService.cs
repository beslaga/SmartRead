using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SmartRead.API.Database.Context;
using SmartRead.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartRead.API.Services
{
    public class PregledService : IPregledService
    {
        private readonly SmartReadContext _context;
        private readonly IMapper _mapper;

        public PregledService(SmartReadContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<AktivnostKorisnik> GetAktivnostKorisnik()
        {
            var list = _context.KorisnikClanci
                   .GroupBy(p => p.KorisnikId)
                   .Select(g => new
                   {
                       KorisnikId = g.Key,
                       BrojPosjeta = g.Sum(j => j.BrojPosjeta)
                   })
                   .ToList();

            var activityList = new List<AktivnostKorisnik>();
            foreach (var item in list)
            {
                var korisnik = _context.Korisnici.Find(item.KorisnikId);
                var k = _mapper.Map<Korisnik>(korisnik);
                activityList.Add(new AktivnostKorisnik { Korisnik = k, BrojPosjeta = item.BrojPosjeta });
            }

            return activityList;
        }

        public async Task<KorisnikClanak> LogujPregled(int korisnikId, int clanakId)
        {
            var korisnikClanak = await _context.KorisnikClanci.FindAsync(korisnikId, clanakId);

            if (korisnikClanak != null)
            {
                korisnikClanak.BrojPosjeta += 1;
            }
            else
            {
                korisnikClanak = new Database.KorisnikClanak
                {
                    KorisnikId = korisnikId,
                    ClanakId = clanakId,
                    BrojPosjeta = 1
                };

                await _context.KorisnikClanci.AddAsync(korisnikClanak);
            }

            await _context.SaveChangesAsync();
            return _mapper.Map<KorisnikClanak>(korisnikClanak);
        }
    }
}
