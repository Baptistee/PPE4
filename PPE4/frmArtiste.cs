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
    public partial class frmArtiste : Form
    {
        LienBDD lien = new LienBDD();
        int IdArtiste;
        DataTable dt;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmArtiste()
        {
            InitializeComponent();
        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {
            //obtient toutes les données des artistes dans la bdd
            try
            {
                dt = lien.getAllArtistes();
                this.dgvArtiste.DataSource = dt;
                this.dgvArtiste.DataMember = dt.TableName;
                this.dgvArtiste.Columns[0].Visible = false;
                this.dgvArtiste.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

            private void reloadDataGridView()
        {
            //recharge le datagrid
            try
            {
                dt = lien.getAllArtistes();
                this.dgvArtiste.DataSource = dt;
                this.dgvArtiste.DataMember = dt.TableName;
                this.dgvArtiste.Columns[0].Visible = false;
                this.dgvArtiste.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvArtiste_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Lorsque l'on clique sur une ligne (que ce soit le header, ou une autre cell)
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dgvArtiste.Rows[index];
                txtBoxArtisteNom.Text = selectedRow.Cells[1].Value.ToString();
                txtBoxArtistePrenom.Text = selectedRow.Cells[2].Value.ToString();
                txtBoxArtisteMail.Text = selectedRow.Cells[3].Value.ToString();
                txtBoxArtisteTel.Text = selectedRow.Cells[4].Value.ToString();
                if (index > 0 || index == 0)
                {
                    IdArtiste = int.Parse(selectedRow.Cells[0].Value.ToString());
                }
            }
            catch (Exception)
            {
                //Ne rien mettre Si on clique sur la dernière ligne, 
                //le programme crash sans aucune raison, mais avec le try catch, 
                //on règle ce problème. Si ca marche (si on clique sur une ligne autre que la dernière) 
                //on fait les actions sinon, on fait rien, pas besoin de fermer le programme
                
            }
            
        }

        private void btnArtisteAnnuler_Click_1(object sender, EventArgs e)
        {
            //Annuler permet de rendre toutes les textboxs vide
            txtBoxArtisteNom.Text = String.Empty;
            txtBoxArtistePrenom.Text = String.Empty;
            txtBoxArtisteMail.Text = String.Empty;
            txtBoxArtisteTel.Text = String.Empty;
        }

        private void btnArtisteCree_Click(object sender, EventArgs e)
        {
        //Si la requete ne renvoie pas d'erreur, l'artiste est créée et un message de succèes apparait, sinon un message d'erreur apparait
            if (lien.createOneArtiste(txtBoxArtisteNom.Text, txtBoxArtistePrenom.Text, txtBoxArtisteMail.Text, txtBoxArtisteTel.Text))
            {
                lbl_Artiste_Info.ForeColor = Color.Green;
                lbl_Artiste_Info.Text = "Artiste créée avec succès !";
                txtBoxArtisteNom.Text = string.Empty;
                txtBoxArtistePrenom.Text = String.Empty;
                txtBoxArtisteMail.Text = String.Empty;
                txtBoxArtisteTel.Text = String.Empty;
                reloadDataGridView();
            }
            else
            {
                lbl_Artiste_Info.ForeColor = Color.Red;
                lbl_Artiste_Info.Text = "Problème ! Impossible de créer l'artiste !";
            }
        }

        private void btnArtisteModif_Click(object sender, EventArgs e)
        {
        //L'artiste est modifiée avec les données comprisent dans les textboxs et un message de succès apparait, sinon un message d'erreur apparait 
            if (lien.updateOneArtiste(IdArtiste, txtBoxArtisteNom.Text, txtBoxArtistePrenom.Text, txtBoxArtisteMail.Text, txtBoxArtisteTel.Text))
            {
                reloadDataGridView();
                lbl_Artiste_Info.ForeColor = Color.Green;
                lbl_Artiste_Info.Text = "Artiste modifiée !";
            }
            else
            {
                lbl_Artiste_Info.Text = "Erreur !";
                lbl_Artiste_Info.ForeColor = Color.Red;
            }
        }

        private void btnArtisteSup_Click(object sender, EventArgs e)
        {
            //On récupère l'id de la ligne sélectionner, et on supprime la ligne de la bdd et on recharge le datagrid
            if (lien.deleteArtiste(IdArtiste))
            {
                reloadDataGridView();
                lbl_Artiste_Info.ForeColor = Color.Green;
                lbl_Artiste_Info.Text = "Artiste supprimé !";
            }
            else
            {
                lbl_Artiste_Info.Text = "Erreur !";
                lbl_Artiste_Info.ForeColor = Color.Red;
            }
        }

        private void dgvArtiste_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            //Lorsque l'on clique sur une ligne (que ce soit le header, ou une autre cell)
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dgvArtiste.Rows[index];
                txtBoxArtisteNom.Text = selectedRow.Cells[1].Value.ToString();
                txtBoxArtistePrenom.Text = selectedRow.Cells[2].Value.ToString();
                txtBoxArtisteMail.Text = selectedRow.Cells[3].Value.ToString();
                txtBoxArtisteTel.Text = selectedRow.Cells[4].Value.ToString();
                if (index > 0 || index == 0)
                {
                    IdArtiste = int.Parse(selectedRow.Cells[0].Value.ToString());
                }
            }
            catch (Exception)
            {
                //Ne rien mettre Si on clique sur la dernière ligne, 
                //le programme crash sans aucune raison, mais avec le try catch, 
                //on règle ce problème. Si ca marche (si on clique sur une ligne autre que la dernière) 
                //on fait les actions sinon, on fait rien, pas besoin de fermer le programme

            }
        }

        private void btnArtisteDetails_Click(object sender, EventArgs e)
        {
            frmDetailsArtiste formDetailsArtiste = new frmDetailsArtiste();
            formDetailsArtiste.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
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

