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

        //Les Agences
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

        public bool createOneAgence(string pSpe, string pNom, string pSite, string pMail, string pTel, string pAdresse)
        {
            try
            {
                int id = NextID("Agence","IDAGENCE");
                string req = "INSERT INTO Agence(idagence, specialite, nom, site, mail, tel, adresse) VALUES (@id, @Spe, @Nom, @Site, @Mail, @Tel, @Adresse)";
                this.cde = new SqlCommand(req, cn);
                this.cde.Parameters.Add("@id", SqlDbType.Int).Value = id;
                this.cde.Parameters.Add("@Spe", SqlDbType.VarChar).Value = pSpe;
                this.cde.Parameters.Add("@Nom", SqlDbType.VarChar).Value = pNom;
                this.cde.Parameters.Add("@Site", SqlDbType.VarChar).Value = pSite;
                this.cde.Parameters.Add("@Mail", SqlDbType.VarChar).Value = pMail;
                this.cde.Parameters.Add("@Tel", SqlDbType.VarChar).Value = pTel;
                this.cde.Parameters.Add("@Adresse", SqlDbType.VarChar).Value = pAdresse;
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

        public int NextID(string p_table, string pid)
        {
            string req = "SELECT MAX(" + pid + ")+1 FROM " + p_table;
            this.cde = new SqlCommand(req, cn);
            int nb = (int) this.cde.ExecuteScalar();
            return nb;
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
