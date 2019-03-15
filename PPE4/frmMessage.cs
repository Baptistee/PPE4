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
        public frmMessage()
        {
            InitializeComponent();
        }


        internal LienBDD connexion;

        private void frmMessage_Load(object sender, EventArgs e)
        {
            connexion = new LienBDD();
        }

        private DataTable dt = new DataTable();

        private void btn_Creer_Valider_Click(object sender, EventArgs e)
        {
            connexion = new LienBDD();
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
