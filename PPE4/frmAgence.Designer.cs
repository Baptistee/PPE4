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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgence)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Agence_Info
            // 
            this.lbl_Agence_Info.AutoSize = true;
            this.lbl_Agence_Info.Location = new System.Drawing.Point(250, 96);
            this.lbl_Agence_Info.Name = "lbl_Agence_Info";
            this.lbl_Agence_Info.Size = new System.Drawing.Size(0, 13);
            this.lbl_Agence_Info.TabIndex = 45;
            // 
            // btnAgenceCree
            // 
            this.btnAgenceCree.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAgenceCree.ForeColor = System.Drawing.Color.White;
            this.btnAgenceCree.Location = new System.Drawing.Point(253, 128);
            this.btnAgenceCree.Name = "btnAgenceCree";
            this.btnAgenceCree.Size = new System.Drawing.Size(106, 40);
            this.btnAgenceCree.TabIndex = 44;
            this.btnAgenceCree.Text = "Valider";
            this.btnAgenceCree.UseVisualStyleBackColor = false;
            this.btnAgenceCree.Click += new System.EventHandler(this.btnAgenceCree_Click);
            // 
            // txtBoxAdresse
            // 
            this.txtBoxAdresse.Location = new System.Drawing.Point(88, 148);
            this.txtBoxAdresse.Name = "txtBoxAdresse";
            this.txtBoxAdresse.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAdresse.TabIndex = 43;
            // 
            // txtBoxTel
            // 
            this.txtBoxTel.Location = new System.Drawing.Point(88, 122);
            this.txtBoxTel.Name = "txtBoxTel";
            this.txtBoxTel.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTel.TabIndex = 42;
            // 
            // txtBoxMail
            // 
            this.txtBoxMail.Location = new System.Drawing.Point(88, 96);
            this.txtBoxMail.Name = "txtBoxMail";
            this.txtBoxMail.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMail.TabIndex = 41;
            // 
            // txtBoxSite
            // 
            this.txtBoxSite.Location = new System.Drawing.Point(88, 70);
            this.txtBoxSite.Name = "txtBoxSite";
            this.txtBoxSite.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSite.TabIndex = 40;
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.Location = new System.Drawing.Point(88, 44);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNom.TabIndex = 39;
            // 
            // txtBoxSpecialite
            // 
            this.txtBoxSpecialite.Location = new System.Drawing.Point(88, 18);
            this.txtBoxSpecialite.Name = "txtBoxSpecialite";
            this.txtBoxSpecialite.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSpecialite.TabIndex = 38;
            // 
            // lbl_Agence_Adresse
            // 
            this.lbl_Agence_Adresse.AutoSize = true;
            this.lbl_Agence_Adresse.Location = new System.Drawing.Point(21, 148);
            this.lbl_Agence_Adresse.Name = "lbl_Agence_Adresse";
            this.lbl_Agence_Adresse.Size = new System.Drawing.Size(48, 13);
            this.lbl_Agence_Adresse.TabIndex = 37;
            this.lbl_Agence_Adresse.Text = "Adresse:";
            // 
            // lbl_Agence_Tel
            // 
            this.lbl_Agence_Tel.AutoSize = true;
            this.lbl_Agence_Tel.Location = new System.Drawing.Point(21, 125);
            this.lbl_Agence_Tel.Name = "lbl_Agence_Tel";
            this.lbl_Agence_Tel.Size = new System.Drawing.Size(61, 13);
            this.lbl_Agence_Tel.TabIndex = 36;
            this.lbl_Agence_Tel.Text = "Téléphone:";
            // 
            // lbl_Agence_Mail
            // 
            this.lbl_Agence_Mail.AutoSize = true;
            this.lbl_Agence_Mail.Location = new System.Drawing.Point(21, 99);
            this.lbl_Agence_Mail.Name = "lbl_Agence_Mail";
            this.lbl_Agence_Mail.Size = new System.Drawing.Size(29, 13);
            this.lbl_Agence_Mail.TabIndex = 35;
            this.lbl_Agence_Mail.Text = "Mail:";
            // 
            // lbl_Agence_Site
            // 
            this.lbl_Agence_Site.AutoSize = true;
            this.lbl_Agence_Site.Location = new System.Drawing.Point(21, 73);
            this.lbl_Agence_Site.Name = "lbl_Agence_Site";
            this.lbl_Agence_Site.Size = new System.Drawing.Size(28, 13);
            this.lbl_Agence_Site.TabIndex = 34;
            this.lbl_Agence_Site.Text = "Site:";
            // 
            // lbl_Agence_Nom
            // 
            this.lbl_Agence_Nom.AutoSize = true;
            this.lbl_Agence_Nom.Location = new System.Drawing.Point(21, 47);
            this.lbl_Agence_Nom.Name = "lbl_Agence_Nom";
            this.lbl_Agence_Nom.Size = new System.Drawing.Size(32, 13);
            this.lbl_Agence_Nom.TabIndex = 33;
            this.lbl_Agence_Nom.Text = "Nom:";
            // 
            // lbl_Agence_Spécialité
            // 
            this.lbl_Agence_Spécialité.AutoSize = true;
            this.lbl_Agence_Spécialité.Location = new System.Drawing.Point(21, 21);
            this.lbl_Agence_Spécialité.Name = "lbl_Agence_Spécialité";
            this.lbl_Agence_Spécialité.Size = new System.Drawing.Size(56, 13);
            this.lbl_Agence_Spécialité.TabIndex = 32;
            this.lbl_Agence_Spécialité.Text = "Spécialité:";
            // 
            // btnAgenceSup
            // 
            this.btnAgenceSup.BackColor = System.Drawing.Color.Firebrick;
            this.btnAgenceSup.ForeColor = System.Drawing.Color.White;
            this.btnAgenceSup.Location = new System.Drawing.Point(554, 128);
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
            this.btnAgenceModif.Location = new System.Drawing.Point(406, 128);
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
            this.dgvAgence.Location = new System.Drawing.Point(11, 174);
            this.dgvAgence.Name = "dgvAgence";
            this.dgvAgence.Size = new System.Drawing.Size(792, 276);
            this.dgvAgence.TabIndex = 29;
            this.dgvAgence.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgence_RowEnter_1);
            // 
            // frmAgence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 462);
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


    }
}