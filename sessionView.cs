using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace solution
{
    public partial class sessionView : Form
    {
        public sessionView()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-58O0VLLG;Initial Catalog=ITPMSOLUTION;Integrated Security=True");

        private void sessionviewdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sessionView_Load(object sender, EventArgs e)
        {
            GetSessiondataview();
        }
        private void GetSessiondataview()
        {

            SqlCommand cmd = new SqlCommand("Select * from SessionTable ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            sessionviewdataGridView.DataSource = dt;

        }

        private void exportsessionbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
