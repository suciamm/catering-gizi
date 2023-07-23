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
    public partial class MenuMakanan : Form
    {
        public MenuMakanan()
        {
            InitializeComponent();
        }

        private void buttonbiasa_Click(object sender, EventArgs e)
        {
            TampMenu.TipeMenu = "BIASA";
            DataMenu frm2 = new DataMenu();
            this.Hide();
            frm2.Show();
            frm2.label2.Text = TampMenu.TipeMenu;
        }

        private void buttonlunak_Click(object sender, EventArgs e)
        {
            TampMenu.TipeMenu = "LUNAK";
            DataMenu frm2 = new DataMenu();
            this.Hide();
            frm2.Show();
            frm2.label2.Text = TampMenu.TipeMenu;
        }

        private void buttonsaring_Click(object sender, EventArgs e)
        {
            TampMenu.TipeMenu = "SARING";
            DataMenu frm2 = new DataMenu();
            this.Hide();
            frm2.Show();
            frm2.label2.Text = TampMenu.TipeMenu;
        }

        private void buttoncair_Click(object sender, EventArgs e)
        {
            TampMenu.TipeMenu = "CAIR";
            DataMenu frm2 = new DataMenu();
            this.Hide();
            frm2.Show();
            frm2.label2.Text = TampMenu.TipeMenu;
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            Form1 fone = new Form1();
            fone.Show();
            this.Hide();
        }
    }
}
