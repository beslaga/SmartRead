using SmartRead.Model;
using SmartRead.WinUI.Forms.Clanci;
using SmartRead.WinUI.Forms.Kategorije;
using SmartRead.WinUI.Helpers;
using System;
using System.Collections.Generic;
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
            this.Text = $"SmartRead Administracija - Welcome, {korisnik.Ime}";
        }

        private void MdiFormParentChangedHandler(object sender, EventArgs args)
        {
            var form = sender as Form;
            if (form != null)
            {
                if (form.MdiParent != null)
                {
                    logoImage.Visible = false;
                }
                else
                {
                    form.ParentChanged -= MdiFormParentChangedHandler;
                    if (this.MdiChildren.Length == 0)
                        logoImage.Visible = true;
                }
            }
        }

        private void CloseLatestChild()
        {
            if (this.MdiChildren.Length > 0)
            {
                var index = MdiChildren.Length - 1;
                MdiChildren[index].Close();
            }
        }

        private void prikažiKategorijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new KategorijeForm();
            this.IsMdiContainer = true;
            CloseLatestChild();
            frm.ParentChanged += MdiFormParentChangedHandler; frm.MdiParent = this;
            frm.Show();
            frm.WindowState = FormWindowState.Minimized;
            frm.WindowState = FormWindowState.Maximized;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
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
            }
            else
            {
                Close();
            }
        }

        private void dodajKategorijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new DodajKategorijuForm(false);
            form.ShowDialog();
        }

        private void dodajČlanakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new DodajClanakForm();
            form.ShowDialog();
        }

        private void članciToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new ClanciForm();
            this.IsMdiContainer = true;
            CloseLatestChild();
            form.ParentChanged += MdiFormParentChangedHandler; form.MdiParent = this;
            form.Show();
            form.WindowState = FormWindowState.Minimized;
            form.WindowState = FormWindowState.Maximized;
        }
    }
}
