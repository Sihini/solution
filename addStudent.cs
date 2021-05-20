using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace solution
{
    public partial class addStudent : Form
    {
        public addStudent()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FIL467M;Initial Catalog=ITPMSOLUTION;Integrated Security=True");
        public string gid { get; set; }
        public string mid { get; set; }
        public string sid { get; set; }
        public string rid { get; set; }

        public string zid { get; set; }
        public string zidr { get; set; }
        private void addStudent_Load(object sender, EventArgs e)
        {
            GetStudentRecord();
        }

        private void GetStudentRecord()
        {


            SqlCommand cmd = new SqlCommand("Select * from StudentTable ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

        }
    

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {


                    SqlCommand cmd = new SqlCommand("INSERT INTO StudentTable VALUES (@a_year_sem, @program, @g_no, @sub_gno, @g_id, @sub_gid)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@a_year_sem", a_year.Text);
                    cmd.Parameters.AddWithValue("@program", programme.Text);
                    cmd.Parameters.AddWithValue("@g_no", g_no.Text);
                    cmd.Parameters.AddWithValue("@sub_gno", sub_gno.Text);
                    cmd.Parameters.AddWithValue("@g_id", g_id.Text);
                    cmd.Parameters.AddWithValue("@sub_gid", sub_gid.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();




                    MessageBox.Show("New Student is Successfully saved in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    //   GetStudentsRecord();
                }
                catch(Exception ey)
                {
                    Console.WriteLine(ey.Message);
                }

            }
            //manageStudent frm = new manageStudent();//open Attendance management form
            //frm.Show();
            openChildForm(new manageStudent());
        }

        private bool IsValid()
        {
            if (programme.Text == String.Empty)
            {
                MessageBox.Show("Student programme is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (a_year.Text == string.Empty)
            {
                MessageBox.Show("Academic Year Semester is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (g_no.Text == string.Empty)
            {
                MessageBox.Show("Group No is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (sub_gno.Text == string.Empty)
            {
                MessageBox.Show("Sub Group No is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (g_id.Text == string.Empty)
            {
                MessageBox.Show("Group Id is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (sub_gid.Text == string.Empty)
            {
                MessageBox.Show("Sub Group Id is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;


        }

        private void clearBtnStd_Click(object sender, EventArgs e)
        {
            ClearFormStd();
        }

        private void ClearFormStd()
        {
           
            a_year.Clear();
            sub_gid.Clear();
            g_id.Clear();
            programme.SelectedIndex = -1;
            g_no.Value = 1;
            sub_gno.Value = 1;
        }

       

        private void stdGenId_Click(object sender, EventArgs e)
        {

            gid = (string)a_year.Text;
            mid = (string)programme.Text;
            sid= (string)g_no.Text;
            rid= (string)sub_gno.Text;

            zid = gid + "." + mid + "." + sid ;
            g_id.Text = (zid);
            zidr = gid + "." + mid + "." + sid+ "."+rid;
            sub_gid.Text = (zidr);
        }

        private void addStudent_Load_1(object sender, EventArgs e)
        {

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
            stdpanel.Controls.Add(childForm);
            stdpanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
