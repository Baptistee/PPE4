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

        //récupère le derniere de la table voulu et rajoute 1
        public int NextID(string p_table , string p_id)
        {
            string req = "SELECT MAX(" + p_id + ")+1 from " + p_table;
            this.cde = new SqlCommand(req, cn);
            int nb = (int)this.cde.ExecuteScalar();
            return nb;
        }

        public bool AjouterCampagne(string p_nom, string p_objectif, string p_publique, string p_dateDebut, string p_dateFin, string p_responsable, string p_agence1, string p_agence2)
        {
            

            try
            {
                //récuperation de l'id
                int nb = NextID("CAMPAGNE", "IDCAMPAGNE");

                //requete sql
                string req = "INSERT INTO CAMPAGNE (IDCAMPAGNE, IDEMPLOYE,IDAGENCE,IDAGENCE_ORGANISATEUR_ART,INTITULE,OBJECTIF,PUBLIQUE,DATEDEBUT,DATEFIN) VALUES (@id, @Employe, @Agence1 , @Agence2 , @nom, @objectif, @publique , @dateDebut, @dateFin)";



                this.cde = new SqlCommand(req, cn);
                //association des variables a leur valeur
                this.cde.Parameters.Add("@id", SqlDbType.Int).Value = nb;
                this.cde.Parameters.Add("@Employe", SqlDbType.Int).Value = int.Parse(p_responsable);
                this.cde.Parameters.Add("@Agence1", SqlDbType.Int).Value = int.Parse(p_agence1);
                this.cde.Parameters.Add("@Agence2", SqlDbType.Int).Value = int.Parse(p_agence2);
                this.cde.Parameters.Add("@nom", SqlDbType.VarChar).Value = p_nom;
                this.cde.Parameters.Add("@objectif", SqlDbType.VarChar).Value = p_objectif;
                this.cde.Parameters.Add("@publique", SqlDbType.VarChar).Value = p_publique;
                this.cde.Parameters.Add("@dateDebut", SqlDbType.Date).Value = DateTime.Parse(p_dateDebut);
                this.cde.Parameters.Add("@dateFin", SqlDbType.Date).Value = DateTime.Parse(p_dateFin);

                //execution de la requete
                this.cde.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        

        public DataTable GetCampagne()
        {
            string req = "Select CAMP.INTITULE , CAMP.OBJECTIF , CAMP.PUBLIQUE , AG1.NOM Agence1 , AG2.NOM Agence2 , CAMP.DATEDEBUT , CAMP.DATEFIN , EMP.NOM + ' ' +  EMP.PRENOM as Responsable FROM CAMPAGNE CAMP  inner join AGENCE AG1 on AG1.IDAGENCE = CAMP.IDAGENCE    inner join AGENCE AG2 on AG2.IDAGENCE = CAMP.IDAGENCE_ORGANISATEUR_ART	inner join EMPLOYE EMP on EMP.IDEMPLOYE = CAMP.IDEMPLOYE";
            this.cde = new SqlCommand(req, cn);
            da = new SqlDataAdapter();
            da.SelectCommand = this.cde;
            dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public DataTable GetResponsable()
        {
            string req = " SELECT IDEMPLOYE ,NOM + ' ' + PRENOM as Responsable FROM EMPLOYE ";
            this.cde = new SqlCommand(req, cn);
            da = new SqlDataAdapter();
            da.SelectCommand = this.cde;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable GetAgence()
        {
            string req = " SELECT IDAGENCE ,NOM FROM AGENCE ";
            this.cde = new SqlCommand(req, cn);
            da = new SqlDataAdapter();
            da.SelectCommand = this.cde;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


    }
}
