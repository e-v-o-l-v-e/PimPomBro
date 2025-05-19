using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ResumMission
{

    public delegate void ClotureMission(object sender, EventArgs e);
    public delegate void PDF(object sender, EventArgs e);


    public partial class ResumeMission: UserControl
    {



        public ResumeMission()
        {
            InitializeComponent();
            //pictureBoxMission.Image = Image.FromFile("../../Ressources/Mission.png");
           // pictureBoxMission.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        public ResumeMission(int id, String type, String caserne, String date, String heure, String adresse, String status, String motif, String chemin1, String chemin2, String chemin3)
        {
            InitializeComponent();
            lblId.Text = id.ToString();
            lblNatureSinistre.Text = type;
            lblCaserne.Text = caserne;
            lblDate.Text = date;
            lblHeure.Text = heure;
            lblStatus.Text = status;
            lblMotif.Text = motif;
            // pictureBoxMission.Image = Image.FromFile("../../Ressources/Mission.png");
            pictureBoxMission.Image = Image.FromFile(chemin1);
            pictureBoxMission.SizeMode = PictureBoxSizeMode.StretchImage;


            btnPDF.BackgroundImage = Image.FromFile(chemin2);
            btnPDF.BackgroundImageLayout = ImageLayout.Stretch;
            btnPDF.Text = ""; // Aucun texte


            btnTerminer.BackgroundImage = Image.FromFile(chemin3);
            btnTerminer.BackgroundImageLayout = ImageLayout.Stretch;
            btnTerminer.Text = ""; // Pas de texte
        }

        public ClotureMission ClotureMission;
        public PDF PDF;

        private void ResumeMission_Load(object sender, EventArgs e)
        {

        }

        private void btnPDF_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;
            if (btn != null)
            {
                btn.BackColor = Color.LightGray;
            }
        }


        private void btnPDF_MouseLeave(object sender, EventArgs e)
        {

            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;
            if (btn != null)
            {
                btn.BackColor = Color.White;
            }
        }

        private void btnTerminer_Click(object sender, EventArgs e)
        {
            if(this.ClotureMission!=null)
            {
                this.ClotureMission(sender, e);
            }
        }

        private void pictureBoxMission_Click(object sender, EventArgs e)
        {
            if (this.PDF != null)
            {
                this.PDF(sender, e);
            }
        }
    }
}
