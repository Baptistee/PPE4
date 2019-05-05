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
        string info;
        DataTable dt;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public frmDetailsArtiste()
        {
            InitializeComponent();
        }

        private void frmDetailsArtiste_Load(object sender, EventArgs e)
        {
            //On charge DataTables avec tout les artistes
            dt = lien.getAllArtistes();
            dt.Columns.Add("FullName");
            //Pour chaque ligne de la DataTable on rajoute un Objet dans la liste déroulante
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmBoxSelectArtiste.Items.Add(dt.Rows[i]["idartiste"]);
                cmBoxSelectArtiste.DisplayMember = (dt.Rows[i]["nom"]).ToString();
            }
        }

        private void cmBoxSelectArtiste_SelectedIndexChanged(object sender, EventArgs e)
        {
            //obtient toutes les données des artistes dans la bdd
            try
            {
                dt = lien.getDetailsOneArtiste(int.Parse(cmBoxSelectArtiste.SelectedItem.ToString()));
                this.dgvDetailsArtiste.DataSource = dt;
                this.dgvDetailsArtiste.DataMember = dt.TableName;
                this.dgvDetailsArtiste.Columns[0].Visible = false;
                this.dgvDetailsArtiste.Columns[1].Visible = false;
                this.dgvDetailsArtiste.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
        
    }
}
