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
    public partial class Introduction : Form
    {
        public Introduction()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Choose cs = new Choose();
                cs.Show();
                this.Visible = false;
        }
    }
}
