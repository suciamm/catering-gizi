using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Suci_CateringGizi.Controller
{
    class karyawanController :Connection
    {
        private object ex;

        public DataTable tampilkaryawan()
        {
            DataTable data = new DataTable();
            try
            {
                string tampil = " select * from Formkaryawan";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }
        public void tambahkaryawan(

            string idkar, string namakar, string jk, string jabat, string akk)
        {
            string tambah = "insert into Formkaryawan values(" + "@id_karyawan,@nama_karyawan, @jenis_kelamin, @jabatan, @alamat_karyawan)";
            try
            {
                cmd = new MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id_karyawan", MySqlDbType.VarChar).Value = idkar;
                cmd.Parameters.Add("@nama_karyawan", MySqlDbType.VarChar).Value = namakar;
                cmd.Parameters.Add("@jenis_kelamin", MySqlDbType.VarChar).Value = jk;
                cmd.Parameters.Add("@jabatan", MySqlDbType.VarChar).Value = jabat;
                cmd.Parameters.Add("@alamat_karyawan", MySqlDbType.VarChar).Value = akk;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah data gagal" + ex.Message);
            }
        }

        public void Updatekaryawan(string idkar, string namakar, string jk, string jabat, string akk)
        {
            string update = "update Formkaryawan set " +
                "nama_karyawan=@nama_karyawan,jenis_kelamin=@jenis_kelamin,jabatan=@jabatan,alamat_karyawan=@alamat_karyawan " +
                "where id_karyawan=" + idkar;
            try
            {
                cmd = new MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@id_karyawan", MySqlDbType.VarChar).Value = idkar;
                cmd.Parameters.Add("@nama_karyawan", MySqlDbType.VarChar).Value = namakar;
                cmd.Parameters.Add("@jenis_kelamin", MySqlDbType.VarChar).Value = jk;
                cmd.Parameters.Add("@jabatan", MySqlDbType.VarChar).Value = jabat;
                cmd.Parameters.Add("@alamat_karyawan", MySqlDbType.VarChar).Value = akk;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update data gagal" + ex.Message);
            }

        }
        public void hapuskaryawan(string id_kar)
        {
            string delete = "delete from Formkaryawan where id_karyawan=" + id_kar;
            //string delete = "delete from barang1 where id_barang=@idbarang";
            try
            {
                cmd = new MySqlCommand(delete, GetConn());
                cmd.Parameters.Add("@id_karyawan", MySqlConnector.MySqlDbType.VarChar).Value = id_kar;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("hapus data gagal" + ex.Message);
            }
        }
    }

}


