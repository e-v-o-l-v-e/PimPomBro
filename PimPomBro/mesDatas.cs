using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SQLite;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace PimPomBro
{
    public class MesDatas
    {
        private static DataSet dsGlobal = new DataSet();
     
        public static DataSet DsGlobal { get {  return MesDatas.dsGlobal; } }

        public static void refreshTable(string table)
        {
            try
            {
                string requete = "SELECT * FROM " + table;
                SQLiteDataAdapter da = new SQLiteDataAdapter(requete, Connexion.Connec);
                DataTable dt = MesDatas.DsGlobal.Tables[table];
                dt.Clear();
                da.Fill(dt);
                da.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
