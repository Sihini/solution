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
    public partial class RegRoomWhatsnew : Form
    {
        string con_string = @"Data Source=DESKTOP-3CRQS4E;Initial Catalog=ITPMSOLUTION;Integrated Security=True";
        public RegRoomWhatsnew()
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection(con_string);
            con.Open();
            //string sqlSelectQuery = "SELECT MAX(LecturerId) as latest FROM LectureTable WHERE (SELECT ";

            //whatsnew 1
            string sqlSelectQuery = "SELECT Roomname as rm FROM LocationTable WHERE LocationID = (SELECT MAX(LocationID) FROM LocationTable)";
            SqlCommand cmd = new SqlCommand(sqlSelectQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = (dr["rm"].ToString());
            }
            con.Close();


            SqlConnection con2 = new SqlConnection(con_string);
            con2.Open();

            //whatsnew 2
            string sqlSelectQuery2 = "SELECT Buildingname as bnm FROM LocationTable WHERE LocationID = (SELECT MAX(LocationID) FROM LocationTable)";
            SqlCommand cmd2 = new SqlCommand(sqlSelectQuery2, con2);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                textBox2.Text = (dr2["bnm"].ToString());
            }
            con2.Close();




            //whatsnew 3
            SqlConnection con3 = new SqlConnection(con_string);
            con3.Open();
            string sqlSelectQuery3 = "SELECT RoomType as rtp FROM LocationTable WHERE LocationID = (SELECT MAX(LocationID) FROM LocationTable)";
            SqlCommand cmd3 = new SqlCommand(sqlSelectQuery3, con3);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                textBox3.Text = (dr3["rtp"].ToString());
            }
            con3.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
