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
    public partial class KhaiCan : Form
    {
        public KhaiCan()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double a1 = Convert.ToDouble(textBox1.Text);
                if (a1 > 0)
                {

                    a1 = Math.Sqrt(a1);
                    textBox3.Text = a1.ToString();
                }
                else textBox3.Text = "Error";
            }
            else textBox3.Text = "Nhập số";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double a1 = Convert.ToDouble(textBox1.Text);
                if (a1 < 0)
                {
                    a1 = Math.Abs(a1);
                    a1 = (Math.Pow(a1, Convert.ToDouble(1) / 3));
                    textBox2.Text = "-" + a1.ToString();
                }
                else
                {
                    a1 = (Math.Pow(a1, Convert.ToDouble(1) / 3));
                    textBox2.Text = a1.ToString();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                if (textBox4.Text != "")
                {
                    double a2 = Convert.ToDouble(textBox6.Text);
                    double n = Convert.ToDouble(textBox4.Text);
                    if (a2 < 0)
                    {
                        a2 = Math.Abs(a2);

                        if ((n % 2) != 0)
                        {

                            a2 = (Math.Pow(a2, Convert.ToDouble(1) / n));
                            textBox5.Text = "-" + a2.ToString();
                        }
                        else textBox5.Text = "Error";
                    }
                    else
                    {
                        a2 = (Math.Pow(a2, Convert.ToDouble(1) / n));
                        textBox5.Text = a2.ToString();
                    }
                }
                else textBox5.Text = "Nhập căn";
            }
            else textBox5.Text = "Nhập số";

        }
    }
}
