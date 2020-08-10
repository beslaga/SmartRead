using System;

namespace SmartRead.Model
{
    public class KorisnikKategorija
    {
        public int KorisnikId { get; set; }
        public int KategorijaId { get; set; }
        public Korisnik Korisnik { get; set; }
        public Kategorija Kategorija { get; set; }
        public bool Obrisan { get; set; }
        public DateTime DatumPretplate { get; set; } = DateTime.Now;
    }
}
