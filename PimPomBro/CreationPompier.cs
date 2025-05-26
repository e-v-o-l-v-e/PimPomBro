using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimPomBro
{
    public partial class CreationPompier : Form
    {
        public CreationPompier()
        {
            InitializeComponent();
        }

        private void CreationPompier_Load(object sender, EventArgs e)
        {
            rdbProfessionnel.Checked = true;

            string requete = "SELECT libelle FROM Habilitation";
            SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) {
                clbHab.Items.Add(dr["libelle"].ToString());
            }
            dr.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string requete = "INSERT INTO Pompier () VALUES ()";
        }
    }
}
