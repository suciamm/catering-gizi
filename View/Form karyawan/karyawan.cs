using MySqlConnector;
using Suci_CateringGizi.Controller;
using System;
//using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suci_CateringGizi.Form_karyawan
{
    public partial class karyawan : Form
    {
        karyawanController kc = new karyawanController();
        public karyawan()
        {
            InitializeComponent();
        }
        private void freezing()
        {
            dataGridView1.DataSource = kc.tampilkaryawan();
            dataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Addkaryawan ak = new Addkaryawan();
            ak.Show();
            this.Hide();
        }

        private void karyawan_Load(object sender, EventArgs e)
        {

            freezing();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateKaryawan su = new UpdateKaryawan();
            su.Show();
            this.Hide();
            su.textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            su.textBox2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            su.textBox3.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            su.textBox4.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            su.textBox5.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();

            if (su.textBox1.Text == "")
            {
                MessageBox.Show("Anda belum memiliki data apapun untuk di ubah");
                karyawan ps = new karyawan();
                ps.Show();
                this.Hide();
            }
            else
            {
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            kc = new karyawanController();
            string selectedValue = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            kc.hapuskaryawan(selectedValue);
            karyawan dm = new karyawan();
            dm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 fone = new Form1();
            fone.Show();
            this.Hide();
        }
    }
}
