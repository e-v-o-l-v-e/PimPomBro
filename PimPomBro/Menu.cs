using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AfficheMisssions;
using PimPomBro;



namespace MenuPrincipal
{
    public partial class frmTabBord : Form
    {

        public frmTabBord()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Charger les données depuis la base SQLite une seule fois
            ChargerToutesLesTables();

            txtRecherche.Text = "id...";
            txtRecherche.ForeColor = Color.Gray;



            // Préparer le bouton recherche
            btnrecherche.BackgroundImage = Image.FromFile("../../Ressources/check.png");
            btnrecherche.BackgroundImageLayout = ImageLayout.Stretch;
            btnrecherche.Text = "";

            // Préparer les icônes des autres boutons
            button1.BackgroundImage = Image.FromFile("../../Ressources/TabBord.png");
            button1.BackgroundImageLayout = ImageLayout.Stretch;

            button2.BackgroundImage = Image.FromFile("../../Ressources/Mission.png");
            button2.BackgroundImageLayout = ImageLayout.Stretch;

            button3.BackgroundImage = Image.FromFile("../../Ressources/Camion.png");
            button3.BackgroundImageLayout = ImageLayout.Stretch;

            button4.BackgroundImage = Image.FromFile("../../Ressources/Pompiers.png");
            button4.BackgroundImageLayout = ImageLayout.Stretch;

            button5.BackgroundImage = Image.FromFile("../../Ressources/Stats.png");
            button5.BackgroundImageLayout = ImageLayout.Stretch;

            // Générer les missions à partir du DataSet (mode déconnecté)
            GenerationMission(); 
        }

        
        public static void ChargerToutesLesTables()
        {
            
            using (SQLiteConnection connexion = new SQLiteConnection(@"DataSource=../../SDIS67.db")
)
            {
                connexion.Open();

                new SQLiteDataAdapter("SELECT * FROM Mission", connexion).Fill(MesDatas.DsGlobal, "Mission");
                new SQLiteDataAdapter("SELECT * FROM Caserne", connexion).Fill(MesDatas.DsGlobal, "Caserne");
                new SQLiteDataAdapter("SELECT * FROM NatureSinistre", connexion).Fill(MesDatas.DsGlobal, "NatureSinistre");

                connexion.Close();
            }
        

        }

        

        public void GenerationMission()
        {
            
            // Nettoyer le panel au cas où on recharge
            panel.Controls.Clear();

            int DistanceHaut = 5;

            // Parcourir chaque ligne de la table Mission
            foreach (DataRow mission in MesDatas.DsGlobal.Tables["Mission"].Rows)
            {
                int id = Convert.ToInt32(mission["id"]);
                int type = Convert.ToInt32(mission["idNatureSinistre"]);
                int cas = Convert.ToInt32(mission["idCaserne"]);
                int terminee = Convert.ToInt32(mission["terminee"]);


                string NatureSinistre = MesDatas.DsGlobal.Tables["NatureSinistre"]
                    .Select("id = " + type)[0]["libelle"].ToString();

                string Caserne = MesDatas.DsGlobal.Tables["Caserne"]
                    .Select("id = " + cas)[0]["nom"].ToString();

                string dateHeure = mission["DateHeureDepart"].ToString();
                string Date = dateHeure.Substring(8, 2) + "/" + dateHeure.Substring(5, 2) + "/20" + dateHeure.Substring(0, 2);
                string Heure = dateHeure.Substring(10, 5);

                string Adresse = mission["adresse"].ToString();
                string Motif = mission["motifAppel"].ToString();
                string Status = (terminee == 1) ? "Terminee" : "En cours";

                string ch1 = "../../Ressources/Mission.png";
                string ch2 = "../../Ressources/pdf.png";
                string ch3 = "../../Ressources/Sign-check-icon.png";

                AfficheMission Mission = new AfficheMission(id, NatureSinistre, Caserne, Date, Heure, Adresse, Status, Motif, ch1, ch2, ch3);

                Mission.Size = new Size(1300, 250);
                Mission.Top = DistanceHaut;
                Mission.Left = 8;


                panel.Controls.Add(Mission);
                DistanceHaut += 255;

              
            }

        }

