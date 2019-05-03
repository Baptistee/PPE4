namespace PPE4
{
    partial class frmCategorie
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
            this.txbHelp = new System.Windows.Forms.TextBox();
            this.gpb_Categorie_Action = new System.Windows.Forms.GroupBox();
            this.txbCategorieAction = new System.Windows.Forms.TextBox();
            this.btn_Categorie_Modifier = new System.Windows.Forms.Button();
            this.btn_Categorie_Supprimer = new System.Windows.Forms.Button();
            this.gpb_Categorie_Ajouter = new System.Windows.Forms.GroupBox();
            this.txbCategorieCreer = new System.Windows.Forms.TextBox();
            this.btn_Categorie_Creer = new System.Windows.Forms.Button();
            this.btn_Categorie_Annuler = new System.Windows.Forms.Button();
            this.dgCategorieConsulter = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpb_Categorie_Action.SuspendLayout();
            this.gpb_Categorie_Ajouter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorieConsulter)).BeginInit();
            this.SuspendLayout();
            // 
            // txbHelp
            // 
            this.txbHelp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txbHelp.Enabled = false;
            this.txbHelp.Location = new System.Drawing.Point(12, 438);
            this.txbHelp.Name = "txbHelp";
            this.txbHelp.ReadOnly = true;
            this.txbHelp.Size = new System.Drawing.Size(163, 20);
            this.txbHelp.TabIndex = 24;
            this.txbHelp.Text = "En attente d\'actions";
            this.txbHelp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gpb_Categorie_Action
            // 
            this.gpb_Categorie_Action.Controls.Add(this.label2);
            this.gpb_Categorie_Action.Controls.Add(this.txbCategorieAction);
            this.gpb_Categorie_Action.Controls.Add(this.btn_Categorie_Modifier);
            this.gpb_Categorie_Action.Controls.Add(this.btn_Categorie_Supprimer);
            this.gpb_Categorie_Action.Enabled = false;
            this.gpb_Categorie_Action.Location = new System.Drawing.Point(339, 12);
            this.gpb_Categorie_Action.Name = "gpb_Categorie_Action";
            this.gpb_Categorie_Action.Size = new System.Drawing.Size(285, 160);
            this.gpb_Categorie_Action.TabIndex = 23;
            this.gpb_Categorie_Action.TabStop = false;
            this.gpb_Categorie_Action.Text = "Actions sur une catégorie";
            // 
            // txbCategorieAction
            // 
            this.txbCategorieAction.Location = new System.Drawing.Point(28, 56);
            this.txbCategorieAction.Multiline = true;
            this.txbCategorieAction.Name = "txbCategorieAction";
            this.txbCategorieAction.Size = new System.Drawing.Size(238, 28);
            this.txbCategorieAction.TabIndex = 11;
            // 
            // btn_Categorie_Modifier
            // 
            this.btn_Categorie_Modifier.Location = new System.Drawing.Point(28, 107);
            this.btn_Categorie_Modifier.Name = "btn_Categorie_Modifier";
            this.btn_Categorie_Modifier.Size = new System.Drawing.Size(102, 39);
            this.btn_Categorie_Modifier.TabIndex = 16;
            this.btn_Categorie_Modifier.Text = "Modifier";
            this.btn_Categorie_Modifier.UseVisualStyleBackColor = true;
            // 
            // btn_Categorie_Supprimer
            // 
            this.btn_Categorie_Supprimer.Location = new System.Drawing.Point(164, 107);
            this.btn_Categorie_Supprimer.Name = "btn_Categorie_Supprimer";
            this.btn_Categorie_Supprimer.Size = new System.Drawing.Size(102, 39);
            this.btn_Categorie_Supprimer.TabIndex = 17;
            this.btn_Categorie_Supprimer.Text = "Supprimer";
            this.btn_Categorie_Supprimer.UseVisualStyleBackColor = true;
            // 
            // gpb_Categorie_Ajouter
            // 
            this.gpb_Categorie_Ajouter.Controls.Add(this.label1);
            this.gpb_Categorie_Ajouter.Controls.Add(this.txbCategorieCreer);
            this.gpb_Categorie_Ajouter.Controls.Add(this.btn_Categorie_Creer);
            this.gpb_Categorie_Ajouter.Controls.Add(this.btn_Categorie_Annuler);
            this.gpb_Categorie_Ajouter.Location = new System.Drawing.Point(12, 12);
            this.gpb_Categorie_Ajouter.Name = "gpb_Categorie_Ajouter";
            this.gpb_Categorie_Ajouter.Size = new System.Drawing.Size(283, 160);
            this.gpb_Categorie_Ajouter.TabIndex = 22;
            this.gpb_Categorie_Ajouter.TabStop = false;
            this.gpb_Categorie_Ajouter.Text = "Créer une catégorie";
            // 
            // txbCategorieCreer
            // 
            this.txbCategorieCreer.Location = new System.Drawing.Point(25, 56);
            this.txbCategorieCreer.Multiline = true;
            this.txbCategorieCreer.Name = "txbCategorieCreer";
            this.txbCategorieCreer.Size = new System.Drawing.Size(235, 28);
            this.txbCategorieCreer.TabIndex = 14;
            // 
            // btn_Categorie_Creer
            // 
            this.btn_Categorie_Creer.Location = new System.Drawing.Point(25, 107);
            this.btn_Categorie_Creer.Name = "btn_Categorie_Creer";
            this.btn_Categorie_Creer.Size = new System.Drawing.Size(93, 39);
            this.btn_Categorie_Creer.TabIndex = 13;
            this.btn_Categorie_Creer.Text = "Créer";
            this.btn_Categorie_Creer.UseVisualStyleBackColor = true;
            this.btn_Categorie_Creer.Click += new System.EventHandler(this.btn_Categorie_Creer_Click);
            // 
            // btn_Categorie_Annuler
            // 
            this.btn_Categorie_Annuler.Location = new System.Drawing.Point(172, 107);
            this.btn_Categorie_Annuler.Name = "btn_Categorie_Annuler";
            this.btn_Categorie_Annuler.Size = new System.Drawing.Size(88, 39);
            this.btn_Categorie_Annuler.TabIndex = 14;
            this.btn_Categorie_Annuler.Text = "Annuler";
            this.btn_Categorie_Annuler.UseVisualStyleBackColor = true;
            // 
            // dgCategorieConsulter
            // 
            this.dgCategorieConsulter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategorieConsulter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgCategorieConsulter.Location = new System.Drawing.Point(12, 178);
            this.dgCategorieConsulter.MultiSelect = false;
            this.dgCategorieConsulter.Name = "dgCategorieConsulter";
            this.dgCategorieConsulter.ReadOnly = true;
            this.dgCategorieConsulter.Size = new System.Drawing.Size(612, 254);
            this.dgCategorieConsulter.TabIndex = 21;
            this.dgCategorieConsulter.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgCategorieConsulter_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Entrer un nom de catégorie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Modifier le nom de la catégorie";
            // 
            // frmCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 470);
            this.Controls.Add(this.txbHelp);
            this.Controls.Add(this.gpb_Categorie_Action);
            this.Controls.Add(this.gpb_Categorie_Ajouter);
            this.Controls.Add(this.dgCategorieConsulter);
            this.Name = "frmCategorie";
            this.Load += new System.EventHandler(this.frmCategorie_Load);
            this.gpb_Categorie_Action.ResumeLayout(false);
            this.gpb_Categorie_Action.PerformLayout();
            this.gpb_Categorie_Ajouter.ResumeLayout(false);
            this.gpb_Categorie_Ajouter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorieConsulter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbHelp;
        private System.Windows.Forms.GroupBox gpb_Categorie_Action;
        private System.Windows.Forms.TextBox txbCategorieAction;
        private System.Windows.Forms.Button btn_Categorie_Modifier;
        private System.Windows.Forms.Button btn_Categorie_Supprimer;
        private System.Windows.Forms.GroupBox gpb_Categorie_Ajouter;
        private System.Windows.Forms.TextBox txbCategorieCreer;
        private System.Windows.Forms.Button btn_Categorie_Creer;
        private System.Windows.Forms.Button btn_Categorie_Annuler;
        private System.Windows.Forms.DataGridView dgCategorieConsulter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}