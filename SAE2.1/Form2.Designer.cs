﻿
namespace SAE2._1
{
    partial class frmModification
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
            this.cmdModif = new System.Windows.Forms.Button();
            this.cmdSupp = new System.Windows.Forms.Button();
            this.cmdAjouter = new System.Windows.Forms.Button();
            this.grpModif = new System.Windows.Forms.GroupBox();
            this.lblOrdre = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHoraire = new System.Windows.Forms.Label();
            this.cmdValider = new System.Windows.Forms.Button();
            this.lblNomArret = new System.Windows.Forms.Label();
            this.lblNArret = new System.Windows.Forms.Label();
            this.cmdRetour = new System.Windows.Forms.Button();
            this.cboChoixLigneModif = new System.Windows.Forms.ComboBox();
            this.cboChoixTrajet = new System.Windows.Forms.ComboBox();
            this.lblTypeTrajet = new System.Windows.Forms.Label();
            this.rbLigneExistante = new System.Windows.Forms.RadioButton();
            this.rbNouvelleLigne = new System.Windows.Forms.RadioButton();
            this.grpPreAjouter = new System.Windows.Forms.GroupBox();
            this.cmdAnnulerAjouter = new System.Windows.Forms.Button();
            this.cmdValiderAjouter = new System.Windows.Forms.Button();
            this.lblTypeTrajetAdd = new System.Windows.Forms.Label();
            this.cboTypeTrajetAjout = new System.Windows.Forms.ComboBox();
            this.txtbNvlLigne = new System.Windows.Forms.TextBox();
            this.cboLigneExistante = new System.Windows.Forms.ComboBox();
            this.grpAjouter = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblResumerAjout = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblOrdrePassage1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdRemove = new System.Windows.Forms.Button();
            this.cmdAnnulerAjt = new System.Windows.Forms.Button();
            this.grpModif.SuspendLayout();
            this.grpPreAjouter.SuspendLayout();
            this.grpAjouter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblChoixLigne
            // 
            this.lblChoixLigne.AutoSize = true;
            this.lblChoixLigne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoixLigne.Location = new System.Drawing.Point(66, 70);
            this.lblChoixLigne.Name = "lblChoixLigne";
            this.lblChoixLigne.Size = new System.Drawing.Size(125, 20);
            this.lblChoixLigne.TabIndex = 0;
            this.lblChoixLigne.Text = "Choisir une ligne";
            // 
            // cmdModif
            // 
            this.cmdModif.Enabled = false;
            this.cmdModif.Location = new System.Drawing.Point(50, 187);
            this.cmdModif.Name = "cmdModif";
            this.cmdModif.Size = new System.Drawing.Size(75, 23);
            this.cmdModif.TabIndex = 2;
            this.cmdModif.Text = "Modifier";
            this.cmdModif.UseVisualStyleBackColor = true;
            this.cmdModif.Click += new System.EventHandler(this.cmdModif_Click);
            // 
            // cmdSupp
            // 
            this.cmdSupp.Enabled = false;
            this.cmdSupp.Location = new System.Drawing.Point(131, 187);
            this.cmdSupp.Name = "cmdSupp";
            this.cmdSupp.Size = new System.Drawing.Size(75, 23);
            this.cmdSupp.TabIndex = 3;
            this.cmdSupp.Text = "Supprimer";
            this.cmdSupp.UseVisualStyleBackColor = true;
            this.cmdSupp.Click += new System.EventHandler(this.cmdSupp_Click);
            // 
            // cmdAjouter
            // 
            this.cmdAjouter.Location = new System.Drawing.Point(52, 227);
            this.cmdAjouter.Name = "cmdAjouter";
            this.cmdAjouter.Size = new System.Drawing.Size(154, 23);
            this.cmdAjouter.TabIndex = 4;
            this.cmdAjouter.Text = "Ajouter une ligne ";
            this.cmdAjouter.UseVisualStyleBackColor = true;
            this.cmdAjouter.Click += new System.EventHandler(this.cmdAjouter_Click);
            // 
            // grpModif
            // 
            this.grpModif.Controls.Add(this.grpAjouter);
            this.grpModif.Controls.Add(this.lblOrdre);
            this.grpModif.Controls.Add(this.tableLayoutPanel1);
            this.grpModif.Controls.Add(this.lblHoraire);
            this.grpModif.Controls.Add(this.cmdValider);
            this.grpModif.Controls.Add(this.lblNomArret);
            this.grpModif.Controls.Add(this.lblNArret);
            this.grpModif.Location = new System.Drawing.Point(262, 12);
            this.grpModif.Name = "grpModif";
            this.grpModif.Size = new System.Drawing.Size(730, 410);
            this.grpModif.TabIndex = 5;
            this.grpModif.TabStop = false;
            this.grpModif.Text = "Modification :";
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
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
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
            // cmdRetour
            // 
            this.cmdRetour.Location = new System.Drawing.Point(465, 443);
            this.cmdRetour.Name = "cmdRetour";
            this.cmdRetour.Size = new System.Drawing.Size(75, 23);
            this.cmdRetour.TabIndex = 6;
            this.cmdRetour.Text = "Retour";
            this.cmdRetour.UseVisualStyleBackColor = true;
            // 
            // cboChoixLigneModif
            // 
            this.cboChoixLigneModif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChoixLigneModif.FormattingEnabled = true;
            this.cboChoixLigneModif.Location = new System.Drawing.Point(70, 96);
            this.cboChoixLigneModif.Name = "cboChoixLigneModif";
            this.cboChoixLigneModif.Size = new System.Drawing.Size(121, 21);
            this.cboChoixLigneModif.TabIndex = 7;
            this.cboChoixLigneModif.SelectedIndexChanged += new System.EventHandler(this.cboChoixLigneModif_SelectedIndexChanged);
            // 
            // cboChoixTrajet
            // 
            this.cboChoixTrajet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChoixTrajet.FormattingEnabled = true;
            this.cboChoixTrajet.Location = new System.Drawing.Point(70, 156);
            this.cboChoixTrajet.Name = "cboChoixTrajet";
            this.cboChoixTrajet.Size = new System.Drawing.Size(121, 21);
            this.cboChoixTrajet.TabIndex = 9;
            this.cboChoixTrajet.SelectedIndexChanged += new System.EventHandler(this.cboChoixLigneModif_SelectedIndexChanged);
            // 
            // lblTypeTrajet
            // 
            this.lblTypeTrajet.AutoSize = true;
            this.lblTypeTrajet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeTrajet.Location = new System.Drawing.Point(45, 130);
            this.lblTypeTrajet.Name = "lblTypeTrajet";
            this.lblTypeTrajet.Size = new System.Drawing.Size(169, 20);
            this.lblTypeTrajet.TabIndex = 8;
            this.lblTypeTrajet.Text = "Choisir le type de trajet";
            // 
            // rbLigneExistante
            // 
            this.rbLigneExistante.AutoSize = true;
            this.rbLigneExistante.Checked = true;
            this.rbLigneExistante.Location = new System.Drawing.Point(12, 19);
            this.rbLigneExistante.Name = "rbLigneExistante";
            this.rbLigneExistante.Size = new System.Drawing.Size(97, 17);
            this.rbLigneExistante.TabIndex = 11;
            this.rbLigneExistante.TabStop = true;
            this.rbLigneExistante.Text = "Ligne Existante";
            this.rbLigneExistante.UseVisualStyleBackColor = true;
            this.rbLigneExistante.CheckedChanged += new System.EventHandler(this.rbLigneExistante_CheckedChanged);
            // 
            // rbNouvelleLigne
            // 
            this.rbNouvelleLigne.AutoSize = true;
            this.rbNouvelleLigne.Location = new System.Drawing.Point(10, 69);
            this.rbNouvelleLigne.Name = "rbNouvelleLigne";
            this.rbNouvelleLigne.Size = new System.Drawing.Size(96, 17);
            this.rbNouvelleLigne.TabIndex = 12;
            this.rbNouvelleLigne.Text = "Nouvelle Ligne";
            this.rbNouvelleLigne.UseVisualStyleBackColor = true;
            this.rbNouvelleLigne.CheckedChanged += new System.EventHandler(this.rbNouvelleLigne_CheckedChanged);
            // 
            // grpPreAjouter
            // 
            this.grpPreAjouter.Controls.Add(this.cmdAnnulerAjouter);
            this.grpPreAjouter.Controls.Add(this.cmdValiderAjouter);
            this.grpPreAjouter.Controls.Add(this.lblTypeTrajetAdd);
            this.grpPreAjouter.Controls.Add(this.cboTypeTrajetAjout);
            this.grpPreAjouter.Controls.Add(this.txtbNvlLigne);
            this.grpPreAjouter.Controls.Add(this.cboLigneExistante);
            this.grpPreAjouter.Controls.Add(this.rbLigneExistante);
            this.grpPreAjouter.Controls.Add(this.rbNouvelleLigne);
            this.grpPreAjouter.Location = new System.Drawing.Point(52, 267);
            this.grpPreAjouter.Name = "grpPreAjouter";
            this.grpPreAjouter.Size = new System.Drawing.Size(154, 242);
            this.grpPreAjouter.TabIndex = 9;
            this.grpPreAjouter.TabStop = false;
            this.grpPreAjouter.Text = "groupBox1";
            this.grpPreAjouter.Visible = false;
            // 
            // cmdAnnulerAjouter
            // 
            this.cmdAnnulerAjouter.Location = new System.Drawing.Point(34, 213);
            this.cmdAnnulerAjouter.Name = "cmdAnnulerAjouter";
            this.cmdAnnulerAjouter.Size = new System.Drawing.Size(75, 23);
            this.cmdAnnulerAjouter.TabIndex = 18;
            this.cmdAnnulerAjouter.Text = "Annuler";
            this.cmdAnnulerAjouter.UseVisualStyleBackColor = true;
            this.cmdAnnulerAjouter.Click += new System.EventHandler(this.cmdAnnuler_Click);
            // 
            // cmdValiderAjouter
            // 
            this.cmdValiderAjouter.Location = new System.Drawing.Point(34, 184);
            this.cmdValiderAjouter.Name = "cmdValiderAjouter";
            this.cmdValiderAjouter.Size = new System.Drawing.Size(75, 23);
            this.cmdValiderAjouter.TabIndex = 17;
            this.cmdValiderAjouter.Text = "Valider";
            this.cmdValiderAjouter.UseVisualStyleBackColor = true;
            this.cmdValiderAjouter.Click += new System.EventHandler(this.cmdValiderAjouter_Click);
            // 
            // lblTypeTrajetAdd
            // 
            this.lblTypeTrajetAdd.AutoSize = true;
            this.lblTypeTrajetAdd.Location = new System.Drawing.Point(9, 126);
            this.lblTypeTrajetAdd.Name = "lblTypeTrajetAdd";
            this.lblTypeTrajetAdd.Size = new System.Drawing.Size(72, 13);
            this.lblTypeTrajetAdd.TabIndex = 16;
            this.lblTypeTrajetAdd.Text = "Type de trajet";
            // 
            // cboTypeTrajetAjout
            // 
            this.cboTypeTrajetAjout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypeTrajetAjout.FormattingEnabled = true;
            this.cboTypeTrajetAjout.Location = new System.Drawing.Point(12, 143);
            this.cboTypeTrajetAjout.Name = "cboTypeTrajetAjout";
            this.cboTypeTrajetAjout.Size = new System.Drawing.Size(121, 21);
            this.cboTypeTrajetAjout.TabIndex = 15;
            // 
            // txtbNvlLigne
            // 
            this.txtbNvlLigne.Enabled = false;
            this.txtbNvlLigne.Location = new System.Drawing.Point(12, 92);
            this.txtbNvlLigne.Name = "txtbNvlLigne";
            this.txtbNvlLigne.Size = new System.Drawing.Size(121, 20);
            this.txtbNvlLigne.TabIndex = 14;
            this.txtbNvlLigne.Tag = "Saisir le nom de la ligne";
            this.txtbNvlLigne.Text = "Saisir le nom de la ligne";
            this.txtbNvlLigne.Enter += new System.EventHandler(this.txtbNvlLigne_Enter);
            this.txtbNvlLigne.Leave += new System.EventHandler(this.txtbNvlLigne_Leave);
            // 
            // cboLigneExistante
            // 
            this.cboLigneExistante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLigneExistante.FormattingEnabled = true;
            this.cboLigneExistante.Location = new System.Drawing.Point(12, 42);
            this.cboLigneExistante.Name = "cboLigneExistante";
            this.cboLigneExistante.Size = new System.Drawing.Size(121, 21);
            this.cboLigneExistante.TabIndex = 13;
            // 
            // grpAjouter
            // 
            this.grpAjouter.Controls.Add(this.cmdAnnulerAjt);
            this.grpAjouter.Controls.Add(this.cmdRemove);
            this.grpAjouter.Controls.Add(this.cmdAdd);
            this.grpAjouter.Controls.Add(this.lblOrdrePassage1);
            this.grpAjouter.Controls.Add(this.textBox2);
            this.grpAjouter.Controls.Add(this.comboBox1);
            this.grpAjouter.Controls.Add(this.label1);
            this.grpAjouter.Controls.Add(this.textBox1);
            this.grpAjouter.Controls.Add(this.lblResumerAjout);
            this.grpAjouter.Controls.Add(this.button1);
            this.grpAjouter.Location = new System.Drawing.Point(0, 0);
            this.grpAjouter.Name = "grpAjouter";
            this.grpAjouter.Size = new System.Drawing.Size(730, 410);
            this.grpAjouter.TabIndex = 9;
            this.grpAjouter.TabStop = false;
            this.grpAjouter.Text = "Ajouter :";
            this.grpAjouter.Visible = false;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(649, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblResumerAjout
            // 
            this.lblResumerAjout.AutoSize = true;
            this.lblResumerAjout.Location = new System.Drawing.Point(10, 23);
            this.lblResumerAjout.Name = "lblResumerAjout";
            this.lblResumerAjout.Size = new System.Drawing.Size(0, 13);
            this.lblResumerAjout.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Délai départ";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(237, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // lblOrdrePassage1
            // 
            this.lblOrdrePassage1.AutoSize = true;
            this.lblOrdrePassage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrdrePassage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdrePassage1.Location = new System.Drawing.Point(213, 60);
            this.lblOrdrePassage1.Name = "lblOrdrePassage1";
            this.lblOrdrePassage1.Size = new System.Drawing.Size(18, 20);
            this.lblOrdrePassage1.TabIndex = 15;
            this.lblOrdrePassage1.Text = "1";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(418, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(70, 21);
            this.textBox2.TabIndex = 14;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Enabled = false;
            this.cmdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.cmdAdd.Location = new System.Drawing.Point(494, 58);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(18, 22);
            this.cmdAdd.TabIndex = 16;
            this.cmdAdd.Text = "+";
            this.cmdAdd.UseVisualStyleBackColor = true;
            // 
            // cmdRemove
            // 
            this.cmdRemove.Enabled = false;
            this.cmdRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.cmdRemove.Location = new System.Drawing.Point(517, 58);
            this.cmdRemove.Name = "cmdRemove";
            this.cmdRemove.Size = new System.Drawing.Size(18, 22);
            this.cmdRemove.TabIndex = 17;
            this.cmdRemove.Text = "-";
            this.cmdRemove.UseVisualStyleBackColor = true;
            // 
            // cmdAnnulerAjt
            // 
            this.cmdAnnulerAjt.Location = new System.Drawing.Point(568, 381);
            this.cmdAnnulerAjt.Name = "cmdAnnulerAjt";
            this.cmdAnnulerAjt.Size = new System.Drawing.Size(75, 23);
            this.cmdAnnulerAjt.TabIndex = 19;
            this.cmdAnnulerAjt.Text = "Annuler";
            this.cmdAnnulerAjt.UseVisualStyleBackColor = true;
            this.cmdAnnulerAjt.Click += new System.EventHandler(this.cmdAnnuler_Click);
            // 
            // frmModification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 521);
            this.Controls.Add(this.grpPreAjouter);
            this.Controls.Add(this.cboChoixTrajet);
            this.Controls.Add(this.lblTypeTrajet);
            this.Controls.Add(this.cboChoixLigneModif);
            this.Controls.Add(this.cmdRetour);
            this.Controls.Add(this.grpModif);
            this.Controls.Add(this.cmdAjouter);
            this.Controls.Add(this.cmdSupp);
            this.Controls.Add(this.cmdModif);
            this.Controls.Add(this.lblChoixLigne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmModification";
            this.ShowIcon = false;
            this.Text = "Modification";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmModification_FormClosed);
            this.Load += new System.EventHandler(this.frmModification_Load);
            this.grpModif.ResumeLayout(false);
            this.grpPreAjouter.ResumeLayout(false);
            this.grpPreAjouter.PerformLayout();
            this.grpAjouter.ResumeLayout(false);
            this.grpAjouter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChoixLigne;
        private System.Windows.Forms.Button cmdModif;
        private System.Windows.Forms.Button cmdSupp;
        private System.Windows.Forms.Button cmdAjouter;
        private System.Windows.Forms.GroupBox grpModif;
        private System.Windows.Forms.Button cmdValider;
        private System.Windows.Forms.Button cmdRetour;
        private System.Windows.Forms.ComboBox cboChoixLigneModif;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblOrdre;
        private System.Windows.Forms.Label lblHoraire;
        private System.Windows.Forms.Label lblNomArret;
        private System.Windows.Forms.Label lblNArret;
        private System.Windows.Forms.ComboBox cboChoixTrajet;
        private System.Windows.Forms.Label lblTypeTrajet;
        private System.Windows.Forms.RadioButton rbLigneExistante;
        private System.Windows.Forms.RadioButton rbNouvelleLigne;
        private System.Windows.Forms.GroupBox grpPreAjouter;
        private System.Windows.Forms.TextBox txtbNvlLigne;
        private System.Windows.Forms.ComboBox cboLigneExistante;
        private System.Windows.Forms.Label lblTypeTrajetAdd;
        private System.Windows.Forms.ComboBox cboTypeTrajetAjout;
        private System.Windows.Forms.Button cmdAnnulerAjouter;
        private System.Windows.Forms.Button cmdValiderAjouter;
        private System.Windows.Forms.GroupBox grpAjouter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdRemove;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Label lblOrdrePassage1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblResumerAjout;
        private System.Windows.Forms.Button cmdAnnulerAjt;
    }
}