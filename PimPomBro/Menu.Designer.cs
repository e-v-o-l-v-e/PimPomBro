namespace MenuPrincipal
{
    partial class frmTabBord
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPimPomBro = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnGestionDuPersonnel = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnStatistiques = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGestionDesEngins = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNouvelleMission = new System.Windows.Forms.Button();
            this.btnTableauDeBord = new System.Windows.Forms.Button();
            this.btnrecherche = new System.Windows.Forms.Button();
            this.chkEnCours = new System.Windows.Forms.CheckBox();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPimPomBro
            // 
            this.lblPimPomBro.AutoSize = true;
            this.lblPimPomBro.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPimPomBro.ForeColor = System.Drawing.Color.Firebrick;
            this.lblPimPomBro.Location = new System.Drawing.Point(24, 38);
            this.lblPimPomBro.Name = "lblPimPomBro";
            this.lblPimPomBro.Size = new System.Drawing.Size(251, 46);
            this.lblPimPomBro.TabIndex = 10;
            this.lblPimPomBro.Text = "PimPomBro ";
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Location = new System.Drawing.Point(398, 123);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1228, 719);
            this.panel.TabIndex = 9;
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Firebrick;
            this.groupBox.Controls.Add(this.btnGestionDuPersonnel);
            this.groupBox.Controls.Add(this.button5);
            this.groupBox.Controls.Add(this.btnQuit);
            this.groupBox.Controls.Add(this.button4);
            this.groupBox.Controls.Add(this.btnStatistiques);
            this.groupBox.Controls.Add(this.button3);
            this.groupBox.Controls.Add(this.button2);
            this.groupBox.Controls.Add(this.btnGestionDesEngins);
            this.groupBox.Controls.Add(this.button1);
            this.groupBox.Controls.Add(this.btnNouvelleMission);
            this.groupBox.Controls.Add(this.btnTableauDeBord);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox.Location = new System.Drawing.Point(12, 123);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(367, 507);
            this.groupBox.TabIndex = 6;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Menu";
            // 
            // btnGestionDuPersonnel
            // 
            this.btnGestionDuPersonnel.BackColor = System.Drawing.Color.White;
            this.btnGestionDuPersonnel.ForeColor = System.Drawing.Color.Navy;
            this.btnGestionDuPersonnel.Location = new System.Drawing.Point(82, 257);
            this.btnGestionDuPersonnel.Name = "btnGestionDuPersonnel";
            this.btnGestionDuPersonnel.Size = new System.Drawing.Size(272, 49);
            this.btnGestionDuPersonnel.TabIndex = 3;
            this.btnGestionDuPersonnel.Text = "Gestion du personnel";
            this.btnGestionDuPersonnel.UseVisualStyleBackColor = false;
            this.btnGestionDuPersonnel.Click += new System.EventHandler(this.btnGestionDuPersonnel_Click);
            this.btnGestionDuPersonnel.MouseEnter += new System.EventHandler(this.btnTableauDeBord_MouseEnter);
            this.btnGestionDuPersonnel.MouseLeave += new System.EventHandler(this.btnTableauDeBord_MouseLeave);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.ForeColor = System.Drawing.Color.Navy;
            this.button5.Location = new System.Drawing.Point(31, 323);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(54, 49);
            this.button5.TabIndex = 9;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.DarkGray;
            this.btnQuit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnQuit.Location = new System.Drawing.Point(20, 426);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(123, 60);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.ForeColor = System.Drawing.Color.Navy;
            this.button4.Location = new System.Drawing.Point(31, 257);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 49);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnStatistiques
            // 
            this.btnStatistiques.BackColor = System.Drawing.Color.White;
            this.btnStatistiques.ForeColor = System.Drawing.Color.Navy;
            this.btnStatistiques.Location = new System.Drawing.Point(82, 323);
            this.btnStatistiques.Name = "btnStatistiques";
            this.btnStatistiques.Size = new System.Drawing.Size(272, 49);
            this.btnStatistiques.TabIndex = 4;
            this.btnStatistiques.Text = "Statistiques";
            this.btnStatistiques.UseVisualStyleBackColor = false;
            this.btnStatistiques.Click += new System.EventHandler(this.btnStatistiques_Click);
            this.btnStatistiques.MouseEnter += new System.EventHandler(this.btnTableauDeBord_MouseEnter);
            this.btnStatistiques.MouseLeave += new System.EventHandler(this.btnTableauDeBord_MouseLeave);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.ForeColor = System.Drawing.Color.Navy;
            this.button3.Location = new System.Drawing.Point(31, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 49);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.ForeColor = System.Drawing.Color.Navy;
            this.button2.Location = new System.Drawing.Point(31, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 49);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnGestionDesEngins
            // 
            this.btnGestionDesEngins.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGestionDesEngins.ForeColor = System.Drawing.Color.Navy;
            this.btnGestionDesEngins.Location = new System.Drawing.Point(82, 189);
            this.btnGestionDesEngins.Name = "btnGestionDesEngins";
            this.btnGestionDesEngins.Size = new System.Drawing.Size(272, 49);
            this.btnGestionDesEngins.TabIndex = 2;
            this.btnGestionDesEngins.Text = "Inventaire des engins";
            this.btnGestionDesEngins.UseVisualStyleBackColor = false;
            this.btnGestionDesEngins.Click += new System.EventHandler(this.btnGestionDesEngins_Click);
            this.btnGestionDesEngins.MouseEnter += new System.EventHandler(this.btnTableauDeBord_MouseEnter);
            this.btnGestionDesEngins.MouseLeave += new System.EventHandler(this.btnTableauDeBord_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(31, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 50);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnNouvelleMission
            // 
            this.btnNouvelleMission.BackColor = System.Drawing.Color.White;
            this.btnNouvelleMission.ForeColor = System.Drawing.Color.Navy;
            this.btnNouvelleMission.Location = new System.Drawing.Point(82, 120);
            this.btnNouvelleMission.Name = "btnNouvelleMission";
            this.btnNouvelleMission.Size = new System.Drawing.Size(272, 49);
            this.btnNouvelleMission.TabIndex = 1;
            this.btnNouvelleMission.Text = "Nouvelle mission";
            this.btnNouvelleMission.UseVisualStyleBackColor = false;
            this.btnNouvelleMission.Click += new System.EventHandler(this.btnNouvelleMission_Click);
            this.btnNouvelleMission.MouseEnter += new System.EventHandler(this.btnTableauDeBord_MouseEnter);
            this.btnNouvelleMission.MouseLeave += new System.EventHandler(this.btnTableauDeBord_MouseLeave);
            // 
            // btnTableauDeBord
            // 
            this.btnTableauDeBord.BackColor = System.Drawing.Color.White;
            this.btnTableauDeBord.ForeColor = System.Drawing.Color.Navy;
            this.btnTableauDeBord.Location = new System.Drawing.Point(82, 53);
            this.btnTableauDeBord.Name = "btnTableauDeBord";
            this.btnTableauDeBord.Size = new System.Drawing.Size(272, 50);
            this.btnTableauDeBord.TabIndex = 0;
            this.btnTableauDeBord.Text = "Tableau de bord";
            this.btnTableauDeBord.UseVisualStyleBackColor = false;
            this.btnTableauDeBord.Click += new System.EventHandler(this.btnTableauDeBord_Click);
            this.btnTableauDeBord.MouseEnter += new System.EventHandler(this.btnTableauDeBord_MouseEnter);
            this.btnTableauDeBord.MouseLeave += new System.EventHandler(this.btnTableauDeBord_MouseLeave);
            // 
            // btnrecherche
            // 
            this.btnrecherche.Location = new System.Drawing.Point(1282, 55);
            this.btnrecherche.Name = "btnrecherche";
            this.btnrecherche.Size = new System.Drawing.Size(37, 31);
            this.btnrecherche.TabIndex = 11;
            this.btnrecherche.UseVisualStyleBackColor = true;
            this.btnrecherche.Click += new System.EventHandler(this.btnrecherche_Click);
            // 
            // chkEnCours
            // 
            this.chkEnCours.AutoSize = true;
            this.chkEnCours.Location = new System.Drawing.Point(447, 55);
            this.chkEnCours.Name = "chkEnCours";
            this.chkEnCours.Size = new System.Drawing.Size(116, 29);
            this.chkEnCours.TabIndex = 12;
            this.chkEnCours.Text = "En cours";
            this.chkEnCours.UseVisualStyleBackColor = true;
            this.chkEnCours.CheckedChanged += new System.EventHandler(this.chkEnCours_CheckedChanged);
            // 
            // txtRecherche
            // 
            this.txtRecherche.ForeColor = System.Drawing.Color.Gray;
            this.txtRecherche.Location = new System.Drawing.Point(1125, 55);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(139, 31);
            this.txtRecherche.TabIndex = 7;
            this.txtRecherche.Text = "id...";
            this.txtRecherche.Enter += new System.EventHandler(this.txtRecherche_Enter);
            this.txtRecherche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecherche_KeyPress);
            this.txtRecherche.Leave += new System.EventHandler(this.txtRecherche_Leave);
            // 
            // frmTabBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1655, 854);
            this.Controls.Add(this.chkEnCours);
            this.Controls.Add(this.btnrecherche);
            this.Controls.Add(this.lblPimPomBro);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.groupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmTabBord";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPimPomBro;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnStatistiques;
        private System.Windows.Forms.Button btnGestionDuPersonnel;
        private System.Windows.Forms.Button btnGestionDesEngins;
        private System.Windows.Forms.Button btnNouvelleMission;
        private System.Windows.Forms.Button btnTableauDeBord;
        private System.Windows.Forms.Button btnrecherche;
        private System.Windows.Forms.CheckBox chkEnCours;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRecherche;
    }
}

