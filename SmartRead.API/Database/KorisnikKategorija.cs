using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartRead.API.Database
{
    public class KorisnikKategorija
    {
        public int KorisnikId { get; set; }
        public int KategorijaId { get; set; }
        [ForeignKey(nameof(KorisnikId))]
        public Korisnik Korisnik { get; set; }
        [ForeignKey(nameof(KategorijaId))]
        public Kategorija Kategorija { get; set; }
        public bool Obrisan { get; set; }
        public DateTime DatumPretplate { get; set; } = DateTime.Now;
    }
}
