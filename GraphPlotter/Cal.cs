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
    public partial class Cal : Form
    {
        public Cal()
        {
            InitializeComponent();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            panel1.Enabled = true;
            button35.Enabled = true;
            button33.Enabled = false;
            panel2.Enabled = true;
            button39.Enabled = true;
            button40.Enabled = true;
            button32.Enabled = true;
            button31.Enabled = true;
            button42.Enabled = true;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            panel1.Enabled = false;
            button35.Enabled = false;
            button33.Enabled = true;
            panel2.Enabled = false;
            button39.Enabled = false;
            button40.Enabled = false;
            button32.Enabled = false;
            button31.Enabled = false;
            button42.Enabled = false;
        }
        double FirstNumber;
        string Operation;
        public bool ClBang = false;
        public string KetQua = "";
        public int NgoacTrai = 0;
        public int NgoacPhai = 0;
        double m;
        public double TinhTich(string str)
        {
            double Tich = 0;
            int l = 0;
            string s1 = str.Substring(l, 1);
            string s2 = "";
            string dau = "";
            while (s1 != "*" && s1 != "/" && l < str.Length)
            {
                s2 = s2 + str.Substring(l, 1);
                l++;
                if (l == str.Length) break;
                s1 = str.Substring(l, 1);
            }
            Tich = double.Parse(s2);
            while (l < str.Length)
            {
                string s3 = "";
                dau = str.Substring(l, 1);

                l++;
                s1 = str.Substring(l, 1);
                while (s1 != "*" && s1 != "/" && l < str.Length)
                {
                    s3 = s3 + str.Substring(l, 1);
                    l++;
                    if (l == str.Length) break;
                    s1 = str.Substring(l, 1);
                }
                if (dau == "*")
                {
                    Tich = Tich * double.Parse(s3);
                    continue;
                }
                if (dau == "/")
                {
                    Tich = Tich / double.Parse(s3);
                    continue;
                }
            }
            return Tich;
        }
        public double tinhKetQua(string str)
        {
            int l = str.Length;

            double result = 0;
            while (l > 0)
            {
                string s1 = "";
                string dau = "";
                string s = str.Substring(l - 1, 1);
                while (s != "+" && s != "-" && s != "*" && s != "/" && l > 0)
                {
                    s1 = str.Substring(l - 1, 1) + s1;
                    l--;
                    if (l == 0) break;
                    s = str.Substring(l - 1, 1);
                }
                if (l == 0)
                    dau = "";
                else
                    dau = str.Substring(l - 1, 1);
                if (dau == "")
                {
                    result += double.Parse(s1);
                }
                if (dau == "+")
                {
                    result = result + double.Parse(s1);
                    l--;
                    continue;
                }
                if (dau == "-")
                {
                    result = result - double.Parse(s1);
                    l--;
                    continue;
                }
                if (dau == "*" || dau == "/")
                {
                    string str_s1 = str.Substring(l - 1, 1);
                    string str_s2 = s1;
                    string d = "";//dấu + or - trước tích:-(3*3*5)
                    while (str_s1 != "+" && str_s1 != "-" && l > 0)
                    {
                        str_s2 = str.Substring(l - 1, 1) + str_s2;
                        l--;
                        if (l == 0) break;
                        str_s1 = str.Substring(l - 1, 1);
                    }

                    if (l == 0)
                        d = "+";
                    else
                        d = str.Substring(l - 1, 1);
                    if (d == "+")
                    {
                        result += TinhTich(str_s2);
                        l--;
                    }
                    if (d == "-")
                    {
                        result -= TinhTich(str_s2);
                        l--;
                    }

                }
            }
            return result;
        }
        public string DaoDau(string str)
        {
            string result = "";
            int i = str.Length - 1;
            while (i >= 0)
            {
                result += str.Substring(i, 1);
                i--;
            }
            return result;
        }
        public string chuoiCongVoiNgoacCoDauTru(string str)
        {
            string result = "";
            int i = 0;

            while (i < str.Length)
            {
                //Xu ly --9
                if (str.Substring(i, 1) == "-" && str.Substring(i + 1, 1) == "-")
                {
                    result += "+";
                    i = i + 2;
                }

                //Xu ly +-9
                if (str.Substring(i, 1) == "+" && str.Substring(i + 1, 1) == "-")
                {
                    result += "-";
                    i = i + 2;
                }
                //Xu ly ++9
                if (str.Substring(i, 1) == "+" && str.Substring(i + 1, 1) == "+")
                {
                    result += "+";
                    i = i + 2;
                }
                else
                {
                    result += str.Substring(i, 1);
                    i++;
                }
            }
            return result;
        }
        public string chuoiNhanVoiNgoacCoDauTru(string str)
        {
            if (str.Substring(0, 1) != "+" && str.Substring(0, 1) != "-")
                str = "+" + str;
            string result = "";
            int i = str.Length - 1;
            while (i >= 0)
            {
                if (str.Substring(i, 1) == "-" && i > 0 && (str.Substring(i - 1, 1) == "*" || str.Substring(i - 1, 1) == "/"))
                {
                    string chuoitam = str.Substring(i - 1, 1);//Lay dau nhan hoac chia
                    int vitridaunhan = i - 1;
                    i = i - 2;//Vuot qua dau tru,nhan
                    //Tim vi tri dau + or -gan nhat
                    // 
                    while ((str.Substring(i, 1) != "+" && str.Substring(i, 1) != "-") && i > 0)
                    {
                        chuoitam += str.Substring(i, 1);
                        i--;
                    }
                    //MessageBox.Show("Vi tri do la  " + i);
                    //Khi gap dau +/-
                    string dau;
                    if (str.Substring(i, 1) == "-")
                        dau = "+";
                    else
                        dau = "-";
                    chuoitam += dau;
                    //Vuot qua dau doi
                    i--;
                    result += chuoitam;

                }
                else
                {

                    result += str.Substring(i, 1);
                    i--;
                }
            }
            return (DaoDau(result));
        }
        public string chinhLaiDau(string str)
        {
            string s1, s2;
            s2 = chuoiCongVoiNgoacCoDauTru(str);
            s1 = chuoiNhanVoiNgoacCoDauTru(s2);
            return s1;
        }
        public string XuLyNgoac(string str, int l)
        {

            string s = "";
            string ketQua = "";
            while (l > 0)
            {

                if (str.Substring(l - 1, 1) == ")")
                {
                    l--;
                    s = XuLyNgoac(str, l);
                    str = s + ketQua;
                    l = str.Length;
                    ketQua = "";
                }
                else
                {

                    if (str.Substring(l - 1, 1) == "(")
                    {
                        return (str.Substring(0, l - 1) + tinhKetQua(chinhLaiDau(ketQua)).ToString());

                    }


                    ketQua = str.Substring(l - 1, 1) + ketQua;
                    l--;
                }
            }

            return chinhLaiDau(ketQua);
        }
        public string XuLyChuoiCoSin(string str)
        {

            string result = "";
            int i = 0;

            while (i < str.Length)
            {
                //Xu ly Sin(9+3)
                string chuoitam = "";
                double sin, s;
                if (str.Substring(i, 1) == "s" && str.Substring(i + 3, 1) == "(")
                {
                    //vuot qua  sin(
                    i = i + 4;
                    int daumongoac = 1;
                    int daudongngoac = 0;
                    while (daumongoac != daudongngoac)
                    {
                        chuoitam += str.Substring(i, 1);

                        if (str.Substring(i, 1) == "(")
                            daumongoac++;
                        if (str.Substring(i, 1) == ")")
                            daudongngoac++;
                        i++;
                    }
                    //Lui lai sau 
                    i--;

                    string u, v;
                    u = XuLyNgoac(chuoitam, chuoitam.Length);
                    v = chinhLaiDau(u);
                    s = tinhKetQua(v);
                    //Doi qua do
                    s = s * Math.PI / 180;


                    //u = double.Parse(s);
                    sin = Math.Sin(s);
                    result += sin.ToString();
                    //vuot qua )
                    i++;
                }
                else
                {
                    result += str.Substring(i, 1);
                    i++;
                }
            }

            return result;
        }
        public string XuLyChuoiCoCos(string str)
        {

            string result = "";
            int i = 0;

            while (i < str.Length)
            {
                //Xu ly Sin(9+3)
                string chuoitam = "";
                double sin, s;
                if (str.Substring(i, 1) == "c" && str.Substring(i + 3, 1) == "(")
                {
                    //vuot qua  sin(
                    i = i + 4;
                    int daumongoac = 1;
                    int daudongngoac = 0;
                    while (daumongoac != daudongngoac)
                    {
                        chuoitam += str.Substring(i, 1);

                        if (str.Substring(i, 1) == "(")
                            daumongoac++;
                        if (str.Substring(i, 1) == ")")
                            daudongngoac++;
                        i++;
                    }
                    //Lui lai sau 
                    i--;

                    string u, v;
                    u = XuLyNgoac(chuoitam, chuoitam.Length);
                    v = chinhLaiDau(u);
                    s = tinhKetQua(v);
                    //Doi qua do
                    s = s * Math.PI / 180;


                    //u = double.Parse(s);
                    sin = Math.Cos(s);
                    result += sin.ToString();
                    //vuot qua )
                    i++;
                }
                else
                {
                    result += str.Substring(i, 1);
                    i++;
                }
            }

            return result;
        }
        public string XuLyChuoiCoTan(string str)
        {

            string result = "";
            int i = 0;

            while (i < str.Length)
            {
                //Xu ly Sin(9+3)
                string chuoitam = "";
                double sin, s;
                if (str.Substring(i, 1) == "t" && str.Substring(i + 3, 1) == "(")
                {
                    //vuot qua  sin(
                    i = i + 4;
                    int daumongoac = 1;
                    int daudongngoac = 0;
                    while (daumongoac != daudongngoac)
                    {
                        chuoitam += str.Substring(i, 1);

                        if (str.Substring(i, 1) == "(")
                            daumongoac++;
                        if (str.Substring(i, 1) == ")")
                            daudongngoac++;
                        i++;
                    }
                    //Lui lai sau 
                    i--;

                    string u, v;
                    u = XuLyNgoac(chuoitam, chuoitam.Length);
                    v = chinhLaiDau(u);
                    s = tinhKetQua(v);
                    //Doi qua do
                    s = s * Math.PI / 180;


                    //u = double.Parse(s);
                    sin = Math.Tan(s);
                    result += sin.ToString();
                    //vuot qua )
                    i++;
                }
                else
                {
                    result += str.Substring(i, 1);
                    i++;
                }
            }

            return result;
        }
        public string XuLyChuoiCoSinCosTan(string str)
        {
            string u, v, result;
            u = XuLyChuoiCoSin(str);
            v = XuLyChuoiCoCos(u);
            result = XuLyChuoiCoTan(v);
            return result;
        }
        public bool KiemTraLoiChuoi(string chuoi)
        {
            string s1;
            string s2;
            if (textBox1.Text == "") return true;
            if (NgoacTrai != NgoacPhai) return true;
            int l = chuoi.Length;
            s1 = chuoi.Substring(l - 1, 1);
            if (s1 == "+" || s1 == "-" || s1 == "/" || s1 == "*") return true;
            for (int i = 0; i < l - 1; i++)
            {

                s1 = chuoi.Substring(i, 1);
                s2 = chuoi.Substring(i + 1, 1);
                if (s1 == "1" || s1 == "2" || s1 == "3" || s1 == "4" || s1 == "5" || s1 == "6" || s1 == "7" || s1 == "8" || s1 == "9" || s1 == "0")
                    if (s2 == "s" || s2 == "c" || s2 == "t") return true;
                if (s1 == ")")
                    if (s2 == "s" || s2 == "c" || s2 == "t") return true;
                if (s1 == "(")
                    if (s2 == ")") return true;
                if (s1 == "/" || s1 == "*" || s1 == "+" || s1 == "-" || s1 == ".")
                    if (s2 == "/" || s2 == "*" || s2 == "+" || s2 == "-" || s2 == ".") return true;
            }

            return false;
        }
        public string XuLyChuoi(string str)
        {
            string u, v, k;
            k = XuLyChuoiCoSinCosTan(str);
            u = XuLyNgoac(k, k.Length);
            v = chinhLaiDau(u);
            return v;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox1.Select();
            SendKeys.Send("{LEFT}");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            textBox1.Select();
            SendKeys.Send("{RIGHT}");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int l = textBox1.Text.Length;
            if (l > 0)
            {
                textBox1.Text = textBox1.Text.Remove(l - 1);
                return;
            }
            ClBang = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
                ClBang = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
                ClBang = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
                ClBang = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
                ClBang = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
                ClBang = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
                ClBang = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
                ClBang = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
                ClBang = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
                ClBang = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
                ClBang = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
            ClBang = false;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            GiaiThua gt = new GiaiThua();
            gt.Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text += "(";
            NgoacTrai += 1;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            textBox1.Text += ")";
            NgoacPhai += 1;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (ClBang == true)
            {
                textBox1.Text = KetQua;
                ClBang = false;
            }
            textBox1.Text += "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (ClBang == true)
            {
                textBox1.Text = KetQua;
                ClBang = false;
            }
            textBox1.Text += "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (ClBang == true)
            {
                textBox1.Text = KetQua;
                ClBang = false;
            }
            textBox1.Text += "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (ClBang == true)
            {
                textBox1.Text = KetQua;
                ClBang = false;
            }
            textBox1.Text += "/";
        }

        private void button36_Click(object sender, EventArgs e)
        {
            textBox1.Text += Math.PI;
            ClBang = false;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (KiemTraLoiChuoi(textBox1.Text) == true)
            {
                textBox2.Text = "Error";
                return;
            }
            else
            {
                textBox2.Text = tinhKetQua(XuLyChuoi(textBox1.Text)).ToString();
                KetQua = textBox2.Text;
                ClBang = true;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Logarit lg = new Logarit();
            lg.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Logarit lg = new Logarit();
            lg.Show();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            KhaiCan kc = new KhaiCan();
            kc.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            KhaiCan kc = new KhaiCan();
            kc.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Logarit lg = new Logarit();
            lg.Show();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            LuongGiac lg = new LuongGiac();
            lg.Show();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            LuongGiac lg = new LuongGiac();
            lg.Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            LuongGiac lg = new LuongGiac();
            lg.Show();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            LuongGiac lg = new LuongGiac();
            lg.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            LuyThua lt = new LuyThua();
            lt.Show();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            PTB2 pt2 = new PTB2();
            pt2.Show();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            PTB1A2 pt12 = new PTB1A2();
            pt12.Show();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            PTB1A3 pt13 = new PTB1A3();
            pt13.Show();
        }
    }
}
