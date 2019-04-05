using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE4
{
    class Artiste
    {
        private int IDagence;
        private string nom;

        public Artiste(int pid, string pnom)
        {
            this.IDagence = pid;
            this.nom = pnom;
        }

        public int getID()
        {
            return this.IDagence;
        }

        public string getNom()
        {
            return this.nom;
        }

        public void setNom(string pNom)
        {
            this.nom = pNom;
        }

        public string getAllInfo()
        {
            return "ID: " + this.IDagence + "\nNom: " + this.nom;
        }
    }
}
