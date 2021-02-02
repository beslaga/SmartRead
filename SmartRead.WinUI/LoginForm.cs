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

namespace SmartRead.WinUI
{
    public partial class LoginForm : Form
    {
        private readonly APIService _serviceLogin = new APIService("login");

        public LoginForm()
        {
            InitializeComponent();
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text.isEmpty() || passwordTextBox.Text.isEmpty())
            {
                MessageBox.Show("Username i Password su obavezni.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Cursor = Cursors.WaitCursor;
                APIService.PrijavljeniKorisnik = await _serviceLogin.Insert<Model.Korisnik>(new Model.Requests.LoginRequest { username = usernameTextBox.Text, password = passwordTextBox.Text });
                Cursor = Cursors.Default;
                if (APIService.PrijavljeniKorisnik == null)
                {
                    MessageBox.Show("Pogrešan username i/ili password.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (APIService.PrijavljeniKorisnik.Administrator == null)
                {
                    MessageBox.Show("Nemate permisije za pristup admin aplikaciji.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    APIService.PrijavljeniKorisnik = null;
                }
                else
                {
                    APIService.Username = usernameTextBox.Text;
                    APIService.Password = passwordTextBox.Text;
                    DialogResult = DialogResult.OK;
                }

            } 
            catch(Exception ex) 
            {
                MessageBox.Show("Greška", $"Desila se greška: {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
