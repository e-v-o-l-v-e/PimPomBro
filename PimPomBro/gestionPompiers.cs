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
    public partial class gestionPompiers : Form
    {
        private int matricule = -1;
        string requete = "";
        SQLiteCommand cmd = null;
        SQLiteDataReader reader = null;

        public gestionPompiers()
        {
            InitializeComponent();
        }

        private void gestionPompiers_Load(object sender, EventArgs e)
        {
            requete = "SELECT nom FROM Caserne";
            cmd = new SQLiteCommand(requete, Connexion.Connec);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cboCaserne.Items.Add(reader[0].ToString());
            }
            reader.Close();
        }

        private void btnModifications_Click(object sender, EventArgs e)
        {
            btnModifications.Visible = false;
            pnlInformationsDetaillees.Visible = true;
            btnChanger.Visible = true;
            txtGrade.Enabled = true;
        }

        private void cboPompier_Click(object sender, EventArgs e)
        {
            if (cboCaserne.SelectedItem == null)
            {
                MessageBox.Show("Veuillez selectionner une caserne pour pouvoir choisir un pompier.");
            }
        }

        private void cboCaserne_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboPompier.Items.Clear();

            if (cboCaserne.SelectedItem == null) { return; }

            requete =
                "SELECT p.nom || ' ' || p.prenom " +
                "FROM Pompier p " +
                "JOIN Affectation a ON a.matriculePompier = p.matricule " +
                "JOIN Caserne c ON a.idCaserne = c.id " +
                "WHERE c.nom = @caserneNom";

            cmd = new SQLiteCommand(requete, Connexion.Connec);
            cmd.Parameters.AddWithValue("@caserneNom", cboCaserne.SelectedItem.ToString());
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cboPompier.Items.Add(reader[0].ToString());
            }

            reader.Close();
        }

        private void cboPompier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPompier.SelectedItem == null) { return; }

            requete = "SELECT * FROM Pompier WHERE nom LIKE @nomPompier AND prenom LIKE @nomPompier";
            cmd = new SQLiteCommand(requete, Connexion.Connec);
            cmd.Parameters.AddWithValue("@nomPompier", "%" + cboPompier.SelectedItem.ToString() + "%");
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                matricule = Convert.ToInt32(reader["matricule"]);
                lblMatricule.Text = matricule.ToString();
                lblNom.Text = reader["nom"].ToString();
                lblPrenom.Text = reader["prenom"].ToString();
                txtGrade.Text = reader["grade"].ToString();
                lblTelephone.Text = reader["tel"].ToString();
            }
        }

    }
}
