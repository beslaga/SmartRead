using System.ComponentModel.DataAnnotations.Schema;

namespace SmartRead.API.Database
{
    public class KorisnikClanak
    {
        public int KorisnikId { get; set; }
        public int ClanakId { get; set; }
        [ForeignKey(nameof(KorisnikId))]
        public Korisnik Korisnik { get; set; }
        [ForeignKey(nameof(ClanakId))]
        public Clanak Clanak { get; set; }
        public int BrojPosjeta { get; set; }
    }
}
