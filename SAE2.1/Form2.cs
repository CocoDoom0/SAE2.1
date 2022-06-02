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
        bool debug = false;
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
            cboChoixTrajet.Items.Add("Aller");
            cboChoixTrajet.Items.Add("Retour");
            cboChoixTrajet.Items.Add("Aller Jour Spécial");
            cboChoixTrajet.Items.Add("Retour Jour Spécial");
            cboTypeTrajetAjout.Items.Add("Aller");
            cboTypeTrajetAjout.Items.Add("Retour");
            cboTypeTrajetAjout.Items.Add("Aller Jour Spécial");
            cboTypeTrajetAjout.Items.Add("Retour Jour Spécial");

        }

        private void cboChargement() 
        {
            List<Table> lesTables;
            lesTables = BDD.GetNomLigne();
            foreach (Table t in lesTables)
            {
                cboChoixLigneModif.Items.Add(t.nomLigne.ToString());
                cboLigneExistante.Items.Add(t.nomLigne.ToString());
            }
        }

        private void ChangeVisible(bool Visible)
        {

            tableLayoutPanel1.Visible = Visible;
            lblHoraire.Visible = Visible;
            lblNArret.Visible = Visible;
            lblNomArret.Visible = Visible;
            lblOrdre.Visible = Visible;
            //cmdAjouter.Enabled = Visible;
            cmdModif.Enabled = Visible;
            cmdSupp.Enabled = Visible;
        }

        private void AjoutLabel(string val, int colonne, int ligne)
        {
            Label lbl = new Label();
            lbl.AutoSize = false;
            lbl.Size = lblChoixLigne.Size;
            //lbl.Font = new Font(FontFamily.GenericSansSerif, 9, FontStyle.Regular);
            //lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Text = val;
            tableLayoutPanel1.Controls.Add(lbl, ligne, colonne);
        }

        private void frmModification_FormClosed(object sender, FormClosedEventArgs e)
        {
            BDD.FermerConnexion();
        }

        private void cboChoixLigneModif_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChoixTrajet.SelectedIndex != -1 && cboChoixLigneModif.SelectedIndex != -1)
            {
                ChangeVisible(false);
                tableLayoutPanel1.Controls.Clear();
                tableLayoutPanel1.RowStyles.Clear();
                List<Table> lesTables;
                //lblChoixLigne.Text = Convert.ToString(cboChoixTrajet.SelectedIndex); 
                lesTables = BDD.GetLigne(cboChoixLigneModif.SelectedIndex + 1, cboChoixTrajet.SelectedIndex + 1);
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
                ChangeVisible(true);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdModif_Click(object sender, EventArgs e)
        {

        }

        private void cmdSupp_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Voulez vous vraiment supprimer la {cboChoixLigneModif.SelectedItem} en {cboChoixTrajet.SelectedItem}","Suppresion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int resultat = BDD.SuppLigne(cboChoixLigneModif.SelectedIndex + 1, cboChoixTrajet.SelectedIndex + 1);
                ChangeVisible(false);
                tableLayoutPanel1.Controls.Clear();
                tableLayoutPanel1.RowStyles.Clear();
                if (resultat == -1)
                {
                    MessageBox.Show("La ligne n'a pas pu etre supprimer", "Erreur de suppresion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void cmdAjouter_Click(object sender, EventArgs e)
        {
            ChangeVisible(false);
            cboChoixLigneModif.Enabled = false;
            cboChoixTrajet.Enabled = false;
            grpAjouter1.Visible = true;
            cmdAjouter.Enabled= false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            grpAjouter1.Visible = false;
            cmdAjouter.Enabled = true;
            cmdModif.Enabled = true;
            cmdSupp.Enabled = true;
            cboChoixLigneModif.Enabled = true;
            cboChoixTrajet.Enabled = true;
            cboChoixLigneModif_SelectedIndexChanged(0,e);
        }

        private void rbLigneExistante_CheckedChanged(object sender, EventArgs e)
        {
            cboLigneExistante.Enabled = true;
            txtbNvlLigne.Enabled = false;
        }

        private void rbNouvelleLigne_CheckedChanged(object sender, EventArgs e)
        {
            cboLigneExistante.Enabled = false;
            txtbNvlLigne.Enabled = true;
        }

        private void cmdValiderAjouter_Click(object sender, EventArgs e)
        {
            if ((rbLigneExistante.Checked == true && cboLigneExistante.SelectedIndex == -1) || (rbNouvelleLigne.Checked == true && (txtbNvlLigne.Text==(string)txtbNvlLigne.Tag || String.IsNullOrEmpty(txtbNvlLigne.Text) == true)))
            {
                MessageBox.Show("Merci de remplir les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else if(rbNouvelleLigne.Checked == true)
            {
                bool erreur = false;
                for(int i = 0; i < cboLigneExistante.Items.Count; i++)
                {
                    if ((cboLigneExistante.GetItemText(cboLigneExistante.Items[i]) == txtbNvlLigne.Text || cboLigneExistante.GetItemText(cboLigneExistante.Items[i]) == "Ligne " + txtbNvlLigne.Text))
                    {
                        MessageBox.Show("Merci de ne pas entrer un nouveau nom de ligne déjà existant ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        erreur = true;
                    }
                    
                }
                if (!erreur)
                {
                    MessageBox.Show("Ok", "WIP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ok", "WIP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtbNvlLigne_Enter(object sender, EventArgs e)
        {
            if(txtbNvlLigne.Text == (string)txtbNvlLigne.Tag)
            {
                txtbNvlLigne.Text = "";
            }
        }

        private void txtbNvlLigne_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtbNvlLigne.Text) == true)
            {
                txtbNvlLigne.Text=(string)txtbNvlLigne.Tag;
            }
        }
    }

}
