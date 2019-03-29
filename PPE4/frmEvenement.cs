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
        int idevenement;
        public frmEvenement()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (lien.creerEvenement(1, dateDebut.Value, dateFin.Value, ville.Text, theme.Text))
            {
                lblRequete.Text ="Requete réussie";
                lblRequete.ForeColor =  Color.Green;
                ville.Text = "";
                theme.Text = "";
            }else{
                   lblRequete.Text ="Probleme avec la requete";
                   lblRequete.ForeColor = Color.Red;
            }
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

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            reloadDataGridView();
        }

     

        private void btnSupprimer_Click(object sender, EventArgs e)
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

        private void dgvEvenement_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvEvenement.Rows[index];
           if(index>0)
            idevenement = int.Parse(selectedRow.Cells[0].Value.ToString());
           
        }
 

      

  


  
    

      

     
    }
}
