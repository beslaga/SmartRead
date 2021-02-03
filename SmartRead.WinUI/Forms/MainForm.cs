using SmartRead.WinUI.Helpers;
using System;
using System.Windows.Forms;

namespace SmartRead.WinUI.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            updateUI();
        }

        private void updateUI()
        {
            Show();
            var korisnik = APIService.PrijavljeniKorisnik;
            if (korisnik == null)
            {
                this.Close();
                return;
            }
            labelUser.Text = $"Welcome, {korisnik.Ime}";
        }

        private void buttonSignOut_Click(object sender, EventArgs e)
        {
            foreach (var child in MdiChildren)
            {
                child.Close();
            }

            Hide();

            var loginForm = new LoginForm();

            if (loginForm.ShowDialog() == DialogResult.OK) 
            {
                updateUI();
            } else
            {
                Close();
            }
        }
    }
}
