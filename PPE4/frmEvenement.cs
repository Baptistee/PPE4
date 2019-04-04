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
    public partial class frmEvenement : Form
    {
        LienBDD lien = new LienBDD();
        DataTable dt;
        int idevenementRow;
        int idcampagneRow;
        DateTime datedebutRow, datefinRow;
        string villeRow, themeRow;
        public frmEvenement()
        {
            InitializeComponent();
        }

    

        private void reloadDataGridView()
        {
            try
            {
                dt = lien.getAllEvenement();
                this.dgvEvenement.DataSource = dt;
                this.dgvEvenement.DataMember = dt.TableName;
                this.dgvEvenement.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


       

        private void btnValider_Click_1(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(ville.Text) && !String.IsNullOrEmpty(theme.Text))
            {
                if (lien.creerEvenement(1, dateDebut.Value, dateFin.Value, ville.Text, theme.Text))
                {
                    lblRequete.Text = "Requete réussie";
                    lblRequete.ForeColor = Color.Green;
                    ville.Text = "";
                    theme.Text = "";
                    reloadDataGridView();
                }
                else
                {
                    lblRequete.Text = "Probleme avec la requete";
                    lblRequete.ForeColor = Color.Red;
                }
            }
            else
            {
                lblRequete.Text = "Veuillez remplir tous les champs";
                lblRequete.ForeColor = Color.Red;
            }
            
        }

        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {
            if (lien.deleteEvenement(idevenement))
            {
                reloadDataGridView();
            }
            else
            {
                MessageBox.Show("erreur");
            }
           
        }

        private void dgvEvenement_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvEvenement.Rows[index];

            if (index >= 0)
            {
                    try
                    {
                        idevenementRow = int.Parse(selectedRow.Cells[0].Value.ToString());
                        idcampagneRow = int.Parse(selectedRow.Cells[1].Value.ToString());
                        datedebutRow = (DateTime)selectedRow.Cells[2].Value;
                        datefinRow = (DateTime)selectedRow.Cells[3].Value;
                        villeRow = selectedRow.Cells[4].Value.ToString();
                        themeRow = selectedRow.Cells[5].Value.ToString();
                    }    
                  catch (Exception ex) 
                    {
                       MessageBox.Show(ex.Message);
                    }
        
  
            }
               
                
             
           
        }

        private void frmEvenement_Load(object sender, EventArgs e)
        {
            reloadDataGridView();
        }

        private void lblRequete_Click(object sender, EventArgs e)
        {
            lblRequete.Text = "";
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (lien.updateEvenement(idevenement, dateDebut.Value, dateFin.Value, ville.Text, theme.Text))
            {
                try
                {
                    lblRequete.Text = "Requete réussie";
                    lblRequete.ForeColor = Color.Green;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
              
                }
            }
        }
 

       
 

      

  


  
    

      

     
    }
}
