using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BD;

namespace SAE2._1
{
    public partial class frmAffichage : Form
    {
        bool PbConnexion = false;
        bool debug = false;

        public frmAffichage()
        {
            InitializeComponent();
        }

        private void frm_Load(object sender, EventArgs e)
        {
            // au chargement du formulaire, avant le 1er affichage
            // ouverture de la connexion avec la BD
            // si pb, fermeture de l'application

            bool retour = BDD.InitConnexion();

            if (!retour)
            {
                MessageBox.Show("Veuillez rétablir la connexion réseau puis relancer le logiciel", "Echec de connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PbConnexion = true;

                Application.Exit();
            }
            else if (debug)
            {
                MessageBox.Show("Connexion avec la base de donnée établie", "OK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            cboChargement();
            cboChoixTrajet.Items.Add("Aller");
            cboChoixTrajet.Items.Add("Retour");
            cboChoixTrajet.Items.Add("Aller Jour Spécial");
            cboChoixTrajet.Items.Add("Retour Jour Spécial");
            cboChoixAffich.Items.Add("Arrêt");
            cboChoixAffich.Items.Add("Horaire");
            cboChoixAffich.Items.Add("Tout");

        }

        private void cboChargement() 
        {
            List<Table> lesTables;
            lesTables = BDD.GetNomLigne();
            foreach (Table t in lesTables)
            {
                cboChoixLigneAff.Items.Add(t.nomLigne.ToString());
            }
        }

        private void AjoutLabelArret(string val, int colonne, int ligne)
        {
            Label lbl = new Label();
            lbl.AutoSize = false;
            lbl.Size = lblChoixLigne.Size;
            lbl.Text = val;
            tableLayoutPanelArret.Controls.Add(lbl, ligne, colonne);
        }
        private void AjoutLabelHoraire(string val, int colonne, int ligne)
        {
            Label lbl = new Label();
            lbl.AutoSize = false;
            lbl.Size = lblChoixLigne.Size;
            lbl.Text = val;
            tableLayoutPanelHoraire.Controls.Add(lbl, ligne, colonne);
        }
        private void AjoutLabelTout(string val, int colonne, int ligne)
        {
            Label lbl = new Label();
            lbl.AutoSize = false;
            lbl.Size = lblChoixLigne.Size;
            lbl.Text = val;
            tableLayoutPanelTout.Controls.Add(lbl, ligne, colonne);
        }


        private void clickRetour(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAffichage_FormClosed(object sender, FormClosedEventArgs e)
        {
            BDD.FermerConnexion();
        }

        private void cbo_SelectIndexChanged(object sender, EventArgs e)
        {
            if(cboChoixAffich.SelectedIndex!=-1 && cboChoixLigneAff.SelectedIndex!=-1 && cboChoixTrajet.SelectedIndex != -1)
            {
                cmdChargement.Enabled = true;
            }
            else
            {
                cmdChargement.Enabled = false;
            }
        }

        private void cmdChargement_Click(object sender, EventArgs e)
        {
            grpAffichArret.Visible = true;
            grpAffichHoraire.Visible = false;
            grpAffichTout.Visible = false;
            tableLayoutPanelArret.Controls.Clear();
            tableLayoutPanelArret.RowStyles.Clear();
            tableLayoutPanelHoraire.Controls.Clear();
            tableLayoutPanelHoraire.RowStyles.Clear();
            tableLayoutPanelTout.Controls.Clear();
            tableLayoutPanelTout.RowStyles.Clear();

            if (cboChoixAffich.SelectedIndex == 0)
            {
                grpAffichArret.Visible = true;
                grpAffichHoraire.Visible = false;
                grpAffichTout.Visible = false;
                //
                tableLayoutPanelArret.Visible = false;
                tableLayoutPanelArret.Controls.Clear();
                tableLayoutPanelArret.RowStyles.Clear();
                //
                List<Table> lesTables;
                lesTables = BDD.GetLigne(cboChoixLigneAff.SelectedIndex + 1, cboChoixTrajet.SelectedIndex + 1);
                //
                int ligne = 1;
                //
                foreach (Table t in lesTables)
                {
                    AjoutLabelArret(t.numArret.ToString(), ligne, 0);
                    AjoutLabelArret(t.nomArret, ligne, 1);
                    AjoutLabelArret(t.ordrePassage.ToString(), ligne, 2);
                    ligne++;
                }
                //
                AjoutLabelArret(" ", ligne, 0);
                AjoutLabelArret(" ", ligne, 1);
                AjoutLabelArret(" ", ligne, 2);
                //
                tableLayoutPanelArret.Visible = true;
            }
            else if(cboChoixAffich.SelectedIndex == 1)
            {
                grpAffichArret.Visible = false;
                grpAffichHoraire.Visible = true;
                grpAffichTout.Visible = false;
                //
                tableLayoutPanelHoraire.Visible = false;
                tableLayoutPanelHoraire.Controls.Clear();
                tableLayoutPanelHoraire.RowStyles.Clear();
                //
                List<Table> lesTables1;
                lesTables1 = BDD.GetLigne(cboChoixLigneAff.SelectedIndex + 1, cboChoixTrajet.SelectedIndex + 1);
                //
                int ligne = 1;
                //
                foreach (Table t in lesTables1)
                {
                    AjoutLabelHoraire(t.ordrePassage.ToString(), ligne, 0);
                    AjoutLabelHoraire(t.Horaire, ligne, 1);
                    ligne++;
                }
                //
                AjoutLabelHoraire(" ", ligne, 0);
                AjoutLabelHoraire(" ", ligne, 1);
                //
                List<Delais> lesDelais;
                lesDelais = BDD.GetDelais(cboChoixLigneAff.SelectedIndex + 1, cboChoixTrajet.SelectedIndex + 1);
                //
                foreach (Delais d in lesDelais)
                {
                    MessageBox.Show($"{d.Horairedepart}");
                    lblHoraireDepartHoraire.Text = "Horaire de depart : " + d.Horairedepart;
                    lblDelaiPassageHoraire.Text = "Delai entre passage : " + d.Delaispassage;
                    lblDenierePassageHoraire.Text = "Dernier passage : " + d.Dernierpassage;
                }
                //
                tableLayoutPanelHoraire.Visible = true;
            }
            else if(cboChoixAffich.SelectedIndex == 2)
            {
                grpAffichArret.Visible = false;
                grpAffichHoraire.Visible = false;
                grpAffichTout.Visible = true;
                //
                tableLayoutPanelTout.Visible = false;
                tableLayoutPanelTout.Controls.Clear();
                tableLayoutPanelTout.RowStyles.Clear();
                //
                List<Table> lesTables2;
                lesTables2 = BDD.GetLigne(cboChoixLigneAff.SelectedIndex + 1, cboChoixTrajet.SelectedIndex + 1);
                //
                int ligne = 1;
                //
                foreach (Table t in lesTables2)
                {
                    AjoutLabelTout(t.numArret.ToString(), ligne, 0);
                    AjoutLabelTout(t.nomArret, ligne, 1);
                    AjoutLabelTout(t.Horaire, ligne, 2);
                    AjoutLabelTout(t.ordrePassage.ToString(), ligne, 3);
                    ligne++;
                }
                //
                AjoutLabelTout(" ", ligne, 0);
                AjoutLabelTout(" ", ligne, 1);
                AjoutLabelTout(" ", ligne, 2);
                AjoutLabelTout(" ", ligne, 3);
                //
                List<Delais> lesDelais;
                lesDelais = BDD.GetDelais(cboChoixLigneAff.SelectedIndex + 1, cboChoixTrajet.SelectedIndex + 1);
                //
                foreach (Delais d in lesDelais)
                {
                    lblHoraireDepartTout.Text = "Horaire de depart : " + d.Horairedepart;
                    lblDelaiPassageTout.Text = "Delai entre passage : " + d.Delaispassage;
                    lblDernierPassageTout.Text = "Dernier passage : " + d.Dernierpassage;
                }
                //
                tableLayoutPanelTout.Visible = true;
            }
        }
    }
}
