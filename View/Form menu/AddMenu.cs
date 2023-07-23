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
    public partial class AddMenu : Form
    {
        private MenuAddController control;
        public AddMenu()
        {
            InitializeComponent();
        }
        void freezing()
        {
            //dataGridView.DataSource = control.tampilTambahMenu(TempMenuAdd.tambahMenu);
            //dataGridView.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
        }

        private void AddMenu_Load(object sender, EventArgs e)
        {

                this.ActiveControl = textBox1;
                textBox1.Focus();
                freezing();
        }

        private void simpan_Click_1(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text =="" || textBox3.Text =="" || textBox4.Text =="" ||textBox5.Text =="" ||textBox6.Text == "")
            {
                MessageBox.Show("Kolom inputan tidak boleh kosong");
            }
            else
            {
                control = new MenuAddController();
                if (TampMenu.TipeMenu == "BIASA")
                {
                    control = new MenuAddController();
                    control.tambahMenuBiasa(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
                    this.Controls.Clear();
                    this.InitializeComponent();
                    textBox1.Focus();
                    MessageBox.Show("Berhasil menambahkan data menu biasa");
                    DataMenu fone = new DataMenu();
                    fone.Show();
                    //Application.Restart();
                    this.Hide();
                }
                if (TampMenu.TipeMenu == "LUNAK")
                {
                    control = new MenuAddController();
                    control.tambahMenuLunak(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
                    this.Controls.Clear();
                    this.InitializeComponent();
                    textBox1.Focus();
                    MessageBox.Show("Berhasil menambahkan data menu lunak");
                    DataMenu fone = new DataMenu();
                    fone.Show();
                    //Application.Restart();
                    this.Hide();
                }
                if (TampMenu.TipeMenu == "SARING")
                {
                    control = new MenuAddController();
                    control.tambahMenuSaring(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
                    this.Controls.Clear();
                    this.InitializeComponent();
                    textBox1.Focus();
                    MessageBox.Show("Berhasil menambahkan data menu saring");
                    DataMenu fone = new DataMenu();
                    fone.Show();
                    //Application.Restart();
                    this.Hide();
                }
                if (TampMenu.TipeMenu == "CAIR")
                {
                    control = new MenuAddController();
                    control.tambahMenuCair(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
                    this.Controls.Clear();
                    this.InitializeComponent();
                    textBox1.Focus();
                    MessageBox.Show("Berhasil menambahkan data menu cair");
                    DataMenu fone = new DataMenu();
                    fone.Show();
                    //Application.Restart();
                    this.Hide();
                }

            }

        }

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            DataMenu dm = new DataMenu();
            dm.Show();
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
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
                textBox6.Focus();
            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpan.Focus();
            }
        }
    }
}
