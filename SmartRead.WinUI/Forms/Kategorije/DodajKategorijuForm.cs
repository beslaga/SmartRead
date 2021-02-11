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

namespace SmartRead.WinUI.Forms.Kategorije
{
    public partial class DodajKategorijuForm : Form
    {
        private bool isEditing;
        private Model.Kategorija kategorija;
        private readonly APIService _service = new APIService("kategorije");

        public DodajKategorijuForm(bool isEditing, Model.Kategorija kategorija = null)
        {
            InitializeComponent();
            this.isEditing = isEditing;
            this.kategorija = kategorija;

            var titleText = isEditing ? "Uredi Kategoriju" : "Dodaj Kategoriju";
            titleLabel.Text = titleText;
            Text = titleText;

            if (isEditing)
            {
                nameTextBox.Text = kategorija.Naziv;
                obrisanCheckBox.Checked = kategorija.Obrisan;
            } else
            {
                obrisanCheckBox.Hide();
            }
        }

        private async void dodajButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(nameTextBox.Text)) 
            {
                MessageBox.Show("Naziv ne smije biti prazan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Model.Kategorija novaKategorija;
            if (isEditing && kategorija != null)
            {
                novaKategorija = await _service.Update<Model.Kategorija>((int)kategorija.Id, new Model.Requests.KategorijaInsertRequest { Naziv = nameTextBox.Text, Obrisan = obrisanCheckBox.Checked });
            } else
            {
                novaKategorija = await _service.Insert<Model.Kategorija>(nameTextBox.Text);
            }

            if (novaKategorija != null)
            {
                MessageBox.Show("Uspješno spašeno", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            } else
            {
                MessageBox.Show("GreŠka", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
