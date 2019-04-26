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
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtiste)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArtiste
            // 
            this.dgvArtiste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtiste.Location = new System.Drawing.Point(12, 98);
            this.dgvArtiste.Name = "dgvArtiste";
            this.dgvArtiste.Size = new System.Drawing.Size(579, 274);
            this.dgvArtiste.TabIndex = 0;
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
            this.txtBoxArtisteNom.Location = new System.Drawing.Point(50, 6);
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
            this.lbl_Artiste_Info.Location = new System.Drawing.Point(12, 52);
            this.lbl_Artiste_Info.Name = "lbl_Artiste_Info";
            this.lbl_Artiste_Info.Size = new System.Drawing.Size(0, 13);
            this.lbl_Artiste_Info.TabIndex = 50;
            // 
            // frmArtiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 384);
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
    }
}