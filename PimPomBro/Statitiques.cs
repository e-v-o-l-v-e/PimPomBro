using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pinpon;
using AfficheMisssions;

namespace PimPomBro
{
    public partial class Statitiques : Form
    {

        public Statitiques()
        {
            InitializeComponent();
            //la connexion s'appel : Connexion.Connec
        }

        private void Statitiques_Load(object sender, EventArgs e)
        {
            //pour esthetique
            lblType.Visible = false;
            lblNumEngin.Visible = false;
            lblUtilisations.Visible = false;

            //PANEL GENERAL
            string requete = "SELECT * FROM NatureSinistre";
            SQLiteCommand commande = new SQLiteCommand(requete, Connexion.Connec);
            SQLiteDataReader lecteur = commande.ExecuteReader();

            while (lecteur.Read())
            {
                string Type = lecteur["libelle"].ToString();
                cboTypesSinistres.Items.Add(Type);
            }

            lecteur.Close();

            //PANEL SPECIFIC
            string requete2 = "SELECT * FROM Caserne";
            SQLiteCommand commande2 = new SQLiteCommand(requete2, Connexion.Connec);
            SQLiteDataReader lecteur2 = commande2.ExecuteReader();

            // Lecture des résultats
            while (lecteur2.Read())
            {
                string name = lecteur2["nom"].ToString();
                cboCasernes.Items.Add(name);
            }

            lecteur2.Close();

            string requete3 = "SELECT * FROM Habilitation";
            SQLiteCommand commande3 = new SQLiteCommand(requete3, Connexion.Connec);
            SQLiteDataReader lecteur3 = commande3.ExecuteReader();

            // Lecture des résultats
            while (lecteur3.Read())
            {
                string habili = lecteur3["libelle"].ToString();
                cboHabilitations.Items.Add(habili);
            }

            lecteur3.Close();


            //les habilitation les plus utiles

            string idREqurence = @"SELECT idHabilitation,   COUNT(*) AS utilisation 
                                    FROM Mobiliser
                                    GROUP BY idHabilitation
                                    ORDER BY COUNT(*) DESC
                                    LIMIT 3;
                                    ";
            SQLiteCommand commande4 = new SQLiteCommand(idREqurence, Connexion.Connec);


            SQLiteDataReader read = commande4.ExecuteReader();

            List<string> tab = new List<string>();
            // Lecture des résultats
            while (read.Read())
            {
                string habilitationid = read["idHabilitation"].ToString();

                String habilitation = "select libelle from HAbilitation where id = @id ;";
                SQLiteCommand commande5 = new SQLiteCommand(habilitation, Connexion.Connec);
                commande5.Parameters.AddWithValue("id", habilitationid);
                String result = commande5.ExecuteScalar().ToString();

               tab.Add(result);
            }

            read.Close();

            String first=tab[0];
            String sec=tab[1];
            String last= tab[2];
            Podium podium = new Podium(first, sec,last);
            podium.Location = new Point(334, 9);
            tabControl.TabPages[0].Controls.Add(podium);

            //l'engin le plus utile:

            String req = @"SELECT p.codeTypeEngin, p.numeroEngin, 
                           ROUND(SUM((julianday(m.dateHeureRetour) - julianday(m.dateHeureDepart)) * 24), 2) AS heure
                            FROM PartirAvec p
                            JOIN Mission m ON p.idMission = m.id
                            WHERE m.dateHeureRetour IS NOT NULL
                            GROUP BY p.codeTypeEngin, p.numeroEngin
                            ORDER BY heure DESC
                            LIMIT 1;
                            ";
            SQLiteCommand comm=new SQLiteCommand(req, Connexion.Connec);
            SQLiteDataReader read2 = comm.ExecuteReader();
            while(read2.Read())
            {
                string best = read2["codeTypeEngin"].ToString() + read2["numeroEngin"].ToString();
                lblEnginBest.Text=best;
            }

        }

        private void btnRetour1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNbInterventions_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled= true;
        }

