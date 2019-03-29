﻿using System;
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

        public int NextID(string p_table)
        {
            string req = "SELECT MAX(idtypemessage)+1 FROM " + p_table;
            this.cde = new SqlCommand(req, cn);
            int nb = (int) this.cde.ExecuteScalar();
            return nb;
        }


        // Baptiste
        public bool AjouterMessage(string p_contenue)
        {
            try
            {
                int nb = NextID("typemessage");
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
                int nb = NextID("evenement");
                string req = "insert into evenement(idevenement, idcampagne,datedebut,datefin,ville,theme) values (@idevenement, @idcampagne, @datedebut,@datefin, @ville, @theme)";
                this.cde = new SqlCommand(req, cn);
                this.cde.Parameters.Add("@idevenement", SqlDbType.Int).Value = nb;
                this.cde.Parameters.Add("@idcampagne", SqlDbType.Int).Value = idcampagne;
                this.cde.Parameters.Add("@datedebut", SqlDbType.DateTime).Value = dateDebut;
                this.cde.Parameters.Add("@datefin", SqlDbType.DateTime).Value = dateFin;
                this.cde.Parameters.Add("@ville", SqlDbType.VarChar).Value = ville;
                this.cde.Parameters.Add("@ville", SqlDbType.VarChar).Value = ville;

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