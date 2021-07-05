using System;
using System.Collections.Generic;

namespace SmartRead.Model
{
    public class Korisnik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string ImePrezime { get { return Ime + " " + Prezime; } }
        public string Mail { get; set; }
        public string Username { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public DateTime DatumRegistracije { get; set; }
        public double Kredit { get; set; }
        public bool Obrisan { get; set; }
        public byte[] Slika { get; set; }
        public Drzava Drzava { get; set; }
        public ICollection<Uplata> Uplate { get; set; }
        public ICollection<Clanak> Clanci { get; set; }
        public ICollection<KorisnikKategorija> PretplaceneKategorije { get; set; }
        public ICollection<KorisnikPrijava> PrijavljeniClanci { get; set; }
        public ICollection<KorisnikUloga> Uloge { get; set; }
        public ICollection<Like> Likes { get; set; }

    }
}
