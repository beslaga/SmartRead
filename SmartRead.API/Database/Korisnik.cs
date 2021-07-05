using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartRead.API.Database
{
    public class Korisnik
    {
        public Korisnik()
        {
            Uplate = new HashSet<Uplata>();
            Clanci = new HashSet<Clanak>();
            PretplaceneKategorije = new HashSet<KorisnikKategorija>();
            PrijavljeniClanci = new HashSet<KorisnikPrijava>();
            Uloge = new HashSet<KorisnikUloga>();
            Likes = new HashSet<Like>();
        }

        [Key]
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Mail { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public DateTime DatumRegistracije { get; set; } = DateTime.Now;
        public double Kredit { get; set; }
        public bool Obrisan { get; set; }
        public byte[] Slika { get; set; }
        [ForeignKey(nameof(DrzavaId))]
        public Drzava Drzava { get; set; }
        public int DrzavaId { get; set; }

        public ICollection<Uplata> Uplate { get; set; }
        public ICollection<Clanak> Clanci { get; set; }
        public ICollection<KorisnikKategorija> PretplaceneKategorije { get; set; }
        public ICollection<KorisnikPrijava> PrijavljeniClanci { get; set; }
        public ICollection<KorisnikUloga> Uloge { get; set; }
        public ICollection<Like> Likes { get; set; }
    }
}
