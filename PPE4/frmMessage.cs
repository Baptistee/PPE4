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
        private int selectedRow = 0;


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
            refreshTable();
        }


        private void btn_Creer_Annuler_Click(object sender, EventArgs e)
        {
            txbMessageAction.ResetText();
            txbMessageCreer.ResetText();
        }


        private void btn_Message_Creer_Click(object sender, EventArgs e)
        {
            string contenue = txbMessageCreer.Text;

            if (contenue.Count() > 4)
            {

                if (connexion.AjouterMessage(contenue))
                {
                    txbHelp.Text = "Message ajouté avec succés!";
                    refreshTable();
                    txbMessageCreer.ResetText();
                }

                else
                {
                    txbHelp.Text = "Message non ajouté";
                }
            }

            else
            {
                txbHelp.Text = "Entrez un message";
            }
            
        }


        private void btn_Message_Supprimer_Click(object sender, EventArgs e)
        {
            if (connexion.SupprimerMessage(selectedRow))
            {
                txbHelp.Text = "Message supprimé avec succés!";
                refreshTable();
                txbMessageAction.ResetText();
            }
            else
            {
                txbHelp.Text = "Échec de la suppréssion du message";
            }
        }


        private void dgMessageConsulter_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedRow = Convert.ToInt32(dgMessageConsulter.Rows[e.RowIndex].Cells[0].Value.ToString());
            txbMessageAction.Text = dgMessageConsulter.Rows[e.RowIndex].Cells[1].Value.ToString();
        }


        private void btn_Message_Modifier_Click(object sender, EventArgs e)
        {
            if (connexion.ModifierMessage(selectedRow, txbMessageAction.Text))
            {
                txbHelp.Text = "Message modifié avec succés!";
                refreshTable();
                txbMessageAction.ResetText();
            }
            else
            {
                txbHelp.Text = "Échec de la modification du message";
            }
        }

    }
}
