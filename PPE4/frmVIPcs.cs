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
    public partial class frmVIP : Form
    {

        // Members
        internal LienBDD connexion;
        private DataTable dt = new DataTable();
        private int selectedRow = 0;


        // Methods

        public frmVIP()
        {
            InitializeComponent();
        }


        private void refreshTable()
        {
            try
            {
                dt = connexion.ConsulterVIP();
                this.dgVIP.DataSource = dt;
                this.dgVIP.DataMember = dt.TableName;
                this.dgVIP.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void frmVIP_Load(object sender, EventArgs e)
        {
            connexion = new LienBDD();
            refreshTable();
            refreshEvenementCbbAjouter();
        }


        // Parser la combobox avec les événements.
        private void refreshEvenementCbbAjouter()
        {
            dt = this.connexion.ConsulterEvenement();
            this.cbAjouterCategorie.DataSource = dt;
            this.cbAjouterCategorie.DisplayMember = "theme";
            this.cbAjouterCategorie.ValueMember = "idevenement";
        }


        private void btnCréer_Click(object sender, EventArgs e)
        {
            int idcategorie = Int32.Parse(cbAjouterCategorie.Text);
            string nom = txbAjouterNom.Text;
            string adresse = txbAjouterAdresse.Text;
            string mail = txbAjouterMail.Text;

            if (connexion.AjouterVIP(idcategorie, nom, adresse, mail))
            {
                refreshTable();
            }
            else
            {

            }
        }
    }
}
