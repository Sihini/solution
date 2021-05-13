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
    public partial class SessionTimeAllocation1 : Form
    {
        public SessionTimeAllocation1()
        {
            InitializeComponent();
            fillsesiontimeallo();
            fillsesiontimeGroupid();
            fillsesioniD();

        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EB5SPN9;Initial Catalog=ITPMSOLUTION;Integrated Security=True;Connect Timeout=30");
        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.None;
            sessionavalibale.Controls.Add(childForm);
            sessionavalibale.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void SessionTimeAllocation1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO STnotAvailable VALUES (@selec_lec, @selec_group, @selec_sub, @selec_ID, @sele_time)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@selec_lec", selectLecturersession.Text);
                cmd.Parameters.AddWithValue("@selec_group", selectgroupsession.Text);
                cmd.Parameters.AddWithValue("@selec_sub", selectGroupsubsesesion.Text);
                cmd.Parameters.AddWithValue("@selec_ID", selectsessionID.Text);
                cmd.Parameters.AddWithValue("@sele_time", timesessionnot.Text);
              

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Lecturer is Successfully saved in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //   GetStudentsRecord();
               // ClearFormLect();


            }
            //  openChildForm(new selectLandgroup());
        }

        private bool IsValid()
        {
            if (selectLecturersession.Text == String.Empty)
            {
                MessageBox.Show("selected lecturer", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (selectgroupsession.Text == string.Empty)
            {
                MessageBox.Show("Employee ID is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (selectGroupsubsesesion.Text == string.Empty)
            {
                MessageBox.Show("Faculty Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (selectsessionID.Text == string.Empty)
            {
                MessageBox.Show("Department Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (timesessionnot.Text == string.Empty)
            {
                MessageBox.Show("Center Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new SessionTimeAllocation2());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
          //  openChildForm(new  consecutiveSt());
        }

        private void selectLecturersession_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void fillsesiontimeallo()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-EB5SPN9;Initial Catalog=ITPMSOLUTION;Integrated Security=True;Connect Timeout=30");
            string sql = "SELECT * from StudentTable ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(1);
                    selectLecturersession.Items.Add(sname);


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


        public void fillsesiontimeGroupid()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-EB5SPN9;Initial Catalog=ITPMSOLUTION;Integrated Security=True;Connect Timeout=30");
            string sql = "SELECT * from StudentTable ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(3);
                    selectgroupsession.Items.Add(sname);


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


        public void fillsesiontimeGroupsub()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-EB5SPN9;Initial Catalog=ITPMSOLUTION;Integrated Security=True;Connect Timeout=30");
            string sql = "SELECT * from LectureTable ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(4);
                    selectGroupsubsesesion.Items.Add(sname);


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }



        public void fillsesioniD()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-EB5SPN9;Initial Catalog=ITPMSOLUTION;Integrated Security=True;Connect Timeout=30");
            string sql = "SELECT * from SessionTable ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(1);
                    selectsessionID.Items.Add(sname);


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void selectGroupsesion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
