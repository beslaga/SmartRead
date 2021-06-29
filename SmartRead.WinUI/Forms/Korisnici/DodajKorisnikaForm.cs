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
    public partial class DodajKorisnikaForm : Form
    {
        private readonly APIService _ulogeService = new APIService("uloga");
        private readonly APIService _korisnikService = new APIService("korisnici");
        private readonly APIService _drzavaService = new APIService("drzava");
        public DodajKorisnikaForm()
        {
            InitializeComponent();
        }

        private async void DodajKorisnikaForm_Load(object sender, EventArgs e)
        {
            var uloge = await _ulogeService.Get<List<Uloga>>(null);
            clbRoles.DataSource = uloge;
            clbRoles.ValueMember = "Id";
            clbRoles.DisplayMember = "Naziv";

            var drzave = await _drzavaService.Get<List<Drzava>>(null);
            cbDrzava.DataSource = drzave;
            cbDrzava.ValueMember = "Id";
            cbDrzava.DisplayMember = "Naziv";
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

        private void txtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorPassword.SetError(txtPassword, "Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorPassword.SetError(txtPassword, "");
                e.Cancel = false;
            }
        }

        private void txtPotvrdiPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPotvrdiPassword.Text))
            {
                errorPotvrdiPassword.SetError(txtPotvrdiPassword, "Obavezno polje");
                e.Cancel = true;
            }
            else if(txtPassword.Text != txtPotvrdiPassword.Text)
            {
                errorPotvrdiPassword.SetError(txtPotvrdiPassword, "Password neispravan");
                e.Cancel = true;
            }
            else
            {
                errorPotvrdiPassword.SetError(txtPotvrdiPassword, "");
                e.Cancel = false;
            }
        }

        private async void btnSpasi_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var insertRequest = new KorisnikInsertRequest
                {
                    Ime = Convert.ToString(txtIme.Text),
                    Prezime = Convert.ToString(txtPrezime.Text),
                    Username = Convert.ToString(txtUsername.Text),
                    Mail = Convert.ToString(txtMail.Text),
                    Password = Convert.ToString(txtPassword.Text),
                    PasswordConfirmation = Convert.ToString(txtPotvrdiPassword.Text),
                    DatumRodjenja = Convert.ToDateTime(dateTimePicker1.Value),
                    Slika = ImageHelper.SystemDrawingToByteArray(pbImage.Image),
                    DrzavaId = ((Drzava)cbDrzava.SelectedItem).Id,
                    Uloge = clbRoles.CheckedItems.Cast<Uloga>().Select(i => i.Id).ToList()
                };

                var noviKorisnik = await _korisnikService.Insert<Korisnik>(insertRequest);

                if (noviKorisnik != null)
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
}
