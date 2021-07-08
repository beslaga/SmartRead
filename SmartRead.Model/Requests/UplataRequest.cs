using System;
    
namespace SmartRead.Model.Requests
{
    public class UplataRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public long? IznosUplate { get; set; }
        public string BrojKartice { get; set; }
        public string Cvc { get; set; }
        public DateTime DatumIsteka { get; set; }
        public string Mail { get; set; }
    }
}
