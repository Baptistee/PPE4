using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void évenementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consulterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void créerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCampagne formCampagne = new FrmCampagne();
            formCampagne.ShowDialog();
        }
    }
}