        private void txtNbInterventions_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboTypesSinistres_SelectedIndexChanged(object sender, EventArgs e)
        {
            //on recup l'id du synistre
            string typeSinistre = cboTypesSinistres.SelectedItem.ToString();

            string idNatureSinistre = "SELECT id FROM NatureSinistre WHERE libelle = @typeSinistre;";
            SQLiteCommand commande1 = new SQLiteCommand(idNatureSinistre, Connexion.Connec);
            commande1.Parameters.AddWithValue("@typeSinistre", typeSinistre);
            String id = commande1.ExecuteScalar().ToString();


            //je compte
            string nbMission = "SELECT COUNT(*) FROM Mission WHERE idNatureSinistre = " + id + ";";
            SQLiteCommand commande2 = new SQLiteCommand(nbMission, Connexion.Connec);
            txtNbInterventions.Text = commande2.ExecuteScalar().ToString();
          
        }

        private void cboHabilitations_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelPompiers.Controls.Clear();
            //on recup l'id de la habilitation
            String habilitation=cboHabilitations.SelectedItem.ToString(); //nom de l'habilitation
            String idHabilitation = "Select id from Habilitation where libelle=@habilitation;";
            SQLiteCommand habilitation1 = new SQLiteCommand(idHabilitation, Connexion.Connec);
            habilitation1.Parameters.AddWithValue("@habilitation", habilitation);
            string result=habilitation1.ExecuteScalar().ToString();


            //tous les matricules des pompiers qui ont deja eu cette habilitation
            String matricule = @"SELECT P.matricule, P.nom, P.prenom
                                FROM passer M
                                JOIN Pompier P ON M.matriculePompier = P.matricule
                                WHERE M.idHabilitation = @id;";

            SQLiteCommand matricule1 = new SQLiteCommand(matricule, Connexion.Connec);
            matricule1.Parameters.AddWithValue("@id", result);

            SQLiteDataReader reader = matricule1.ExecuteReader();
            int top = 0;
            while(reader.Read())
            {
                string mat = reader["matricule"].ToString();
                string name = reader["nom"].ToString();
                string prenom = reader["prenom"].ToString();

                EnginHeure cumul = new EnginHeure(mat, name, prenom);
                cumul.Top = top;
                cumul.Left = 0;
                panelPompiers.Controls.Add(cumul);
                top += 80;
            }

           if (panelPompiers.Controls.Count==0)
            {
                Label rien = new Label();
                rien.Text = "Aucun pompier n'a cette habilitation";
                rien.AutoSize = true;
                rien.ForeColor = Color.Navy;

                int x = 20;
                int y = (panelPompiers.Height - rien.PreferredHeight) / 2;
                rien.Location = new Point(x, y);

                panelPompiers.Controls.Add(rien);
            }

        }

        private void cboCasernes_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            lblType.Visible = true;
            lblNumEngin.Visible = true;
            lblUtilisations.Visible = true;


            panelCumulEngin.Controls.Clear();
            String cas = cboCasernes.SelectedItem.ToString();
            //recup l'id de la caserne 
            string requete = "SELECT id from Caserne where nom = @cas";
            SQLiteCommand idCaserne = new SQLiteCommand(requete, Connexion.Connec);
            idCaserne.Parameters.AddWithValue("@cas", cas);
            string id = idCaserne.ExecuteScalar().ToString();

            //avoir le type num et heure en fct de la caserne
            string heures = @"Select p.codeTypeEngin, p.numeroEngin, ROUND(SUM((julianday(m.dateHeureRetour) - julianday(m.dateHeureDepart)) * 24), 2) as heure
                            From PartirAvec p JOIN Mission m
                            where p.idMission=m.id
                            and m.idCaserne=@id
                            AND m.dateHeureRetour IS NOT NULL
                            GROUP BY p.codeTypeEngin, p.numeroEngin;";

            SQLiteCommand hours = new SQLiteCommand(heures, Connexion.Connec);
            hours.Parameters.AddWithValue("@id", id);

            int top = 10;

            SQLiteDataReader read = hours.ExecuteReader();
            while (read.Read())
            {
                string type = read["codeTypeEngin"].ToString();
                string num = read["numeroEngin"].ToString();

                float heure = float.Parse(read["heure"].ToString());

                int hour = (int)heure;               // Partie entière = les heures
                float min = (heure - hour) * 60;     // Partie décimale transformée en minutes (max 60, pas 100)

                string temps = $"{hour}h {Math.Round(min)}min";

                EnginHeure cumul = new EnginHeure(type,num,temps);
                cumul.Top = top;
                cumul.Left = 0;
                panelCumulEngin.Controls.Add(cumul);
                top += 80;
            }
        }

        private void lblHabilitationsSolicitees_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
