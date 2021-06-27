
namespace SmartRead.WinUI.Forms.Clanci
{
    partial class ClanciForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odobren = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Odbijen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naslov,
            this.Cijena,
            this.Odobren,
            this.Odbijen});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 316);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Naslov
            // 
            this.Naslov.DataPropertyName = "Naslov";
            this.Naslov.HeaderText = "Naslov";
            this.Naslov.Name = "Naslov";
            this.Naslov.ReadOnly = true;
            this.Naslov.Width = 430;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // Odobren
            // 
            this.Odobren.DataPropertyName = "Odobren";
            this.Odobren.HeaderText = "Odobren";
            this.Odobren.Name = "Odobren";
            this.Odobren.ReadOnly = true;
            // 
            // Odbijen
            // 
            this.Odbijen.DataPropertyName = "Odbijen";
            this.Odbijen.HeaderText = "Odbijen";
            this.Odbijen.Name = "Odbijen";
            this.Odbijen.ReadOnly = true;
            // 
            // ClanciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ClanciForm";
            this.Text = "ClanciForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Odobren;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Odbijen;
    }
}