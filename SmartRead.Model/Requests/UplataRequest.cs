namespace SmartRead.Model.Requests
{
    public class UplataRequest
    {
        public long? IznosUplate { get; set; }
        public string BrojKartice { get; set; }
        public string Cvc { get; set; }
        public int MjesecIsteka { get; set; }
        public int GodinaIsteka { get; set; }
    }
}
