
namespace SAE2._1
{
    partial class frmAffichage
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
            this.lblChoixLigne = new System.Windows.Forms.Label();
            this.cboChoixLigneAff = new System.Windows.Forms.ComboBox();
            this.cboChoixTrajet = new System.Windows.Forms.ComboBox();
            this.lblChoixTrajet = new System.Windows.Forms.Label();
            this.cboChoixAffich = new System.Windows.Forms.ComboBox();
            this.cboAffichage = new System.Windows.Forms.Label();
            this.grpAffichArret = new System.Windows.Forms.GroupBox();
            this.lblOrdre = new System.Windows.Forms.Label();
            this.lblNomArret = new System.Windows.Forms.Label();
            this.lblNArret = new System.Windows.Forms.Label();
            this.cmdRetour = new System.Windows.Forms.Button();
            this.cmdChargement = new System.Windows.Forms.Button();
            this.tableLayoutPanelArret = new System.Windows.Forms.TableLayoutPanel();
            this.grpAffichHoraire = new System.Windows.Forms.GroupBox();
            this.lblHoraireDepartHoraire = new System.Windows.Forms.Label();
            this.tableLayoutPanelHoraire = new System.Windows.Forms.TableLayoutPanel();
            this.lblDenierePassageHoraire = new System.Windows.Forms.Label();
            this.lblDelaiPassageHoraire = new System.Windows.Forms.Label();
            this.lblOrdrePassageHoraire = new System.Windows.Forms.Label();
            this.lblHoraireHoraire = new System.Windows.Forms.Label();
            this.grpAffichTout = new System.Windows.Forms.GroupBox();
            this.lblNumArretTout = new System.Windows.Forms.Label();
            this.lblDelaiPassageTout = new System.Windows.Forms.Label();
            this.lblDernierPassageTout = new System.Windows.Forms.Label();
            this.tableLayoutPanelTout = new System.Windows.Forms.TableLayoutPanel();
            this.lblHoraireDepartTout = new System.Windows.Forms.Label();
            this.lblArretTout = new System.Windows.Forms.Label();
            this.lblHoraireTout = new System.Windows.Forms.Label();
            this.lblOrdrePassageTout = new System.Windows.Forms.Label();
            this.grpAffichArret.SuspendLayout();
            this.grpAffichHoraire.SuspendLayout();
            this.grpAffichTout.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblChoixLigne
            // 
            this.lblChoixLigne.AutoSize = true;
            this.lblChoixLigne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoixLigne.Location = new System.Drawing.Point(66, 70);
            this.lblChoixLigne.Name = "lblChoixLigne";
            this.lblChoixLigne.Size = new System.Drawing.Size(125, 20);
            this.lblChoixLigne.TabIndex = 1;
            this.lblChoixLigne.Text = "Choisir une ligne";
            // 
            // cboChoixLigneAff
            // 
            this.cboChoixLigneAff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChoixLigneAff.FormattingEnabled = true;
            this.cboChoixLigneAff.Location = new System.Drawing.Point(70, 96);
            this.cboChoixLigneAff.Name = "cboChoixLigneAff";
            this.cboChoixLigneAff.Size = new System.Drawing.Size(121, 21);
            this.cboChoixLigneAff.TabIndex = 2;
            this.cboChoixLigneAff.SelectedIndexChanged += new System.EventHandler(this.cbo_SelectIndexChanged);
            // 
            // cboChoixTrajet
            // 
            this.cboChoixTrajet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChoixTrajet.FormattingEnabled = true;
            this.cboChoixTrajet.Location = new System.Drawing.Point(70, 158);
            this.cboChoixTrajet.Name = "cboChoixTrajet";
            this.cboChoixTrajet.Size = new System.Drawing.Size(121, 21);
            this.cboChoixTrajet.TabIndex = 4;
            this.cboChoixTrajet.SelectedIndexChanged += new System.EventHandler(this.cbo_SelectIndexChanged);
            // 
            // lblChoixTrajet
            // 
            this.lblChoixTrajet.AutoSize = true;
            this.lblChoixTrajet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoixTrajet.Location = new System.Drawing.Point(43, 135);
            this.lblChoixTrajet.Name = "lblChoixTrajet";
            this.lblChoixTrajet.Size = new System.Drawing.Size(175, 20);
            this.lblChoixTrajet.TabIndex = 3;
            this.lblChoixTrajet.Text = "Choisir un type de trajet";
            // 
            // cboChoixAffich
            // 
            this.cboChoixAffich.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChoixAffich.FormattingEnabled = true;
            this.cboChoixAffich.Location = new System.Drawing.Point(70, 226);
            this.cboChoixAffich.Name = "cboChoixAffich";
            this.cboChoixAffich.Size = new System.Drawing.Size(121, 21);
            this.cboChoixAffich.TabIndex = 6;
            this.cboChoixAffich.SelectedIndexChanged += new System.EventHandler(this.cbo_SelectIndexChanged);
            // 
            // cboAffichage
            // 
            this.cboAffichage.AutoSize = true;
            this.cboAffichage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAffichage.Location = new System.Drawing.Point(34, 203);
            this.cboAffichage.Name = "cboAffichage";
            this.cboAffichage.Size = new System.Drawing.Size(195, 20);
            this.cboAffichage.TabIndex = 5;
            this.cboAffichage.Text = "Choisir un type d\'affichage";
            // 
            // grpAffichArret
            // 
            this.grpAffichArret.Controls.Add(this.tableLayoutPanelArret);
            this.grpAffichArret.Controls.Add(this.lblOrdre);
            this.grpAffichArret.Controls.Add(this.lblNomArret);
            this.grpAffichArret.Controls.Add(this.lblNArret);
            this.grpAffichArret.Location = new System.Drawing.Point(262, 12);
            this.grpAffichArret.Name = "grpAffichArret";
            this.grpAffichArret.Size = new System.Drawing.Size(730, 410);
            this.grpAffichArret.TabIndex = 7;
            this.grpAffichArret.TabStop = false;
            this.grpAffichArret.Text = "Affichage Arret :";
            this.grpAffichArret.Visible = false;
            // 
            // lblOrdre
            // 
            this.lblOrdre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrdre.Location = new System.Drawing.Point(492, 23);
            this.lblOrdre.Name = "lblOrdre";
            this.lblOrdre.Size = new System.Drawing.Size(231, 23);
            this.lblOrdre.TabIndex = 3;
            this.lblOrdre.Text = "Ordre de passage";
            this.lblOrdre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNomArret
            // 
            this.lblNomArret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNomArret.Location = new System.Drawing.Point(254, 23);
            this.lblNomArret.Name = "lblNomArret";
            this.lblNomArret.Size = new System.Drawing.Size(232, 23);
            this.lblNomArret.TabIndex = 1;
            this.lblNomArret.Text = "Nom Arret";
            this.lblNomArret.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNArret
            // 
            this.lblNArret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNArret.Location = new System.Drawing.Point(13, 23);
            this.lblNArret.Name = "lblNArret";
            this.lblNArret.Size = new System.Drawing.Size(235, 23);
            this.lblNArret.TabIndex = 0;
            this.lblNArret.Text = "N°Arret";
            this.lblNArret.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdRetour
            // 
            this.cmdRetour.Location = new System.Drawing.Point(465, 443);
            this.cmdRetour.Name = "cmdRetour";
            this.cmdRetour.Size = new System.Drawing.Size(75, 23);
            this.cmdRetour.TabIndex = 8;
            this.cmdRetour.Text = "Retour";
            this.cmdRetour.UseVisualStyleBackColor = true;
            this.cmdRetour.Click += new System.EventHandler(this.clickRetour);
            // 
            // cmdChargement
            // 
            this.cmdChargement.Enabled = false;
            this.cmdChargement.Location = new System.Drawing.Point(70, 275);
            this.cmdChargement.Name = "cmdChargement";
            this.cmdChargement.Size = new System.Drawing.Size(121, 23);
            this.cmdChargement.TabIndex = 9;
            this.cmdChargement.Text = "Chargement";
            this.cmdChargement.UseVisualStyleBackColor = true;
            this.cmdChargement.Click += new System.EventHandler(this.cmdChargement_Click);
            // 
            // tableLayoutPanelArret
            // 
            this.tableLayoutPanelArret.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelArret.AutoScroll = true;
            this.tableLayoutPanelArret.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelArret.ColumnCount = 3;
            this.tableLayoutPanelArret.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelArret.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelArret.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelArret.Location = new System.Drawing.Point(13, 49);
            this.tableLayoutPanelArret.Name = "tableLayoutPanelArret";
            this.tableLayoutPanelArret.RowCount = 1;
            this.tableLayoutPanelArret.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelArret.Size = new System.Drawing.Size(711, 355);
            this.tableLayoutPanelArret.TabIndex = 4;
            // 
            // grpAffichHoraire
            // 
            this.grpAffichHoraire.Controls.Add(this.grpAffichTout);
            this.grpAffichHoraire.Controls.Add(this.lblHoraireHoraire);
            this.grpAffichHoraire.Controls.Add(this.lblOrdrePassageHoraire);
            this.grpAffichHoraire.Controls.Add(this.lblDelaiPassageHoraire);
            this.grpAffichHoraire.Controls.Add(this.lblDenierePassageHoraire);
            this.grpAffichHoraire.Controls.Add(this.tableLayoutPanelHoraire);
            this.grpAffichHoraire.Controls.Add(this.lblHoraireDepartHoraire);
            this.grpAffichHoraire.Location = new System.Drawing.Point(262, 12);
            this.grpAffichHoraire.Name = "grpAffichHoraire";
            this.grpAffichHoraire.Size = new System.Drawing.Size(730, 410);
            this.grpAffichHoraire.TabIndex = 8;
            this.grpAffichHoraire.TabStop = false;
            this.grpAffichHoraire.Text = "Affichage Horaire :";
            this.grpAffichHoraire.Visible = false;
            // 
            // lblHoraireDepartHoraire
            // 
            this.lblHoraireDepartHoraire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHoraireDepartHoraire.Location = new System.Drawing.Point(13, 23);
            this.lblHoraireDepartHoraire.Name = "lblHoraireDepartHoraire";
            this.lblHoraireDepartHoraire.Size = new System.Drawing.Size(162, 23);
            this.lblHoraireDepartHoraire.TabIndex = 0;
            this.lblHoraireDepartHoraire.Text = "Horaire de depart :";
            this.lblHoraireDepartHoraire.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanelHoraire
            // 
            this.tableLayoutPanelHoraire.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelHoraire.AutoScroll = true;
            this.tableLayoutPanelHoraire.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelHoraire.ColumnCount = 2;
            this.tableLayoutPanelHoraire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelHoraire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelHoraire.Location = new System.Drawing.Point(390, 49);
            this.tableLayoutPanelHoraire.Name = "tableLayoutPanelHoraire";
            this.tableLayoutPanelHoraire.RowCount = 1;
            this.tableLayoutPanelHoraire.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHoraire.Size = new System.Drawing.Size(334, 355);
            this.tableLayoutPanelHoraire.TabIndex = 4;
            // 
            // lblDenierePassageHoraire
            // 
            this.lblDenierePassageHoraire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDenierePassageHoraire.Location = new System.Drawing.Point(13, 83);
            this.lblDenierePassageHoraire.Name = "lblDenierePassageHoraire";
            this.lblDenierePassageHoraire.Size = new System.Drawing.Size(162, 23);
            this.lblDenierePassageHoraire.TabIndex = 5;
            this.lblDenierePassageHoraire.Text = "Dernier passage :";
            this.lblDenierePassageHoraire.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDelaiPassageHoraire
            // 
            this.lblDelaiPassageHoraire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDelaiPassageHoraire.Location = new System.Drawing.Point(13, 53);
            this.lblDelaiPassageHoraire.Name = "lblDelaiPassageHoraire";
            this.lblDelaiPassageHoraire.Size = new System.Drawing.Size(162, 23);
            this.lblDelaiPassageHoraire.TabIndex = 6;
            this.lblDelaiPassageHoraire.Text = "Delai entre passage :";
            this.lblDelaiPassageHoraire.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOrdrePassageHoraire
            // 
            this.lblOrdrePassageHoraire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrdrePassageHoraire.Location = new System.Drawing.Point(390, 23);
            this.lblOrdrePassageHoraire.Name = "lblOrdrePassageHoraire";
            this.lblOrdrePassageHoraire.Size = new System.Drawing.Size(162, 23);
            this.lblOrdrePassageHoraire.TabIndex = 7;
            this.lblOrdrePassageHoraire.Text = "Ordre de passage";
            this.lblOrdrePassageHoraire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHoraireHoraire
            // 
            this.lblHoraireHoraire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHoraireHoraire.Location = new System.Drawing.Point(561, 23);
            this.lblHoraireHoraire.Name = "lblHoraireHoraire";
            this.lblHoraireHoraire.Size = new System.Drawing.Size(162, 23);
            this.lblHoraireHoraire.TabIndex = 8;
            this.lblHoraireHoraire.Text = "Horaire";
            this.lblHoraireHoraire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpAffichTout
            // 
            this.grpAffichTout.Controls.Add(this.lblNumArretTout);
            this.grpAffichTout.Controls.Add(this.lblHoraireTout);
            this.grpAffichTout.Controls.Add(this.lblOrdrePassageTout);
            this.grpAffichTout.Controls.Add(this.lblArretTout);
            this.grpAffichTout.Controls.Add(this.lblDelaiPassageTout);
            this.grpAffichTout.Controls.Add(this.lblDernierPassageTout);
            this.grpAffichTout.Controls.Add(this.tableLayoutPanelTout);
            this.grpAffichTout.Controls.Add(this.lblHoraireDepartTout);
            this.grpAffichTout.Location = new System.Drawing.Point(0, 0);
            this.grpAffichTout.Name = "grpAffichTout";
            this.grpAffichTout.Size = new System.Drawing.Size(730, 410);
            this.grpAffichTout.TabIndex = 9;
            this.grpAffichTout.TabStop = false;
            this.grpAffichTout.Text = "Affichage Tout :";
            this.grpAffichTout.Visible = false;
            // 
            // lblNumArretTout
            // 
            this.lblNumArretTout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumArretTout.Location = new System.Drawing.Point(181, 23);
            this.lblNumArretTout.Name = "lblNumArretTout";
            this.lblNumArretTout.Size = new System.Drawing.Size(132, 23);
            this.lblNumArretTout.TabIndex = 7;
            this.lblNumArretTout.Text = "N°Arret";
            this.lblNumArretTout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDelaiPassageTout
            // 
            this.lblDelaiPassageTout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDelaiPassageTout.Location = new System.Drawing.Point(13, 53);
            this.lblDelaiPassageTout.Name = "lblDelaiPassageTout";
            this.lblDelaiPassageTout.Size = new System.Drawing.Size(162, 23);
            this.lblDelaiPassageTout.TabIndex = 6;
            this.lblDelaiPassageTout.Text = "Delai entre passage :";
            this.lblDelaiPassageTout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDernierPassageTout
            // 
            this.lblDernierPassageTout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDernierPassageTout.Location = new System.Drawing.Point(13, 83);
            this.lblDernierPassageTout.Name = "lblDernierPassageTout";
            this.lblDernierPassageTout.Size = new System.Drawing.Size(162, 23);
            this.lblDernierPassageTout.TabIndex = 5;
            this.lblDernierPassageTout.Text = "Dernier passage :";
            this.lblDernierPassageTout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanelTout
            // 
            this.tableLayoutPanelTout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelTout.AutoScroll = true;
            this.tableLayoutPanelTout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelTout.ColumnCount = 4;
            this.tableLayoutPanelTout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelTout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelTout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelTout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelTout.Location = new System.Drawing.Point(181, 49);
            this.tableLayoutPanelTout.Name = "tableLayoutPanelTout";
            this.tableLayoutPanelTout.RowCount = 1;
            this.tableLayoutPanelTout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTout.Size = new System.Drawing.Size(543, 355);
            this.tableLayoutPanelTout.TabIndex = 4;
            // 
            // lblHoraireDepartTout
            // 
            this.lblHoraireDepartTout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHoraireDepartTout.Location = new System.Drawing.Point(13, 23);
            this.lblHoraireDepartTout.Name = "lblHoraireDepartTout";
            this.lblHoraireDepartTout.Size = new System.Drawing.Size(162, 23);
            this.lblHoraireDepartTout.TabIndex = 0;
            this.lblHoraireDepartTout.Text = "Horaire de depart :";
            this.lblHoraireDepartTout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblArretTout
            // 
            this.lblArretTout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArretTout.Location = new System.Drawing.Point(319, 23);
            this.lblArretTout.Name = "lblArretTout";
            this.lblArretTout.Size = new System.Drawing.Size(132, 23);
            this.lblArretTout.TabIndex = 9;
            this.lblArretTout.Text = "Arret";
            this.lblArretTout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHoraireTout
            // 
            this.lblHoraireTout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHoraireTout.Location = new System.Drawing.Point(457, 23);
            this.lblHoraireTout.Name = "lblHoraireTout";
            this.lblHoraireTout.Size = new System.Drawing.Size(132, 23);
            this.lblHoraireTout.TabIndex = 10;
            this.lblHoraireTout.Text = "Horaire";
            this.lblHoraireTout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrdrePassageTout
            // 
            this.lblOrdrePassageTout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrdrePassageTout.Location = new System.Drawing.Point(592, 23);
            this.lblOrdrePassageTout.Name = "lblOrdrePassageTout";
            this.lblOrdrePassageTout.Size = new System.Drawing.Size(132, 23);
            this.lblOrdrePassageTout.TabIndex = 11;
            this.lblOrdrePassageTout.Text = "Ordre de passage";
            this.lblOrdrePassageTout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAffichage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 521);
            this.Controls.Add(this.grpAffichHoraire);
            this.Controls.Add(this.cmdChargement);
            this.Controls.Add(this.cmdRetour);
            this.Controls.Add(this.grpAffichArret);
            this.Controls.Add(this.cboChoixAffich);
            this.Controls.Add(this.cboAffichage);
            this.Controls.Add(this.cboChoixTrajet);
            this.Controls.Add(this.lblChoixTrajet);
            this.Controls.Add(this.cboChoixLigneAff);
            this.Controls.Add(this.lblChoixLigne);
            this.Name = "frmAffichage";
            this.Text = "Affichage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAffichage_FormClosed);
            this.Load += new System.EventHandler(this.frm_Load);
            this.grpAffichArret.ResumeLayout(false);
            this.grpAffichHoraire.ResumeLayout(false);
            this.grpAffichTout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChoixLigne;
        private System.Windows.Forms.ComboBox cboChoixLigneAff;
        private System.Windows.Forms.ComboBox cboChoixTrajet;
        private System.Windows.Forms.Label lblChoixTrajet;
        private System.Windows.Forms.ComboBox cboChoixAffich;
        private System.Windows.Forms.Label cboAffichage;
        private System.Windows.Forms.GroupBox grpAffichArret;
        private System.Windows.Forms.Label lblOrdre;
        private System.Windows.Forms.Label lblNomArret;
        private System.Windows.Forms.Label lblNArret;
        private System.Windows.Forms.Button cmdRetour;
        private System.Windows.Forms.Button cmdChargement;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelArret;
        private System.Windows.Forms.GroupBox grpAffichHoraire;
        private System.Windows.Forms.Label lblHoraireDepartHoraire;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHoraire;
        private System.Windows.Forms.Label lblDelaiPassageHoraire;
        private System.Windows.Forms.Label lblDenierePassageHoraire;
        private System.Windows.Forms.Label lblHoraireHoraire;
        private System.Windows.Forms.Label lblOrdrePassageHoraire;
        private System.Windows.Forms.GroupBox grpAffichTout;
        private System.Windows.Forms.Label lblNumArretTout;
        private System.Windows.Forms.Label lblDelaiPassageTout;
        private System.Windows.Forms.Label lblDernierPassageTout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTout;
        private System.Windows.Forms.Label lblHoraireDepartTout;
        private System.Windows.Forms.Label lblHoraireTout;
        private System.Windows.Forms.Label lblOrdrePassageTout;
        private System.Windows.Forms.Label lblArretTout;
    }
}