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
    public partial class FrmCampagne : Form
    {
        public FrmCampagne()
        {
            InitializeComponent();
        }

        internal LienBDD connexion;
        private DataTable dt;
        private DataTable dt2;


        //initialisation du lien avec la bdd
        private void FrmCampagne_Load(object sender, EventArgs e)
        {
            connexion = new LienBDD() ;

            this.ActualiserTableaux();

            dt = this.connexion.GetAgence();
            dt2 = this.connexion.GetAgence();
            this.fCamp_cbAgence1.DataSource = dt;
            this.fCamp_cbAgence2.DataSource = dt2;
            this.fCamp_cbAgence1.DisplayMember = "NOM";
            this.fCamp_cbAgence2.DisplayMember = "NOM";
            this.fCamp_cbAgence1.ValueMember = "IDAGENCE";
            this.fCamp_cbAgence2.ValueMember = "IDAGENCE";

            dt = this.connexion.GetResponsable();
            this.fCamp_cbResponsable.DataSource = dt;
            this.fCamp_cbResponsable.DisplayMember = "Responsable";
            this.fCamp_cbResponsable.ValueMember = "IDAGENCE";

            
        }

        //methode normal
        private void ActualiserTableaux()
        {
            try
            {
                dt = connexion.GetCampagne();
                this.fCamp_DgCampagne.DataSource = dt;
                this.fCamp_DgCampagne.DataMember = dt.TableName;
                this.fCamp_DgCampagne.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReinitialiserGroupBox(GroupBox grBox)
        {
            foreach (Control ctrl in grBox.Controls)
            {
                if (ctrl is TextBox)
                {

                    TextBox textBox = (TextBox)ctrl;

                    textBox.ResetText();

                }

                if (ctrl is ComboBox)
                {

                    ComboBox comboBox = (ComboBox)ctrl;

                    comboBox.ResetText();

                }

                if (ctrl is DateTimePicker)
                {
                    DateTimePicker dateTime = (DateTimePicker)ctrl;

                    dateTime.ResetText();
                }
            }
        }

        //methode bouton

        //Ajout de campagne
        private void fCamp_BtAnnuler_Click(object sender, EventArgs e)
        {
            this.ReinitialiserGroupBox(this.fCamp_GrpBox);
        }

        private void fCamp_BtValider_Click(object sender, EventArgs e)
        {
            connexion = new LienBDD();
            //recuperation du formulaire
            string nom = fCamp_tbNom.Text;
            string objectif = fCamp_tbObjectif.Text;
            string publique = fCamp_tbPublique.Text;
            string datedebut = fCamp_dtDateDebut.Text;
            string datefin = fCamp_dtDateFin.Text;
            string agence1 = fCamp_cbAgence1.Text;
            string agence2 = fCamp_cbAgence2.Text;
            string responsable = fCamp_cbResponsable.Text;

            if (connexion.AjouterCampagne(nom, objectif, publique, datedebut, datefin, responsable, agence1, agence2))
            {
                fCamp_TpSet_lblReponse.Text = "Réussi";
            }
            else
            {
                fCamp_TpSet_lblReponse.Text = "Echec !";
            }

            this.ActualiserTableaux();
        }



        

        

        
    }
}
