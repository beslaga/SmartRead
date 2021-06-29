using System;
using System.Collections.Generic;

namespace SmartRead.Model.Requests
{
    public class KorisnikInsertRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Mail { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordConfirmation { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public int DrzavaId { get; set; }
        public byte[] Slika { get; set; }
        public List<int> Uloge { get; set; }
    }
}
