namespace PPE4
{
    partial class FrmStatistiques
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fStat_dgStat = new System.Windows.Forms.DataGridView();
            this.fStat_rBtnStat1 = new System.Windows.Forms.RadioButton();
            this.fStat_rBtnStat2 = new System.Windows.Forms.RadioButton();
            this.fStat_cbSat2 = new System.Windows.Forms.ComboBox();
            this.fStat_cbSat1 = new System.Windows.Forms.ComboBox();
            this.fStat_btnRechercher = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fStat_dgStat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fStat_btnRechercher);
            this.groupBox1.Controls.Add(this.fStat_cbSat1);
            this.groupBox1.Controls.Add(this.fStat_cbSat2);
            this.groupBox1.Controls.Add(this.fStat_rBtnStat2);
            this.groupBox1.Controls.Add(this.fStat_rBtnStat1);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(881, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // fStat_dgStat
            // 
            this.fStat_dgStat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fStat_dgStat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fStat_dgStat.Location = new System.Drawing.Point(12, 155);
            this.fStat_dgStat.Name = "fStat_dgStat";
            this.fStat_dgStat.Size = new System.Drawing.Size(881, 270);
            this.fStat_dgStat.TabIndex = 1;
            // 
            // fStat_rBtnStat1
            // 
            this.fStat_rBtnStat1.AutoSize = true;
            this.fStat_rBtnStat1.Location = new System.Drawing.Point(6, 44);
            this.fStat_rBtnStat1.Name = "fStat_rBtnStat1";
            this.fStat_rBtnStat1.Size = new System.Drawing.Size(340, 17);
            this.fStat_rBtnStat1.TabIndex = 0;
            this.fStat_rBtnStat1.TabStop = true;
            this.fStat_rBtnStat1.Text = "Statistique 1 : Nombre d\'événements par campagne pour l\'année X";
            this.fStat_rBtnStat1.UseVisualStyleBackColor = true;
            // 
            // fStat_rBtnStat2
            // 
            this.fStat_rBtnStat2.AutoSize = true;
            this.fStat_rBtnStat2.Location = new System.Drawing.Point(6, 89);
            this.fStat_rBtnStat2.Name = "fStat_rBtnStat2";
            this.fStat_rBtnStat2.Size = new System.Drawing.Size(258, 17);
            this.fStat_rBtnStat2.TabIndex = 1;
            this.fStat_rBtnStat2.TabStop = true;
            this.fStat_rBtnStat2.Text = "Statistique 1 : Liste des campagnes pour la ville X";
            this.fStat_rBtnStat2.UseVisualStyleBackColor = true;
            // 
            // fStat_cbSat2
            // 
            this.fStat_cbSat2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fStat_cbSat2.FormattingEnabled = true;
            this.fStat_cbSat2.Location = new System.Drawing.Point(312, 89);
            this.fStat_cbSat2.Name = "fStat_cbSat2";
            this.fStat_cbSat2.Size = new System.Drawing.Size(121, 21);
            this.fStat_cbSat2.TabIndex = 2;
            // 
            // fStat_cbSat1
            // 
            this.fStat_cbSat1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fStat_cbSat1.FormattingEnabled = true;
            this.fStat_cbSat1.Location = new System.Drawing.Point(361, 44);
            this.fStat_cbSat1.Name = "fStat_cbSat1";
            this.fStat_cbSat1.Size = new System.Drawing.Size(121, 21);
            this.fStat_cbSat1.TabIndex = 3;
            // 
            // fStat_btnRechercher
            // 
            this.fStat_btnRechercher.Location = new System.Drawing.Point(644, 57);
            this.fStat_btnRechercher.Name = "fStat_btnRechercher";
            this.fStat_btnRechercher.Size = new System.Drawing.Size(137, 39);
            this.fStat_btnRechercher.TabIndex = 4;
            this.fStat_btnRechercher.Text = "Rechercher";
            this.fStat_btnRechercher.UseVisualStyleBackColor = true;
            this.fStat_btnRechercher.Click += new System.EventHandler(this.fStat_btnRechercher_Click);
            // 
            // FrmStatistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 437);
            this.Controls.Add(this.fStat_dgStat);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmStatistiques";
            this.Text = "FrmStatistiques";
            this.Load += new System.EventHandler(this.FrmStatistiques_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fStat_dgStat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView fStat_dgStat;
        private System.Windows.Forms.ComboBox fStat_cbSat1;
        private System.Windows.Forms.ComboBox fStat_cbSat2;
        private System.Windows.Forms.RadioButton fStat_rBtnStat2;
        private System.Windows.Forms.RadioButton fStat_rBtnStat1;
        private System.Windows.Forms.Button fStat_btnRechercher;
    }
}