        public void GenerationMission(int idRecherche)
        {
            // Nettoyer le panel
            panel.Controls.Clear();

            int DistanceHaut = 5;

            // Parcourir les missions
            foreach (DataRow mission in MesDatas.DsGlobal.Tables["Mission"].Rows)
            {
                int id = Convert.ToInt32(mission["id"]);

                if (id != idRecherche)
                    continue;

                int type = Convert.ToInt32(mission["idNatureSinistre"]);
                int cas = Convert.ToInt32(mission["idCaserne"]);
                int terminee = Convert.ToInt32(mission["terminee"]);

             
              
                string NatureSinistre = MesDatas.DsGlobal.Tables["NatureSinistre"]
                    .Select("id = " + type)[0]["libelle"].ToString();

                string Caserne = MesDatas.DsGlobal.Tables["Caserne"]
                    .Select("id = " + cas)[0]["nom"].ToString();

                string dateHeure = mission["DateHeureDepart"].ToString();
                string Date = dateHeure.Substring(8, 2) + "/" + dateHeure.Substring(5, 2) + "/20" + dateHeure.Substring(0, 2);
                string Heure = dateHeure.Substring(10, 5);

                string Adresse = mission["adresse"].ToString();
                string Motif = mission["motifAppel"].ToString();
                string Status = (terminee == 1) ? "Terminee" : "En cours";

                string ch1 = "../../Ressources/Mission.png";
                string ch2 = "../../Ressources/pdf.png";
                string ch3 = "../../Ressources/Sign-check-icon.png";

                AfficheMission Mission = new AfficheMission(id, NatureSinistre, Caserne, Date, Heure, Adresse, Status, Motif, ch1, ch2, ch3);

                Mission.Size = new Size(1300, 250);
                Mission.Top = DistanceHaut;
                Mission.Left = 8;

                panel.Controls.Add(Mission);
                DistanceHaut += 255;

                break; 
            }
        }


        public void GenerationMissionEnCours()
        {
            // Nettoyer le panel au cas où on recharge
            panel.Controls.Clear();

            int DistanceHaut = 5;

            // Parcourir chaque ligne de la table Mission
            foreach (DataRow mission in MesDatas.DsGlobal.Tables["Mission"].Rows)
            {
                int id = Convert.ToInt32(mission["id"]);
                int type = Convert.ToInt32(mission["idNatureSinistre"]);
                int cas = Convert.ToInt32(mission["idCaserne"]);
                int terminee = Convert.ToInt32(mission["terminee"]);

                // ❗️On affiche uniquement les missions "En cours"
                if (terminee == 1)
                {
                    continue; // On saute si elle est terminée
                }

                string NatureSinistre = MesDatas.DsGlobal.Tables["NatureSinistre"]
                    .Select("id = " + type)[0]["libelle"].ToString();

                string Caserne = MesDatas.DsGlobal.Tables["Caserne"]
                    .Select("id = " + cas)[0]["nom"].ToString();

                string dateHeure = mission["DateHeureDepart"].ToString();
                string Date = dateHeure.Substring(8, 2) + "/" + dateHeure.Substring(5, 2) + "/20" + dateHeure.Substring(0, 2);
                string Heure = dateHeure.Substring(10, 5);

                string Adresse = mission["adresse"].ToString();
                string Motif = mission["motifAppel"].ToString();
                string Status = "En cours";

                string ch1 = "../../Ressources/Mission.png";
                string ch2 = "../../Ressources/pdf.png";
                string ch3 = "../../Ressources/Sign-check-icon.png";

                AfficheMission Mission = new AfficheMission(id, NatureSinistre, Caserne, Date, Heure, Adresse, Status, Motif, ch1, ch2, ch3);

                Mission.Size = new Size(1300, 250);
                Mission.Top = DistanceHaut;
                Mission.Left = 8;

                panel.Controls.Add(Mission);
                DistanceHaut += 255;
            }
        }


