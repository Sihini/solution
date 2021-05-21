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


        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.None;
            timeAllocationsubpannel.Controls.Add(childForm);
            timeAllocationsubpannel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }



        public SessionTimeAllocation1()
        {
            InitializeComponent();
         /*   fillsesiontimeallo();
            fillsesiontimeGroupid();
            fillsesioniD();*/

        }
        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-EB5SPN9;Initial Catalog=ITPMSOLUTION;Integrated Security=True;Connect Timeout=30");
       


        private void SessionTimeAllocation1_Load(object sender, EventArgs e)
        {

        }
/*
        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO STnotAvailable VALUES (@selec_lec, @selec_group, @selec_sub, @selec_ID, @sele_time)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@selec_lec", lecturerComboBox.Text);
                cmd.Parameters.AddWithValue("@selec_group", groupComboBox.Text);
                cmd.Parameters.AddWithValue("@selec_sub", subgroupComboBox.Text);
                cmd.Parameters.AddWithValue("@selec_ID", sessionComboBox.Text);
                cmd.Parameters.AddWithValue("@sele_time", timeTextBox.Text);
              

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Lecturer is Successfully saved in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //   GetStudentsRecord();
               // ClearFormLect();


            }
            //  openChildForm(new selectLandgroup());
        }
*/
   /*     private bool IsValid()
        {
            if (lecturerComboBox.Text == String.Empty)
            {
                MessageBox.Show("selected lecturer", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (groupComboBox.Text == string.Empty)
            {
                MessageBox.Show("Employee ID is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (subgroupComboBox.Text == string.Empty)
            {
                MessageBox.Show("Faculty Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (sessionComboBox.Text == string.Empty)
            {
                MessageBox.Show("Department Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (timeTextBox.Text == string.Empty)
            {
                MessageBox.Show("Center Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
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
                    lecturerComboBox.Items.Add(sname);


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


        public void fillsesiontimeGroupid()
        {
            
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
                    subgroupComboBox.Items.Add(sname);


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
                    sessionComboBox.Items.Add(sname);


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        
        private void stNotAvailableSubmitbtn_Click(object sender, EventArgs e)
        {

        }
*/
       

        private void stConsecutivebtn_Click(object sender, EventArgs e)
        {
            //  openChildForm(new  consecutiveSt());
        }

        private void stParallelbtn_Click(object sender, EventArgs e)
        {

        }

        private void stNonOverlappingbtn_Click(object sender, EventArgs e)
        {

        }

        private void stNotAvailablebtn_Click(object sender, EventArgs e)
        {
            //openChildForm(new SessionTimeAllocation1());
        }

        private void stNotAvailablebtn_Click_1(object sender, EventArgs e)
        {
            openChildForm(new NotTimeAvailable1());
        }

        private void timeAllocationsubpannel_Paint(object sender, PaintEventArgs e)
        {

        }


        /*
                private void groupComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
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
                            groupComboBox.Items.Add(sname);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }*/
    }
}
