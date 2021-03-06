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
    public partial class selectLandgroup : Form
    {
        public selectLandgroup()
        {
            InitializeComponent();
            fillcombox();
            fillselectsubject();
        }


        SqlConnection con = new SqlConnection("Data Source=LAPTOP-58O0VLLG;Initial Catalog=ITPMSOLUTION;Integrated Security=True");

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.None;
            groupSubject.Controls.Add(childForm);
            groupSubject.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void selectsubject_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-58O0VLLG;Initial Catalog=ITPMSOLUTION;Integrated Security=True");
            string sql = "SELECT * from SubjectTable where SubjectCode ='"+ selectsubject.Text +"';";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(3);
                    sybjectname.Text = sname;


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public void fillcombox()
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-58O0VLLG;Initial Catalog=ITPMSOLUTION;Integrated Security=True");
            string sql = "SELECT * from StudentTable ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(5);
                    selectgroup.Items.Add(sname);


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        public void fillselectsubject()
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-58O0VLLG;Initial Catalog=ITPMSOLUTION;Integrated Security=True");
            string sql = "SELECT * from SubjectTable ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string suject = myreader.GetString(4);
                    selectsubject.Items.Add(suject);
                }
                con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            /*selectsubject.SelectedValue = ("@sub",selectsubject.Text);
            string sql1 = "SELECT SubjectName from SubjectTable WHERE SubjectCode=@sub";
            SqlCommand cmdd = new SqlCommand(sql1, con);
            con.Open();
            SqlDataReader myreadeer = cmdd.ExecuteReader();
            if (myreadeer.Read())
            {
                
                sybjectname.Text = (myreadeer["SubjectName"].ToString());
            }
            con.Close();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            openChildForm(new sessionadd());
        }

        private void addnext_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("UPDATE SessionTable SET  s_group=@s_group,sub_code= @sub_code,sub_name= @sub_name,noofstudent= @noofstudent,duration= @duration where s_id=(select TOP(1) s_id FROM SessionTable ORDER BY s_id DESC)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@s_group", selectgroup.Text);
                cmd.Parameters.AddWithValue("@sub_code", selectsubject.Text);
                cmd.Parameters.AddWithValue("@sub_name", sybjectname.Text);
                cmd.Parameters.AddWithValue("@noofstudent", noofstudent.Text);
                cmd.Parameters.AddWithValue("@duration", duration.Text);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();



                MessageBox.Show(" Successfully Inserted in the database", "INSERT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFormLect();
            }

           
        }

        private bool IsValid()
        {
            if (selectgroup.Text == String.Empty)
            {
                MessageBox.Show("Selecetd Group is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (selectsubject.Text == string.Empty)
            {
                MessageBox.Show("Selecetd Subject code is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (sybjectname.Text == string.Empty)
            {
                MessageBox.Show("Selected Subeject Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (noofstudent.Text == string.Empty)
            {
                MessageBox.Show("No Of student is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (duration.Text == string.Empty)
            {
                MessageBox.Show(" Duration  is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }

        private void selectLandgroup_Load(object sender, EventArgs e)
        {

        }

        private void groupSubject_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sybjectname_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectgroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearbtnsession_Click(object sender, EventArgs e)
        {
            ClearFormLect();
        }

        private void ClearFormLect()
        {

            noofstudent.Clear();
            duration.Clear();
            sybjectname.Clear();

            //cpmbo box clear
            selectgroup.SelectedIndex = -1;
            selectsubject.SelectedIndex = -1;


            noofstudent.Focus();

        }
    }
}