        public void GenerationMissionEnCours(int idRecherche)
        {
            // Nettoyer le panel au cas où on recharge
            panel.Controls.Clear();

            int DistanceHaut = 5;

            // Parcourir chaque ligne de la table Mission
            foreach (DataRow mission in MesDatas.DsGlobal.Tables["Mission"].Rows)
            {
                int id = Convert.ToInt32(mission["id"]);
                int type = Convert.ToInt32(mission["idNatureSinistre"]);
                int cas = Convert.ToInt32(mission["idCaserne"]);
                int terminee = Convert.ToInt32(mission["terminee"]);

                // On filtre sur l'id demandé et on affiche uniquement les missions "En cours"
                if (id != idRecherche || terminee == 1)
                {
                    continue; // On saute si l'id ne correspond pas ou la mission est terminée
                }

                string NatureSinistre = MesDatas.DsGlobal.Tables["NatureSinistre"]
                    .Select("id = " + type)[0]["libelle"].ToString();

                string Caserne = MesDatas.DsGlobal.Tables["Caserne"]
                    .Select("id = " + cas)[0]["nom"].ToString();

                string dateHeure = mission["DateHeureDepart"].ToString();
                string Date = dateHeure.Substring(8, 2) + "/" + dateHeure.Substring(5, 2) + "/20" + dateHeure.Substring(0, 2);
                string Heure = dateHeure.Substring(10, 5);

                string Adresse = mission["adresse"].ToString();
                string Motif = mission["motifAppel"].ToString();
                string Status = "En cours";

                string ch1 = "../../Ressources/Mission.png";
                string ch2 = "../../Ressources/pdf.png";
                string ch3 = "../../Ressources/Sign-check-icon.png";

                AfficheMission Mission = new AfficheMission(id, NatureSinistre, Caserne, Date, Heure, Adresse, Status, Motif, ch1, ch2, ch3);

                Mission.Size = new Size(1300, 250);
                Mission.Top = DistanceHaut;
                Mission.Left = 8;

                panel.Controls.Add(Mission);
                DistanceHaut += 255;
            }
        }





        private void chkEnCours_CheckedChanged(object sender, EventArgs e)
        {
            if (txtRecherche.Text == ""||txtRecherche.Text=="id...")
            {
                if (chkEnCours.Checked)
                {
                    GenerationMissionEnCours();
                }
                else
                {
                    GenerationMission();
                }
            }
            else
            {
                if (chkEnCours.Checked)
                {
                    int id = int.Parse(txtRecherche.Text);
                    GenerationMissionEnCours(id);
                }
                else
                {
                    int id = int.Parse(txtRecherche.Text);
                    GenerationMission(id);
                }

            }

        }

        private void txtRecherche_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
                txtRecherche.ForeColor = Color.Black;
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtRecherche.Text == "")
                {
                    GenerationMission();
                }
                else{
                    int id = int.Parse(txtRecherche.Text);
                    GenerationMission(id);
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnrecherche_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTableauDeBord_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;
             btn.BackColor = Color.LightGray;
        }

        private void btnTableauDeBord_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;
            btn.BackColor = Color.White;
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void txtRecherche_Leave(object sender, EventArgs e)
        {
            if (txtRecherche.Text=="")
            {
                txtRecherche.Text = "id...";
                txtRecherche.ForeColor = Color.Gray;
            }
            
        }

        private void btnTableauDeBord_Click(object sender, EventArgs e)
        {

        }

        private void btnNouvelleMission_Click(object sender, EventArgs e)
        {

        }

        private void btnGestionDesEngins_Click(object sender, EventArgs e)
        {

        }

        private void btnGestionDuPersonnel_Click(object sender, EventArgs e)
        {

        }

        private void btnStatistiques_Click(object sender, EventArgs e)
        {
            Statitiques statitiques = new Statitiques();
            statitiques.ShowDialog(); // ouverture de l;autre formulaire
        }

        

        private void txtRecherche_Enter(object sender, EventArgs e)
        {
            txtRecherche.Text = "";
            txtRecherche.ForeColor = Color.Black;
            chkEnCours.Checked = false;
        }
    }
}
