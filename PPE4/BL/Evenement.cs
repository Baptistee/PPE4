using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE4
{
    class Evenement
    {
        private int id;
        private DateTime dateDebut;
        private DateTime dateFin;
        private string theme;
        private string ville;

        public Evenement(int pid, DateTime pdateDebut, DateTime pdateFin, string ptheme, string pville)
        {
            this.id = pid;
            this.dateDebut = pdateDebut;
            this.dateFin = pdateFin;
            this.theme = ptheme;
            this.ville = pville;
        }

        public int getId()
        {
            return this.id;
        }

        public void setIdEvenement(int pid)
        {
            this.id = pid;
        }

        public DateTime getDateDebut()
        {
            return this.dateDebut;
        }
        public void setDateDebut(DateTime pdate)
        {
            this.dateDebut = pdate;
        }
        public DateTime getDateFin()
        {
            return this.dateFin;
        }
        public void setDateFin(DateTime pdate)
        {
            this.dateFin = pdate;
        }

        public string getVille()
        {
            return this.ville;
        }
        public void setVille(string pville)
        {
            this.ville = pville;
        }

        public string getTheme()
        {
            return this.theme;
        }
        public void setTheme(string ptheme)
        {
            this.theme = ptheme;
        }

        public string getAllInfo()
        {
            return "ID Evenement : " + this.id +
                    "\n Date debut : " + this.dateDebut +
                    "\n Date fin : " + this.dateFin +
                    "\n Ville : " + this.ville +
                    "\n Theme : " + this.theme;
        }
    }
}
