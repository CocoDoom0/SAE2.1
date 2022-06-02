
namespace SAE2._1
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpRecherche = new System.Windows.Forms.GroupBox();
            this.lblOrdre = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHoraire = new System.Windows.Forms.Label();
            this.cmdValider = new System.Windows.Forms.Button();
            this.lblNomArret = new System.Windows.Forms.Label();
            this.lblNArret = new System.Windows.Forms.Label();
            this.cboChoixArretArr = new System.Windows.Forms.ComboBox();
            this.lblChoixTrajet = new System.Windows.Forms.Label();
            this.cboChoixLigneAff = new System.Windows.Forms.ComboBox();
            this.lblArretDep = new System.Windows.Forms.Label();
            this.cmdRetour = new System.Windows.Forms.Button();
            this.cmdRechercher = new System.Windows.Forms.Button();
            this.grpRecherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRecherche
            // 
            this.grpRecherche.Controls.Add(this.lblOrdre);
            this.grpRecherche.Controls.Add(this.tableLayoutPanel1);
            this.grpRecherche.Controls.Add(this.lblHoraire);
            this.grpRecherche.Controls.Add(this.cmdValider);
            this.grpRecherche.Controls.Add(this.lblNomArret);
            this.grpRecherche.Controls.Add(this.lblNArret);
            this.grpRecherche.Location = new System.Drawing.Point(262, 12);
            this.grpRecherche.Name = "grpRecherche";
            this.grpRecherche.Size = new System.Drawing.Size(730, 410);
            this.grpRecherche.TabIndex = 6;
            this.grpRecherche.TabStop = false;
            this.grpRecherche.Text = "Trajet";
            // 
            // lblOrdre
            // 
            this.lblOrdre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrdre.Location = new System.Drawing.Point(550, 23);
            this.lblOrdre.Name = "lblOrdre";
            this.lblOrdre.Size = new System.Drawing.Size(173, 23);
            this.lblOrdre.TabIndex = 3;
            this.lblOrdre.Text = "Ordre de passage";
            this.lblOrdre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOrdre.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.08662F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.80943F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.05198F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.05198F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 355F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 355F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(724, 355);
            this.tableLayoutPanel1.TabIndex = 8;
            this.tableLayoutPanel1.Visible = false;
            // 
            // lblHoraire
            // 
            this.lblHoraire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHoraire.Location = new System.Drawing.Point(371, 23);
            this.lblHoraire.Name = "lblHoraire";
            this.lblHoraire.Size = new System.Drawing.Size(173, 23);
            this.lblHoraire.TabIndex = 2;
            this.lblHoraire.Text = "Horaire";
            this.lblHoraire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHoraire.Visible = false;
            // 
            // cmdValider
            // 
            this.cmdValider.Enabled = false;
            this.cmdValider.Location = new System.Drawing.Point(649, 381);
            this.cmdValider.Name = "cmdValider";
            this.cmdValider.Size = new System.Drawing.Size(75, 23);
            this.cmdValider.TabIndex = 6;
            this.cmdValider.Text = "Valider";
            this.cmdValider.UseVisualStyleBackColor = true;
            // 
            // lblNomArret
            // 
            this.lblNomArret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNomArret.Location = new System.Drawing.Point(192, 23);
            this.lblNomArret.Name = "lblNomArret";
            this.lblNomArret.Size = new System.Drawing.Size(173, 23);
            this.lblNomArret.TabIndex = 1;
            this.lblNomArret.Text = "Nom Arret";
            this.lblNomArret.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNomArret.Visible = false;
            // 
            // lblNArret
            // 
            this.lblNArret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNArret.Location = new System.Drawing.Point(13, 23);
            this.lblNArret.Name = "lblNArret";
            this.lblNArret.Size = new System.Drawing.Size(173, 23);
            this.lblNArret.TabIndex = 0;
            this.lblNArret.Text = "N°Arret";
            this.lblNArret.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNArret.Visible = false;
            // 
            // cboChoixArretArr
            // 
            this.cboChoixArretArr.FormattingEnabled = true;
            this.cboChoixArretArr.Location = new System.Drawing.Point(70, 149);
            this.cboChoixArretArr.Name = "cboChoixArretArr";
            this.cboChoixArretArr.Size = new System.Drawing.Size(121, 21);
            this.cboChoixArretArr.TabIndex = 12;
            this.cboChoixArretArr.Text = "Choisir arrêt d\'arrivé";
            // 
            // lblChoixTrajet
            // 
            this.lblChoixTrajet.AutoSize = true;
            this.lblChoixTrajet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoixTrajet.Location = new System.Drawing.Point(81, 126);
            this.lblChoixTrajet.Name = "lblChoixTrajet";
            this.lblChoixTrajet.Size = new System.Drawing.Size(98, 20);
            this.lblChoixTrajet.TabIndex = 11;
            this.lblChoixTrajet.Text = "Arrêt d\'arrivé";
            // 
            // cboChoixLigneAff
            // 
            this.cboChoixLigneAff.FormattingEnabled = true;
            this.cboChoixLigneAff.Location = new System.Drawing.Point(70, 93);
            this.cboChoixLigneAff.Name = "cboChoixLigneAff";
            this.cboChoixLigneAff.Size = new System.Drawing.Size(121, 21);
            this.cboChoixLigneAff.TabIndex = 10;
            this.cboChoixLigneAff.Text = "Choisir arrêt départ";
            // 
            // lblArretDep
            // 
            this.lblArretDep.AutoSize = true;
            this.lblArretDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArretDep.Location = new System.Drawing.Point(72, 70);
            this.lblArretDep.Name = "lblArretDep";
            this.lblArretDep.Size = new System.Drawing.Size(116, 20);
            this.lblArretDep.TabIndex = 9;
            this.lblArretDep.Text = "Arrêt de départ";
            // 
            // cmdRetour
            // 
            this.cmdRetour.Location = new System.Drawing.Point(465, 443);
            this.cmdRetour.Name = "cmdRetour";
            this.cmdRetour.Size = new System.Drawing.Size(75, 23);
            this.cmdRetour.TabIndex = 13;
            this.cmdRetour.Text = "Retour";
            this.cmdRetour.UseVisualStyleBackColor = true;
            // 
            // cmdRechercher
            // 
            this.cmdRechercher.Enabled = false;
            this.cmdRechercher.Location = new System.Drawing.Point(70, 185);
            this.cmdRechercher.Name = "cmdRechercher";
            this.cmdRechercher.Size = new System.Drawing.Size(121, 23);
            this.cmdRechercher.TabIndex = 14;
            this.cmdRechercher.Text = "Rechercher";
            this.cmdRechercher.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 521);
            this.Controls.Add(this.cmdRechercher);
            this.Controls.Add(this.cmdRetour);
            this.Controls.Add(this.cboChoixArretArr);
            this.Controls.Add(this.grpRecherche);
            this.Controls.Add(this.lblChoixTrajet);
            this.Controls.Add(this.lblArretDep);
            this.Controls.Add(this.cboChoixLigneAff);
            this.Name = "Form4";
            this.Text = "Form4";
            this.grpRecherche.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRecherche;
        private System.Windows.Forms.Label lblOrdre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblHoraire;
        private System.Windows.Forms.Button cmdValider;
        private System.Windows.Forms.Label lblNomArret;
        private System.Windows.Forms.Label lblNArret;
        private System.Windows.Forms.ComboBox cboChoixArretArr;
        private System.Windows.Forms.Label lblChoixTrajet;
        private System.Windows.Forms.ComboBox cboChoixLigneAff;
        private System.Windows.Forms.Label lblArretDep;
        private System.Windows.Forms.Button cmdRetour;
        private System.Windows.Forms.Button cmdRechercher;
    }
}