
namespace SAE2._1
{
    partial class frmRecherche
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
            this.tableLayoutPanelRecherche = new System.Windows.Forms.TableLayoutPanel();
            this.cmdValider = new System.Windows.Forms.Button();
            this.lblNomArret = new System.Windows.Forms.Label();
            this.lblNArret = new System.Windows.Forms.Label();
            this.cboChoixArretArr = new System.Windows.Forms.ComboBox();
            this.lblArretArr = new System.Windows.Forms.Label();
            this.cboChoixArretDep = new System.Windows.Forms.ComboBox();
            this.lblArretDep = new System.Windows.Forms.Label();
            this.cmdRetour = new System.Windows.Forms.Button();
            this.cmdRechercher = new System.Windows.Forms.Button();
            this.cboChoixLigne = new System.Windows.Forms.ComboBox();
            this.lblLigne = new System.Windows.Forms.Label();
            this.grpRecherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRecherche
            // 
            this.grpRecherche.Controls.Add(this.lblOrdre);
            this.grpRecherche.Controls.Add(this.tableLayoutPanelRecherche);
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
            this.lblOrdre.Location = new System.Drawing.Point(522, 23);
            this.lblOrdre.Name = "lblOrdre";
            this.lblOrdre.Size = new System.Drawing.Size(173, 23);
            this.lblOrdre.TabIndex = 3;
            this.lblOrdre.Text = "Ordre de passage";
            this.lblOrdre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelRecherche
            // 
            this.tableLayoutPanelRecherche.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelRecherche.AutoScroll = true;
            this.tableLayoutPanelRecherche.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelRecherche.ColumnCount = 3;
            this.tableLayoutPanelRecherche.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.08662F));
            this.tableLayoutPanelRecherche.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.80943F));
            this.tableLayoutPanelRecherche.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.05198F));
            this.tableLayoutPanelRecherche.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.05198F));
            this.tableLayoutPanelRecherche.Location = new System.Drawing.Point(6, 49);
            this.tableLayoutPanelRecherche.Name = "tableLayoutPanelRecherche";
            this.tableLayoutPanelRecherche.RowCount = 1;
            this.tableLayoutPanelRecherche.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 361F));
            this.tableLayoutPanelRecherche.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 361F));
            this.tableLayoutPanelRecherche.Size = new System.Drawing.Size(724, 355);
            this.tableLayoutPanelRecherche.TabIndex = 8;
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
            this.lblNomArret.Location = new System.Drawing.Point(274, 23);
            this.lblNomArret.Name = "lblNomArret";
            this.lblNomArret.Size = new System.Drawing.Size(173, 23);
            this.lblNomArret.TabIndex = 1;
            this.lblNomArret.Text = "Nom Arret";
            this.lblNomArret.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNArret
            // 
            this.lblNArret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNArret.Location = new System.Drawing.Point(42, 23);
            this.lblNArret.Name = "lblNArret";
            this.lblNArret.Size = new System.Drawing.Size(173, 23);
            this.lblNArret.TabIndex = 0;
            this.lblNArret.Text = "N°Arret";
            this.lblNArret.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboChoixArretArr
            // 
            this.cboChoixArretArr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChoixArretArr.FormattingEnabled = true;
            this.cboChoixArretArr.Location = new System.Drawing.Point(69, 228);
            this.cboChoixArretArr.Name = "cboChoixArretArr";
            this.cboChoixArretArr.Size = new System.Drawing.Size(121, 21);
            this.cboChoixArretArr.TabIndex = 12;
            this.cboChoixArretArr.SelectedIndexChanged += new System.EventHandler(this.cbo_SelectedIndexChanged);
            // 
            // lblArretArr
            // 
            this.lblArretArr.AutoSize = true;
            this.lblArretArr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArretArr.Location = new System.Drawing.Point(65, 205);
            this.lblArretArr.Name = "lblArretArr";
            this.lblArretArr.Size = new System.Drawing.Size(98, 20);
            this.lblArretArr.TabIndex = 11;
            this.lblArretArr.Text = "Arrêt d\'arrivé";
            // 
            // cboChoixArretDep
            // 
            this.cboChoixArretDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChoixArretDep.FormattingEnabled = true;
            this.cboChoixArretDep.Location = new System.Drawing.Point(69, 172);
            this.cboChoixArretDep.Name = "cboChoixArretDep";
            this.cboChoixArretDep.Size = new System.Drawing.Size(121, 21);
            this.cboChoixArretDep.TabIndex = 10;
            this.cboChoixArretDep.SelectedIndexChanged += new System.EventHandler(this.cbo_SelectedIndexChanged);
            // 
            // lblArretDep
            // 
            this.lblArretDep.AutoSize = true;
            this.lblArretDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArretDep.Location = new System.Drawing.Point(65, 149);
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
            this.cmdRetour.Click += new System.EventHandler(this.ClickRetour);
            // 
            // cmdRechercher
            // 
            this.cmdRechercher.Enabled = false;
            this.cmdRechercher.Location = new System.Drawing.Point(69, 264);
            this.cmdRechercher.Name = "cmdRechercher";
            this.cmdRechercher.Size = new System.Drawing.Size(121, 23);
            this.cmdRechercher.TabIndex = 14;
            this.cmdRechercher.Text = "Rechercher";
            this.cmdRechercher.UseVisualStyleBackColor = true;
            this.cmdRechercher.Click += new System.EventHandler(this.cmdRechercher_Click);
            // 
            // cboChoixLigne
            // 
            this.cboChoixLigne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChoixLigne.FormattingEnabled = true;
            this.cboChoixLigne.Location = new System.Drawing.Point(69, 98);
            this.cboChoixLigne.Name = "cboChoixLigne";
            this.cboChoixLigne.Size = new System.Drawing.Size(121, 21);
            this.cboChoixLigne.TabIndex = 15;
            this.cboChoixLigne.SelectedIndexChanged += new System.EventHandler(this.cbo_SelectedIndexChanged);
            // 
            // lblLigne
            // 
            this.lblLigne.AutoSize = true;
            this.lblLigne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLigne.Location = new System.Drawing.Point(65, 75);
            this.lblLigne.Name = "lblLigne";
            this.lblLigne.Size = new System.Drawing.Size(48, 20);
            this.lblLigne.TabIndex = 16;
            this.lblLigne.Text = "Ligne";
            // 
            // frmRecherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 521);
            this.Controls.Add(this.lblLigne);
            this.Controls.Add(this.cboChoixLigne);
            this.Controls.Add(this.cmdRechercher);
            this.Controls.Add(this.cmdRetour);
            this.Controls.Add(this.cboChoixArretArr);
            this.Controls.Add(this.grpRecherche);
            this.Controls.Add(this.lblArretArr);
            this.Controls.Add(this.lblArretDep);
            this.Controls.Add(this.cboChoixArretDep);
            this.Name = "frmRecherche";
            this.Text = "Recherche";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRecherche_FormClosed);
            this.Load += new System.EventHandler(this.frmRecherche_Load);
            this.grpRecherche.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRecherche;
        private System.Windows.Forms.Label lblOrdre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRecherche;
        private System.Windows.Forms.Button cmdValider;
        private System.Windows.Forms.Label lblNomArret;
        private System.Windows.Forms.Label lblNArret;
        private System.Windows.Forms.ComboBox cboChoixArretArr;
        private System.Windows.Forms.Label lblArretArr;
        private System.Windows.Forms.ComboBox cboChoixArretDep;
        private System.Windows.Forms.Label lblArretDep;
        private System.Windows.Forms.Button cmdRetour;
        private System.Windows.Forms.Button cmdRechercher;
        private System.Windows.Forms.ComboBox cboChoixLigne;
        private System.Windows.Forms.Label lblLigne;
    }
}