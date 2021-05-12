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
    public partial class managesessionnew : Form
    {
        public managesessionnew()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-58O0VLLG;Initial Catalog=ITPMSOLUTION;Integrated Security=True");
        public int s_id;
        int count = 0;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void selectsession_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



            SqlCommand cmd = new SqlCommand("Select * from SessionTable ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            s_id = Convert.ToInt32(selectsession.SelectedRows[0].Cells[0].Value);
            selectLecturer.Text = selectsession.SelectedRows[0].Cells[1].Value.ToString();
            selettextlect.Text = selectsession.SelectedRows[0].Cells[2].Value.ToString();
            selecttags.Text = selectsession.SelectedRows[0].Cells[3].Value.ToString();
            selectgroup.Text = selectsession.SelectedRows[0].Cells[4].Value.ToString();
            selectsubject.Text = selectsession.SelectedRows[0].Cells[5].Value.ToString();
            sybjectname.Text = selectsession.SelectedRows[0].Cells[6].Value.ToString();
            noofstudent.Text = selectsession.SelectedRows[0].Cells[7].Value.ToString();
            duration.Text = selectsession.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void managesessionnew_Load(object sender, EventArgs e)
        {
            GetSessiondata();
        }

        private void GetSessiondata()
        {

            SqlCommand cmd = new SqlCommand("Select * from SessionTable ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            selectsession.DataSource = dt;

        }

        private void selectupdate_Click(object sender, EventArgs e)
        {

            if (s_id > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE SessionTable SET  s_lecturer=@s_lecturer,ss_lecturer= @ss_lecturer,s_Tag= @s_Tag,s_group= @s_group,sub_code= @sub_code,sub_name= @sub_name,noofstudent= @noofstudent,duration= @duration WHERE s_id =@ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@s_lecturer", selectLecturer.Text);
                cmd.Parameters.AddWithValue("@ss_lecturer", selettextlect.Text);
                cmd.Parameters.AddWithValue("@s_Tag", selecttags.Text);
                cmd.Parameters.AddWithValue("@s_group", selectgroup.Text);
                cmd.Parameters.AddWithValue("@sub_code", selectsubject.Text);
                cmd.Parameters.AddWithValue("@sub_name", sybjectname.Text);
                cmd.Parameters.AddWithValue("@noofstudent", noofstudent.Text);
                cmd.Parameters.AddWithValue("@duration", duration.Text);
                cmd.Parameters.AddWithValue("@ID", this.s_id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Lecturer is Successfully Updated the database", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetSessiondata();
              //  clearManageLectrerdetails();
            }
            else
            {
                MessageBox.Show("Please select an Lecturer to update his information", "Select ?", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void selectdelete_Click(object sender, EventArgs e)
        {

            if (s_id > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM SessionTable WHERE s_id =@ID", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@ID", this.s_id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Lecturer is Deleted from this System", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetSessiondata();
                //   clearManageLectrerdetails();

            }
            else
            {
                MessageBox.Show("Please select an Lecturer to update his information", "Select ?", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
