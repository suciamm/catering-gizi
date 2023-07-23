using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Suci_CateringGizi.Model
{
    public class MenuUpdateController : Connection
    {
        public DataTable tampilUpdateMenu(string tipeMenu)
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
        public void UpdateMenuBiasa(string idmenu, string karbo, string hewanii, string nabatii, string sayurr, string buahh)
        {
            string update = "update menubiasa set " +
                "Karbohidrat=@Karbohidrat,Hewani=@Hewani,Nabati=@Nabati, Sayur=@Sayur, Buah=@Buah " +
                "where id_menu_biasa=" + idmenu;
            try
            {
                cmd = new MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@id_menu_biasa", MySqlDbType.VarChar).Value = idmenu;
                cmd.Parameters.Add("@Karbohidrat", MySqlDbType.VarChar).Value = karbo;
                cmd.Parameters.Add("@Hewani", MySqlDbType.VarChar).Value = hewanii;
                cmd.Parameters.Add("@Nabati", MySqlDbType.VarChar).Value = nabatii;
                cmd.Parameters.Add("@Sayur", MySqlDbType.VarChar).Value = sayurr;
                cmd.Parameters.Add("@Buah", MySqlDbType.VarChar).Value = buahh;
                    cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update data gagal" + ex.Message);
            }
        }
        public void UpdateMenuSaring(string idmenu, string karbo, string hewanii, string nabatii, string sayurr, string buahh)
        {
            string update = "update menusaring set " +
                "Karbohidrat=@Karbohidrat,Hewani=@Hewani,Nabati=@Nabati, Sayur=@Sayur, Buah=@Buah " +
                "where id_menu_saring=" + idmenu;
            try
            {
                cmd = new MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@id_menu_saring", MySqlDbType.VarChar).Value = idmenu;
                cmd.Parameters.Add("@Karbohidrat", MySqlDbType.VarChar).Value = karbo;
                cmd.Parameters.Add("@Hewani", MySqlDbType.VarChar).Value = hewanii;
                cmd.Parameters.Add("@Nabati", MySqlDbType.VarChar).Value = nabatii;
                cmd.Parameters.Add("@Sayur", MySqlDbType.VarChar).Value = sayurr;
                cmd.Parameters.Add("@Buah", MySqlDbType.VarChar).Value = buahh;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update data gagal" + ex.Message);
            }
        }
        public void UpdateMenuLunak(string idmenu, string karbo, string hewanii, string nabatii, string sayurr, string buahh)
        {
            string update = "update menulunak set " +
                "Karbohidrat=@Karbohidrat,Hewani=@Hewani,Nabati=@Nabati, Sayur=@Sayur, Buah=@Buah " +
                "where id_menu_lunak=" + idmenu;
            try
            {
                cmd = new MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@id_menu_lunak", MySqlDbType.VarChar).Value = idmenu;
                cmd.Parameters.Add("@Karbohidrat", MySqlDbType.VarChar).Value = karbo;
                cmd.Parameters.Add("@Hewani", MySqlDbType.VarChar).Value = hewanii;
                cmd.Parameters.Add("@Nabati", MySqlDbType.VarChar).Value = nabatii;
                cmd.Parameters.Add("@Sayur", MySqlDbType.VarChar).Value = sayurr;
                cmd.Parameters.Add("@Buah", MySqlDbType.VarChar).Value = buahh;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update data gagal" + ex.Message);
            }
        }
        public void UpdateMenuCair(string idmenu, string karbo, string hewanii, string nabatii, string sayurr, string buahh)
        {
            string update = "update menucair set " +
                "Karbohidrat=@Karbohidrat,Hewani=@Hewani,Nabati=@Nabati, Sayur=@Sayur, Buah=@Buah " +
                "where id_menu_cair=" + idmenu;
            try
            {
                cmd = new MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@id_menu_cair", MySqlDbType.VarChar).Value = idmenu;
                cmd.Parameters.Add("@Karbohidrat", MySqlDbType.VarChar).Value = karbo;
                cmd.Parameters.Add("@Hewani", MySqlDbType.VarChar).Value = hewanii;
                cmd.Parameters.Add("@Nabati", MySqlDbType.VarChar).Value = nabatii;
                cmd.Parameters.Add("@Sayur", MySqlDbType.VarChar).Value = sayurr;
                cmd.Parameters.Add("@Buah", MySqlDbType.VarChar).Value = buahh;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update data gagal" + ex.Message);
            }
        }
    }

}
