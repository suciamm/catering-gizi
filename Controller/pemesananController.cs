using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suci_CateringGizi.Controller
{
    class pemesananController :Connection
    {
        
        public DataTable tampilpemesanan()
        {
            DataTable data = new DataTable();
            try
            {
                //string tampil buat napilin databasenya
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
        public void tambahPemesanan(
            string nopesan, string tanggal, string riwayat, string keterngn, string banyak, string kuantitas)
        {
            string tambah = "insert into pemesanan values(" + "@no_pemesanan,@tanggal_pemesanan, @riwayat_pemesanan, @keterangan, @banyak_pasien, @kuantitas)";
            try
            {
                cmd = new MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@no_pemesanan", MySqlDbType.VarChar).Value = nopesan;
                cmd.Parameters.Add("@no_pemesanan", MySqlDbType.VarChar).Value = tanggal;
                cmd.Parameters.Add("@riwayat_pemesanan", MySqlDbType.VarChar).Value = riwayat;
                cmd.Parameters.Add("@keterangan", MySqlDbType.Int32).Value = keterngn;
                cmd.Parameters.Add("@banyak_pasien", MySqlDbType.Int32).Value = banyak;
                cmd.Parameters.Add("@kuantitas", MySqlDbType.Int32).Value = kuantitas;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah data gagal" + ex.Message);
            }
        }
        public void Updatepemesanann(string nopes, string nriwayat, string keter, string banyak, string knnts)
        {
            string update = "update pemesanan set " +
                "riwayat_pemesanan=@riwayat_pemesanan,keterangan=@keterangan,banyak_pasien=@banyak_pasien,kuantitas=@kuantitas" +
                "where no_pemesanan=" + nopes;
            try
            {
                cmd = new MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@no_pemesanan", MySqlDbType.VarChar).Value = nopes;
                cmd.Parameters.Add("@riwayat_pemesanan", MySqlDbType.VarChar).Value = nriwayat;
                cmd.Parameters.Add("@keterangan", MySqlDbType.VarChar).Value = keter;
                cmd.Parameters.Add("@banyak_pasien", MySqlDbType.VarChar).Value = banyak;
                cmd.Parameters.Add("@kuantitas", MySqlDbType.VarChar).Value = knnts;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update data gagal" + ex.Message);
            }
        }
        public void hapuspemesanan(string nopes)
        {
            string delete = "delete from pemesanan where no_pemesanan=" + nopes;
            try
            {
                cmd = new MySqlCommand(delete, GetConn());
                cmd.Parameters.Add("@no_pemesanan", MySqlConnector.MySqlDbType.VarChar).Value = nopes;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("hapus data gagal" + ex.Message);
            }
        }

    }
}
