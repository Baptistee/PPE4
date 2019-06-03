using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE4
{
    public partial class FrmStatistiques : Form
    {
        public FrmStatistiques()
        {
            InitializeComponent();
        }

        internal LienBDD connexion;
        private DataTable dt;

        private void FrmStatistiques_Load(object sender, EventArgs e)
        {
            connexion = new LienBDD();

            dt = this.connexion.GetAnneCampagne();

            this.fStat_cbSat1.DataSource = dt;
            this.fStat_cbSat1.ValueMember = "Annee";
            this.fStat_cbSat1.DisplayMember = "Annee";

            

            this.ActualiserTableaux(dt);
        }

        private void fStat_btnRechercher_Click(object sender, EventArgs e)
        {
            if (this.fStat_rBtnStat1.Checked)
            {
                dt = this.connexion.GetNbrEvenmentParCampagnePourUneAnnee(int.Parse(this.fStat_cbSat1.SelectedValue.ToString()));
                this.ActualiserTableaux(dt);
            }
            else
            {

            }
        }

        private void ActualiserTableaux(DataTable dt)
        {
            try
            {
                this.fStat_dgStat.DataSource = dt;
                this.fStat_dgStat.DataMember = dt.TableName;
                //this.fStat_dgStat.Columns[0].Visible = false;
                this.fStat_dgStat.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
