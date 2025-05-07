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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboCaserne = new System.Windows.Forms.ComboBox();
            this.cboPompier = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.picNouveau = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNouveau)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.picNouveau);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cboPompier);
            this.panel1.Controls.Add(this.cboCaserne);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 665);
            this.panel1.TabIndex = 0;
            // 
            // cboCaserne
            // 
            this.cboCaserne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(29, 102);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(265, 28);
            this.cboCaserne.TabIndex = 0;
            // 
            // cboPompier
            // 
            this.cboPompier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPompier.FormattingEnabled = true;
            this.cboPompier.Location = new System.Drawing.Point(29, 193);
            this.cboPompier.Name = "cboPompier";
            this.cboPompier.Size = new System.Drawing.Size(265, 28);
            this.cboPompier.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "btnNouveau";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // picNouveau
            // 
            this.picNouveau.Location = new System.Drawing.Point(108, 325);
            this.picNouveau.Name = "picNouveau";
            this.picNouveau.Size = new System.Drawing.Size(106, 122);
            this.picNouveau.TabIndex = 3;
            this.picNouveau.TabStop = false;
            // 
            // gestionPompiers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(925, 690);
            this.Controls.Add(this.panel1);
            this.Name = "gestionPompiers";
            this.Text = "Gestion du Personnel";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picNouveau)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboPompier;
        private System.Windows.Forms.ComboBox cboCaserne;
        private System.Windows.Forms.PictureBox picNouveau;
        private System.Windows.Forms.Button button1;
    }
}