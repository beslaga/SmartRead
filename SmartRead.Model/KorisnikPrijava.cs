using System;

namespace SmartRead.Model
{
    public class KorisnikPrijava
    {
        public int Id { get; set; }
        public string Opis { get; set; }
        public DateTime VrijemePrijave { get; set; }
        public bool Pregledano { get; set; }
        public bool Uvazeno { get; set; }
        public Korisnik Korisnik { get; set; }
        public int KorisnikId { get; set; }
        public Clanak Clanak { get; set; }
        public int ClanakId { get; set; }
    }
}
