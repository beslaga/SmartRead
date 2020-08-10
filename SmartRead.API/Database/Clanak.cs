using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartRead.API.Database
{
    public class Clanak
    {
        public Clanak()
        {
            Prijave = new HashSet<KorisnikPrijava>();
        }
        [Key]
        public int Id { get; set; }
        public string Naslov { get; set; }
        public string Text { get; set; }
        public byte[] Slika { get; set; }
        public double Cijena { get; set; }
        public bool Odobren { get; set; }
        public bool Obrisan { get; set; }
        [ForeignKey(nameof(AutorId))]
        public Korisnik Autor { get; set; }
        public int AutorId { get; set; }
        [ForeignKey(nameof(OdobravateljId))]
        public Administrator Odobravatelj { get; set; }
        public int? OdobravateljId { get; set; }

        public ICollection<KorisnikPrijava> Prijave { get; set; }
    }
}
