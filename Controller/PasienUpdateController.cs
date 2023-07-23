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
    class PasienUpdateController :Connection
    {
        public DataTable tampilUpdatePasien(string Tipepasien)
        {
            DataTable data = new DataTable();
            try
            {
                //string tampil buat nampilin databasenya
                string tampil = "select * from pasien" + Tipepasien + "";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }
        public void UpdatepasianPmc(string nomor, string nama, string keterangan, string diit, string jenis)
        {
            string update = "update pasienpmc set " +
                "nama_pasien=@nama_pasien,keterangan=@keterangan,Diit_atau_Riwayat_penyakit=@Diit_atau_Riwayat_penyakit, jenis_menu=@jenis_menu " +
                "where no_pasien_pmc=" + nomor;
            try
            {
                cmd = new MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@no_pasien_pmc", MySqlDbType.VarChar).Value = nomor;
                cmd.Parameters.Add("@nama_pasien", MySqlDbType.VarChar).Value = nama;
                cmd.Parameters.Add("@keterangan", MySqlDbType.VarChar).Value = keterangan;
                cmd.Parameters.Add("@Diit_atau_Riwayat_penyakit", MySqlDbType.VarChar).Value = diit;
                cmd.Parameters.Add("@jenis_menu", MySqlDbType.VarChar).Value = jenis;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update data gagal" + ex.Message);
            }
        }
        public void Updatepasiancimenyan(string nomorcmy, string nama, string keterangan, string diit, string jenis)
        {
            string update = "update pasiencimenyan set " +
                "nama_pasien=@nama_pasien,keterangan=@keterangan,Diit_atau_Riwayat_penyakit=@Diit_atau_Riwayat_penyakit, jenis_menu=@jenis_menu " +
                "where no_pasien_cimenyan=" + nomorcmy;
            try
            {
                cmd = new MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@no_pasien_cimenyan", MySqlDbType.VarChar).Value = nomorcmy;
                cmd.Parameters.Add("@nama_pasien", MySqlDbType.VarChar).Value = nama;
                cmd.Parameters.Add("@keterangan", MySqlDbType.VarChar).Value = keterangan;
                cmd.Parameters.Add("@Diit_atau_Riwayat_penyakit", MySqlDbType.VarChar).Value = diit;
                cmd.Parameters.Add("@jenis_menu", MySqlDbType.VarChar).Value = jenis;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update data gagal" + ex.Message);
            }
        }
        public void Updatepasianpegadaian(string nomor, string nama, string keterangan, string diit, string jenis)
        {
            string update = "update pasienpegadaian set " +
                "nama_pasien=@nama_pasien,keterangan=@keterangan,Diit_atau_Riwayat_penyakit=@Diit_atau_Riwayat_penyakit, jenis_menu=@jenis_menu " +
                "where no_pasien_pegadaian=" + nomor;
            try
            {
                cmd = new MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@no_pasien_pegadaian", MySqlDbType.VarChar).Value = nomor;
                cmd.Parameters.Add("@nama_pasien", MySqlDbType.VarChar).Value = nama;
                cmd.Parameters.Add("@keterangan", MySqlDbType.VarChar).Value = keterangan;
                cmd.Parameters.Add("@Diit_atau_Riwayat_penyakit", MySqlDbType.VarChar).Value = diit;
                cmd.Parameters.Add("@jenis_menu", MySqlDbType.VarChar).Value = jenis;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update data gagal" + ex.Message);
            }
        }
        public void Updatepasienlainnya(string nomorln, string nama, string keterangan, string diit, string jenis)
        {
            string update = "update pasienlainnya set " +
                "nama_pasien=@nama_pasien,alamat_pasien=@alamat_pasien,Diit_atau_Riwayat_penyakit=@Diit_atau_Riwayat_penyakit, jenis_menu=@jenis_menu " +
                "where no_pesanan_lainnya=" + nomorln;
            try
            {
                cmd = new MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@no_pesanan_lainnya", MySqlDbType.VarChar).Value = nomorln;
                cmd.Parameters.Add("@nama_pasien", MySqlDbType.VarChar).Value = nama;
                cmd.Parameters.Add("@alamat_pasien", MySqlDbType.VarChar).Value = keterangan;
                cmd.Parameters.Add("@Diit_atau_Riwayat_penyakit", MySqlDbType.VarChar).Value = diit;
                cmd.Parameters.Add("@jenis_menu", MySqlDbType.VarChar).Value = jenis;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update data gagal" + ex.Message);
            }
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
    }
}
