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
    public partial class DiemTn : Form
    {
        public DiemTn()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
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
            richTextBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double KQua = 0;
                double DiemVan = Double.Parse(textBox1.Text.Trim());
                double DiemToan = Double.Parse(textBox4.Text.Trim());
                double DiemAnh = Double.Parse(textBox3.Text.Trim());
                double DiemKhoi = Double.Parse(textBox2.Text.Trim());
                double DiemTrb = Double.Parse(textBox5.Text.Trim());
                double DiemUT = Double.Parse(textBox6.Text.Trim());
                double DiemKK = Double.Parse(textBox7.Text.Trim());
                if (DiemVan >= 0 && DiemVan <= 10 || DiemKhoi >=0 && DiemKhoi <=10 || DiemAnh >= 0 && DiemAnh <= 10 || DiemToan >= 0 && DiemToan <= 10 ||DiemTrb >= 0 && DiemTrb <= 10)
                {
                        KQua = ((((DiemVan + DiemToan + DiemAnh + DiemKhoi + DiemKK) / 4) * 7 + DiemTrb * 3) / 10) + DiemUT;
                        richTextBox1.Text = "Thí sinh " + textBox8.Text + "\n" + "SBD:" + textBox9.Text + "\n" + "Điểm xét tốt nghiệp của bạn là: " + KQua.ToString();
                }
                else
                {
                    MessageBox.Show("Điểm bạn vừa nhập không hợp lệ", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                } 
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DiemDH dh = new DiemDH();
            dh.Show();
            this.Visible = false;
        }
    }
}
