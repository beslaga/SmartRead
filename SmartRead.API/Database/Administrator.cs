using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartRead.API.Database
{
    public class Administrator
    {
        public Administrator()
        {
            OdobreniClanci = new HashSet<Clanak>();
        }

        [ForeignKey("Korisnik")]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public Korisnik Korisnik { get; set; }

        public ICollection<Clanak> OdobreniClanci { get; set; }
    }
}
