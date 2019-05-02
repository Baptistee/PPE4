namespace PPE4
{
    partial class frmArtiste
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
            this.dgvArtiste = new System.Windows.Forms.DataGridView();
            this.lbl_Artiste_nom = new System.Windows.Forms.Label();
            this.txtBoxArtisteNom = new System.Windows.Forms.TextBox();
            this.btnArtisteCree = new System.Windows.Forms.Button();
            this.btnArtisteAnnuler = new System.Windows.Forms.Button();
            this.btnArtisteModif = new System.Windows.Forms.Button();
            this.btnArtisteSup = new System.Windows.Forms.Button();
            this.lbl_Artiste_Info = new System.Windows.Forms.Label();
            this.lbl_Artiste_prenom = new System.Windows.Forms.Label();
            this.lbl_Artiste_mail = new System.Windows.Forms.Label();
            this.lbl_Artiste_num = new System.Windows.Forms.Label();
            this.txtBoxArtistePrenom = new System.Windows.Forms.TextBox();
            this.txtBoxArtisteMail = new System.Windows.Forms.TextBox();
            this.txtBoxArtisteTel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtiste)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArtiste
            // 
            this.dgvArtiste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArtiste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtiste.Location = new System.Drawing.Point(12, 98);
            this.dgvArtiste.Name = "dgvArtiste";
            this.dgvArtiste.Size = new System.Drawing.Size(579, 274);
            this.dgvArtiste.TabIndex = 0;
            this.dgvArtiste.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArtiste_RowEnter_1);
            this.dgvArtiste.Enter += new System.EventHandler(this.dataGridView1_Enter);
            // 
            // lbl_Artiste_nom
            // 
            this.lbl_Artiste_nom.AutoSize = true;
            this.lbl_Artiste_nom.Location = new System.Drawing.Point(12, 9);
            this.lbl_Artiste_nom.Name = "lbl_Artiste_nom";
            this.lbl_Artiste_nom.Size = new System.Drawing.Size(32, 13);
            this.lbl_Artiste_nom.TabIndex = 1;
            this.lbl_Artiste_nom.Text = "Nom:";
            // 
            // txtBoxArtisteNom
            // 
            this.txtBoxArtisteNom.Location = new System.Drawing.Point(64, 6);
            this.txtBoxArtisteNom.Name = "txtBoxArtisteNom";
            this.txtBoxArtisteNom.Size = new System.Drawing.Size(100, 20);
            this.txtBoxArtisteNom.TabIndex = 2;
            // 
            // btnArtisteCree
            // 
            this.btnArtisteCree.BackColor = System.Drawing.Color.YellowGreen;
            this.btnArtisteCree.ForeColor = System.Drawing.Color.White;
            this.btnArtisteCree.Location = new System.Drawing.Point(373, 6);
            this.btnArtisteCree.Name = "btnArtisteCree";
            this.btnArtisteCree.Size = new System.Drawing.Size(106, 40);
            this.btnArtisteCree.TabIndex = 45;
            this.btnArtisteCree.Text = "Valider";
            this.btnArtisteCree.UseVisualStyleBackColor = false;
            this.btnArtisteCree.Click += new System.EventHandler(this.btnArtisteCree_Click);
            // 
            // btnArtisteAnnuler
            // 
            this.btnArtisteAnnuler.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnArtisteAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnArtisteAnnuler.Location = new System.Drawing.Point(485, 6);
            this.btnArtisteAnnuler.Name = "btnArtisteAnnuler";
            this.btnArtisteAnnuler.Size = new System.Drawing.Size(106, 40);
            this.btnArtisteAnnuler.TabIndex = 47;
            this.btnArtisteAnnuler.Text = "Annuler";
            this.btnArtisteAnnuler.UseVisualStyleBackColor = false;
            this.btnArtisteAnnuler.Click += new System.EventHandler(this.btnArtisteAnnuler_Click_1);
            // 
            // btnArtisteModif
            // 
            this.btnArtisteModif.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnArtisteModif.ForeColor = System.Drawing.Color.White;
            this.btnArtisteModif.Location = new System.Drawing.Point(373, 52);
            this.btnArtisteModif.Name = "btnArtisteModif";
            this.btnArtisteModif.Size = new System.Drawing.Size(106, 40);
            this.btnArtisteModif.TabIndex = 48;
            this.btnArtisteModif.Text = "Modifier";
            this.btnArtisteModif.UseVisualStyleBackColor = false;
            this.btnArtisteModif.Click += new System.EventHandler(this.btnArtisteModif_Click);
            // 
            // btnArtisteSup
            // 
            this.btnArtisteSup.BackColor = System.Drawing.Color.DarkRed;
            this.btnArtisteSup.ForeColor = System.Drawing.Color.White;
            this.btnArtisteSup.Location = new System.Drawing.Point(485, 52);
            this.btnArtisteSup.Name = "btnArtisteSup";
            this.btnArtisteSup.Size = new System.Drawing.Size(106, 40);
            this.btnArtisteSup.TabIndex = 49;
            this.btnArtisteSup.Text = "Supprimer";
            this.btnArtisteSup.UseVisualStyleBackColor = false;
            this.btnArtisteSup.Click += new System.EventHandler(this.btnArtisteSup_Click);
            // 
            // lbl_Artiste_Info
            // 
            this.lbl_Artiste_Info.AutoSize = true;
            this.lbl_Artiste_Info.Location = new System.Drawing.Point(12, 79);
            this.lbl_Artiste_Info.Name = "lbl_Artiste_Info";
            this.lbl_Artiste_Info.Size = new System.Drawing.Size(0, 13);
            this.lbl_Artiste_Info.TabIndex = 50;
            // 
            // lbl_Artiste_prenom
            // 
            this.lbl_Artiste_prenom.AutoSize = true;
            this.lbl_Artiste_prenom.Location = new System.Drawing.Point(12, 48);
            this.lbl_Artiste_prenom.Name = "lbl_Artiste_prenom";
            this.lbl_Artiste_prenom.Size = new System.Drawing.Size(46, 13);
            this.lbl_Artiste_prenom.TabIndex = 51;
            this.lbl_Artiste_prenom.Text = "Prenom:";
            // 
            // lbl_Artiste_mail
            // 
            this.lbl_Artiste_mail.AutoSize = true;
            this.lbl_Artiste_mail.Location = new System.Drawing.Point(176, 9);
            this.lbl_Artiste_mail.Name = "lbl_Artiste_mail";
            this.lbl_Artiste_mail.Size = new System.Drawing.Size(29, 13);
            this.lbl_Artiste_mail.TabIndex = 52;
            this.lbl_Artiste_mail.Text = "Mail:";
            // 
            // lbl_Artiste_num
            // 
            this.lbl_Artiste_num.AutoSize = true;
            this.lbl_Artiste_num.Location = new System.Drawing.Point(176, 48);
            this.lbl_Artiste_num.Name = "lbl_Artiste_num";
            this.lbl_Artiste_num.Size = new System.Drawing.Size(61, 13);
            this.lbl_Artiste_num.TabIndex = 53;
            this.lbl_Artiste_num.Text = "Téléphone:";
            // 
            // txtBoxArtistePrenom
            // 
            this.txtBoxArtistePrenom.Location = new System.Drawing.Point(64, 45);
            this.txtBoxArtistePrenom.Name = "txtBoxArtistePrenom";
            this.txtBoxArtistePrenom.Size = new System.Drawing.Size(100, 20);
            this.txtBoxArtistePrenom.TabIndex = 54;
            // 
            // txtBoxArtisteMail
            // 
            this.txtBoxArtisteMail.Location = new System.Drawing.Point(243, 6);
            this.txtBoxArtisteMail.Name = "txtBoxArtisteMail";
            this.txtBoxArtisteMail.Size = new System.Drawing.Size(100, 20);
            this.txtBoxArtisteMail.TabIndex = 55;
            // 
            // txtBoxArtisteTel
            // 
            this.txtBoxArtisteTel.Location = new System.Drawing.Point(243, 45);
            this.txtBoxArtisteTel.Name = "txtBoxArtisteTel";
            this.txtBoxArtisteTel.Size = new System.Drawing.Size(100, 20);
            this.txtBoxArtisteTel.TabIndex = 56;
            // 
            // frmArtiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 384);
            this.Controls.Add(this.txtBoxArtisteTel);
            this.Controls.Add(this.txtBoxArtisteMail);
            this.Controls.Add(this.txtBoxArtistePrenom);
            this.Controls.Add(this.lbl_Artiste_num);
            this.Controls.Add(this.lbl_Artiste_mail);
            this.Controls.Add(this.lbl_Artiste_prenom);
            this.Controls.Add(this.lbl_Artiste_Info);
            this.Controls.Add(this.btnArtisteSup);
            this.Controls.Add(this.btnArtisteModif);
            this.Controls.Add(this.btnArtisteAnnuler);
            this.Controls.Add(this.btnArtisteCree);
            this.Controls.Add(this.txtBoxArtisteNom);
            this.Controls.Add(this.lbl_Artiste_nom);
            this.Controls.Add(this.dgvArtiste);
            this.Name = "frmArtiste";
            this.Text = "frmArtiste";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtiste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArtiste;
        private System.Windows.Forms.Label lbl_Artiste_nom;
        private System.Windows.Forms.TextBox txtBoxArtisteNom;
        private System.Windows.Forms.Button btnArtisteCree;
        private System.Windows.Forms.Button btnArtisteAnnuler;
        private System.Windows.Forms.Button btnArtisteModif;
        private System.Windows.Forms.Button btnArtisteSup;
        private System.Windows.Forms.Label lbl_Artiste_Info;
        private System.Windows.Forms.Label lbl_Artiste_prenom;
        private System.Windows.Forms.Label lbl_Artiste_mail;
        private System.Windows.Forms.Label lbl_Artiste_num;
        private System.Windows.Forms.TextBox txtBoxArtistePrenom;
        private System.Windows.Forms.TextBox txtBoxArtisteMail;
        private System.Windows.Forms.TextBox txtBoxArtisteTel;
    }
}