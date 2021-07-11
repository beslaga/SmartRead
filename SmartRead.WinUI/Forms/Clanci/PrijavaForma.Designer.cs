
namespace SmartRead.WinUI.Forms.Clanci
{
    partial class PrijavaForma
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSadrzaj = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrijava = new System.Windows.Forms.RichTextBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnUvazeno = new System.Windows.Forms.Button();
            this.btnPregledano = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Sadržaj";
            // 
            // txtSadrzaj
            // 
            this.txtSadrzaj.Location = new System.Drawing.Point(38, 302);
            this.txtSadrzaj.Name = "txtSadrzaj";
            this.txtSadrzaj.Size = new System.Drawing.Size(733, 183);
            this.txtSadrzaj.TabIndex = 39;
            this.txtSadrzaj.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Naslov";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(38, 241);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(733, 20);
            this.txtNaslov.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 525);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Prijava";
            // 
            // txtPrijava
            // 
            this.txtPrijava.Location = new System.Drawing.Point(38, 544);
            this.txtPrijava.Name = "txtPrijava";
            this.txtPrijava.Size = new System.Drawing.Size(733, 183);
            this.txtPrijava.TabIndex = 41;
            this.txtPrijava.Text = "";
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(38, 12);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(733, 184);
            this.pbImage.TabIndex = 36;
            this.pbImage.TabStop = false;
            // 
            // btnUvazeno
            // 
            this.btnUvazeno.Location = new System.Drawing.Point(38, 783);
            this.btnUvazeno.Name = "btnUvazeno";
            this.btnUvazeno.Size = new System.Drawing.Size(149, 23);
            this.btnUvazeno.TabIndex = 43;
            this.btnUvazeno.Text = "Uvazeno";
            this.btnUvazeno.UseVisualStyleBackColor = true;
            this.btnUvazeno.Click += new System.EventHandler(this.btnUvazeno_Click);
            // 
            // btnPregledano
            // 
            this.btnPregledano.Location = new System.Drawing.Point(218, 783);
            this.btnPregledano.Name = "btnPregledano";
            this.btnPregledano.Size = new System.Drawing.Size(149, 23);
            this.btnPregledano.TabIndex = 44;
            this.btnPregledano.Text = "Pregledano";
            this.btnPregledano.UseVisualStyleBackColor = true;
            this.btnPregledano.Click += new System.EventHandler(this.btnPregledano_Click);
            // 
            // PrijavaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 861);
            this.Controls.Add(this.btnPregledano);
            this.Controls.Add(this.btnUvazeno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrijava);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSadrzaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.pbImage);
            this.Name = "PrijavaForma";
            this.Text = "PrijavaForma";
            this.Load += new System.EventHandler(this.PrijavaForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtSadrzaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtPrijava;
        private System.Windows.Forms.Button btnUvazeno;
        private System.Windows.Forms.Button btnPregledano;
    }
}