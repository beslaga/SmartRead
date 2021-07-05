namespace SmartRead.Model
{
    public class Like
    {
        public int KorisnikId { get; set; }
        public Korisnik Korisnik { get; set; }
        public int ClanakId { get; set; }
        public Clanak Clanak { get; set; }
    }
}
