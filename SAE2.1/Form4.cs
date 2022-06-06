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
            List<Arret> lesArrets;
            lesArrets = BDD.GetArret();
            foreach (Arret t in lesArrets)
            {
                cboChoixArretArr.Items.Add(t.nomArret.ToString());
                cboChoixArretDep.Items.Add(t.nomArret.ToString());
            }
        }

        private void cmdRechercher_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La recherche d'itinéraire n'est pas terminer.");
        }

        private void cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboChoixArretArr.SelectedIndex!=-1 && cboChoixArretDep.SelectedIndex != -1)
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
