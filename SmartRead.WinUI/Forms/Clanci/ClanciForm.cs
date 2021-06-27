using SmartRead.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SmartRead.WinUI.Forms.Clanci
{
    public partial class ClanciForm : Form
    {
        public ClanciForm(List<Model.Clanak> clanci)
        {
            InitializeComponent();
            
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = clanci;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var clanak = (dataGridView1.DataSource as List<Clanak>)[e.RowIndex];
            if (clanak != null)
            {
                var form = new DodajClanakForm(clanak);
                form.ShowDialog();
            }
        }
    }
}
