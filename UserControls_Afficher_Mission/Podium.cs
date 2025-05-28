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
    public partial class Podium : UserControl
    {
        public Podium()
        {
            InitializeComponent();
        }

        public Podium(String premier, String deuxieme, String troisieme)
        {
            InitializeComponent();
            lbl1.Text = premier;
            lbl2.Text = deuxieme;   
            lbl3.Text = troisieme;
        }

        private void Podium_Load(object sender, EventArgs e)
        {

        }
    }
}
