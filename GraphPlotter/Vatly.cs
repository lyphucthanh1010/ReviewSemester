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
    public partial class Vatly : Form
    {
        public Vatly()
        {
            InitializeComponent();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel6.LinkVisited = true;
                System.Diagnostics.Process.Start("https://tuyensinhso.vn/ban-tin-truoc-ky-thi/so-do-tu-duy-kien-thuc-mon-vat-ly-cho-on-thi-thpt-quoc-gia-c25723.html");
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
                System.Diagnostics.Process.Start("http://nangtamkienthuc.com/cau-truc-de-thi-thpt-quoc-gia-mon-vat-ly/");
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
                System.Diagnostics.Process.Start("https://tuyensinhso.vn/ban-tin-truoc-ky-thi/phuong-phap-giai-nhanh-trac-nghiem-vat-ly-lop-12-bang-may-tinh-casio-c26257.html");
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
                System.Diagnostics.Process.Start("https://butbi.hocmai.vn/on-thi-thpt-quoc-gia-2022-mon-vat-li.html");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở được link đã mở");
            }
        }
    }
}
