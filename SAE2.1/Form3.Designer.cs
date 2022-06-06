
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
            this.cmdRetour = new System.Windows.Forms.Button();
            this.cmdChargement = new System.Windows.Forms.Button();
            this.grpAffichTout = new System.Windows.Forms.GroupBox();
            this.lblNumArretTout = new System.Windows.Forms.Label();
            this.lblHoraireTout = new System.Windows.Forms.Label();
            this.lblOrdrePassageTout = new System.Windows.Forms.Label();
            this.lblArretTout = new System.Windows.Forms.Label();
            this.lblDelaiPassageTout = new System.Windows.Forms.Label();
            this.lblDernierPassageTout = new System.Windows.Forms.Label();
            this.tableLayoutPanelTout = new System.Windows.Forms.TableLayoutPanel();
            this.lblHoraireDepartTout = new System.Windows.Forms.Label();
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
            this.grpAffichTout.Location = new System.Drawing.Point(235, 27);
            this.grpAffichTout.Name = "grpAffichTout";
            this.grpAffichTout.Size = new System.Drawing.Size(730, 410);
            this.grpAffichTout.TabIndex = 9;
            this.grpAffichTout.TabStop = false;
            this.grpAffichTout.Text = "Affichage Tout :";
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
            // lblDelaiPassageTout
            // 
            this.lblDelaiPassageTout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDelaiPassageTout.Location = new System.Drawing.Point(13, 53);
            this.lblDelaiPassageTout.Name = "lblDelaiPassageTout";
            this.lblDelaiPassageTout.Size = new System.Drawing.Size(162, 23);
            this.lblDelaiPassageTout.TabIndex = 6;
            this.lblDelaiPassageTout.Text = "Delai entre départ:";
            this.lblDelaiPassageTout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDernierPassageTout
            // 
            this.lblDernierPassageTout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDernierPassageTout.Location = new System.Drawing.Point(13, 83);
            this.lblDernierPassageTout.Name = "lblDernierPassageTout";
            this.lblDernierPassageTout.Size = new System.Drawing.Size(162, 23);
            this.lblDernierPassageTout.TabIndex = 5;
            this.lblDernierPassageTout.Text = "Horaire de fin: ";
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
            this.lblHoraireDepartTout.Text = "Horaire de départ:";
            this.lblHoraireDepartTout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmAffichage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 521);
            this.Controls.Add(this.grpAffichTout);
            this.Controls.Add(this.cmdChargement);
            this.Controls.Add(this.cmdRetour);
            this.Controls.Add(this.cboChoixTrajet);
            this.Controls.Add(this.lblChoixTrajet);
            this.Controls.Add(this.cboChoixLigneAff);
            this.Controls.Add(this.lblChoixLigne);
            this.Name = "frmAffichage";
            this.Text = "Affichage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAffichage_FormClosed);
            this.Load += new System.EventHandler(this.frm_Load);
            this.grpAffichTout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChoixLigne;
        private System.Windows.Forms.ComboBox cboChoixLigneAff;
        private System.Windows.Forms.ComboBox cboChoixTrajet;
        private System.Windows.Forms.Label lblChoixTrajet;
        private System.Windows.Forms.Button cmdRetour;
        private System.Windows.Forms.Button cmdChargement;
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