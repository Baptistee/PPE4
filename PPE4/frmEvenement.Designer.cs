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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblRequete = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.dateDebut = new System.Windows.Forms.DateTimePicker();
            this.theme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ville = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.dgvEvenement = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvenement)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRequete
            // 
            this.lblRequete.AutoSize = true;
            this.lblRequete.Location = new System.Drawing.Point(33, 168);
            this.lblRequete.Name = "lblRequete";
            this.lblRequete.Size = new System.Drawing.Size(0, 13);
            this.lblRequete.TabIndex = 36;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.YellowGreen;
            this.btnValider.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnValider.Location = new System.Drawing.Point(845, 281);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(122, 36);
            this.btnValider.TabIndex = 35;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click_1);
            // 
            // dateDebut
            // 
            this.dateDebut.Location = new System.Drawing.Point(21, 53);
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.Size = new System.Drawing.Size(200, 20);
            this.dateDebut.TabIndex = 33;
            // 
            // theme
            // 
            this.theme.Location = new System.Drawing.Point(404, 129);
            this.theme.Name = "theme";
            this.theme.Size = new System.Drawing.Size(318, 20);
            this.theme.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(401, 113);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Theme";
            // 
            // dateFin
            // 
            this.dateFin.Location = new System.Drawing.Point(298, 53);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(200, 20);
            this.dateFin.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Date début";
            // 
            // ville
            // 
            this.ville.Location = new System.Drawing.Point(22, 129);
            this.ville.Name = "ville";
            this.ville.Size = new System.Drawing.Size(318, 20);
            this.ville.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 113);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Ville";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(295, 27);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Date fin";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Firebrick;
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(846, 390);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(121, 36);
            this.btnSupprimer.TabIndex = 26;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click_1);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(845, 338);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(121, 36);
            this.btnModifier.TabIndex = 25;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            // 
            // dgvEvenement
            // 
            this.dgvEvenement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvenement.Location = new System.Drawing.Point(12, 232);
            this.dgvEvenement.Name = "dgvEvenement";
            this.dgvEvenement.Size = new System.Drawing.Size(777, 284);
            this.dgvEvenement.TabIndex = 24;
            this.dgvEvenement.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvenement_RowEnter_1);
            // 
            // frmEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 528);
            this.Controls.Add(this.lblRequete);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.dateDebut);
            this.Controls.Add(this.theme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateFin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ville);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.dgvEvenement);
            this.Name = "frmEvenement";
            this.Text = "Evenement";
            this.Load += new System.EventHandler(this.frmEvenement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvenement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblRequete;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.DateTimePicker dateDebut;
        private System.Windows.Forms.TextBox theme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ville;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.DataGridView dgvEvenement;
    }
}