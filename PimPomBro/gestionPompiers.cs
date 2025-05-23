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
        bool admin = true; // A CHANGER A FALSE, TRUE JUSTE POUR EVITER DE LOGIN A CHAQUE TEST /!\
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
            cboCaserne.DisplayMember = "nom";
            cboCaserne.ValueMember = "id";
            cboCaserne.DataSource = MesDatas.DsGlobal.Tables["Caserne"];
            // cboCaserne.SelectedIndex = -1;

            cboCaserneDeRattachement.DisplayMember = "nom";
            cboCaserneDeRattachement.ValueMember = "id";
            cboCaserneDeRattachement.DataSource = MesDatas.DsGlobal.Tables["Caserne"];

            foreach (DataRow rowHab in MesDatas.DsGlobal.Tables["Habilitation"].Rows)
            {
                clbHabilitations.Items.Add(rowHab["libelle"].ToString());
            }
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
            cboPompier.Text = "";
            cboPompier.Select();

            if (cboCaserne.SelectedItem == null) { return; }
            int idCaserne = Convert.ToInt32(cboCaserne.SelectedValue);

            DataTable tablePompiers = MesDatas.DsGlobal.Tables["Pompier"];
            DataTable tableAffectation = MesDatas.DsGlobal.Tables["Affectation"];

            List<int> listeMatricules = new List<int>();
            foreach (DataRow rowAff in tableAffectation.Rows)
            {
                if (Convert.ToInt32(rowAff["idCaserne"]) == idCaserne)
                {
                    listeMatricules.Add(Convert.ToInt32(rowAff["matriculePompier"]));
                }
            }

            string filter = "matricule IN (" + string.Join(",", listeMatricules) + ")";
            DataView dv = new DataView(tablePompiers, filter, null, DataViewRowState.CurrentRows);

            cboPompier.ValueMember = "matricule";
            cboPompier.DataSource = dv;

            cboPompier.Format += (s, e2) =>
            {
                DataRowView drv = e2.ListItem as DataRowView;
                if (drv != null)
                {
                    e2.Value = drv["nom"] + " " + drv["prenom"];
                }
            };
        }

        private void cboPompier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPompier.SelectedItem == null)
            {
                // MessageBox.Show("null pompier"); 
                return;
            }
            // MessageBox.Show("good pompier"); 

            pnlInformationsDetaillees.Visible = false;
            cboGrade.Enabled = false;


            matricule = Convert.ToInt32(cboPompier.SelectedValue);
            DataTable tablePompier = MesDatas.DsGlobal.Tables["Pompier"];
            DataRow rowPompier = tablePompier.Rows.Find(matricule);

            lblMatricule.Text = matricule.ToString();
            lblNom.Text = rowPompier["nom"].ToString();
            lblPrenom.Text = rowPompier["prenom"].ToString();
            lblSexe.Text = rowPompier["sexe"].ToString().ToUpper();
            lblDateEmbauche.Text = rowPompier["dateEmbauche"].ToString();
            txtGrade.Text = rowPompier["codeGrade"].ToString();
            if (rowPompier["type"].ToString() == "p") { rdbProfessionel.Checked = true; } else { rdbVolontaire.Checked = true; }
            try
            {
                lblTelephone.Text = rowPompier["portable"].ToString();
                lblBip.Text = rowPompier["bip"].ToString();
            }
            catch (Exception ex) { }

            try
            {
                requete = "SELECT libelle FROM Grade WHERE code = @codeGrade";
                cmd = new SQLiteCommand(requete, Connexion.Connec);
                cmd.Parameters.AddWithValue("@codeGrade", txtGrade.Text);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    cboGrade.Text = reader["libelle"].ToString();
                }
            } catch (Exception ex) { 
                cboGrade.Visible = false;
            }

            pnlPompier.Visible = true;
        }
        private void btnModifications_Click(object sender, EventArgs e)
        {
            if (!admin) { connexionAdmin(); }
            if (!admin) { return; }

            // cboCaserneDeRattachement.SelectedItem = cboCaserne.SelectedItem;


            for (int i = 0; i < clbHabilitations.Items.Count; i++)
            {
                clbHabilitations.SetItemChecked(i, false);
            }
            requete = "SELECT h.libelle FROM Passer p JOIN Habilitation h ON p.idHabilitation = h.id WHERE p.matriculePompier = @matricule";
            cmd = new SQLiteCommand(requete, Connexion.Connec);
            cmd.Parameters.AddWithValue("@matricule", matricule);
            reader = cmd.ExecuteReader();
            while (reader.Read()) {
                string libelle = reader["libelle"].ToString();
                int index = clbHabilitations.Items.IndexOf(libelle);
                if (index != -1)
                {
                    clbHabilitations.SetItemChecked(index, true);
                }
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
            cboGrade.Enabled = true;
            pnlInformationsDetaillees.Visible = true;
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
