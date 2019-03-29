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

        public int NextID(string p_table, string p_id)
        {
            int nb;
            string req = "SELECT MAX(" + p_id + ")+1 FROM " + p_table;
            this.cde = new SqlCommand(req, cn);
            if(this.cde.ExecuteScalar().ToString() == "")
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
                int nb = NextID("typemessage", "idtypemessage");
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


        public DataTable ConsulterMessage()
        {
            try
            {
                String req = "SELECT idtypemessage, contenue FROM typemessage";
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


        public bool ModifierMessage(int p_id, string p_contenue)
        {
            try
            {
                string req = "UPDATE typemessage SET contenue = @contenue WHERE idtypemessage = @id";
                this.cde = new SqlCommand(req, cn);
                this.cde.Parameters.Add("@id", SqlDbType.Int).Value = p_id;
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
