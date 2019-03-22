namespace PPE4
{
    partial class frmMessage
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
            this.tbpConsulter = new System.Windows.Forms.TabPage();
            this.dgMessageConsulter = new System.Windows.Forms.DataGridView();
            this.txbMessage = new System.Windows.Forms.TextBox();
            this.lbl_Creer_Titre = new System.Windows.Forms.Label();
            this.btn_Message_Creer = new System.Windows.Forms.Button();
            this.btn_Creer_Annuler = new System.Windows.Forms.Button();
            this.lblVerification = new System.Windows.Forms.Label();
            this.tbcMessage = new System.Windows.Forms.TabControl();
            this.btn_Message_Modifier = new System.Windows.Forms.Button();
            this.btn_Message_Supprimer = new System.Windows.Forms.Button();
            this.tbpConsulter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMessageConsulter)).BeginInit();
            this.tbcMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpConsulter
            // 
            this.tbpConsulter.Controls.Add(this.btn_Message_Supprimer);
            this.tbpConsulter.Controls.Add(this.btn_Message_Modifier);
            this.tbpConsulter.Controls.Add(this.lblVerification);
            this.tbpConsulter.Controls.Add(this.btn_Creer_Annuler);
            this.tbpConsulter.Controls.Add(this.btn_Message_Creer);
            this.tbpConsulter.Controls.Add(this.lbl_Creer_Titre);
            this.tbpConsulter.Controls.Add(this.txbMessage);
            this.tbpConsulter.Controls.Add(this.dgMessageConsulter);
            this.tbpConsulter.Location = new System.Drawing.Point(4, 22);
            this.tbpConsulter.Name = "tbpConsulter";
            this.tbpConsulter.Padding = new System.Windows.Forms.Padding(3);
            this.tbpConsulter.Size = new System.Drawing.Size(903, 567);
            this.tbpConsulter.TabIndex = 0;
            this.tbpConsulter.Text = "Consulter";
            this.tbpConsulter.UseVisualStyleBackColor = true;
            this.tbpConsulter.Enter += new System.EventHandler(this.tbpConsulter_Enter);
            // 
            // dgMessageConsulter
            // 
            this.dgMessageConsulter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMessageConsulter.Location = new System.Drawing.Point(6, 307);
            this.dgMessageConsulter.Name = "dgMessageConsulter";
            this.dgMessageConsulter.Size = new System.Drawing.Size(891, 254);
            this.dgMessageConsulter.TabIndex = 0;
            // 
            // txbMessage
            // 
            this.txbMessage.Location = new System.Drawing.Point(295, 71);
            this.txbMessage.Multiline = true;
            this.txbMessage.Name = "txbMessage";
            this.txbMessage.Size = new System.Drawing.Size(238, 175);
            this.txbMessage.TabIndex = 2;
            // 
            // lbl_Creer_Titre
            // 
            this.lbl_Creer_Titre.AutoSize = true;
            this.lbl_Creer_Titre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Creer_Titre.Location = new System.Drawing.Point(362, 23);
            this.lbl_Creer_Titre.Name = "lbl_Creer_Titre";
            this.lbl_Creer_Titre.Size = new System.Drawing.Size(116, 15);
            this.lbl_Creer_Titre.TabIndex = 4;
            this.lbl_Creer_Titre.Text = "Création d\'un message";
            // 
            // btn_Message_Creer
            // 
            this.btn_Message_Creer.Location = new System.Drawing.Point(539, 71);
            this.btn_Message_Creer.Name = "btn_Message_Creer";
            this.btn_Message_Creer.Size = new System.Drawing.Size(119, 39);
            this.btn_Message_Creer.TabIndex = 5;
            this.btn_Message_Creer.Text = "Créer";
            this.btn_Message_Creer.UseVisualStyleBackColor = true;
            this.btn_Message_Creer.Click += new System.EventHandler(this.btn_Message_Creer_Click);
            // 
            // btn_Creer_Annuler
            // 
            this.btn_Creer_Annuler.Location = new System.Drawing.Point(540, 207);
            this.btn_Creer_Annuler.Name = "btn_Creer_Annuler";
            this.btn_Creer_Annuler.Size = new System.Drawing.Size(119, 39);
            this.btn_Creer_Annuler.TabIndex = 6;
            this.btn_Creer_Annuler.Text = "Annuler";
            this.btn_Creer_Annuler.UseVisualStyleBackColor = true;
            // 
            // lblVerification
            // 
            this.lblVerification.AutoSize = true;
            this.lblVerification.Location = new System.Drawing.Point(375, 269);
            this.lblVerification.Name = "lblVerification";
            this.lblVerification.Size = new System.Drawing.Size(90, 13);
            this.lblVerification.TabIndex = 7;
            this.lblVerification.Text = "Valider pour créer";
            // 
            // tbcMessage
            // 
            this.tbcMessage.Controls.Add(this.tbpConsulter);
            this.tbcMessage.Location = new System.Drawing.Point(12, 2);
            this.tbcMessage.Name = "tbcMessage";
            this.tbcMessage.SelectedIndex = 0;
            this.tbcMessage.Size = new System.Drawing.Size(911, 593);
            this.tbcMessage.TabIndex = 0;
            // 
            // btn_Message_Modifier
            // 
            this.btn_Message_Modifier.Location = new System.Drawing.Point(539, 116);
            this.btn_Message_Modifier.Name = "btn_Message_Modifier";
            this.btn_Message_Modifier.Size = new System.Drawing.Size(119, 39);
            this.btn_Message_Modifier.TabIndex = 8;
            this.btn_Message_Modifier.Text = "Modifier";
            this.btn_Message_Modifier.UseVisualStyleBackColor = true;
            // 
            // btn_Message_Supprimer
            // 
            this.btn_Message_Supprimer.Location = new System.Drawing.Point(540, 162);
            this.btn_Message_Supprimer.Name = "btn_Message_Supprimer";
            this.btn_Message_Supprimer.Size = new System.Drawing.Size(119, 39);
            this.btn_Message_Supprimer.TabIndex = 9;
            this.btn_Message_Supprimer.Text = "Supprimer";
            this.btn_Message_Supprimer.UseVisualStyleBackColor = true;
            // 
            // frmMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 607);
            this.Controls.Add(this.tbcMessage);
            this.Name = "frmMessage";
            this.Text = "frmMessage";
            this.Load += new System.EventHandler(this.frmMessage_Load);
            this.tbpConsulter.ResumeLayout(false);
            this.tbpConsulter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMessageConsulter)).EndInit();
            this.tbcMessage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbpConsulter;
        private System.Windows.Forms.Button btn_Message_Supprimer;
        private System.Windows.Forms.Button btn_Message_Modifier;
        private System.Windows.Forms.Label lblVerification;
        private System.Windows.Forms.Button btn_Creer_Annuler;
        private System.Windows.Forms.Button btn_Message_Creer;
        private System.Windows.Forms.Label lbl_Creer_Titre;
        private System.Windows.Forms.TextBox txbMessage;
        private System.Windows.Forms.DataGridView dgMessageConsulter;
        private System.Windows.Forms.TabControl tbcMessage;

    }
}