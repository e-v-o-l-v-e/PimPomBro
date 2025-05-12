namespace ControlePimPomBro
{
    partial class UserControl1
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
            this.grpBox1 = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblSinistre = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblHeure = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.btnPDf = new System.Windows.Forms.Button();
            this.btnAccomplie = new System.Windows.Forms.Button();
            this.grpBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox1
            // 
            this.grpBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.grpBox1.Controls.Add(this.lblCaserne);
            this.grpBox1.Controls.Add(this.lblMotif);
            this.grpBox1.Controls.Add(this.lblStatus);
            this.grpBox1.Controls.Add(this.lblId);
            this.grpBox1.Controls.Add(this.lblAdresse);
            this.grpBox1.Controls.Add(this.lblSinistre);
            this.grpBox1.Controls.Add(this.lblHeure);
            this.grpBox1.Controls.Add(this.lblDate);
            this.grpBox1.Location = new System.Drawing.Point(60, 45);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.Size = new System.Drawing.Size(572, 284);
            this.grpBox1.TabIndex = 0;
            this.grpBox1.TabStop = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(216, 27);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(31, 25);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "id";
            // 
            // lblSinistre
            // 
            this.lblSinistre.AutoSize = true;
            this.lblSinistre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinistre.ForeColor = System.Drawing.Color.Firebrick;
            this.lblSinistre.Location = new System.Drawing.Point(299, 26);
            this.lblSinistre.Name = "lblSinistre";
            this.lblSinistre.Size = new System.Drawing.Size(57, 25);
            this.lblSinistre.TabIndex = 2;
            this.lblSinistre.Text = "type";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(48, 83);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(54, 25);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "date";
            // 
            // lblHeure
            // 
            this.lblHeure.AutoSize = true;
            this.lblHeure.Location = new System.Drawing.Point(48, 131);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(67, 25);
            this.lblHeure.TabIndex = 4;
            this.lblHeure.Text = "heure";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(48, 181);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(89, 25);
            this.lblAdresse.TabIndex = 5;
            this.lblAdresse.Text = "adresse";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(377, 104);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(70, 25);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "status";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(377, 154);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(58, 25);
            this.lblMotif.TabIndex = 7;
            this.lblMotif.Text = "motif";
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Location = new System.Drawing.Point(48, 231);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(89, 25);
            this.lblCaserne.TabIndex = 8;
            this.lblCaserne.Text = "caserne";
            // 
            // btnPDf
            // 
            this.btnPDf.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPDf.Location = new System.Drawing.Point(638, 59);
            this.btnPDf.Name = "btnPDf";
            this.btnPDf.Size = new System.Drawing.Size(120, 115);
            this.btnPDf.TabIndex = 1;
            this.btnPDf.Text = "to pdf";
            this.btnPDf.UseVisualStyleBackColor = false;
            // 
            // btnAccomplie
            // 
            this.btnAccomplie.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAccomplie.Location = new System.Drawing.Point(638, 201);
            this.btnAccomplie.Name = "btnAccomplie";
            this.btnAccomplie.Size = new System.Drawing.Size(120, 115);
            this.btnAccomplie.TabIndex = 2;
            this.btnAccomplie.Text = "accomplie";
            this.btnAccomplie.UseVisualStyleBackColor = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAccomplie);
            this.Controls.Add(this.btnPDf);
            this.Controls.Add(this.grpBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1034, 709);
            this.grpBox1.ResumeLayout(false);
            this.grpBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox1;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblSinistre;
        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnPDf;
        private System.Windows.Forms.Button btnAccomplie;
    }
}
