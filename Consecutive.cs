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

  
    public partial class Consecutive : Form
    {

        private Form activeForm = null;
        private void openChildForm2(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.None;
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3CRQS4E;Initial Catalog=ITPMSOLUTION;Integrated Security=True");
        public Consecutive()
        {
            InitializeComponent();
            fillcomboxroomsMS();
        }
        private void Consecutive_Load(object sender, EventArgs e)
        {
            GetConsecutiveData();
        }
        private void GetConsecutiveData()
        {
            SqlCommand cmd = new SqlCommand("Select * from ConsecutiveSt ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr1 = cmd.ExecuteReader();
            dt.Load(sdr1);
            con.Close();

            MSRGrid2.DataSource = dt;
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Width = 30;
            checkBoxColumn.Name = "checkBoxColumn";
            MSRGrid2.Columns.Insert(0, checkBoxColumn);

        }

        public void fillcomboxroomsMS()
        {
             SqlConnection con = new SqlConnection("Data Source=DESKTOP-3CRQS4E;Initial Catalog=ITPMSOLUTION;Integrated Security=True");
              string sql = "SELECT * from LocationTable";
              SqlCommand cmd = new SqlCommand(sql, con);
              SqlDataReader myreader;
              try
              {
                  con.Open();
                  myreader = cmd.ExecuteReader();
                  while (myreader.Read())
                  {
                      string sname = myreader.GetString(2);
                      selectroomMS.Items.Add(sname);


                  }

              }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.Message);

              }
         
        }


        private void btnsaveMSR_Click(object sender, EventArgs e)
        {
            int inserted = 0;
              foreach (DataGridViewRow dr in MSRGrid2.Rows)
            {
                  bool isSelected = Convert.ToBoolean(dr.Cells["checkBoxColumn"].Value);

                    if (isSelected)
                {

                    string sqlquery = "SET IDENTITY_INSERT ConsecutiveSRT ON; INSERT INTO ConsecutiveSRT (cr_id,lec_1,lec_2,sub_code,sub_name,gr_id,rtag_name,croom_name) values (@cr_id,@lec_1,@lec_2,@sub_code,@sub_name,@gr_id,@rtag_name,@croom_name) SET IDENTITY_INSERT ConsecutiveSRT OFF;";
                    SqlCommand sqlcomm = new SqlCommand(sqlquery, con);
                     sqlcomm.Parameters.AddWithValue("@cr_id", dr.Cells["cid"].Value);
                      sqlcomm.Parameters.AddWithValue("@lec_1", dr.Cells["lecture_1"].Value);
                      sqlcomm.Parameters.AddWithValue("@lec_2", dr.Cells["lecture_2"].Value);
                      sqlcomm.Parameters.AddWithValue("@sub_code", dr.Cells["subject_code"].Value);
                       sqlcomm.Parameters.AddWithValue("@sub_name", dr.Cells["subject_name"].Value);
                      sqlcomm.Parameters.AddWithValue("@gr_id", dr.Cells["group_id"].Value);
                      sqlcomm.Parameters.AddWithValue("@rtag_name", dr.Cells["tag_name"].Value);
                      sqlcomm.Parameters.AddWithValue("@croom_name", selectroomMS.Text);
                    con.Open();
                    sqlcomm.ExecuteNonQuery();
                    con.Close();
                }
                inserted++;
            }
            if (inserted > 0) { MessageBox.Show(string.Format("records inserted.", inserted), "Message"); }
            {

            }

            openChildForm2(new ManageSessionRoomConsecutive());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm2(new ManageSessionRoomNext());
        }
    }
}
