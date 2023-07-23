using Suci_CateringGizi.Form_dashboard;
using Suci_CateringGizi.Form_karyawan;
using Suci_CateringGizi.Form_Riwayat_pembayaran;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suci_CateringGizi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuMakanan mm = new MenuMakanan();
            this.Hide();
            mm.Show();
        }

        private void buttonpesan_Click(object sender, EventArgs e)
        {
            RiwayatPasien rp = new RiwayatPasien();
            rp.Show();
            this.Hide();
        }

        private void buttonsupplier_Click(object sender, EventArgs e)
        {
            Supplier supp = new Supplier();
            supp.Show();
            this.Hide();
        }

        private void buttonpemesanan_Click(object sender, EventArgs e)
        {
            Pemesanan ps = new Pemesanan();
            ps.Show();
            this.Hide();
        }

        private void buttonriwayat_Click(object sender, EventArgs e)
        {
            karyawan kr = new karyawan();
            kr.Show();
            this.Hide();
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Riwayatbayar rb = new Riwayatbayar();
            rb.Show();
            this.Hide();
        }
    }
}
