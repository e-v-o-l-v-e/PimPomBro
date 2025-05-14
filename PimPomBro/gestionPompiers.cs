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
        bool admin = false;
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

        private void cboPompier_Click(object sender, EventArgs e)
        {
            if (cboCaserne.SelectedItem == null)
            {
                MessageBox.Show("Veuillez selectionner une caserne pour pouvoir choisir un pompier.");
            }
        }

        private void cboCaserne_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblConsigne.Text = "Veuillez selectionner un pompier.";
            cboPompier.Items.Clear();
            cboPompier.Text = "";
            cboPompier.Select();

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
            if (cboPompier.SelectedItem == null) { 
                // MessageBox.Show("null pompier"); 
                return; 
            }
            // MessageBox.Show("good pompier"); 

            requete = "SELECT * FROM Pompier p JOIN Grade g ON p.codeGrade = g.code WHERE CONCAT(p.nom, ' ', p.prenom) = @pompier";
            cmd = new SQLiteCommand(requete, Connexion.Connec);
            cmd.Parameters.AddWithValue("@pompier", cboPompier.SelectedItem.ToString());
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                matricule = Convert.ToInt32(reader["matricule"]);
                lblMatricule.Text = matricule.ToString();
                lblNom.Text = reader["nom"].ToString();
                lblPrenom.Text = reader["prenom"].ToString();
                lblSexe.Text = reader["sexe"].ToString().ToUpper();
                lblDateEmbauche.Text = reader["dateEmbauche"].ToString();
                txtGrade.Text = reader["codeGrade"].ToString();
                cboGrade.Text = reader["libelle"].ToString();
                lblTelephone.Text = reader["portable"].ToString();
                lblBip.Text = reader["bip"].ToString();
                if (reader["type"].ToString() == "p") { rdbProfessionel.Checked = true; } else { rdbVolontaire.Checked = true; }
            }

            requete = "SELECT libelle FROM Grade";
            cmd = new SQLiteCommand(requete, Connexion.Connec);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cboGrade.Items.Add(reader["libelle"].ToString());
            }
            cboGrade.Visible = true;

            pnlPompier.Visible = true;
        }
        private void btnModifications_Click(object sender, EventArgs e)
        {
            btnModifications.Visible = false;
            pnlInformationsDetaillees.Visible = true;

            requete = "SELECT nom FROM Caserne";
            cmd = new SQLiteCommand(requete, Connexion.Connec);
            reader = cmd.ExecuteReader();
            while (reader.Read()) {
                cboCaserneDeRattachement.Items.Add(reader["nom"]);
            }
            cboCaserneDeRattachement.SelectedItem = cboCaserne.SelectedItem;

            requete = "SELECT libelle FROM Habilitation";
            cmd = new SQLiteCommand(requete, Connexion.Connec);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                clbHabilitations.Items.Add(reader["libelle"].ToString());
            }
        }

    }
}
