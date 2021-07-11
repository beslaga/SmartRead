
namespace SmartRead.WinUI.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.kategorijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikažiKategorijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKategorijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.članciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.članciToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajČlanakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikažiKorisnikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoImage = new System.Windows.Forms.PictureBox();
            this.prijavljeniČlanciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategorijeToolStripMenuItem,
            this.članciToolStripMenuItem,
            this.korisniciToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(882, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // kategorijeToolStripMenuItem
            // 
            this.kategorijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikažiKategorijeToolStripMenuItem,
            this.dodajKategorijuToolStripMenuItem});
            this.kategorijeToolStripMenuItem.Name = "kategorijeToolStripMenuItem";
            this.kategorijeToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.kategorijeToolStripMenuItem.Text = "Kategorije";
            // 
            // prikažiKategorijeToolStripMenuItem
            // 
            this.prikažiKategorijeToolStripMenuItem.Name = "prikažiKategorijeToolStripMenuItem";
            this.prikažiKategorijeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.prikažiKategorijeToolStripMenuItem.Text = "Prikaži Kategorije";
            this.prikažiKategorijeToolStripMenuItem.Click += new System.EventHandler(this.prikažiKategorijeToolStripMenuItem_Click);
            // 
            // dodajKategorijuToolStripMenuItem
            // 
            this.dodajKategorijuToolStripMenuItem.Name = "dodajKategorijuToolStripMenuItem";
            this.dodajKategorijuToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.dodajKategorijuToolStripMenuItem.Text = "Dodaj Kategoriju";
            this.dodajKategorijuToolStripMenuItem.Click += new System.EventHandler(this.dodajKategorijuToolStripMenuItem_Click);
            // 
            // članciToolStripMenuItem
            // 
            this.članciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.članciToolStripMenuItem1,
            this.dodajČlanakToolStripMenuItem,
            this.prijavljeniČlanciToolStripMenuItem});
            this.članciToolStripMenuItem.Name = "članciToolStripMenuItem";
            this.članciToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.članciToolStripMenuItem.Text = "Članci";
            // 
            // članciToolStripMenuItem1
            // 
            this.članciToolStripMenuItem1.Name = "članciToolStripMenuItem1";
            this.članciToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.članciToolStripMenuItem1.Text = "Prikaži Članke";
            this.članciToolStripMenuItem1.Click += new System.EventHandler(this.članciToolStripMenuItem1_Click);
            // 
            // dodajČlanakToolStripMenuItem
            // 
            this.dodajČlanakToolStripMenuItem.Name = "dodajČlanakToolStripMenuItem";
            this.dodajČlanakToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajČlanakToolStripMenuItem.Text = "Dodaj Članak";
            this.dodajČlanakToolStripMenuItem.Click += new System.EventHandler(this.dodajČlanakToolStripMenuItem_Click);
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikažiKorisnikeToolStripMenuItem,
            this.dodajKorisnikaToolStripMenuItem});
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // prikažiKorisnikeToolStripMenuItem
            // 
            this.prikažiKorisnikeToolStripMenuItem.Name = "prikažiKorisnikeToolStripMenuItem";
            this.prikažiKorisnikeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.prikažiKorisnikeToolStripMenuItem.Text = "Prikaži Korisnike";
            this.prikažiKorisnikeToolStripMenuItem.Click += new System.EventHandler(this.prikažiKorisnikeToolStripMenuItem_Click);
            // 
            // dodajKorisnikaToolStripMenuItem
            // 
            this.dodajKorisnikaToolStripMenuItem.Name = "dodajKorisnikaToolStripMenuItem";
            this.dodajKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.dodajKorisnikaToolStripMenuItem.Text = "Dodaj Korisnika";
            this.dodajKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.dodajKorisnikaToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // logoImage
            // 
            this.logoImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoImage.Image = global::SmartRead.WinUI.Properties.Resources.SmartReadLogo;
            this.logoImage.Location = new System.Drawing.Point(0, 24);
            this.logoImage.Name = "logoImage";
            this.logoImage.Size = new System.Drawing.Size(882, 486);
            this.logoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoImage.TabIndex = 3;
            this.logoImage.TabStop = false;
            // 
            // prijavljeniČlanciToolStripMenuItem
            // 
            this.prijavljeniČlanciToolStripMenuItem.Name = "prijavljeniČlanciToolStripMenuItem";
            this.prijavljeniČlanciToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prijavljeniČlanciToolStripMenuItem.Text = "Prijavljeni Članci";
            this.prijavljeniČlanciToolStripMenuItem.Click += new System.EventHandler(this.prijavljeniČlanciToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 510);
            this.Controls.Add(this.logoImage);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "SmartRead Administracija";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.PictureBox logoImage;
        private System.Windows.Forms.ToolStripMenuItem kategorijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikažiKategorijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKategorijuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem članciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajČlanakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem članciToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikažiKorisnikeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prijavljeniČlanciToolStripMenuItem;
    }
}