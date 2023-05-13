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
    public partial class DiemDH : Form
    {
        public DiemDH()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
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

        private void button1_Click(object sender, EventArgs e)
        {
            DiemTn tn = new DiemTn();
            tn.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double A00, B00, A01, C00, D01, D07 = 0;
                double DiemVan = Double.Parse(textBox1.Text.Trim());
                double DiemToan = Double.Parse(textBox4.Text.Trim());
                double DiemAnh = Double.Parse(textBox3.Text.Trim());
                double DiemMon1 = Double.Parse(textBox5.Text.Trim());
                double DiemMon2 = Double.Parse(textBox6.Text.Trim());
                double DiemMon3 = Double.Parse(textBox7.Text.Trim());
                if (DiemVan >= 0 && DiemVan <= 10 || DiemMon1 >= 0 && DiemMon1 <= 10 || DiemAnh >= 0 && DiemAnh <= 10 || DiemToan >= 0 && DiemToan <= 10 || DiemMon2 >= 0 && DiemMon2 <= 10|| DiemMon3>=0 && DiemMon3<=10)
                {
                    A00 = DiemMon1 + DiemMon2 + DiemToan;
                    A01 = DiemMon1 + DiemToan + DiemAnh;
                    B00 = DiemToan + DiemMon2 + DiemMon3;
                    C00 = DiemVan + DiemMon1 + DiemMon2;
                    D01 = DiemVan + DiemToan + DiemAnh;
                    D07 = DiemToan + DiemMon2 + DiemAnh;
                    richTextBox1.Text = "Thí sinh " + textBox8.Text + "\n" + "SBD:" + textBox9.Text + "\n" + "Điểm các khôi của bạn là: " + "\n" + "Toán Lý Hoá " + A00.ToString() + "\n" + "Toán Lý Anh " + A01.ToString() + "\n" + "Toán Hoá Sinh " + B00.ToString() + "\n" + "Văn Sử Địa " + C00.ToString() + "\n" + "Văn Toán Anh " + D01.ToString() + "\n" + "Toán Hoá Anh " + D07.ToString(); 
                }
                else
                {
                    MessageBox.Show("Điểm bạn vừa nhập không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
