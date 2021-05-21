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
    public partial class RoomsNotAvailableTimes : Form
    {
        public RoomsNotAvailableTimes()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EB5SPN9;Initial Catalog=ITPMSOLUTION;Integrated Security=True;Connect Timeout=30");

        private void selectRoomTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectDateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void startTimeTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void endTimeTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void mgAddSessionbtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO NotAvailabTable VALUES (@sroom, @sdate, @stime, @etime)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@sroom", selectRoomTB.Text);
            cmd.Parameters.AddWithValue("@sdate", selectDateComboBox.Text);
            cmd.Parameters.AddWithValue("@stime", startTimeTB.Text);
            cmd.Parameters.AddWithValue("@etime", endTimeTB.Text);
            

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("New Lecturer is Successfully saved in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //   GetStudentsRecord();
            // ClearFormLect();
            clearManageTagdetails();








        }

        private void mgClearbtn_Click(object sender, EventArgs e)
        {
            clearManageTagdetails();
        }
        private void clearManageTagdetails()
        {
           
            selectRoomTB.Clear();
            startTimeTB.Clear();
            endTimeTB.Clear();
            selectDateComboBox.SelectedIndex = -1;
           
        }

        private void roomsNotAvailableViewbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new RoomsNotAvailableTimes2());
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
            roomsNotAvailableTimepanel.Controls.Add(childForm);
            roomsNotAvailableTimepanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void RoomsNotAvailableTimes_Load(object sender, EventArgs e)
        {

        }
    }
}
