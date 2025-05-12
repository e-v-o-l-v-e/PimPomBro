using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimPomBro
{
    public partial class gestionPompiers : Form
    {
        public gestionPompiers()
        {
            InitializeComponent();
        }

        private void gestionPompiers_Load(object sender, EventArgs e)
        {

        }

        private void btnModifications_Click(object sender, EventArgs e)
        {
            btnModifications.Visible = false;
            btnChanger.Visible = true;
            pnlInformationsDetaillees.Visible = true;
        }
    }
}
