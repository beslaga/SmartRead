using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SmartRead.API.Database.Context;
using SmartRead.API.Helpers;
using SmartRead.Model;
using SmartRead.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
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
                .Include(i => i.Likes)
                .ThenInclude(i => i.Clanak)
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

        public override async Task<List<Korisnik>> Get(KorisnikSearchRequest search)
        {
            var list = await _context.Set<Database.Korisnik>()
                .AsNoTracking()
                .Include(i => i.Uloge)
                    .ThenInclude(i => i.Uloga)
                .Include(i => i.Drzava)
                .ToListAsync();


            return _mapper.Map<List<Korisnik>>(list);
        }

        public override async Task<Korisnik> Insert(KorisnikInsertRequest request)
        {
            if (request.Password != request.PasswordConfirmation)
            {
                throw new Exception("Passwordi se ne podudaraju!");
            }

            if (!await IsMailUnique(request.Mail))
            {
                throw new UserException("Mail je zauzet!");
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

        public async Task<PasswordReset> ResetPassword(int id)
        {
            var entity = await _context.Korisnici.FindAsync(id);

            if (entity != null)
            {
                var newPassword = GeneratePassword(16);
                entity.PasswordSalt = HashHelper.GenerateSalt();
                entity.PasswordHash = HashHelper.GenerateHash(entity.PasswordSalt, newPassword);

                await _context.SaveChangesAsync();
                return new PasswordReset
                {
                    Password = newPassword
                };
            }

            return null;
        }

        private string GeneratePassword(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public override async Task<Korisnik> Update(int id, KorisnikUpdateRequest request)
        {
            var entity = await _context.Korisnici.FindAsync(id);

            if (entity.Mail != request.Mail && await IsMailUnique(request.Mail) == false)
            {
                throw new UserException("Mail je zauzet!");
            }

            if (entity.Username != request.Username && await IsUsernameUnique(request.Username) == false)
            {
                throw new UserException("Username je zauzet!");
            }

            _context.Korisnici.Attach(entity);
            _context.Korisnici.Update(entity);

            foreach (var ulogaId in request.Uloge)
            {
                var uloga = await _context.KorisnikUloge
                    .Where(i => i.UlogaId == ulogaId && i.KorisnikId == id)
                    .SingleOrDefaultAsync();

                if (uloga == null)
                {
                    var novaUloga = new Database.KorisnikUloga
                    {
                        KorisnikId = id,
                        UlogaId = ulogaId
                    };
                    await _context.Set<Database.KorisnikUloga>().AddAsync(novaUloga);
                }
            }


            foreach (var ulogaId in request.UlogeZaObrisati)
            {
                var uloga = await _context.KorisnikUloge
                    .Where(i => i.UlogaId == ulogaId && i.KorisnikId == id)
                    .SingleOrDefaultAsync();

                if (uloga != null)
                {
                    _context.Set<Database.KorisnikUloga>().Remove(uloga);
                }
            }

            _mapper.Map(request, entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<Korisnik>(entity);
        }

        public async Task<List<Clanak>> Likes(int id)
        {
            var list = await _context.Likes
                .Include(i => i.Clanak)
                .Where(i => i.KorisnikId == id)
                .Select(i => i.Clanak)
                .ToListAsync();

            return _mapper.Map<List<Clanak>>(list);
        }
    }
}
