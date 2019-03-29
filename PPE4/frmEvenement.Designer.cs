namespace PPE4
{
    partial class frmEvenement
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
            this.ville = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.theme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateDebut = new System.Windows.Forms.DateTimePicker();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.tabEvenementConsulter = new System.Windows.Forms.TabControl();
            this.Consulter = new System.Windows.Forms.TabPage();
            this.lblRequete = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnInserer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.dgvEvenement = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabEvenementConsulter.SuspendLayout();
            this.Consulter.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvenement)).BeginInit();
            this.SuspendLayout();
            // 
            // ville
            // 
            this.ville.Location = new System.Drawing.Point(19, 112);
            this.ville.Name = "ville";
            this.ville.Size = new System.Drawing.Size(318, 20);
            this.ville.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date début";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 30);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date fin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 96);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ville";
            // 
            // theme
            // 
            this.theme.Location = new System.Drawing.Point(19, 180);
            this.theme.Name = "theme";
            this.theme.Size = new System.Drawing.Size(318, 20);
            this.theme.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 155);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Theme";
            // 
            // dateDebut
            // 
            this.dateDebut.Location = new System.Drawing.Point(19, 56);
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.Size = new System.Drawing.Size(200, 20);
            this.dateDebut.TabIndex = 8;
            // 
            // dateFin
            // 
            this.dateFin.Location = new System.Drawing.Point(296, 56);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(200, 20);
            this.dateFin.TabIndex = 9;
            // 
            // tabEvenementConsulter
            // 
            this.tabEvenementConsulter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabEvenementConsulter.Controls.Add(this.Consulter);
            this.tabEvenementConsulter.Controls.Add(this.tabPage2);
            this.tabEvenementConsulter.Location = new System.Drawing.Point(3, 2);
            this.tabEvenementConsulter.Name = "tabEvenementConsulter";
            this.tabEvenementConsulter.SelectedIndex = 0;
            this.tabEvenementConsulter.Size = new System.Drawing.Size(990, 524);
            this.tabEvenementConsulter.TabIndex = 10;
            // 
            // Consulter
            // 
            this.Consulter.Controls.Add(this.lblRequete);
            this.Consulter.Controls.Add(this.btnValider);
            this.Consulter.Controls.Add(this.btnAnnuler);
            this.Consulter.Controls.Add(this.dateDebut);
            this.Consulter.Controls.Add(this.theme);
            this.Consulter.Controls.Add(this.label4);
            this.Consulter.Controls.Add(this.dateFin);
            this.Consulter.Controls.Add(this.label1);
            this.Consulter.Controls.Add(this.ville);
            this.Consulter.Controls.Add(this.label3);
            this.Consulter.Controls.Add(this.label2);
            this.Consulter.Location = new System.Drawing.Point(4, 22);
            this.Consulter.Name = "Consulter";
            this.Consulter.Padding = new System.Windows.Forms.Padding(3);
            this.Consulter.Size = new System.Drawing.Size(982, 498);
            this.Consulter.TabIndex = 0;
            this.Consulter.Text = "Créer";
            this.Consulter.UseVisualStyleBackColor = true;
            // 
            // lblRequete
            // 
            this.lblRequete.AutoSize = true;
            this.lblRequete.Location = new System.Drawing.Point(16, 247);
            this.lblRequete.Name = "lblRequete";
            this.lblRequete.Size = new System.Drawing.Size(0, 13);
            this.lblRequete.TabIndex = 12;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.YellowGreen;
            this.btnValider.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnValider.Location = new System.Drawing.Point(215, 235);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(122, 36);
            this.btnValider.TabIndex = 11;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.Firebrick;
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAnnuler.Location = new System.Drawing.Point(343, 235);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(122, 36);
            this.btnAnnuler.TabIndex = 10;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSupprimer);
            this.tabPage2.Controls.Add(this.btnInserer);
            this.tabPage2.Controls.Add(this.btnModifier);
            this.tabPage2.Controls.Add(this.dgvEvenement);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(982, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulter";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(822, 405);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(121, 36);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnInserer
            // 
            this.btnInserer.Location = new System.Drawing.Point(822, 330);
            this.btnInserer.Name = "btnInserer";
            this.btnInserer.Size = new System.Drawing.Size(121, 36);
            this.btnInserer.TabIndex = 2;
            this.btnInserer.Text = "Insérer";
            this.btnInserer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(822, 257);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(121, 36);
            this.btnModifier.TabIndex = 1;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // dgvEvenement
            // 
            this.dgvEvenement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvenement.Location = new System.Drawing.Point(6, 208);
            this.dgvEvenement.Name = "dgvEvenement";
            this.dgvEvenement.Size = new System.Drawing.Size(777, 284);
            this.dgvEvenement.TabIndex = 0;
          
            this.dgvEvenement.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvenement_RowEnter);
            // 
            // frmEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 528);
            this.Controls.Add(this.tabEvenementConsulter);
            this.Name = "frmEvenement";
            this.Text = "Evenement";
            this.tabEvenementConsulter.ResumeLayout(false);
            this.Consulter.ResumeLayout(false);
            this.Consulter.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvenement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ville;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox theme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateDebut;
        private System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.TabControl tabEvenementConsulter;
        private System.Windows.Forms.TabPage Consulter;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvEvenement;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lblRequete;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnInserer;
    }
}