using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Configuration;

namespace solution
{
    public partial class consecutiveView : Form
    {
        public consecutiveView()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FIL467M;Initial Catalog=ITPMSOLUTION;Integrated Security=True");
        

        private void consecutiveView_Load(object sender, EventArgs e)
        {
           
            GETConsecutiveView();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
            conView.Controls.Add(childForm);
            conView.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void GETConsecutiveView()
        {

            SqlCommand cmd = new SqlCommand("Select * from ConsecutiveSt ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr1 = cmd.ExecuteReader();
            dt.Load(sdr1);
            con.Close();

            consecutiveGridView1.DataSource = dt;
        }

        private void sessionavalibale_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            openChildForm(new consecutive());
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (consecutiveGridView1.CurrentRow.Cells.Count > 0)
            {
                int i = consecutiveGridView1.CurrentRow.Cells[0].RowIndex;

                if (consecutiveGridView1.Rows.Count > 1 && i != consecutiveGridView1.Rows.Count - 1)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM ConsecutiveSt WHERE cid =" + consecutiveGridView1.CurrentRow.Cells[0].Value.ToString() + "", con);
                    cmd.CommandType = CommandType.Text;


                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    consecutiveGridView1.Rows.RemoveAt(consecutiveGridView1.CurrentRow.Index);
                    MessageBox.Show("Row is Deleted from this System", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show("Please select an Lecturer to update his information", "Select ?", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            
        }

        private void consecutiveGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
