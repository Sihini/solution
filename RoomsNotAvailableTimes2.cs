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
    public partial class RoomsNotAvailableTimes2 : Form
    {
        public RoomsNotAvailableTimes2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EB5SPN9;Initial Catalog=ITPMSOLUTION;Integrated Security=True;Connect Timeout=30");
        public int sid;
        private void roomsNotAvailableBackbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new RoomsNotAvailableTimes());
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
            roomsNotAvailableTimepanel2.Controls.Add(childForm);
            roomsNotAvailableTimepanel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void RoomsNotAvailableTimes2_Load(object sender, EventArgs e)
        {
            Getroomnotrdata();
        }
        int IsLoad = 0;
        private void roomsNotAvailableGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            SqlCommand cmd = new SqlCommand("Select * from NotAvailabTable ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            
        }
        private void Getroomnotrdata()
        {

            SqlCommand cmd = new SqlCommand("Select * from NotAvailabTable ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            roomsNotAvailableGridView.DataSource = dt;
            if (IsLoad == 0)
            {
                DataGridViewCheckBoxColumn datacheckbox = new DataGridViewCheckBoxColumn();
                datacheckbox.HeaderText = "";
                datacheckbox.Width = 30;
                datacheckbox.Name = "Checkbox";
                roomsNotAvailableGridView.Columns.Insert(0, datacheckbox);
                IsLoad++;
            }

        }
        void Delete_data()
        {
            try
            {
                String connection = ("Data Source=DESKTOP-EB5SPN9;Initial Catalog=ITPMSOLUTION;Integrated Security=True;Connect Timeout=30");

                SqlConnection con = new SqlConnection(connection);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                    string query = "delete from NotAvailabTable where sid in(" + ids + ") ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Successfully");

                    Getroomnotrdata();

                }

            }
            catch (Exception)
            {
                MessageBox.Show("fail");
            }
        }

        string ids = string.Empty;

        private void nottimeavalibale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void roomsNotAvailableDeletebtn_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (DataGridViewRow row in roomsNotAvailableGridView.Rows)
            {

                bool isSelected = Convert.ToBoolean(row.Cells["Checkbox"].Value);
                if (isSelected)
                {
                    // ids += Environment.NewLine;
                    if (i == 0)
                    {
                        ids += Convert.ToString(row.Cells["sid"].Value);
                        i++;
                    }
                    else
                    {
                        ids += "," + Convert.ToString(row.Cells["sid"].Value);
                    }
                }

            }
            //  MessageBox.Show(ids);
            if (ids != "")
            {
                Delete_data();


            }
            else
            {
                MessageBox.Show("please select data firse");
            }

        }
    }
}
