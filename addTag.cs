using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace solution
{
    public partial class addTag : Form
    {
        public addTag()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FIL467M;Initial Catalog=ITPMSOLUTION;Integrated Security=True"
            );

        private void addTag_Load(object sender, EventArgs e)
        {
            GetTagRecord();
        }

        private void GetTagRecord()
        {


            SqlCommand cmd = new SqlCommand("Select * from TagTable ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void t_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearFormTag();
        }

        private void ClearFormTag()
        {

            t_name.Clear();
            t_code.Clear();
            related_tag.SelectedIndex = -1;
           
        }

        private void SaveBtnTag_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {


                    SqlCommand cmd = new SqlCommand("INSERT INTO TagTable VALUES (@t_name, @t_code, @related_tag)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@t_name", t_name.Text);
                    cmd.Parameters.AddWithValue("@t_code", t_code.Text);
                    cmd.Parameters.AddWithValue("@related_tag", related_tag.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();




                    MessageBox.Show("New Tag is Successfully saved in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //   GetTagRecord();
                }
                catch (Exception ey)
                {
                    Console.WriteLine(ey.Message);
                }

            }
            //manageTag frm = new manageTag();//open Attendance management form
            //frm.Show();
            openChildForm(new manageTag());
        }

        private bool IsValid()
        {
            if (t_name.Text == String.Empty)
            {
                MessageBox.Show("Tag name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (t_code.Text == string.Empty)
            {
                MessageBox.Show(" Tag Code is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (related_tag.Text == string.Empty)
            {
                MessageBox.Show("Related Tag is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;


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
            tagpanel.Controls.Add(childForm);
            tagpanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
             
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void t_code_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
