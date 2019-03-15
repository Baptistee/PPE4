using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE4
{
    class Agence
    {
        private int IDagence;
        private string specialite;
        private string nom;
        private string site;
        private string mail;
        private string tel;
        private string adresse;

        public Agence(int pid, string pspecialite, string pnom, string psite, string pmail, string ptel, string padresse)
        {
            this.IDagence = pid;
            this.specialite = pspecialite;
            this.nom = pnom;
            this.site = psite;
            this.mail = pmail;
            this.tel = ptel;
            this.adresse = padresse;
        }

        //A faire: toString()

        public int getID()
        {
            return this.IDagence;
        }

        public string getSpecialite()
        {
            return this.specialite;
        }

        public void setSpecialite(string pSpe)
        {
            this.specialite = pSpe;
        }

        public string getNom()
        {
            return this.nom;
        }

        public void setNom(string pnom)
        {
            this.nom = pnom;
        }

        public string getSite(){
            return this.site;
        }

        public void setSite(string psite)
        {
            this.site = psite;
        }

        public string getMail()
        {
            return this.mail;
        }

        public void setMail(string pmail)
        {
            this.mail = pmail;
        }

        public string getTel()
        {
            return this.tel;
        }

        public void setTel(string ptel)
        {
            this.tel = ptel;
        }

        public string getAdresse()
        {
            return this.adresse;
        }

        public void setAdresse(string padresse)
        {
            this.adresse = padresse;
        }

        public string getAllInfo()
        {
            return "ID: " + this.IDagence + "\NSpecialité: " + this.specialite + "\NNom: " + this.nom + "\NSite: " + this.Site + "\NMail: " + this.mail + "\NTéléphone: " + this.tel + "\NAdresse: " + this.adresse;
        }
    }
}
