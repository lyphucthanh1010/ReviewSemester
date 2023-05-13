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
    public partial class LuyThua : Form
    {
        public LuyThua()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        double a1, a2, n;
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                a1 = Convert.ToDouble(textBox1.Text);
                a1 = Math.Abs(a1);
                a1 = a1 * a1;
                textBox3.Text = a1.ToString();
            }
            else textBox3.Text = "Nhập cơ số";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                a1 = Convert.ToDouble(textBox1.Text);
                a1 = a1 * a1 * a1;
                textBox2.Text = a1.ToString();
            }
            else textBox2.Text = "Nhập cơ số";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                if (textBox4.Text != "")
                {

                    a2 = Convert.ToDouble(textBox6.Text);
                    n = Convert.ToDouble(textBox4.Text);
                    a2 = (Math.Pow(a2, n));
                    textBox5.Text = a2.ToString();
                }
                else textBox4.Text = "Nhập số mũ";
            }
            else textBox6.Text = "Nhập cơ số";
        }
    }
}
