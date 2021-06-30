using SmartRead.Model;
using SmartRead.Model.Requests;
using SmartRead.WinUI.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SmartRead.WinUI.Forms.Korisnici
{
    public partial class UrediKorisnikaForm : Form
    {
        private readonly Korisnik korisnik;
        private readonly APIService _ulogeService = new APIService("uloga");
        private readonly APIService _korisnikService = new APIService("korisnici");
        private readonly APIService _drzavaService = new APIService("drzava");
        public UrediKorisnikaForm(Korisnik korisnik)
        {
            this.korisnik = korisnik;
            InitializeComponent();
        }

        private async void btnSpasi_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                try
                {
                    var odabraneUloge = clbRoles.CheckedItems.Cast<Uloga>().Select(i => i.Id).ToList();

                    List<int> neodabraneUloge = new List<int>();
                    for (int i = 0; i < clbRoles.Items.Count; i++)
                    {
                        if (!clbRoles.GetItemChecked(i))
                        {
                            int id = clbRoles.Items.Cast<Uloga>().ToList()[i].Id;
                            neodabraneUloge.Add(id);
                        }
                    }

                    var request = new KorisnikUpdateRequest
                    {
                        Ime = Convert.ToString(txtIme.Text),
                        Prezime = Convert.ToString(txtPrezime.Text),
                        Username = Convert.ToString(txtUsername.Text),
                        Mail = Convert.ToString(txtMail.Text),
                        DrzavaId = ((Drzava)cbDrzava.SelectedItem).Id,
                        DatumRodjenja = dateTimePicker1.Value,
                        Slika = pbImage.Image != null ? ImageHelper.SystemDrawingToByteArray(pbImage.Image) : null,
                        Uloge = odabraneUloge,
                        UlogeZaObrisati = neodabraneUloge
                    };

                    await _korisnikService.Update<Korisnik>(korisnik.Id, request);

                    MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private async void btnReset_Click(object sender, EventArgs e)
        {
            var password = await _korisnikService.Insert<PasswordReset>(null, korisnik.Id + "/reset-password");
            MessageBox.Show($"Novi password {password.Password}", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var response = await _korisnikService.Delete<bool>(korisnik.Id);

            if (response)
            {
                MessageBox.Show("Uspješno obrisan korisnik", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("GreŠka", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void UrediKorisnikaForm_Load(object sender, EventArgs e)
        {
            var drzave = await _drzavaService.Get<List<Drzava>>(null);
            cbDrzava.DataSource = drzave;
            cbDrzava.ValueMember = "Id";
            cbDrzava.DisplayMember = "Naziv";

            txtIme.Text = korisnik.Ime;
            txtPrezime.Text = korisnik.Prezime;
            txtUsername.Text = korisnik.Username;
            txtMail.Text = korisnik.Mail;
            cbDrzava.SelectedItem = korisnik.Drzava;
            dateTimePicker1.Value = korisnik.DatumRodjenja;

            if (korisnik.Slika.Length != 0)
            {
                pbImage.Image = ImageHelper.ByteArrayToSystemDrawing(korisnik.Slika);
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            var uloge = await _ulogeService.Get<List<Uloga>>(null);
            clbRoles.DataSource = uloge;
            clbRoles.ValueMember = "Id";
            clbRoles.DisplayMember = "Naziv";


            //Check users roles
            var ulogeLista = clbRoles.Items.Cast<Uloga>().Select(i => i.Id).ToList();
            foreach (var uloga in korisnik.Uloge)
            {
                for (int i = 0; i < clbRoles.Items.Count; i++)
                {
                    if (ulogeLista[i] == uloga.UlogaId)
                    {
                        clbRoles.SetItemChecked(i, true);
                    }
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

        private void txtIme_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtIme.Text))
            {
                errorIme.SetError(txtIme, "Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorIme.SetError(txtIme, "");
                e.Cancel = false;
            }
        }

        private void txtPrezime_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrezime.Text))
            {
                errorPrezime.SetError(txtPrezime, "Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorPrezime.SetError(txtPrezime, "");
                e.Cancel = false;
            }
        }

        private void txtUsername_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                errorUsername.SetError(txtUsername, "Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorUsername.SetError(txtUsername, "");
                e.Cancel = false;
            }
        }

        private void txtMail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMail.Text))
            {
                errorMail.SetError(txtMail, "Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorMail.SetError(txtMail, "");
                e.Cancel = false;
            }
        }
    }
}
