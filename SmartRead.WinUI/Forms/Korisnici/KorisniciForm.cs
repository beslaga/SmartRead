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

namespace SmartRead.WinUI.Forms.Korisnici
{
    public partial class KorisniciForm : Form
    {
        private readonly APIService _service = new APIService("korisnici");
        public KorisniciForm()
        {
            InitializeComponent();
        }

        private async Task getData()
        {
            var korisnici = await _service.Get<List<Model.Korisnik>>();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = korisnici;
        }

        private async void KorisniciForm_Load(object sender, EventArgs e)
        {
            await getData();
        }

        private async void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var korisnik = (dataGridView1.DataSource as List<Korisnik>)[e.RowIndex];
            if (korisnik != null)
            {
                var form = new UrediKorisnikaForm(korisnik);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    await getData();
                }
            }
        }
    }
}
