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
    public partial class FrmCampagne : Form
    {
        public FrmCampagne()
        {
            InitializeComponent();
        }

        internal LienBDD connexion;
        private DataTable dt;
        private DataTable dt2;
        private int selectedRow = 0;


        //initialisation du lien avec la bdd
        private void FrmCampagne_Load(object sender, EventArgs e)
        {
            connexion = new LienBDD() ;

            this.ActualiserTableaux(this.connexion.GetCampagne());

            dt = this.connexion.GetAgenceCommunication();
            dt2 = this.connexion.GetAgenceArtistique();
            this.fCamp_cbAgence1.DataSource = dt;
            this.fCamp_cbAgence2.DataSource = dt2;
            this.fCamp_cbAgence1.DisplayMember = "NOM";
            this.fCamp_cbAgence2.DisplayMember = "NOM";
            this.fCamp_cbAgence1.ValueMember = "IDAGENCE";
            this.fCamp_cbAgence2.ValueMember = "IDAGENCE";

            dt = this.connexion.GetResponsable();
            this.fCamp_cbResponsable.DataSource = dt;
            this.fCamp_cbResponsable.DisplayMember = "Responsable";
            this.fCamp_cbResponsable.ValueMember = "IDEMPLOYE";

            this.ReinitialiserGroupBox(this.fCamp_GrpBox);
            
        }

        //methode normal
        private void ActualiserTableaux(DataTable dt)
        {
            try
            {
                this.fCamp_DgCampagne.DataSource = dt;
                this.fCamp_DgCampagne.DataMember = dt.TableName;
                this.fCamp_DgCampagne.Columns[0].Visible = false;
                this.fCamp_DgCampagne.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReinitialiserGroupBox(GroupBox grBox)
        {
            foreach (Control ctrl in grBox.Controls)
            {
                if (ctrl is TextBox)
                {

                    TextBox textBox = (TextBox)ctrl;

                    textBox.ResetText();

                }

                if (ctrl is ComboBox)
                {

                    ComboBox comboBox = (ComboBox)ctrl;

                    comboBox.ResetText();

                }

                if (ctrl is DateTimePicker)
                {
                    DateTimePicker dateTime = (DateTimePicker)ctrl;

                    dateTime.ResetText();
                }
                if (ctrl is CheckBox)
                {
                    CheckBox checkbox = (CheckBox)ctrl;

                    checkbox.Checked = false;
                }
            }
        }

        //methode bouton

        //Ajout de campagne
        private void fCamp_BtAnnuler_Click(object sender, EventArgs e)
        {
            this.ReinitialiserGroupBox(this.fCamp_GrpBox);
        }

        private void fCamp_BtValider_Click(object sender, EventArgs e)
        {
            
            //recuperation du formulaire
            string nom = fCamp_tbNom.Text;
            string objectif = fCamp_tbObjectif.Text;
            string publique = fCamp_tbPublique.Text;
            DateTime datedebut = fCamp_dtDateDebut.Value;
            DateTime datefin = fCamp_dtDateFin.Value;

            string responsable;
            string agence1;
            string agence2;

            if (fCamp_checkBoxAgence1.Checked == true)
            {
                agence1 = fCamp_cbAgence1.SelectedValue.ToString();
            }
            else
            {
                agence1 = null;
            }

            if (fCamp_checkBoxAgence2.Checked == true)
            {
                agence2 = fCamp_cbAgence2.SelectedValue.ToString();
            }
            else
            {
                agence2 = null;
            }
          
            responsable = fCamp_cbResponsable.SelectedValue.ToString();



            if (nom == "" || objectif == "" || publique == "")
            {
                System.Windows.Forms.MessageBox.Show("Veuillez remplir tout les champs !");
            }
            else
            {
                if (DateTime.Compare(datedebut, datefin) <= 0)
                {

                    if (connexion.AjouterCampagne(nom, objectif, publique, datedebut.ToString(), datefin.ToString(), responsable, agence1, agence2))
                    {
                        System.Windows.Forms.MessageBox.Show("Ajout réussi !");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Echec !");
                    }

                    this.ActualiserTableaux(this.connexion.GetCampagne());
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Date de debut superieur à celle de fin !");
                }
            }
        }

        //suppression d'une campagne
        private void fCamp_BtSupprimer_Click(object sender, EventArgs e)
        {            
            if (connexion.DeleteCampagne(selectedRow))
            {
                System.Windows.Forms.MessageBox.Show("Message supprimé avec succés!");
                this.ActualiserTableaux(this.connexion.GetCampagne());
                this.ReinitialiserGroupBox(this.fCamp_GrpBox);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Échec de la suppréssion du message");    
        }
        }

        private void fCamp_DgCampagne_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                selectedRow = Convert.ToInt32(fCamp_DgCampagne.Rows[e.RowIndex].Cells[0].Value.ToString());

                fCamp_tbNom.Text = fCamp_DgCampagne.Rows[e.RowIndex].Cells[1].Value.ToString();
                fCamp_tbObjectif.Text = fCamp_DgCampagne.Rows[e.RowIndex].Cells[2].Value.ToString();
                fCamp_tbPublique.Text = fCamp_DgCampagne.Rows[e.RowIndex].Cells[3].Value.ToString();
                fCamp_dtDateDebut.Value = DateTime.Parse(fCamp_DgCampagne.Rows[e.RowIndex].Cells[6].Value.ToString());
                fCamp_dtDateFin.Value = DateTime.Parse(fCamp_DgCampagne.Rows[e.RowIndex].Cells[7].Value.ToString());

                fCamp_cbResponsable.Text = fCamp_DgCampagne.Rows[e.RowIndex].Cells[8].Value.ToString();

                fCamp_checkBoxAgence1.Checked = true;
                string agence1 = fCamp_DgCampagne.Rows[e.RowIndex].Cells[4].Value.ToString();

                if (agence1 != "")
                {
                    fCamp_cbAgence1.Text = agence1;
                    fCamp_cbAgence1.ValueMember = this.connexion.GetAgenceId(fCamp_DgCampagne.Rows[e.RowIndex].Cells[4].Value.ToString());                   
                }
                else
                {
                    fCamp_checkBoxAgence1.Checked = false;
                }


                fCamp_checkBoxAgence2.Checked = true;
                string agence2 = fCamp_DgCampagne.Rows[e.RowIndex].Cells[5].Value.ToString();

                if (agence2 != "")
                {
                    fCamp_cbAgence2.Text = agence2;
                    fCamp_cbAgence2.ValueMember = this.connexion.GetAgenceId(fCamp_DgCampagne.Rows[e.RowIndex].Cells[5].Value.ToString());

                }
                else
                {
                    fCamp_checkBoxAgence2.Checked = false;
                }
                
                
                

            }
            catch (Exception)
            {

            }
             


        }

        private void fCamp_BtModifier_Click(object sender, EventArgs e)
        {
            

            //recuperation du formulaire
            string nom = fCamp_tbNom.Text;
            string objectif = fCamp_tbObjectif.Text;
            string publique = fCamp_tbPublique.Text;
            DateTime datedebut = fCamp_dtDateDebut.Value;
            DateTime datefin = fCamp_dtDateFin.Value;
            string responsable = fCamp_cbResponsable.SelectedValue.ToString();
            int id = selectedRow;

            string agence1;
            string agence2;

            if (fCamp_checkBoxAgence1.Checked == true)
            {
                agence1 = fCamp_cbAgence1.SelectedValue.ToString();
            }
            else
            {
                agence1 = null;
            }

            if (fCamp_checkBoxAgence2.Checked == true)
            {
                agence2 = fCamp_cbAgence2.SelectedValue.ToString();
            }
            else
            {
                agence2 = null;
            }

            if (nom == "" || objectif == "" || responsable == "" || publique == "")
            {
                System.Windows.Forms.MessageBox.Show("Veuillez remplir tout les champs !");
            }
            else
            {
                if (DateTime.Compare(datedebut, datefin) <= 0)
                {

                    if (connexion.ModifierCampagne(id, nom, objectif, publique, datedebut.ToString(), datefin.ToString(), responsable, agence1, agence2))
                    { 
                        System.Windows.Forms.MessageBox.Show("Modification réussi !");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Echec !");
                    }

                    this.ActualiserTableaux(this.connexion.GetCampagne());
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Date de debut superieur à celle de fin !");
                }
            }
        }

        private void fCamp_checkBoxAgence1_CheckedChanged(object sender, EventArgs e)
        {
            if (fCamp_checkBoxAgence1.Checked == true)
            {
                fCamp_cbAgence1.Enabled = true;
            }
            else
            {
                fCamp_cbAgence1.Enabled = false;
            }
        }

        private void fCamp_checkBoxAgence2_CheckedChanged(object sender, EventArgs e)
        {
            if (fCamp_checkBoxAgence2.Checked == true)
            {
                fCamp_cbAgence2.Enabled = true;
            }
            else
            {
                fCamp_cbAgence2.Enabled = false;
            }
        }





        

        

        
    }
}
