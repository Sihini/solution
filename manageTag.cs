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
    public partial class manageTag : Form
    {
        public manageTag()
        {
            InitializeComponent();
        }

        private void manageTag_Load_1(object sender, EventArgs e)
        {
            GETManageTag();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FIL467M;Initial Catalog=ITPMSOLUTION;Integrated Security=True");
        public int tid;
        int count = 0;


        private bool IsValid()
        {
            return true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM TagTable where t_code like'" + TagSearch.Text + "%' OR t_name LIKE'" + TagSearch.Text + "%' OR related_tag LIKE'" + TagSearch.Text + "%'", con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            TagdataGridView.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from TagTable ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            tid = Convert.ToInt32(TagdataGridView.SelectedRows[0].Cells[0].Value);
            t_name.Text = TagdataGridView.SelectedRows[0].Cells[1].Value.ToString();
            t_code.Text = TagdataGridView.SelectedRows[0].Cells[2].Value.ToString();
            related_tag.Text = TagdataGridView.SelectedRows[0].Cells[3].Value.ToString();
           
        }

        private void ClearBtnManageTag_Click(object sender, EventArgs e)
        {
            clearManageTagdetails();
        }

        private void clearManageTagdetails()
        {
            tid = 0;
            t_code.Clear();
            t_name.Clear();
            related_tag.SelectedIndex = -1;

            t_name.Focus(); ;
        }
       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();


                    con.Open();
                    //cmd.ExecuteNonQuery();
                    con.Close();

                    //   MessageBox.Show("New TAG is Successfully saved in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GETManageTag();
                }
                catch (Exception er)
                {
                    Console.WriteLine(er.Message);
                }

            }
        }

        private void GETManageTag()
        {

            SqlCommand cmd = new SqlCommand("Select * from TagTable ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr1 = cmd.ExecuteReader();
            dt.Load(sdr1);
            con.Close();

            TagdataGridView.DataSource = dt;
        }

        private void UpdateBtnTag_Click(object sender, EventArgs e)
        {
            if (tid > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE TagTable SET t_name=@t_name,t_code=@t_code,related_tag=@related_tag WHERE tid=@tid", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@t_name", t_name.Text);
                cmd.Parameters.AddWithValue("@t_code", t_code.Text);
                cmd.Parameters.AddWithValue("@related_tag", related_tag.Text);
                cmd.Parameters.AddWithValue("@tid", this.tid);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Tag is Successfully Updated the database", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GETManageTag();

                clearManageTagdetails();
            }
            else
            {
                MessageBox.Show("Please select an Tag to update the information", "Select ?", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void DeleteBtnTag_Click(object sender, EventArgs e)
        {
            if (tid > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM TagTable WHERE tid =@tid", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@tid", this.tid);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Tag is Deleted from this System", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GETManageTag();

                clearManageTagdetails();

            }
            else
            {
                MessageBox.Show("Please select an Tag to update his information", "Select ?", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    
    }
}
