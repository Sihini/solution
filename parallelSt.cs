using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace solution
{
    public partial class parallelSt : Form
    {
        public parallelSt()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FIL467M;Initial Catalog=ITPMSOLUTION;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            int inserted = 0;
            foreach (DataGridViewRow dr in parallelGridView.Rows)
            {
                bool isSelected = Convert.ToBoolean(dr.Cells["checkBoxColumn"].Value);

                if (isSelected)
                {

                    string sqlquery = "SET IDENTITY_INSERT ParallelSt ON; INSERT INTO ParallelSt (pid,lecture_1,lecture_2,subject_code,subject_name,group_id,tag_name) values (@pid,@lecture_1,@lecture_2,@subject_code,@subject_name,@group_id,@tag_name) SET IDENTITY_INSERT ConsecutiveSt OFF;";
                    SqlCommand sqlcomm = new SqlCommand(sqlquery, con);
                    sqlcomm.Parameters.AddWithValue("@pid", dr.Cells["s_id"].Value);
                    sqlcomm.Parameters.AddWithValue("@lecture_1", dr.Cells["s_lecturer"].Value);
                    sqlcomm.Parameters.AddWithValue("@lecture_2", dr.Cells["ss_lecturer"].Value);
                    sqlcomm.Parameters.AddWithValue("@subject_code", dr.Cells["sub_name"].Value);
                    sqlcomm.Parameters.AddWithValue("@subject_name", dr.Cells["s_group"].Value);
                    sqlcomm.Parameters.AddWithValue("@group_id", dr.Cells["sub_code"].Value); 
                    sqlcomm.Parameters.AddWithValue("@tag_name", dr.Cells["s_Tag"].Value);
                    con.Open();
                    sqlcomm.ExecuteNonQuery();
                    con.Close();
                }
                inserted++;
            }
            if (inserted > 0) { MessageBox.Show(string.Format("records inserted.", inserted), "Message"); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void parallelSt_Load(object sender, EventArgs e)
        {
            //GetParalleldataview();
            SqlCommand cmd = new SqlCommand("Select * from SessionTable ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            parallelGridView.DataSource = dt;

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Width = 30;
            checkBoxColumn.Name = "checkBoxColumn";
            parallelGridView.Columns.Insert(0, checkBoxColumn);
        }

        private void GetParalleldataview()
        {

        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.None;
            parallelView.Controls.Add(childForm);
            parallelView.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new parallelView());
        }
    }
}
