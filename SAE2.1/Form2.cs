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
                MessageBox.Show("Veuillez rétablir la connexion réseau puis relancer le logiciel", "Echec de connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            grpPreAjouter.Visible = true;
            cmdAjouter.Enabled= false;
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
                    AjoutArret(txtbNvlLigne.Text,(string)cboTypeTrajetAjout.SelectedItem);
                }
            }
            else
            {
                List<Table> lesTables;

                lesTables = BDD.CheckPassage(cboLigneExistante.SelectedIndex+1, cboTypeTrajetAjout.SelectedIndex+1);
                int nbpassage = 0;
                foreach (Table t in lesTables)
                {
                    nbpassage++;
                }
                if (nbpassage != 0)
                {
                    MessageBox.Show("Cette ligne à déjà des passage, merci de la supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    AjoutArret((string)cboLigneExistante.SelectedItem,(string)cboTypeTrajetAjout.SelectedItem);
                }
            }
        }

        private void AjoutArret(string ligne,string trajet)
        {
            string[] subs = ligne.Split(' ');
            string nomLigne=String.Empty;
            foreach (var sub in subs)
            {
                if (sub.ToUpper() != "LIGNE")
                {
                    nomLigne = nomLigne+sub+" ";
                }
            }
            lblResumerAjout.Text = $"Ajout pour la ligne {nomLigne}en {trajet}";
            grpPreAjouter.Visible = false;
            grpAjouter.Visible = true;
            List<Arret> arrets;
            arrets = BDD.GetArret();
            foreach (Arret arret in arrets)
            {
                cboChoixArret1.Items.Add(arret.nomArret);
                cboNArretSave.Items.Add(arret.numArret);
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

        private void cmdAnnuler_Click(object sender, EventArgs e)
        {
            grpAjouter.Visible = false;
            grpPreAjouter.Visible = false;
            cmdAjouter.Enabled = true;
            cmdModif.Enabled = true;
            cmdSupp.Enabled = true;
            cboChoixLigneModif.Enabled = true;
            cboChoixTrajet.Enabled = true;
            cboChoixLigneModif_SelectedIndexChanged(0, e);
        }

        private void cboChoixArret_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void clickRetour(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if(cboChoixArret1.SelectedIndex==-1 || String.IsNullOrEmpty(txtbChoixDelai1.Text) == true)
            {
                MessageBox.Show("Merci de remplir les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else{
                tableLayoutPanel2.Visible = false;
                cmdRemove.Enabled = true; 
                
                Label lbl = new Label();
                lbl.AutoSize = false;
                lbl.Size = lblSetTaille0.Size;
                lbl.Text = (string)cboChoixArret1.SelectedItem;
                tableLayoutPanel2.Controls.Add(lbl, 0, Convert.ToInt32(lblIndex.Text));
                cboSaveNomArret.Items.Add(cboChoixArret1.SelectedItem);
                cboSaveNumArret.Items.Add(cboNArretSave.Items[cboChoixArret1.SelectedIndex]);

                Label lbl2 = new Label();
                lbl2.AutoSize = false;
                lbl2.Size = lblSetTaille1.Size;
                lbl2.Text = txtbChoixDelai1.Text;
                cboSaveDelai.Items.Add(txtbChoixDelai1.Text);
                tableLayoutPanel2.Controls.Add(lbl2, 1, Convert.ToInt32(lblIndex.Text));

                Label lbl3 = new Label();
                lbl3.AutoSize = false;
                lbl3.Size = lblSetTaille2.Size;
                lbl3.Text = Convert.ToString(Convert.ToInt32(lblIndex.Text) + 1);
                tableLayoutPanel2.Controls.Add(lbl3, 2, Convert.ToInt32(lblIndex.Text));
                lblIndex.Text = Convert.ToString(Convert.ToInt32(lblIndex.Text) + 1);
                tableLayoutPanel2.Visible = true;
                cmdValiderAjt.Enabled = true;
            }

        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Visible = false;
            lblIndex.Text = Convert.ToString(Convert.ToInt32(lblIndex.Text) - 1);
            cboSaveDelai.Items.RemoveAt(Convert.ToInt32(lblIndex.Text));
            cboSaveNomArret.Items.RemoveAt(Convert.ToInt32(lblIndex.Text));
            cboSaveNumArret.Items.RemoveAt(Convert.ToInt32(lblIndex.Text));
            tableLayoutPanel2.Controls.Clear();
            for(int i = 0; i < Convert.ToInt32(lblIndex.Text) ; i++)
            {
                Label lbl1 = new Label();
                lbl1.AutoSize = false;
                lbl1.Size = lblSetTaille0.Size;
                lbl1.Text = (string)cboSaveNomArret.Items[i];
                tableLayoutPanel2.Controls.Add(lbl1);

                Label lbl2 = new Label();
                lbl2.AutoSize = false;
                lbl2.Size = lblSetTaille1.Size;
                lbl2.Text = (string)cboSaveDelai.Items[i];
                tableLayoutPanel2.Controls.Add(lbl2);

                Label lbl3 = new Label();
                lbl3.AutoSize = false;
                lbl3.Size = lblSetTaille2.Size;
                lbl3.Text = Convert.ToString(i+1);
                tableLayoutPanel2.Controls.Add(lbl3);
            }
            if (Convert.ToInt32(lblIndex.Text) == 0)
            {
                cmdRemove.Enabled = false;
                cmdValiderAjt.Enabled = false;
            }
            tableLayoutPanel2.Visible = true;
        }

        private void cmdValiderAjout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez vous vraiment ajouter cette ligne ?", "Ajout", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                for (int i = 0; i < Convert.ToInt32(lblIndex.Text); i++)
                {
                    string emplacement = string.Empty;
                    for (int j = 0; j < cboChoixArret1.Items.Count; j++)
                    {
                        MessageBox.Show($"{cboChoixArret1.GetItemText(j+1)}");
                    }
                    //MessageBox.Show($"{cboLigneExistante.SelectedIndex+1},{cboTypeTrajetAjout.SelectedIndex+1}, {Convert.ToInt32(cboNArretSave.GetItemText(Convert.ToInt32(emplacement)))},{Convert.ToString(tableLayoutPanel2.GetControlFromPosition(2, i))},{i}", "Erreur de suppresion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //BDD.AddLigne(cboLigneExistante.SelectedIndex+1,cboTypeTrajetAjout.SelectedIndex+1, Convert.ToInt32(cboNArretSave.GetItemText(Convert.ToInt32(emplacement))),Convert.ToString(tableLayoutPanel2.GetControlFromPosition(2, i)),i);
                }
            }
        }
    }

}
