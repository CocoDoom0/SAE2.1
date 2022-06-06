using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE2._1
{
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }

        private void cmdModification_Click(object sender, EventArgs e)
        {
            frmModification f2 = new frmModification();
            f2.ShowDialog();
        }

        private void cmdAffichage_Click(object sender, EventArgs e)
        {
            frmAffichage f3 = new frmAffichage();
            f3.ShowDialog();
        }

        private void cmdRecherche_Click(object sender, EventArgs e)
        {
            frmRecherche f4 = new frmRecherche();
            f4.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
