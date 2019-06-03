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


                string req = "";

                if (p_agence1 != null && p_agence2 != null)
                {
                    req = "INSERT INTO CAMPAGNE (IDCAMPAGNE, IDEMPLOYE,IDAGENCE,IDAGENCE_ORGANISATEUR_ART,INTITULE,OBJECTIF,PUBLIQUE,DATEDEBUT,DATEFIN) VALUES (@id, @Employe, @Agence1 , @Agence2 , @nom, @objectif, @publique , @dateDebut, @dateFin)";

                    this.cde = new SqlCommand(req, cn);

                    this.cde.Parameters.Add("@Agence1", SqlDbType.Int).Value = int.Parse(p_agence1);
                    this.cde.Parameters.Add("@Agence2", SqlDbType.Int).Value = int.Parse(p_agence2);
                }
                else if (p_agence1 == null && p_agence2 != null)
                {
                    req = "INSERT INTO CAMPAGNE (IDCAMPAGNE, IDEMPLOYE,IDAGENCE_ORGANISATEUR_ART,INTITULE,OBJECTIF,PUBLIQUE,DATEDEBUT,DATEFIN) VALUES (@id, @Employe , @Agence2 , @nom, @objectif, @publique , @dateDebut, @dateFin)";
                    
                    this.cde = new SqlCommand(req, cn);

                    this.cde.Parameters.Add("@Agence2", SqlDbType.Int).Value = int.Parse(p_agence2);
                }
                else if (p_agence1 != null && p_agence2 == null)
                {
                    req = "INSERT INTO CAMPAGNE (IDCAMPAGNE, IDEMPLOYE,IDAGENCE,INTITULE,OBJECTIF,PUBLIQUE,DATEDEBUT,DATEFIN) VALUES (@id, @Employe, @Agence1 , @nom, @objectif, @publique , @dateDebut, @dateFin)";

                    this.cde = new SqlCommand(req, cn);

                    this.cde.Parameters.Add("@Agence1", SqlDbType.Int).Value = int.Parse(p_agence1);
                }
                else
                {
                    req = "INSERT INTO CAMPAGNE (IDCAMPAGNE, IDEMPLOYE,INTITULE,OBJECTIF,PUBLIQUE,DATEDEBUT,DATEFIN) VALUES (@id, @Employe , @nom, @objectif, @publique , @dateDebut, @dateFin)";

                    this.cde = new SqlCommand(req, cn);

                }
                

                


                
                //association des variables a leur valeur
                this.cde.Parameters.Add("@id", SqlDbType.Int).Value = nb;
                this.cde.Parameters.Add("@Employe", SqlDbType.Int).Value = int.Parse(p_responsable);

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
            string req = "Select CAMP.IDCAMPAGNE , CAMP.INTITULE , CAMP.OBJECTIF , CAMP.PUBLIQUE , AG1.NOM Agence_Communication , AG2.NOM Agence_Artistique , CAMP.DATEDEBUT , CAMP.DATEFIN , EMP.NOM + ' ' +  EMP.PRENOM as Responsable FROM CAMPAGNE CAMP  left join AGENCE AG1 on AG1.IDAGENCE = CAMP.IDAGENCE    left join AGENCE AG2 on AG2.IDAGENCE = CAMP.IDAGENCE_ORGANISATEUR_ART	inner join EMPLOYE EMP on EMP.IDEMPLOYE = CAMP.IDEMPLOYE";
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

        public DataTable GetAgenceArtistique()
        {
            string req = " SELECT IDAGENCE ,NOM FROM AGENCE WHERE SPECIALITE = 'Artistique' ";
            this.cde = new SqlCommand(req, cn);
            da = new SqlDataAdapter();
            da.SelectCommand = this.cde;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable GetAgenceCommunication()
        {
            string req = " SELECT IDAGENCE ,NOM FROM AGENCE WHERE SPECIALITE = 'Communication' ";
            this.cde = new SqlCommand(req, cn);
            da = new SqlDataAdapter();
            da.SelectCommand = this.cde;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool DeleteCampagne(int p_id)
        {
            try
            {
                string req = "DELETE CAMPAGNE WHERE IDCAMPAGNE = @id";
                this.cde = new SqlCommand(req, cn);
                this.cde.Parameters.Add("@id", SqlDbType.Int).Value = p_id;
                this.cde.ExecuteNonQuery();
                return true;
            }

            catch (Exception)
            {
                return false;
            }
        }

        public bool ModifierCampagne(int p_id, string p_nom, string p_objectif, string p_publique, string p_dateDebut, string p_dateFin, string p_responsable, string p_agence1, string p_agence2)
        {
            try
            {
                //requete sql

                string req = "";

                if (p_agence1 != null && p_agence2 != null)
                {
                    req = "UPDATE CAMPAGNE SET IDEMPLOYE = @Employe, IDAGENCE = @Agence1 , IDAGENCE_ORGANISATEUR_ART = @Agence2 , INTITULE = @nom, OBJECTIF = @objectif, PUBLIQUE = @publique , DATEDEBUT = @dateDebut, DATEFIN = @dateFin WHERE IDCAMPAGNE = @id";

                    this.cde = new SqlCommand(req, cn);

                    this.cde.Parameters.Add("@Agence1", SqlDbType.Int).Value = int.Parse(p_agence1);
                    this.cde.Parameters.Add("@Agence2", SqlDbType.Int).Value = int.Parse(p_agence2);
                }
                else if (p_agence1 == null && p_agence2 != null)
                {
                    req = "UPDATE CAMPAGNE SET IDEMPLOYE = @Employe, IDAGENCE = null, IDAGENCE_ORGANISATEUR_ART = @Agence2 , INTITULE = @nom, OBJECTIF = @objectif, PUBLIQUE = @publique , DATEDEBUT = @dateDebut, DATEFIN = @dateFin WHERE IDCAMPAGNE = @id";
                    this.cde = new SqlCommand(req, cn);

                    this.cde.Parameters.Add("@Agence2", SqlDbType.Int).Value = int.Parse(p_agence2);
                }
                else if (p_agence1 != null && p_agence2 == null)
                {
                    req = "UPDATE CAMPAGNE SET IDEMPLOYE = @Employe, IDAGENCE = @Agence1 ,IDAGENCE_ORGANISATEUR_ART = null, INTITULE = @nom, OBJECTIF = @objectif, PUBLIQUE = @publique , DATEDEBUT = @dateDebut, DATEFIN = @dateFin WHERE IDCAMPAGNE = @id";
                    
                    this.cde = new SqlCommand(req, cn);

                    this.cde.Parameters.Add("@Agence1", SqlDbType.Int).Value = int.Parse(p_agence1);
                }
                else
                {
                    req = "UPDATE CAMPAGNE SET IDEMPLOYE = @Employe,IDAGENCE = null,IDAGENCE_ORGANISATEUR_ART = null, INTITULE = @nom, OBJECTIF = @objectif, PUBLIQUE = @publique , DATEDEBUT = @dateDebut, DATEFIN = @dateFin WHERE IDCAMPAGNE = @id";

                    this.cde = new SqlCommand(req, cn);

                }

                 //req = "UPDATE CAMPAGNE SET IDEMPLOYE = @Employe, IDAGENCE = @Agence1 , IDAGENCE_ORGANISATEUR_ART = @Agence2 , INTITULE = @nom, OBJECTIF = @objectif, PUBLIQUE = @publique , DATEDEBUT = @dateDebut, DATEFIN = @dateFin WHERE IDCAMPAGNE = @id";


                
                //association des variables a leur valeur
                this.cde.Parameters.Add("@Employe", SqlDbType.Int).Value = int.Parse(p_responsable);
                
                
                this.cde.Parameters.Add("@nom", SqlDbType.VarChar).Value = p_nom;
                this.cde.Parameters.Add("@objectif", SqlDbType.VarChar).Value = p_objectif;
                this.cde.Parameters.Add("@publique", SqlDbType.VarChar).Value = p_publique;
                this.cde.Parameters.Add("@dateDebut", SqlDbType.Date).Value = DateTime.Parse(p_dateDebut);
                this.cde.Parameters.Add("@dateFin", SqlDbType.Date).Value = DateTime.Parse(p_dateFin);
                this.cde.Parameters.Add("@id", SqlDbType.Int).Value = p_id;

                //execution de la requete
                this.cde.ExecuteNonQuery();
                
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public string GetAgenceId(string p_nom)
        {
            
                //requete sql
                string req = "SELECT IDAGENCE FROM AGENCE WHERE NOM = @nom";

                this.cde = new SqlCommand(req, cn);
                //association des variables a leur valeur
                this.cde.Parameters.Add("@nom", SqlDbType.VarChar).Value = p_nom;
                
                //execution de la requete
                string result = this.cde.ExecuteScalar().ToString();
                   
                return result;  
        }

        public DataTable GetAnneCampagne()
        {
            //requete sql 
            string req = "SELECT year(CAMPAGNE.DATEDEBUT) as Annee FROM CAMPAGNE group by YEAR(CAMPAGNE.DATEDEBUT)";

            this.cde = new SqlCommand(req, cn);
            da = new SqlDataAdapter();
            da.SelectCommand = this.cde;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable GetNbrEvenmentParCampagnePourUneAnnee(int p_annee)
        {
            //requete sql 
            string req = "SELECT COUNT(EVENEMENT.IDEVENEMENT) as NombreEvenement, CAMPAGNE.INTITULE FROM CAMPAGNE INNER JOIN EVENEMENT on CAMPAGNE.IDCAMPAGNE = EVENEMENT.IDCAMPAGNE where YEAR(CAMPAGNE.DATEDEBUT) = @annee Group by CAMPAGNE.IDCAMPAGNE, CAMPAGNE.INTITULE";

            this.cde = new SqlCommand(req, cn);
            //association des variables a leur valeur
            this.cde.Parameters.Add("@annee", SqlDbType.Int).Value = p_annee;

            //execution de la requete
            da = new SqlDataAdapter();
            da.SelectCommand = this.cde;
            dt = new DataTable();
            da.Fill(dt);
            return dt;

        }


    }
}
