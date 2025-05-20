namespace AfficheMisssions
{
    partial class AfficheMission
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

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTerminer = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.grpBox1 = new System.Windows.Forms.GroupBox();
            this.lblNomMotif = new System.Windows.Forms.Label();
            this.lblNomStatus = new System.Windows.Forms.Label();
            this.lblNomAdresse = new System.Windows.Forms.Label();
            this.lblNomHeure = new System.Windows.Forms.Label();
            this.lblNomDate = new System.Windows.Forms.Label();
            this.lblNomCaserne = new System.Windows.Forms.Label();
            this.lblNomId = new System.Windows.Forms.Label();
            this.pictureBoxMission = new System.Windows.Forms.PictureBox();
            this.lblNatureSinistre = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblHeure = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.grpBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMission)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTerminer
            // 
            this.btnTerminer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTerminer.Location = new System.Drawing.Point(1053, 136);
            this.btnTerminer.Name = "btnTerminer";
            this.btnTerminer.Size = new System.Drawing.Size(84, 85);
            this.btnTerminer.TabIndex = 8;
            this.btnTerminer.Text = "button2";
            this.btnTerminer.UseVisualStyleBackColor = false;
            this.btnTerminer.Click += new System.EventHandler(this.btnTerminer_Click);
            this.btnTerminer.MouseLeave += new System.EventHandler(this.btnPDF_MouseLeave);
            this.btnTerminer.MouseHover += new System.EventHandler(this.btnPDF_MouseHover);
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPDF.Location = new System.Drawing.Point(1053, 29);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(84, 82);
            this.btnPDF.TabIndex = 7;
            this.btnPDF.Text = "button1";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            this.btnPDF.MouseLeave += new System.EventHandler(this.btnPDF_MouseLeave);
            this.btnPDF.MouseHover += new System.EventHandler(this.btnPDF_MouseHover);
            // 
            // grpBox1
            // 
            this.grpBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grpBox1.Controls.Add(this.lblNomMotif);
            this.grpBox1.Controls.Add(this.lblNomStatus);
            this.grpBox1.Controls.Add(this.lblNomAdresse);
            this.grpBox1.Controls.Add(this.lblNomHeure);
            this.grpBox1.Controls.Add(this.lblNomDate);
            this.grpBox1.Controls.Add(this.lblNomCaserne);
            this.grpBox1.Controls.Add(this.lblNomId);
            this.grpBox1.Controls.Add(this.pictureBoxMission);
            this.grpBox1.Controls.Add(this.lblNatureSinistre);
            this.grpBox1.Controls.Add(this.lblStatus);
            this.grpBox1.Controls.Add(this.lblMotif);
            this.grpBox1.Controls.Add(this.lblCaserne);
            this.grpBox1.Controls.Add(this.lblAdresse);
            this.grpBox1.Controls.Add(this.lblHeure);
            this.grpBox1.Controls.Add(this.lblId);
            this.grpBox1.Controls.Add(this.lblDate);
            this.grpBox1.Location = new System.Drawing.Point(3, 3);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.Size = new System.Drawing.Size(1044, 233);
            this.grpBox1.TabIndex = 6;
            this.grpBox1.TabStop = false;
            this.grpBox1.Enter += new System.EventHandler(this.grpBox1_Enter);
            // 
            // lblNomMotif
            // 
            this.lblNomMotif.AutoSize = true;
            this.lblNomMotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomMotif.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblNomMotif.Location = new System.Drawing.Point(682, 125);
            this.lblNomMotif.Name = "lblNomMotif";
            this.lblNomMotif.Size = new System.Drawing.Size(161, 25);
            this.lblNomMotif.TabIndex = 15;
            this.lblNomMotif.Text = "Motif d\'appel :";
            // 
            // lblNomStatus
            // 
            this.lblNomStatus.AutoSize = true;
            this.lblNomStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomStatus.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblNomStatus.Location = new System.Drawing.Point(682, 88);
            this.lblNomStatus.Name = "lblNomStatus";
            this.lblNomStatus.Size = new System.Drawing.Size(93, 25);
            this.lblNomStatus.TabIndex = 14;
            this.lblNomStatus.Text = "Status :";
            // 
            // lblNomAdresse
            // 
            this.lblNomAdresse.AutoSize = true;
            this.lblNomAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomAdresse.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblNomAdresse.Location = new System.Drawing.Point(226, 200);
            this.lblNomAdresse.Name = "lblNomAdresse";
            this.lblNomAdresse.Size = new System.Drawing.Size(112, 25);
            this.lblNomAdresse.TabIndex = 13;
            this.lblNomAdresse.Text = "Adresse :";
            // 
            // lblNomHeure
            // 
            this.lblNomHeure.AutoSize = true;
            this.lblNomHeure.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomHeure.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblNomHeure.Location = new System.Drawing.Point(226, 162);
            this.lblNomHeure.Name = "lblNomHeure";
            this.lblNomHeure.Size = new System.Drawing.Size(89, 25);
            this.lblNomHeure.TabIndex = 12;
            this.lblNomHeure.Text = "Heure :";
            // 
            // lblNomDate
            // 
            this.lblNomDate.AutoSize = true;
            this.lblNomDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomDate.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblNomDate.Location = new System.Drawing.Point(226, 125);
            this.lblNomDate.Name = "lblNomDate";
            this.lblNomDate.Size = new System.Drawing.Size(75, 25);
            this.lblNomDate.TabIndex = 11;
            this.lblNomDate.Text = "Date :";
            // 
            // lblNomCaserne
            // 
            this.lblNomCaserne.AutoSize = true;
            this.lblNomCaserne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomCaserne.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblNomCaserne.Location = new System.Drawing.Point(226, 88);
            this.lblNomCaserne.Name = "lblNomCaserne";
            this.lblNomCaserne.Size = new System.Drawing.Size(114, 25);
            this.lblNomCaserne.TabIndex = 10;
            this.lblNomCaserne.Text = "Caserne :";
            // 
            // lblNomId
            // 
            this.lblNomId.AutoSize = true;
            this.lblNomId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomId.Location = new System.Drawing.Point(232, 33);
            this.lblNomId.Name = "lblNomId";
            this.lblNomId.Size = new System.Drawing.Size(45, 25);
            this.lblNomId.TabIndex = 9;
            this.lblNomId.Text = "id :";
            // 
            // pictureBoxMission
            // 
            this.pictureBoxMission.Location = new System.Drawing.Point(17, 26);
            this.pictureBoxMission.Name = "pictureBoxMission";
            this.pictureBoxMission.Size = new System.Drawing.Size(145, 142);
            this.pictureBoxMission.TabIndex = 8;
            this.pictureBoxMission.TabStop = false;
            this.pictureBoxMission.Click += new System.EventHandler(this.pictureBoxMission_Click);
            // 
            // lblNatureSinistre
            // 
            this.lblNatureSinistre.AutoSize = true;
            this.lblNatureSinistre.Font = new System.Drawing.Font("Rubik", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNatureSinistre.ForeColor = System.Drawing.Color.Firebrick;
            this.lblNatureSinistre.Location = new System.Drawing.Point(494, 26);
            this.lblNatureSinistre.Name = "lblNatureSinistre";
            this.lblNatureSinistre.Size = new System.Drawing.Size(178, 34);
            this.lblNatureSinistre.TabIndex = 7;
            this.lblNatureSinistre.Text = "type danger";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Navy;
            this.lblStatus.Location = new System.Drawing.Point(770, 88);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(95, 25);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "terminee";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.ForeColor = System.Drawing.Color.Navy;
            this.lblMotif.Location = new System.Drawing.Point(738, 163);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(114, 25);
            this.lblMotif.TabIndex = 5;
            this.lblMotif.Text = "MotifAppel";
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.ForeColor = System.Drawing.Color.Navy;
            this.lblCaserne.Location = new System.Drawing.Point(346, 88);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(93, 25);
            this.lblCaserne.TabIndex = 4;
            this.lblCaserne.Text = "Caserne";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.ForeColor = System.Drawing.Color.Navy;
            this.lblAdresse.Location = new System.Drawing.Point(344, 200);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(89, 25);
            this.lblAdresse.TabIndex = 3;
            this.lblAdresse.Text = "adresse";
            // 
            // lblHeure
            // 
            this.lblHeure.AutoSize = true;
            this.lblHeure.ForeColor = System.Drawing.Color.Navy;
            this.lblHeure.Location = new System.Drawing.Point(321, 162);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(67, 25);
            this.lblHeure.TabIndex = 2;
            this.lblHeure.Text = "heure";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(277, 31);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(117, 37);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "id mission";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.Color.Navy;
            this.lblDate.Location = new System.Drawing.Point(304, 125);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(54, 25);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "date";
            // 
            // AfficheMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTerminer);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.grpBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AfficheMission";
            this.Size = new System.Drawing.Size(1140, 240);
            this.grpBox1.ResumeLayout(false);
            this.grpBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMission)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTerminer;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.GroupBox grpBox1;
        private System.Windows.Forms.Label lblNomMotif;
        private System.Windows.Forms.Label lblNomStatus;
        private System.Windows.Forms.Label lblNomAdresse;
        private System.Windows.Forms.Label lblNomHeure;
        private System.Windows.Forms.Label lblNomDate;
        private System.Windows.Forms.Label lblNomCaserne;
        private System.Windows.Forms.Label lblNomId;
        private System.Windows.Forms.PictureBox pictureBoxMission;
        private System.Windows.Forms.Label lblNatureSinistre;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblDate;
    }
}
