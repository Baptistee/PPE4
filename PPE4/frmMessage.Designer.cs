﻿namespace PPE4
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
            this.btn_Message_Supprimer = new System.Windows.Forms.Button();
            this.btn_Message_Modifier = new System.Windows.Forms.Button();
            this.btn_Message_Annuler = new System.Windows.Forms.Button();
            this.btn_Message_Creer = new System.Windows.Forms.Button();
            this.txbMessageAction = new System.Windows.Forms.TextBox();
            this.dgMessageConsulter = new System.Windows.Forms.DataGridView();
            this.gpb_Message_Ajouter = new System.Windows.Forms.GroupBox();
            this.cbb_Message_Categorie_Ajouter = new System.Windows.Forms.ComboBox();
            this.txbMessageCreer = new System.Windows.Forms.TextBox();
            this.gpb_Message_Action = new System.Windows.Forms.GroupBox();
            this.cbb_Message_Categorie_Action = new System.Windows.Forms.ComboBox();
            this.txbHelp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMessageConsulter)).BeginInit();
            this.gpb_Message_Ajouter.SuspendLayout();
            this.gpb_Message_Action.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Message_Supprimer
            // 
            this.btn_Message_Supprimer.Location = new System.Drawing.Point(164, 238);
            this.btn_Message_Supprimer.Name = "btn_Message_Supprimer";
            this.btn_Message_Supprimer.Size = new System.Drawing.Size(102, 39);
            this.btn_Message_Supprimer.TabIndex = 17;
            this.btn_Message_Supprimer.Text = "Supprimer";
            this.btn_Message_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Message_Supprimer.Click += new System.EventHandler(this.btn_Message_Supprimer_Click);
            // 
            // btn_Message_Modifier
            // 
            this.btn_Message_Modifier.Location = new System.Drawing.Point(28, 238);
            this.btn_Message_Modifier.Name = "btn_Message_Modifier";
            this.btn_Message_Modifier.Size = new System.Drawing.Size(102, 39);
            this.btn_Message_Modifier.TabIndex = 16;
            this.btn_Message_Modifier.Text = "Modifier";
            this.btn_Message_Modifier.UseVisualStyleBackColor = true;
            this.btn_Message_Modifier.Click += new System.EventHandler(this.btn_Message_Modifier_Click);
            // 
            // btn_Message_Annuler
            // 
            this.btn_Message_Annuler.Location = new System.Drawing.Point(172, 238);
            this.btn_Message_Annuler.Name = "btn_Message_Annuler";
            this.btn_Message_Annuler.Size = new System.Drawing.Size(88, 39);
            this.btn_Message_Annuler.TabIndex = 14;
            this.btn_Message_Annuler.Text = "Annuler";
            this.btn_Message_Annuler.UseVisualStyleBackColor = true;
            this.btn_Message_Annuler.Click += new System.EventHandler(this.btn_Creer_Annuler_Click);
            // 
            // btn_Message_Creer
            // 
            this.btn_Message_Creer.Location = new System.Drawing.Point(25, 238);
            this.btn_Message_Creer.Name = "btn_Message_Creer";
            this.btn_Message_Creer.Size = new System.Drawing.Size(93, 39);
            this.btn_Message_Creer.TabIndex = 13;
            this.btn_Message_Creer.Text = "Créer";
            this.btn_Message_Creer.UseVisualStyleBackColor = true;
            this.btn_Message_Creer.Click += new System.EventHandler(this.btn_Message_Creer_Click);
            // 
            // txbMessageAction
            // 
            this.txbMessageAction.Location = new System.Drawing.Point(28, 49);
            this.txbMessageAction.Multiline = true;
            this.txbMessageAction.Name = "txbMessageAction";
            this.txbMessageAction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbMessageAction.Size = new System.Drawing.Size(238, 132);
            this.txbMessageAction.TabIndex = 11;
            // 
            // dgMessageConsulter
            // 
            this.dgMessageConsulter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMessageConsulter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgMessageConsulter.Location = new System.Drawing.Point(22, 318);
            this.dgMessageConsulter.MultiSelect = false;
            this.dgMessageConsulter.Name = "dgMessageConsulter";
            this.dgMessageConsulter.ReadOnly = true;
            this.dgMessageConsulter.Size = new System.Drawing.Size(891, 254);
            this.dgMessageConsulter.TabIndex = 10;
            this.dgMessageConsulter.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgMessageConsulter_RowHeaderMouseClick);
            // 
            // gpb_Message_Ajouter
            // 
            this.gpb_Message_Ajouter.Controls.Add(this.label2);
            this.gpb_Message_Ajouter.Controls.Add(this.label1);
            this.gpb_Message_Ajouter.Controls.Add(this.cbb_Message_Categorie_Ajouter);
            this.gpb_Message_Ajouter.Controls.Add(this.txbMessageCreer);
            this.gpb_Message_Ajouter.Controls.Add(this.btn_Message_Creer);
            this.gpb_Message_Ajouter.Controls.Add(this.btn_Message_Annuler);
            this.gpb_Message_Ajouter.Location = new System.Drawing.Point(22, 12);
            this.gpb_Message_Ajouter.Name = "gpb_Message_Ajouter";
            this.gpb_Message_Ajouter.Size = new System.Drawing.Size(283, 300);
            this.gpb_Message_Ajouter.TabIndex = 18;
            this.gpb_Message_Ajouter.TabStop = false;
            this.gpb_Message_Ajouter.Text = "Créer un type de message";
            // 
            // cbb_Message_Categorie_Ajouter
            // 
            this.cbb_Message_Categorie_Ajouter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Message_Categorie_Ajouter.FormattingEnabled = true;
            this.cbb_Message_Categorie_Ajouter.Location = new System.Drawing.Point(25, 211);
            this.cbb_Message_Categorie_Ajouter.Name = "cbb_Message_Categorie_Ajouter";
            this.cbb_Message_Categorie_Ajouter.Size = new System.Drawing.Size(235, 21);
            this.cbb_Message_Categorie_Ajouter.TabIndex = 16;
            // 
            // txbMessageCreer
            // 
            this.txbMessageCreer.Location = new System.Drawing.Point(25, 49);
            this.txbMessageCreer.Multiline = true;
            this.txbMessageCreer.Name = "txbMessageCreer";
            this.txbMessageCreer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbMessageCreer.Size = new System.Drawing.Size(235, 132);
            this.txbMessageCreer.TabIndex = 14;
            // 
            // gpb_Message_Action
            // 
            this.gpb_Message_Action.Controls.Add(this.label4);
            this.gpb_Message_Action.Controls.Add(this.label3);
            this.gpb_Message_Action.Controls.Add(this.cbb_Message_Categorie_Action);
            this.gpb_Message_Action.Controls.Add(this.txbMessageAction);
            this.gpb_Message_Action.Controls.Add(this.btn_Message_Modifier);
            this.gpb_Message_Action.Controls.Add(this.btn_Message_Supprimer);
            this.gpb_Message_Action.Enabled = false;
            this.gpb_Message_Action.Location = new System.Drawing.Point(628, 12);
            this.gpb_Message_Action.Name = "gpb_Message_Action";
            this.gpb_Message_Action.Size = new System.Drawing.Size(285, 300);
            this.gpb_Message_Action.TabIndex = 19;
            this.gpb_Message_Action.TabStop = false;
            this.gpb_Message_Action.Text = "Actions sur un type de message";
            // 
            // cbb_Message_Categorie_Action
            // 
            this.cbb_Message_Categorie_Action.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Message_Categorie_Action.FormattingEnabled = true;
            this.cbb_Message_Categorie_Action.Location = new System.Drawing.Point(28, 211);
            this.cbb_Message_Categorie_Action.Name = "cbb_Message_Categorie_Action";
            this.cbb_Message_Categorie_Action.Size = new System.Drawing.Size(238, 21);
            this.cbb_Message_Categorie_Action.TabIndex = 19;
            // 
            // txbHelp
            // 
            this.txbHelp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txbHelp.Enabled = false;
            this.txbHelp.Location = new System.Drawing.Point(22, 578);
            this.txbHelp.Name = "txbHelp";
            this.txbHelp.ReadOnly = true;
            this.txbHelp.Size = new System.Drawing.Size(163, 20);
            this.txbHelp.TabIndex = 20;
            this.txbHelp.Text = "En attente d\'actions";
            this.txbHelp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Entrer un message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Choisir une catégorie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Modifier le message";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Choisir une catégorie";
            // 
            // frmMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 607);
            this.Controls.Add(this.txbHelp);
            this.Controls.Add(this.gpb_Message_Action);
            this.Controls.Add(this.gpb_Message_Ajouter);
            this.Controls.Add(this.dgMessageConsulter);
            this.Name = "frmMessage";
            this.Text = "Type Message";
            this.Load += new System.EventHandler(this.frmMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMessageConsulter)).EndInit();
            this.gpb_Message_Ajouter.ResumeLayout(false);
            this.gpb_Message_Ajouter.PerformLayout();
            this.gpb_Message_Action.ResumeLayout(false);
            this.gpb_Message_Action.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Message_Supprimer;
        private System.Windows.Forms.Button btn_Message_Modifier;
        private System.Windows.Forms.Button btn_Message_Annuler;
        private System.Windows.Forms.Button btn_Message_Creer;
        private System.Windows.Forms.TextBox txbMessageAction;
        private System.Windows.Forms.DataGridView dgMessageConsulter;
        private System.Windows.Forms.GroupBox gpb_Message_Ajouter;
        private System.Windows.Forms.GroupBox gpb_Message_Action;
        private System.Windows.Forms.TextBox txbMessageCreer;
        private System.Windows.Forms.TextBox txbHelp;
        private System.Windows.Forms.ComboBox cbb_Message_Categorie_Ajouter;
        private System.Windows.Forms.ComboBox cbb_Message_Categorie_Action;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;







    }
}