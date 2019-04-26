﻿using System;
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
            string agence1 = fCamp_cbAgence1.SelectedValue.ToString();
            string agence2 = fCamp_cbAgence2.SelectedValue.ToString();
            string responsable = fCamp_cbResponsable.SelectedValue.ToString();

            if (nom == "" || objectif == "" || responsable == "" || publique == "")
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

                fCamp_cbAgence2.Text = fCamp_DgCampagne.Rows[e.RowIndex].Cells[5].Value.ToString();
                fCamp_cbAgence1.Text = fCamp_DgCampagne.Rows[e.RowIndex].Cells[4].Value.ToString();
                fCamp_cbResponsable.Text = fCamp_DgCampagne.Rows[e.RowIndex].Cells[8].Value.ToString();
                                
                fCamp_cbAgence1.ValueMember = this.connexion.GetAgenceId(fCamp_DgCampagne.Rows[e.RowIndex].Cells[4].Value.ToString());
                fCamp_cbAgence2.ValueMember = this.connexion.GetAgenceId(fCamp_DgCampagne.Rows[e.RowIndex].Cells[5].Value.ToString());
                

                
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
            string agence1 = fCamp_cbAgence1.SelectedValue.ToString();
            string agence2 = fCamp_cbAgence2.SelectedValue.ToString();
            string responsable = fCamp_cbResponsable.SelectedValue.ToString();
            int id = selectedRow;

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





        

        

        
    }
}