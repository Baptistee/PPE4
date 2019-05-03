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
    public partial class frmDetailsArtiste : Form
    {
        LienBDD lien = new LienBDD();
        int IdArtiste;
        DataTable dt;
        public frmDetailsArtiste()
        {
            InitializeComponent();
        }

        private void dgvDetailsArtiste_Enter(object sender, EventArgs e)
        {
            //obtient toutes les données des artistes dans la bdd
            try
            {
                dt = lien.getDetailsOneArtiste(IdArtiste);
                this.dgvDetailsArtiste.DataSource = dt;
                this.dgvDetailsArtiste.DataMember = dt.TableName;
                this.dgvDetailsArtiste.Columns[0].Visible = false;
                this.dgvDetailsArtiste.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
