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
    public partial class ManageSessionRooms : Form
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
            panelMSRIN.Controls.Add(childForm);
            panelMSRIN.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        public ManageSessionRooms()
        {
            InitializeComponent();
            fillcomboxrooms();
            fillcomboxrooms2();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void selectsession_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }



        public void fillcomboxrooms()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3CRQS4E;Initial Catalog=ITPMSOLUTION;Integrated Security=True");
            string sql = "SELECT * from LocationTable"; 
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(2);
                    selectroom.Items.Add(sname);


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        public void fillcomboxrooms2()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3CRQS4E;Initial Catalog=ITPMSOLUTION;Integrated Security=True");
            string sql = "SELECT s_id from SessionTable ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                   int sid = myreader.GetInt32(myreader.GetOrdinal("s_id"));
                    selectsession.Items.Add(sid);


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void selectroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ManageSessionRooms_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void selettextlect_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnsavelaction_Click(object sender, EventArgs e)
        { }

        private void btnsaveMSR_Click(object sender, EventArgs e)
        {

        }

        private void panelMSRIN_Paint(object sender, PaintEventArgs e)
        {

        }

        private void selectsession_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3CRQS4E;Initial Catalog=ITPMSOLUTION;Integrated Security=True");
            con.Open();
            string sql = "SELECT * from SessionTable where s_id =" + int.Parse(selectsession.Text);
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader = cmd.ExecuteReader();

            try
            {

                if (myreader.Read())
                {

                    Box1.Text = (myreader[1].ToString());
                    Box2.Text = (myreader[2].ToString());
                    Box3.Text = (myreader[3].ToString());
                    Box4.Text = (myreader[4].ToString());
                    Box5.Text = (myreader[5].ToString());
                    Box6.Text = (myreader[6].ToString());
                    Box7.Text = (myreader[7].ToString());
                    Box8.Text = (myreader[8].ToString());

 
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnsaveMSR_Click_1(object sender, EventArgs e)

        {
            if (IsValid())
            {

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-3CRQS4E;Initial Catalog=ITPMSOLUTION;Integrated Security=True");


                SqlCommand cmd = new SqlCommand("INSERT INTO ManageRoomTable VALUES (@sm_id, @s_room, @lec_session, @lect_session, @ses_tag, @ses_group, @su_code, @su_name, @nstuden, @sduration)", con);
                cmd.CommandType = CommandType.Text;

                /*Insert Building Name*/

                cmd.Parameters.AddWithValue("@sm_id", selectsession.Text);
                cmd.Parameters.AddWithValue("@s_room", selectroom.Text);
                cmd.Parameters.AddWithValue("@lec_session", Box1.Text);
                cmd.Parameters.AddWithValue("@lect_session", Box2.Text);
                cmd.Parameters.AddWithValue("@ses_tag", Box3.Text);
                cmd.Parameters.AddWithValue("@ses_group", Box4.Text);
                cmd.Parameters.AddWithValue("@su_code", Box5.Text);
                cmd.Parameters.AddWithValue("@su_name", Box6.Text);
                cmd.Parameters.AddWithValue("@nstuden", Box7.Text);
                cmd.Parameters.AddWithValue("@sduration", Box8.Text);



                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New SessionRoom is Successfully saved in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                openChildForm(new ManageSessionRoomNext());
                
            }


        }



        private bool IsValid()
        {
            if (selectsession.Text == String.Empty)
            {
                MessageBox.Show("Please Select Session ID", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (selectroom.Text == string.Empty)
            {
                MessageBox.Show("Please Select RoomName", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

           
            return true;
        }




        private void selectroom_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Box1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclearMSR_Click(object sender, EventArgs e)
        {
            clearLocation();
        }

        private void clearLocation()
        {
            selectsession.Text = String.Empty;
            selectroom.Text = String.Empty;
            Box1.Clear();
            Box2.Clear();
            Box3.Clear();
            Box4.Clear();
            Box5.Clear();
            Box6.Clear();
            Box7.Clear();
            Box8.Clear();


        }
    }
    }

