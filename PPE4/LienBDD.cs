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
                throw new Exception("Erreur à la connexion");
            }
        }


        public void FermerConnexion()
        {
            this.cn.Close();
        }


        public int RecupEvenement(int p_id)
        {
            try
            {
                String req = "SELECT idevenement FROM evenement WHERE idevenement = @idevenement";
                this.cde = new SqlCommand(req, cn);
                this.cde.Parameters.Add("@idevenement", SqlDbType.Int).Value = p_id;
                return (int)this.cde.ExecuteScalar();
            }

            catch (Exception)
            {
                return -1;
            }
        }


        public int RecupCategorie(int p_id)
        {
            try
            {
                String req = "SELECT idcategorie FROM categorie WHERE idcategorie = @idcategorie";
                this.cde = new SqlCommand(req, cn);
                this.cde.Parameters.Add("@idcategorie", SqlDbType.Int).Value = p_id;
                return (int)this.cde.ExecuteScalar();
            }

            catch (Exception)
            {
                return -1;
            }
        }


        public int NextID(string p_table, string p_id)
        {
            int nb;
            string req = "SELECT MAX(" + p_id + ")+1 FROM " + p_table;
            this.cde = new SqlCommand(req, cn);
            if(this.cde.ExecuteScalar().ToString() == "")
            {
                return nb = 1;
            }
            else
            {
                return nb = (int)this.cde.ExecuteScalar();
            }
        }


        public int LastID(string p_table, string p_id)
        {
            int nb;
            string req = "SELECT MAX(" + p_id + ") FROM " + p_table;
            this.cde = new SqlCommand(req, cn);
            if(this.cde.ExecuteScalar().ToString() == "")
            {
                return nb = 0;
            }
            else
            {
                return nb = (int)this.cde.ExecuteScalar();
            }
        }


        public bool AjouterMessage(int p_idcategorie, string p_contenue)
        {
            try
            {
                int nb = NextID("typemessage", "idtypemessage");
                string req = "insert into typemessage(idtypemessage, idcategorie, contenue) values (@id, @idcategorie, @contenue)";
                this.cde = new SqlCommand(req, cn);
                this.cde.Parameters.Add("@id", SqlDbType.Int).Value = nb;
                this.cde.Parameters.Add("@idcategorie", SqlDbType.Int).Value = p_idcategorie;
                this.cde.Parameters.Add("@contenue", SqlDbType.VarChar).Value = p_contenue;
                this.cde.ExecuteNonQuery();
                return true;
            }

            catch (Exception)
            {
                return false;
            }
        }


        public bool AjouterCategorie(string p_libelle)
        {
            try
            {
                int nb = NextID("categorie", "idcategorie");
                string req = "insert into categorie(idcategorie, libelle) values (@id, @libelle)";
                this.cde = new SqlCommand(req, cn);
                this.cde.Parameters.Add("@id", SqlDbType.Int).Value = nb;
                this.cde.Parameters.Add("@libelle", SqlDbType.VarChar).Value = p_libelle;
                this.cde.ExecuteNonQuery();
                return true;
            }

            catch (Exception)
            {
                return false;
            }
        }


        public DataTable ConsulterEvenement()
        {
            try
            {
                String req = "SELECT * FROM evenement";
                dt = new DataTable();
                this.cde = new SqlCommand(req, cn);
                da = new SqlDataAdapter();
                da.SelectCommand = this.cde;
                dt = new DataTable();
                da.Fill(dt);
                return dt;
            }

            catch (Exception)
            {
                return null;
            }
        }


        public DataTable ConsulterCategorie()
        {
            try
            {
                String req = "SELECT * FROM categorie";
                dt = new DataTable();
                this.cde = new SqlCommand(req, cn);
                da = new SqlDataAdapter();
                da.SelectCommand = this.cde;
                dt = new DataTable();
                da.Fill(dt);
                return dt;
            }

            catch (Exception)
            {
                return null;
            }
        }


        public DataTable ConsulterMessage()
        {
            try
            {
                String req = "SELECT * FROM typemessage";
                dt = new DataTable();
                this.cde = new SqlCommand(req, cn);
                da = new SqlDataAdapter();
                da.SelectCommand = this.cde;
                dt = new DataTable();
                da.Fill(dt);
                return dt;
            }

            catch (Exception)
            {
                return null;
            }
        }


        public bool SupprimerMessage(int p_id)
        {
            try
            {
                string req = "DELETE typemessage WHERE idtypemessage = @id";
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


        public bool SupprimerCategorie(int p_id)
        {
            try
            {
                string req = "DELETE categorie WHERE idcategorie = @id";
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


        public bool ModifierMessage(int p_id, int p_idcategorie, string p_contenue)
        {
            try
            {
                string req = "UPDATE typemessage SET contenue = @contenue, idcategorie = @idcategorie WHERE idtypemessage = @id";
                this.cde = new SqlCommand(req, cn);
                this.cde.Parameters.Add("@id", SqlDbType.Int).Value = p_id;
                this.cde.Parameters.Add("@idcategorie", SqlDbType.Int).Value = p_idcategorie;
                this.cde.Parameters.Add("@contenue", SqlDbType.VarChar).Value = p_contenue;
                this.cde.ExecuteNonQuery();
                return true;
            }

            catch (Exception)
            {
                return false;
            }
        }


        public bool ModifierCategorie(int p_id, string p_libelle)
        {
            try
            {
                string req = "UPDATE categorie SET libelle = @libelle WHERE idcategorie = @id";
                this.cde = new SqlCommand(req, cn);
                this.cde.Parameters.Add("@id", SqlDbType.Int).Value = p_id;
                this.cde.Parameters.Add("@libelle", SqlDbType.VarChar).Value = p_libelle;
                this.cde.ExecuteNonQuery();
                return true;
            }

            catch (Exception)
            {
                return false;
            }
        }


        public bool AjouterVIP(int p_idtypemessage, string p_nom, string p_adresse, string p_mail)
        {
            try
            {
                int nb = NextID("vip", "idvip");
                string req = "insert into vip values (@id, @idtypemessage, @nom, @adresse, @mail)";
                this.cde = new SqlCommand(req, cn);
                this.cde.Parameters.Add("@id", SqlDbType.Int).Value = nb;
                this.cde.Parameters.Add("@idtypemessage", SqlDbType.VarChar).Value = p_idtypemessage;
                this.cde.Parameters.Add("@nom", SqlDbType.VarChar).Value = p_nom;
                this.cde.Parameters.Add("@adresse", SqlDbType.VarChar).Value = p_adresse;
                this.cde.Parameters.Add("@mail", SqlDbType.VarChar).Value = p_mail;
                this.cde.ExecuteNonQuery();
                return true;
            }

            catch (Exception)
            {
                return false;
            }
        }


        public DataTable ConsulterVIP()
        {
            try
            {
                String req = "SELECT * FROM vip";
                dt = new DataTable();
                this.cde = new SqlCommand(req, cn);
                da = new SqlDataAdapter();
                da.SelectCommand = this.cde;
                dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
                 
            catch (Exception)
            {
                return null;
            }
        }
    }
}
