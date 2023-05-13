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
    public partial class AnhVan : Form
    {
        public AnhVan()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel1.LinkVisited = true;
                System.Diagnostics.Process.Start("https://prep.vn/blog/cac-dang-bai-trong-de-thi-tieng-anh-thpt-quoc-gia/");

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
                System.Diagnostics.Process.Start("https://drive.google.com/file/d/19upWJ_aQmQkq5wg8VJA3uGqm55jAZchj/view?usp=sharing");

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
                System.Diagnostics.Process.Start("https://drive.google.com/file/d/11J99frviLNE4VqVkIZyqyWl4ZZAIEPtW/view?usp=sharing ");

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
                System.Diagnostics.Process.Start("https://drive.google.com/file/d/1DxxIRrds_PB_FLg8BpQk1JdpUUcKK94t/view?usp=sharing");

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
                System.Diagnostics.Process.Start("https://drive.google.com/file/d/1TPEj7Mb3obfdQak--8bkDURfJ5fqUCnu/view?usp=sharing");

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
                System.Diagnostics.Process.Start("https://drive.google.com/file/d/1Ra4O9xJ9srTpjpdgi2rpGdxNCU28RuHs/view?usp=sharing");

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
                System.Diagnostics.Process.Start("https://drive.google.com/file/d/1YIS3cdmFFVP_uKjF-WsRSd_q2wjneltP/view?usp=sharing");

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
                System.Diagnostics.Process.Start("https://drive.google.com/file/d/1JcmnWmDkkvh7K7tR-Ad43qcEMm5SnpBG/view?usp=sharing");

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
                System.Diagnostics.Process.Start("https://drive.google.com/file/d/1uhy2_1U6S4oh15GPxdfNiCqohufR70Mc/view?usp=sharing");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở được link đã mở");
            }
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel10.LinkVisited = true;
                System.Diagnostics.Process.Start("https://drive.google.com/file/d/1m3ZT9X7ZFnXIdv7IL91TuNu7fB0IFeRD/view?usp=sharing");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở được link đã mở");
            }
        }
    }
}
