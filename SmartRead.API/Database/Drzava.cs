using System.ComponentModel.DataAnnotations;

namespace SmartRead.API.Database
{
    public class Drzava
    {
        [Key]
        public int Id { get; set; }
        public string Naziv { get; set; }
    }
}
