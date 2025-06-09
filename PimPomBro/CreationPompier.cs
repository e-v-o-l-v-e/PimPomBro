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
            cboCaserneDeRattachement.DisplayMember = "nom";
            cboCaserneDeRattachement.ValueMember = "id";
            cboCaserneDeRattachement.DataSource = MesDatas.DsGlobal.Tables["Caserne"];

            rdbProfessionnel.Checked = true;


            cboGrade.DisplayMember = "libelle";
            cboGrade.ValueMember = "code";
            cboGrade.DataSource = MesDatas.DsGlobal.Tables["Grade"];

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

            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;
            string portable = txtPortable.Text;
            if (nom.Length < 1) { }


            try
            {
                string requete = "SELECT MAX(matricule) FROM Pompier";
                SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);
                object result = cmd.ExecuteScalar();
                matricule = Convert.ToInt32(result) + 11;

                requete = "SELECT code FROM Grade WHERE libelle = @libelle";
                cmd = new SQLiteCommand(requete, Connexion.Connec);
                cmd.Parameters.AddWithValue("@libelle", cboGrade.Text);
                IDataReader dr = cmd.ExecuteReader();
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
                cmd.Parameters.AddWithValue("@bip", (txtBip.TextLength == 0) ? matricule : Convert.ToInt32(txtBip.Text));
                cmd.Parameters.AddWithValue("@enMission", 0);
                cmd.Parameters.AddWithValue("@enConge", 0);
                cmd.Parameters.AddWithValue("@codeGrade", codeGrade);
                cmd.Parameters.AddWithValue("@dateEmbauche", dtpEmbauche.Value.ToString());
                cmd.ExecuteNonQuery();

                requete = "INSERT INTO Affectation VALUES (@matricule, @dateA, '', @caserne)";
                cmd = new SQLiteCommand(requete, Connexion.Connec);
                cmd.Parameters.AddWithValue("@matricule", matricule);
                cmd.Parameters.AddWithValue("@dateA", dtpEmbauche.Value.ToString());
                cmd.Parameters.AddWithValue("@caserne", cboCaserneDeRattachement.SelectedValue);
                cmd.ExecuteNonQuery();



                foreach (object o in clbHab.CheckedItems)
                {
                    String date;

                    dateHabilitation dateHab = new dateHabilitation(o.ToString());
                    if (dateHab.ShowDialog() == DialogResult.OK)
                    {
                        date = dateHab.date;                        
                    }
                    else
                    {
                        date = dtpEmbauche.Value.ToString();
                    }
                    requete = "SELECT id FROM Habilitation WHERE libelle = @libelle";
                    cmd = new SQLiteCommand(requete, Connexion.Connec);
                    cmd.Parameters.AddWithValue("@libelle", o.ToString());
                    dr = cmd.ExecuteReader();
                    int idHab;
                    dr.Read();
                    idHab = Convert.ToInt32(dr["id"]);

                    requete = "INSERT INTO Passer VALUES (@matricule, @hab, @date)";
                    cmd = new SQLiteCommand(requete, Connexion.Connec);
                    cmd.Parameters.AddWithValue("@matricule", matricule);
                    cmd.Parameters.AddWithValue("@hab", idHab);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.ExecuteNonQuery();
                }

                MesDatas.refreshTable("Pompier");
                MesDatas.refreshTable("Affectation");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
