using System.Collections.Generic;

namespace SmartRead.Model
{
    public class Administrator
    {
        public int Id { get; set; }
        public Korisnik Korisnik { get; set; }
        public ICollection<Clanak> OdobreniClanci { get; set; }
    }
}
