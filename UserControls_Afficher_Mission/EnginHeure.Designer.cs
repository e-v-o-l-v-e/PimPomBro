namespace AfficheMisssions
{
    partial class EnginHeure
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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelType = new System.Windows.Forms.Panel();
            this.panelNumero = new System.Windows.Forms.Panel();
            this.panelHeure = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblHeure = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.panelPrincipal.SuspendLayout();
            this.panelType.SuspendLayout();
            this.panelNumero.SuspendLayout();
            this.panelHeure.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.Navy;
            this.panelPrincipal.Controls.Add(this.label1);
            this.panelPrincipal.Controls.Add(this.panelNumero);
            this.panelPrincipal.Controls.Add(this.panelHeure);
            this.panelPrincipal.Controls.Add(this.panelType);
            this.panelPrincipal.Location = new System.Drawing.Point(3, 3);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(388, 83);
            this.panelPrincipal.TabIndex = 0;
            // 
            // panelType
            // 
            this.panelType.BackColor = System.Drawing.Color.Silver;
            this.panelType.Controls.Add(this.lblType);
            this.panelType.Location = new System.Drawing.Point(31, 18);
            this.panelType.Name = "panelType";
            this.panelType.Size = new System.Drawing.Size(110, 47);
            this.panelType.TabIndex = 1;
            // 
            // panelNumero
            // 
            this.panelNumero.BackColor = System.Drawing.Color.Silver;
            this.panelNumero.Controls.Add(this.lblNumero);
            this.panelNumero.Location = new System.Drawing.Point(147, 18);
            this.panelNumero.Name = "panelNumero";
            this.panelNumero.Size = new System.Drawing.Size(110, 47);
            this.panelNumero.TabIndex = 2;
            // 
            // panelHeure
            // 
            this.panelHeure.BackColor = System.Drawing.Color.Silver;
            this.panelHeure.Controls.Add(this.lblHeure);
            this.panelHeure.Location = new System.Drawing.Point(262, 18);
            this.panelHeure.Name = "panelHeure";
            this.panelHeure.Size = new System.Drawing.Size(110, 47);
            this.panelHeure.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(-1, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 75);
            this.label1.TabIndex = 1;
            this.label1.Text = "✪\r\n✪\r\n✪";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(3, 12);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(60, 25);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "label2";
            // 
            // lblHeure
            // 
            this.lblHeure.AutoSize = true;
            this.lblHeure.Location = new System.Drawing.Point(3, 12);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(60, 25);
            this.lblHeure.TabIndex = 1;
            this.lblHeure.Text = "label2";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(3, 12);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(60, 25);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "label2";
            // 
            // EnginHeure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelPrincipal);
            this.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "EnginHeure";
            this.Size = new System.Drawing.Size(394, 90);
            this.Load += new System.EventHandler(this.EnginHeure_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.panelType.ResumeLayout(false);
            this.panelType.PerformLayout();
            this.panelNumero.ResumeLayout(false);
            this.panelNumero.PerformLayout();
            this.panelHeure.ResumeLayout(false);
            this.panelHeure.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelNumero;
        private System.Windows.Forms.Panel panelHeure;
        private System.Windows.Forms.Panel panelType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.Label lblType;
    }
}
