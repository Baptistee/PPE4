namespace PPE4
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.campagneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.évenementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.créerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artisteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.créerToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.vIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.campagneToolStripMenuItem,
            this.évenementToolStripMenuItem,
            this.agenceToolStripMenuItem,
            this.artisteToolStripMenuItem,
            this.vIPToolStripMenuItem,
            this.messageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(572, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // campagneToolStripMenuItem
            // 
            this.campagneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulterToolStripMenuItem,
            this.créerToolStripMenuItem});
            this.campagneToolStripMenuItem.Name = "campagneToolStripMenuItem";
            this.campagneToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.campagneToolStripMenuItem.Text = "Campagne";
            // 
            // consulterToolStripMenuItem
            // 
            this.consulterToolStripMenuItem.Name = "consulterToolStripMenuItem";
            this.consulterToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consulterToolStripMenuItem.Text = "Consulter";
            // 
            // créerToolStripMenuItem
            // 
            this.créerToolStripMenuItem.Name = "créerToolStripMenuItem";
            this.créerToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.créerToolStripMenuItem.Text = "Créer";
            // 
            // évenementToolStripMenuItem
            // 
            this.évenementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulterToolStripMenuItem1,
            this.créerToolStripMenuItem1});
            this.évenementToolStripMenuItem.Name = "évenementToolStripMenuItem";
            this.évenementToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.évenementToolStripMenuItem.Text = "Événement";
            this.évenementToolStripMenuItem.Click += new System.EventHandler(this.évenementToolStripMenuItem_Click);
            // 
            // consulterToolStripMenuItem1
            // 
            this.consulterToolStripMenuItem1.Name = "consulterToolStripMenuItem1";
            this.consulterToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.consulterToolStripMenuItem1.Text = "Consulter";
            // 
            // créerToolStripMenuItem1
            // 
            this.créerToolStripMenuItem1.Name = "créerToolStripMenuItem1";
            this.créerToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.créerToolStripMenuItem1.Text = "Créer";
            // 
            // agenceToolStripMenuItem
            // 
            this.agenceToolStripMenuItem.Name = "agenceToolStripMenuItem";
            this.agenceToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.agenceToolStripMenuItem.Text = "Agence";
            this.agenceToolStripMenuItem.Click += new System.EventHandler(this.agenceToolStripMenuItem_Click);
            // 
            // artisteToolStripMenuItem
            // 
            this.artisteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulterToolStripMenuItem3,
            this.créerToolStripMenuItem3});
            this.artisteToolStripMenuItem.Name = "artisteToolStripMenuItem";
            this.artisteToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.artisteToolStripMenuItem.Text = "Artiste";
            // 
            // consulterToolStripMenuItem3
            // 
            this.consulterToolStripMenuItem3.Name = "consulterToolStripMenuItem3";
            this.consulterToolStripMenuItem3.Size = new System.Drawing.Size(125, 22);
            this.consulterToolStripMenuItem3.Text = "Consulter";
            // 
            // créerToolStripMenuItem3
            // 
            this.créerToolStripMenuItem3.Name = "créerToolStripMenuItem3";
            this.créerToolStripMenuItem3.Size = new System.Drawing.Size(125, 22);
            this.créerToolStripMenuItem3.Text = "Créer";
            // 
            // vIPToolStripMenuItem
            // 
            this.vIPToolStripMenuItem.Name = "vIPToolStripMenuItem";
            this.vIPToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.vIPToolStripMenuItem.Text = "VIP";
            this.vIPToolStripMenuItem.Click += new System.EventHandler(this.vIPToolStripMenuItem_Click);
            // 
            // messageToolStripMenuItem
            // 
            this.messageToolStripMenuItem.Name = "messageToolStripMenuItem";
            this.messageToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.messageToolStripMenuItem.Text = "Message";
            // 
            // consulterToolStripMenuItem5
            // 
            this.consulterToolStripMenuItem5.Name = "consulterToolStripMenuItem5";
            this.consulterToolStripMenuItem5.Size = new System.Drawing.Size(152, 22);
            this.consulterToolStripMenuItem5.Text = "Consulter";
            // 
            // créerToolStripMenuItem5
            // 
            this.créerToolStripMenuItem5.Name = "créerToolStripMenuItem5";
            this.créerToolStripMenuItem5.Size = new System.Drawing.Size(152, 22);
            this.créerToolStripMenuItem5.Text = "Créer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 316);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem campagneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artisteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem évenementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem créerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consulterToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem créerToolStripMenuItem3;
    }
}

