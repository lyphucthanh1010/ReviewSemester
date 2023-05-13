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
    public partial class Van : Form
    {
        int Dem = 0;
        public Van()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel1.LinkVisited = true;
                System.Diagnostics.Process.Start("https://butbi.hocmai.vn/on-thi-thpt-quoc-gia-2022-mon-ngu-van.html");
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
                System.Diagnostics.Process.Start("https://butbi.hocmai.vn/phan-tich-chiec-thuyen-ngoai-xa.html");
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
                System.Diagnostics.Process.Start("https://butbi.hocmai.vn/phan-tich-tac-pham-vo-chong-a-phu.html");
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
                System.Diagnostics.Process.Start("https://butbi.hocmai.vn/phan-tich-tac-pham-vo-nhat.html");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở được link đã mở");
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel5.LinkVisited = true;
                System.Diagnostics.Process.Start("https://butbi.hocmai.vn/phan-tich-bai-nguoi-lai-do-song-da.html");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở được link đã mở");
            }
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel6.LinkVisited = true;
                System.Diagnostics.Process.Start("https://butbi.hocmai.vn/phan-tich-tac-pham-ai-da-dat-ten-cho-dong-song.html");
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
                System.Diagnostics.Process.Start("https://butbi.hocmai.vn/phan-tich-bai-tho-dat-nuoc-nguyen-khoa-diem.html");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở được link đã mở");
            }
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel8.LinkVisited = true;
                System.Diagnostics.Process.Start("https://butbi.hocmai.vn/phan-tich-bai-tho-dat-nuoc-nguyen-dinh-thi.html");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở được link đã mở");
            }
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel9.LinkVisited = true;
                System.Diagnostics.Process.Start("https://butbi.hocmai.vn/phan-tich-bai-tho-viet-bac.html");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở được link đã mở");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dem++;
            label3.Text = Dem.ToString();
            button1.Enabled = true;
            if(Dem < 7 )
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
            if( Dem ==0 )
            {
                panel1.Visible = true;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = false;
            }   
            else if(Dem ==1)
            {
                panel1.Visible = false;
                panel2.Visible = true;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = false;
            }    
            else if(Dem==2)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = true;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = false;
            }  
            else if(Dem==3)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = true;
                panel5.Visible = false;
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = false;
            }    
            else if(Dem ==4)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = true;
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = false;
            }  
            else if(Dem==5)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = true;
                panel7.Visible = false;
                panel8.Visible = false;
            }   
            else if(Dem ==6)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                panel7.Visible = true;
                panel8.Visible = false;
            }    
            else
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = true;
            }    
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
