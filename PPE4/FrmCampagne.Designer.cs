namespace PPE4
{
    partial class FrmCampagne
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.fCamp_TpGet = new System.Windows.Forms.TabPage();
            this.fCamp_TpGet_DgCampagne = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.fCamp_TpSet_lblReponse = new System.Windows.Forms.Label();
            this.fCamp_TpSet_tbNom = new System.Windows.Forms.TextBox();
            this.fCamp_TpSet_tbObjectif = new System.Windows.Forms.TextBox();
            this.fCamp_TpSet_tbPublique = new System.Windows.Forms.TextBox();
            this.fCamp_TpSet_dtDateFin = new System.Windows.Forms.DateTimePicker();
            this.fCamp_TpSet_dtDateDebut = new System.Windows.Forms.DateTimePicker();
            this.fCamp_TpSet_cbAgence2 = new System.Windows.Forms.ComboBox();
            this.fCamp_TpSet_cbAgence1 = new System.Windows.Forms.ComboBox();
            this.fCamp_TpSet_cbResponsable = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.fCamp_TpSet_BtAnnuler = new System.Windows.Forms.Button();
            this.fCamp_TpSet_BtValider = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.fCamp_TpGet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fCamp_TpGet_DgCampagne)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.fCamp_TpGet);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(548, 292);
            this.tabControl1.TabIndex = 0;
            // 
            // fCamp_TpGet
            // 
            this.fCamp_TpGet.Controls.Add(this.fCamp_TpGet_DgCampagne);
            this.fCamp_TpGet.Location = new System.Drawing.Point(4, 22);
            this.fCamp_TpGet.Name = "fCamp_TpGet";
            this.fCamp_TpGet.Padding = new System.Windows.Forms.Padding(3);
            this.fCamp_TpGet.Size = new System.Drawing.Size(540, 266);
            this.fCamp_TpGet.TabIndex = 0;
            this.fCamp_TpGet.Text = "Consulter";
            this.fCamp_TpGet.UseVisualStyleBackColor = true;
            this.fCamp_TpGet.Enter += new System.EventHandler(this.fCamp_TpGet_Enter);
            // 
            // fCamp_TpGet_DgCampagne
            // 
            this.fCamp_TpGet_DgCampagne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fCamp_TpGet_DgCampagne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fCamp_TpGet_DgCampagne.Location = new System.Drawing.Point(6, 33);
            this.fCamp_TpGet_DgCampagne.Name = "fCamp_TpGet_DgCampagne";
            this.fCamp_TpGet_DgCampagne.Size = new System.Drawing.Size(528, 227);
            this.fCamp_TpGet_DgCampagne.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.fCamp_TpSet_lblReponse);
            this.tabPage2.Controls.Add(this.fCamp_TpSet_tbNom);
            this.tabPage2.Controls.Add(this.fCamp_TpSet_tbObjectif);
            this.tabPage2.Controls.Add(this.fCamp_TpSet_tbPublique);
            this.tabPage2.Controls.Add(this.fCamp_TpSet_dtDateFin);
            this.tabPage2.Controls.Add(this.fCamp_TpSet_dtDateDebut);
            this.tabPage2.Controls.Add(this.fCamp_TpSet_cbAgence2);
            this.tabPage2.Controls.Add(this.fCamp_TpSet_cbAgence1);
            this.tabPage2.Controls.Add(this.fCamp_TpSet_cbResponsable);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.fCamp_TpSet_BtAnnuler);
            this.tabPage2.Controls.Add(this.fCamp_TpSet_BtValider);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(540, 266);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Créer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // fCamp_TpSet_lblReponse
            // 
            this.fCamp_TpSet_lblReponse.AutoSize = true;
            this.fCamp_TpSet_lblReponse.Location = new System.Drawing.Point(349, 42);
            this.fCamp_TpSet_lblReponse.Name = "fCamp_TpSet_lblReponse";
            this.fCamp_TpSet_lblReponse.Size = new System.Drawing.Size(0, 13);
            this.fCamp_TpSet_lblReponse.TabIndex = 19;
            // 
            // fCamp_TpSet_tbNom
            // 
            this.fCamp_TpSet_tbNom.Location = new System.Drawing.Point(58, 22);
            this.fCamp_TpSet_tbNom.Name = "fCamp_TpSet_tbNom";
            this.fCamp_TpSet_tbNom.Size = new System.Drawing.Size(100, 20);
            this.fCamp_TpSet_tbNom.TabIndex = 18;
            // 
            // fCamp_TpSet_tbObjectif
            // 
            this.fCamp_TpSet_tbObjectif.Location = new System.Drawing.Point(67, 52);
            this.fCamp_TpSet_tbObjectif.Name = "fCamp_TpSet_tbObjectif";
            this.fCamp_TpSet_tbObjectif.Size = new System.Drawing.Size(100, 20);
            this.fCamp_TpSet_tbObjectif.TabIndex = 17;
            // 
            // fCamp_TpSet_tbPublique
            // 
            this.fCamp_TpSet_tbPublique.Location = new System.Drawing.Point(76, 75);
            this.fCamp_TpSet_tbPublique.Name = "fCamp_TpSet_tbPublique";
            this.fCamp_TpSet_tbPublique.Size = new System.Drawing.Size(100, 20);
            this.fCamp_TpSet_tbPublique.TabIndex = 16;
            // 
            // fCamp_TpSet_dtDateFin
            // 
            this.fCamp_TpSet_dtDateFin.Location = new System.Drawing.Point(87, 133);
            this.fCamp_TpSet_dtDateFin.Name = "fCamp_TpSet_dtDateFin";
            this.fCamp_TpSet_dtDateFin.Size = new System.Drawing.Size(200, 20);
            this.fCamp_TpSet_dtDateFin.TabIndex = 15;
            // 
            // fCamp_TpSet_dtDateDebut
            // 
            this.fCamp_TpSet_dtDateDebut.Location = new System.Drawing.Point(102, 102);
            this.fCamp_TpSet_dtDateDebut.Name = "fCamp_TpSet_dtDateDebut";
            this.fCamp_TpSet_dtDateDebut.Size = new System.Drawing.Size(200, 20);
            this.fCamp_TpSet_dtDateDebut.TabIndex = 14;
            // 
            // fCamp_TpSet_cbAgence2
            // 
            this.fCamp_TpSet_cbAgence2.FormattingEnabled = true;
            this.fCamp_TpSet_cbAgence2.Location = new System.Drawing.Point(386, 201);
            this.fCamp_TpSet_cbAgence2.Name = "fCamp_TpSet_cbAgence2";
            this.fCamp_TpSet_cbAgence2.Size = new System.Drawing.Size(121, 21);
            this.fCamp_TpSet_cbAgence2.TabIndex = 13;
            // 
            // fCamp_TpSet_cbAgence1
            // 
            this.fCamp_TpSet_cbAgence1.FormattingEnabled = true;
            this.fCamp_TpSet_cbAgence1.Location = new System.Drawing.Point(115, 201);
            this.fCamp_TpSet_cbAgence1.Name = "fCamp_TpSet_cbAgence1";
            this.fCamp_TpSet_cbAgence1.Size = new System.Drawing.Size(121, 21);
            this.fCamp_TpSet_cbAgence1.TabIndex = 12;
            // 
            // fCamp_TpSet_cbResponsable
            // 
            this.fCamp_TpSet_cbResponsable.FormattingEnabled = true;
            this.fCamp_TpSet_cbResponsable.Location = new System.Drawing.Point(97, 171);
            this.fCamp_TpSet_cbResponsable.Name = "fCamp_TpSet_cbResponsable";
            this.fCamp_TpSet_cbResponsable.Size = new System.Drawing.Size(121, 21);
            this.fCamp_TpSet_cbResponsable.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(199, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Création d\'une campagne";
            // 
            // fCamp_TpSet_BtAnnuler
            // 
            this.fCamp_TpSet_BtAnnuler.Location = new System.Drawing.Point(441, 226);
            this.fCamp_TpSet_BtAnnuler.Name = "fCamp_TpSet_BtAnnuler";
            this.fCamp_TpSet_BtAnnuler.Size = new System.Drawing.Size(93, 34);
            this.fCamp_TpSet_BtAnnuler.TabIndex = 9;
            this.fCamp_TpSet_BtAnnuler.Text = "Annuler";
            this.fCamp_TpSet_BtAnnuler.UseVisualStyleBackColor = true;
            this.fCamp_TpSet_BtAnnuler.Click += new System.EventHandler(this.fCamp_TpSet_BtAnnuler_Click);
            // 
            // fCamp_TpSet_BtValider
            // 
            this.fCamp_TpSet_BtValider.Location = new System.Drawing.Point(320, 226);
            this.fCamp_TpSet_BtValider.Name = "fCamp_TpSet_BtValider";
            this.fCamp_TpSet_BtValider.Size = new System.Drawing.Size(96, 34);
            this.fCamp_TpSet_BtValider.TabIndex = 8;
            this.fCamp_TpSet_BtValider.Text = "Valider";
            this.fCamp_TpSet_BtValider.UseVisualStyleBackColor = true;
            this.fCamp_TpSet_BtValider.Click += new System.EventHandler(this.fCamp_TpSet_BtValider_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Deuxième agence :\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Première agence :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Responsable :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date de fin :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date de début :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Publique :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Objectif:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // FrmCampagne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 316);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmCampagne";
            this.Text = "FrmCampagne";
            this.Load += new System.EventHandler(this.FrmCampagne_Load);
            this.tabControl1.ResumeLayout(false);
            this.fCamp_TpGet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fCamp_TpGet_DgCampagne)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage fCamp_TpGet;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button fCamp_TpSet_BtAnnuler;
        private System.Windows.Forms.Button fCamp_TpSet_BtValider;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker fCamp_TpSet_dtDateDebut;
        private System.Windows.Forms.ComboBox fCamp_TpSet_cbAgence2;
        private System.Windows.Forms.ComboBox fCamp_TpSet_cbAgence1;
        private System.Windows.Forms.ComboBox fCamp_TpSet_cbResponsable;
        private System.Windows.Forms.TextBox fCamp_TpSet_tbNom;
        private System.Windows.Forms.TextBox fCamp_TpSet_tbObjectif;
        private System.Windows.Forms.TextBox fCamp_TpSet_tbPublique;
        private System.Windows.Forms.DateTimePicker fCamp_TpSet_dtDateFin;
        private System.Windows.Forms.Label fCamp_TpSet_lblReponse;
        private System.Windows.Forms.DataGridView fCamp_TpGet_DgCampagne;
    }
}