
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
            this.dudChoixLigne = new System.Windows.Forms.DomainUpDown();
            this.cmdModif = new System.Windows.Forms.Button();
            this.cmdSupp = new System.Windows.Forms.Button();
            this.cmdAjouter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdValider = new System.Windows.Forms.Button();
            this.cmdRetour = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
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
            // dudChoixLigne
            // 
            this.dudChoixLigne.Location = new System.Drawing.Point(71, 93);
            this.dudChoixLigne.Name = "dudChoixLigne";
            this.dudChoixLigne.Size = new System.Drawing.Size(120, 20);
            this.dudChoixLigne.TabIndex = 1;
            this.dudChoixLigne.Text = "N°Ligne";
            // 
            // cmdModif
            // 
            this.cmdModif.Location = new System.Drawing.Point(50, 153);
            this.cmdModif.Name = "cmdModif";
            this.cmdModif.Size = new System.Drawing.Size(75, 23);
            this.cmdModif.TabIndex = 2;
            this.cmdModif.Text = "Modifier";
            this.cmdModif.UseVisualStyleBackColor = true;
            // 
            // cmdSupp
            // 
            this.cmdSupp.Location = new System.Drawing.Point(131, 153);
            this.cmdSupp.Name = "cmdSupp";
            this.cmdSupp.Size = new System.Drawing.Size(75, 23);
            this.cmdSupp.TabIndex = 3;
            this.cmdSupp.Text = "Supprimer";
            this.cmdSupp.UseVisualStyleBackColor = true;
            // 
            // cmdAjouter
            // 
            this.cmdAjouter.Location = new System.Drawing.Point(52, 193);
            this.cmdAjouter.Name = "cmdAjouter";
            this.cmdAjouter.Size = new System.Drawing.Size(154, 23);
            this.cmdAjouter.TabIndex = 4;
            this.cmdAjouter.Text = "Ajouter une ligne ";
            this.cmdAjouter.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdValider);
            this.groupBox1.Location = new System.Drawing.Point(262, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 410);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
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
            // cmdRetour
            // 
            this.cmdRetour.Location = new System.Drawing.Point(465, 443);
            this.cmdRetour.Name = "cmdRetour";
            this.cmdRetour.Size = new System.Drawing.Size(75, 23);
            this.cmdRetour.TabIndex = 6;
            this.cmdRetour.Text = "Retour";
            this.cmdRetour.UseVisualStyleBackColor = true;
            // 
            // frmModification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 521);
            this.Controls.Add(this.cmdRetour);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdAjouter);
            this.Controls.Add(this.cmdSupp);
            this.Controls.Add(this.cmdModif);
            this.Controls.Add(this.dudChoixLigne);
            this.Controls.Add(this.lblChoixLigne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmModification";
            this.ShowIcon = false;
            this.Text = "Modification";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChoixLigne;
        private System.Windows.Forms.DomainUpDown dudChoixLigne;
        private System.Windows.Forms.Button cmdModif;
        private System.Windows.Forms.Button cmdSupp;
        private System.Windows.Forms.Button cmdAjouter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdValider;
        private System.Windows.Forms.Button cmdRetour;
    }
}