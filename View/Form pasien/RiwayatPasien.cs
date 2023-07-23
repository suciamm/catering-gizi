using Suci_CateringGizi.Form_pasien;
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
    public partial class RiwayatPasien : Form
    {
        FormPasien Pasi = new FormPasien();
        public RiwayatPasien()
        {
            InitializeComponent();
        }

        private void buttonPmc_Click(object sender, EventArgs e)
        {
            TempDataPasien.TipePasien = "PMC";
            this.Hide();
            Pasi.Show();
            Pasi.label2.Text = TempDataPasien.TipePasien;
        }

        private void buttonpegadaian_Click(object sender, EventArgs e)
        {
            TempDataPasien.TipePasien ="Pegadaian";
            this.Hide();
            Pasi.Show();
            Pasi.label2.Text = TempDataPasien.TipePasien;
        }

        private void buttoncimenyan_Click(object sender, EventArgs e)
        {
            TempDataPasien.TipePasien ="Cimenyan";
            this.Hide();
            Pasi.Show();
            Pasi.label2.Text = TempDataPasien.TipePasien;
        }

        private void buttonkmb_Click(object sender, EventArgs e)
        {
            Form1 fone = new Form1();
            fone.Show();
            this.Hide();
        }

        private void buttonlainnya_Click(object sender, EventArgs e)
        {
            TempDataPasien.TipePasien = "Lainnya";
            this.Hide();
            Pasi.Show();
            Pasi.label2.Text = TempDataPasien.TipePasien;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
