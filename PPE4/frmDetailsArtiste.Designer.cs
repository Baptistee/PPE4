namespace PPE4
{
    partial class frmDetailsArtiste
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
            this.dgvDetailsArtiste = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailsArtiste)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetailsArtiste
            // 
            this.dgvDetailsArtiste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetailsArtiste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailsArtiste.Location = new System.Drawing.Point(12, 165);
            this.dgvDetailsArtiste.Name = "dgvDetailsArtiste";
            this.dgvDetailsArtiste.Size = new System.Drawing.Size(533, 220);
            this.dgvDetailsArtiste.TabIndex = 0;
            this.dgvDetailsArtiste.Enter += new System.EventHandler(this.dgvDetailsArtiste_Enter);
            // 
            // frmDetailsArtiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 397);
            this.Controls.Add(this.dgvDetailsArtiste);
            this.Name = "frmDetailsArtiste";
            this.Text = "frmDetailsArtiste";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailsArtiste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetailsArtiste;
    }
}