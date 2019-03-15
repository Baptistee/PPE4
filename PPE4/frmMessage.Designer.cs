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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpConsulter = new System.Windows.Forms.TabPage();
            this.tbpCreer = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpConsulter);
            this.tabControl1.Controls.Add(this.tbpCreer);
            this.tabControl1.Location = new System.Drawing.Point(12, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(548, 292);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpConsulter
            // 
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
            this.tbpCreer.Location = new System.Drawing.Point(4, 22);
            this.tbpCreer.Name = "tbpCreer";
            this.tbpCreer.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCreer.Size = new System.Drawing.Size(540, 266);
            this.tbpCreer.TabIndex = 1;
            this.tbpCreer.Text = "Créer";
            this.tbpCreer.UseVisualStyleBackColor = true;
            // 
            // frmMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 316);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMessage";
            this.Text = "frmMessage";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpConsulter;
        private System.Windows.Forms.TabPage tbpCreer;
    }
}