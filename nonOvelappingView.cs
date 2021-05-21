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
    public partial class nonOvelappingView : Form
    {
        public nonOvelappingView()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FIL467M;Initial Catalog=ITPMSOLUTION;Integrated Security=True");

        private void nonOvelappingView_Load(object sender, EventArgs e)
        {
            GetNonOverlappingView();
        }

        private void GetNonOverlappingView()
        {
            SqlCommand cmd = new SqlCommand("Select * from NonOverlappingSt ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr1 = cmd.ExecuteReader();
            dt.Load(sdr1);
            con.Close();

            nonOveralappingGridView.DataSource = dt;

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
            nonOverlappingPanel.Controls.Add(childForm);
            nonOverlappingPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            openChildForm(new nonOverlappingSt());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nonOveralappingGridView.CurrentRow.Cells.Count > 0)
            {
                int i = nonOveralappingGridView.CurrentRow.Cells[0].RowIndex;

                if (nonOveralappingGridView.Rows.Count > 1 && i != nonOveralappingGridView.Rows.Count - 1)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM NonOverlappingSt WHERE oid =" + nonOveralappingGridView.CurrentRow.Cells[0].Value.ToString() + "", con);
                    cmd.CommandType = CommandType.Text;


                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    nonOveralappingGridView.Rows.RemoveAt(nonOveralappingGridView.CurrentRow.Index);
                    MessageBox.Show("Row is Deleted from this System", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show("Please select an Lecturer to update his information", "Select ?", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    }
}
