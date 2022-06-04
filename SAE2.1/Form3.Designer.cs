
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
            this.grpAffich = new System.Windows.Forms.GroupBox();
            this.lblOrdre = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHoraire = new System.Windows.Forms.Label();
            this.lblNomArret = new System.Windows.Forms.Label();
            this.lblNArret = new System.Windows.Forms.Label();
            this.cmdRetour = new System.Windows.Forms.Button();
            this.grpAffich.SuspendLayout();
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
            this.cboChoixLigneAff.SelectedIndexChanged += new System.EventHandler(this.cboChoixLigneAff_SelectedIndexChanged);
            // 
            // cboChoixTrajet
            // 
            this.cboChoixTrajet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChoixTrajet.FormattingEnabled = true;
            this.cboChoixTrajet.Location = new System.Drawing.Point(70, 158);
            this.cboChoixTrajet.Name = "cboChoixTrajet";
            this.cboChoixTrajet.Size = new System.Drawing.Size(121, 21);
            this.cboChoixTrajet.TabIndex = 4;
            // 
            // lblChoixTrajet
            // 
            this.lblChoixTrajet.AutoSize = true;
            this.lblChoixTrajet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoixTrajet.Location = new System.Drawing.Point(66, 132);
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
            // 
            // cboAffichage
            // 
            this.cboAffichage.AutoSize = true;
            this.cboAffichage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAffichage.Location = new System.Drawing.Point(66, 200);
            this.cboAffichage.Name = "cboAffichage";
            this.cboAffichage.Size = new System.Drawing.Size(195, 20);
            this.cboAffichage.TabIndex = 5;
            this.cboAffichage.Text = "Choisir un type d\'affichage";
            // 
            // grpAffich
            // 
            this.grpAffich.Controls.Add(this.lblOrdre);
            this.grpAffich.Controls.Add(this.tableLayoutPanel1);
            this.grpAffich.Controls.Add(this.lblHoraire);
            this.grpAffich.Controls.Add(this.lblNomArret);
            this.grpAffich.Controls.Add(this.lblNArret);
            this.grpAffich.Location = new System.Drawing.Point(262, 12);
            this.grpAffich.Name = "grpAffich";
            this.grpAffich.Size = new System.Drawing.Size(730, 410);
            this.grpAffich.TabIndex = 7;
            this.grpAffich.TabStop = false;
            this.grpAffich.Text = "Affichage horaire :";
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
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.39683F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.82973F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.26263F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.79942F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 358F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 358F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(711, 355);
            this.tableLayoutPanel1.TabIndex = 8;
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
            // frmAffichage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 521);
            this.Controls.Add(this.cmdRetour);
            this.Controls.Add(this.grpAffich);
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
            this.grpAffich.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox grpAffich;
        private System.Windows.Forms.Label lblOrdre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblHoraire;
        private System.Windows.Forms.Label lblNomArret;
        private System.Windows.Forms.Label lblNArret;
        private System.Windows.Forms.Button cmdRetour;
    }
}