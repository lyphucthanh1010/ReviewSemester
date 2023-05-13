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
    public partial class BTAnhVan : Form
    {
        public BTAnhVan()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel2.LinkVisited = true;
                System.Diagnostics.Process.Start("https://drive.google.com/drive/folders/1cvJ4M10cgBxln5PkQq-roCFRRjljcrKr?usp=share_link");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở được link đã mở");
            }
        }
    }
}
