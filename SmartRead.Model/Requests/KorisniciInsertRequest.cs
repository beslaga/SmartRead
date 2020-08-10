using System;
using System.ComponentModel.DataAnnotations;

namespace SmartRead.Model.Requests
{
    public class KorisniciInsertRequest
    {
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        [Required]
        public string Mail { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string PasswordConfirmation { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public int DrzavaId { get; set; }
        public byte[] Slika { get; set; }
    }
}
