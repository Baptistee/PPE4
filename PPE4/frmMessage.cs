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

        private void frmMessage_Load(object sender, EventArgs e)
        {
            connexion = new LienBDD();
        }


        private void tbpConsulter_Enter(object sender, EventArgs e)
        {
            try
            {
                // remplissage de la data grid view
                dt = connexion.ConsulterMessage();  // on appelle la méthode ConsulterMessage de la classe LienBdd
                this.dgMessageConsulter.DataSource = dt;
                this.dgMessageConsulter.DataMember = dt.TableName;
                this.dgMessageConsulter.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            }
            else
            {
                lblVerification.Text = "Message non ajouté";
            }
        }

    }
}
