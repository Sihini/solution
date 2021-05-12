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
            SqlCommand cmd = new SqlCommand("INSERT INTO SessionTable (s_lecturer,ss_lecturer,s_Tag) VALUES (@s_lecturer, @ss_lecturer, @s_Tag )", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@s_lecturer", selectLecturer.Text);
            cmd.Parameters.AddWithValue("@ss_lecturer", selettextlect.Text);
            cmd.Parameters.AddWithValue("@s_Tag", selecttags.Text);
            /* cmd.Parameters.AddWithValue("@s_group", txtDepname.Text);
             cmd.Parameters.AddWithValue("@sub_code", txtcent.Text);
             cmd.Parameters.AddWithValue("@sub_name", txtbulin.Text);
             cmd.Parameters.AddWithValue("@noofstudent", txtlevel.Text);
             cmd.Parameters.AddWithValue("@duration", txtrank.Text);*/

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();


            openChildForm(new selectLandgroup());
        }
    }
}
