using System.ComponentModel.DataAnnotations;

namespace SmartRead.API.Database
{
    public class Kategorija
    {
        [Key]
        public int Id { get; set; }
        public int Naziv { get; set; }
    }
}
