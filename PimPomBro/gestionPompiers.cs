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
            cboCaserne.DataSource = MesDatas.DsGlobal.Tables["Caserne"];
            cboCaserne.DisplayMember = "nom";
            cboCaserne.ValueMember = "id";
            
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

            DataTable pompierTable = MesDatas.DsGlobal.Tables["Pompier"];
            pompierTable.DefaultView.RowFilter = "p.matricule = a.matricule where a.id = " + cboCaserne.SelectedValue;
            cboPompier.DataSource = pompierTable;
            cboPompier.DisplayMember = "nom || ' ' || prenom";
            cboPompier.ValueMember = "id";

        }

        private void cboPompier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPompier.SelectedItem == null) { 
                // MessageBox.Show("null pompier"); 
                return; 
            }
            // MessageBox.Show("good pompier"); 

            pnlInformationsDetaillees.Visible = false;

            requete = "SELECT * FROM Pompier p JOIN Grade g ON p.codeGrade = g.code WHERE CONCAT(p.nom, ' ', p.prenom) = @pompier";
            cmd = new SQLiteCommand(requete, Connexion.Connec);
            cmd.Parameters.AddWithValue("@pompier", cboPompier.SelectedItem.ToString());
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                matricule = Convert.ToInt32(reader["matricule"]);
                lblMatricule.Text = matricule.ToString();
                lblNom.Text = reader["nom"].ToString();
                lblPrenom.Text = reader["prenom"].ToString();
                lblSexe.Text = reader["sexe"].ToString().ToUpper();
                lblDateEmbauche.Text = reader["dateEmbauche"].ToString();
                txtGrade.Text = reader["codeGrade"].ToString();
                cboGrade.Text = reader["libelle"].ToString();
                try
                {
                MessageBox.Show(reader["type"].ToString());
                if (reader["type"].ToString() == "p") { rdbProfessionel.Checked = true; } else { rdbVolontaire.Checked = true; }

                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    lblTelephone.Text = reader["portable"].ToString();
                    lblBip.Text = reader["bip"].ToString();
                }
                catch (Exception ex) { }

            }
            reader.Close();

            requete = "SELECT libelle FROM Grade";
            cmd = new SQLiteCommand(requete, Connexion.Connec);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cboGrade.Items.Add(reader["libelle"].ToString());
            }
            cboGrade.Visible = true;

            pnlPompier.Visible = true;
            reader.Close();
        }
        private void btnModifications_Click(object sender, EventArgs e)
        {
            if (!admin) { connexionAdmin(); }
            if (!admin) { return; }


            pnlInformationsDetaillees.Visible = true;
            cboGrade.Enabled = true;

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

            requete = "SELECT a.dateA,a.dateFin,c.nom FROM Affectation a JOIN Caserne c ON a.idCaserne = c.id WHERE matriculePompier = @matricule AND dateFin IS NOT NULL";
            cmd = new SQLiteCommand(requete, Connexion.Connec);
            cmd.Parameters.AddWithValue("@matricule", matricule);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string caserne = reader["nom"].ToString();
                string dateA = reader["dateA"].ToString();
                string dateFin = reader["dateFin"].ToString();
                lstAffectations.Items.Add(caserne + " : " + dateA + " - " + dateFin);
            }


            requete = "SELECT enConge FROM Pompier WHERE matricule = @matricule";
            cmd = new SQLiteCommand(requete, Connexion.Connec);
            cmd.Parameters.AddWithValue("@matricule", matricule);
            reader = cmd.ExecuteReader();
            reader.Read();
            // MessageBox.Show(Convert.ToInt32(reader["enConge"]).ToString());
            if (Convert.ToInt32(reader["enConge"]) == 1)
            {
                chkConge.Checked = true;
            }

            reader.Close();
        }

        private void connexionAdmin()
        {
            ConnexionAdmin connexionAdmin = new ConnexionAdmin();
            var result = connexionAdmin.ShowDialog();
            if (result == DialogResult.OK) {
                admin = true;
            } else
            {
                admin = false;
            }

        }

       private void btnAppliquerModif_Click(object sender, EventArgs e)
        {
            using (SQLiteTransaction tran = Connexion.Connec.BeginTransaction())
            {
                try
                {
                    requete = "UPDATE Pompier SET codeGrade = @codeGrade, enConge = @enConge WHERE matricule = @matricule";
                    cmd = new SQLiteCommand(requete, Connexion.Connec);
                    cmd.Parameters.AddWithValue("@codeGrade", txtGrade.Text);
                    cmd.Parameters.AddWithValue("@matricule", matricule);
                    cmd.Parameters.AddWithValue("@enConge", (chkConge.Checked) ? 1 : 0);
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cboGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            requete = "SELECT code FROM Grade WHERE libelle = @libelle";
            cmd = new SQLiteCommand(requete, Connexion.Connec);
            cmd.Parameters.AddWithValue("@libelle", cboGrade.Text);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtGrade.Text = reader["code"].ToString();
            }

            reader.Close();
        }
    }
}
