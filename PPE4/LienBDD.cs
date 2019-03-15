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


        // Baptiste
        public bool AjouterMessage(int p_id, string p_contenue)
        {
            string req = "insert into typemessage(idtypemessage, contenue) values (@id, @contenue)";
            this.cde = new SqlCommand(req, cn);
            this.cde.Parameters.Add("@id", SqlDbType.Int).Value = p_id;
            this.cde.Parameters.Add("@contenue", SqlDbType.VarChar).Value = p_contenue;

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
