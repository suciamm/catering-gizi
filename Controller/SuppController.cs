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
    class SuppController : Connection
    {
        private object ex;

        public DataTable tampilBarang()
        {
            DataTable data = new DataTable();
            try
            {
                string tampil = " select * from formsupplier";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }
        public void tambahsupplier(
            string idsupp, string namasupp, string namabrg, string harga)
        {
            string tambah = "insert into formsupplier values(" + "@Id_supplier,@Nama_supplier, @Nama_barang, @Harga_satuan)";
            try
            {
                cmd = new MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@Id_supplier", MySqlDbType.VarChar).Value = idsupp;
                cmd.Parameters.Add("@Nama_supplier", MySqlDbType.VarChar).Value = namasupp;
                cmd.Parameters.Add("@Nama_barang", MySqlDbType.VarChar).Value = namabrg;
                cmd.Parameters.Add("@Harga_satuan", MySqlDbType.VarChar).Value = harga;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah data gagal" + ex.Message);
            }
        }

        public void Updatesupplierk(string idsupp, string namasupp, string namabrg, string harga)
        {
            string update = "update formsupplier set " +
                "Nama_supplier=@Nama_supplier,Nama_barang=@Nama_barang,Harga_satuan=@Harga_satuan " +
                "where id_supplier=" + idsupp;
            try
            {
                cmd = new MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@id_supplier", MySqlDbType.VarChar).Value = idsupp;
                cmd.Parameters.Add("@Nama_supplier", MySqlDbType.VarChar).Value = namasupp;
                cmd.Parameters.Add("@Nama_barang", MySqlDbType.VarChar).Value = namabrg;
                cmd.Parameters.Add("@Harga_satuan", MySqlDbType.VarChar).Value = harga;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update data gagal" + ex.Message);
            }

        }
        public void hapusSupplier(string id_supp)
        {
            string delete = "delete from formsupplier where id_supplier=" + id_supp;
            //string delete = "delete from barang1 where id_barang=@idbarang";
            try
            {
                cmd = new MySqlCommand(delete, GetConn());
                cmd.Parameters.Add("@id_supplier", MySqlConnector.MySqlDbType.VarChar).Value = id_supp;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("hapus data gagal" + ex.Message);
            }
        }
    }

   }

