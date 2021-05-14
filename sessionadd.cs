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
    public partial class sessionadd : Form
    {
        public sessionadd()
        {
            InitializeComponent();
            fillcombox();
            filltagcombox();
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
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

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

        private void button5_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO SessionTable (s_lecturer,ss_lecturer,s_Tag) VALUES (@s_lecturer, @ss_lecturer, @s_Tag )", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@s_lecturer", selectLecturer.Text);
                cmd.Parameters.AddWithValue("@ss_lecturer", selettextlect.Text);
                cmd.Parameters.AddWithValue("@s_Tag", selecttags.Text);
               

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();


                openChildForm(new selectLandgroup());
            }
        }

        private bool IsValid()
        {
            if (selectLecturer.Text == String.Empty)
            {
                MessageBox.Show("Selected Lecturer name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (selettextlect.Text == string.Empty)
            {
                MessageBox.Show("Selected Tag name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (selecttags.Text == string.Empty)
            {
                MessageBox.Show("Selected lecturer Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

           
            return true;

        }

        private void selectLecturer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearbtnsession_Click(object sender, EventArgs e)
        {
            ClearFormLect();

        }

        private void ClearFormLect()
        {

            selettextlect.Clear();

            //cpmbo box clear
            selectLecturer.SelectedIndex = -1;
            selecttags.SelectedIndex = -1;


            selettextlect.Focus();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
