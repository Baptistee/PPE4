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
    public partial class frmCategorie : Form
    {

        // Members
        internal LienBDD connexion;
        private DataTable dt = new DataTable();
        private int[] selectedRow = new int[4];


        public frmCategorie()
        {
            InitializeComponent();
        }


        // Methods
        private void refreshTable()
        {
            try
            {
                dt = connexion.ConsulterCategorie();
                this.dgCategorieConsulter.DataSource = dt;
                this.dgCategorieConsulter.DataMember = dt.TableName;
                this.dgCategorieConsulter.Columns[0].Visible = false;
                this.dgCategorieConsulter.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void frmCategorie_Load(object sender, EventArgs e)
        {
            connexion = new LienBDD();
            refreshTable();
        }


        private void btn_Categorie_Creer_Click(object sender, EventArgs e)
        {
            string libelle = txbCategorieCreer.Text;

            if (connexion.AjouterCategorie(libelle))
            {
                txbHelp.Text = "Message ajouté avec succés!";
                refreshTable();
                txbCategorieCreer.ResetText();
            }

            else
            {
                txbHelp.Text = "Message non ajouté";
            }
        }


        private void dgCategorieConsulter_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            gpb_Categorie_Ajouter.Enabled = false;
            gpb_Categorie_Action.Enabled = true;
            selectedRow[0] = Convert.ToInt32(dgCategorieConsulter.Rows[e.RowIndex].Cells[0].Value.ToString());
            txbCategorieAction.Text = dgCategorieConsulter.Rows[e.RowIndex].Cells[1].Value.ToString();
            selectedRow[1] = Convert.ToInt32(dgCategorieConsulter.Rows[e.RowIndex].Cells[1].Value.ToString());
        }
    }
}
