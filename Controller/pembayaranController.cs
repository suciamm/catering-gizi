using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySqlConnector;
using System.Data;
using System.Windows.Forms;

namespace Suci_CateringGizi.Model
{
    class pembayaranController :Connection
    {
        DataTable data = new DataTable();
        public DataTable riwayat()
        {
            try
            {
                string tampil = "select * from pemesanan";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }

        public DataTable bulan(string bulan)
        {
            string moon = "select * from pemesanan where tanggal_pemesanan like '%/" + bulan + "/%';";
            da = new MySqlConnector.MySqlDataAdapter(moon, GetConn());
            da.Fill(data);
            return data;
        }
    }
}
