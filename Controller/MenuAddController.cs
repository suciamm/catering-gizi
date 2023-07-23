using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Suci_CateringGizi
{
    class MenuAddController : Connection
    {
        public DataTable tampilAddeMenu(string tipeMenu)
        {
            DataTable data = new DataTable();
            try
            {
                //string tampil buat nampilin databasenya
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
        public void tambahMenuBiasa(
        string idmenubiasa, string karbohidrat, string hewani, string nabati, string sayur, string buah)
        {
            string tambah = "insert into menubiasa values(" + "@id_menu_biasa,@Karbohidrat, @Hewani, @Nabati, @Sayur, @Buah)";
            try
            {
                cmd = new MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id_menu_biasa", MySqlDbType.VarChar).Value = idmenubiasa;
                cmd.Parameters.Add("@Karbohidrat", MySqlDbType.VarChar).Value = karbohidrat;
                cmd.Parameters.Add("@Hewani", MySqlDbType.Int32).Value = hewani;
                cmd.Parameters.Add("@Nabati", MySqlDbType.Int32).Value = nabati;
                cmd.Parameters.Add("@Sayur", MySqlDbType.Int32).Value = sayur;
                cmd.Parameters.Add("@Buah", MySqlDbType.Int32).Value = buah;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah data gagal" + ex.Message);
            }
        }
        public void tambahMenuLunak(
        string idmenulunak, string karbohidrat, string hewani, string nabati, string sayur, string buah)
        {
            string tambah = "insert into menulunak values(" + "@id_menu_lunak,@Karbohidrat, @Hewani, @Nabati, @Sayur, @Buah)";
            try
            {
                cmd = new MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id_menu_lunak", MySqlDbType.VarChar).Value = idmenulunak;
                cmd.Parameters.Add("@Karbohidrat", MySqlDbType.VarChar).Value = karbohidrat;
                cmd.Parameters.Add("@Hewani", MySqlDbType.Int32).Value = hewani;
                cmd.Parameters.Add("@Nabati", MySqlDbType.Int32).Value = nabati;
                cmd.Parameters.Add("@Sayur", MySqlDbType.Int32).Value = sayur;
                cmd.Parameters.Add("@Buah", MySqlDbType.Int32).Value = buah;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah data gagal" + ex.Message);
            }
        }
        public void tambahMenuSaring(
        string idmenusaring, string karbohidrat, string hewani, string nabati, string sayur, string buah)
        {
            string tambah = "insert into menusaring values(" + "@id_menu_saring,@Karbohidrat, @Hewani, @Nabati, @Sayur, @Buah)";
            try
            {
                cmd = new MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id_menu_saring", MySqlDbType.VarChar).Value = idmenusaring;
                cmd.Parameters.Add("@Karbohidrat", MySqlDbType.VarChar).Value = karbohidrat;
                cmd.Parameters.Add("@Hewani", MySqlDbType.Int32).Value = hewani;
                cmd.Parameters.Add("@Nabati", MySqlDbType.Int32).Value = nabati;
                cmd.Parameters.Add("@Sayur", MySqlDbType.Int32).Value = sayur;
                cmd.Parameters.Add("@Buah", MySqlDbType.Int32).Value = buah;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah data gagal" + ex.Message);
            }
        }
        public void tambahMenuCair(
        string idmenucair, string karbohidrat, string hewani, string nabati, string sayur, string buah)
        {
            string tambah = "insert into menucair values(" + "@id_menu_cair,@Karbohidrat, @Hewani, @Nabati, @Sayur, @Buah)";
            try
            {
                cmd = new MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id_menu_cair", MySqlDbType.VarChar).Value = idmenucair;
                cmd.Parameters.Add("@Karbohidrat", MySqlDbType.VarChar).Value = karbohidrat;
                cmd.Parameters.Add("@Hewani", MySqlDbType.Int32).Value = hewani;
                cmd.Parameters.Add("@Nabati", MySqlDbType.Int32).Value = nabati;
                cmd.Parameters.Add("@Sayur", MySqlDbType.Int32).Value = sayur;
                cmd.Parameters.Add("@Buah", MySqlDbType.Int32).Value = buah;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah data gagal" + ex.Message);
            }
        }
    }
}
