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
    public partial class ManageSessionRoomNext : Form
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
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

  
        public ManageSessionRoomNext()
        {
            InitializeComponent();
            fillcomboxroomsMS();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3CRQS4E;Initial Catalog=ITPMSOLUTION;Integrated Security=True");

        private void ManageSessionRoomNext_Load(object sender, EventArgs e)
        {
            GetSessiondata();
           
        }

        private void GetSessiondata()
        {
            SqlCommand cmd = new SqlCommand("Select * from ManageRoomTable ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr1 = cmd.ExecuteReader();
            dt.Load(sdr1);
            con.Close();

            MSRGridView.DataSource = dt;


        }


        private void GetConsecutiveData()
        {
            

        }
   

      public void fillcomboxroomsMS()
        {
           }


        private void MSRGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnaddRoom_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnaddRoom_Click_1(object sender, EventArgs e)
        {
            openChildForm(new ManageSessionRooms());
        }

        private void MSRGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void MSRGridView_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void selectroom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



       private void btnsaveMSR_Click(object sender, EventArgs e)
        {
           
           

        }

        private void MSRGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MSRGridView_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
      {

        }

        private void consbtn_Click(object sender, EventArgs e)
        {
           // openChildForm(new Consecutive());
        }

        private void btnaddRoom_Click_2(object sender, EventArgs e)
        {
            openChildForm(new ManageSessionRooms());
        }
    }
}
