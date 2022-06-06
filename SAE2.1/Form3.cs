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

        private void AjoutLabel(string val, int colonne, int ligne)
        {
            Label lbl = new Label();
            lbl.AutoSize = false;
            lbl.Size = lblChoixLigne.Size;
            lbl.Text = val;
            tableLayoutPanel1.Controls.Add(lbl, ligne, colonne);
        }

        private void cboChoixLigneAff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChoixTrajet.SelectedIndex != -1 && cboChoixLigneAff.SelectedIndex != -1)
            {
                tableLayoutPanel1.Visible = false;
                tableLayoutPanel1.Controls.Clear();
                tableLayoutPanel1.RowStyles.Clear();
                List<Table> lesTables;
                lesTables = BDD.GetLigne(cboChoixLigneAff.SelectedIndex + 1, cboChoixTrajet.SelectedIndex + 1);
                int ligne = 1;
                foreach (Table t in lesTables)
                {
                    AjoutLabel(t.numArret.ToString(), ligne, 0);
                    AjoutLabel(t.nomArret, ligne, 1);
                    AjoutLabel(t.Horaire, ligne, 2);
                    AjoutLabel(t.ordrePassage.ToString(), ligne, 3);
                    ligne++;
                }
                AjoutLabel(" ", ligne, 0);
                AjoutLabel(" ", ligne, 1);
                AjoutLabel(" ", ligne, 2);
                AjoutLabel(" ", ligne, 3);
                tableLayoutPanel1.Visible = true;
            }
        }



        private void clickRetour(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAffichage_FormClosed(object sender, FormClosedEventArgs e)
        {
            BDD.FermerConnexion();
        }
    }
}
