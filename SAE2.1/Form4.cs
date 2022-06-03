using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BD;

namespace SAE2._1
{
    public partial class frmRecherche : Form
    {
        public frmRecherche()
        {
            InitializeComponent();
        }

        private void ClickRetour(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRecherche_FormClosed(object sender, FormClosedEventArgs e)
        {
            BDD.FermerConnexion();
        }
    }
}
