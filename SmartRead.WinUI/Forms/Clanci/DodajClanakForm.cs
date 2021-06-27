using SmartRead.Model;
using SmartRead.Model.Requests;
using SmartRead.WinUI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SmartRead.WinUI.Forms.Clanci
{
    public partial class DodajClanakForm : Form
    {
        private readonly APIService _kategorijeApiService = new APIService("kategorije");
        private readonly APIService _clanakApiService = new APIService("clanak");
        public DodajClanakForm()
        {
            InitializeComponent();
            AutoScroll = true;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
            {
                var kategorije = lbKategorije.Items.Cast<Kategorija>().Select(i => i.Id).ToList();

                var request = new ClanakInsertRequest()
                {
                    Naslov = Convert.ToString(textBox1.Text),
                    Text = Convert.ToString(richTextBox1.Text),
                    Cijena = Convert.ToDouble(numericUpDown1.Value),
                    Kategorije = kategorije,
                    AutorId = APIService.PrijavljeniKorisnik.Id,
                    Slika = ImageHelper.SystemDrawingToByteArray(pbImage.Image),
                };

                var clanak = await _clanakApiService.Insert<Clanak>(request);

                if (clanak != null)
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

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog
            {
                Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif"
            };
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
                pbImage.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void BindComboList<T>(ComboBox comboBox, List<T> list)
        {
            comboBox.DataSource = list;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "Naziv";
        }

        private void BindListBox<T>(ListBox listBox, IList<T> list)
        {
            listBox.DataSource = null;
            listBox.ValueMember = "Id";
            listBox.DisplayMember = "Naziv";

            if (list != null)
            {
                foreach (var item in list)
                {
                    listBox.Items.Add(item);
                }
            }

        }

        private async void DodajClanakForm_Load(object sender, EventArgs e)
        {
            var kategorije = await _kategorijeApiService.Get<List<Kategorija>>();
            BindComboList(cbKategorija, kategorije);
            BindListBox<Kategorija>(lbKategorije, null);
        }

        private void btnDodajKategoriju_Click(object sender, EventArgs e)
        {
            var kategorija = cbKategorija.SelectedItem;

            if (!lbKategorije.Items.Contains(kategorija))
            {
                lbKategorije.Items.Add(kategorija);
            }
        }

        private void btnUkloniKategoriju_Click(object sender, EventArgs e)
        {
            var kategorija = lbKategorije.SelectedItem;
            lbKategorije.Items.Remove(kategorija);
        }

        private void Naslov_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
                e.Cancel = false;
            }
        }

        private void Sadrzaj_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                errorProvider2.SetError(richTextBox1, "Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider2.SetError(richTextBox1, "");
                e.Cancel = false;
            }
        }
    }
}
