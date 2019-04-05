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
        int IdAgence;

        DataTable dt;

        public frmAgence()
        {
            InitializeComponent();
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

        private void reloadDataGridView()
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

        private void btnAgenceSup_Click(object sender, EventArgs e)
        {
            if (lien.deleteAgence(IdAgence))
            {
                reloadDataGridView();
                lbl_Agence_Info.ForeColor = Color.Green;
                lbl_Agence_Info.Text = "Agence supprimé !";
            }
            else
            {
                MessageBox.Show("erreur");
            }
        }

        private void btnAgenceModif_Click(object sender, EventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvAgence.Rows[index];
            int id = 
        }

        private void btnAgenceCree_Click(object sender, EventArgs e)
        {
            //Si la requete ne renvoie pas d'erreur, l'agence est créée et un message de succèes apparait, sinon un message d'erreur apparait
            if (lien.createOneAgence(txtBoxSpecialite.Text, txtBoxNom.Text, txtBoxSite.Text, txtBoxMail.Text, txtBoxTel.Text, txtBoxAdresse.Text))
            {
                lbl_Agence_Info.ForeColor = Color.Green;
                lbl_Agence_Info.Text = "Agence créée avec succès !";
                txtBoxSpecialite.Text = string.Empty;
                txtBoxNom.Text = string.Empty;
                txtBoxSite.Text = string.Empty;
                txtBoxMail.Text = string.Empty;
                txtBoxTel.Text = string.Empty;
                txtBoxAdresse.Text = string.Empty; 
                reloadDataGridView();
            }
            else
            {
                lbl_Agence_Info.ForeColor = Color.Red;
                lbl_Agence_Info.Text = "Problème ! Impossible de créer l'agence !";
            }
        }

        private void frmAgence_Load(object sender, EventArgs e)
        {
            reloadDataGridView();
        }

        private void dgvAgence_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvAgence.Rows[index];
            if (index > 0 || index == 0 ){
                IdAgence = int.Parse(selectedRow.Cells[0].Value.ToString());
            }
        }

        private void btnAgenceAnnuler_Click(object sender, EventArgs e)
        {
            txtBoxAdresse.Text = String.Empty;
            txtBoxMail.Text = String.Empty;
            txtBoxNom.Text = String.Empty;
            txtBoxSite.Text = String.Empty;
            txtBoxSpecialite.Text = String.Empty;
            txtBoxTel.Text = String.Empty;
        }

    }
}
 