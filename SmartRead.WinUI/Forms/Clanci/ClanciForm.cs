using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
