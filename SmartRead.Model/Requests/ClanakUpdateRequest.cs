using System.Collections.Generic;

namespace SmartRead.Model.Requests
{
    public class ClanakUpdateRequest
    {
        public string Naslov { get; set; }
        public string Text { get; set; }
        public byte[] Slika { get; set; }
        public double Cijena { get; set; }
        public int AutorId { get; set; }
        public List<int> Kategorije { get; set; }
        public List<int> ObrisaneKategorije { get; set; }

    }
}
