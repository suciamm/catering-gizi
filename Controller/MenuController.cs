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
    class MenuController: Connection
    {
        public DataTable tampilBarangMenu(string TipePasien)
        {
            DataTable data = new DataTable();
            try
            {
                //string tampil buat napilin databasenya
                string tampil = "select * from menu"+ TipePasien + "";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }
        public void hapusmenulunak(string id_menu)
        {
            string delete = "delete from menulunak where id_menu_lunak=" + id_menu;
            //string delete = "delete from barang1 where id_barang=@idbarang";
            try
            {
                cmd = new MySqlCommand(delete, GetConn());
                cmd.Parameters.Add("@id_menu_lunak", MySqlConnector.MySqlDbType.VarChar).Value = id_menu;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("hapus data gagal" + ex.Message);
            }
        }
        public void hapusmenubiasa(string id_menu)
        {
            string delete = "delete from menubiasa where id_menu_biasa=" + id_menu;
            //string delete = "delete from barang1 where id_barang=@idbarang";
            try
            {
                cmd = new MySqlCommand(delete, GetConn());
                cmd.Parameters.Add("@id_menu_biasa", MySqlConnector.MySqlDbType.VarChar).Value = id_menu;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("hapus data gagal" + ex.Message);
            }
        }
        public void hapusmenucair(string id_menu)
        {
            string delete = "delete from menucair where id_menu_cair=" + id_menu;
            //string delete = "delete from barang1 where id_barang=@idbarang";
            try
            {
                cmd = new MySqlCommand(delete, GetConn());
                cmd.Parameters.Add("@id_menu_cair", MySqlConnector.MySqlDbType.VarChar).Value = id_menu;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("hapus data gagal" + ex.Message);
            }
        }
        public void hapusmenusaring(string id_menu)
        {
            string delete = "delete from menusaring where id_menu_saring=" + id_menu;
            //string delete = "delete from barang1 where id_barang=@idbarang";
            try
            {
                cmd = new MySqlCommand(delete, GetConn());
                cmd.Parameters.Add("@id_menu_saring", MySqlConnector.MySqlDbType.VarChar).Value = id_menu;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("hapus data gagal" + ex.Message);
            }
        }
    }
}
