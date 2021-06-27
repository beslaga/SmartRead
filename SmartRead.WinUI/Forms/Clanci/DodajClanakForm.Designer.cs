
namespace SmartRead.WinUI.Forms.Clanci
{
    partial class DodajClanakForm
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
            this.components = new System.ComponentModel.Container();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSadrzaj = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numCijena = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lbKategorije = new System.Windows.Forms.ListBox();
            this.lblGenres = new System.Windows.Forms.Label();
            this.btnDodajKategoriju = new System.Windows.Forms.Button();
            this.btnUkloniKategoriju = new System.Windows.Forms.Button();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.errorProviderNaslov = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSadrzaj = new System.Windows.Forms.ErrorProvider(this.components);
            this.pbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numCijena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNaslov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSadrzaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImage.Location = new System.Drawing.Point(31, 224);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(188, 23);
            this.btnUploadImage.TabIndex = 31;
            this.btnUploadImage.Text = "Izaberi sliku";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(31, 288);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(733, 20);
            this.txtNaslov.TabIndex = 32;
            this.txtNaslov.Validating += new System.ComponentModel.CancelEventHandler(this.Naslov_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Naslov";
            // 
            // txtSadrzaj
            // 
            this.txtSadrzaj.Location = new System.Drawing.Point(31, 349);
            this.txtSadrzaj.Name = "txtSadrzaj";
            this.txtSadrzaj.Size = new System.Drawing.Size(733, 183);
            this.txtSadrzaj.TabIndex = 34;
            this.txtSadrzaj.Text = "";
            this.txtSadrzaj.Validating += new System.ComponentModel.CancelEventHandler(this.Sadrzaj_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Sadržaj";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 870);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Spasi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numCijena
            // 
            this.numCijena.DecimalPlaces = 2;
            this.numCijena.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numCijena.Location = new System.Drawing.Point(34, 824);
            this.numCijena.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCijena.Name = "numCijena";
            this.numCijena.Size = new System.Drawing.Size(188, 20);
            this.numCijena.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 805);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Cijena";
            // 
            // lbKategorije
            // 
            this.lbKategorije.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKategorije.FormattingEnabled = true;
            this.lbKategorije.Location = new System.Drawing.Point(34, 579);
            this.lbKategorije.Name = "lbKategorije";
            this.lbKategorije.Size = new System.Drawing.Size(188, 147);
            this.lbKategorije.TabIndex = 86;
            // 
            // lblGenres
            // 
            this.lblGenres.AutoSize = true;
            this.lblGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenres.Location = new System.Drawing.Point(31, 563);
            this.lblGenres.Name = "lblGenres";
            this.lblGenres.Size = new System.Drawing.Size(54, 13);
            this.lblGenres.TabIndex = 87;
            this.lblGenres.Text = "Kategorije";
            // 
            // btnDodajKategoriju
            // 
            this.btnDodajKategoriju.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajKategoriju.Location = new System.Drawing.Point(268, 635);
            this.btnDodajKategoriju.Name = "btnDodajKategoriju";
            this.btnDodajKategoriju.Size = new System.Drawing.Size(188, 23);
            this.btnDodajKategoriju.TabIndex = 89;
            this.btnDodajKategoriju.Text = "Dodaj Kategoriju";
            this.btnDodajKategoriju.UseVisualStyleBackColor = true;
            this.btnDodajKategoriju.Click += new System.EventHandler(this.btnDodajKategoriju_Click);
            // 
            // btnUkloniKategoriju
            // 
            this.btnUkloniKategoriju.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkloniKategoriju.Location = new System.Drawing.Point(34, 743);
            this.btnUkloniKategoriju.Name = "btnUkloniKategoriju";
            this.btnUkloniKategoriju.Size = new System.Drawing.Size(188, 23);
            this.btnUkloniKategoriju.TabIndex = 90;
            this.btnUkloniKategoriju.Text = "Ukloni Kategoriju";
            this.btnUkloniKategoriju.UseVisualStyleBackColor = true;
            this.btnUkloniKategoriju.Click += new System.EventHandler(this.btnUkloniKategoriju_Click);
            // 
            // cbKategorija
            // 
            this.cbKategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(268, 579);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(188, 24);
            this.cbKategorija.TabIndex = 88;
            // 
            // errorProviderNaslov
            // 
            this.errorProviderNaslov.ContainerControl = this;
            // 
            // errorProviderSadrzaj
            // 
            this.errorProviderSadrzaj.ContainerControl = this;
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(31, 25);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(733, 184);
            this.pbImage.TabIndex = 30;
            this.pbImage.TabStop = false;
            // 
            // DodajClanakForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 916);
            this.Controls.Add(this.lbKategorije);
            this.Controls.Add(this.lblGenres);
            this.Controls.Add(this.btnDodajKategoriju);
            this.Controls.Add(this.btnUkloniKategoriju);
            this.Controls.Add(this.cbKategorija);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numCijena);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSadrzaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnUploadImage);
            this.Name = "DodajClanakForm";
            this.Text = "Dodaj Članak";
            this.Load += new System.EventHandler(this.DodajClanakForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCijena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNaslov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSadrzaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtSadrzaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numCijena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbKategorije;
        private System.Windows.Forms.Label lblGenres;
        private System.Windows.Forms.Button btnDodajKategoriju;
        private System.Windows.Forms.Button btnUkloniKategoriju;
        private System.Windows.Forms.ComboBox cbKategorija;
        private System.Windows.Forms.ErrorProvider errorProviderNaslov;
        private System.Windows.Forms.ErrorProvider errorProviderSadrzaj;
    }
}