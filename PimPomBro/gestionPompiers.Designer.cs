namespace PimPomBro
{
    partial class gestionPompiers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestionPompiers));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.picNouveau = new System.Windows.Forms.PictureBox();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.cboPompier = new System.Windows.Forms.ComboBox();
            this.cboCaserne = new System.Windows.Forms.ComboBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlInformationsDetaillees = new System.Windows.Forms.Panel();
            this.btnAppliquerModif = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.chkConge = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstAffectations = new System.Windows.Forms.ListBox();
            this.lstHabilitations = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboCaserneDeRattachement = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlPompier = new System.Windows.Forms.Panel();
            this.btnModifications = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblDateEmbauche = new System.Windows.Forms.Label();
            this.lblDateDeNaissance = new System.Windows.Forms.Label();
            this.lblSexe = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.gboCarriere = new System.Windows.Forms.GroupBox();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.lblBip = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbVolontaire = new System.Windows.Forms.RadioButton();
            this.rdbProfessionnel = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.lbl14 = new System.Windows.Forms.Label();
            this.lblConsigne = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNouveau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlInformationsDetaillees.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlPompier.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gboCarriere.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.picNouveau);
            this.panel1.Controls.Add(this.btnNouveau);
            this.panel1.Controls.Add(this.cboPompier);
            this.panel1.Controls.Add(this.cboCaserne);
            this.panel1.Location = new System.Drawing.Point(13, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 736);
            this.panel1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(120, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 25);
            this.label11.TabIndex = 4;
            this.label11.Text = "Caserne";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(120, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 25);
            this.label14.TabIndex = 5;
            this.label14.Text = "Pompier";
            // 
            // picNouveau
            // 
            this.picNouveau.Image = ((System.Drawing.Image)(resources.GetObject("picNouveau.Image")));
            this.picNouveau.Location = new System.Drawing.Point(85, 326);
            this.picNouveau.Name = "picNouveau";
            this.picNouveau.Size = new System.Drawing.Size(161, 184);
            this.picNouveau.TabIndex = 3;
            this.picNouveau.TabStop = false;
            this.picNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.Location = new System.Drawing.Point(85, 508);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(161, 87);
            this.btnNouveau.TabIndex = 2;
            this.btnNouveau.Text = "Nouveau Pompier";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // cboPompier
            // 
            this.cboPompier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPompier.FormattingEnabled = true;
            this.cboPompier.Location = new System.Drawing.Point(31, 186);
            this.cboPompier.Name = "cboPompier";
            this.cboPompier.Size = new System.Drawing.Size(265, 28);
            this.cboPompier.TabIndex = 1;
            this.cboPompier.SelectedIndexChanged += new System.EventHandler(this.cboPompier_SelectedIndexChanged);
            this.cboPompier.Click += new System.EventHandler(this.cboPompier_Click);
            // 
            // cboCaserne
            // 
            this.cboCaserne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(31, 60);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(265, 28);
            this.cboCaserne.TabIndex = 0;
            this.cboCaserne.SelectedIndexChanged += new System.EventHandler(this.cboCaserne_SelectedIndexChanged);
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(99, -17);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(160, 154);
            this.picLogo.TabIndex = 6;
            this.picLogo.TabStop = false;
            // 
            // pnlInformationsDetaillees
            // 
            this.pnlInformationsDetaillees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInformationsDetaillees.Controls.Add(this.btnAppliquerModif);
            this.pnlInformationsDetaillees.Controls.Add(this.btnAnnuler);
            this.pnlInformationsDetaillees.Controls.Add(this.chkConge);
            this.pnlInformationsDetaillees.Controls.Add(this.groupBox1);
            this.pnlInformationsDetaillees.Location = new System.Drawing.Point(17, 403);
            this.pnlInformationsDetaillees.Name = "pnlInformationsDetaillees";
            this.pnlInformationsDetaillees.Size = new System.Drawing.Size(529, 422);
            this.pnlInformationsDetaillees.TabIndex = 3;
            this.pnlInformationsDetaillees.Visible = false;
            // 
            // btnAppliquerModif
            // 
            this.btnAppliquerModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppliquerModif.Location = new System.Drawing.Point(298, 375);
            this.btnAppliquerModif.Name = "btnAppliquerModif";
            this.btnAppliquerModif.Size = new System.Drawing.Size(199, 32);
            this.btnAppliquerModif.TabIndex = 19;
            this.btnAppliquerModif.Text = "Valider les modifications";
            this.btnAppliquerModif.UseVisualStyleBackColor = true;
            this.btnAppliquerModif.Click += new System.EventHandler(this.btnAppliquerModif_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(174, 375);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(112, 32);
            this.btnAnnuler.TabIndex = 20;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // chkConge
            // 
            this.chkConge.AutoSize = true;
            this.chkConge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkConge.Location = new System.Drawing.Point(22, 375);
            this.chkConge.Name = "chkConge";
            this.chkConge.Size = new System.Drawing.Size(94, 24);
            this.chkConge.TabIndex = 18;
            this.chkConge.Text = "en congé";
            this.chkConge.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstAffectations);
            this.groupBox1.Controls.Add(this.lstHabilitations);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cboCaserneDeRattachement);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 347);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations carrière";
            // 
            // lstAffectations
            // 
            this.lstAffectations.FormattingEnabled = true;
            this.lstAffectations.ItemHeight = 20;
            this.lstAffectations.Location = new System.Drawing.Point(9, 238);
            this.lstAffectations.Name = "lstAffectations";
            this.lstAffectations.Size = new System.Drawing.Size(475, 104);
            this.lstAffectations.TabIndex = 16;
            // 
            // lstHabilitations
            // 
            this.lstHabilitations.FormattingEnabled = true;
            this.lstHabilitations.ItemHeight = 20;
            this.lstHabilitations.Location = new System.Drawing.Point(9, 91);
            this.lstHabilitations.Name = "lstHabilitations";
            this.lstHabilitations.Size = new System.Drawing.Size(477, 104);
            this.lstHabilitations.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Affectation passées :";
            // 
            // cboCaserneDeRattachement
            // 
            this.cboCaserneDeRattachement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCaserneDeRattachement.FormattingEnabled = true;
            this.cboCaserneDeRattachement.Location = new System.Drawing.Point(219, 30);
            this.cboCaserneDeRattachement.Name = "cboCaserneDeRattachement";
            this.cboCaserneDeRattachement.Size = new System.Drawing.Size(265, 28);
            this.cboCaserneDeRattachement.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 18);
            this.label12.TabIndex = 10;
            this.label12.Text = "Habilitations :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(207, 18);
            this.label13.TabIndex = 9;
            this.label13.Text = "Caserne de rattachement :";
            // 
            // pnlPompier
            // 
            this.pnlPompier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPompier.Controls.Add(this.pnlInformationsDetaillees);
            this.pnlPompier.Controls.Add(this.btnModifications);
            this.pnlPompier.Controls.Add(this.panel3);
            this.pnlPompier.Location = new System.Drawing.Point(350, 12);
            this.pnlPompier.Name = "pnlPompier";
            this.pnlPompier.Size = new System.Drawing.Size(563, 843);
            this.pnlPompier.TabIndex = 1;
            this.pnlPompier.Visible = false;
            // 
            // btnModifications
            // 
            this.btnModifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifications.ForeColor = System.Drawing.Color.DarkRed;
            this.btnModifications.Location = new System.Drawing.Point(159, 505);
            this.btnModifications.Name = "btnModifications";
            this.btnModifications.Size = new System.Drawing.Size(251, 63);
            this.btnModifications.TabIndex = 16;
            this.btnModifications.Text = "Plus d\'information / Modifications";
            this.btnModifications.UseVisualStyleBackColor = true;
            this.btnModifications.Click += new System.EventHandler(this.btnModifications_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.lblDateEmbauche);
            this.panel3.Controls.Add(this.lblDateDeNaissance);
            this.panel3.Controls.Add(this.lblSexe);
            this.panel3.Controls.Add(this.lblPrenom);
            this.panel3.Controls.Add(this.lblNom);
            this.panel3.Controls.Add(this.gboCarriere);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.rdbVolontaire);
            this.panel3.Controls.Add(this.rdbProfessionnel);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblMatricule);
            this.panel3.Controls.Add(this.lbl14);
            this.panel3.Location = new System.Drawing.Point(17, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(529, 375);
            this.panel3.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "Status :";
            // 
            // lblDateEmbauche
            // 
            this.lblDateEmbauche.AutoSize = true;
            this.lblDateEmbauche.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateEmbauche.Location = new System.Drawing.Point(156, 174);
            this.lblDateEmbauche.Name = "lblDateEmbauche";
            this.lblDateEmbauche.Size = new System.Drawing.Size(32, 18);
            this.lblDateEmbauche.TabIndex = 21;
            this.lblDateEmbauche.Text = "???";
            // 
            // lblDateDeNaissance
            // 
            this.lblDateDeNaissance.AutoSize = true;
            this.lblDateDeNaissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDeNaissance.Location = new System.Drawing.Point(414, 93);
            this.lblDateDeNaissance.Name = "lblDateDeNaissance";
            this.lblDateDeNaissance.Size = new System.Drawing.Size(32, 18);
            this.lblDateDeNaissance.TabIndex = 20;
            this.lblDateDeNaissance.Text = "???";
            // 
            // lblSexe
            // 
            this.lblSexe.AutoSize = true;
            this.lblSexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexe.Location = new System.Drawing.Point(325, 62);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(32, 18);
            this.lblSexe.TabIndex = 19;
            this.lblSexe.Text = "???";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(98, 89);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(35, 18);
            this.lblPrenom.TabIndex = 18;
            this.lblPrenom.Text = "???";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(75, 62);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 18);
            this.lblNom.TabIndex = 17;
            this.lblNom.Text = "???";
            // 
            // gboCarriere
            // 
            this.gboCarriere.Controls.Add(this.cboGrade);
            this.gboCarriere.Controls.Add(this.lblBip);
            this.gboCarriere.Controls.Add(this.label8);
            this.gboCarriere.Controls.Add(this.lblTelephone);
            this.gboCarriere.Controls.Add(this.txtGrade);
            this.gboCarriere.Controls.Add(this.label7);
            this.gboCarriere.Controls.Add(this.label6);
            this.gboCarriere.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gboCarriere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboCarriere.Location = new System.Drawing.Point(22, 218);
            this.gboCarriere.Name = "gboCarriere";
            this.gboCarriere.Size = new System.Drawing.Size(477, 143);
            this.gboCarriere.TabIndex = 16;
            this.gboCarriere.TabStop = false;
            this.gboCarriere.Text = "Carrière";
            // 
            // cboGrade
            // 
            this.cboGrade.Enabled = false;
            this.cboGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(194, 37);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(176, 28);
            this.cboGrade.TabIndex = 16;
            this.cboGrade.SelectedIndexChanged += new System.EventHandler(this.cboGrade_SelectedIndexChanged);
            // 
            // lblBip
            // 
            this.lblBip.AutoSize = true;
            this.lblBip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBip.Location = new System.Drawing.Point(351, 98);
            this.lblBip.Name = "lblBip";
            this.lblBip.Size = new System.Drawing.Size(35, 18);
            this.lblBip.TabIndex = 14;
            this.lblBip.Text = "???";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(302, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Bip :";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.Location = new System.Drawing.Point(116, 98);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(35, 18);
            this.lblTelephone.TabIndex = 12;
            this.lblTelephone.Text = "???";
            // 
            // txtGrade
            // 
            this.txtGrade.Enabled = false;
            this.txtGrade.Location = new System.Drawing.Point(84, 37);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(86, 26);
            this.txtGrade.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Téléphone :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Grade :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Date d\'embauche :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(270, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sexe :";
            // 
            // rdbVolontaire
            // 
            this.rdbVolontaire.AutoSize = true;
            this.rdbVolontaire.Enabled = false;
            this.rdbVolontaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbVolontaire.Location = new System.Drawing.Point(216, 139);
            this.rdbVolontaire.Name = "rdbVolontaire";
            this.rdbVolontaire.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdbVolontaire.Size = new System.Drawing.Size(92, 22);
            this.rdbVolontaire.TabIndex = 13;
            this.rdbVolontaire.TabStop = true;
            this.rdbVolontaire.Text = "Volontaire";
            this.rdbVolontaire.UseVisualStyleBackColor = true;
            // 
            // rdbProfessionnel
            // 
            this.rdbProfessionnel.AutoSize = true;
            this.rdbProfessionnel.Enabled = false;
            this.rdbProfessionnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbProfessionnel.Location = new System.Drawing.Point(83, 139);
            this.rdbProfessionnel.Name = "rdbProfessionnel";
            this.rdbProfessionnel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdbProfessionnel.Size = new System.Drawing.Size(117, 22);
            this.rdbProfessionnel.TabIndex = 12;
            this.rdbProfessionnel.TabStop = true;
            this.rdbProfessionnel.Text = "Professionnel";
            this.rdbProfessionnel.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(270, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date de naissance :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prénom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nom :";
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricule.Location = new System.Drawing.Point(292, 10);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(74, 31);
            this.lblMatricule.TabIndex = 7;
            this.lblMatricule.Text = "????";
            // 
            // lbl14
            // 
            this.lbl14.AutoSize = true;
            this.lbl14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl14.Location = new System.Drawing.Point(162, 10);
            this.lbl14.Name = "lbl14";
            this.lbl14.Size = new System.Drawing.Size(124, 31);
            this.lbl14.TabIndex = 6;
            this.lbl14.Text = "Matricule";
            // 
            // lblConsigne
            // 
            this.lblConsigne.AutoSize = true;
            this.lblConsigne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsigne.Location = new System.Drawing.Point(478, 209);
            this.lblConsigne.Name = "lblConsigne";
            this.lblConsigne.Size = new System.Drawing.Size(346, 25);
            this.lblConsigne.TabIndex = 2;
            this.lblConsigne.Text = "Veuillez selectionnez une caserne.";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(85, 659);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "revenir au menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gestionPompiers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(925, 868);
            this.Controls.Add(this.pnlPompier);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblConsigne);
            this.Controls.Add(this.picLogo);
            this.Name = "gestionPompiers";
            this.Text = "Gestion du Personnel";
            this.Load += new System.EventHandler(this.gestionPompiers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNouveau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlInformationsDetaillees.ResumeLayout(false);
            this.pnlInformationsDetaillees.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlPompier.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gboCarriere.ResumeLayout(false);
            this.gboCarriere.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboPompier;
        private System.Windows.Forms.ComboBox cboCaserne;
        private System.Windows.Forms.PictureBox picNouveau;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Panel pnlPompier;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.Label lbl14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbVolontaire;
        private System.Windows.Forms.RadioButton rdbProfessionnel;
        private System.Windows.Forms.GroupBox gboCarriere;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblSexe;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblDateEmbauche;
        private System.Windows.Forms.Label lblDateDeNaissance;
        private System.Windows.Forms.Label lblBip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Panel pnlInformationsDetaillees;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboCaserneDeRattachement;
        private System.Windows.Forms.Button btnModifications;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblConsigne;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkConge;
        private System.Windows.Forms.Button btnAppliquerModif;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.ListBox lstHabilitations;
        private System.Windows.Forms.ListBox lstAffectations;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button button1;
    }
}