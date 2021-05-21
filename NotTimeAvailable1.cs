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
    public partial class NotTimeAvailable1 : Form
    {
        public NotTimeAvailable1()
        {
            InitializeComponent();
            fillcomboxselectlecturer();
            fillcomboxselectgroup();
            fillcomboxselectsubgroup();
            fillcomboxselectsession();
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
            notAvailableTimepanel1.Controls.Add(childForm);
            notAvailableTimepanel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        public void fillcomboxselectlecturer()
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
                    string lecname = myreader.GetString(1);
                    lecturerComboBox.Items.Add(lecname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void fillcomboxselectgroup()
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
                    string groupid = myreader.GetString(3);
                    groupComboBox.Items.Add(groupid);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void fillcomboxselectsubgroup()
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
                    string subgrp = myreader.GetString(4);
                    subgroupComboBox.Items.Add(subgrp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void fillcomboxselectsession()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-EB5SPN9;Initial Catalog=ITPMSOLUTION;Integrated Security=True;Connect Timeout=30");
            string sql = "SELECT s_id from SessionTable ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    int sid = myreader.GetInt32(myreader.GetOrdinal("s_id"));
                    sessionComboBox.Items.Add(sid);


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }



        private void lecturerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void groupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void subgroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void sessionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void timeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void stNotAvailableSubmitbtn_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-EB5SPN9;Initial Catalog=ITPMSOLUTION;Integrated Security=True;Connect Timeout=30");
                SqlCommand cmd = new SqlCommand("INSERT INTO STnotAvailable VALUES (@selec_lec, @selec_group, @selec_sub, @selec_ID, @selec_time)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@selec_lec", lecturerComboBox.Text);
                cmd.Parameters.AddWithValue("@selec_group", groupComboBox.Text);
                cmd.Parameters.AddWithValue("@selec_sub", subgroupComboBox.Text);
                cmd.Parameters.AddWithValue("@selec_ID", sessionComboBox.Text);
                cmd.Parameters.AddWithValue("@selec_time", timeTextBox.Text);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Lecturer is Successfully saved in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                openChildForm(new NotTimeAvailable2());
                //   GetStudentsRecord();
                // ClearFormLect();


            }
            //  openChildForm(new selectLandgroup());
        }

        private bool IsValid()
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


        private void stNotAvailableViewbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new NotTimeAvailable2());
        }

        private void stNotAvailableClearbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
