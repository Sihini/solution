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
    public partial class manageLocation : Form
    {
        public manageLocation()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3CRQS4E;Initial Catalog=ITPMSOLUTION;Integrated Security=True");
        string roomtype;
        public int LocationID;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void manageLocation_Load(object sender, EventArgs e)
        {
            GetLocationdata();
        }

        private void GetLocationdata()
        {
            SqlCommand cmd = new SqlCommand("Select * from LocationTable ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr1 = cmd.ExecuteReader();
            dt.Load(sdr1);
            con.Close();

            LocationdataGridView.DataSource = dt;


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void LocationdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from LocationTable ", con);
                DataTable dt = new DataTable();

                con.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                con.Close();

                LocationID = Convert.ToInt32(LocationdataGridView.SelectedRows[0].Cells[0].Value);
                txtBuildingname.Text = LocationdataGridView.SelectedRows[0].Cells[1].Value.ToString();
                /* if (addsubjectradiobtn1.Checked == true)
                 {
                     semseter = "1st semeseter";
                 }
                 else if (addsubjectradiobtn2.Checked == true)
                 {
                     semseter = "2nd semeseter";
                 }*/
                txtroomname.Text = LocationdataGridView.SelectedRows[0].Cells[2].Value.ToString();
                if (roomtype =="Lecurer Hall")
                {
                    lecturradiobtn.Checked = true;
                    roomtype = "Lecurer Hall";
                }
                else if (roomtype == "laboratory")
                {
                    labradiobtn.Checked = true;
                   
                }
                roomtype= LocationdataGridView.SelectedRows[0].Cells[3].Value.ToString();
                txtcapacity.Text = LocationdataGridView.SelectedRows[0].Cells[4].Value.ToString();
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand();


                con.Open();
                //cmd.ExecuteNonQuery();
                con.Close();

                //   MessageBox.Show("New Lecturer is Successfully saved in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetLocationdata();



            }
        }

        private bool IsValid()
        {
            return true;
        }

        private void clearSubjctbtn_Click(object sender, EventArgs e)
        {
           
        }

        private void clearmanageLocation()
        {
            txtBuildingname.Clear();
            txtcapacity.Clear();
            txtroomname.Clear();

            //radio button
            labradiobtn.Checked = false;
            lecturradiobtn.Checked = false;

        }

        private void clearlocationtbtn_Click(object sender, EventArgs e)
        {
            clearmanageLocation();
        }

        private void manageLocationbtn_Click(object sender, EventArgs e)
        {


            if (LocationID > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE LocationTable  SET Buildingname=@buildingname,Roomname= @roomname,RoomType= @roomtype,Capacity= @capacity WHERE LocationID =@Id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@buildingname", txtBuildingname.Text);
                cmd.Parameters.AddWithValue("@roomname", txtroomname.Text);
               
                if (lecturradiobtn.Checked == true)
                {
                    roomtype = "Lecurer Hall";
                }
                else if (labradiobtn.Checked == true)
                {
                    roomtype = "laboratory";
                }
                cmd.Parameters.AddWithValue("@roomtype", roomtype);
                cmd.Parameters.AddWithValue("@capacity", txtcapacity.Text);

                cmd.Parameters.AddWithValue("@Id", this.LocationID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Lecturer is Successfully Updated the database", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetLocationdata();
                clearmanageLocation();

            }
            else
            {
                MessageBox.Show("Please select an Lecturer to update his information", "Select ?", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void deleteLocationbtn_Click(object sender, EventArgs e)
        {




            if (LocationID > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM LocationTable WHERE LocationID =@Id ", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", this.LocationID);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Lecturer is Deleted from this System", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetLocationdata();
                clearmanageLocation();
            }
            else
            {
                MessageBox.Show("Please select an Lecturer to update his information", "Select ?", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void txtsearchlocation_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3CRQS4E;Initial Catalog=ITPMSOLUTION;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM LocationTable where Buildingname like'" + txtsearchlocation.Text + "%' OR Roomname LIKE '" + txtsearchlocation.Text + "%' OR RoomType LIKE '" + txtsearchlocation.Text + "%' OR  Capacity LIKE '" + txtsearchlocation.Text + "%'", con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            LocationdataGridView.DataSource = dt;
        }

        private void labradiobtn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
