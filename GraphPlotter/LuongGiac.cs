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
    public partial class LuongGiac : Form
    {
        public LuongGiac()
        {
            InitializeComponent();
        }
        double rad;
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox10.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                rad = Convert.ToDouble(textBox1.Text);
                rad = ((Math.Cos(Math.PI * rad / 180)) / (Math.Sin(Math.PI * rad / 180)));
                textBox5.Text = rad.ToString();
            }
            else textBox5.Text = "Nhập số";
            if (textBox1.Text != "")
            {
                rad = Convert.ToDouble(textBox1.Text);
                rad = ((Math.Sin(Math.PI * rad / 180)) / (Math.Cos(Math.PI * rad / 180)));
                textBox2.Text = rad.ToString();
            }
            else textBox2.Text = "Nhập số";
            if (textBox1.Text != "")
            {
                rad = Convert.ToDouble(textBox1.Text);
                rad = (Math.Cos(Math.PI * rad / 180));
                textBox3.Text = rad.ToString();
            }
            else textBox3.Text = "Nhập số";
            if (textBox1.Text != "")
            {
                rad = Convert.ToDouble(textBox1.Text);
                rad = (Math.Sin(Math.PI * rad / 180));
                textBox4.Text = rad.ToString();
            }
            else textBox4.Text = "Nhập số";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox10.Text != "")
            {
                rad = Convert.ToDouble(textBox10.Text);
                rad = (Math.Sin(Math.PI * 180 / rad));
                textBox7.Text = rad.ToString();
            }
            else textBox7.Text = "Nhập số";
            if (textBox10.Text != "")
            {
                rad = Convert.ToDouble(textBox10.Text);
                rad = (Math.Cos(Math.PI * 180 / rad));
                textBox8.Text = rad.ToString();
            }
            else textBox8.Text = "Nhập số";
            if (textBox10.Text != "")
            {
                rad = Convert.ToDouble(textBox10.Text);
                rad = ((Math.Sin(Math.PI * 180 / rad)) / (Math.Cos(Math.PI * 180 / rad)));
                textBox9.Text = rad.ToString();
            }
            else textBox9.Text = "Nhập số";
            if (textBox10.Text != "")
            {
                rad = Convert.ToDouble(textBox10.Text);
                rad = ((Math.Cos(Math.PI * 180 / rad)) / (Math.Sin(Math.PI * 180 / rad)));
                textBox6.Text = rad.ToString();
            }
            else textBox6.Text = "Nhập số";
        }
    }
}
