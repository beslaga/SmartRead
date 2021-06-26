using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SmartRead.API.Database.Context;
using SmartRead.API.Helpers;
using SmartRead.Model;
using System.Threading.Tasks;

namespace SmartRead.API.Services
{
    public class KorisniciService : 
        BaseService<Korisnik, KorisnikSearchRequest, Database.Korisnik>,
        IKorisniciService
    {
        public KorisniciService(SmartReadContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<Korisnik> Autentifikacija(string username, string password)
        {
            var korisnik = await _context.Korisnici
                .Include(x => x.Drzava)
                .Include(i => i.Uloge)
                .ThenInclude(i => i.Uloga)
                .FirstOrDefaultAsync(x => x.Username == username);

            if (korisnik != null)
            {
                var newHash = HashHelper.GenerateHash(korisnik.PasswordSalt, password);
                if (newHash == korisnik.PasswordHash)
                {
                    return _mapper.Map<Korisnik>(korisnik);
                }
            }
            return null;
        }
    }
}
