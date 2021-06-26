using SmartRead.WinUI.Helpers;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SmartRead.WinUI.Forms.Kategorije
{
    public partial class KategorijeForm : Form
    {
        private readonly APIService _service = new APIService("kategorije");
        public KategorijeForm()
        {
            InitializeComponent();
            getData();
        }

        private async void getData()
        {
            var kategorijeList = await _service.Get<List<Model.Kategorija>>();
            kategorijeGridView.AutoGenerateColumns = false;
            kategorijeGridView.DataSource = kategorijeList;
        }

        private void kategorijeGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var kategorija = (kategorijeGridView.DataSource as List<Model.Kategorija>)[e.RowIndex];
            if (kategorija == null) { return; }

            var form = new DodajKategorijuForm(true, kategorija);

            if (form.ShowDialog() == DialogResult.OK)
            {
                getData();
            }

        }

        private void buttonDodaj_Click(object sender, System.EventArgs e)
        {
            var form = new DodajKategorijuForm(false);

            if (form.ShowDialog() == DialogResult.OK)
            {
                getData();
            }
        }
    }
}
