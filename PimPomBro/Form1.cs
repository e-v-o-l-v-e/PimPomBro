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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string req;
            DataTable schemaTable = Connexion.Connec.GetSchema("Tables");
            string liste = "";
            for (int i = 0; i < schemaTable.Rows.Count; i++)
            {
                string nomTable = schemaTable.Rows[i][2].ToString();
                req = @"select * from " + nomTable;
                SQLiteCommand cd = new SQLiteCommand(req, Connexion.Connec);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cd);

                da.FillSchema(MesDatas.DsGlobal, SchemaType.Source, nomTable);

                da.Fill(MesDatas.DsGlobal, nomTable);

                liste += nomTable + "\n";
            }

            gestionPompiers gestionPompiers = new gestionPompiers();
            gestionPompiers.ShowDialog();
            Close();
        }
    }
}
