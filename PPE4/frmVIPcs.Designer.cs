﻿namespace PPE4
{
    partial class frmVIP
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
            this.btnCréer = new System.Windows.Forms.Button();
            this.btnCreerAnnuler = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.cbAjouterCategorie = new System.Windows.Forms.ComboBox();
            this.txbAjouterNom = new System.Windows.Forms.TextBox();
            this.txbAjouterAdresse = new System.Windows.Forms.TextBox();
            this.txbAjouterMail = new System.Windows.Forms.TextBox();
            this.grbCreerVIP = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgVIP = new System.Windows.Forms.DataGridView();
            this.grbModifierVIP = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbModifierNom = new System.Windows.Forms.TextBox();
            this.txbModifierAdresse = new System.Windows.Forms.TextBox();
            this.txbModifierMail = new System.Windows.Forms.TextBox();
            this.cbModifierCategorie = new System.Windows.Forms.ComboBox();
            this.grbCreerVIP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVIP)).BeginInit();
            this.grbModifierVIP.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCréer
            // 
            this.btnCréer.Location = new System.Drawing.Point(353, 80);
            this.btnCréer.Name = "btnCréer";
            this.btnCréer.Size = new System.Drawing.Size(111, 62);
            this.btnCréer.TabIndex = 0;
            this.btnCréer.Text = "Créer";
            this.btnCréer.UseVisualStyleBackColor = true;
            this.btnCréer.Click += new System.EventHandler(this.btnCréer_Click);
            // 
            // btnCreerAnnuler
            // 
            this.btnCreerAnnuler.Location = new System.Drawing.Point(501, 80);
            this.btnCreerAnnuler.Name = "btnCreerAnnuler";
            this.btnCreerAnnuler.Size = new System.Drawing.Size(109, 62);
            this.btnCreerAnnuler.TabIndex = 1;
            this.btnCreerAnnuler.Text = "Annuler";
            this.btnCreerAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(353, 70);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(111, 57);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(501, 70);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(109, 57);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // cbAjouterCategorie
            // 
            this.cbAjouterCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAjouterCategorie.FormattingEnabled = true;
            this.cbAjouterCategorie.ItemHeight = 13;
            this.cbAjouterCategorie.Location = new System.Drawing.Point(64, 30);
            this.cbAjouterCategorie.Name = "cbAjouterCategorie";
            this.cbAjouterCategorie.Size = new System.Drawing.Size(164, 21);
            this.cbAjouterCategorie.TabIndex = 4;
            // 
            // txbAjouterNom
            // 
            this.txbAjouterNom.BackColor = System.Drawing.SystemColors.Window;
            this.txbAjouterNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAjouterNom.Location = new System.Drawing.Point(64, 77);
            this.txbAjouterNom.Name = "txbAjouterNom";
            this.txbAjouterNom.Size = new System.Drawing.Size(164, 20);
            this.txbAjouterNom.TabIndex = 5;
            // 
            // txbAjouterAdresse
            // 
            this.txbAjouterAdresse.Location = new System.Drawing.Point(64, 128);
            this.txbAjouterAdresse.Name = "txbAjouterAdresse";
            this.txbAjouterAdresse.Size = new System.Drawing.Size(164, 20);
            this.txbAjouterAdresse.TabIndex = 6;
            // 
            // txbAjouterMail
            // 
            this.txbAjouterMail.Location = new System.Drawing.Point(64, 175);
            this.txbAjouterMail.Name = "txbAjouterMail";
            this.txbAjouterMail.Size = new System.Drawing.Size(164, 20);
            this.txbAjouterMail.TabIndex = 7;
            // 
            // grbCreerVIP
            // 
            this.grbCreerVIP.Controls.Add(this.label4);
            this.grbCreerVIP.Controls.Add(this.label3);
            this.grbCreerVIP.Controls.Add(this.label2);
            this.grbCreerVIP.Controls.Add(this.label1);
            this.grbCreerVIP.Controls.Add(this.txbAjouterNom);
            this.grbCreerVIP.Controls.Add(this.txbAjouterAdresse);
            this.grbCreerVIP.Controls.Add(this.txbAjouterMail);
            this.grbCreerVIP.Controls.Add(this.cbAjouterCategorie);
            this.grbCreerVIP.Controls.Add(this.btnCréer);
            this.grbCreerVIP.Controls.Add(this.btnCreerAnnuler);
            this.grbCreerVIP.Location = new System.Drawing.Point(12, 12);
            this.grbCreerVIP.Name = "grbCreerVIP";
            this.grbCreerVIP.Size = new System.Drawing.Size(674, 201);
            this.grbCreerVIP.TabIndex = 8;
            this.grbCreerVIP.TabStop = false;
            this.grbCreerVIP.Text = "Ajouter un VIP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Adresse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Catégorie";
            // 
            // dgVIP
            // 
            this.dgVIP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVIP.Location = new System.Drawing.Point(12, 440);
            this.dgVIP.Name = "dgVIP";
            this.dgVIP.Size = new System.Drawing.Size(674, 264);
            this.dgVIP.TabIndex = 9;
            // 
            // grbModifierVIP
            // 
            this.grbModifierVIP.Controls.Add(this.label5);
            this.grbModifierVIP.Controls.Add(this.label6);
            this.grbModifierVIP.Controls.Add(this.label7);
            this.grbModifierVIP.Controls.Add(this.label8);
            this.grbModifierVIP.Controls.Add(this.txbModifierNom);
            this.grbModifierVIP.Controls.Add(this.txbModifierAdresse);
            this.grbModifierVIP.Controls.Add(this.txbModifierMail);
            this.grbModifierVIP.Controls.Add(this.cbModifierCategorie);
            this.grbModifierVIP.Controls.Add(this.btnModifier);
            this.grbModifierVIP.Controls.Add(this.btnSupprimer);
            this.grbModifierVIP.Location = new System.Drawing.Point(12, 219);
            this.grbModifierVIP.Name = "grbModifierVIP";
            this.grbModifierVIP.Size = new System.Drawing.Size(674, 215);
            this.grbModifierVIP.TabIndex = 10;
            this.grbModifierVIP.TabStop = false;
            this.grbModifierVIP.Text = "Modifier le VIP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Adresse";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nom";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Catégorie";
            // 
            // txbModifierNom
            // 
            this.txbModifierNom.Location = new System.Drawing.Point(64, 84);
            this.txbModifierNom.Name = "txbModifierNom";
            this.txbModifierNom.Size = new System.Drawing.Size(164, 20);
            this.txbModifierNom.TabIndex = 9;
            // 
            // txbModifierAdresse
            // 
            this.txbModifierAdresse.Location = new System.Drawing.Point(64, 132);
            this.txbModifierAdresse.Name = "txbModifierAdresse";
            this.txbModifierAdresse.Size = new System.Drawing.Size(164, 20);
            this.txbModifierAdresse.TabIndex = 10;
            // 
            // txbModifierMail
            // 
            this.txbModifierMail.Location = new System.Drawing.Point(64, 179);
            this.txbModifierMail.Name = "txbModifierMail";
            this.txbModifierMail.Size = new System.Drawing.Size(164, 20);
            this.txbModifierMail.TabIndex = 11;
            // 
            // cbModifierCategorie
            // 
            this.cbModifierCategorie.FormattingEnabled = true;
            this.cbModifierCategorie.Location = new System.Drawing.Point(64, 37);
            this.cbModifierCategorie.Name = "cbModifierCategorie";
            this.cbModifierCategorie.Size = new System.Drawing.Size(164, 21);
            this.cbModifierCategorie.TabIndex = 8;
            // 
            // frmVIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 716);
            this.Controls.Add(this.grbModifierVIP);
            this.Controls.Add(this.dgVIP);
            this.Controls.Add(this.grbCreerVIP);
            this.Name = "frmVIP";
            this.Text = "VIP";
            this.Load += new System.EventHandler(this.frmVIP_Load);
            this.grbCreerVIP.ResumeLayout(false);
            this.grbCreerVIP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVIP)).EndInit();
            this.grbModifierVIP.ResumeLayout(false);
            this.grbModifierVIP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCréer;
        private System.Windows.Forms.Button btnCreerAnnuler;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.ComboBox cbAjouterCategorie;
        private System.Windows.Forms.TextBox txbAjouterNom;
        private System.Windows.Forms.TextBox txbAjouterAdresse;
        private System.Windows.Forms.TextBox txbAjouterMail;
        private System.Windows.Forms.GroupBox grbCreerVIP;
        private System.Windows.Forms.DataGridView dgVIP;
        private System.Windows.Forms.GroupBox grbModifierVIP;
        private System.Windows.Forms.TextBox txbModifierNom;
        private System.Windows.Forms.TextBox txbModifierAdresse;
        private System.Windows.Forms.TextBox txbModifierMail;
        private System.Windows.Forms.ComboBox cbModifierCategorie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}