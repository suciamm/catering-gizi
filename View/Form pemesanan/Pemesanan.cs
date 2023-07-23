using MySqlConnector;
using Suci_CateringGizi.Controller;
using Suci_CateringGizi.Form_menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Suci_CateringGizi.Model;
using Suci_CateringGizi.Form_pemesanan;

namespace Suci_CateringGizi
{
    public partial class Pemesanan : Form
    {
        MySqlCommand cmd;
        MySqlConnection conn;
        MySqlDataReader reader;

        private pemesanannController brgcontroller = new pemesanannController();
        // private object dataGridView;

        private void freezing()
        {
            dataGridView1.DataSource = brgcontroller.tampilkpemesanan();
            dataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
        }

        public Pemesanan()
        {
            InitializeComponent();
            brgcontroller = new pemesanannController();
        }

        private void Pemesanan_Load(object sender, EventArgs e)
        {
            freezing();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fone = new Form1();
            fone.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            brgcontroller = new pemesanannController();
            string selectedValue = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            brgcontroller.hapuspemesanan(selectedValue);
            Pemesanan dm = new Pemesanan();
            dm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PemesananUpdate fthr = new PemesananUpdate();
            fthr.Show();
            this.Hide();
            fthr.textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            fthr.textBox3.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            fthr.textBox4.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            fthr.textBox5.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PemesananAdd pa = new PemesananAdd();
            pa.Show();
            this.Hide();
        }
    }
}
