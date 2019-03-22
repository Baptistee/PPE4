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

        private void FrmCampagne_Load(object sender, EventArgs e)
        {
            connexion = new LienBDD() ;
        }

        private void fCamp_TpSet_BtValider_Click(object sender, EventArgs e)
        {
            connexion = new LienBDD() ;        
            string nom = fCamp_TpSet_tbNom.Text;
            string objectif = fCamp_TpSet_tbObjectif.Text;
            string publique = fCamp_TpSet_tbPublique.Text;
            string datedebut = fCamp_TpSet_dtDateDebut.Text;
            string datefin = fCamp_TpSet_dtDateFin.Text;
            string agence1 = fCamp_TpSet_cbAgence1.Text;
            string agence2 = fCamp_TpSet_cbAgence2.Text;
            string responsable = fCamp_TpSet_cbResponsable.Text;
 
            if(connexion.AjouterCampagne(nom, objectif, publique, datedebut,datefin,responsable,agence1, agence2))
            {
                fCamp_TpSet_lblReponse.Text = "Réussi";
            }
            else 
            {
                fCamp_TpSet_lblReponse.Text = "Echec !";
            }


        }

        private void fCamp_TpGet_Enter(object sender, EventArgs e)
        {     
            try
            {
                dt = connexion.GetCampagne();
                this.fCamp_TpGet_DgCampagne.DataSource = dt;
                this.fCamp_TpGet_DgCampagne.DataMember = dt.TableName;
                this.fCamp_TpGet_DgCampagne.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fCamp_TpSet_BtAnnuler_Click(object sender, EventArgs e)
        {
            fCamp_TpSet_tbNom.ResetText();
            fCamp_TpSet_tbObjectif.ResetText();
            fCamp_TpSet_tbPublique.ResetText();
            fCamp_TpSet_dtDateDebut.ResetText();
            fCamp_TpSet_dtDateFin.ResetText();
            fCamp_TpSet_cbAgence1.ResetText();
            fCamp_TpSet_cbAgence2.ResetText();
            fCamp_TpSet_cbResponsable.ResetText();
        }

        

        
    }
}
