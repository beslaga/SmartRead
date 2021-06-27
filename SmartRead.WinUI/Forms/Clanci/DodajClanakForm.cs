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

        private readonly Clanak clanak;

        public DodajClanakForm(Clanak clanak = null)
        {
            InitializeComponent();
            AutoScroll = true;

            this.clanak = clanak;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
            {
                var kategorije = lbKategorije.Items.Cast<Kategorija>().Select(i => i.Id).ToList();



                Clanak noviClanak = null;

                if(clanak != null)
                {
                    var obrisaneKategorije = clanak.Kategorije
                       .Where(i => !kategorije.Any(j => j.Equals(i.KategorijaId)))
                       .Select(i => i.KategorijaId)
                       .ToList();

                    var updateRequest = new ClanakUpdateRequest
                    {
                        Naslov = Convert.ToString(txtNaslov.Text),
                        Text = Convert.ToString(txtSadrzaj.Text),
                        Cijena = Convert.ToDouble(numCijena.Value),
                        Kategorije = kategorije,
                        ObrisaneKategorije = obrisaneKategorije,
                        AutorId = APIService.PrijavljeniKorisnik.Id,
                        Slika = ImageHelper.SystemDrawingToByteArray(pbImage.Image),
                    };

                    noviClanak = await _clanakApiService.Update<Clanak>(clanak.Id, updateRequest);
                }
                else
                {
                    var insertRequest = new ClanakInsertRequest
                    {
                        Naslov = Convert.ToString(txtNaslov.Text),
                        Text = Convert.ToString(txtSadrzaj.Text),
                        Cijena = Convert.ToDouble(numCijena.Value),
                        Kategorije = kategorije,
                        AutorId = APIService.PrijavljeniKorisnik.Id,
                        Slika = ImageHelper.SystemDrawingToByteArray(pbImage.Image),
                    };

                    noviClanak = await _clanakApiService.Insert<Clanak>(insertRequest);
                }

                if (noviClanak != null)
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

            if (clanak != null)
            {
                txtNaslov.Text = clanak.Naslov;
                txtSadrzaj.Text = clanak.Text;
                numCijena.Value = (decimal)clanak.Cijena;

                BindListBox(lbKategorije, clanak.Kategorije.Select(i => i.Kategorija).ToList());

                if (clanak.Slika.Length != 0)
                {
                    pbImage.Image = ImageHelper.ByteArrayToSystemDrawing(clanak.Slika);
                    pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
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
            if(string.IsNullOrEmpty(txtNaslov.Text))
            {
                errorProviderNaslov.SetError(txtNaslov, "Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorProviderNaslov.SetError(txtNaslov, "");
                e.Cancel = false;
            }
        }

        private void Sadrzaj_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSadrzaj.Text))
            {
                errorProviderSadrzaj.SetError(txtSadrzaj, "Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorProviderSadrzaj.SetError(txtSadrzaj, "");
                e.Cancel = false;
            }
        }
    }
}
