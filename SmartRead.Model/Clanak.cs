using System.Collections.Generic;

namespace SmartRead.Model
{
    public class Clanak
    {
        public int Id { get; set; }
        public string Naslov { get; set; }
        public string Text { get; set; }
        public byte[] Slika { get; set; }
        public double Cijena { get; set; }
        public bool Odobren { get; set; }
        public bool Obrisan { get; set; }
        public Korisnik Autor { get; set; }
        public int AutorId { get; set; }
        public Korisnik Odobravatelj { get; set; }
        public int? OdobravateljId { get; set; }
        public ICollection<KorisnikPrijava> Prijave { get; set; }
        public ICollection<ClanakKategorija> Kategorije { get; set; }
    }
}
