using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace solution
{
    public partial class mangeLecturer : Form
    {
        public mangeLecturer()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-58O0VLLG;Initial Catalog=ITPMSOLUTION;Integrated Security=True");
        public int LecturerID;
        int count = 0;

        public string gid { get; set; }
        public string mid { get; set; }

        public string rid { get; set; }


        private void LectrerMandataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {





            SqlCommand cmd = new SqlCommand("Select * from LectureTable ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            LecturerID = Convert.ToInt32(LectrerMandataGridView.SelectedRows[0].Cells[0].Value);
            txtlecname.Text = LectrerMandataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtEmpid.Text = LectrerMandataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtFacu.Text = LectrerMandataGridView.SelectedRows[0].Cells[3].Value.ToString();
            txtDepname.Text = LectrerMandataGridView.SelectedRows[0].Cells[4].Value.ToString();
            txtcent.Text = LectrerMandataGridView.SelectedRows[0].Cells[5].Value.ToString();
            txtbulin.Text = LectrerMandataGridView.SelectedRows[0].Cells[6].Value.ToString();
            txtlevel.Text = LectrerMandataGridView.SelectedRows[0].Cells[7].Value.ToString();
            txtrank.Text = LectrerMandataGridView.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void mangeLecturer_Load(object sender, EventArgs e)
        {
            GetLecturerdata();
          
        }

        private void GetLecturerdata()
        {

            SqlCommand cmd = new SqlCommand("Select * from LectureTable ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            LectrerMandataGridView.DataSource = dt;

        }

     //   private void button1_Click(object sender, EventArgs e)
       // {


         //   if (IsValid())
           // {
             //   SqlCommand cmd = new SqlCommand("INSERT INTO LectureTable VALUES (@Lecturname, @empID, @faculy, @Department, @center, @building, @level, @rank)", con);


               // con.Open();
                //cmd.ExecuteNonQuery();
               // con.Close();

             //   MessageBox.Show("New Lecturer is Successfully saved in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //GetLecturerdata();

       //     }
       // }
        private bool IsValid()
        {
            return true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand();


                con.Open();
                //cmd.ExecuteNonQuery();
                con.Close();

                //   MessageBox.Show("New Lecturer is Successfully saved in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetLecturerdata();
               

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearManageLectrerdetails();

        }

        private void clearManageLectrerdetails()
        {
            LecturerID = 0;
            txtlecname.Clear();
            txtEmpid.Clear();
            txtDepname.Clear();
            txtrank.Clear();

            //clearing combo box
            txtFacu.SelectedIndex = -1;
            txtcent.SelectedIndex = -1;
            txtbulin.SelectedIndex = -1;
            txtlevel.SelectedIndex = -1;


            txtlecname.Focus();
        }

        private void managelectupdatbtn_Click(object sender, EventArgs e)
        {

            if(LecturerID >0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE LectureTable SET  LecturerName=@Lecturname,EmployeeID= @empID,Faculty= @faculy,Department= @Department,Center= @center,Building= @building,Levels= @level,Rank= @rank WHERE LecturerId =@ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Lecturname", txtlecname.Text);
                cmd.Parameters.AddWithValue("@empID", txtEmpid.Text);
                cmd.Parameters.AddWithValue("@faculy", txtFacu.Text);
                cmd.Parameters.AddWithValue("@Department", txtDepname.Text);
                cmd.Parameters.AddWithValue("@center", txtcent.Text);
                cmd.Parameters.AddWithValue("@building", txtbulin.Text);
                cmd.Parameters.AddWithValue("@level", txtlevel.Text);
                cmd.Parameters.AddWithValue("@rank", txtrank.Text);
                cmd.Parameters.AddWithValue("@ID", this.LecturerID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Lecturer is Successfully Updated the database", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetLecturerdata();
                clearManageLectrerdetails();
            }
            else
            {
                MessageBox.Show("Please select an Lecturer to update his information", "Select ?", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void lectManageDeleteBtn_Click(object sender, EventArgs e)
        {

            if(LecturerID > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM LectureTable WHERE LecturerId =@ID", con);
                cmd.CommandType = CommandType.Text;
             
                cmd.Parameters.AddWithValue("@ID", this.LecturerID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Lecturer is Deleted from this System", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetLecturerdata();
                clearManageLectrerdetails();

            }
            else
            {
                MessageBox.Show("Please select an Lecturer to update his information", "Select ?", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }


        private void txtserachmangelec_TextChanged(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM LectureTable where LecturerName like'"+txtserachmangelec.Text + "%' OR EmployeeID LIKE'"+txtserachmangelec.Text+ "%' OR Faculty LIKE'"+txtserachmangelec.Text+ "%' OR Department LIKE'"+txtserachmangelec.Text+ "%' OR Center LIKE '"+txtserachmangelec.Text+ "%' OR Building LIKE '"+txtserachmangelec.Text+ "%' OR Levels LIKE '"+txtserachmangelec.Text+ "%' OR Rank LIKE '"+txtserachmangelec.Text+"%' ", con );
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            LectrerMandataGridView.DataSource = dt;


        }

        private void serachmanagelectBtn_Click(object sender, EventArgs e)
        {
           /* count = 0;
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from LectureTable where LecturerName='" + txtserachmangelec + "'OR EmployeeID ='" + txtserachmangelec + "'OR  Faculty ='" + txtserachmangelec + "' ";

            con.Open();

           
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            con.Close();

            LectrerMandataGridView.DataSource = dt;

            if (count == 0)
            {
                MessageBox.Show("record not found");
            }*/
        }


        private void button2_Click_1(object sender, EventArgs e)
        {

            gid = (string)txtEmpid.Text;
            mid = (string)txtlevel.Text;


            rid = mid + "." + gid;
            txtrank.Text = (rid);

        }

        private void txtlecname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}