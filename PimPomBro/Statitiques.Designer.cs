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
            this.lblPompiersParHabilitation = new System.Windows.Forms.Label();
            this.txtHabilitation3 = new System.Windows.Forms.TextBox();
            this.txtHabilitation2 = new System.Windows.Forms.TextBox();
            this.lblTypesHabilitations = new System.Windows.Forms.Label();
            this.lblTypeSinistre = new System.Windows.Forms.Label();
            this.cboHabilitations = new System.Windows.Forms.ComboBox();
            this.txtHabilitation1 = new System.Windows.Forms.TextBox();
            this.lblHabilitationsSolicitees = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txtNbInterventions = new System.Windows.Forms.TextBox();
            this.lblNbInterventions = new System.Windows.Forms.Label();
            this.cboTypesSinistres = new System.Windows.Forms.ComboBox();
            this.precis = new System.Windows.Forms.TabPage();
            this.lblHeuresParEngin = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblEngins = new System.Windows.Forms.Label();
            this.txtEngin3 = new System.Windows.Forms.TextBox();
            this.txtEngin2 = new System.Windows.Forms.TextBox();
            this.txtEngin1 = new System.Windows.Forms.TextBox();
            this.lblCasernes = new System.Windows.Forms.Label();
            this.cboCasernes = new System.Windows.Forms.ComboBox();
            this.tabControl.SuspendLayout();
            this.General.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.precis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.General);
            this.tabControl.Controls.Add(this.precis);
            this.tabControl.Location = new System.Drawing.Point(21, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1499, 691);
            this.tabControl.TabIndex = 1;
            // 
            // General
            // 
            this.General.BackColor = System.Drawing.Color.LightGray;
            this.General.Controls.Add(this.lblPompiersParHabilitation);
            this.General.Controls.Add(this.txtHabilitation3);
            this.General.Controls.Add(this.txtHabilitation2);
            this.General.Controls.Add(this.lblTypesHabilitations);
            this.General.Controls.Add(this.lblTypeSinistre);
            this.General.Controls.Add(this.cboHabilitations);
            this.General.Controls.Add(this.txtHabilitation1);
            this.General.Controls.Add(this.lblHabilitationsSolicitees);
            this.General.Controls.Add(this.dataGridView);
            this.General.Controls.Add(this.txtNbInterventions);
            this.General.Controls.Add(this.lblNbInterventions);
            this.General.Controls.Add(this.cboTypesSinistres);
            this.General.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.General.Location = new System.Drawing.Point(4, 38);
            this.General.Name = "General";
            this.General.Padding = new System.Windows.Forms.Padding(3);
            this.General.Size = new System.Drawing.Size(1491, 649);
            this.General.TabIndex = 0;
            this.General.Text = "Infos Generales";
            // 
            // lblPompiersParHabilitation
            // 
            this.lblPompiersParHabilitation.AutoSize = true;
            this.lblPompiersParHabilitation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblPompiersParHabilitation.ForeColor = System.Drawing.Color.Navy;
            this.lblPompiersParHabilitation.Location = new System.Drawing.Point(639, 213);
            this.lblPompiersParHabilitation.Name = "lblPompiersParHabilitation";
            this.lblPompiersParHabilitation.Size = new System.Drawing.Size(319, 29);
            this.lblPompiersParHabilitation.TabIndex = 11;
            this.lblPompiersParHabilitation.Text = "Pompiers par habilitation :";
            // 
            // txtHabilitation3
            // 
            this.txtHabilitation3.Location = new System.Drawing.Point(1006, 153);
            this.txtHabilitation3.Name = "txtHabilitation3";
            this.txtHabilitation3.Size = new System.Drawing.Size(283, 35);
            this.txtHabilitation3.TabIndex = 10;
            // 
            // txtHabilitation2
            // 
            this.txtHabilitation2.Location = new System.Drawing.Point(1006, 112);
            this.txtHabilitation2.Name = "txtHabilitation2";
            this.txtHabilitation2.Size = new System.Drawing.Size(283, 35);
            this.txtHabilitation2.TabIndex = 9;
            // 
            // lblTypesHabilitations
            // 
            this.lblTypesHabilitations.AutoSize = true;
            this.lblTypesHabilitations.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblTypesHabilitations.ForeColor = System.Drawing.Color.Navy;
            this.lblTypesHabilitations.Location = new System.Drawing.Point(34, 251);
            this.lblTypesHabilitations.Name = "lblTypesHabilitations";
            this.lblTypesHabilitations.Size = new System.Drawing.Size(267, 29);
            this.lblTypesHabilitations.TabIndex = 8;
            this.lblTypesHabilitations.Text = "Types d\'habilitations :";
            // 
            // lblTypeSinistre
            // 
            this.lblTypeSinistre.AutoSize = true;
            this.lblTypeSinistre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeSinistre.ForeColor = System.Drawing.Color.Navy;
            this.lblTypeSinistre.Location = new System.Drawing.Point(34, 42);
            this.lblTypeSinistre.Name = "lblTypeSinistre";
            this.lblTypeSinistre.Size = new System.Drawing.Size(241, 29);
            this.lblTypeSinistre.TabIndex = 7;
            this.lblTypeSinistre.Text = "Types de sinistres :";
            // 
            // cboHabilitations
            // 
            this.cboHabilitations.FormattingEnabled = true;
            this.cboHabilitations.Location = new System.Drawing.Point(26, 296);
            this.cboHabilitations.Name = "cboHabilitations";
            this.cboHabilitations.Size = new System.Drawing.Size(496, 37);
            this.cboHabilitations.TabIndex = 6;
            // 
            // txtHabilitation1
            // 
            this.txtHabilitation1.Location = new System.Drawing.Point(1006, 71);
            this.txtHabilitation1.Name = "txtHabilitation1";
            this.txtHabilitation1.Size = new System.Drawing.Size(283, 35);
            this.txtHabilitation1.TabIndex = 5;
            // 
            // lblHabilitationsSolicitees
            // 
            this.lblHabilitationsSolicitees.AutoSize = true;
            this.lblHabilitationsSolicitees.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblHabilitationsSolicitees.ForeColor = System.Drawing.Color.Navy;
            this.lblHabilitationsSolicitees.Location = new System.Drawing.Point(639, 77);
            this.lblHabilitationsSolicitees.Name = "lblHabilitationsSolicitees";
            this.lblHabilitationsSolicitees.Size = new System.Drawing.Size(361, 29);
            this.lblHabilitationsSolicitees.TabIndex = 4;
            this.lblHabilitationsSolicitees.Text = "Habilitation les plus solicites :";
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(644, 245);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(811, 380);
            this.dataGridView.TabIndex = 3;
            // 
            // txtNbInterventions
            // 
            this.txtNbInterventions.Location = new System.Drawing.Point(955, 15);
            this.txtNbInterventions.Name = "txtNbInterventions";
            this.txtNbInterventions.Size = new System.Drawing.Size(100, 35);
            this.txtNbInterventions.TabIndex = 2;
            // 
            // lblNbInterventions
            // 
            this.lblNbInterventions.AutoSize = true;
            this.lblNbInterventions.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblNbInterventions.ForeColor = System.Drawing.Color.Navy;
            this.lblNbInterventions.Location = new System.Drawing.Point(639, 15);
            this.lblNbInterventions.Name = "lblNbInterventions";
            this.lblNbInterventions.Size = new System.Drawing.Size(297, 29);
            this.lblNbInterventions.TabIndex = 1;
            this.lblNbInterventions.Text = "Nombre d\'interventions :";
            // 
            // cboTypesSinistres
            // 
            this.cboTypesSinistres.FormattingEnabled = true;
            this.cboTypesSinistres.Location = new System.Drawing.Point(26, 77);
            this.cboTypesSinistres.Name = "cboTypesSinistres";
            this.cboTypesSinistres.Size = new System.Drawing.Size(496, 37);
            this.cboTypesSinistres.TabIndex = 0;
            // 
            // precis
            // 
            this.precis.BackColor = System.Drawing.Color.LightGray;
            this.precis.Controls.Add(this.lblHeuresParEngin);
            this.precis.Controls.Add(this.dataGridView1);
            this.precis.Controls.Add(this.lblEngins);
            this.precis.Controls.Add(this.txtEngin3);
            this.precis.Controls.Add(this.txtEngin2);
            this.precis.Controls.Add(this.txtEngin1);
            this.precis.Controls.Add(this.lblCasernes);
            this.precis.Controls.Add(this.cboCasernes);
            this.precis.ForeColor = System.Drawing.Color.Black;
            this.precis.Location = new System.Drawing.Point(4, 38);
            this.precis.Name = "precis";
            this.precis.Padding = new System.Windows.Forms.Padding(3);
            this.precis.Size = new System.Drawing.Size(1486, 653);
            this.precis.TabIndex = 1;
            this.precis.Text = "Caserne Precise";
            // 
            // lblHeuresParEngin
            // 
            this.lblHeuresParEngin.AutoSize = true;
            this.lblHeuresParEngin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblHeuresParEngin.ForeColor = System.Drawing.Color.Navy;
            this.lblHeuresParEngin.Location = new System.Drawing.Point(685, 218);
            this.lblHeuresParEngin.Name = "lblHeuresParEngin";
            this.lblHeuresParEngin.Size = new System.Drawing.Size(451, 29);
            this.lblHeuresParEngin.TabIndex = 7;
            this.lblHeuresParEngin.Text = "Heures d\'utilisation de chaque engin :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(690, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(756, 359);
            this.dataGridView1.TabIndex = 6;
            // 
            // lblEngins
            // 
            this.lblEngins.AutoSize = true;
            this.lblEngins.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngins.ForeColor = System.Drawing.Color.Navy;
            this.lblEngins.Location = new System.Drawing.Point(862, 30);
            this.lblEngins.Name = "lblEngins";
            this.lblEngins.Size = new System.Drawing.Size(295, 29);
            this.lblEngins.TabIndex = 5;
            this.lblEngins.Text = "Engins les plus utilises :";
            // 
            // txtEngin3
            // 
            this.txtEngin3.Location = new System.Drawing.Point(1163, 132);
            this.txtEngin3.Name = "txtEngin3";
            this.txtEngin3.Size = new System.Drawing.Size(249, 35);
            this.txtEngin3.TabIndex = 4;
            // 
            // txtEngin2
            // 
            this.txtEngin2.Location = new System.Drawing.Point(1163, 82);
            this.txtEngin2.Name = "txtEngin2";
            this.txtEngin2.Size = new System.Drawing.Size(249, 35);
            this.txtEngin2.TabIndex = 3;
            // 
            // txtEngin1
            // 
            this.txtEngin1.Location = new System.Drawing.Point(1163, 30);
            this.txtEngin1.Name = "txtEngin1";
            this.txtEngin1.Size = new System.Drawing.Size(249, 35);
            this.txtEngin1.TabIndex = 2;
            // 
            // lblCasernes
            // 
            this.lblCasernes.AutoSize = true;
            this.lblCasernes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCasernes.ForeColor = System.Drawing.Color.Navy;
            this.lblCasernes.Location = new System.Drawing.Point(26, 80);
            this.lblCasernes.Name = "lblCasernes";
            this.lblCasernes.Size = new System.Drawing.Size(258, 29);
            this.lblCasernes.TabIndex = 1;
            this.lblCasernes.Text = "Choix de la caserne :";
            // 
            // cboCasernes
            // 
            this.cboCasernes.FormattingEnabled = true;
            this.cboCasernes.Location = new System.Drawing.Point(31, 112);
            this.cboCasernes.Name = "cboCasernes";
            this.cboCasernes.Size = new System.Drawing.Size(478, 37);
            this.cboCasernes.TabIndex = 0;
            // 
            // Statitiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1534, 711);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Statitiques";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.General.ResumeLayout(false);
            this.General.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.precis.ResumeLayout(false);
            this.precis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage General;
        private System.Windows.Forms.Label lblPompiersParHabilitation;
        private System.Windows.Forms.TextBox txtHabilitation3;
        private System.Windows.Forms.TextBox txtHabilitation2;
        private System.Windows.Forms.Label lblTypesHabilitations;
        private System.Windows.Forms.Label lblTypeSinistre;
        private System.Windows.Forms.ComboBox cboHabilitations;
        private System.Windows.Forms.TextBox txtHabilitation1;
        private System.Windows.Forms.Label lblHabilitationsSolicitees;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txtNbInterventions;
        private System.Windows.Forms.Label lblNbInterventions;
        private System.Windows.Forms.ComboBox cboTypesSinistres;
        private System.Windows.Forms.TabPage precis;
        private System.Windows.Forms.Label lblHeuresParEngin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblEngins;
        private System.Windows.Forms.TextBox txtEngin3;
        private System.Windows.Forms.TextBox txtEngin2;
        private System.Windows.Forms.TextBox txtEngin1;
        private System.Windows.Forms.Label lblCasernes;
        private System.Windows.Forms.ComboBox cboCasernes;
    }
}