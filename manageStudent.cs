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
    public partial class manageStudent : Form
    {
        public manageStudent()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3CRQS4E;Initial Catalog=ITPMSOLUTION;Integrated Security=True");
        public int sid;
        int count = 0;
        public string gid { get; set; }
        public string mid { get; set; }
        public string qid { get; set; }
        public string rid { get; set; }

        public string zid { get; set; }
        public string zidr { get; set; }


        private bool IsValid()
        {
            return true;
        }

        private void clearManageStudentdetails()
        {
            sid = 0;
            a_year.Clear();
            sub_gid.Clear();
            g_id.Clear();
            programme.SelectedIndex = -1;
            g_no.Value = 1;
            sub_gno.Value = 1;


            a_year.Focus();
        }


       

        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from StudentTable ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            sid = Convert.ToInt32(StudentdataGridView.SelectedRows[0].Cells[0].Value);
            a_year.Text = StudentdataGridView.SelectedRows[0].Cells[1].Value.ToString();
            programme.Text = StudentdataGridView.SelectedRows[0].Cells[2].Value.ToString();
            g_no.Text = StudentdataGridView.SelectedRows[0].Cells[3].Value.ToString();
            sub_gno.Text = StudentdataGridView.SelectedRows[0].Cells[4].Value.ToString();
            g_id.Text = StudentdataGridView.SelectedRows[0].Cells[5].Value.ToString();
            sub_gid.Text = StudentdataGridView.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();


                    con.Open();
                    //cmd.ExecuteNonQuery();
                    con.Close();

                    //   MessageBox.Show("New Lecturer is Successfully saved in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GETManageStudent();
                }
                catch(Exception er)
                {
                    Console.WriteLine(er.Message);
                }

            }
        }

        private void clearBtnStdMan_Click(object sender, EventArgs e)
        {
            clearManageStudentdetails();
        }

        private void UpdateBtnStd_Click(object sender, EventArgs e)
        {
            if (sid > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE StudentTable SET a_year_sem=@a_year_sem,program=@program,g_no=@g_no,sub_gno=@sub_gno,g_id=@g_id,sub_gid=@sub_gid WHERE sid =@sid", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@a_year_sem", a_year.Text);
                cmd.Parameters.AddWithValue("@program", programme.Text);
                cmd.Parameters.AddWithValue("@g_no", g_no.Text);
                cmd.Parameters.AddWithValue("@sub_gno", sub_gno.Text);
                cmd.Parameters.AddWithValue("@g_id", g_id.Text);
                cmd.Parameters.AddWithValue("@sub_gid", sub_gid.Text);
                cmd.Parameters.AddWithValue("@sid", this.sid);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Student is Successfully Updated the database", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GETManageStudent();
               
                clearManageStudentdetails();
            }
            else
            {
                MessageBox.Show("Please select an Student to update his information", "Select ?", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void DeleteBtnStd_Click(object sender, EventArgs e)
        {
            if (sid > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM StudentTable WHERE sid =@sid", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@sid", this.sid);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Student is Deleted from this System", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GETManageStudent();
                
                clearManageStudentdetails();

            }
            else
            {
                MessageBox.Show("Please select an Student to update his information", "Select ?", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void textSearchBtn_TextChanged(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM StudentTable where program like'" + textSearchBtn.Text + "%' OR a_year_sem LIKE'" + textSearchBtn.Text + "%' OR g_no LIKE'" + textSearchBtn.Text + "%' OR sub_gno LIKE'" + textSearchBtn.Text + "%' OR g_id LIKE '" + textSearchBtn.Text + "%' OR sub_gid LIKE '" + textSearchBtn.Text + "% '", con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            StudentdataGridView.DataSource = dt;
        }

        private void SearchBtnStd_Click(object sender, EventArgs e)
        {
           
        }

        private void manageStudent_Load_1(object sender, EventArgs e)
        {
            GETManageStudent();
        }

        private void GETManageStudent()
        {

            SqlCommand cmd = new SqlCommand("Select * from StudentTable ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr1 = cmd.ExecuteReader();
            dt.Load(sdr1);
            con.Close();

            StudentdataGridView.DataSource = dt;
        }

        private void stdGenId_Click(object sender, EventArgs e)
        {

            gid = (string)a_year.Text;
            mid = (string)programme.Text;
            qid = (string)g_no.Text;
            rid = (string)sub_gno.Text;

            zid = gid + "." + mid + "." + qid;
            g_id.Text = (zid);
            zidr = gid + "." + mid + "." + qid + "." + rid;
            sub_gid.Text = (zidr);
        }
    }
}
