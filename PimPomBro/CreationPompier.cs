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
            int matricule;

            try
            {
                string requete = "SELECT max(a.matriculePompier) FROM Affectation a JOIN Caserne c ON a.idCaserne = c.id WHERE c.nom = @caserne";
                SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);
                cmd.Parameters.AddWithValue("@caserne", cboCaserneDeRattachement.Text);
                IDataReader dr = cmd.ExecuteReader();
                dr.Read();
                matricule = Convert.ToInt32(dr[0]) + 1;
                dr.Close();

                requete = "SELECT code FROM Grade WHERE libelle = @libelle";
                cmd = new SQLiteCommand(requete, Connexion.Connec);
                cmd.Parameters.AddWithValue("@libelle", cboGrade.Text);
                dr = cmd.ExecuteReader();
                dr.Read();
                string codeGrade = dr[0].ToString();
                dr.Close();

                requete = "INSERT INTO Pompier VALUES (@matricule, @nom, @prenom, @sexe, @dateNaissance, @type, @portable, @bip, @enMission, @enConge, @codeGrade, @dateEmbauche)";
                cmd = new SQLiteCommand(requete, Connexion.Connec);
                cmd.Parameters.AddWithValue("@matricule", matricule);
                cmd.Parameters.AddWithValue("@nom", txtNom.Text);
                cmd.Parameters.AddWithValue("@prenom", txtPrenom.Text);
                cmd.Parameters.AddWithValue("@sexe", rdbFemelle.Checked ? "f" : "m" );
                cmd.Parameters.AddWithValue("@dateNaissance", dtpNaissance.Value.ToString());
                cmd.Parameters.AddWithValue("@type", rdbProfessionnel.Checked ? "p" : "v" );
                cmd.Parameters.AddWithValue("@portable", txtPortable.Text);
                cmd.Parameters.AddWithValue("@bip", (txtBip.Text != "") ? matricule : Convert.ToInt32(txtBip.Text));
                cmd.Parameters.AddWithValue("@enMission", 0);
                cmd.Parameters.AddWithValue("@enConge", 0);
                cmd.Parameters.AddWithValue("@codeGrade", codeGrade);
                cmd.Parameters.AddWithValue("@dateEmbauche", dtpEmbauche.Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
