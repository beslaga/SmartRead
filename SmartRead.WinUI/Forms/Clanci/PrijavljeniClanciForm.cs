using SmartRead.Model;
using SmartRead.WinUI.Helpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartRead.WinUI.Forms.Clanci
{
    public partial class PrijavljeniClanciForm : Form
    {
        private readonly APIService _service = new APIService("clanak");
        public PrijavljeniClanciForm()
        {
            InitializeComponent();
        }

        private async void PrijavljeniClanciForm_Load(object sender, EventArgs e)
        {
            await getData();
        }

        private async Task getData()
        {
            var prijave = await _service.Get<List<KorisnikPrijava>>(null, "prijave");
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = prijave;
        }

        private async void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var prijava = (dataGridView1.DataSource as List<KorisnikPrijava>)[e.RowIndex];
            if (prijava != null)
            {
                var form = new PrijavaForma(prijava);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    await getData();
                }
            }
        }
    }
}
