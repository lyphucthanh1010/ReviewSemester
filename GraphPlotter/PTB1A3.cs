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
    public partial class PTB1A3 : Form
    {
        public PTB1A3()
        {
            InitializeComponent();
        }
        double a1, a2, a3, b1, b2, b3, c1, c2, c3, d1, d2, d3, h, hx, hy, hz;

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            textBox8.Text = textBox1.Text + "x + " + textBox2.Text + "y + " + textBox6.Text + "z = " + textBox15.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox8.Text = textBox1.Text + "x + " + textBox2.Text + "y + " + textBox6.Text + "z = " + textBox15.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox8.Text = textBox1.Text + "x + " + textBox2.Text + "y + " + textBox6.Text + "z = " + textBox15.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox8.Text = textBox1.Text + "x + " + textBox2.Text + "y + " + textBox6.Text + "z = " + textBox15.Text;
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            textBox7.Text = textBox12.Text + "x + " + textBox11.Text + "y + " + textBox10.Text + "z = " + textBox14.Text;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            textBox7.Text = textBox12.Text + "x + " + textBox11.Text + "y + " + textBox10.Text + "z = " + textBox14.Text;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            textBox7.Text = textBox12.Text + "x + " + textBox11.Text + "y + " + textBox10.Text + "z = " + textBox14.Text;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            textBox7.Text = textBox12.Text + "x + " + textBox11.Text + "y + " + textBox10.Text + "z = " + textBox14.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox13.Text = textBox3.Text + "x + " + textBox4.Text + "y + " + textBox5.Text + "z = " + textBox16.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox13.Text = textBox3.Text + "x + " + textBox4.Text + "y + " + textBox5.Text + "z = " + textBox16.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox13.Text = textBox3.Text + "x + " + textBox4.Text + "y + " + textBox5.Text + "z = " + textBox16.Text;
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            textBox13.Text = textBox3.Text + "x + " + textBox4.Text + "y + " + textBox5.Text + "z = " + textBox16.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a1 = Convert.ToDouble(textBox12.Text);
                b1 = Convert.ToDouble(textBox11.Text);
                c1 = Convert.ToDouble(textBox10.Text);
                d1 = Convert.ToDouble(textBox14.Text);

                a2 = Convert.ToDouble(textBox1.Text);
                b2 = Convert.ToDouble(textBox2.Text);
                c2 = Convert.ToDouble(textBox6.Text);
                d2 = Convert.ToDouble(textBox15.Text);

                a3 = Convert.ToDouble(textBox3.Text);
                b3 = Convert.ToDouble(textBox4.Text);
                c3 = Convert.ToDouble(textBox5.Text);
                d3 = Convert.ToDouble(textBox16.Text);

                h = a1 * b2 * c3 - a1 * c2 * b3 + b1 * a2 * c3 - b1 * c2 * a3 + c1 * a2 * b3 - c1 * a3 * b2;
                hx = d1 * b2 * c3 - d1 * c2 * b3 + b1 * d2 * c3 - b1 * c2 * d3 + c1 * d2 * b3 - c1 * d3 * b2;
                hy = a1 * d2 * c3 - a1 * c2 * d3 + d1 * a2 * c3 - d1 * c2 * a3 + c1 * a2 * d3 - c1 * a3 * d2;
                hz = a1 * b2 * d3 - a1 * d2 * b3 + b1 * a2 * d3 - b1 * d2 * a3 + d1 * a2 * b3 - d1 * a3 * b2;

                if (h == 0 && hx == 0 && hy == 0 && hz == 0)
                    textBox9.Text = "Hệ phương trình vô số nghiệm ! ";
                if (h == 0) if (hx != 0 || hy != 0 || hz != 0)
                        textBox9.Text = "Hệ phương trình vô nghiệm !";
                if (h != 0)
                    textBox9.Text = "Nghiệm của hệ phương trình :\n x = " + hx / h + "\n y = " + hy / h + "\n z = " + hz / h;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }
    }
}
