namespace SmartRead.API.Database
{
    public class ClanakKategorija
    {
        public int ClanakId { get; set; }
        public Clanak Clanak { get; set; }
        public int KategorijaId { get; set; }
        public Kategorija Kategorija { get; set; }
    }
}
