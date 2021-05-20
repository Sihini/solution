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
    public partial class addLocation : Form
    {
        public addLocation()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-58O0VLLG;Initial Catalog=ITPMSOLUTION;Integrated Security=True");
         string roomtype;

        private void addLocation_Load(object sender, EventArgs e)
        {

        }

        private void btnsavelaction_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO LocationTable VALUES (@buildingname, @roomname, @roomtype, @capacity)", con);
                cmd.CommandType = CommandType.Text;

            /*Insert Building Name*/    
                cmd.Parameters.AddWithValue("@buildingname", txtBuildingname.Text);
            /*Insert Room Name*/
                cmd.Parameters.AddWithValue("@roomname", txtroomname.Text);
            /*Insert Room Type*/
                if (lecturradiobtn.Checked == true)
                {
                    roomtype = "Lecurer Hall";
                }
                else if (labradiobtn.Checked == true)
                {
                    roomtype = "laboratory";
                }
                cmd.Parameters.AddWithValue("@roomtype", roomtype);
             /*Insert Capacity*/
                cmd.Parameters.AddWithValue("@capacity", txtcapacity.Text);
                

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Lecturer is Successfully saved in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //   GetStudentsRecord();


            }
        }

        private bool IsValid()
        {
            if (txtBuildingname.Text == String.Empty)
            {
                MessageBox.Show("Selected  to Offered year", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtroomname.Text == string.Empty)
            {
                MessageBox.Show("Selected to offered semester", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (roomtype == string.Empty)
            {
                MessageBox.Show("Subject Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (txtcapacity.Text == string.Empty)
            {
                MessageBox.Show("Subject Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



            return true;
        }

        private void btnclearlocation_Click(object sender, EventArgs e)
        {
            clearLocation();
        }

        private void clearLocation()
        {
            txtBuildingname.Clear();
            txtcapacity.Clear();
            txtroomname.Clear();

            //radio button
            labradiobtn.Checked = false;
            lecturradiobtn.Checked = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
