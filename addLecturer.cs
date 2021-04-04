using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace solution
{
    public partial class addLecturer : Form
    {
        public addLecturer()
        {
            InitializeComponent();
        }
      
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-58O0VLLG;Initial Catalog=ITPMSOLUTION;Integrated Security=True");
        private void addLecturer_Load(object sender, EventArgs e)
        {
            GetLecturerRecord();
        }

        private void GetLecturerRecord()
        {


            SqlCommand cmd = new SqlCommand("Select * from LectureTable ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO LectureTable VALUES (@Lecturname, @empID, @faculy, @Department, @center, @building, @level, @rank)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Lecturname", txtlecname.Text);
                cmd.Parameters.AddWithValue("@empID", txtEmpid.Text);
                cmd.Parameters.AddWithValue("@faculy", txtFacu.Text);
                cmd.Parameters.AddWithValue("@Department", txtDepname.Text);
                cmd.Parameters.AddWithValue("@center", txtcent.Text);
                cmd.Parameters.AddWithValue("@building", txtbulin.Text);
                cmd.Parameters.AddWithValue("@level", txtlevel.Text);
                cmd.Parameters.AddWithValue("@rank", txtrank.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Lecturer is Successfully saved in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //   GetStudentsRecord();
                ClearFormLect();


            }
            mangeLecturer frm = new mangeLecturer();//open Attendance management form
            frm.Show();

        }
        private bool IsValid()
        {
            if (txtlecname.Text == String.Empty)
            {
                MessageBox.Show("Lecturer nam is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtEmpid.Text == string.Empty)
            {
                MessageBox.Show("Employee ID is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (txtFacu.Text == string.Empty)
            {
                MessageBox.Show("Faculty Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (txtDepname.Text == string.Empty)
            {
                MessageBox.Show("Department Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtcent.Text == string.Empty)
            {
                MessageBox.Show("Center Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtbulin.Text == string.Empty)
            {
                MessageBox.Show("Building Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtlevel.Text == string.Empty)
            {
                MessageBox.Show("Level is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtrank.Text == string.Empty)
            {
                MessageBox.Show("Rank  is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;


        }

       //  this.button1.Click += new System.EventHandler(this.button1_Click);

        private void clearbtnlec_Click(object sender, EventArgs e)
        {
            ClearFormLect();

        }

        private void ClearFormLect()
        {
            txtlecname.Clear();
            txtEmpid.Clear();
            txtDepname.Clear();
            txtrank.Clear();

            //cpmbo box clear
            txtFacu.SelectedIndex = -1;
            txtcent.SelectedIndex = -1;
            txtbulin.SelectedIndex = -1;
            txtlevel.SelectedIndex = -1;

            txtlecname.Focus();
            
        }
    }
}
