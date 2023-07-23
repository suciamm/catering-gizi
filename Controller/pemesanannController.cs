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
    class pemesanannController:Connection
    {
        public DataTable tampilkpemesanan()
        {
            DataTable data = new DataTable();
            try
            {
                string tampil = " select * from pemesanan";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }
        public void tambahpemesanan(
            string idp, string tanggal, string namap, string ket, string byk, string harga)
        {
            string tambah = "insert into pemesanan values(" + "@no_pemesanan,@tanggal_pemesanan,@riwayat_pemesanan, @keterangan, @banyak_pasien,@harga_perporsi)";
            try
            {
                cmd = new MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@no_pemesanan", MySqlDbType.VarChar).Value = idp;
                cmd.Parameters.Add("@tanggal_pemesanan", MySqlDbType.VarChar).Value = tanggal;
                cmd.Parameters.Add("@riwayat_pemesanan", MySqlDbType.VarChar).Value = namap;
                cmd.Parameters.Add("@keterangan", MySqlDbType.VarChar).Value = ket;
                cmd.Parameters.Add("@banyak_pasien", MySqlDbType.VarChar).Value = byk;
                cmd.Parameters.Add("@harga_perporsi", MySqlDbType.VarChar).Value = harga;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah data gagal" + ex.Message);
            }
        }
        public void Updatepemesanan(string idkk, string namak, string jk, string jbtnk, string alamatk)
        {
            string update = "update pemesanan set " +
                "riwayat_pemesanan=@riwayat_pemesanan,keterangan=@keterangan,banyak_pasien=@banyak_pasien,harga_perporsi=@harga_perporsi " +
                "where no_pemesanan=" + idkk;
            try
            {
                cmd = new MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@no_pemesanan", MySqlDbType.VarChar).Value = idkk;
                cmd.Parameters.Add("@riwayat_pemesanan", MySqlDbType.VarChar).Value = namak;
                cmd.Parameters.Add("@keterangan", MySqlDbType.VarChar).Value = jk;
                cmd.Parameters.Add("@banyak_pasien", MySqlDbType.VarChar).Value = jbtnk;
                cmd.Parameters.Add("@harga_perporsi", MySqlDbType.VarChar).Value = alamatk;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update data gagal" + ex.Message);
            }

        }
        public void hapuspemesanan(string idkpes)
        {
            string delete = "delete from pemesanan where no_pemesanan=" + idkpes;
            try
            {
                cmd = new MySqlCommand(delete, GetConn());
                cmd.Parameters.Add("@no_pemesanan", MySqlConnector.MySqlDbType.VarChar).Value = idkpes;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("hapus data gagal" + ex.Message);
            }
        }
    }

}

