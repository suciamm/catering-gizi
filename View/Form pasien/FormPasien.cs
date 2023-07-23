using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Suci_CateringGizi.Controller;
using System.Threading.Tasks;
using System.Windows.Forms;
using Suci_CateringGizi.Form_pasien;

namespace Suci_CateringGizi
{
    public partial class FormPasien : Form
    {
        PassiController controll = new PassiController();
        public FormPasien()
        {
            InitializeComponent();
        }
        void freezing()
        {
            dataGridView1.DataSource = controll.tampilBarangPassien(TempDataPasien.TipePasien);
            dataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
        }

        private void FormPasien_Load(object sender, EventArgs e)
        {
            freezing();
            if (TempDataPasien.TipePasien == "PMC")
            {
                label2.Text = "PMC";
            }
            if (TempDataPasien.TipePasien == "Cimenyan")
            {
                label2.Text = "Cimenyan";
            }
            if (TempDataPasien.TipePasien == "Pegadaian")
            {
                label2.Text = "Pegadaian";
            }
            if (TempDataPasien.TipePasien == "Lainnya")
            {
                label2.Text = "Lainnya";
            }
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            RiwayatPasien rp = new RiwayatPasien();
            rp.Show();
            this.Hide();
        }

        private void buttonpesan_Click(object sender, EventArgs e)
        {
            /*PasienPesan pp = new PasienPesan();
            pp.Show();
            this.Hide();*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            PasienAdd pa = new PasienAdd();
            pa.Show();
            this.Hide();
        }

        private void buttonedit_Click(object sender, EventArgs e)
        {
            PasienUpdate pu = new PasienUpdate();
            pu.Show();
            this.Hide();
            if (TempDataPasien.TipePasien == "PMC")
            {
                pu.textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                pu.textBox2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                pu.textBox3.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                pu.textBox4.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                pu.textBox5.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();            }

            if (TempDataPasien.TipePasien == "Cimenyan")
            {
                pu.textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                pu.textBox2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                pu.textBox3.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                pu.textBox4.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                pu.textBox5.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
            if (TempDataPasien.TipePasien == "Pegadaian")
            {
                pu.textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                pu.textBox2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                pu.textBox3.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                pu.textBox4.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                pu.textBox5.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
            if (TempDataPasien.TipePasien == "Lainnya")
            {
                pu.textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                pu.textBox2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                pu.textBox3.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                pu.textBox4.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                pu.textBox5.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void buttonhapus_Click(object sender, EventArgs e)
        {
            if (TempDataPasien.TipePasien == "PMC")
            {
                controll = new PassiController();
                string selectedValue = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                controll.hapuspasienpmc(selectedValue);
                FormPasien dm = new FormPasien();
                dm.Show();
                this.Hide();
            }
            if (TempDataPasien.TipePasien == "Cimenyan")
            {
                controll = new PassiController();
                string selectedValue = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                controll.hapuspasiencimenyan(selectedValue);
                FormPasien dm = new FormPasien();
                dm.Show();
                this.Hide();
            }
            if (TempDataPasien.TipePasien == "Pegadaian")
            {
                controll = new PassiController();
                string selectedValue = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                controll.hapuspasienpegadaian(selectedValue);
                FormPasien dm = new FormPasien();
                dm.Show();
                this.Hide();
            }
            if (TempDataPasien.TipePasien == "Lainnya")
            {
                controll = new PassiController();
                string selectedValue = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                controll.hapuspasienlainnya(selectedValue);
                FormPasien dm = new FormPasien();
                dm.Show();
                this.Hide();
            }
        }


    }
}