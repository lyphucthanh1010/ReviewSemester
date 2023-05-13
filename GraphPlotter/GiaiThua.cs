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
    public partial class GiaiThua : Form
    {
        public GiaiThua()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n, gt = 1;
            if (textBox1.Text == "")
                textBox2.Text = "Please write your number!";
            else
            {
                n = Convert.ToDouble(textBox1.Text);
                if (n >= 0)
                {
                    for (int i = 1; i <= n; i++)
                        gt = gt * i;
                    textBox2.Text = gt.ToString();
                }
                else
                    textBox2.Text = "Error";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
