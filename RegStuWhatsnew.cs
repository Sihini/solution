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
    public partial class RegStuWhatsnew : Form
    {
        string con_string = @"Data Source=DESKTOP-3CRQS4E;Initial Catalog=ITPMSOLUTION;Integrated Security=True";
        public RegStuWhatsnew()
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection(con_string);
            con.Open();

            //whatsnew 1
            string sqlSelectQuery = "SELECT program as prg FROM StudentTable WHERE sid = (SELECT MAX(sid) FROM StudentTable)";
            SqlCommand cmd = new SqlCommand(sqlSelectQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = (dr["prg"].ToString());
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


            SqlConnection con3 = new SqlConnection(con_string);
            con3.Open();

            //whatsnew 1
            string sqlSelectQuery3 = "SELECT a_year_sem as sem FROM StudentTable WHERE sid = (SELECT MAX(sid) FROM StudentTable)";
            SqlCommand cmd3 = new SqlCommand(sqlSelectQuery3, con3);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                textBox3.Text = (dr3["sem"].ToString());
            }
            con3.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
