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
                // Message d'erreur si la connexion est impossible
                MessageBox.Show("Veuillez rétablir la connexion réseau puis relancer le logiciel", "Echec de connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PbConnexion = true;

                //Ferme la page
                Application.Exit();
            }

            //Charge les Items de la BD
            cboChargement();

            //Ajout les type de Trajet dans les combobox dédiers
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
            //Obtient les Items de la BD
            lesTables = BDD.GetNomLigne();
            foreach (Table t in lesTables)
            {
                //Pour chaque Items, inserer dans les combobox dédiers
                cboChoixLigneModif.Items.Add(t.nomLigne.ToString());
                cboLigneExistante.Items.Add(t.nomLigne.ToString());
            }
        }

        private void ChangeVisible(bool Visible)
        {
            // Affiche / Desaffiche 
            tableLayoutPanel1.Visible = Visible;
            lblHoraire.Visible = Visible;
            lblNArret.Visible = Visible;
            lblNomArret.Visible = Visible;
            lblOrdre.Visible = Visible;
            cmdModif.Enabled = Visible;
            cmdSupp.Enabled = Visible;
        }

        private void AjoutLabel(string val, int colonne, int ligne)
        {
            //Permet d'ajouter les éléments dans la table pour l'affichage 
            Label lbl = new Label();
            lbl.AutoSize = false;
            lbl.Size = lblChoixLigne.Size;
            lbl.Text = val;
            tableLayoutPanel1.Controls.Add(lbl, ligne, colonne);
        }

        private void frmModification_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Ferme la connexion a la BD
            BDD.FermerConnexion();
        }

        private void cboChoixLigneModif_SelectedIndexChanged(object sender, EventArgs e)
        {
            AjoutTable();
        }

        private void AjoutTable()
        {
            //Si le combobox du choix trajet et du choix de ligne ont un item selectionner :
            if (cboChoixTrajet.SelectedIndex != -1 && cboChoixLigneModif.SelectedIndex != -1)
            {
                //Cache la table pour eviter les bug visuel
                ChangeVisible(false);

                //Vide toute la table
                tableLayoutPanel1.Controls.Clear();
                tableLayoutPanel1.RowStyles.Clear();
                List<Table> lesTables;

                //Obtient les num d'arret, nom d'arret, horaire et ordre de passage  selon les items choisis dans la combobox
                lesTables = BDD.GetLigne(cboChoixLigneModif.SelectedIndex + 1, cboChoixTrajet.SelectedIndex + 1);
                
                //Commence a la 1er ligne du tableau
                int ligne = 1;

                //Pour chaque items dans lesTables
                foreach (Table t in lesTables)
                {
                    //Ajoute le num Arret dans la 1er colonne
                    AjoutLabel(t.numArret.ToString(), ligne, 0);
                    //Ajoute le nom arret dans la 2eme colonne 
                    AjoutLabel(t.nomArret, ligne, 1);
                    //Ajoute l'horaire dans la 3eme colonne
                    AjoutLabel(t.Horaire, ligne, 2);
                    //Ajoute l'ordre de passage dans la 4eme colonne
                    AjoutLabel(t.ordrePassage.ToString(), ligne, 3);
                    //ajoute 1 a ligne afin de passer a la ligne suivante lors des prochaines insertions
                    ligne++;
                }
                //Permet de fermer le tableau avec une ligne pour que tout soit beau
                AjoutLabel(" ", ligne, 0);
                AjoutLabel(" ", ligne, 1);
                AjoutLabel(" ", ligne, 2);
                AjoutLabel(" ", ligne, 3);

                //Reaffiche le tableau avec les informations inserer
                ChangeVisible(true);
            }
        }

        private void cmdSupp_Click(object sender, EventArgs e)
        {
            //Demande de confirmation de la suppresion d'une ligne
            DialogResult dialogResult = MessageBox.Show($"Voulez vous vraiment supprimer la {cboChoixLigneModif.SelectedItem} en {cboChoixTrajet.SelectedItem}","Suppresion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Envoie la requet a la bd de la ligne a supprimer
                int resultat = BDD.SuppLigne(cboChoixLigneModif.SelectedIndex + 1, cboChoixTrajet.SelectedIndex + 1);
                
                //Cache la table pour eviter les bug visuel
                ChangeVisible(false);
                //Vide la table
                tableLayoutPanel1.Controls.Clear();
                tableLayoutPanel1.RowStyles.Clear();
                if (resultat == -1)
                {
                    MessageBox.Show("La ligne n'a pas pu etre supprimer", "Erreur de suppresion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int resultat1 = BDD.SuppDepart(cboChoixLigneModif.SelectedIndex + 1, cboChoixTrajet.SelectedIndex + 1);
                    if(resultat1 == -1)
                    {
                        MessageBox.Show("Le heures de departs n'ont pas pu etre supprimer", "Erreur de suppresion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                //Reajoute la table selectionner dans les combobox meme si elles sont vides
                AjoutTable();
            }
        }

        private void cmdAjouter_Click(object sender, EventArgs e)
        {
            //Cache la table et affiche le groupe control pour ajouter une ligne
            ChangeVisible(false);
            cboChoixLigneModif.Enabled = false;
            cboChoixTrajet.Enabled = false;
            grpPreAjouter.Visible = true;
            cmdAjouter.Enabled= false;
        }

        private void rbLigneExistante_CheckedChanged(object sender, EventArgs e)
        {
            //Si la radiobox ligne existante est selectionner 
            //Active la combobox des lignes existante
            cboLigneExistante.Enabled = true;
            //Desactive la saisie d'une nouvelle ligne
            txtbNvlLigne.Enabled = false;
        }

        private void rbNouvelleLigne_CheckedChanged(object sender, EventArgs e)
        {
            //Si la radiobox nouvelle ligne est selectionner
            //Active la saisie d'une nouvelle ligne
            cboLigneExistante.Enabled = false;
            //Desactive la combobox des lignes existante
            txtbNvlLigne.Enabled = true;
        }

        private void cmdValiderAjouter_Click(object sender, EventArgs e)
        {
            //Si la radiobox Ligne existante est selectionner et que rien n'est selectionner dans la combobox ligne existante
            //ou
            //Si la radiobox Nouvelle Ligne est selectionner et que la texte box n'a pas été selectionner ou est vide
            if ((rbLigneExistante.Checked == true && cboLigneExistante.SelectedIndex == -1) || (rbNouvelleLigne.Checked == true && (txtbNvlLigne.Text==(string)txtbNvlLigne.Tag || String.IsNullOrEmpty(txtbNvlLigne.Text) == true)))
            {
                //Afficher un message d'erreur
                MessageBox.Show("Merci de remplir les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //Sinon si tout est remplis et que la radiobox nouvelle ligne est selectionner
            }else if(rbNouvelleLigne.Checked == true)
            {
                bool erreur = false;
                //Pour chaque element dans la combobox des les existante
                for(int i = 0; i < cboLigneExistante.Items.Count; i++)
                {
                    //Si l'item n°i de la combobox ligne existante est egal a la saisie de la nouvelle ligne ou egal a "Ligne" + la saisie de la nouvelle ligne
                    if ((cboLigneExistante.GetItemText(cboLigneExistante.Items[i]) == txtbNvlLigne.Text || cboLigneExistante.GetItemText(cboLigneExistante.Items[i]) == "Ligne " + txtbNvlLigne.Text))
                    {
                        // afficher une erreur 
                        MessageBox.Show("Merci de ne pas entrer un nouveau nom de ligne déjà existant ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        erreur = true;
                    }
                    
                }
                //Si il n'y a pas eu une erreur
                if (!erreur)
                {
                    //Lancer l'ajout de l'arret
                    AjoutArret(txtbNvlLigne.Text,(string)cboTypeTrajetAjout.SelectedItem);
                }
            }
            //Sinon si la radiobox Ligne existante est selectionner
            else
            {
                List<Table> lesTables;
                //Obtient les ordre de passage de la ligne selectionner 
                lesTables = BDD.CheckPassage(cboLigneExistante.SelectedIndex+1, cboTypeTrajetAjout.SelectedIndex+1);
                int nbpassage = 0;
                //compte le nombre de passage de la ligne
                foreach (Table t in lesTables)
                {
                    nbpassage++;
                }
                //Si la ligne a plus de 0 passage 
                if (nbpassage != 0)
                {
                    //Afficher une erreur car on ne peut pas crée un nouvelle ligne sur une ancienne ligne
                    MessageBox.Show("Cette ligne à déjà des passage, merci de la supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //Lancer l'ajout de l'arret
                    AjoutArret((string)cboLigneExistante.SelectedItem,(string)cboTypeTrajetAjout.SelectedItem);
                }
            }
        }

        private void AjoutArret(string ligne,string trajet)
        {
            //Decoupe le chaine de texte du nom de la ligne en plusieur chaine de texte
            string[] subs = ligne.Split(' ');
            string nomLigne=String.Empty;

            //Pour chaque partie de la chaine de texte decouper
            foreach (var sub in subs)
            {
                //Si une des partie de la chaine de caractere (en maj) ne correspond pas a "LIGNE"
                if (sub.ToUpper() != "LIGNE")
                {
                    //Ajouter la partie de la chaine de caractere au reste
                    nomLigne = nomLigne+sub+" ";
                }
            }
            //Cela permet de ne pas avoir une double ligne dans le texte si l'utilisateur a entrer une nouvelle ligne avec le mot ligne avant

            //Permet d'afficher le resumer dans le label a cet effet
            lblResumerAjout.Text = $"Ajout pour la ligne {nomLigne}en {trajet}";

            //Cache le groupe pré ajoute
            grpPreAjouter.Visible = false;
            //Affiche le groupe ajoute pour selectionner l'ajout des arret
            grpAjouter.Visible = true;
            List<Arret> arrets;
            //obtient tout les arrets disponible
            arrets = BDD.GetArret();
            foreach (Arret arret in arrets)
            {
                //ajoute les items dans les combobox
                cboChoixArret1.Items.Add(arret.nomArret);
                //combobox de save qui permet de faciliter l'ajout des items a la fin
                cboNArretSave.Items.Add(arret.numArret);
            }

        }

        private void txtbNvlLigne_Enter(object sender, EventArgs e)
        {
            //Si la saisie de text de la nouvelle ligne est egale a sont tag (soit le texte de base)
            if(txtbNvlLigne.Text == (string)txtbNvlLigne.Tag)
            {
                //Vide la zone de saisie
                txtbNvlLigne.Text = "";
            }
        }

        private void txtbNvlLigne_Leave(object sender, EventArgs e)
        {
            //Si a la sortie de la zone de saisie celle si est vide
            if (String.IsNullOrEmpty(txtbNvlLigne.Text) == true)
            {
                //Remet le texte de base
                txtbNvlLigne.Text=(string)txtbNvlLigne.Tag;
            }
        }

        private void cmdAnnuler_Click(object sender, EventArgs e)
        {
            //Si bouton annuler
            //Ferme la table et reset tout de l'ajout
            CloseGrpAjout();
        }
        private void CloseGrpAjout()
        {
            //Cache la table Ajoute
            grpAjouter.Visible = false;

            //Desactive le bouton Valider de la table ajoute
            cmdValiderAjt.Enabled = false;

            //Cache la table PreAjoute
            grpPreAjouter.Visible = false;

            //Vide la table des arret pour l'Ajout
            tableLayoutPanel2.Controls.Clear();

            //Vide les combobox de sauvegarde
            cboSaveDelai.Items.Clear();
            cboSaveNomArret.Items.Clear();
            cboSaveNumArret.Items.Clear();

            //Met le nombre d'items a ajouter a 0
            lblIndex.Text = "0";

            //Remet les bouton et combobox au valeur de demarrage
            cmdAjouter.Enabled = true;
            cmdModif.Enabled = false;
            cmdSupp.Enabled = false;
            cboChoixLigneModif.Enabled = true;
            cboChoixTrajet.Enabled = true;

            //Permet d'afficher la table qui est selectionner
            AjoutTable();
        }

        private void clickRetour(object sender, EventArgs e)
        {
            //Ferme la fenetre
            this.Close();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            //Si le combobox du choix d'arret n'a rien de selectionner ou si le delai n'est pas saisie
            if(cboChoixArret1.SelectedIndex==-1 || String.IsNullOrEmpty(txtbChoixDelai1.Text) == true)
            {
                //Affiche un message d'erreur
                MessageBox.Show("Merci de remplir les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else{
                //Cache la table ajout pour eviter les bug visuel
                tableLayoutPanel2.Visible = false;

                //Active le bouton pour supprimer l'arret qui va etre ajouter
                cmdRemove.Enabled = true; 
                
                //Ajout un label avec le nom de l'arret a la table des nouveau arret
                Label lbl = new Label();
                lbl.AutoSize = false;
                lbl.Size = lblSetTaille0.Size;
                lbl.Text = (string)cboChoixArret1.SelectedItem;
                tableLayoutPanel2.Controls.Add(lbl, 0, Convert.ToInt32(lblIndex.Text));

                //Sauvegarde les passage des arret dans des combobox non visible 
                // Sauvegarde dans les combobox pour une recuperation simple des items pour l'ajout dans la BD
                cboSaveNomArret.Items.Add(cboChoixArret1.SelectedItem);
                cboSaveNumArret.Items.Add(cboNArretSave.Items[cboChoixArret1.SelectedIndex]);

                //Ajout un label avec le delai a la table des nouveau arret
                Label lbl2 = new Label();
                lbl2.AutoSize = false;
                lbl2.Size = lblSetTaille1.Size;
                lbl2.Text = txtbChoixDelai1.Text;
                tableLayoutPanel2.Controls.Add(lbl2, 1, Convert.ToInt32(lblIndex.Text));

                //Sauvegarde le delai dans un combobox non visible 
                // Sauvegarde dans les combobox pour une recuperation simple des items pour l'ajout dans la BD
                cboSaveDelai.Items.Add(txtbChoixDelai1.Text);

                //Ajout un label avec le numero de passage a la table des nouveau arret
                Label lbl3 = new Label();
                lbl3.AutoSize = false;
                lbl3.Size = lblSetTaille2.Size;
                lbl3.Text = Convert.ToString(Convert.ToInt32(lblIndex.Text) + 1);
                tableLayoutPanel2.Controls.Add(lbl3, 2, Convert.ToInt32(lblIndex.Text));

                //Augmente de 1 le numero de passage pour le suivant 
                lblIndex.Text = Convert.ToString(Convert.ToInt32(lblIndex.Text) + 1);

                //reaffiche le tableau avec les nouvelles infos
                tableLayoutPanel2.Visible = true;
                //Active le bouton valider afin d'envoyer a la bd
                cmdValiderAjt.Enabled = true;
            }

        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            //Cache la table ajout pour eviter les bug visuel
            tableLayoutPanel2.Visible = false;

            //Enleve 1 au nombre total de passage
            lblIndex.Text = Convert.ToString(Convert.ToInt32(lblIndex.Text) - 1);

            //Enleve le derniere items ajouter des combobox de sauvegarde
            cboSaveDelai.Items.RemoveAt(Convert.ToInt32(lblIndex.Text));
            cboSaveNomArret.Items.RemoveAt(Convert.ToInt32(lblIndex.Text));
            cboSaveNumArret.Items.RemoveAt(Convert.ToInt32(lblIndex.Text));

            //Supprime tout les element de la table d'affichage car il n'est pas possible de choisir lequel supprimer
            tableLayoutPanel2.Controls.Clear();

            //Boucle permettant de reattribuer tout les items sauf le derniere items qui vient d'etre enlever au tableau d'affichage
            for(int i = 0; i < Convert.ToInt32(lblIndex.Text) ; i++)
            {
                //Ajoute Nom arret
                Label lbl1 = new Label();
                lbl1.AutoSize = false;
                lbl1.Size = lblSetTaille0.Size;
                lbl1.Text = (string)cboSaveNomArret.Items[i];
                tableLayoutPanel2.Controls.Add(lbl1);

                //Ajoute Delai
                Label lbl2 = new Label();
                lbl2.AutoSize = false;
                lbl2.Size = lblSetTaille1.Size;
                lbl2.Text = (string)cboSaveDelai.Items[i];
                tableLayoutPanel2.Controls.Add(lbl2);

                //Ajoute l'ordre de passage
                Label lbl3 = new Label();
                lbl3.AutoSize = false;
                lbl3.Size = lblSetTaille2.Size;
                lbl3.Text = Convert.ToString(i+1);
                tableLayoutPanel2.Controls.Add(lbl3);
            }

            //Si aucun arret restant
            if (Convert.ToInt32(lblIndex.Text) == 0)
            {
                //Desactive le bouton supprimer et valider 
                cmdRemove.Enabled = false;
                cmdValiderAjt.Enabled = false;
            }

            //Reaffiche la table
            tableLayoutPanel2.Visible = true;
        }

        private void cmdValiderAjt_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtbHeureDepart.Text) == true || String.IsNullOrEmpty(txtbDelai.Text) == true || String.IsNullOrEmpty(txtbDerniereHeure.Text) == true)
            {
                MessageBox.Show("Merci de remplir les champs de delais", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Confirmation de l'ajout dans la BD
                DialogResult dialogResult = MessageBox.Show("Voulez vous vraiment ajouter cette ligne ?", "Ajout", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //Si c'est une nouvelle ligne
                    if (rbNouvelleLigne.Checked)
                    {
                        //On decoupe la chaine de caractere du nom de la ligne afin de ne pas avoir de double "Ligne" dans le nom
                        string[] subs = txtbNvlLigne.Text.Split(' ');
                        string nomLigne = String.Empty;
                        foreach (var sub in subs)
                        {
                            if (sub.ToUpper() != "LIGNE")
                            {
                                nomLigne = nomLigne + " " + sub;
                            }
                        }
                        nomLigne = "Ligne" + nomLigne;

                        //Ajoute la nouvelle ligne dans les combobox avec le choix des lignes
                        cboLigneExistante.Items.Add(nomLigne);
                        cboChoixLigneModif.Items.Add(nomLigne);

                        //Ajoute la nouvelle ligne dans la bd
                        int id = BDD.AddLigne(cboLigneExistante.Items.Count, nomLigne);

                        //Si erreur d'insertion
                        if (id == -1)
                        {
                            MessageBox.Show("Une erreur est survenu (Ajout Ligne)");
                        }
                        //Sinon on ajoute les passages selectionner dans la BD
                        else
                        {
                            for (int i = 0; i < Convert.ToInt32(lblIndex.Text); i++)
                            {
                                int id1 = BDD.AddPassage(cboLigneExistante.Items.Count, cboTypeTrajetAjout.SelectedIndex + 1, Convert.ToInt32(cboSaveNumArret.Items[i]), Convert.ToString(cboSaveDelai.Items[i]), i + 1);
                                if (id1 == -1)
                                {
                                    MessageBox.Show("Une erreur est survenu (Ajout Passage)");
                                }

                            }
                            int id2 = BDD.AddDepart(cboLigneExistante.Items.Count, cboTypeTrajetAjout.SelectedIndex + 1, txtbHeureDepart.Text, txtbDelai.Text, txtbDerniereHeure.Text);
                            if (id2 == -1)
                            {
                                MessageBox.Show("Une erreur est survenu (Ajout Depart)");
                            }
                        }
                    }
                    //Sinon si Ligne existante
                    else
                    {
                        for (int i = 0; i < Convert.ToInt32(lblIndex.Text); i++)
                        {
                            int id = BDD.AddPassage(cboLigneExistante.SelectedIndex + 1, cboTypeTrajetAjout.SelectedIndex + 1, Convert.ToInt32(cboSaveNumArret.Items[i]), Convert.ToString(cboSaveDelai.Items[i]), i + 1);
                            if (id == -1)
                            {
                                MessageBox.Show("Une erreur est survenu (Ajout Passage)");
                            }

                        }
                        int id1 = BDD.AddDepart(cboLigneExistante.SelectedIndex + 1, cboTypeTrajetAjout.SelectedIndex + 1, txtbHeureDepart.Text, txtbDelai.Text, txtbDerniereHeure.Text);
                        if (id1 == -1)
                        {
                            MessageBox.Show($"Une erreur est survenu (Ajout Depart) {cboLigneExistante.SelectedIndex + 1},{cboTypeTrajetAjout.SelectedIndex + 1},{txtbHeureDepart.Text},{txtbDelai.Text},{txtbDerniereHeure.Text}");
                        }
                    }

                    //Ferme le groupe de l'ajout
                    CloseGrpAjout();
                }
            }
        }
    }
}
