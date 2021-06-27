using SmartRead.Model;
using SmartRead.WinUI.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartRead.WinUI.Forms.Clanci
{
    public partial class ClanciForm : Form
    {
        private readonly APIService _service = new APIService("clanak");
        public ClanciForm()
        {
            InitializeComponent();
        }

        private async void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var clanak = (dataGridView1.DataSource as List<Clanak>)[e.RowIndex];
            if (clanak != null)
            {
                var form = new DodajClanakForm(clanak);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    await getData();
                }
            }
        }

        private async Task getData()
        {
            var clanci = await _service.Get<List<Clanak>>();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = clanci;
        }

        private async void ClanciForm_Load(object sender, System.EventArgs e)
        {
            await getData();
        }
    }
}
