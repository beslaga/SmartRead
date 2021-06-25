using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SmartRead.API.Database.Context;
using SmartRead.Model;
using System;
using System.Security.Cryptography;
using System.Text;
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
                .FirstOrDefaultAsync(x => x.Username == username);

            if (korisnik != null)
            {
                var newHash = GenerateHash(korisnik.PasswordSalt, password);
                if (newHash == korisnik.PasswordHash)
                {
                    return _mapper.Map<Korisnik>(korisnik);
                }
            }
            return null;
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
    }
}
