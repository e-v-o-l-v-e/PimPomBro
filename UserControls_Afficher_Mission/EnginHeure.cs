using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AfficheMisssions
{
    public partial class EnginHeure : UserControl
    {
        public EnginHeure()
        {
            InitializeComponent();
        }

        public EnginHeure(String type, String num, String Heure)
        {
            InitializeComponent();
            lblType.Text = type;
            lblNumero.Text = num;
            lblHeure.Text = Heure;
        }

        private void EnginHeure_Load(object sender, EventArgs e)
        {

        }
    }
}
