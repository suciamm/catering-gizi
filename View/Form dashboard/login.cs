using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suci_CateringGizi.Form_dashboard
{
    public partial class login : Form
    {
        
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txboxusername.Focus();
            if (txboxusername.Text == "suciamnh" && textBox2.Text == "suci")
            {
                Form1 fone = new Form1();
                fone.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau password yang anda masukan salah");
                txboxusername.Clear();
                textBox2.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txboxusername;
            txboxusername.Focus();
        }

        private void txboxusername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
        }
    }
}
