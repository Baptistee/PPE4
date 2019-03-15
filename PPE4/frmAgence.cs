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
    public partial class Agenzdzdce : Form
    {
        LienBDD lien = new LienBDD();

        public Agenzdzdce()
        {
            InitializeComponent();
        }

        private void créeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabPageCreerAgence_Click(object sender, EventArgs e)
        {

        }

        private void btnCreeAgenceValider_Click(object sender, EventArgs e)
        {
            lien.createOneAgence(txtboxSpecialite.Text, txtBoxNom.Text, txtBoxSite.Text, txtBoxMail.Text, txtBoxTel.Text, txtBoxAdresse.Text);
        }

        private void btnCreeAgenceAnnuler_Click(object sender, EventArgs e)
        {
            txtboxSpecialite.Text = string.Empty;
            txtBoxNom.Text= string.Empty;
            txtBoxSite.Text= string.Empty;
            txtBoxMail.Text= string.Empty;
            txtBoxTel.Text= string.Empty;
            txtBoxAdresse.Text = string.Empty;
        }
    }
}
