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
    public partial class frmRecherche : Form
    {
        public frmRecherche()
        {
            InitializeComponent();
        }

        private void ClickRetour(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRecherche_FormClosed(object sender, FormClosedEventArgs e)
        {
            BDD.FermerConnexion();
        }

        private void frmRecherche_Load(object sender, EventArgs e)
        {
            bool retour = BDD.InitConnexion();

            if (!retour)
            {
                MessageBox.Show("Veuillez rétablir la connexion réseau puis relancer le logiciel", "Echec de connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }


            cboChargement();
            List<Arret> lesArrets;
            lesArrets = BDD.GetArret();
            foreach (Arret t in lesArrets)
            {
                cboChoixArretArr.Items.Add(t.nomArret.ToString());
                cboChoixArretDep.Items.Add(t.nomArret.ToString());
            }
        }

        private void cboChargement()
        {
            List<Table> lesTables;
            lesTables = BDD.GetNomLigne();
            foreach (Table t in lesTables)
            {
                cboChoixLigne.Items.Add(t.nomLigne.ToString());
            }

        }
        private void cmdRechercher_Click(object sender, EventArgs e)
        {


            List<Table> lesTables = new List<Table>();
            lesTables = BDD.RechercheArret(cboChoixLigne.SelectedIndex + 1,cboChoixArretDep.SelectedIndex + 1, cboChoixArretArr.SelectedIndex + 1);
            //
            int ligne = 1;
            //
            foreach (Table t in lesTables)
            {
                AjoutLabelRecherche(t.numArret.ToString(), ligne, 0);
                AjoutLabelRecherche(t.nomArret, ligne, 1);
                AjoutLabelRecherche(t.ordrePassage.ToString(), ligne, 2);
                ligne++;
            }

        }
        private void AjoutLabelRecherche(string val, int colonne, int ligne)
        {
            Label lbl = new Label();
            lbl.AutoSize = false;
            lbl.Size = lblArretDep.Size;
            lbl.Text = val;
            tableLayoutPanelRecherche.Controls.Add(lbl, ligne, colonne);
        }

        private void cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboChoixArretArr.SelectedIndex!=-1 && cboChoixArretDep.SelectedIndex != -1 && cboChoixLigne.SelectedIndex != -1)
            {
                cmdRechercher.Enabled = true;
            }
            else
            {
                cmdRechercher.Enabled = false;
            }
        }
    }
}
