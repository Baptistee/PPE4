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
            this.fCamp_DgCampagne = new System.Windows.Forms.DataGridView();
            this.fCamp_GrpBox = new System.Windows.Forms.GroupBox();
            this.fCamp_BtSupprimer = new System.Windows.Forms.Button();
            this.fCamp_BtModifier = new System.Windows.Forms.Button();
            this.fCamp_TpSet_lblReponse = new System.Windows.Forms.Label();
            this.fCamp_tbNom = new System.Windows.Forms.TextBox();
            this.fCamp_tbObjectif = new System.Windows.Forms.TextBox();
            this.fCamp_tbPublique = new System.Windows.Forms.TextBox();
            this.fCamp_dtDateFin = new System.Windows.Forms.DateTimePicker();
            this.fCamp_dtDateDebut = new System.Windows.Forms.DateTimePicker();
            this.fCamp_cbAgence2 = new System.Windows.Forms.ComboBox();
            this.fCamp_cbAgence1 = new System.Windows.Forms.ComboBox();
            this.fCamp_cbResponsable = new System.Windows.Forms.ComboBox();
            this.fCamp_BtAnnuler = new System.Windows.Forms.Button();
            this.fCamp_BtValider = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.fCamp_DgCampagne)).BeginInit();
            this.fCamp_GrpBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fCamp_DgCampagne
            // 
            this.fCamp_DgCampagne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fCamp_DgCampagne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fCamp_DgCampagne.Location = new System.Drawing.Point(12, 202);
            this.fCamp_DgCampagne.Name = "fCamp_DgCampagne";
            this.fCamp_DgCampagne.Size = new System.Drawing.Size(1066, 335);
            this.fCamp_DgCampagne.TabIndex = 40;
            this.fCamp_DgCampagne.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.fCamp_DgCampagne_RowHeaderMouseClick);
            // 
            // fCamp_GrpBox
            // 
            this.fCamp_GrpBox.Controls.Add(this.fCamp_BtSupprimer);
            this.fCamp_GrpBox.Controls.Add(this.fCamp_BtModifier);
            this.fCamp_GrpBox.Controls.Add(this.fCamp_TpSet_lblReponse);
            this.fCamp_GrpBox.Controls.Add(this.fCamp_tbNom);
            this.fCamp_GrpBox.Controls.Add(this.fCamp_tbObjectif);
            this.fCamp_GrpBox.Controls.Add(this.fCamp_tbPublique);
            this.fCamp_GrpBox.Controls.Add(this.fCamp_dtDateFin);
            this.fCamp_GrpBox.Controls.Add(this.fCamp_dtDateDebut);
            this.fCamp_GrpBox.Controls.Add(this.fCamp_cbAgence2);
            this.fCamp_GrpBox.Controls.Add(this.fCamp_cbAgence1);
            this.fCamp_GrpBox.Controls.Add(this.fCamp_cbResponsable);
            this.fCamp_GrpBox.Controls.Add(this.fCamp_BtAnnuler);
            this.fCamp_GrpBox.Controls.Add(this.fCamp_BtValider);
            this.fCamp_GrpBox.Controls.Add(this.label8);
            this.fCamp_GrpBox.Controls.Add(this.label7);
            this.fCamp_GrpBox.Controls.Add(this.label6);
            this.fCamp_GrpBox.Controls.Add(this.label5);
            this.fCamp_GrpBox.Controls.Add(this.label4);
            this.fCamp_GrpBox.Controls.Add(this.label3);
            this.fCamp_GrpBox.Controls.Add(this.label2);
            this.fCamp_GrpBox.Controls.Add(this.label1);
            this.fCamp_GrpBox.Location = new System.Drawing.Point(0, 0);
            this.fCamp_GrpBox.Name = "fCamp_GrpBox";
            this.fCamp_GrpBox.Size = new System.Drawing.Size(562, 196);
            this.fCamp_GrpBox.TabIndex = 41;
            this.fCamp_GrpBox.TabStop = false;
            // 
            // fCamp_BtSupprimer
            // 
            this.fCamp_BtSupprimer.Location = new System.Drawing.Point(446, 148);
            this.fCamp_BtSupprimer.Name = "fCamp_BtSupprimer";
            this.fCamp_BtSupprimer.Size = new System.Drawing.Size(96, 34);
            this.fCamp_BtSupprimer.TabIndex = 64;
            this.fCamp_BtSupprimer.Text = "Supprimer";
            this.fCamp_BtSupprimer.UseVisualStyleBackColor = true;
            this.fCamp_BtSupprimer.Click += new System.EventHandler(this.fCamp_BtSupprimer_Click);
            // 
            // fCamp_BtModifier
            // 
            this.fCamp_BtModifier.Location = new System.Drawing.Point(140, 148);
            this.fCamp_BtModifier.Name = "fCamp_BtModifier";
            this.fCamp_BtModifier.Size = new System.Drawing.Size(96, 34);
            this.fCamp_BtModifier.TabIndex = 63;
            this.fCamp_BtModifier.Text = "Modifier";
            this.fCamp_BtModifier.UseVisualStyleBackColor = true;
            this.fCamp_BtModifier.Click += new System.EventHandler(this.fCamp_BtModifier_Click);
            // 
            // fCamp_TpSet_lblReponse
            // 
            this.fCamp_TpSet_lblReponse.AutoSize = true;
            this.fCamp_TpSet_lblReponse.Location = new System.Drawing.Point(516, 84);
            this.fCamp_TpSet_lblReponse.Name = "fCamp_TpSet_lblReponse";
            this.fCamp_TpSet_lblReponse.Size = new System.Drawing.Size(0, 13);
            this.fCamp_TpSet_lblReponse.TabIndex = 62;
            // 
            // fCamp_tbNom
            // 
            this.fCamp_tbNom.Location = new System.Drawing.Point(56, 21);
            this.fCamp_tbNom.Name = "fCamp_tbNom";
            this.fCamp_tbNom.Size = new System.Drawing.Size(100, 20);
            this.fCamp_tbNom.TabIndex = 61;
            // 
            // fCamp_tbObjectif
            // 
            this.fCamp_tbObjectif.Location = new System.Drawing.Point(66, 47);
            this.fCamp_tbObjectif.Name = "fCamp_tbObjectif";
            this.fCamp_tbObjectif.Size = new System.Drawing.Size(100, 20);
            this.fCamp_tbObjectif.TabIndex = 60;
            // 
            // fCamp_tbPublique
            // 
            this.fCamp_tbPublique.Location = new System.Drawing.Point(76, 78);
            this.fCamp_tbPublique.Name = "fCamp_tbPublique";
            this.fCamp_tbPublique.Size = new System.Drawing.Size(100, 20);
            this.fCamp_tbPublique.TabIndex = 59;
            // 
            // fCamp_dtDateFin
            // 
            this.fCamp_dtDateFin.Location = new System.Drawing.Point(342, 50);
            this.fCamp_dtDateFin.Name = "fCamp_dtDateFin";
            this.fCamp_dtDateFin.Size = new System.Drawing.Size(200, 20);
            this.fCamp_dtDateFin.TabIndex = 58;
            // 
            // fCamp_dtDateDebut
            // 
            this.fCamp_dtDateDebut.Location = new System.Drawing.Point(342, 19);
            this.fCamp_dtDateDebut.Name = "fCamp_dtDateDebut";
            this.fCamp_dtDateDebut.Size = new System.Drawing.Size(200, 20);
            this.fCamp_dtDateDebut.TabIndex = 57;
            // 
            // fCamp_cbAgence2
            // 
            this.fCamp_cbAgence2.FormattingEnabled = true;
            this.fCamp_cbAgence2.Location = new System.Drawing.Point(421, 112);
            this.fCamp_cbAgence2.Name = "fCamp_cbAgence2";
            this.fCamp_cbAgence2.Size = new System.Drawing.Size(121, 21);
            this.fCamp_cbAgence2.TabIndex = 56;
            // 
            // fCamp_cbAgence1
            // 
            this.fCamp_cbAgence1.FormattingEnabled = true;
            this.fCamp_cbAgence1.Location = new System.Drawing.Point(160, 109);
            this.fCamp_cbAgence1.Name = "fCamp_cbAgence1";
            this.fCamp_cbAgence1.Size = new System.Drawing.Size(121, 21);
            this.fCamp_cbAgence1.TabIndex = 55;
            // 
            // fCamp_cbResponsable
            // 
            this.fCamp_cbResponsable.FormattingEnabled = true;
            this.fCamp_cbResponsable.Location = new System.Drawing.Point(421, 81);
            this.fCamp_cbResponsable.Name = "fCamp_cbResponsable";
            this.fCamp_cbResponsable.Size = new System.Drawing.Size(121, 21);
            this.fCamp_cbResponsable.TabIndex = 54;
            // 
            // fCamp_BtAnnuler
            // 
            this.fCamp_BtAnnuler.Location = new System.Drawing.Point(262, 148);
            this.fCamp_BtAnnuler.Name = "fCamp_BtAnnuler";
            this.fCamp_BtAnnuler.Size = new System.Drawing.Size(93, 34);
            this.fCamp_BtAnnuler.TabIndex = 52;
            this.fCamp_BtAnnuler.Text = "Annuler";
            this.fCamp_BtAnnuler.UseVisualStyleBackColor = true;
            this.fCamp_BtAnnuler.Click += new System.EventHandler(this.fCamp_BtAnnuler_Click);
            // 
            // fCamp_BtValider
            // 
            this.fCamp_BtValider.Location = new System.Drawing.Point(18, 148);
            this.fCamp_BtValider.Name = "fCamp_BtValider";
            this.fCamp_BtValider.Size = new System.Drawing.Size(96, 34);
            this.fCamp_BtValider.TabIndex = 51;
            this.fCamp_BtValider.Text = "Valider";
            this.fCamp_BtValider.UseVisualStyleBackColor = true;
            this.fCamp_BtValider.Click += new System.EventHandler(this.fCamp_BtValider_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(320, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Agence artistique :\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Agence de communication :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Responsable :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Date de fin :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Date de début :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Publique :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Objectif:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Nom :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(568, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 196);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Rechercher";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 20);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // FrmCampagne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 549);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fCamp_GrpBox);
            this.Controls.Add(this.fCamp_DgCampagne);
            this.Name = "FrmCampagne";
            this.Text = "FrmCampagne";
            this.Load += new System.EventHandler(this.FrmCampagne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fCamp_DgCampagne)).EndInit();
            this.fCamp_GrpBox.ResumeLayout(false);
            this.fCamp_GrpBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView fCamp_DgCampagne;
        private System.Windows.Forms.GroupBox fCamp_GrpBox;
        private System.Windows.Forms.Button fCamp_BtSupprimer;
        private System.Windows.Forms.Button fCamp_BtModifier;
        private System.Windows.Forms.Label fCamp_TpSet_lblReponse;
        private System.Windows.Forms.TextBox fCamp_tbNom;
        private System.Windows.Forms.TextBox fCamp_tbObjectif;
        private System.Windows.Forms.TextBox fCamp_tbPublique;
        private System.Windows.Forms.DateTimePicker fCamp_dtDateFin;
        private System.Windows.Forms.DateTimePicker fCamp_dtDateDebut;
        private System.Windows.Forms.ComboBox fCamp_cbAgence2;
        private System.Windows.Forms.ComboBox fCamp_cbAgence1;
        private System.Windows.Forms.ComboBox fCamp_cbResponsable;
        private System.Windows.Forms.Button fCamp_BtAnnuler;
        private System.Windows.Forms.Button fCamp_BtValider;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;

    }
}