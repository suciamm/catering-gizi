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
    class PassiController : Connection
    {
        public DataTable tampilBarangPassien(string tipeMenu)
        {
            DataTable data = new DataTable();
            try
            {
                //string tampil buat napilin databasenya
                string tampil = "select * from pasien"+TempDataPasien.TipePasien+"";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }

        public void tambahpasienpmc(
        string nomorpmc, string nama, string keterangan, string diit, string jenis)
        {
            string tambah = "insert into pasienpmc values(" + "@no_pasien_pmc,@nama_pasien, @keterangan, @Diit_atau_riwayat_penyakit, @jenis_menu)";
            try
            {
                cmd = new MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@no_pasien_pmc", MySqlDbType.VarChar).Value = nomorpmc;
                cmd.Parameters.Add("@nama_pasien", MySqlDbType.VarChar).Value = nama;
                cmd.Parameters.Add("@keterangan", MySqlDbType.Int32).Value = keterangan;
                cmd.Parameters.Add("@Diit_atau_riwayat_penyakit", MySqlDbType.Int32).Value = diit;
                cmd.Parameters.Add("@jenis_menu", MySqlDbType.Int32).Value = jenis;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah data gagal" + ex.Message);
            }
        }
        public void tambahpasiencimenyan(
        string nomorcmy, string nama, string keterangan, string diit, string jenis)
        {
            string tambah = "insert into pasiencimenyan values(" + "@no_pasien_cimenyan,@nama_pasien, @keterangan, @Diit_atau_riwayat_penyakit, @jenis_menu)";
            try
            {
                cmd = new MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@no_pasien_cimenyan", MySqlDbType.VarChar).Value = nomorcmy;
                cmd.Parameters.Add("@nama_pasien", MySqlDbType.VarChar).Value = nama;
                cmd.Parameters.Add("@keterangan", MySqlDbType.Int32).Value = keterangan;
                cmd.Parameters.Add("@Diit_atau_riwayat_penyakit", MySqlDbType.Int32).Value = diit;
                cmd.Parameters.Add("@jenis_menu", MySqlDbType.Int32).Value = jenis;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah data gagal" + ex.Message);
            }
        }
        public void tambahpasienpegadaian(
         string nomorpgd, string nama, string keterangan, string diit, string jenis)
        {
            string tambah = "insert into pasienpegadaian values(" + "@no_pasien_pegadaian,@nama_pasien, @keterangan, @Diit_atau_riwayat_penyakit, @jenis_menu)";
            try
            {
                cmd = new MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@no_pasien_pegadaian", MySqlDbType.VarChar).Value = nomorpgd;
                cmd.Parameters.Add("@nama_pasien", MySqlDbType.VarChar).Value = nama;
                cmd.Parameters.Add("@keterangan", MySqlDbType.Int32).Value = keterangan;
                cmd.Parameters.Add("@Diit_atau_riwayat_penyakit", MySqlDbType.Int32).Value = diit;
                cmd.Parameters.Add("@jenis_menu", MySqlDbType.Int32).Value = jenis;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah data gagal" + ex.Message);
            }
        }
        public void tambahpasienlainnya(
         string nomorln, string nama, string alamat, string diit, string jenis)
        {
            string tambah = "insert into pasienlainnya values(" + "@no_pesanan_lainnya,@nama_pasien, @alamat_pasien, @Diit_atau_riwayat_penyakit, @jenis_menu)";
            try
            {
                cmd = new MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@no_pesanan_lainnya", MySqlDbType.VarChar).Value = nomorln;
                cmd.Parameters.Add("@nama_pasien", MySqlDbType.VarChar).Value = nama;
                cmd.Parameters.Add("@alamat_pasien", MySqlDbType.Int32).Value = alamat;
                cmd.Parameters.Add("@Diit_atau_riwayat_penyakit", MySqlDbType.Int32).Value = diit;
                cmd.Parameters.Add("@jenis_menu", MySqlDbType.Int32).Value = jenis;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah data gagal" + ex.Message);
            }
        }
        public void hapuspasienpmc(string id_pass)
        {
            string delete = "delete from pasienpmc where no_pasien_pmc=" + id_pass;
            //string delete = "delete from barang1 where id_barang=@idbarang";
            try
            {
                cmd = new MySqlCommand(delete, GetConn());
                cmd.Parameters.Add("@no_pasien_pmc", MySqlConnector.MySqlDbType.VarChar).Value = id_pass;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("hapus data gagal" + ex.Message);
            }
        }
        public void hapuspasiencimenyan(string id_pass)
        {
            string delete = "delete from pasiencimenyan where no_pasien_cimenyan=" + id_pass;
            //string delete = "delete from barang1 where id_barang=@idbarang";
            try
            {
                cmd = new MySqlCommand(delete, GetConn());
                cmd.Parameters.Add("@no_pasien_cimenyan", MySqlConnector.MySqlDbType.VarChar).Value = id_pass;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("hapus data gagal" + ex.Message);
            }
        }
        public void hapuspasienpegadaian(string id_pass)
        {
            string delete = "delete from pasienpegadaian where no_pasien_pegadaian=" + id_pass;
            //string delete = "delete from barang1 where id_barang=@idbarang";
            try
            {
                cmd = new MySqlCommand(delete, GetConn());
                cmd.Parameters.Add("@no_pasien_pmc", MySqlConnector.MySqlDbType.VarChar).Value = id_pass;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("hapus data gagal" + ex.Message);
            }
        }
        public void hapuspasienlainnya(string id_pass)
        {
            string delete = "delete from pasienlainnya where no_pesanan_lainnya=" + id_pass;
            //string delete = "delete from barang1 where id_barang=@idbarang";
            try
            {
                cmd = new MySqlCommand(delete, GetConn());
                cmd.Parameters.Add("@no_pesanan_lainnya", MySqlConnector.MySqlDbType.VarChar).Value = id_pass;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("hapus data gagal" + ex.Message);
            }
        }


    }
}
