using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartRead.API.Database
{
    public class Uplata
    {
        [Key]
        public int Id { get; set; }
        public float Iznos { get; set; }
        public string Opis { get; set; }
        [ForeignKey(nameof(KorisnikId))]
        public Korisnik Korisnik { get; set; }
        public int KorisnikId { get; set; }
    }
}
