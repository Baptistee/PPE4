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
            this.tabControlAgence = new System.Windows.Forms.TabControl();
            this.tabPageConsulterAgence = new System.Windows.Forms.TabPage();
            this.dgvAgence = new System.Windows.Forms.DataGridView();
            this.tabPageCreerAgence = new System.Windows.Forms.TabPage();
            this.lblValid = new System.Windows.Forms.Label();
            this.btnCreeAgenceAnnuler = new System.Windows.Forms.Button();
            this.btnCreeAgenceValider = new System.Windows.Forms.Button();
            this.txtBoxAdresse = new System.Windows.Forms.TextBox();
            this.txtBoxTel = new System.Windows.Forms.TextBox();
            this.txtBoxMail = new System.Windows.Forms.TextBox();
            this.txtBoxSite = new System.Windows.Forms.TextBox();
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.txtboxSpecialite = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblSite = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblSpe = new System.Windows.Forms.Label();
            this.tabControlAgence.SuspendLayout();
            this.tabPageConsulterAgence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgence)).BeginInit();
            this.tabPageCreerAgence.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAgence
            // 
            this.tabControlAgence.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlAgence.Controls.Add(this.tabPageConsulterAgence);
            this.tabControlAgence.Controls.Add(this.tabPageCreerAgence);
            this.tabControlAgence.Location = new System.Drawing.Point(1, 3);
            this.tabControlAgence.Name = "tabControlAgence";
            this.tabControlAgence.SelectedIndex = 0;
            this.tabControlAgence.Size = new System.Drawing.Size(816, 458);
            this.tabControlAgence.TabIndex = 0;
            // 
            // tabPageConsulterAgence
            // 
            this.tabPageConsulterAgence.Controls.Add(this.dgvAgence);
            this.tabPageConsulterAgence.Location = new System.Drawing.Point(4, 22);
            this.tabPageConsulterAgence.Name = "tabPageConsulterAgence";
            this.tabPageConsulterAgence.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConsulterAgence.Size = new System.Drawing.Size(808, 432);
            this.tabPageConsulterAgence.TabIndex = 0;
            this.tabPageConsulterAgence.Text = "Consulter";
            this.tabPageConsulterAgence.UseVisualStyleBackColor = true;
            this.tabPageConsulterAgence.Enter += new System.EventHandler(this.tabPageConsulterAgence_Enter);
            // 
            // dgvAgence
            // 
            this.dgvAgence.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAgence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgence.Location = new System.Drawing.Point(3, 3);
            this.dgvAgence.Name = "dgvAgence";
            this.dgvAgence.Size = new System.Drawing.Size(805, 433);
            this.dgvAgence.TabIndex = 0;
            // 
            // tabPageCreerAgence
            // 
            this.tabPageCreerAgence.Controls.Add(this.lblValid);
            this.tabPageCreerAgence.Controls.Add(this.btnCreeAgenceAnnuler);
            this.tabPageCreerAgence.Controls.Add(this.btnCreeAgenceValider);
            this.tabPageCreerAgence.Controls.Add(this.txtBoxAdresse);
            this.tabPageCreerAgence.Controls.Add(this.txtBoxTel);
            this.tabPageCreerAgence.Controls.Add(this.txtBoxMail);
            this.tabPageCreerAgence.Controls.Add(this.txtBoxSite);
            this.tabPageCreerAgence.Controls.Add(this.txtBoxNom);
            this.tabPageCreerAgence.Controls.Add(this.txtboxSpecialite);
            this.tabPageCreerAgence.Controls.Add(this.lblAdresse);
            this.tabPageCreerAgence.Controls.Add(this.lblTel);
            this.tabPageCreerAgence.Controls.Add(this.lblMail);
            this.tabPageCreerAgence.Controls.Add(this.lblSite);
            this.tabPageCreerAgence.Controls.Add(this.lblNom);
            this.tabPageCreerAgence.Controls.Add(this.lblSpe);
            this.tabPageCreerAgence.Location = new System.Drawing.Point(4, 22);
            this.tabPageCreerAgence.Name = "tabPageCreerAgence";
            this.tabPageCreerAgence.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCreerAgence.Size = new System.Drawing.Size(753, 391);
            this.tabPageCreerAgence.TabIndex = 1;
            this.tabPageCreerAgence.Text = "Créer";
            this.tabPageCreerAgence.UseVisualStyleBackColor = true;
            this.tabPageCreerAgence.Click += new System.EventHandler(this.tabPageCreerAgence_Click);
            // 
            // lblValid
            // 
            this.lblValid.AutoSize = true;
            this.lblValid.Location = new System.Drawing.Point(118, 331);
            this.lblValid.Name = "lblValid";
            this.lblValid.Size = new System.Drawing.Size(0, 13);
            this.lblValid.TabIndex = 14;
            // 
            // btnCreeAgenceAnnuler
            // 
            this.btnCreeAgenceAnnuler.BackColor = System.Drawing.Color.Firebrick;
            this.btnCreeAgenceAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnCreeAgenceAnnuler.Location = new System.Drawing.Point(553, 333);
            this.btnCreeAgenceAnnuler.Name = "btnCreeAgenceAnnuler";
            this.btnCreeAgenceAnnuler.Size = new System.Drawing.Size(106, 38);
            this.btnCreeAgenceAnnuler.TabIndex = 13;
            this.btnCreeAgenceAnnuler.Text = "Annuler";
            this.btnCreeAgenceAnnuler.UseVisualStyleBackColor = false;
            this.btnCreeAgenceAnnuler.Click += new System.EventHandler(this.btnCreeAgenceAnnuler_Click);
            // 
            // btnCreeAgenceValider
            // 
            this.btnCreeAgenceValider.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCreeAgenceValider.ForeColor = System.Drawing.Color.White;
            this.btnCreeAgenceValider.Location = new System.Drawing.Point(390, 331);
            this.btnCreeAgenceValider.Name = "btnCreeAgenceValider";
            this.btnCreeAgenceValider.Size = new System.Drawing.Size(106, 40);
            this.btnCreeAgenceValider.TabIndex = 12;
            this.btnCreeAgenceValider.Text = "Valider";
            this.btnCreeAgenceValider.UseVisualStyleBackColor = false;
            this.btnCreeAgenceValider.Click += new System.EventHandler(this.btnCreeAgenceValider_Click);
            // 
            // txtBoxAdresse
            // 
            this.txtBoxAdresse.Location = new System.Drawing.Point(185, 241);
            this.txtBoxAdresse.Name = "txtBoxAdresse";
            this.txtBoxAdresse.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAdresse.TabIndex = 11;
            // 
            // txtBoxTel
            // 
            this.txtBoxTel.Location = new System.Drawing.Point(185, 207);
            this.txtBoxTel.Name = "txtBoxTel";
            this.txtBoxTel.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTel.TabIndex = 10;
            // 
            // txtBoxMail
            // 
            this.txtBoxMail.Location = new System.Drawing.Point(185, 173);
            this.txtBoxMail.Name = "txtBoxMail";
            this.txtBoxMail.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMail.TabIndex = 9;
            // 
            // txtBoxSite
            // 
            this.txtBoxSite.Location = new System.Drawing.Point(185, 136);
            this.txtBoxSite.Name = "txtBoxSite";
            this.txtBoxSite.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSite.TabIndex = 8;
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.Location = new System.Drawing.Point(185, 96);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNom.TabIndex = 7;
            // 
            // txtboxSpecialite
            // 
            this.txtboxSpecialite.Location = new System.Drawing.Point(185, 63);
            this.txtboxSpecialite.Name = "txtboxSpecialite";
            this.txtboxSpecialite.Size = new System.Drawing.Size(100, 20);
            this.txtboxSpecialite.TabIndex = 6;
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(118, 241);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(48, 13);
            this.lblAdresse.TabIndex = 5;
            this.lblAdresse.Text = "Adresse:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(118, 210);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(61, 13);
            this.lblTel.TabIndex = 4;
            this.lblTel.Text = "Téléphone:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(118, 176);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(29, 13);
            this.lblMail.TabIndex = 3;
            this.lblMail.Text = "Mail:";
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(118, 139);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(28, 13);
            this.lblSite.TabIndex = 2;
            this.lblSite.Text = "Site:";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(118, 99);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(32, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom:";
            // 
            // lblSpe
            // 
            this.lblSpe.AutoSize = true;
            this.lblSpe.Location = new System.Drawing.Point(118, 66);
            this.lblSpe.Name = "lblSpe";
            this.lblSpe.Size = new System.Drawing.Size(56, 13);
            this.lblSpe.TabIndex = 0;
            this.lblSpe.Text = "Spécialité:";
            // 
            // frmAgence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 462);
            this.Controls.Add(this.tabControlAgence);
            this.Name = "frmAgence";
            this.Text = "Agence";
            this.tabControlAgence.ResumeLayout(false);
            this.tabPageConsulterAgence.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgence)).EndInit();
            this.tabPageCreerAgence.ResumeLayout(false);
            this.tabPageCreerAgence.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAgence;
        private System.Windows.Forms.TabPage tabPageConsulterAgence;
        private System.Windows.Forms.TabPage tabPageCreerAgence;
        private System.Windows.Forms.DataGridView dgvAgence;
        private System.Windows.Forms.TextBox txtBoxAdresse;
        private System.Windows.Forms.TextBox txtBoxTel;
        private System.Windows.Forms.TextBox txtBoxMail;
        private System.Windows.Forms.TextBox txtBoxSite;
        private System.Windows.Forms.TextBox txtBoxNom;
        private System.Windows.Forms.TextBox txtboxSpecialite;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblSpe;
        private System.Windows.Forms.Button btnCreeAgenceAnnuler;
        private System.Windows.Forms.Button btnCreeAgenceValider;
        private System.Windows.Forms.Label lblValid;

    }
}