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

        }
    }
}
