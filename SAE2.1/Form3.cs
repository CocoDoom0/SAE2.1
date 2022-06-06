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
            cboChargement();
            cboChoixTrajet.Items.Add("Aller");
            cboChoixTrajet.Items.Add("Retour");
            cboChoixTrajet.Items.Add("Aller Jour Spécial");
            cboChoixTrajet.Items.Add("Retour Jour Spécial");

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
            if(cboChoixLigneAff.SelectedIndex!=-1 && cboChoixTrajet.SelectedIndex != -1)
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
            //
            tableLayoutPanelTout.Visible = false;
            tableLayoutPanelTout.Controls.Clear();
            tableLayoutPanelTout.RowStyles.Clear();
            //
            List<Table> lesTables = new List<Table>();
            lesTables = BDD.GetLigne(cboChoixLigneAff.SelectedIndex + 1, cboChoixTrajet.SelectedIndex + 1);
            //
            int ligne = 1;
            //
            foreach (Table t in lesTables)
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
            foreach(Delais d in lesDelais)
            {
                lblHoraireDepartTout.Text = "Horaire de début: " + d.Horairedepart;
                lblDelaiPassageTout.Text = "Delai entre depart: " + d.Delaispassage;
                lblDernierPassageTout.Text = "Horaire de fin: " + d.Delaispassage;
            }
            //
            tableLayoutPanelTout.Visible = true;
        }
    }
}
