using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Suci_CateringGizi.Controller;
using Suci_CateringGizi.Model;

namespace Suci_CateringGizi.Form_Riwayat_pembayaran
{
    public partial class Riwayatbayar : Form
    {
        pembayaranController controll = new pembayaranController();
        public Riwayatbayar()
        {
            InitializeComponent();
        }

        private void Riwayatbayar_Load(object sender, EventArgs e)
        {
            reloadTable();
            for(int a=1; a<=12; a++)
            {
                if (a < 10)
                {
                    comboBox1.Items.Add("0"+a);
                }
                else if(a>=10 && a<=12)
                {
                    comboBox1.Items.Add(a);
                }
            }
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ff = new Form1();
            ff.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pembayaranController pembayaran = new pembayaranController();
            dataGridView1.DataSource = pembayaran.bulan(comboBox1.Text);
        }

        public void reloadTable()
        {
            dataGridView1.DataSource = controll.riwayat();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
