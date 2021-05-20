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
    public partial class parallelView : Form
    {
        public parallelView()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FIL467M;Initial Catalog=ITPMSOLUTION;Integrated Security=True");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void parallelView_Load(object sender, EventArgs e)
        {
            GETParallelView();
        }

        private void GETParallelView()
        {
            SqlCommand cmd = new SqlCommand("Select * from ParallelSt ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr1 = cmd.ExecuteReader();
            dt.Load(sdr1);
            con.Close();

            parallelDataGridView.DataSource = dt;
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
            parallelPanel.Controls.Add(childForm);
            parallelPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            openChildForm(new parallelSt());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (parallelDataGridView.CurrentRow.Cells.Count > 0)
            {
                int i = parallelDataGridView.CurrentRow.Cells[0].RowIndex;

                if (parallelDataGridView.Rows.Count > 1 && i != parallelDataGridView.Rows.Count - 1)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM ParallelSt WHERE pid =" + parallelDataGridView.CurrentRow.Cells[0].Value.ToString() + "", con);
                    cmd.CommandType = CommandType.Text;


                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    parallelDataGridView.Rows.RemoveAt(parallelDataGridView.CurrentRow.Index);
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
