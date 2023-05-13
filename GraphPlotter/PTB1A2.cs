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
    public partial class PTB1A2 : Form
    {
        public PTB1A2()
        {
            InitializeComponent();
        }
        double a1, b1, c1, a2, b2, c2, d, d1, d2;

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox8.Text = textBox3.Text + "x + " + textBox4.Text + "y =" + textBox5.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox8.Text = textBox3.Text + "x + " + textBox4.Text + "y =" + textBox5.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox7.Text = textBox1.Text + "x + " + textBox2.Text + "y =" + textBox6.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox7.Text = textBox1.Text + "x + " + textBox2.Text + "y =" + textBox6.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox8.Text = textBox3.Text + "x + " + textBox4.Text + "y =" + textBox5.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox7.Text = textBox1.Text + "x + " + textBox2.Text + "y =" + textBox6.Text;
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
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a1 = Convert.ToDouble(textBox1.Text);
            b1 = Convert.ToDouble(textBox2.Text);
            c1 = Convert.ToDouble(textBox6.Text);
            a2 = Convert.ToDouble(textBox3.Text);
            b2 = Convert.ToDouble(textBox4.Text);
            c2 = Convert.ToDouble(textBox5.Text);

            d = a1 * b2 - a2 * b1;
            d1 = c1 * b2 - c2 * b1;
            d2 = a1 * c2 - a2 * c1;

            if ((a1 / a2) != (b1 / b2))
                textBox9.Text = "Hệ phương trình có nghiệm :\n x = " + d1 / d + "\n y = " + d2 / d;
            else
            if (((a1 / a2) == (b1 / b2)) && ((b1 / b2) == (c1 / c2)))
                textBox9.Text = "\t Hệ phương trình vô số nghiệm.";
            else
                if (((a1 / a2) == (b1 / b2)) && ((b1 / b2) != (c1 / c2)))
                textBox9.Text = "\t Hệ phương trình vô nghiệm .";

        }
    }
}
