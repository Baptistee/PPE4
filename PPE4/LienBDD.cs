using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;

namespace PPE4
{
    class LienBDD
    {
        //members
        private SqlConnection cn;
        private SqlCommand cde;
        private SqlDataAdapter da;
        private DataTable dt;


        //methods
        public LienBDD()
        {
            try
            {
                string ch = ConfigurationManager.ConnectionStrings["MaConnection"].ConnectionString;
                this.cn = new SqlConnection(ch);
                this.cn.Open();
            }
            catch (SqlException)
            {
                throw new Exception("Erreur à laconnexion");
            }
        }


        public void FermerConnexion()
        {
            this.cn.Close();
        }

        //Clement
        public int NextID()
        {
            string req = "SELECT MAX(IDcampagne)+1 from CAMPAGNE";
            this.cde = new SqlCommand(req, cn);
            int nb = (int)this.cde.ExecuteScalar();
            return nb;
        }

        public bool AjouterCampagne(string p_nom, string p_objectif, string p_publique, string p_dateDebut, string p_dateFin, string p_responsable, string p_agence1, string p_agence2)
        {
            int nb = NextID();
            
            string req = "INSERT INTO CAMPAGNE (IDCAMPAGNE, IDEMPLOYE,IDAGENCE,IDAGENCE_ORGANISATEUR_ART,INTITULE,OBJECTIF,PUBLIQUE,DATEDEBUT,DATEFIN) VALUES (@id, @Employe, @Agence1 , @Agence2 , @nom, @objectif, @publique , @dateDebut, @dateFin)";

            this.cde = new SqlCommand(req, cn);
            this.cde.Parameters.Add("@id", SqlDbType.Int).Value = nb ;
            this.cde.Parameters.Add("@Employe", SqlDbType.Int).Value = int.Parse(p_responsable);
            this.cde.Parameters.Add("@Agence1", SqlDbType.Int).Value = int.Parse(p_agence1);
            this.cde.Parameters.Add("@Agence2", SqlDbType.Int).Value = int.Parse(p_agence2);
            this.cde.Parameters.Add("@nom", SqlDbType.VarChar).Value = p_nom;
            this.cde.Parameters.Add("@objectif", SqlDbType.VarChar).Value = p_objectif;
            this.cde.Parameters.Add("@publique", SqlDbType.VarChar).Value = p_publique;
            this.cde.Parameters.Add("@dateDebut", SqlDbType.Date).Value = DateTime.Parse(p_dateDebut);
            this.cde.Parameters.Add("@dateFin", SqlDbType.Date).Value = DateTime.Parse(p_dateFin);

            try
            {
                this.cde.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
