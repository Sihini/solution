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
            filltagcombox();
            fillcombox();
            fillcomboxes();
            fillselectsubject();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-58O0VLLG;Initial Catalog=ITPMSOLUTION;Integrated Security=True");
        public int s_id;
        int count = 0;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
                ClearFormmanagesessin();
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
                ClearFormmanagesessin();
               

            }
            else
            {
                MessageBox.Show("Please select an Lecturer to update his information", "Select ?", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void selectLecturer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public void filltagcombox()
        {
            SqlConnection cons = new SqlConnection("Data Source=LAPTOP-58O0VLLG;Initial Catalog=ITPMSOLUTION;Integrated Security=True");
            string sqli = "SELECT * from TagTable ";
            SqlCommand cmds = new SqlCommand(sqli, cons);
            SqlDataReader myreaders;
            try
            {
                cons.Open();
                myreaders = cmds.ExecuteReader();
                while (myreaders.Read())
                {
                    string stag = myreaders.GetString(3);
                    selecttags.Items.Add(stag);


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
            string sql = "SELECT * from LectureTable ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(1);
                    selectLecturer.Items.Add(sname);


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void selectgroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void fillcomboxes()
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

        private void sybjectname_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectsubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-58O0VLLG;Initial Catalog=ITPMSOLUTION;Integrated Security=True");
            string sql = "SELECT * from SubjectTable where SubjectCode ='" + selectsubject.Text + "';";
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

        private void selectclear_Click(object sender, EventArgs e)
        {
            ClearFormmanagesessin();
        }
        private void ClearFormmanagesessin()
        {
            selectsubject.SelectedIndex = -1;
            noofstudent.Clear();
            duration.Clear();
            selectsubject.SelectedIndex = -1;

            sybjectname.Clear();


           // selectsubject.SelectedIndex = -1;
            selettextlect.Clear();

            //cpmbo box clear
            selectLecturer.SelectedIndex = -1;
            selecttags.SelectedIndex = -1;


           // selettextlect.Focus();

            //cpmbo box clear
            selectgroup.SelectedIndex = -1;



            selettextlect.Focus();

        }

        private void selectlecgropsear_TextChanged(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM SessionTable where s_lecturer like'" + selectlecgropsear.Text + "%' OR ss_lecturer LIKE'" + selectlecgropsear.Text + "%' OR s_Tag LIKE'" + selectlecgropsear.Text + "%' OR s_group LIKE'" + selectlecgropsear.Text + "%' OR sub_code LIKE '" + selectlecgropsear.Text + "%' OR sub_name LIKE '" + selectlecgropsear.Text + "%' OR noofstudent LIKE '" + selectlecgropsear.Text + "%' OR duration LIKE '" + selectlecgropsear.Text + "%' ", con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            selectsession.DataSource = dt;

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
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void selectviewsession_Click(object sender, EventArgs e)
        {
            openChildForm(new sessionView());
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
