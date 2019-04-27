namespace PPE4
{
    partial class frmAgence
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
            this.lbl_Agence_Info = new System.Windows.Forms.Label();
            this.btnAgenceCree = new System.Windows.Forms.Button();
            this.txtBoxAdresse = new System.Windows.Forms.TextBox();
            this.txtBoxTel = new System.Windows.Forms.TextBox();
            this.txtBoxMail = new System.Windows.Forms.TextBox();
            this.txtBoxSite = new System.Windows.Forms.TextBox();
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.txtBoxSpecialite = new System.Windows.Forms.TextBox();
            this.lbl_Agence_Adresse = new System.Windows.Forms.Label();
            this.lbl_Agence_Tel = new System.Windows.Forms.Label();
            this.lbl_Agence_Mail = new System.Windows.Forms.Label();
            this.lbl_Agence_Site = new System.Windows.Forms.Label();
            this.lbl_Agence_Nom = new System.Windows.Forms.Label();
            this.lbl_Agence_Spécialité = new System.Windows.Forms.Label();
            this.btnAgenceSup = new System.Windows.Forms.Button();
            this.btnAgenceModif = new System.Windows.Forms.Button();
            this.dgvAgence = new System.Windows.Forms.DataGridView();
            this.btnAgenceAnnuler = new System.Windows.Forms.Button();
            this.lbl_Agence_Ville = new System.Windows.Forms.Label();
            this.lbl_Agence_CP = new System.Windows.Forms.Label();
            this.txtBoxVille = new System.Windows.Forms.TextBox();
            this.txtBoxCP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgence)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Agence_Info
            // 
            this.lbl_Agence_Info.AutoSize = true;
            this.lbl_Agence_Info.Location = new System.Drawing.Point(69, 77);
            this.lbl_Agence_Info.Name = "lbl_Agence_Info";
            this.lbl_Agence_Info.Size = new System.Drawing.Size(0, 13);
            this.lbl_Agence_Info.TabIndex = 45;
            // 
            // btnAgenceCree
            // 
            this.btnAgenceCree.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAgenceCree.ForeColor = System.Drawing.Color.White;
            this.btnAgenceCree.Location = new System.Drawing.Point(774, 4);
            this.btnAgenceCree.Name = "btnAgenceCree";
            this.btnAgenceCree.Size = new System.Drawing.Size(106, 40);
            this.btnAgenceCree.TabIndex = 44;
            this.btnAgenceCree.Text = "Valider";
            this.btnAgenceCree.UseVisualStyleBackColor = false;
            this.btnAgenceCree.Click += new System.EventHandler(this.btnAgenceCree_Click);
            // 
            // txtBoxAdresse
            // 
            this.txtBoxAdresse.Location = new System.Drawing.Point(417, 46);
            this.txtBoxAdresse.Name = "txtBoxAdresse";
            this.txtBoxAdresse.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAdresse.TabIndex = 43;
            // 
            // txtBoxTel
            // 
            this.txtBoxTel.Location = new System.Drawing.Point(418, 11);
            this.txtBoxTel.Name = "txtBoxTel";
            this.txtBoxTel.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTel.TabIndex = 42;
            // 
            // txtBoxMail
            // 
            this.txtBoxMail.Location = new System.Drawing.Point(225, 46);
            this.txtBoxMail.Name = "txtBoxMail";
            this.txtBoxMail.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMail.TabIndex = 41;
            // 
            // txtBoxSite
            // 
            this.txtBoxSite.Location = new System.Drawing.Point(225, 11);
            this.txtBoxSite.Name = "txtBoxSite";
            this.txtBoxSite.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSite.TabIndex = 40;
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.Location = new System.Drawing.Point(71, 46);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNom.TabIndex = 39;
            // 
            // txtBoxSpecialite
            // 
            this.txtBoxSpecialite.Location = new System.Drawing.Point(72, 11);
            this.txtBoxSpecialite.Name = "txtBoxSpecialite";
            this.txtBoxSpecialite.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSpecialite.TabIndex = 38;
            // 
            // lbl_Agence_Adresse
            // 
            this.lbl_Agence_Adresse.AutoSize = true;
            this.lbl_Agence_Adresse.Location = new System.Drawing.Point(350, 46);
            this.lbl_Agence_Adresse.Name = "lbl_Agence_Adresse";
            this.lbl_Agence_Adresse.Size = new System.Drawing.Size(48, 13);
            this.lbl_Agence_Adresse.TabIndex = 37;
            this.lbl_Agence_Adresse.Text = "Adresse:";
            // 
            // lbl_Agence_Tel
            // 
            this.lbl_Agence_Tel.AutoSize = true;
            this.lbl_Agence_Tel.Location = new System.Drawing.Point(351, 14);
            this.lbl_Agence_Tel.Name = "lbl_Agence_Tel";
            this.lbl_Agence_Tel.Size = new System.Drawing.Size(61, 13);
            this.lbl_Agence_Tel.TabIndex = 36;
            this.lbl_Agence_Tel.Text = "Téléphone:";
            // 
            // lbl_Agence_Mail
            // 
            this.lbl_Agence_Mail.AutoSize = true;
            this.lbl_Agence_Mail.Location = new System.Drawing.Point(190, 49);
            this.lbl_Agence_Mail.Name = "lbl_Agence_Mail";
            this.lbl_Agence_Mail.Size = new System.Drawing.Size(29, 13);
            this.lbl_Agence_Mail.TabIndex = 35;
            this.lbl_Agence_Mail.Text = "Mail:";
            // 
            // lbl_Agence_Site
            // 
            this.lbl_Agence_Site.AutoSize = true;
            this.lbl_Agence_Site.Location = new System.Drawing.Point(191, 14);
            this.lbl_Agence_Site.Name = "lbl_Agence_Site";
            this.lbl_Agence_Site.Size = new System.Drawing.Size(28, 13);
            this.lbl_Agence_Site.TabIndex = 34;
            this.lbl_Agence_Site.Text = "Site:";
            // 
            // lbl_Agence_Nom
            // 
            this.lbl_Agence_Nom.AutoSize = true;
            this.lbl_Agence_Nom.Location = new System.Drawing.Point(4, 49);
            this.lbl_Agence_Nom.Name = "lbl_Agence_Nom";
            this.lbl_Agence_Nom.Size = new System.Drawing.Size(32, 13);
            this.lbl_Agence_Nom.TabIndex = 33;
            this.lbl_Agence_Nom.Text = "Nom:";
            // 
            // lbl_Agence_Spécialité
            // 
            this.lbl_Agence_Spécialité.AutoSize = true;
            this.lbl_Agence_Spécialité.Location = new System.Drawing.Point(5, 14);
            this.lbl_Agence_Spécialité.Name = "lbl_Agence_Spécialité";
            this.lbl_Agence_Spécialité.Size = new System.Drawing.Size(56, 13);
            this.lbl_Agence_Spécialité.TabIndex = 32;
            this.lbl_Agence_Spécialité.Text = "Spécialité:";
            // 
            // btnAgenceSup
            // 
            this.btnAgenceSup.BackColor = System.Drawing.Color.DarkRed;
            this.btnAgenceSup.ForeColor = System.Drawing.Color.White;
            this.btnAgenceSup.Location = new System.Drawing.Point(910, 50);
            this.btnAgenceSup.Name = "btnAgenceSup";
            this.btnAgenceSup.Size = new System.Drawing.Size(106, 40);
            this.btnAgenceSup.TabIndex = 31;
            this.btnAgenceSup.Text = "Supprimer";
            this.btnAgenceSup.UseVisualStyleBackColor = false;
            this.btnAgenceSup.Click += new System.EventHandler(this.btnAgenceSup_Click);
            // 
            // btnAgenceModif
            // 
            this.btnAgenceModif.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgenceModif.ForeColor = System.Drawing.Color.White;
            this.btnAgenceModif.Location = new System.Drawing.Point(774, 50);
            this.btnAgenceModif.Name = "btnAgenceModif";
            this.btnAgenceModif.Size = new System.Drawing.Size(106, 40);
            this.btnAgenceModif.TabIndex = 30;
            this.btnAgenceModif.Text = "Modifier";
            this.btnAgenceModif.UseVisualStyleBackColor = false;
            this.btnAgenceModif.Click += new System.EventHandler(this.btnAgenceModif_Click);
            // 
            // dgvAgence
            // 
            this.dgvAgence.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAgence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgence.Location = new System.Drawing.Point(11, 96);
            this.dgvAgence.Name = "dgvAgence";
            this.dgvAgence.Size = new System.Drawing.Size(1005, 354);
            this.dgvAgence.TabIndex = 29;
            this.dgvAgence.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgence_RowEnter);
            // 
            // btnAgenceAnnuler
            // 
            this.btnAgenceAnnuler.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAgenceAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAgenceAnnuler.Location = new System.Drawing.Point(910, 4);
            this.btnAgenceAnnuler.Name = "btnAgenceAnnuler";
            this.btnAgenceAnnuler.Size = new System.Drawing.Size(106, 40);
            this.btnAgenceAnnuler.TabIndex = 46;
            this.btnAgenceAnnuler.Text = "Annuler";
            this.btnAgenceAnnuler.UseVisualStyleBackColor = false;
            this.btnAgenceAnnuler.Click += new System.EventHandler(this.btnAgenceAnnuler_Click);
            // 
            // lbl_Agence_Ville
            // 
            this.lbl_Agence_Ville.AutoSize = true;
            this.lbl_Agence_Ville.Location = new System.Drawing.Point(545, 14);
            this.lbl_Agence_Ville.Name = "lbl_Agence_Ville";
            this.lbl_Agence_Ville.Size = new System.Drawing.Size(29, 13);
            this.lbl_Agence_Ville.TabIndex = 47;
            this.lbl_Agence_Ville.Text = "Ville:";
            // 
            // lbl_Agence_CP
            // 
            this.lbl_Agence_CP.AutoSize = true;
            this.lbl_Agence_CP.Location = new System.Drawing.Point(545, 53);
            this.lbl_Agence_CP.Name = "lbl_Agence_CP";
            this.lbl_Agence_CP.Size = new System.Drawing.Size(67, 13);
            this.lbl_Agence_CP.TabIndex = 48;
            this.lbl_Agence_CP.Text = "Code Postal:";
            // 
            // txtBoxVille
            // 
            this.txtBoxVille.Location = new System.Drawing.Point(618, 11);
            this.txtBoxVille.Name = "txtBoxVille";
            this.txtBoxVille.Size = new System.Drawing.Size(100, 20);
            this.txtBoxVille.TabIndex = 49;
            // 
            // txtBoxCP
            // 
            this.txtBoxCP.Location = new System.Drawing.Point(618, 50);
            this.txtBoxCP.Name = "txtBoxCP";
            this.txtBoxCP.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCP.TabIndex = 50;
            // 
            // frmAgence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 462);
            this.Controls.Add(this.txtBoxCP);
            this.Controls.Add(this.txtBoxVille);
            this.Controls.Add(this.lbl_Agence_CP);
            this.Controls.Add(this.lbl_Agence_Ville);
            this.Controls.Add(this.btnAgenceAnnuler);
            this.Controls.Add(this.lbl_Agence_Info);
            this.Controls.Add(this.btnAgenceCree);
            this.Controls.Add(this.txtBoxAdresse);
            this.Controls.Add(this.txtBoxTel);
            this.Controls.Add(this.txtBoxMail);
            this.Controls.Add(this.txtBoxSite);
            this.Controls.Add(this.txtBoxNom);
            this.Controls.Add(this.txtBoxSpecialite);
            this.Controls.Add(this.lbl_Agence_Adresse);
            this.Controls.Add(this.lbl_Agence_Tel);
            this.Controls.Add(this.lbl_Agence_Mail);
            this.Controls.Add(this.lbl_Agence_Site);
            this.Controls.Add(this.lbl_Agence_Nom);
            this.Controls.Add(this.lbl_Agence_Spécialité);
            this.Controls.Add(this.btnAgenceSup);
            this.Controls.Add(this.btnAgenceModif);
            this.Controls.Add(this.dgvAgence);
            this.Name = "frmAgence";
            this.Text = "Agence";
            this.Load += new System.EventHandler(this.frmAgence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Agence_Info;
        private System.Windows.Forms.Button btnAgenceCree;
        private System.Windows.Forms.TextBox txtBoxAdresse;
        private System.Windows.Forms.TextBox txtBoxTel;
        private System.Windows.Forms.TextBox txtBoxMail;
        private System.Windows.Forms.TextBox txtBoxSite;
        private System.Windows.Forms.TextBox txtBoxNom;
        private System.Windows.Forms.TextBox txtBoxSpecialite;
        private System.Windows.Forms.Label lbl_Agence_Adresse;
        private System.Windows.Forms.Label lbl_Agence_Tel;
        private System.Windows.Forms.Label lbl_Agence_Mail;
        private System.Windows.Forms.Label lbl_Agence_Site;
        private System.Windows.Forms.Label lbl_Agence_Nom;
        private System.Windows.Forms.Label lbl_Agence_Spécialité;
        private System.Windows.Forms.Button btnAgenceSup;
        private System.Windows.Forms.Button btnAgenceModif;
        private System.Windows.Forms.DataGridView dgvAgence;
        private System.Windows.Forms.Button btnAgenceAnnuler;
        private System.Windows.Forms.Label lbl_Agence_Ville;
        private System.Windows.Forms.Label lbl_Agence_CP;
        private System.Windows.Forms.TextBox txtBoxVille;
        private System.Windows.Forms.TextBox txtBoxCP;
    }
}