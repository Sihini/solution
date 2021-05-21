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
    public partial class ManageSessionRoomConsecutive : Form
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
            CRpanel2.Controls.Add(childForm);
            CRpanel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }


        public ManageSessionRoomConsecutive()
        {
            InitializeComponent();
            GetConsecutiveRoomdata();
        }


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3CRQS4E;Initial Catalog=ITPMSOLUTION;Integrated Security=True");
        private void ManageSessionRoomConsecutive_Load(object sender, EventArgs e)
        {

        }

        private void GetConsecutiveRoomdata()
        {
            SqlCommand cmd = new SqlCommand("Select * from ConsecutiveSRT ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr1 = cmd.ExecuteReader();
            dt.Load(sdr1);
            con.Close();

            MSRconsecutive.DataSource = dt;


        }

        private void deleteLocationbtn_Click(object sender, EventArgs e)
        {

        }

        private void MSRconsecutive_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteLocationbtn_Click_1(object sender, EventArgs e)
        {
            if (MSRconsecutive.CurrentRow.Cells.Count > 0)
            {
                int i = MSRconsecutive.CurrentRow.Cells[0].RowIndex;

                if (MSRconsecutive.Rows.Count > 1 && i != MSRconsecutive.Rows.Count - 1)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM ConsecutiveSRT WHERE cr_id =" + MSRconsecutive.CurrentRow.Cells[0].Value.ToString() + "", con);
                    cmd.CommandType = CommandType.Text;


                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MSRconsecutive.Rows.RemoveAt(MSRconsecutive.CurrentRow.Index);
                    MessageBox.Show("Row is Deleted from this System", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show("Please select an Lecturer to update his information", "Select ?", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //openChildForm(new Consecutive());

        }

        
    }
}
