namespace SCVZ
{
    partial class FrmSCVZ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSCVZ));
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.btnPopularDish = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.dnevniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tjedniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mjesečniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOrder = new System.Windows.Forms.Button();
            this.bttnRecenzije = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMenu
            // 
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Location = new System.Drawing.Point(34, 57);
            this.dgvMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.RowHeadersWidth = 62;
            this.dgvMenu.Size = new System.Drawing.Size(934, 397);
            this.dgvMenu.TabIndex = 0;
            // 
            // btnPopularDish
            // 
            this.btnPopularDish.Location = new System.Drawing.Point(34, 486);
            this.btnPopularDish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPopularDish.Name = "btnPopularDish";
            this.btnPopularDish.Size = new System.Drawing.Size(112, 35);
            this.btnPopularDish.TabIndex = 1;
            this.btnPopularDish.Text = "Popular";
            this.btnPopularDish.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(856, 486);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(112, 35);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1014, 34);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dnevniToolStripMenuItem,
            this.tjedniToolStripMenuItem,
            this.mjesečniToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(80, 29);
            this.toolStripDropDownButton1.Text = "MENU";
            this.toolStripDropDownButton1.ToolTipText = "MENU";
            // 
            // dnevniToolStripMenuItem
            // 
            this.dnevniToolStripMenuItem.Name = "dnevniToolStripMenuItem";
            this.dnevniToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.dnevniToolStripMenuItem.Text = "Dnevni";
            this.dnevniToolStripMenuItem.Click += new System.EventHandler(this.dnevniToolStripMenuItem_Click);
            // 
            // tjedniToolStripMenuItem
            // 
            this.tjedniToolStripMenuItem.Name = "tjedniToolStripMenuItem";
            this.tjedniToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.tjedniToolStripMenuItem.Text = "Tjedni";
            this.tjedniToolStripMenuItem.Click += new System.EventHandler(this.tjedniToolStripMenuItem_Click);
            // 
            // mjesečniToolStripMenuItem
            // 
            this.mjesečniToolStripMenuItem.Name = "mjesečniToolStripMenuItem";
            this.mjesečniToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.mjesečniToolStripMenuItem.Text = "Mjesečni";
            this.mjesečniToolStripMenuItem.Click += new System.EventHandler(this.mjesečniToolStripMenuItem_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(717, 486);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(92, 35);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Naruči";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // bttnRecenzije
            // 
            this.bttnRecenzije.Location = new System.Drawing.Point(127, 0);
            this.bttnRecenzije.Name = "bttnRecenzije";
            this.bttnRecenzije.Size = new System.Drawing.Size(141, 38);
            this.bttnRecenzije.TabIndex = 5;
            this.bttnRecenzije.Text = "RECENZIJE";
            this.bttnRecenzije.UseVisualStyleBackColor = true;
            this.bttnRecenzije.Click += new System.EventHandler(this.bttnRecenzije_Click);
            // 
            // FrmSCVZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 548);
            this.Controls.Add(this.bttnRecenzije);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnPopularDish);
            this.Controls.Add(this.dgvMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmSCVZ";
            this.Text = "SCVZ";
            this.Load += new System.EventHandler(this.FrmSCVZ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Button btnPopularDish;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem dnevniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tjedniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mjesečniToolStripMenuItem;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button bttnRecenzije;
    }
}