namespace SCVZ
{
    partial class Recenziranje
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
            this.lblOdabirJela = new System.Windows.Forms.Label();
            this.lblOcjena = new System.Windows.Forms.Label();
            this.lblKomentar = new System.Windows.Forms.Label();
            this.tbxKomentar = new System.Windows.Forms.TextBox();
            this.cmbOdabir = new System.Windows.Forms.ComboBox();
            this.nudOcjena = new System.Windows.Forms.NumericUpDown();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudOcjena)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOdabirJela
            // 
            this.lblOdabirJela.AutoSize = true;
            this.lblOdabirJela.Location = new System.Drawing.Point(42, 59);
            this.lblOdabirJela.Name = "lblOdabirJela";
            this.lblOdabirJela.Size = new System.Drawing.Size(101, 20);
            this.lblOdabirJela.TabIndex = 0;
            this.lblOdabirJela.Text = "Odaberi jelo: ";
            // 
            // lblOcjena
            // 
            this.lblOcjena.AutoSize = true;
            this.lblOcjena.Location = new System.Drawing.Point(42, 147);
            this.lblOcjena.Name = "lblOcjena";
            this.lblOcjena.Size = new System.Drawing.Size(67, 20);
            this.lblOcjena.TabIndex = 1;
            this.lblOcjena.Text = "Ocjena: ";
            // 
            // lblKomentar
            // 
            this.lblKomentar.AutoSize = true;
            this.lblKomentar.Location = new System.Drawing.Point(42, 240);
            this.lblKomentar.Name = "lblKomentar";
            this.lblKomentar.Size = new System.Drawing.Size(86, 20);
            this.lblKomentar.TabIndex = 2;
            this.lblKomentar.Text = "Komentar: ";
            // 
            // tbxKomentar
            // 
            this.tbxKomentar.Location = new System.Drawing.Point(46, 272);
            this.tbxKomentar.Multiline = true;
            this.tbxKomentar.Name = "tbxKomentar";
            this.tbxKomentar.Size = new System.Drawing.Size(834, 232);
            this.tbxKomentar.TabIndex = 3;
            // 
            // cmbOdabir
            // 
            this.cmbOdabir.FormattingEnabled = true;
            this.cmbOdabir.Location = new System.Drawing.Point(150, 56);
            this.cmbOdabir.Name = "cmbOdabir";
            this.cmbOdabir.Size = new System.Drawing.Size(716, 28);
            this.cmbOdabir.TabIndex = 4;
            this.cmbOdabir.Text = "Odaberi jelo";
            // 
            // nudOcjena
            // 
            this.nudOcjena.Location = new System.Drawing.Point(150, 145);
            this.nudOcjena.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudOcjena.Name = "nudOcjena";
            this.nudOcjena.Size = new System.Drawing.Size(120, 26);
            this.nudOcjena.TabIndex = 5;
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(764, 544);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(145, 34);
            this.btnPosalji.TabIndex = 6;
            this.btnPosalji.Text = "Pošalji";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(23, 544);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(145, 34);
            this.btnZatvori.TabIndex = 7;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // Recenziranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 597);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.nudOcjena);
            this.Controls.Add(this.cmbOdabir);
            this.Controls.Add(this.tbxKomentar);
            this.Controls.Add(this.lblKomentar);
            this.Controls.Add(this.lblOcjena);
            this.Controls.Add(this.lblOdabirJela);
            this.Name = "Recenziranje";
            this.Text = "Recenziranje";
            this.Load += new System.EventHandler(this.Recenziranje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudOcjena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOdabirJela;
        private System.Windows.Forms.Label lblOcjena;
        private System.Windows.Forms.Label lblKomentar;
        private System.Windows.Forms.TextBox tbxKomentar;
        private System.Windows.Forms.ComboBox cmbOdabir;
        private System.Windows.Forms.NumericUpDown nudOcjena;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.Button btnZatvori;
    }
}