using Suci_CateringGizi.Controller;
using Suci_CateringGizi.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Suci_CateringGizi.Form_pemesanan
{
    public partial class PemesananAdd : Form
    {
        private pemesanannController control;
        public PemesananAdd()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="" || textBox2.Text==""|| textBox3.Text==""|| textBox4.Text==""|| textBox5.Text == ""){
                MessageBox.Show("Kolom inputan tidak boleh dikosongkan");
            }
            else
            {
                /*control = new pemesanannController();
                control.tambahpemesanan(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                this.Controls.Clear();
                this.InitializeComponent();
                textBox1.Focus();
                MessageBox.Show("Data tersimpan");
                Pemesanan fone = new Pemesanan();
                fone.Show();
                this.Hide();*/
                control = new pemesanannController();
                control.tambahpemesanan(textBox1.Text, dateTimePicker1.Text , textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                this.Controls.Clear();
                this.InitializeComponent();
                textBox1.Focus();
                MessageBox.Show("Berhasil menambahkan data pasien Di Patroman Medical Centre");
                Pemesanan fone = new Pemesanan();
                fone.Show();
                this.Hide();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pemesanan ps = new Pemesanan();
            ps.Show();
            this.Hide();
        }

        private void PemesananAdd_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
            textBox1.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox3.Focus();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox4.Focus();
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox5.Focus();
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2.Focus();
            }
        }
    }
}
