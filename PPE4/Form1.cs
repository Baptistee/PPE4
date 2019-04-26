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

        private void agenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgence formAgence = new frmAgence();
            formAgence.ShowDialog();

        }

        private void artisteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArtiste formArtiste = new frmArtiste();
            formArtiste.ShowDialog();
        }

    }
}
