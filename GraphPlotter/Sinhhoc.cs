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
    public partial class Sinhhoc : Form
    {
        public Sinhhoc()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel1.LinkVisited = true;
                System.Diagnostics.Process.Start("https://drive.google.com/file/d/1PYhZthE3OeNMJs1oLd9rx3wO76Crvh5R/view?usp=sharing");
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
                System.Diagnostics.Process.Start("https://drive.google.com/file/d/1ZzCNw5wytsPCAgJFtFpdSyIJmmOPlz_T/view?usp=sharing");
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
                System.Diagnostics.Process.Start("https://butbi.hocmai.vn/on-thi-thpt-quoc-gia-mon-sinh-2022.html");
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
                System.Diagnostics.Process.Start("https://tuyensinhso.vn/ban-tin-truoc-ky-thi/so-do-hoa-kien-thuc-ly-thuyet-sinh-hoc-lop-12-giup-thi-sinh-vuot-qua-ky-thi-c25633.html");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở được link đã mở");
            }
        }
    }
}
