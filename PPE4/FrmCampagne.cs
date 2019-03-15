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

        private void FrmCampagne_Load(object sender, EventArgs e)
        {
            connexion = new LienBDD() ;
        }

        private void fCamp_TpSet_BtValider_Click(object sender, EventArgs e)
        {
            fCamp_TpSet_lblReponse.Text = "Réussi";
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


        
    }
}
