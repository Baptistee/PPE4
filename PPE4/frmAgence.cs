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
    public partial class frmAgence : Form
    {
        LienBDD lien = new LienBDD();

        DataTable dt;

        public frmAgence()
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
            //Si la requete ne renvoie pas d'erreur, l'agence est créée et un message de succèes apparait, sinon un message d'erreur apparait
            if (lien.createOneAgence(txtboxSpecialite.Text, txtBoxNom.Text, txtBoxSite.Text, txtBoxMail.Text, txtBoxTel.Text, txtBoxAdresse.Text))
            {
                lblValid.Text = "Agence créée avec succès !";
                txtboxSpecialite.Text = string.Empty;
                txtBoxNom.Text = string.Empty;
                txtBoxSite.Text = string.Empty;
                txtBoxMail.Text = string.Empty;
                txtBoxTel.Text = string.Empty;
                txtBoxAdresse.Text = string.Empty;
            }
            else
            {
                lblValid.Text = "Problème ! Impossible de créer l'agence !";
            }
        }

        private void btnCreeAgenceAnnuler_Click(object sender, EventArgs e)
        {
            //Une fois le bouton annuler cliquer, toute els textbox se vident
            txtboxSpecialite.Text = string.Empty;
            txtBoxNom.Text= string.Empty;
            txtBoxSite.Text= string.Empty;
            txtBoxMail.Text= string.Empty;
            txtBoxTel.Text= string.Empty;
            txtBoxAdresse.Text = string.Empty;
        }

        private void tabPageConsulterAgence_Enter(object sender, EventArgs e)
        {
            try
            {
                dt = lien.getAllAgences();
                this.dgvAgence.DataSource = dt;
                this.dgvAgence.DataMember = dt.TableName;
                this.dgvAgence.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
