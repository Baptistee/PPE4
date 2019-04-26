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
            //obtient toutes les données des agences dans la bdd
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
            //recharge le datagrid
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
            //On récupère l'id de la ligne sélectionner, et on supprime la ligne de la bdd et on recharge le datagrid
            if (lien.deleteAgence(IdAgence))
            {
                reloadDataGridView();
                lbl_Agence_Info.ForeColor = Color.Green;
                lbl_Agence_Info.Text = "Agence supprimé !";
            }
            else
            {
                lbl_Agence_Info.Text = "Erreur !";
                lbl_Agence_Info.ForeColor = Color.Red;
            }
        }

        private void btnAgenceModif_Click(object sender, EventArgs e)
        {
            //L'agence est modifiée avec les données comprisent dans les textboxs et un message de succès apparait, sinon un message d'erreur apparait 
            if (lien.updateOneAgence(IdAgence, txtBoxSpecialite.Text, txtBoxNom.Text, txtBoxSite.Text, txtBoxMail.Text, txtBoxTel.Text, txtBoxAdresse.Text))
            {
                reloadDataGridView();
                lbl_Agence_Info.ForeColor = Color.Green;
                lbl_Agence_Info.Text = "Agence modifiée !";
            }
            else
            {
                lbl_Agence_Info.Text = "Erreur !";
                lbl_Agence_Info.ForeColor = Color.Red;
            }
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
            //lorsque l'on charge le form, le datagrid est chargé avec les données de la bdd
            reloadDataGridView();
        }

        private void btnAgenceAnnuler_Click(object sender, EventArgs e)
        {
            //Annuler permet de rendre toutes les textboxs vide
            txtBoxAdresse.Text = String.Empty;
            txtBoxMail.Text = String.Empty;
            txtBoxNom.Text = String.Empty;
            txtBoxSite.Text = String.Empty;
            txtBoxSpecialite.Text = String.Empty;
            txtBoxTel.Text = String.Empty;
        }

        private void dgvAgence_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Lorsque l'on clique sur une ligne (que ce soit le header, ou une autre cell)
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dgvAgence.Rows[index];
                txtBoxSpecialite.Text = selectedRow.Cells[1].Value.ToString();
                txtBoxNom.Text = selectedRow.Cells[2].Value.ToString();
                txtBoxSite.Text = selectedRow.Cells[3].Value.ToString();
                txtBoxMail.Text = selectedRow.Cells[4].Value.ToString();
                txtBoxTel.Text = selectedRow.Cells[5].Value.ToString();
                txtBoxAdresse.Text = selectedRow.Cells[6].Value.ToString();
                if (index > 0 || index == 0)
                {
                    IdAgence = int.Parse(selectedRow.Cells[0].Value.ToString());
                }
            }
            catch (Exception)
            {
                //Ne rien mettre Si on clique sur la dernière ligne, 
                //le programme crash sans aucune raison, mais avec le try catch, 
                //on règle ce problème. Si ca marche (si on clique sur une ligne autre que la dernière) 
                //on fait les actions sinon, on fait rien, pas besoin de fermer le programme
                
            }
            
        }


    }
}
 