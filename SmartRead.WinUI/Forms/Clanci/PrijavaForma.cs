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

namespace SmartRead.WinUI.Forms.Clanci
{
    public partial class PrijavaForma : Form
    {
        private readonly KorisnikPrijava _prijava;
        private readonly APIService _service = new APIService("clanak");
        public PrijavaForma(KorisnikPrijava prijava)
        {
            InitializeComponent();
            _prijava = prijava;
        }

        private void PrijavaForma_Load(object sender, EventArgs e)
        {
            if (_prijava.Clanak.Slika.Length != 0)
            {
                pbImage.Image = ImageHelper.ByteArrayToSystemDrawing(_prijava.Clanak.Slika);
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            txtNaslov.Text = _prijava.Clanak.Naslov;
            txtSadrzaj.Text = _prijava.Clanak.Text;

            txtPrijava.Text = _prijava.Opis;
        }

        private async void btnUvazeno_Click(object sender, EventArgs e)
        {
            var result = await _service.Insert<KorisnikPrijava>(null, $"{_prijava.Id}/uvazi");
            if (result != null)
            {
                MessageBox.Show("Uspješno spašeno", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("GreŠka", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnPregledano_Click(object sender, EventArgs e)
        {
            var result = await _service.Insert<KorisnikPrijava>(null, $"{_prijava.Id}/pregledano");
            if (result != null)
            {
                MessageBox.Show("Uspješno spašeno", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("GreŠka", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
