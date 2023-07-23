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

namespace Suci_CateringGizi
{
    public partial class DataMenu : Form
    {   
        private MenuController controll = new MenuController();
        //private MenuController brgController;
        private MySqlConnection conn;
        private MySqlCommand cmd;
        //private MySqlDataReader reader;
        public DataMenu()
        {
            InitializeComponent();
        }
        void freezing()
        {
            dataGridView.DataSource = controll.tampilBarangMenu(TampMenu.TipeMenu);
            dataGridView.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
        }

        private void DataMenu_Load(object sender, EventArgs e)
        {
            freezing();
            if (TampMenu.TipeMenu == "BIASA")
            {
                label2.Text = "BIASA";
            }
            if (TampMenu.TipeMenu == "LUNAK")
            {
                label2.Text = "LUNAK";
            }
            if (TampMenu.TipeMenu == "SARING")
            {
                label2.Text = "SARING";
            }
            if (TampMenu.TipeMenu == "CAIR")
            {
                label2.Text = "CAIR";
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TempDataPasien.TipePasien);
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            AddMenu am = new AddMenu();
            am.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if(dataGridView.CurrentRow.Cells[0].Value == " ")
            {

            }
            UpdateMenu su = new UpdateMenu();
            su.Show();
            this.Hide();
            if (TampMenu.TipeMenu == "BIASA")
            {
                su.textBox1.Text = this.dataGridView.CurrentRow.Cells[0].Value.ToString();
                su.textBox2.Text = this.dataGridView.CurrentRow.Cells[1].Value.ToString();
                su.textBox3.Text = this.dataGridView.CurrentRow.Cells[2].Value.ToString();
                su.textBox4.Text = this.dataGridView.CurrentRow.Cells[3].Value.ToString();
                su.textBox5.Text = this.dataGridView.CurrentRow.Cells[4].Value.ToString();
                su.textBox6.Text = this.dataGridView.CurrentRow.Cells[5].Value.ToString();
            }
            if (TampMenu.TipeMenu == "LUNAK")
            {
                su.textBox1.Text = this.dataGridView.CurrentRow.Cells[0].Value.ToString();
                su.textBox2.Text = this.dataGridView.CurrentRow.Cells[1].Value.ToString();
                su.textBox3.Text = this.dataGridView.CurrentRow.Cells[2].Value.ToString();
                su.textBox4.Text = this.dataGridView.CurrentRow.Cells[3].Value.ToString();
                su.textBox5.Text = this.dataGridView.CurrentRow.Cells[4].Value.ToString();
                su.textBox6.Text = this.dataGridView.CurrentRow.Cells[5].Value.ToString();
            }
            if (TampMenu.TipeMenu == "CAIR")
            {
                su.textBox1.Text = this.dataGridView.CurrentRow.Cells[0].Value.ToString();
                su.textBox2.Text = this.dataGridView.CurrentRow.Cells[1].Value.ToString();
                su.textBox3.Text = this.dataGridView.CurrentRow.Cells[2].Value.ToString();
                su.textBox4.Text = this.dataGridView.CurrentRow.Cells[3].Value.ToString();
                su.textBox5.Text = this.dataGridView.CurrentRow.Cells[4].Value.ToString();
                su.textBox6.Text = this.dataGridView.CurrentRow.Cells[5].Value.ToString();
            }
            if (TampMenu.TipeMenu == "SARING")
            {
                su.textBox1.Text = this.dataGridView.CurrentRow.Cells[0].Value.ToString();
                su.textBox2.Text = this.dataGridView.CurrentRow.Cells[1].Value.ToString();
                su.textBox3.Text = this.dataGridView.CurrentRow.Cells[2].Value.ToString();
                su.textBox4.Text = this.dataGridView.CurrentRow.Cells[3].Value.ToString();
                su.textBox5.Text = this.dataGridView.CurrentRow.Cells[4].Value.ToString();
                su.textBox6.Text = this.dataGridView.CurrentRow.Cells[5].Value.ToString();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (TampMenu.TipeMenu == "BIASA")
            {
                controll = new MenuController();
                string selectedValue = this.dataGridView.CurrentRow.Cells[0].Value.ToString();
                controll.hapusmenubiasa(selectedValue);
                DataMenu dm = new DataMenu();
                dm.Show();
                this.Hide();
            }
            if (TampMenu.TipeMenu == "SARING")
            {
                controll = new MenuController();
                string selectedValue = this.dataGridView.CurrentRow.Cells[0].Value.ToString();
                controll.hapusmenusaring(selectedValue);
                DataMenu dm = new DataMenu();
                dm.Show();
                this.Hide();
            }
            if (TampMenu.TipeMenu == "CAIR")
            {
                controll = new MenuController();
                string selectedValue = this.dataGridView.CurrentRow.Cells[0].Value.ToString();
                controll.hapusmenucair(selectedValue);
                DataMenu dm = new DataMenu();
                dm.Show();
                this.Hide();
            }
            if (TampMenu.TipeMenu == "LUNAK")
            {
                controll = new MenuController();
                string selectedValue = this.dataGridView.CurrentRow.Cells[0].Value.ToString();
                controll.hapusmenulunak(selectedValue);
                DataMenu dm = new DataMenu();
                dm.Show();
                this.Hide();
            }
        }

        private void buttonkembali_Click(object sender, EventArgs e)
        {
            MenuMakanan mm = new MenuMakanan();
            mm.Show();
            this.Hide();
        }
    }
}
