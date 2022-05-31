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
    public partial class frmModification : Form
    {
        bool PbConnexion = false;
        bool debug = true;
        public frmModification()
        {
            InitializeComponent();
        }

        private void frmModification_Load(object sender, EventArgs e)
        {
            // au chargement du formulaire, avant le 1er affichage
            // ouverture de la connexion avec la BD
            // si pb, fermeture de l'application

            bool retour = BDD.InitConnexion();

            if (!retour)
            {
                MessageBox.Show("Veuillez rétablir la connexion réseau puis relancer le jeu", "Echec de connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PbConnexion = true;

                Application.Exit();
            }
            else if(debug)
            {
                MessageBox.Show("Connexion avec la base de donnée établie","OK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            cboChargement();

        }

        private void cboChargement() 
        {
            List<Table> lesTables;
            lesTables = BDD.GetNomLigne();
            foreach (Table t in lesTables)
            {
                cboChoixLigneModif.Items.Add(t.nomLigne.ToString());
            }
        }

        private void ChangeVisible(bool Visible)
        {

            tableLayoutPanel1.Visible = Visible;
            lblChoixLigne.Visible = Visible;
            lblHoraire.Visible = Visible;
            lblNArret.Visible = Visible;
            lblNomArret.Visible = Visible;
            lblOrdre.Visible = Visible;
        }


        private void frmModification_FormClosed(object sender, FormClosedEventArgs e)
        {
            BDD.FermerConnexion();
        }

        private void cboChoixLigneModif_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeVisible(true);
        }
    }

}
