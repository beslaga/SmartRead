namespace SmartRead.API.Database
{
    public class KorisnikUloga
    {
        public int KorisnikId { get; set; }
        public Korisnik Korisnik { get; set; }
        public int UlogaId { get; set; }
        public Uloga Uloga { get; set; }
    }
}
