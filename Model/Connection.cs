 using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Suci_CateringGizi
{
    public class Connection
    {
        //untuk menjalankan queri di database
        public MySqlCommand cmd;
        //memorinta, buat nympan datanya
        public DataSet ds;
        //nyambunin datanya ke sql, membaca data dari database aplikasi
        public MySqlDataAdapter da;

        public MySqlConnection GetConn()
        {
            //BUAT KONEKIN
            MySqlConnection Conn = new MySqlConnection();
            //nyammbungin data nya ke database
            Conn.ConnectionString = "server=localhost; user=root; database=projectuas; AllowUserVariables=true";
            try
            {
                //buat buka koneksi
                Conn.Open();
            }
            catch (Exception ex)
            {
                //ngasitau errornya
                MessageBox.Show("Koneksi gagal" + ex.Message);
            }
            return Conn;
        }
    }
}
