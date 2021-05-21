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
    public partial class RegLecWhatsnew : Form
    {
        string con_string = @"Data Source=DESKTOP-3CRQS4E;Initial Catalog=ITPMSOLUTION;Integrated Security=True";
        public RegLecWhatsnew()
        {

            InitializeComponent();

            SqlConnection con = new SqlConnection(con_string);
            con.Open();
            //string sqlSelectQuery = "SELECT MAX(LecturerId) as latest FROM LectureTable WHERE (SELECT ";

            //whatsnew 1
            string sqlSelectQuery = "SELECT LecturerName as lec FROM LectureTable WHERE LecturerId = (SELECT MAX(LecturerId) FROM LectureTable)";
            SqlCommand cmd = new SqlCommand(sqlSelectQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = (dr["lec"].ToString());
            }
            con.Close();


            SqlConnection con2 = new SqlConnection(con_string);
            con2.Open();

            //whatsnew 1
            string sqlSelectQuery2 = "SELECT g_no as grp FROM StudentTable WHERE sid = (SELECT MAX(sid) FROM StudentTable)";
            SqlCommand cmd2 = new SqlCommand(sqlSelectQuery2, con2);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                textBox2.Text = (dr2["grp"].ToString());
            }
            con2.Close();


            

            //whatsnew 3
            SqlConnection con3 = new SqlConnection(con_string);
            con3.Open();
            string sqlSelectQuery3 = "SELECT SubjectName as sub FROM SubjectTable WHERE SubjectID = (SELECT MAX(SubjectID) FROM SubjectTable)";
            SqlCommand cmd3 = new SqlCommand(sqlSelectQuery3, con3);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                textBox3.Text = (dr3["sub"].ToString());
            }
            con3.Close();

            //whatsnew 3
            /*string sqlSelectQuery3 = "SELECT LecturerName as lec FROM LectureTable WHERE LecturerId = (SELECT MAX(LecturerId) FROM LectureTable)";
            SqlCommand cmd3 = new SqlCommand(sqlSelectQuery3, con);
            SqlDataReader dr3 = cmd.ExecuteReader();*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
