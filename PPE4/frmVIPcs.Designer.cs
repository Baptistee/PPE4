namespace PPE4
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnVIPModifier = new System.Windows.Forms.Button();
            this.btnVIPSupprimer = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.grbCreerVIP = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grbModifierVIP = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbCreerVIP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbModifierVIP.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "Créer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(473, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 62);
            this.button2.TabIndex = 1;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnVIPModifier
            // 
            this.btnVIPModifier.Location = new System.Drawing.Point(279, 98);
            this.btnVIPModifier.Name = "btnVIPModifier";
            this.btnVIPModifier.Size = new System.Drawing.Size(75, 23);
            this.btnVIPModifier.TabIndex = 2;
            this.btnVIPModifier.Text = "Modifier";
            this.btnVIPModifier.UseVisualStyleBackColor = true;
            // 
            // btnVIPSupprimer
            // 
            this.btnVIPSupprimer.Location = new System.Drawing.Point(404, 98);
            this.btnVIPSupprimer.Name = "btnVIPSupprimer";
            this.btnVIPSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnVIPSupprimer.TabIndex = 3;
            this.btnVIPSupprimer.Text = "Supprimer";
            this.btnVIPSupprimer.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 13;
            this.comboBox1.Location = new System.Drawing.Point(6, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 175);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 20);
            this.textBox3.TabIndex = 7;
            // 
            // grbCreerVIP
            // 
            this.grbCreerVIP.Controls.Add(this.label1);
            this.grbCreerVIP.Controls.Add(this.textBox1);
            this.grbCreerVIP.Controls.Add(this.textBox2);
            this.grbCreerVIP.Controls.Add(this.textBox3);
            this.grbCreerVIP.Controls.Add(this.comboBox1);
            this.grbCreerVIP.Controls.Add(this.button1);
            this.grbCreerVIP.Controls.Add(this.button2);
            this.grbCreerVIP.Location = new System.Drawing.Point(12, 35);
            this.grbCreerVIP.Name = "grbCreerVIP";
            this.grbCreerVIP.Size = new System.Drawing.Size(674, 201);
            this.grbCreerVIP.TabIndex = 8;
            this.grbCreerVIP.TabStop = false;
            this.grbCreerVIP.Text = "Ajouter un VIP";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 440);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(674, 264);
            this.dataGridView1.TabIndex = 9;
            // 
            // grbModifierVIP
            // 
            this.grbModifierVIP.Controls.Add(this.textBox4);
            this.grbModifierVIP.Controls.Add(this.textBox5);
            this.grbModifierVIP.Controls.Add(this.textBox6);
            this.grbModifierVIP.Controls.Add(this.comboBox2);
            this.grbModifierVIP.Controls.Add(this.btnVIPModifier);
            this.grbModifierVIP.Controls.Add(this.btnVIPSupprimer);
            this.grbModifierVIP.Location = new System.Drawing.Point(12, 272);
            this.grbModifierVIP.Name = "grbModifierVIP";
            this.grbModifierVIP.Size = new System.Drawing.Size(674, 162);
            this.grbModifierVIP.TabIndex = 10;
            this.grbModifierVIP.TabStop = false;
            this.grbModifierVIP.Text = "Modifier le VIP";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 81);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(6, 107);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 20);
            this.textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(6, 133);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(121, 20);
            this.textBox6.TabIndex = 11;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 54);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Catégorie";
            // 
            // frmVIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 716);
            this.Controls.Add(this.grbModifierVIP);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grbCreerVIP);
            this.Name = "frmVIP";
            this.Text = "VIP";
            this.grbCreerVIP.ResumeLayout(false);
            this.grbCreerVIP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbModifierVIP.ResumeLayout(false);
            this.grbModifierVIP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnVIPModifier;
        private System.Windows.Forms.Button btnVIPSupprimer;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox grbCreerVIP;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grbModifierVIP;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
    }
}