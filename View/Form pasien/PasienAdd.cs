using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suci_CateringGizi.Form_pasien
{
    public partial class PasienAdd : Form
    {
        private PassiController control = new PassiController();
        public PasienAdd()
        {
            InitializeComponent();
        }

        private void simpan_Click(object sender, EventArgs e)
        {
            if(textBox1.Text ==""|| textBox2.Text==""|| textBox3.Text==""|| textBox4.Text==""|| textBox5.Text == "")
            {
                MessageBox.Show("Kolom inputan tidak boleh kosong");
            }
            else
            {
                control = new PassiController();
                if (TempDataPasien.TipePasien == "PMC")
                {
                    control = new PassiController();
                    control.tambahpasienpmc(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                    this.Controls.Clear();
                    this.InitializeComponent();
                    textBox1.Focus();
                    MessageBox.Show("Berhasil menambahkan data pasien Di Patroman Medical Centre");
                    FormPasien fone = new FormPasien();
                    fone.Show();
                    this.Hide();
                }
                if (TempDataPasien.TipePasien == "Cimenyan")
                {
                    control = new PassiController();
                    control.tambahpasiencimenyan(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                    this.Controls.Clear();
                    this.InitializeComponent();
                    textBox1.Focus();
                    MessageBox.Show("Berhasil menambahkan data pasien Di Klinik Cimenyan");
                    FormPasien fone = new FormPasien();
                    fone.Show();
                    this.Hide();
                }
                if (TempDataPasien.TipePasien == "Pegadaian")
                {
                    control = new PassiController();
                    control.tambahpasienpegadaian(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                    this.Controls.Clear();
                    this.InitializeComponent();
                    textBox1.Focus();
                    MessageBox.Show("Berhasil menambahkan data pasien Di Klinik Utama Pegadaian");
                    FormPasien fone = new FormPasien();
                    fone.Show();
                    this.Hide();
                }
                if (TempDataPasien.TipePasien == "Lainnya")
                {
                    control = new PassiController();
                    control.tambahpasienlainnya(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                    this.Controls.Clear();
                    this.InitializeComponent();
                    textBox1.Focus();
                    MessageBox.Show("Berhasil menambahkan data pasien Di Pasien lainnya");
                    FormPasien fone = new FormPasien();
                    fone.Show();
                    this.Hide();
                }

            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormPasien fp = new FormPasien();
            fp.Show();
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PasienAdd_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
            textBox1.Focus();
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
                simpan.Focus();
            }
        }
    }
}
