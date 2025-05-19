using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Statistiques : Form
    {
        public Statistiques()
        {
            InitializeComponent();
            dataGridView1.BackgroundColor = Color.Navy; // Couleur du fond
            dataGridView1.DefaultCellStyle.BackColor = Color.White; // Fond des cellules
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black; // Couleur du texte

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
