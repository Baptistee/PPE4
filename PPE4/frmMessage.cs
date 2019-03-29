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
    public partial class frmMessage : Form
    {
        // Members
        internal LienBDD connexion;
        private DataTable dt = new DataTable();


        public frmMessage()
        {
            InitializeComponent();
        }


        // Methods

        private void refreshTable()
        {
            try
            {
                dt = connexion.ConsulterMessage();
                this.dgMessageConsulter.DataSource = dt;
                this.dgMessageConsulter.DataMember = dt.TableName;
                this.dgMessageConsulter.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmMessage_Load(object sender, EventArgs e)
        {
            connexion = new LienBDD();
        }


        private void tbpConsulter_Enter(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void btn_Creer_Annuler_Click(object sender, EventArgs e)
        {
            txbMessage.ResetText();
        }

        private void btn_Message_Creer_Click(object sender, EventArgs e)
        {
            string contenue = txbMessage.Text;

            if (connexion.AjouterMessage(contenue))
            {
                lblVerification.Text = "Message ajouté à la BDD";
                refreshTable();
                txbMessage.ResetText();
            }
            else
            {
                lblVerification.Text = "Message non ajouté";
            }
        }

        private void btn_Message_Supprimer_Click(object sender, EventArgs e)
        {
            int id = 0;

            if (connexion.SupprimerMessage(id))
            {
                lblVerification.Text = "Message supprimé de la BDD";
                refreshTable();
            }
            else
            {
                lblVerification.Text = "Échec de la suppréssion du message";
            }
        }

        private void dgMessageConsulter_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txbMessage.Text = dgMessageConsulter.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

    }
}
