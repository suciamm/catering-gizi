using Suci_CateringGizi.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySqlConnector;
using System.Threading.Tasks;
using System.Windows.Forms;
using Suci_CateringGizi.Controller;

namespace Suci_CateringGizi.Form_pasien
{
    public partial class PasienUpdate : Form
    {
        private PasienUpdateController updatepass = new PasienUpdateController();
        public PasienUpdate()
        {
            InitializeComponent();
        }

        private void simpan_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Kolom inputan tidak boleh kosong");
            }
            else
            {
                updatepass = new PasienUpdateController();

                if (TempDataPasien.TipePasien == "PMC")
                {
                    updatepass.UpdatepasianPmc(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                }
                if (TempDataPasien.TipePasien == "Cimenyan")
                {
                    updatepass.Updatepasiancimenyan(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);

                }
                if (TempDataPasien.TipePasien == "Pegadaian")
                {
                    updatepass.Updatepasianpegadaian(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);

                }
                if (TempDataPasien.TipePasien == "Lainnya")
                {
                    updatepass.Updatepasienlainnya(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);

                }
                this.Controls.Clear();
                this.InitializeComponent();
                textBox1.Focus();
                MessageBox.Show("Data tersimpan");
                FormPasien fone = new FormPasien();
                fone.Show();
                this.Hide();
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

        private void PasienUpdate_Load(object sender, EventArgs e)
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
