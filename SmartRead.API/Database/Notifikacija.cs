namespace SmartRead.API.Database
{
    public class Notifikacija
    {
        public int KorisnikId { get; set; }
        public int ClanakId { get; set; }
        public Korisnik Korisnik { get; set; }
        public Clanak Clanak { get; set; }
    }
}
