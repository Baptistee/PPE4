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

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMessage formMessage = new frmMessage();
            formMessage.ShowDialog();
        }

        private void vIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVIP formVIP = new frmVIP();
            formVIP.ShowDialog();
        }
    }
}
