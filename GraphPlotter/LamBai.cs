using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VietGraph
{
    public partial class LamBai : Form
    {
        public LamBai()
        {
            InitializeComponent();
            
        }
        private void LamBai_Load(object sender, EventArgs e)
        {
          
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BTToan bt1 = new BTToan();
            bt1.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BTAnhVan bt2 = new BTAnhVan();
            bt2.Show();
         
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BTVatLy bt3 = new BTVatLy();
            bt3.Show();
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BTHoaHoc bt4 = new BTHoaHoc();
            bt4.Show();
      
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BTSinhHoc bt5 = new BTSinhHoc();
            bt5.Show();
   
        }
    }
}
