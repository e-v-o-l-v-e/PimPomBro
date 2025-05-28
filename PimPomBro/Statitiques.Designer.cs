namespace PimPomBro
{
    partial class Statitiques
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.General = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRetour1 = new System.Windows.Forms.Button();
            this.lblPompiersParHabilitation = new System.Windows.Forms.Label();
            this.lblTypesHabilitations = new System.Windows.Forms.Label();
            this.lblTypeSinistre = new System.Windows.Forms.Label();
            this.cboHabilitations = new System.Windows.Forms.ComboBox();
            this.lblHabilitationsSolicitees = new System.Windows.Forms.Label();
            this.txtNbInterventions = new System.Windows.Forms.TextBox();
            this.lblNbInterventions = new System.Windows.Forms.Label();
            this.cboTypesSinistres = new System.Windows.Forms.ComboBox();
            this.precis = new System.Windows.Forms.TabPage();
            this.lblUtilisations = new System.Windows.Forms.Label();
            this.panelCumulEngin = new System.Windows.Forms.Panel();
            this.lblNumEngin = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblEnginBest = new System.Windows.Forms.Label();
            this.btnRetour2 = new System.Windows.Forms.Button();
            this.lblHeuresParEngin = new System.Windows.Forms.Label();
            this.lblEngins = new System.Windows.Forms.Label();
            this.lblCasernes = new System.Windows.Forms.Label();
            this.cboCasernes = new System.Windows.Forms.ComboBox();
            this.panelPompiers = new System.Windows.Forms.Panel();
            this.tabControl.SuspendLayout();
            this.General.SuspendLayout();
            this.precis.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.General);
            this.tabControl.Controls.Add(this.precis);
            this.tabControl.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(21, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1347, 691);
            this.tabControl.TabIndex = 1;
            // 
            // General
            // 
            this.General.BackColor = System.Drawing.SystemColors.Control;
            this.General.Controls.Add(this.panelPompiers);
            this.General.Controls.Add(this.button1);
            this.General.Controls.Add(this.btnRetour1);
            this.General.Controls.Add(this.lblPompiersParHabilitation);
            this.General.Controls.Add(this.lblTypesHabilitations);
            this.General.Controls.Add(this.lblTypeSinistre);
            this.General.Controls.Add(this.cboHabilitations);
            this.General.Controls.Add(this.lblHabilitationsSolicitees);
            this.General.Controls.Add(this.txtNbInterventions);
            this.General.Controls.Add(this.lblNbInterventions);
            this.General.Controls.Add(this.cboTypesSinistres);
            this.General.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.General.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.General.Location = new System.Drawing.Point(4, 40);
            this.General.Name = "General";
            this.General.Padding = new System.Windows.Forms.Padding(3);
            this.General.Size = new System.Drawing.Size(1339, 647);
            this.General.TabIndex = 0;
            this.General.Text = "Infos Generales";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.ForeColor = System.Drawing.Color.Gold;
            this.button1.Location = new System.Drawing.Point(1032, 577);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 47);
            this.button1.TabIndex = 17;
            this.button1.Text = "Ajouter un pompier ➤";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRetour1
            // 
            this.btnRetour1.BackColor = System.Drawing.Color.Navy;
            this.btnRetour1.ForeColor = System.Drawing.Color.Gold;
            this.btnRetour1.Location = new System.Drawing.Point(26, 577);
            this.btnRetour1.Name = "btnRetour1";
            this.btnRetour1.Size = new System.Drawing.Size(197, 47);
            this.btnRetour1.TabIndex = 12;
            this.btnRetour1.Text = "Retour Menu";
            this.btnRetour1.UseVisualStyleBackColor = false;
            this.btnRetour1.Click += new System.EventHandler(this.btnRetour1_Click);
            // 
            // lblPompiersParHabilitation
            // 
            this.lblPompiersParHabilitation.AutoSize = true;
            this.lblPompiersParHabilitation.Font = new System.Drawing.Font("Arial Narrow", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPompiersParHabilitation.ForeColor = System.Drawing.Color.Navy;
            this.lblPompiersParHabilitation.Location = new System.Drawing.Point(757, 19);
            this.lblPompiersParHabilitation.Name = "lblPompiersParHabilitation";
            this.lblPompiersParHabilitation.Size = new System.Drawing.Size(294, 31);
            this.lblPompiersParHabilitation.TabIndex = 11;
            this.lblPompiersParHabilitation.Text = "Pompiers par habilitation :";
            // 
            // lblTypesHabilitations
            // 
            this.lblTypesHabilitations.AutoSize = true;
            this.lblTypesHabilitations.Font = new System.Drawing.Font("Arial Narrow", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypesHabilitations.ForeColor = System.Drawing.Color.Navy;
            this.lblTypesHabilitations.Location = new System.Drawing.Point(20, 380);
            this.lblTypesHabilitations.Name = "lblTypesHabilitations";
            this.lblTypesHabilitations.Size = new System.Drawing.Size(246, 31);
            this.lblTypesHabilitations.TabIndex = 8;
            this.lblTypesHabilitations.Text = "Types d\'habilitations :";
            // 
            // lblTypeSinistre
            // 
            this.lblTypeSinistre.AutoSize = true;
            this.lblTypeSinistre.Font = new System.Drawing.Font("Arial Narrow", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeSinistre.ForeColor = System.Drawing.Color.Navy;
            this.lblTypeSinistre.Location = new System.Drawing.Point(20, 171);
            this.lblTypeSinistre.Name = "lblTypeSinistre";
            this.lblTypeSinistre.Size = new System.Drawing.Size(219, 31);
            this.lblTypeSinistre.TabIndex = 7;
            this.lblTypeSinistre.Text = "Types de sinistres :";
            // 
            // cboHabilitations
            // 
            this.cboHabilitations.FormattingEnabled = true;
            this.cboHabilitations.Location = new System.Drawing.Point(12, 425);
            this.cboHabilitations.Name = "cboHabilitations";
            this.cboHabilitations.Size = new System.Drawing.Size(496, 39);
            this.cboHabilitations.TabIndex = 6;
            this.cboHabilitations.SelectedIndexChanged += new System.EventHandler(this.cboHabilitations_SelectedIndexChanged);
            // 
            // lblHabilitationsSolicitees
            // 
            this.lblHabilitationsSolicitees.AutoSize = true;
            this.lblHabilitationsSolicitees.Font = new System.Drawing.Font("Arial Narrow", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabilitationsSolicitees.ForeColor = System.Drawing.Color.Navy;
            this.lblHabilitationsSolicitees.Location = new System.Drawing.Point(19, 19);
            this.lblHabilitationsSolicitees.Name = "lblHabilitationsSolicitees";
            this.lblHabilitationsSolicitees.Size = new System.Drawing.Size(316, 31);
            this.lblHabilitationsSolicitees.TabIndex = 4;
            this.lblHabilitationsSolicitees.Text = "Habilitation la plus solicitee :";
            this.lblHabilitationsSolicitees.Click += new System.EventHandler(this.lblHabilitationsSolicitees_Click);
            // 
            // txtNbInterventions
            // 
            this.txtNbInterventions.Location = new System.Drawing.Point(354, 251);
            this.txtNbInterventions.Name = "txtNbInterventions";
            this.txtNbInterventions.Size = new System.Drawing.Size(100, 38);
            this.txtNbInterventions.TabIndex = 2;
            this.txtNbInterventions.TextChanged += new System.EventHandler(this.txtNbInterventions_TextChanged);
            this.txtNbInterventions.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNbInterventions_KeyPress);
            // 
            // lblNbInterventions
            // 
            this.lblNbInterventions.AutoSize = true;
            this.lblNbInterventions.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbInterventions.ForeColor = System.Drawing.Color.Navy;
            this.lblNbInterventions.Location = new System.Drawing.Point(89, 257);
            this.lblNbInterventions.Name = "lblNbInterventions";
            this.lblNbInterventions.Size = new System.Drawing.Size(246, 29);
            this.lblNbInterventions.TabIndex = 1;
            this.lblNbInterventions.Text = "Nombre d\'interventions :";
            // 
            // cboTypesSinistres
            // 
            this.cboTypesSinistres.FormattingEnabled = true;
            this.cboTypesSinistres.Location = new System.Drawing.Point(12, 206);
            this.cboTypesSinistres.Name = "cboTypesSinistres";
            this.cboTypesSinistres.Size = new System.Drawing.Size(496, 39);
            this.cboTypesSinistres.TabIndex = 0;
            this.cboTypesSinistres.SelectedIndexChanged += new System.EventHandler(this.cboTypesSinistres_SelectedIndexChanged);
            // 
            // precis
            // 
            this.precis.BackColor = System.Drawing.SystemColors.Control;
            this.precis.Controls.Add(this.lblUtilisations);
            this.precis.Controls.Add(this.panelCumulEngin);
            this.precis.Controls.Add(this.lblNumEngin);
            this.precis.Controls.Add(this.lblType);
            this.precis.Controls.Add(this.lblEnginBest);
            this.precis.Controls.Add(this.btnRetour2);
            this.precis.Controls.Add(this.lblHeuresParEngin);
            this.precis.Controls.Add(this.lblEngins);
            this.precis.Controls.Add(this.lblCasernes);
            this.precis.Controls.Add(this.cboCasernes);
            this.precis.ForeColor = System.Drawing.Color.Black;
            this.precis.Location = new System.Drawing.Point(4, 40);
            this.precis.Name = "precis";
            this.precis.Padding = new System.Windows.Forms.Padding(3);
            this.precis.Size = new System.Drawing.Size(1339, 647);
            this.precis.TabIndex = 1;
            this.precis.Text = "Par Caserne";
            // 
            // lblUtilisations
            // 
            this.lblUtilisations.AutoSize = true;
            this.lblUtilisations.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilisations.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblUtilisations.Location = new System.Drawing.Point(892, 65);
            this.lblUtilisations.Name = "lblUtilisations";
            this.lblUtilisations.Size = new System.Drawing.Size(149, 62);
            this.lblUtilisations.TabIndex = 3;
            this.lblUtilisations.Text = "     Heures\r\nd\'utilisations";
            // 
            // panelCumulEngin
            // 
            this.panelCumulEngin.AutoScroll = true;
            this.panelCumulEngin.Location = new System.Drawing.Point(641, 135);
            this.panelCumulEngin.Name = "panelCumulEngin";
            this.panelCumulEngin.Size = new System.Drawing.Size(544, 444);
            this.panelCumulEngin.TabIndex = 15;
            // 
            // lblNumEngin
            // 
            this.lblNumEngin.AutoSize = true;
            this.lblNumEngin.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumEngin.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblNumEngin.Location = new System.Drawing.Point(780, 65);
            this.lblNumEngin.Name = "lblNumEngin";
            this.lblNumEngin.Size = new System.Drawing.Size(99, 62);
            this.lblNumEngin.TabIndex = 2;
            this.lblNumEngin.Text = "Numero\r\nd\'engin";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblType.Location = new System.Drawing.Point(663, 63);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(93, 62);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "  Type\r\nd\'engin";
            // 
            // lblEnginBest
            // 
            this.lblEnginBest.AutoSize = true;
            this.lblEnginBest.BackColor = System.Drawing.Color.Transparent;
            this.lblEnginBest.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnginBest.Location = new System.Drawing.Point(296, 22);
            this.lblEnginBest.Name = "lblEnginBest";
            this.lblEnginBest.Size = new System.Drawing.Size(76, 31);
            this.lblEnginBest.TabIndex = 14;
            this.lblEnginBest.Text = "label1";
            // 
            // btnRetour2
            // 
            this.btnRetour2.BackColor = System.Drawing.Color.Navy;
            this.btnRetour2.ForeColor = System.Drawing.Color.Gold;
            this.btnRetour2.Location = new System.Drawing.Point(24, 577);
            this.btnRetour2.Name = "btnRetour2";
            this.btnRetour2.Size = new System.Drawing.Size(197, 47);
            this.btnRetour2.TabIndex = 13;
            this.btnRetour2.Text = "Retour Menu";
            this.btnRetour2.UseVisualStyleBackColor = false;
            this.btnRetour2.Click += new System.EventHandler(this.btnRetour1_Click);
            // 
            // lblHeuresParEngin
            // 
            this.lblHeuresParEngin.AutoSize = true;
            this.lblHeuresParEngin.Font = new System.Drawing.Font("Arial Narrow", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblHeuresParEngin.ForeColor = System.Drawing.Color.Navy;
            this.lblHeuresParEngin.Location = new System.Drawing.Point(635, 22);
            this.lblHeuresParEngin.Name = "lblHeuresParEngin";
            this.lblHeuresParEngin.Size = new System.Drawing.Size(413, 31);
            this.lblHeuresParEngin.TabIndex = 7;
            this.lblHeuresParEngin.Text = "Heures d\'utilisation de chaque engin :";
            // 
            // lblEngins
            // 
            this.lblEngins.AutoSize = true;
            this.lblEngins.Font = new System.Drawing.Font("Arial Narrow", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblEngins.ForeColor = System.Drawing.Color.Navy;
            this.lblEngins.Location = new System.Drawing.Point(19, 22);
            this.lblEngins.Name = "lblEngins";
            this.lblEngins.Size = new System.Drawing.Size(271, 31);
            this.lblEngins.TabIndex = 5;
            this.lblEngins.Text = "Engins les plus utilises :";
            // 
            // lblCasernes
            // 
            this.lblCasernes.AutoSize = true;
            this.lblCasernes.Font = new System.Drawing.Font("Arial Narrow", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCasernes.ForeColor = System.Drawing.Color.Navy;
            this.lblCasernes.Location = new System.Drawing.Point(19, 96);
            this.lblCasernes.Name = "lblCasernes";
            this.lblCasernes.Size = new System.Drawing.Size(234, 31);
            this.lblCasernes.TabIndex = 1;
            this.lblCasernes.Text = "Choix de la caserne :";
            // 
            // cboCasernes
            // 
            this.cboCasernes.FormattingEnabled = true;
            this.cboCasernes.Location = new System.Drawing.Point(24, 128);
            this.cboCasernes.Name = "cboCasernes";
            this.cboCasernes.Size = new System.Drawing.Size(478, 39);
            this.cboCasernes.TabIndex = 0;
            this.cboCasernes.SelectedIndexChanged += new System.EventHandler(this.cboCasernes_SelectedIndexChanged);
            // 
            // panelPompiers
            // 
            this.panelPompiers.AutoScroll = true;
            this.panelPompiers.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelPompiers.Location = new System.Drawing.Point(763, 84);
            this.panelPompiers.Name = "panelPompiers";
            this.panelPompiers.Size = new System.Drawing.Size(533, 380);
            this.panelPompiers.TabIndex = 18;
            // 
            // Statitiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1387, 711);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Statitiques";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Statistiques";
            this.Load += new System.EventHandler(this.Statitiques_Load);
            this.tabControl.ResumeLayout(false);
            this.General.ResumeLayout(false);
            this.General.PerformLayout();
            this.precis.ResumeLayout(false);
            this.precis.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage General;
        private System.Windows.Forms.Label lblPompiersParHabilitation;
        private System.Windows.Forms.Label lblTypesHabilitations;
        private System.Windows.Forms.Label lblTypeSinistre;
        private System.Windows.Forms.ComboBox cboHabilitations;
        private System.Windows.Forms.Label lblHabilitationsSolicitees;
        private System.Windows.Forms.TextBox txtNbInterventions;
        private System.Windows.Forms.Label lblNbInterventions;
        private System.Windows.Forms.ComboBox cboTypesSinistres;
        private System.Windows.Forms.TabPage precis;
        private System.Windows.Forms.Label lblHeuresParEngin;
        private System.Windows.Forms.Label lblEngins;
        private System.Windows.Forms.Label lblCasernes;
        private System.Windows.Forms.ComboBox cboCasernes;
        private System.Windows.Forms.Button btnRetour1;
        private System.Windows.Forms.Button btnRetour2;
        private System.Windows.Forms.Label lblEnginBest;
        private System.Windows.Forms.Panel panelCumulEngin;
        private System.Windows.Forms.Label lblUtilisations;
        private System.Windows.Forms.Label lblNumEngin;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelPompiers;
    }
}