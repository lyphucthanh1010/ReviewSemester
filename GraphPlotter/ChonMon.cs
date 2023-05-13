using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VietGraph
{
    public partial class ChonMon : Form
    {
        public ChonMon()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Van v = new Van();
            v.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnhVan av = new AnhVan();
            av.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hoahoc hh = new Hoahoc();
            hh.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Toan t = new Toan();
            t.Show();
            this.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Vatly vl = new Vatly();
            vl.Show();
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sinhhoc sh = new Sinhhoc();
            sh.Show();
            this.Visible = false;
        }
    }
}
