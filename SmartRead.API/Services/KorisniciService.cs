using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SmartRead.API.Database.Context;
using SmartRead.API.Helpers;
using SmartRead.Model;
using SmartRead.Model.Requests;
using System;
using System.Threading.Tasks;

namespace SmartRead.API.Services
{
    public class KorisniciService : 
        CrudService<Korisnik, KorisnikSearchRequest, Database.Korisnik, KorisnikInsertRequest, KorisnikUpdateRequest>,
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

        public override async Task<Korisnik> Insert(KorisnikInsertRequest request)
        {
            if (request.Password != request.PasswordConfirmation)
            {
                throw new Exception("Passwordi se ne podudaraju!");
            }

            if (!await IsMailUnique(request.Mail))
            {
                throw new UserException("Email je zauzet!");
            }

            if (!await IsUsernameUnique(request.Username))
            {
                throw new UserException("Username je zauzet!");
            }

            var entity = _mapper.Map<Database.Korisnik>(request);
            entity.PasswordSalt = HashHelper.GenerateSalt();
            entity.PasswordHash = HashHelper.GenerateHash(entity.PasswordSalt, request.Password);

            await _context.Korisnici.AddAsync(entity);
            await _context.SaveChangesAsync();

            foreach (var ulogaId in request.Uloge)
            {
                var uloga = new Database.KorisnikUloga
                {
                    KorisnikId = entity.Id,
                    UlogaId = ulogaId
                };

                await _context.KorisnikUloge.AddAsync(uloga);
            }
            await _context.SaveChangesAsync();

            return _mapper.Map<Korisnik>(entity);
        }

        public async Task<bool> IsMailUnique(string Mail)
        {
            return !await _context.Korisnici.AnyAsync(i => i.Mail == Mail);
        }

        public async Task<bool> IsUsernameUnique(string Username)
        {
            return !await _context.Korisnici.AnyAsync(i => i.Username == Username);
        }
    }
}
