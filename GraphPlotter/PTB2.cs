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
    public partial class PTB2 : Form
    {
        public PTB2()
        {
            InitializeComponent();
        }
        double a, b, c, de, x1, x2, x;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox6.Text = textBox1.Text + "x² + " + textBox3.Text + "x + " + textBox2.Text + " = 0";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox6.Text = textBox1.Text + "x² + " + textBox3.Text + "x + " + textBox2.Text + " = 0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox6.Text = textBox1.Text + "x² + " + textBox3.Text + "x + " + textBox2.Text + " = 0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox3.Text);
                c = Convert.ToDouble(textBox2.Text);
                x = (-c) / b;
                de = b * b - 4 * a * c;
                x1 = ((-b) + Math.Sqrt(de)) / (2 * a);
                x2 = ((-b) - Math.Sqrt(de)) / (2 * a);

                if (textBox1.Text == "" || textBox3.Text == "" || textBox2.Text == "")
                    textBox4.Text = "Nhập hệ số!";
                else
                    if (a == 0) textBox4.Text = "Phương trình có 1 nghiệm:\n x= " + x;
                else
                {
                    de = b * b - 4 * a * c;
                    if (de < 0) textBox4.Text = "Phương trình vô nghiệm";
                    else
                        if (de == 0)
                    {
                        x = (-b) / (2 * a);
                        textBox4.Text = "Phương trình có nghiệm kép:\n x1=x2= " + x;
                    }
                    else
                    {
                        textBox4.Text = "Phương trình có 2 nghiệm phân biệt :\n x1= " + x1 + "\n" + "\n x2=" + x2;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
