using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace smsmtest
{
    class DBKon
    {
        MySqlConnection kon;
        string konstr;
        static string host = "127.0.0.1";
        static string database = "pos";
        static string user = "root";
        static string pass = "civong";
        public static string strProvider = "server=" + host + ";Database=" + database + ";User ID=" + user + ";Password=" + pass;

        public bool Open()
        {
            try
            {
                strProvider = "server=" + host + ";Database=" + database + ";User ID=" + user + ";Password=" + pass;
                kon = new MySqlConnection(strProvider);
                kon.Open();
                return true;
            }
            catch (Exception er)
            {
                MessageBox.Show("Connection Error ! " + er.Message, "Information");
            }
            return false;
        }

        public void Close()
        {
            kon.Close();
            kon.Dispose();
        }
    }
}
