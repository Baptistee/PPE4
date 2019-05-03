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
        private int[] selectedRow = new int[4];


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
                this.dgVIP.Columns[0].Visible = false;
                this.dgVIP.Columns[1].Visible = false;
                this.dgVIP.Columns[5].Visible = false;
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
            refreshCategorieCbbAjouter();
        }


        // Parser la combobox avec les événements.
        private void refreshCategorieCbbAjouter()
        {
            dt = this.connexion.ConsulterCategorie();
            this.cbAjouterCategorie.DataSource = dt;
            this.cbAjouterCategorie.DisplayMember = "libelle";
            this.cbAjouterCategorie.ValueMember = "idcategorie";
        }


        private void btnCréer_Click(object sender, EventArgs e)
        {
            int idcategorie = Int32.Parse(cbAjouterCategorie.SelectedValue.ToString());
            string nom = txbAjouterNom.Text;
            string adresse = txbAjouterAdresse.Text;
            string email = txbAjouterMail.Text;

            if (connexion.AjouterVIP(idcategorie, nom, adresse, email))
            {
                txbHelp.Text = "VIP ajouté avec succés!";
                refreshTable();
                grbVIPCreer.ResetText();
            }
            else
            {
                txbHelp.Text = "VIP non ajouté";
            }
        }

        private void btnCreerAnnuler_Click(object sender, EventArgs e)
        {
            txbAjouterNom.ResetText();
            txbAjouterAdresse.ResetText();
            txbAjouterMail.ResetText();
        }
    }
}
