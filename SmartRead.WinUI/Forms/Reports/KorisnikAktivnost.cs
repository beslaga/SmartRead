using SmartRead.Model;
using SmartRead.WinUI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartRead.WinUI.Forms.Reports
{
    public class Data
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }
        public int BrojPosjeta { get; set; }
    }
    public partial class KorisnikAktivnost : Form
    {
        private readonly APIService _service = new APIService("pregled");
        public KorisnikAktivnost()
        {
            InitializeComponent();
        }

        private async Task getData()
        {
            var korisnici = await _service.Get<List<AktivnostKorisnik>>(null, "korisnik-aktivnost");

            var list = new List<Data>();
            foreach (var item in korisnici)
            {
                list.Add(new Data
                {
                    Ime = item.Korisnik.Ime,
                    Prezime = item.Korisnik.Prezime,
                    Username = item.Korisnik.Username,
                    BrojPosjeta = item.BrojPosjeta
                });
            }

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = list;
        }

        private async void KorisnikAktivnost_Load(object sender, EventArgs e)
        {
            await getData();
        }
    }
}
