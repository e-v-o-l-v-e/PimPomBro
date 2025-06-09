using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimPomBro
{
    public partial class ConnexionAdmin : Form
    {

        public bool admin { get; private set; } = false;
        public ConnexionAdmin()
        {
            InitializeComponent();
        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            try
            {
                String requete = "SELECT mdp FROM Admin WHERE login = @login";
                SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);
                cmd.Parameters.AddWithValue("@login", txtLogin.Text);
                IDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (txtMDP.Text == reader["mdp"].ToString())
                {
                    admin = true;
                    this.DialogResult = DialogResult.OK;
                } else
                {
                    admin = false;
                    MessageBox.Show("Le login et/ou le mot de passe est erroné.");
                    txtMDP.Text = "";
                    txtLogin.Select();
                    txtLogin.SelectAll();
                }
            } catch
            {
                admin = false;
                MessageBox.Show("Le login et/ou le mot de passe est erroné.");
                txtMDP.Text = "";
                txtLogin.Select();
                txtLogin.SelectAll();
            }
        }

        private void txtMDP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSeConnecter_Click(sender, e);
            }
        }

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMDP.Select();
            }
        }
    }
}
