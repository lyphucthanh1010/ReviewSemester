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
    public partial class Choose : Form
    {
        public Choose()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Draw dr = new Draw();
            dr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Introduction itdt = new Introduction();
            itdt.Show();
            this.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Cal cl = new Cal();
            cl.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DiemTn gg = new DiemTn();
            gg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChonMon cm = new ChonMon();
            cm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LamBai lb = new LamBai();
            lb.Show();
        }
    }
}
