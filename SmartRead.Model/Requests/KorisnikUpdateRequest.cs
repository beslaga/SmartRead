using System;
using System.Collections.Generic;

namespace SmartRead.Model.Requests
{
    public class KorisnikUpdateRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }
        public string Mail { get; set; }
        public int DrzavaId { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public byte[] Slika { get; set; }
        public List<int> Uloge { get; set; } = new List<int>();
        public List<int> UlogeZaObrisati { get; set; } = new List<int>();
    }
}
