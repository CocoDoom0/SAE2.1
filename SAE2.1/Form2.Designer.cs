
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
            this.grpAjouter = new System.Windows.Forms.GroupBox();
            this.cmdAnnulerAjt = new System.Windows.Forms.Button();
            this.cmdRemove = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.lblOrdrePassage1 = new System.Windows.Forms.Label();
            this.txtbChoixDelai1 = new System.Windows.Forms.TextBox();
            this.cboChoixArret1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblResumerAjout = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.grpModif.SuspendLayout();
            this.grpAjouter.SuspendLayout();
            this.grpPreAjouter.SuspendLayout();
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
            this.lblChoixLigne.TabIndex = 0;
            this.lblChoixLigne.Text = "Choisir une ligne";
            // 
            // cmdModif
            // 
            this.cmdModif.Enabled = false;
            this.cmdModif.Location = new System.Drawing.Point(67, 230);
            this.cmdModif.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdModif.Name = "cmdModif";
            this.cmdModif.Size = new System.Drawing.Size(100, 28);
            this.cmdModif.TabIndex = 2;
            this.cmdModif.Text = "Modifier";
            this.cmdModif.UseVisualStyleBackColor = true;
            this.cmdModif.Click += new System.EventHandler(this.cmdModif_Click);
            // 
            // cmdSupp
            // 
            this.cmdSupp.Enabled = false;
            this.cmdSupp.Location = new System.Drawing.Point(175, 230);
            this.cmdSupp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdSupp.Name = "cmdSupp";
            this.cmdSupp.Size = new System.Drawing.Size(100, 28);
            this.cmdSupp.TabIndex = 3;
            this.cmdSupp.Text = "Supprimer";
            this.cmdSupp.UseVisualStyleBackColor = true;
            this.cmdSupp.Click += new System.EventHandler(this.cmdSupp_Click);
            // 
            // cmdAjouter
            // 
            this.cmdAjouter.Location = new System.Drawing.Point(69, 279);
            this.cmdAjouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdAjouter.Name = "cmdAjouter";
            this.cmdAjouter.Size = new System.Drawing.Size(205, 28);
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
            this.grpModif.Location = new System.Drawing.Point(349, 15);
            this.grpModif.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpModif.Name = "grpModif";
            this.grpModif.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpModif.Size = new System.Drawing.Size(973, 505);
            this.grpModif.TabIndex = 5;
            this.grpModif.TabStop = false;
            this.grpModif.Text = "Modification :";
            // 
            // grpAjouter
            // 
            this.grpAjouter.Controls.Add(this.cmdAnnulerAjt);
            this.grpAjouter.Controls.Add(this.cmdRemove);
            this.grpAjouter.Controls.Add(this.cmdAdd);
            this.grpAjouter.Controls.Add(this.lblOrdrePassage1);
            this.grpAjouter.Controls.Add(this.txtbChoixDelai1);
            this.grpAjouter.Controls.Add(this.cboChoixArret1);
            this.grpAjouter.Controls.Add(this.label1);
            this.grpAjouter.Controls.Add(this.textBox1);
            this.grpAjouter.Controls.Add(this.lblResumerAjout);
            this.grpAjouter.Controls.Add(this.button1);
            this.grpAjouter.Location = new System.Drawing.Point(0, 0);
            this.grpAjouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAjouter.Name = "grpAjouter";
            this.grpAjouter.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAjouter.Size = new System.Drawing.Size(973, 505);
            this.grpAjouter.TabIndex = 9;
            this.grpAjouter.TabStop = false;
            this.grpAjouter.Text = "Ajouter :";
            this.grpAjouter.Visible = false;
            // 
            // cmdAnnulerAjt
            // 
            this.cmdAnnulerAjt.Location = new System.Drawing.Point(757, 469);
            this.cmdAnnulerAjt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdAnnulerAjt.Name = "cmdAnnulerAjt";
            this.cmdAnnulerAjt.Size = new System.Drawing.Size(100, 28);
            this.cmdAnnulerAjt.TabIndex = 19;
            this.cmdAnnulerAjt.Text = "Annuler";
            this.cmdAnnulerAjt.UseVisualStyleBackColor = true;
            this.cmdAnnulerAjt.Click += new System.EventHandler(this.cmdAnnuler_Click);
            // 
            // cmdRemove
            // 
            this.cmdRemove.Enabled = false;
            this.cmdRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.cmdRemove.Location = new System.Drawing.Point(689, 71);
            this.cmdRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdRemove.Name = "cmdRemove";
            this.cmdRemove.Size = new System.Drawing.Size(24, 27);
            this.cmdRemove.TabIndex = 17;
            this.cmdRemove.Text = "-";
            this.cmdRemove.UseVisualStyleBackColor = true;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Enabled = false;
            this.cmdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.cmdAdd.Location = new System.Drawing.Point(659, 71);
            this.cmdAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(24, 27);
            this.cmdAdd.TabIndex = 16;
            this.cmdAdd.Text = "+";
            this.cmdAdd.UseVisualStyleBackColor = true;
            // 
            // lblOrdrePassage1
            // 
            this.lblOrdrePassage1.AutoSize = true;
            this.lblOrdrePassage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrdrePassage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdrePassage1.Location = new System.Drawing.Point(284, 74);
            this.lblOrdrePassage1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrdrePassage1.Name = "lblOrdrePassage1";
            this.lblOrdrePassage1.Size = new System.Drawing.Size(22, 26);
            this.lblOrdrePassage1.TabIndex = 15;
            this.lblOrdrePassage1.Text = "1";
            // 
            // txtbChoixDelai1
            // 
            this.txtbChoixDelai1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbChoixDelai1.Location = new System.Drawing.Point(557, 73);
            this.txtbChoixDelai1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbChoixDelai1.Name = "txtbChoixDelai1";
            this.txtbChoixDelai1.Size = new System.Drawing.Size(92, 24);
            this.txtbChoixDelai1.TabIndex = 14;
            // 
            // cboChoixArret1
            // 
            this.cboChoixArret1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChoixArret1.FormattingEnabled = true;
            this.cboChoixArret1.Location = new System.Drawing.Point(316, 73);
            this.cboChoixArret1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboChoixArret1.Name = "cboChoixArret1";
            this.cboChoixArret1.Size = new System.Drawing.Size(232, 24);
            this.cboChoixArret1.TabIndex = 13;
            this.cboChoixArret1.SelectedIndexChanged += new System.EventHandler(this.cboChoixArret_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Délai départ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 74);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 11;
            // 
            // lblResumerAjout
            // 
            this.lblResumerAjout.AutoSize = true;
            this.lblResumerAjout.Location = new System.Drawing.Point(13, 28);
            this.lblResumerAjout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResumerAjout.Name = "lblResumerAjout";
            this.lblResumerAjout.Size = new System.Drawing.Size(0, 16);
            this.lblResumerAjout.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(865, 469);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 6;
            this.button1.Tag = "1";
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
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
            this.cmdRetour.TabIndex = 6;
            this.cmdRetour.Text = "Retour";
            this.cmdRetour.UseVisualStyleBackColor = true;
            this.cmdRetour.Click += new System.EventHandler(this.clickRetour);
            // 
            // cboChoixLigneModif
            // 
            this.cboChoixLigneModif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChoixLigneModif.FormattingEnabled = true;
            this.cboChoixLigneModif.Location = new System.Drawing.Point(93, 118);
            this.cboChoixLigneModif.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboChoixLigneModif.Name = "cboChoixLigneModif";
            this.cboChoixLigneModif.Size = new System.Drawing.Size(160, 24);
            this.cboChoixLigneModif.TabIndex = 7;
            this.cboChoixLigneModif.SelectedIndexChanged += new System.EventHandler(this.cboChoixLigneModif_SelectedIndexChanged);
            // 
            // cboChoixTrajet
            // 
            this.cboChoixTrajet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChoixTrajet.FormattingEnabled = true;
            this.cboChoixTrajet.Location = new System.Drawing.Point(93, 192);
            this.cboChoixTrajet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboChoixTrajet.Name = "cboChoixTrajet";
            this.cboChoixTrajet.Size = new System.Drawing.Size(160, 24);
            this.cboChoixTrajet.TabIndex = 9;
            this.cboChoixTrajet.SelectedIndexChanged += new System.EventHandler(this.cboChoixLigneModif_SelectedIndexChanged);
            // 
            // lblTypeTrajet
            // 
            this.lblTypeTrajet.AutoSize = true;
            this.lblTypeTrajet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeTrajet.Location = new System.Drawing.Point(60, 160);
            this.lblTypeTrajet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeTrajet.Name = "lblTypeTrajet";
            this.lblTypeTrajet.Size = new System.Drawing.Size(209, 25);
            this.lblTypeTrajet.TabIndex = 8;
            this.lblTypeTrajet.Text = "Choisir le type de trajet";
            // 
            // rbLigneExistante
            // 
            this.rbLigneExistante.AutoSize = true;
            this.rbLigneExistante.Checked = true;
            this.rbLigneExistante.Location = new System.Drawing.Point(16, 23);
            this.rbLigneExistante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbLigneExistante.Name = "rbLigneExistante";
            this.rbLigneExistante.Size = new System.Drawing.Size(118, 20);
            this.rbLigneExistante.TabIndex = 11;
            this.rbLigneExistante.TabStop = true;
            this.rbLigneExistante.Text = "Ligne Existante";
            this.rbLigneExistante.UseVisualStyleBackColor = true;
            this.rbLigneExistante.CheckedChanged += new System.EventHandler(this.rbLigneExistante_CheckedChanged);
            // 
            // rbNouvelleLigne
            // 
            this.rbNouvelleLigne.AutoSize = true;
            this.rbNouvelleLigne.Location = new System.Drawing.Point(13, 85);
            this.rbNouvelleLigne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbNouvelleLigne.Name = "rbNouvelleLigne";
            this.rbNouvelleLigne.Size = new System.Drawing.Size(118, 20);
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
            this.grpPreAjouter.Location = new System.Drawing.Point(69, 329);
            this.grpPreAjouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPreAjouter.Name = "grpPreAjouter";
            this.grpPreAjouter.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPreAjouter.Size = new System.Drawing.Size(205, 298);
            this.grpPreAjouter.TabIndex = 9;
            this.grpPreAjouter.TabStop = false;
            this.grpPreAjouter.Text = "groupBox1";
            this.grpPreAjouter.Visible = false;
            // 
            // cmdAnnulerAjouter
            // 
            this.cmdAnnulerAjouter.Location = new System.Drawing.Point(45, 262);
            this.cmdAnnulerAjouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdAnnulerAjouter.Name = "cmdAnnulerAjouter";
            this.cmdAnnulerAjouter.Size = new System.Drawing.Size(100, 28);
            this.cmdAnnulerAjouter.TabIndex = 18;
            this.cmdAnnulerAjouter.Text = "Annuler";
            this.cmdAnnulerAjouter.UseVisualStyleBackColor = true;
            this.cmdAnnulerAjouter.Click += new System.EventHandler(this.cmdAnnuler_Click);
            // 
            // cmdValiderAjouter
            // 
            this.cmdValiderAjouter.Location = new System.Drawing.Point(45, 226);
            this.cmdValiderAjouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdValiderAjouter.Name = "cmdValiderAjouter";
            this.cmdValiderAjouter.Size = new System.Drawing.Size(100, 28);
            this.cmdValiderAjouter.TabIndex = 17;
            this.cmdValiderAjouter.Text = "Valider";
            this.cmdValiderAjouter.UseVisualStyleBackColor = true;
            this.cmdValiderAjouter.Click += new System.EventHandler(this.cmdValiderAjouter_Click);
            // 
            // lblTypeTrajetAdd
            // 
            this.lblTypeTrajetAdd.AutoSize = true;
            this.lblTypeTrajetAdd.Location = new System.Drawing.Point(12, 155);
            this.lblTypeTrajetAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeTrajetAdd.Name = "lblTypeTrajetAdd";
            this.lblTypeTrajetAdd.Size = new System.Drawing.Size(90, 16);
            this.lblTypeTrajetAdd.TabIndex = 16;
            this.lblTypeTrajetAdd.Text = "Type de trajet";
            // 
            // cboTypeTrajetAjout
            // 
            this.cboTypeTrajetAjout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypeTrajetAjout.FormattingEnabled = true;
            this.cboTypeTrajetAjout.Location = new System.Drawing.Point(16, 176);
            this.cboTypeTrajetAjout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTypeTrajetAjout.Name = "cboTypeTrajetAjout";
            this.cboTypeTrajetAjout.Size = new System.Drawing.Size(160, 24);
            this.cboTypeTrajetAjout.TabIndex = 15;
            // 
            // txtbNvlLigne
            // 
            this.txtbNvlLigne.Enabled = false;
            this.txtbNvlLigne.Location = new System.Drawing.Point(16, 113);
            this.txtbNvlLigne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbNvlLigne.Name = "txtbNvlLigne";
            this.txtbNvlLigne.Size = new System.Drawing.Size(160, 22);
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
            this.cboLigneExistante.Location = new System.Drawing.Point(16, 52);
            this.cboLigneExistante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboLigneExistante.Name = "cboLigneExistante";
            this.cboLigneExistante.Size = new System.Drawing.Size(160, 24);
            this.cboLigneExistante.TabIndex = 13;
            // 
            // frmModification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 641);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmModification";
            this.ShowIcon = false;
            this.Text = "Modification";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmModification_FormClosed);
            this.Load += new System.EventHandler(this.frmModification_Load);
            this.grpModif.ResumeLayout(false);
            this.grpAjouter.ResumeLayout(false);
            this.grpAjouter.PerformLayout();
            this.grpPreAjouter.ResumeLayout(false);
            this.grpPreAjouter.PerformLayout();
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
        private System.Windows.Forms.TextBox txtbChoixDelai1;
        private System.Windows.Forms.ComboBox cboChoixArret1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblResumerAjout;
        private System.Windows.Forms.Button cmdAnnulerAjt;
    }
}