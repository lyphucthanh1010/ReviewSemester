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
    public partial class Logarit : Form
    {
        public Logarit()
        {
            InitializeComponent();
        }
        double log, mu;
        const double E = 2.718281828;
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                log = Convert.ToDouble(textBox1.Text);
                if (log > 0)
                {
                    log = Math.Log10(log);
                    textBox3.Text = log.ToString();
                }
                else textBox3.Text = "Error";
            }
            else textBox3.Text = "Nhập cơ số";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                log = Convert.ToDouble(textBox1.Text);
                if (log > 0)
                {
                    log = Math.Log(log, E);
                    textBox2.Text = log.ToString();
                }
                else textBox2.Text = "Error";
            }
            else textBox2.Text = "Nhập cơ số";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                mu = Convert.ToDouble(textBox6.Text);
                mu = (Math.Pow(10, mu));
                textBox4.Text = mu.ToString();
            }
            else textBox4.Text = "Nhập cơ số";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                mu = Convert.ToDouble(textBox6.Text);
                mu = (Math.Pow(E, mu));
                textBox5.Text = mu.ToString();
            }
            else textBox5.Text = "Nhập cơ số";
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
    }
}
