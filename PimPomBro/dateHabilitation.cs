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
    public partial class dateHabilitation : Form
    {
        String habilitation;

        public dateHabilitation(string habilitation)
        {
            InitializeComponent();
            this.habilitation = habilitation;
        }

        private void dateHabilitation_Load(object sender, EventArgs e)
        {
            lblHab.Text = this.habilitation;
        }

        public String date { get; private set; }

        private void btnValider_Click(object sender, EventArgs e)
        {
            date = dtpDate.Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
