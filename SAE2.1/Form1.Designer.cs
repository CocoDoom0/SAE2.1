
namespace SAE2._1
{
    partial class frmAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmdModification = new System.Windows.Forms.Button();
            this.cmdRecherche = new System.Windows.Forms.Button();
            this.cmdAffichage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(192, 63);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(181, 58);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Corolis";
            // 
            // cmdModification
            // 
            this.cmdModification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModification.Location = new System.Drawing.Point(169, 151);
            this.cmdModification.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdModification.Name = "cmdModification";
            this.cmdModification.Size = new System.Drawing.Size(240, 55);
            this.cmdModification.TabIndex = 1;
            this.cmdModification.Text = "Modification";
            this.cmdModification.UseVisualStyleBackColor = true;
            this.cmdModification.Click += new System.EventHandler(this.cmdModification_Click);
            // 
            // cmdRecherche
            // 
            this.cmdRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRecherche.Location = new System.Drawing.Point(169, 239);
            this.cmdRecherche.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdRecherche.Name = "cmdRecherche";
            this.cmdRecherche.Size = new System.Drawing.Size(240, 55);
            this.cmdRecherche.TabIndex = 2;
            this.cmdRecherche.Text = "Recherche";
            this.cmdRecherche.UseVisualStyleBackColor = true;
            this.cmdRecherche.Click += new System.EventHandler(this.cmdRecherche_Click);
            // 
            // cmdAffichage
            // 
            this.cmdAffichage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAffichage.Location = new System.Drawing.Point(169, 326);
            this.cmdAffichage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdAffichage.Name = "cmdAffichage";
            this.cmdAffichage.Size = new System.Drawing.Size(240, 55);
            this.cmdAffichage.TabIndex = 3;
            this.cmdAffichage.Text = "Affichage";
            this.cmdAffichage.UseVisualStyleBackColor = true;
            this.cmdAffichage.Click += new System.EventHandler(this.cmdAffichage_Click);
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 444);
            this.Controls.Add(this.cmdAffichage);
            this.Controls.Add(this.cmdRecherche);
            this.Controls.Add(this.cmdModification);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmAccueil";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button cmdModification;
        private System.Windows.Forms.Button cmdRecherche;
        private System.Windows.Forms.Button cmdAffichage;
    }
}

