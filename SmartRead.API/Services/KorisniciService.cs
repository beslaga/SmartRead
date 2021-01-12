using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SmartRead.API.Database.Context;
using SmartRead.Model;
using SmartRead.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace SmartRead.API.Services
{
    public class KorisniciService : IKorisniciService
    {
        private readonly SmartReadContext _context;
        private readonly IMapper _mapper;

        private Korisnik _prijavljeniKorisnik;


        public KorisniciService(SmartReadContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Korisnik Autentifikacija(string username, string password)
        {
            var korisnik = _context.Korisnici.Include(x => x.Administrator).Include(x => x.Drzava).FirstOrDefault(x => x.Username == username);

            if (korisnik == null) { return null; }
            var newHash = GenerateHash(korisnik.PasswordSalt, password);
            if (newHash == korisnik.PasswordHash)
            {
                return _mapper.Map<Korisnik>(korisnik);
            }
            return null;
        }

        public List<Model.Korisnik> Get()
        {
            return _mapper.Map<List<Model.Korisnik>>(_context.Korisnici.Include(x => x.Drzava).Include(x => x.Administrator).ToList());
        }

        public Model.Korisnik Insert(KorisniciInsertRequest request)
        {
            throw new System.NotImplementedException();
        }

        public void SetPrijavljeniKorisnik(Korisnik korisnik)
        {
            _prijavljeniKorisnik = korisnik;
        }
        public Korisnik GetPrijavljeniKorisnik()
        {
            return _prijavljeniKorisnik;
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

        public Korisnik GetTrenutniKorisnik()
        {
            return _prijavljeniKorisnik;
        }
    }
}
