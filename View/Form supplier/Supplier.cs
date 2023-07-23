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


namespace Suci_CateringGizi
{
    public partial class Supplier : Form
    {
        MySqlCommand cmd;
        MySqlConnection conn;
        MySqlDataReader reader;
        private SuppController brgcontroller = new SuppController();
       // private object dataGridView;

        public Supplier()
        {
            InitializeComponent();
            brgcontroller = new SuppController();
        }
        private void freezing()
        {
            dataGridView1.DataSource = brgcontroller.tampilBarang();
            dataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            freezing();
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            SupplierAdd sa = new SupplierAdd();
            sa.Show();
            this.Hide();
        }

        private void buttonhapus_Click(object sender, EventArgs e)
        {
                brgcontroller = new SuppController();
                string selectedValue = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                brgcontroller.hapusSupplier(selectedValue);
                Supplier dm = new Supplier();
                dm.Show();
                this.Hide();
        }
         
        private void buttonedit_Click(object sender, EventArgs e)
        {
            SupplierUpdate su = new SupplierUpdate();
            su.Show();
            this.Hide();
            su.textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            su.textBox2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            su.textBox3.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            su.textBox4.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();


        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            Form1 mn= new Form1();
            mn.Show();
            this.Hide();
        }


    }
}
