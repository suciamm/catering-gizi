using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySqlConnector;
using System.Data;
using System.Windows.Forms;

namespace Suci_CateringGizi
{
    class UpdateController : Connection
    {
        public DataTable tampilBarangUpdate(string tipeMenu)
        {
            DataTable data = new DataTable();
            try
            {
                //string tampil buat napilin databasenya
                string tampil = "select * from menu" + tipeMenu + "";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }


    }
}
