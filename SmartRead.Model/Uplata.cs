namespace SmartRead.Model
{
    public class Uplata
    {
        public int Id { get; set; }
        public float Iznos { get; set; }
        public string Opis { get; set; }
        public Korisnik Korisnik { get; set; }
    }
}
