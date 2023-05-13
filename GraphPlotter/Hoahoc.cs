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
    public partial class Hoahoc : Form
    {
        int Dem = 0;
        public Hoahoc()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dem++;
            label3.Text = Dem.ToString();
            button1.Enabled = true;
            if (Dem < 5)
            {
                button2.Enabled = true;
            }
            else { button2.Enabled = false; }
            XuLyBai();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dem--;
            label3.Text = Dem.ToString();
            if (Dem > 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
            else { button1.Enabled = false; }
            XuLyBai();
        }
        public void XuLyBai()
        {
            if (Dem == 0)
            {
                panel6.Visible = true;
                panel5.Visible = false;
                panel4.Visible = false;
                panel3.Visible = false;
                panel2.Visible = false;
                panel1.Visible = false;
              
            
            }
            else if (Dem == 1)
            {
                panel6.Visible = false;
                panel5.Visible = true;
                panel4.Visible = false;
                panel3.Visible = false;
                panel2.Visible = false;
                panel1.Visible = false;
              
            }
            else if (Dem == 2)
            {
                panel6.Visible = false;
                panel5.Visible = false;
                panel4.Visible = true;
                panel3.Visible = false;
                panel2.Visible = false;
                panel1.Visible = false;
               
            }
            else if (Dem == 3)
            {
                panel6.Visible = false;
                panel5.Visible = false;
                panel4.Visible = false;
                panel3.Visible = true;
                panel2.Visible = false;
                panel1.Visible = false;
            }
            else if (Dem == 4)
            {
                panel6.Visible = false;
                panel5.Visible = false;
                panel4.Visible = false;
                panel3.Visible = false;
                panel2.Visible = true;
                panel1.Visible = false;
              
            }
            else
            {
                panel6.Visible = false;
                panel5.Visible = false;
                panel4.Visible = false;
                panel3.Visible = false;
                panel2.Visible = false;
                panel1.Visible = true;
                
            }
          
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel6.LinkVisited = true;
                System.Diagnostics.Process.Start("https://drive.google.com/file/d/1A4x1OKvS0QifswUIwx-7f_vcif-UlKKY/view?usp=sharing");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở được link đã mở");
            }
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel7.LinkVisited = true;
                System.Diagnostics.Process.Start("https://luyenthidgnl.com.vn/so-do-tu-duy-hoa-hoc-12");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở được link đã mở");
            }
        }

        private void linkLabel5_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel5.LinkVisited = true;
                System.Diagnostics.Process.Start("https://drive.google.com/file/d/1y90WZa2OLbFRqybP3-YD_I06hvAlvsVJ/view?usp=sharing");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở được link đã mở");
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel4.LinkVisited = true;
                System.Diagnostics.Process.Start("https://drive.google.com/file/d/1W_0UI4fLCQ1SMJvTZELqHSt8C7xAVUEK/view?usp=sharing");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở được link đã mở");
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel3.LinkVisited = true;
                System.Diagnostics.Process.Start("https://drive.google.com/file/d/18hUMx1c8Fpzz8BduZRbGZ6PD7AYiCVd0/view?usp=sharing");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở được link đã mở");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel1.LinkVisited = true;
                System.Diagnostics.Process.Start("https://drive.google.com/file/d/1rYg3QsEsGMAKQr3_dZTH28BtSNjyTRsL/view?usp=sharing");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở được link đã mở");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel2.LinkVisited = true;
                System.Diagnostics.Process.Start("https://drive.google.com/file/d/1TXrVsjH2rgFiRdk-BFG3OmUO4kYzOhxD/view?usp=sharing");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở được link đã mở");
            }
        }
    }
}
