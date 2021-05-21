using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace solution
{
    public partial class loadingpage : Form
    {
        public loadingpage()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            propanel.Width += 3;

            if(propanel.Width >=1028)
            {
                timer1.Stop();
                AddWorkingDays fm2 = new AddWorkingDays();
                fm2.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
