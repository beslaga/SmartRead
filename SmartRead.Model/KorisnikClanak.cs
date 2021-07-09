namespace SmartRead.Model
{
    public class KorisnikClanak
    {
        public int KorisnikId { get; set; }
        public int ClanakId { get; set; }
        public Korisnik Korisnik { get; set; }
        public Clanak Clanak { get; set; }
        public int BrojPosjeta { get; set; }
        public bool Kupljen { get; set; }
        public int Ocjena { get; set; }
    }
}
