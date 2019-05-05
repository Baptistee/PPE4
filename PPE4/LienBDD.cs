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

        #region LORIS

        #region ARTISTES
        //Les Artistes
        //Insert un artiste dans la bdd à partir des donénes du form
        public bool createOneArtiste(string pNom, string pPrenom, string pMail, string pNum)
        {
            try
            {
                int id = NextID("Artiste", "IDARTISTE");
                string req = "INSERT INTO Artiste(idartiste, nom, prenom, mail, num) VALUES (@id, @Nom, @Prenom, @Mail, @Num)";
                this.cde = new SqlCommand(req, cn);
                this.cde.Parameters.Add("@id", SqlDbType.Int).Value = id;
                this.cde.Parameters.Add("@Nom", SqlDbType.VarChar).Value = pNom;
                this.cde.Parameters.Add("@Prenom", SqlDbType.VarChar).Value = pPrenom;
                this.cde.Parameters.Add("@Mail", SqlDbType.VarChar).Value = pMail;
                this.cde.Parameters.Add("@Num", SqlDbType.VarChar).Value = pNum;
                this.cde.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Select tout les artistes de la bdd
        public DataTable getAllArtistes()
        {
            try
            {
                string req = "SELECT * FROM Artiste ORDER BY Nom";
                this.cde = new SqlCommand(req, cn);
                da = new SqlDataAdapter();
                da.SelectCommand = this.cde;
                dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //UPDATE un artiste avec les nouvelles valeurs du formulaire où l'id est le même
        public bool updateOneArtiste(int id, string pNom, string pPrenom, string pMail, string pNum)
        {
            try
            {
                string req = "UPDATE Artiste SET nom = @Nom, prenom = @Prenom, mail = @Mail, num= @Num WHERE IDARTISTE = @id";
                this.cde = new SqlCommand(req, cn);
                this.cde.Parameters.Add("@id", SqlDbType.Int).Value = id;
                this.cde.Parameters.Add("@Nom", SqlDbType.VarChar).Value = pNom;
                this.cde.Parameters.Add("@Prenom", SqlDbType.VarChar).Value = pPrenom;
                this.cde.Parameters.Add("@Mail", SqlDbType.VarChar).Value = pMail;
                this.cde.Parameters.Add("@Num", SqlDbType.VarChar).Value = pNum;
                this.cde.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        //supprime la ligne de la table artiste qui a pour id celui rentré
        public bool deleteArtiste(int pid)
        {
            try
            {
                string req = "DELETE FROM Artiste WHERE IDARTISTE = @id";
                this.cde = new SqlCommand(req, cn);
                this.cde.Parameters.Add("@id", SqlDbType.Int).Value = pid;
                this.cde.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable getDetailsOneArtiste(int pIdArtiste)
        {
            try
            {
                string req = "SELECT inviter.idevenement, idartiste, cachet, ville, theme, datedebut, datefin FROM Inviter INNER JOIN Evenement ON Inviter.IdEvenement = Evenement.IdEvenement WHERE IDARTISTE = @id";
                this.cde = new SqlCommand(req, cn);
                this.cde.Parameters.Add("@id", SqlDbType.Int).Value = pIdArtiste;
                da = new SqlDataAdapter();
                da.SelectCommand = this.cde;
                dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Fin Artistes

        #endregion

        #region AGENCES
        //Début Les Agences
        public DataTable getAllAgences()
        {
            try
            {
                string req = "SELECT * FROM Agence";
                this.cde = new SqlCommand(req, cn);
                da = new SqlDataAdapter();
                da.SelectCommand = this.cde;
                dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool createOneAgence(string pSpe, string pNom, string pSite, string pMail, string pTel, string pAdresse, string pVille, string pCp)
        {
            try
            {
                int id = NextID("Agence", "IDAGENCE");
                string req = "INSERT INTO Agence(idagence, specialite, nom, site, mail, tel, adresse, ville, cp) VALUES (@id, @Spe, @Nom, @Site, @Mail, @Tel, @Adresse, @Ville, @Cp)";
                this.cde = new SqlCommand(req, cn);
                this.cde.Parameters.Add("@id", SqlDbType.Int).Value = id;
                this.cde.Parameters.Add("@Spe", SqlDbType.VarChar).Value = pSpe;
                this.cde.Parameters.Add("@Nom", SqlDbType.VarChar).Value = pNom;
                this.cde.Parameters.Add("@Site", SqlDbType.VarChar).Value = pSite;
                this.cde.Parameters.Add("@Mail", SqlDbType.VarChar).Value = pMail;
                this.cde.Parameters.Add("@Tel", SqlDbType.VarChar).Value = pTel;
                this.cde.Parameters.Add("@Adresse", SqlDbType.VarChar).Value = pAdresse;
                this.cde.Parameters.Add("@Ville", SqlDbType.VarChar).Value = pVille;
                this.cde.Parameters.Add("@Cp", SqlDbType.VarChar).Value = pCp;
                this.cde.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool updateOneAgence(int id, string pSpe, string pNom, string pSite, string pMail, string pTel, string pAdresse, string pVille, string pCp)
        {
            try
            {
                string req = "UPDATE Agence SET specialite = @Spe, nom = @Nom, site= @Site, mail = @Mail, tel = @Tel, adresse = @Adresse, ville = @Ville, cp = @Cp WHERE IDAGENCE = @id";
                this.cde = new SqlCommand(req, cn);
                this.cde.Parameters.Add("@id", SqlDbType.Int).Value = id;
                this.cde.Parameters.Add("@Spe", SqlDbType.VarChar).Value = pSpe;
                this.cde.Parameters.Add("@Nom", SqlDbType.VarChar).Value = pNom;
                this.cde.Parameters.Add("@Site", SqlDbType.VarChar).Value = pSite;
                this.cde.Parameters.Add("@Mail", SqlDbType.VarChar).Value = pMail;
                this.cde.Parameters.Add("@Tel", SqlDbType.VarChar).Value = pTel;
                this.cde.Parameters.Add("@Adresse", SqlDbType.VarChar).Value = pAdresse;
                this.cde.Parameters.Add("@Ville", SqlDbType.VarChar).Value = pVille;
                this.cde.Parameters.Add("@Cp", SqlDbType.VarChar).Value = pCp;
                this.cde.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool deleteAgence(int pid)
        {
            try
            {
                string req = "DELETE Agence WHERE IDAGENCE = @id";
                this.cde = new SqlCommand(req, cn);
                this.cde.Parameters.Add("@id", SqlDbType.Int).Value = pid;
                this.cde.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Fin des Agences
        #endregion

        #endregion

        public int NextID(string p_table, string p_id)
        {
            int nb;
            string req = "SELECT MAX(" + p_id + ")+1 FROM " + p_table;
            this.cde = new SqlCommand(req, cn);
            if (this.cde.ExecuteScalar().ToString() == "")
            {
                return nb = 1;
            }
            else
            {
                return nb = (int)this.cde.ExecuteScalar();
            }
        }

        // Baptiste
        public bool AjouterMessage(string p_contenue)
        {
            try
            {
                int nb = NextID("typemessage","idtypemessage");
                string req = "insert into typemessage(idtypemessage, contenue) values (@id, @contenue)";
                this.cde = new SqlCommand(req, cn);
                this.cde.Parameters.Add("@id", SqlDbType.Int).Value = nb;
                this.cde.Parameters.Add("@contenue", SqlDbType.VarChar).Value = p_contenue;
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
