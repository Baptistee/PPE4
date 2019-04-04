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

        public DataTable getAllAgences()
        {
            string req = "SELECT * FROM Agence";
            this.cde = new SqlCommand(req, cn);
            da = new SqlDataAdapter();
            da.SelectCommand = this.cde;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void createOneAgence(string pSpe, string pNom, string pSite, string pMail, string pTel, string pAdresse)
        {
            string req = "INSERT INTO Agence(specialite, nom, site, mail, tel, adresse) VALUES ()";
            this.cde = new SqlCommand(req, cn);
        }

        public int NextID(string p_table, string p_id)
        {
            int nb;
            string req = "SELECT MAX(" + p_id + ")+1 FROM " + p_table;
            this.cde = new SqlCommand(req, cn);
            if (this.cde.ExecuteScalar().ToString() == "")
            {
                nb = 1;
            }
            else
            {
                nb = (int)this.cde.ExecuteScalar();
            }
            return nb;
        }


        // Baptiste
        public bool AjouterMessage(string p_contenue)
        {
            try
            {
                int nb = NextID("typemessage","1");
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

        // Said

        public bool creerEvenement(int idcampagne,DateTime dateDebut, DateTime dateFin, string ville, string theme)
        {
            try
            {
                int nb = NextID("evenement", "idevenement");
                string req = "insert into evenement(idevenement, idcampagne,datedebut,datefin,ville,theme) values (@idevenement, @idcampagne, @datedebut,@datefin, @ville, @theme)";
                this.cde = new SqlCommand(req, cn);
                this.cde.Parameters.Add("@idevenement", SqlDbType.Int).Value = nb;
                this.cde.Parameters.Add("@idcampagne", SqlDbType.Int).Value = idcampagne;
                this.cde.Parameters.Add("@datedebut", SqlDbType.Date).Value = dateDebut;
                this.cde.Parameters.Add("@datefin", SqlDbType.Date).Value = dateFin;
                this.cde.Parameters.Add("@ville", SqlDbType.VarChar).Value = ville;
                this.cde.Parameters.Add("@theme", SqlDbType.VarChar).Value = theme;

                this.cde.ExecuteNonQuery();
                return true;
              
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public bool updateEvenement(int idcampagne, DateTime dateDebut, DateTime dateFin, string ville, string theme)
        {
            try
            {
                int nb = NextID("evenement", "idevenement");
                string req = "UPDATE evenement SET  idcampagne = @idcampagne, datedebut = @datedebut, datefin=@datefin, ville=@ville, theme= @theme WHERE idevenement =@idevenement";
                this.cde = new SqlCommand(req, cn);

                this.cde.ExecuteNonQuery();
                return true;

            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public DataTable getAllEvenement()
        {
            string req = "SELECT * FROM evenement";
            this.cde = new SqlCommand(req, cn);
            da = new SqlDataAdapter();
            da.SelectCommand = this.cde;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool deleteEvenement(int id)
        {
            try
            {
                string req = "DELETE FROM evenement WHERE idevenement = @id";
                this.cde = new SqlCommand(req, cn);
                this.cde.Parameters.Add("@id", SqlDbType.Int).Value = id;
                this.cde.ExecuteNonQuery();
                return true;
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

    }
}