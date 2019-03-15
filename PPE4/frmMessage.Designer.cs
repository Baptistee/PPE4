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
            this.tbcMessage = new System.Windows.Forms.TabControl();
            this.tbpConsulter = new System.Windows.Forms.TabPage();
            this.tbpCreer = new System.Windows.Forms.TabPage();
            this.btn_Creer_Valider = new System.Windows.Forms.Button();
            this.txbMessage = new System.Windows.Forms.TextBox();
            this.btn_Creer_Annuler = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_Creer_Titre = new System.Windows.Forms.Label();
            this.lblVerification = new System.Windows.Forms.Label();
            this.tbcMessage.SuspendLayout();
            this.tbpConsulter.SuspendLayout();
            this.tbpCreer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcMessage
            // 
            this.tbcMessage.Controls.Add(this.tbpConsulter);
            this.tbcMessage.Controls.Add(this.tbpCreer);
            this.tbcMessage.Location = new System.Drawing.Point(12, 2);
            this.tbcMessage.Name = "tbcMessage";
            this.tbcMessage.SelectedIndex = 0;
            this.tbcMessage.Size = new System.Drawing.Size(548, 292);
            this.tbcMessage.TabIndex = 0;
            // 
            // tbpConsulter
            // 
            this.tbpConsulter.Controls.Add(this.dataGridView1);
            this.tbpConsulter.Location = new System.Drawing.Point(4, 22);
            this.tbpConsulter.Name = "tbpConsulter";
            this.tbpConsulter.Padding = new System.Windows.Forms.Padding(3);
            this.tbpConsulter.Size = new System.Drawing.Size(540, 266);
            this.tbpConsulter.TabIndex = 0;
            this.tbpConsulter.Text = "Consulter";
            this.tbpConsulter.UseVisualStyleBackColor = true;
            // 
            // tbpCreer
            // 
            this.tbpCreer.Controls.Add(this.lblVerification);
            this.tbpCreer.Controls.Add(this.lbl_Creer_Titre);
            this.tbpCreer.Controls.Add(this.btn_Creer_Annuler);
            this.tbpCreer.Controls.Add(this.txbMessage);
            this.tbpCreer.Controls.Add(this.btn_Creer_Valider);
            this.tbpCreer.Location = new System.Drawing.Point(4, 22);
            this.tbpCreer.Name = "tbpCreer";
            this.tbpCreer.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCreer.Size = new System.Drawing.Size(540, 266);
            this.tbpCreer.TabIndex = 1;
            this.tbpCreer.Text = "Créer";
            this.tbpCreer.UseVisualStyleBackColor = true;
            // 
            // btn_Creer_Valider
            // 
            this.btn_Creer_Valider.Location = new System.Drawing.Point(153, 210);
            this.btn_Creer_Valider.Name = "btn_Creer_Valider";
            this.btn_Creer_Valider.Size = new System.Drawing.Size(119, 39);
            this.btn_Creer_Valider.TabIndex = 0;
            this.btn_Creer_Valider.Text = "Valider";
            this.btn_Creer_Valider.UseVisualStyleBackColor = true;
            this.btn_Creer_Valider.Click += new System.EventHandler(this.btn_Creer_Valider_Click);
            // 
            // txbMessage
            // 
            this.txbMessage.Location = new System.Drawing.Point(153, 65);
            this.txbMessage.Multiline = true;
            this.txbMessage.Name = "txbMessage";
            this.txbMessage.Size = new System.Drawing.Size(238, 139);
            this.txbMessage.TabIndex = 1;
            // 
            // btn_Creer_Annuler
            // 
            this.btn_Creer_Annuler.Location = new System.Drawing.Point(297, 210);
            this.btn_Creer_Annuler.Name = "btn_Creer_Annuler";
            this.btn_Creer_Annuler.Size = new System.Drawing.Size(94, 39);
            this.btn_Creer_Annuler.TabIndex = 2;
            this.btn_Creer_Annuler.Text = "Annuler";
            this.btn_Creer_Annuler.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(528, 254);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbl_Creer_Titre
            // 
            this.lbl_Creer_Titre.AutoSize = true;
            this.lbl_Creer_Titre.Location = new System.Drawing.Point(212, 26);
            this.lbl_Creer_Titre.Name = "lbl_Creer_Titre";
            this.lbl_Creer_Titre.Size = new System.Drawing.Size(114, 13);
            this.lbl_Creer_Titre.TabIndex = 3;
            this.lbl_Creer_Titre.Text = "Création d\'un message";
            // 
            // lblVerification
            // 
            this.lblVerification.AutoSize = true;
            this.lblVerification.Location = new System.Drawing.Point(419, 223);
            this.lblVerification.Name = "lblVerification";
            this.lblVerification.Size = new System.Drawing.Size(90, 13);
            this.lblVerification.TabIndex = 4;
            this.lblVerification.Text = "Valider pour créer";
            // 
            // frmMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 316);
            this.Controls.Add(this.tbcMessage);
            this.Name = "frmMessage";
            this.Text = "frmMessage";
            this.Load += new System.EventHandler(this.frmMessage_Load);
            this.tbcMessage.ResumeLayout(false);
            this.tbpConsulter.ResumeLayout(false);
            this.tbpCreer.ResumeLayout(false);
            this.tbpCreer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMessage;
        private System.Windows.Forms.TabPage tbpConsulter;
        private System.Windows.Forms.TabPage tbpCreer;
        private System.Windows.Forms.Button btn_Creer_Annuler;
        private System.Windows.Forms.TextBox txbMessage;
        private System.Windows.Forms.Button btn_Creer_Valider;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_Creer_Titre;
        private System.Windows.Forms.Label lblVerification;
    }
}