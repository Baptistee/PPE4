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
            this.btnArtisteDetails = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtiste)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArtiste
            // 
            this.dgvArtiste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArtiste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtiste.Location = new System.Drawing.Point(12, 144);
            this.dgvArtiste.Name = "dgvArtiste";
            this.dgvArtiste.Size = new System.Drawing.Size(579, 322);
            this.dgvArtiste.TabIndex = 0;
            this.dgvArtiste.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArtiste_RowEnter_1);
            this.dgvArtiste.Enter += new System.EventHandler(this.dataGridView1_Enter);
            // 
            // lbl_Artiste_nom
            // 
            this.lbl_Artiste_nom.AutoSize = true;
            this.lbl_Artiste_nom.Location = new System.Drawing.Point(12, 53);
            this.lbl_Artiste_nom.Name = "lbl_Artiste_nom";
            this.lbl_Artiste_nom.Size = new System.Drawing.Size(32, 13);
            this.lbl_Artiste_nom.TabIndex = 1;
            this.lbl_Artiste_nom.Text = "Nom:";
            // 
            // txtBoxArtisteNom
            // 
            this.txtBoxArtisteNom.Location = new System.Drawing.Point(64, 50);
            this.txtBoxArtisteNom.Name = "txtBoxArtisteNom";
            this.txtBoxArtisteNom.Size = new System.Drawing.Size(100, 20);
            this.txtBoxArtisteNom.TabIndex = 2;
            // 
            // btnArtisteCree
            // 
            this.btnArtisteCree.BackColor = System.Drawing.Color.YellowGreen;
            this.btnArtisteCree.ForeColor = System.Drawing.Color.White;
            this.btnArtisteCree.Location = new System.Drawing.Point(373, 50);
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
            this.btnArtisteAnnuler.Location = new System.Drawing.Point(485, 50);
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
            this.btnArtisteModif.Location = new System.Drawing.Point(373, 96);
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
            this.btnArtisteSup.Location = new System.Drawing.Point(485, 96);
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
            this.lbl_Artiste_Info.Location = new System.Drawing.Point(12, 123);
            this.lbl_Artiste_Info.Name = "lbl_Artiste_Info";
            this.lbl_Artiste_Info.Size = new System.Drawing.Size(0, 13);
            this.lbl_Artiste_Info.TabIndex = 50;
            // 
            // lbl_Artiste_prenom
            // 
            this.lbl_Artiste_prenom.AutoSize = true;
            this.lbl_Artiste_prenom.Location = new System.Drawing.Point(12, 92);
            this.lbl_Artiste_prenom.Name = "lbl_Artiste_prenom";
            this.lbl_Artiste_prenom.Size = new System.Drawing.Size(46, 13);
            this.lbl_Artiste_prenom.TabIndex = 51;
            this.lbl_Artiste_prenom.Text = "Prenom:";
            // 
            // lbl_Artiste_mail
            // 
            this.lbl_Artiste_mail.AutoSize = true;
            this.lbl_Artiste_mail.Location = new System.Drawing.Point(176, 53);
            this.lbl_Artiste_mail.Name = "lbl_Artiste_mail";
            this.lbl_Artiste_mail.Size = new System.Drawing.Size(29, 13);
            this.lbl_Artiste_mail.TabIndex = 52;
            this.lbl_Artiste_mail.Text = "Mail:";
            // 
            // lbl_Artiste_num
            // 
            this.lbl_Artiste_num.AutoSize = true;
            this.lbl_Artiste_num.Location = new System.Drawing.Point(176, 92);
            this.lbl_Artiste_num.Name = "lbl_Artiste_num";
            this.lbl_Artiste_num.Size = new System.Drawing.Size(61, 13);
            this.lbl_Artiste_num.TabIndex = 53;
            this.lbl_Artiste_num.Text = "Téléphone:";
            // 
            // txtBoxArtistePrenom
            // 
            this.txtBoxArtistePrenom.Location = new System.Drawing.Point(64, 89);
            this.txtBoxArtistePrenom.Name = "txtBoxArtistePrenom";
            this.txtBoxArtistePrenom.Size = new System.Drawing.Size(100, 20);
            this.txtBoxArtistePrenom.TabIndex = 54;
            // 
            // txtBoxArtisteMail
            // 
            this.txtBoxArtisteMail.Location = new System.Drawing.Point(243, 50);
            this.txtBoxArtisteMail.Name = "txtBoxArtisteMail";
            this.txtBoxArtisteMail.Size = new System.Drawing.Size(100, 20);
            this.txtBoxArtisteMail.TabIndex = 55;
            // 
            // txtBoxArtisteTel
            // 
            this.txtBoxArtisteTel.Location = new System.Drawing.Point(243, 89);
            this.txtBoxArtisteTel.Name = "txtBoxArtisteTel";
            this.txtBoxArtisteTel.Size = new System.Drawing.Size(100, 20);
            this.txtBoxArtisteTel.TabIndex = 56;
            // 
            // btnArtisteDetails
            // 
            this.btnArtisteDetails.Location = new System.Drawing.Point(268, 115);
            this.btnArtisteDetails.Name = "btnArtisteDetails";
            this.btnArtisteDetails.Size = new System.Drawing.Size(75, 23);
            this.btnArtisteDetails.TabIndex = 57;
            this.btnArtisteDetails.Text = "Détails";
            this.btnArtisteDetails.UseVisualStyleBackColor = true;
            this.btnArtisteDetails.Click += new System.EventHandler(this.btnArtisteDetails_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 37);
            this.panel1.TabIndex = 58;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(441, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(558, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 37);
            this.button2.TabIndex = 59;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 60;
            this.label1.Text = "Artiste";
            // 
            // frmArtiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 478);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnArtisteDetails);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmArtiste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmArtiste";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtiste)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button btnArtisteDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}