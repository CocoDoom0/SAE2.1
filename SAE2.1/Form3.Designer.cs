
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
            this.cmdValider = new System.Windows.Forms.Button();
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
            this.lblChoixLigne.Location = new System.Drawing.Point(88, 86);
            this.lblChoixLigne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChoixLigne.Name = "lblChoixLigne";
            this.lblChoixLigne.Size = new System.Drawing.Size(157, 25);
            this.lblChoixLigne.TabIndex = 1;
            this.lblChoixLigne.Text = "Choisir une ligne";
            // 
            // cboChoixLigneAff
            // 
            this.cboChoixLigneAff.FormattingEnabled = true;
            this.cboChoixLigneAff.Location = new System.Drawing.Point(93, 118);
            this.cboChoixLigneAff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboChoixLigneAff.Name = "cboChoixLigneAff";
            this.cboChoixLigneAff.Size = new System.Drawing.Size(160, 24);
            this.cboChoixLigneAff.TabIndex = 2;
            this.cboChoixLigneAff.Text = "Choisir une ligne";
            this.cboChoixLigneAff.SelectedIndexChanged += new System.EventHandler(this.cboChoixLigneAff_SelectedIndexChanged);
            // 
            // cboChoixTrajet
            // 
            this.cboChoixTrajet.FormattingEnabled = true;
            this.cboChoixTrajet.Location = new System.Drawing.Point(93, 194);
            this.cboChoixTrajet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboChoixTrajet.Name = "cboChoixTrajet";
            this.cboChoixTrajet.Size = new System.Drawing.Size(160, 24);
            this.cboChoixTrajet.TabIndex = 4;
            this.cboChoixTrajet.Text = "Choisir un trajet";
            // 
            // lblChoixTrajet
            // 
            this.lblChoixTrajet.AutoSize = true;
            this.lblChoixTrajet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoixTrajet.Location = new System.Drawing.Point(88, 162);
            this.lblChoixTrajet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChoixTrajet.Name = "lblChoixTrajet";
            this.lblChoixTrajet.Size = new System.Drawing.Size(216, 25);
            this.lblChoixTrajet.TabIndex = 3;
            this.lblChoixTrajet.Text = "Choisir un type de trajet";
            // 
            // cboChoixAffich
            // 
            this.cboChoixAffich.FormattingEnabled = true;
            this.cboChoixAffich.Location = new System.Drawing.Point(93, 278);
            this.cboChoixAffich.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboChoixAffich.Name = "cboChoixAffich";
            this.cboChoixAffich.Size = new System.Drawing.Size(160, 24);
            this.cboChoixAffich.TabIndex = 6;
            this.cboChoixAffich.Text = "Choisir un affichage";
            // 
            // cboAffichage
            // 
            this.cboAffichage.AutoSize = true;
            this.cboAffichage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAffichage.Location = new System.Drawing.Point(88, 246);
            this.cboAffichage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cboAffichage.Name = "cboAffichage";
            this.cboAffichage.Size = new System.Drawing.Size(241, 25);
            this.cboAffichage.TabIndex = 5;
            this.cboAffichage.Text = "Choisir un type d\'affichage";
            // 
            // grpAffich
            // 
            this.grpAffich.Controls.Add(this.lblOrdre);
            this.grpAffich.Controls.Add(this.tableLayoutPanel1);
            this.grpAffich.Controls.Add(this.lblHoraire);
            this.grpAffich.Controls.Add(this.cmdValider);
            this.grpAffich.Controls.Add(this.lblNomArret);
            this.grpAffich.Controls.Add(this.lblNArret);
            this.grpAffich.Location = new System.Drawing.Point(349, 15);
            this.grpAffich.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAffich.Name = "grpAffich";
            this.grpAffich.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAffich.Size = new System.Drawing.Size(973, 505);
            this.grpAffich.TabIndex = 7;
            this.grpAffich.TabStop = false;
            this.grpAffich.Text = "Affichage horaire :";
            // 
            // lblOrdre
            // 
            this.lblOrdre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrdre.Location = new System.Drawing.Point(733, 28);
            this.lblOrdre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrdre.Name = "lblOrdre";
            this.lblOrdre.Size = new System.Drawing.Size(230, 28);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 60);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 438F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 438F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(965, 437);
            this.tableLayoutPanel1.TabIndex = 8;
            this.tableLayoutPanel1.Visible = false;
            // 
            // lblHoraire
            // 
            this.lblHoraire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHoraire.Location = new System.Drawing.Point(495, 28);
            this.lblHoraire.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraire.Name = "lblHoraire";
            this.lblHoraire.Size = new System.Drawing.Size(230, 28);
            this.lblHoraire.TabIndex = 2;
            this.lblHoraire.Text = "Horaire";
            this.lblHoraire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHoraire.Visible = false;
            // 
            // cmdValider
            // 
            this.cmdValider.Enabled = false;
            this.cmdValider.Location = new System.Drawing.Point(865, 469);
            this.cmdValider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdValider.Name = "cmdValider";
            this.cmdValider.Size = new System.Drawing.Size(100, 28);
            this.cmdValider.TabIndex = 6;
            this.cmdValider.Text = "Valider";
            this.cmdValider.UseVisualStyleBackColor = true;
            // 
            // lblNomArret
            // 
            this.lblNomArret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNomArret.Location = new System.Drawing.Point(256, 28);
            this.lblNomArret.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomArret.Name = "lblNomArret";
            this.lblNomArret.Size = new System.Drawing.Size(230, 28);
            this.lblNomArret.TabIndex = 1;
            this.lblNomArret.Text = "Nom Arret";
            this.lblNomArret.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNomArret.Visible = false;
            // 
            // lblNArret
            // 
            this.lblNArret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNArret.Location = new System.Drawing.Point(17, 28);
            this.lblNArret.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNArret.Name = "lblNArret";
            this.lblNArret.Size = new System.Drawing.Size(230, 28);
            this.lblNArret.TabIndex = 0;
            this.lblNArret.Text = "N°Arret";
            this.lblNArret.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNArret.Visible = false;
            // 
            // cmdRetour
            // 
            this.cmdRetour.Location = new System.Drawing.Point(620, 545);
            this.cmdRetour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdRetour.Name = "cmdRetour";
            this.cmdRetour.Size = new System.Drawing.Size(100, 28);
            this.cmdRetour.TabIndex = 8;
            this.cmdRetour.Text = "Retour";
            this.cmdRetour.UseVisualStyleBackColor = true;
            this.cmdRetour.Click += new System.EventHandler(this.clickRetour);
            // 
            // frmAffichage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 641);
            this.Controls.Add(this.cmdRetour);
            this.Controls.Add(this.grpAffich);
            this.Controls.Add(this.cboChoixAffich);
            this.Controls.Add(this.cboAffichage);
            this.Controls.Add(this.cboChoixTrajet);
            this.Controls.Add(this.lblChoixTrajet);
            this.Controls.Add(this.cboChoixLigneAff);
            this.Controls.Add(this.lblChoixLigne);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAffichage";
            this.Text = "Affichage";
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
        private System.Windows.Forms.Button cmdValider;
        private System.Windows.Forms.Label lblNomArret;
        private System.Windows.Forms.Label lblNArret;
        private System.Windows.Forms.Button cmdRetour;
    }
}