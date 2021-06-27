using System.Collections.Generic;

namespace SmartRead.Model.Requests
{
    public class ClanakInsertRequest
    {
        public string Naslov { get; set; }
        public string Text { get; set; }
        public byte[] Slika { get; set; }
        public double Cijena { get; set; }
        public int AutorId { get; set; }
        public List<int> Kategorije { get; set; }
        public bool Odobren { get; } = false;
        public bool Obrisan { get; } = false;
    }
}
