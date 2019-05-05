namespace PPE4
{
    partial class frmDetailsArtiste
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
            this.dgvDetailsArtiste = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmBoxSelectArtiste = new System.Windows.Forms.ComboBox();
            this.lblSelectArtiste = new System.Windows.Forms.Label();
            this.lblCountCachet = new System.Windows.Forms.Label();
            this.lblCachet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailsArtiste)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDetailsArtiste
            // 
            this.dgvDetailsArtiste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetailsArtiste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailsArtiste.Location = new System.Drawing.Point(12, 89);
            this.dgvDetailsArtiste.Name = "dgvDetailsArtiste";
            this.dgvDetailsArtiste.Size = new System.Drawing.Size(463, 291);
            this.dgvDetailsArtiste.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 39);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(421, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(66, 39);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Détails Artistes";
            // 
            // cmBoxSelectArtiste
            // 
            this.cmBoxSelectArtiste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxSelectArtiste.FormattingEnabled = true;
            this.cmBoxSelectArtiste.Location = new System.Drawing.Point(57, 52);
            this.cmBoxSelectArtiste.Name = "cmBoxSelectArtiste";
            this.cmBoxSelectArtiste.Size = new System.Drawing.Size(121, 21);
            this.cmBoxSelectArtiste.TabIndex = 2;
            this.cmBoxSelectArtiste.SelectedIndexChanged += new System.EventHandler(this.cmBoxSelectArtiste_SelectedIndexChanged);
            // 
            // lblSelectArtiste
            // 
            this.lblSelectArtiste.AutoSize = true;
            this.lblSelectArtiste.Location = new System.Drawing.Point(12, 55);
            this.lblSelectArtiste.Name = "lblSelectArtiste";
            this.lblSelectArtiste.Size = new System.Drawing.Size(39, 13);
            this.lblSelectArtiste.TabIndex = 3;
            this.lblSelectArtiste.Text = "Artiste:";
            // 
            // lblCountCachet
            // 
            this.lblCountCachet.AutoSize = true;
            this.lblCountCachet.Location = new System.Drawing.Point(209, 55);
            this.lblCountCachet.Name = "lblCountCachet";
            this.lblCountCachet.Size = new System.Drawing.Size(71, 13);
            this.lblCountCachet.TabIndex = 4;
            this.lblCountCachet.Text = "Cachet Total:";
            // 
            // lblCachet
            // 
            this.lblCachet.AutoSize = true;
            this.lblCachet.Location = new System.Drawing.Point(286, 55);
            this.lblCachet.Name = "lblCachet";
            this.lblCachet.Size = new System.Drawing.Size(0, 13);
            this.lblCachet.TabIndex = 7;
            // 
            // frmDetailsArtiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 392);
            this.Controls.Add(this.lblCachet);
            this.Controls.Add(this.lblCountCachet);
            this.Controls.Add(this.lblSelectArtiste);
            this.Controls.Add(this.cmBoxSelectArtiste);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDetailsArtiste);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDetailsArtiste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetailsArtiste";
            this.Load += new System.EventHandler(this.frmDetailsArtiste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailsArtiste)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetailsArtiste;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmBoxSelectArtiste;
        private System.Windows.Forms.Label lblSelectArtiste;
        private System.Windows.Forms.Label lblCountCachet;
        private System.Windows.Forms.Label lblCachet;
    }
}