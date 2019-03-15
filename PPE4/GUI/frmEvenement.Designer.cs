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
            this.tabControlEvenement = new System.Windows.Forms.TabControl();
            this.Consulter = new System.Windows.Forms.TabPage();
            this.btnCreerEvenement = new System.Windows.Forms.Button();
            this.btnAnnulerEvenement = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvEvenement = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControlEvenement.SuspendLayout();
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
            // tabControlEvenement
            // 
            this.tabControlEvenement.Controls.Add(this.Consulter);
            this.tabControlEvenement.Controls.Add(this.tabPage2);
            this.tabControlEvenement.Location = new System.Drawing.Point(12, 12);
            this.tabControlEvenement.Name = "tabControlEvenement";
            this.tabControlEvenement.SelectedIndex = 0;
            this.tabControlEvenement.Size = new System.Drawing.Size(556, 303);
            this.tabControlEvenement.TabIndex = 10;
            // 
            // Consulter
            // 
            this.Consulter.Controls.Add(this.btnCreerEvenement);
            this.Consulter.Controls.Add(this.btnAnnulerEvenement);
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
            this.Consulter.Size = new System.Drawing.Size(548, 277);
            this.Consulter.TabIndex = 0;
            this.Consulter.Text = "Créer";
            this.Consulter.UseVisualStyleBackColor = true;
            // 
            // btnCreerEvenement
            // 
            this.btnCreerEvenement.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCreerEvenement.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreerEvenement.Location = new System.Drawing.Point(215, 235);
            this.btnCreerEvenement.Name = "btnCreerEvenement";
            this.btnCreerEvenement.Size = new System.Drawing.Size(122, 36);
            this.btnCreerEvenement.TabIndex = 11;
            this.btnCreerEvenement.Text = "Valider";
            this.btnCreerEvenement.UseVisualStyleBackColor = false;
            // 
            // btnAnnulerEvenement
            // 
            this.btnAnnulerEvenement.BackColor = System.Drawing.Color.Firebrick;
            this.btnAnnulerEvenement.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAnnulerEvenement.Location = new System.Drawing.Point(343, 235);
            this.btnAnnulerEvenement.Name = "btnAnnulerEvenement";
            this.btnAnnulerEvenement.Size = new System.Drawing.Size(122, 36);
            this.btnAnnulerEvenement.TabIndex = 10;
            this.btnAnnulerEvenement.Text = "Annuler";
            this.btnAnnulerEvenement.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvEvenement);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(548, 277);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulter";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvEvenement
            // 
            this.dgvEvenement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvenement.Location = new System.Drawing.Point(15, 24);
            this.dgvEvenement.Name = "dgvEvenement";
            this.dgvEvenement.Size = new System.Drawing.Size(479, 232);
            this.dgvEvenement.TabIndex = 0;
            // 
            // frmEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 356);
            this.Controls.Add(this.tabControlEvenement);
            this.Name = "frmEvenement";
            this.Text = "Evement";
            this.tabControlEvenement.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl tabControlEvenement;
        private System.Windows.Forms.TabPage Consulter;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvEvenement;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCreerEvenement;
        private System.Windows.Forms.Button btnAnnulerEvenement;
    }
}