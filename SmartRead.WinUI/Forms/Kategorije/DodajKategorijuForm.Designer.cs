
namespace SmartRead.WinUI.Forms.Kategorije
{
    partial class DodajKategorijuForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.dodajButton = new System.Windows.Forms.Button();
            this.obrisanCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(94, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(148, 24);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Dodaj Kategoriju";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 64);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(320, 20);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(111, 124);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(92, 23);
            this.dodajButton.TabIndex = 2;
            this.dodajButton.Text = "Snimi";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // obrisanCheckBox
            // 
            this.obrisanCheckBox.AutoSize = true;
            this.obrisanCheckBox.Location = new System.Drawing.Point(130, 90);
            this.obrisanCheckBox.Name = "obrisanCheckBox";
            this.obrisanCheckBox.Size = new System.Drawing.Size(62, 17);
            this.obrisanCheckBox.TabIndex = 3;
            this.obrisanCheckBox.Text = "Obrisan";
            this.obrisanCheckBox.UseVisualStyleBackColor = true;
            // 
            // DodajKategorijuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 194);
            this.Controls.Add(this.obrisanCheckBox);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "DodajKategorijuForm";
            this.Text = "Dodaj Kategoriju";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.CheckBox obrisanCheckBox;
    }
}