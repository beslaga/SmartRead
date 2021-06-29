
namespace SmartRead.WinUI.Forms.Korisnici
{
    partial class DodajKorisnikaForm
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.cbDrzava = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.txtPotvrdiPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.clbRoles = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSpasi = new System.Windows.Forms.Button();
            this.errorIme = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPrezime = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPotvrdiPassword = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrezime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPotvrdiPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(50, 309);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(292, 20);
            this.txtIme.TabIndex = 0;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(446, 309);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(292, 20);
            this.txtPrezime.TabIndex = 1;
            this.txtPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezime_Validating);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(50, 370);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(292, 20);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(446, 370);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(292, 20);
            this.txtMail.TabIndex = 3;
            this.txtMail.Validating += new System.ComponentModel.CancelEventHandler(this.txtMail_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mail";
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(49, 32);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(188, 184);
            this.pbImage.TabIndex = 31;
            this.pbImage.TabStop = false;
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImage.Location = new System.Drawing.Point(49, 237);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(188, 23);
            this.btnUploadImage.TabIndex = 32;
            this.btnUploadImage.Text = "Izaberi sliku";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // cbDrzava
            // 
            this.cbDrzava.FormattingEnabled = true;
            this.cbDrzava.Location = new System.Drawing.Point(50, 438);
            this.cbDrzava.Name = "cbDrzava";
            this.cbDrzava.Size = new System.Drawing.Size(293, 21);
            this.cbDrzava.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Drzava";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 507);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Potvrdi Password";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(50, 507);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 37;
            this.Password.Text = "Password";
            // 
            // txtPotvrdiPassword
            // 
            this.txtPotvrdiPassword.Location = new System.Drawing.Point(446, 523);
            this.txtPotvrdiPassword.Name = "txtPotvrdiPassword";
            this.txtPotvrdiPassword.PasswordChar = '*';
            this.txtPotvrdiPassword.Size = new System.Drawing.Size(292, 20);
            this.txtPotvrdiPassword.TabIndex = 36;
            this.txtPotvrdiPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPotvrdiPassword_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(50, 523);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(292, 20);
            this.txtPassword.TabIndex = 35;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // clbRoles
            // 
            this.clbRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbRoles.FormattingEnabled = true;
            this.clbRoles.Location = new System.Drawing.Point(50, 590);
            this.clbRoles.Name = "clbRoles";
            this.clbRoles.Size = new System.Drawing.Size(688, 148);
            this.clbRoles.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(443, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "Datum rođenja";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(446, 439);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(292, 20);
            this.dateTimePicker1.TabIndex = 65;
            // 
            // btnSpasi
            // 
            this.btnSpasi.Location = new System.Drawing.Point(54, 771);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(161, 23);
            this.btnSpasi.TabIndex = 66;
            this.btnSpasi.Text = "Spasi";
            this.btnSpasi.UseVisualStyleBackColor = true;
            this.btnSpasi.Click += new System.EventHandler(this.btnSpasi_Click);
            // 
            // errorIme
            // 
            this.errorIme.ContainerControl = this;
            // 
            // errorPrezime
            // 
            this.errorPrezime.ContainerControl = this;
            // 
            // errorUsername
            // 
            this.errorUsername.ContainerControl = this;
            // 
            // errorMail
            // 
            this.errorMail.ContainerControl = this;
            // 
            // errorPassword
            // 
            this.errorPassword.ContainerControl = this;
            // 
            // errorPotvrdiPassword
            // 
            this.errorPotvrdiPassword.ContainerControl = this;
            // 
            // DodajKorisnikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 818);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.clbRoles);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.txtPotvrdiPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbDrzava);
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Name = "DodajKorisnikaForm";
            this.Text = "DodajKorisnikaForm";
            this.Load += new System.EventHandler(this.DodajKorisnikaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrezime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPotvrdiPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.ComboBox cbDrzava;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox txtPotvrdiPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckedListBox clbRoles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnSpasi;
        private System.Windows.Forms.ErrorProvider errorIme;
        private System.Windows.Forms.ErrorProvider errorPrezime;
        private System.Windows.Forms.ErrorProvider errorUsername;
        private System.Windows.Forms.ErrorProvider errorMail;
        private System.Windows.Forms.ErrorProvider errorPassword;
        private System.Windows.Forms.ErrorProvider errorPotvrdiPassword;
    }
}