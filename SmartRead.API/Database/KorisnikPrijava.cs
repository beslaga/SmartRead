using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartRead.API.Database
{
    public class KorisnikPrijava
    {
        [Key]
        public int Id { get; set; }
        public string Opis { get; set; }
        public DateTime VrijemePrijave { get; set; } = DateTime.Now;
        public bool Pregledano { get; set; }
        public bool Uvazeno { get; set; }
        [ForeignKey(nameof(KorisnikId))]
        public Korisnik Korisnik { get; set; }
        public int KorisnikId { get; set; }
        [ForeignKey(nameof(ClanakId))]
        public Clanak Clanak { get; set; }
        public int ClanakId { get; set; }
    }
}
