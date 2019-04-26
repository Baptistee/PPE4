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
        private int[] selectedRow = new int [4];


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
                this.dgMessageConsulter.Columns[0].Visible = false;
                this.dgMessageConsulter.Columns[1].Visible = false;
                this.dgMessageConsulter.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // Parser la combobox avec les événements.
        private void refreshEvenementCbbAjouter()
        {
            dt = this.connexion.ConsulterEvenement();
            this.cbb_Message_Evenement_Ajouter.DataSource = dt;
            this.cbb_Message_Evenement_Ajouter.DisplayMember = "theme";
            this.cbb_Message_Evenement_Ajouter.ValueMember = "idevenement";
        }


        private void refreshEvenementCbbAction(int idevenement)
        {
            dt = this.connexion.ConsulterEvenement();
            this.cbb_Message_Evenement_Action.DataSource = dt;
            this.cbb_Message_Evenement_Action.DisplayMember = "theme";
            this.cbb_Message_Evenement_Action.ValueMember = "idevenement";
            this.cbb_Message_Evenement_Action.SelectedValue = idevenement;
        }


        private void frmMessage_Load(object sender, EventArgs e)
        {
            connexion = new LienBDD();
            refreshTable();
            refreshEvenementCbbAjouter();
        }


        private void btn_Creer_Annuler_Click(object sender, EventArgs e)
        {
            txbMessageAction.ResetText();
            txbMessageCreer.ResetText();
        }


        private void btn_Message_Creer_Click(object sender, EventArgs e)
        {
            int idevenement = connexion.RecupEvenement(Int32.Parse(cbb_Message_Evenement_Ajouter.SelectedValue.ToString()));
            string contenue = txbMessageCreer.Text;

            if (connexion.AjouterMessage(idevenement, contenue)) // Exécuter la requête ajouter message.
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


        private void btn_Message_Supprimer_Click(object sender, EventArgs e)
        {
            if (connexion.SupprimerMessage(selectedRow[0]))
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
            gpb_Message_Ajouter.Enabled = false;
            gpb_Message_Action.Enabled = true;
            selectedRow[0] = Convert.ToInt32(dgMessageConsulter.Rows[e.RowIndex].Cells[0].Value.ToString());
            txbMessageAction.Text = dgMessageConsulter.Rows[e.RowIndex].Cells[2].Value.ToString();
            selectedRow[1] = Convert.ToInt32(dgMessageConsulter.Rows[e.RowIndex].Cells[1].Value.ToString());
            refreshEvenementCbbAction(selectedRow[1]);
        }


        private void btn_Message_Modifier_Click(object sender, EventArgs e)
        {

            int idevenement = Int32.Parse(cbb_Message_Evenement_Action.SelectedValue.ToString());

            if (connexion.ModifierMessage(selectedRow[0], idevenement, txbMessageAction.Text))
            {
                txbHelp.Text = "Message modifié avec succés!";
                refreshTable();
                txbMessageAction.ResetText();
                cbb_Message_Evenement_Action.ResetText();
            }
            else
            {
                txbHelp.Text = "Échec de la modification du message";
            }
            gpb_Message_Ajouter.Enabled = true;
            gpb_Message_Action.Enabled = false;
        }

    }
}
