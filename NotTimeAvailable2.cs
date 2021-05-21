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
    public partial class NotTimeAvailable2 : Form
    {
        int IsLoad =0;
        public NotTimeAvailable2()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EB5SPN9;Initial Catalog=ITPMSOLUTION;Integrated Security=True;Connect Timeout=30");

        public int lec_id;

        private void GetNotTimeAvailable()
        {
            SqlCommand cmd = new SqlCommand("Select * from STnotAvailable ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr1 = cmd.ExecuteReader();
            dt.Load(sdr1);
            con.Close();

            nottimeavalibale.DataSource = dt;
            if (IsLoad == 0)
            {
                DataGridViewCheckBoxColumn datacheckbox = new DataGridViewCheckBoxColumn();
                datacheckbox.HeaderText = "";
                datacheckbox.Width = 30;
                datacheckbox.Name = "Checkbox";
                nottimeavalibale.Columns.Insert(0, datacheckbox);
                IsLoad++;
            }

        }
        void Delete_data()
        {
            try
            {
              String  connection =("Data Source=DESKTOP-EB5SPN9;Initial Catalog=ITPMSOLUTION;Integrated Security=True;Connect Timeout=30");

                SqlConnection con = new SqlConnection(connection);
                if(con.State != ConnectionState.Open)
                {
                    con.Open();
                    string query = "delete from STnotAvailable where lec_id in("+ids+") ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Successfully");

                    GetNotTimeAvailable();

                }

            }
            catch (Exception)
            {
                MessageBox.Show("fail");
            }
        }

        string ids = string.Empty;
        private void stNotAvailableDeletebtn_Click(object sender, EventArgs e)
        {

            //  string ids = string.Empty;
            int i = 0;
            foreach(DataGridViewRow row in nottimeavalibale.Rows)
            {

                bool isSelected = Convert.ToBoolean(row.Cells["Checkbox"].Value);
                if (isSelected)
                {
                    // ids += Environment.NewLine;
                    if (i == 0)
                    {
                        ids += Convert.ToString(row.Cells["lec_id"].Value);
                        i++;
                    }
                    else
                    {
                        ids += ","+ Convert.ToString(row.Cells["lec_id"].Value);
                    }
                    }

            }
          //  MessageBox.Show(ids);
          if(ids != "")
            {
                Delete_data();


            }
            else
            {
                MessageBox.Show("please select data firse");
            }

           /* if (lec_id > 0)
            {

                SqlCommand cmd = new SqlCommand("DELETE FROM STnotAvailable WHERE lec_id=@id", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@id", this.lec_id);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Time Allocation is Deleted from this System", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetNotTimeAvailable();
            }
            else
            {
                MessageBox.Show("Please SESSIONN AND NOT AVAILABLE TIME ALOCATION to Delete his information", "Select ?", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }*/
        }

        
        private void nottimeavalibale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GetNotTimeAvailable(); 
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
            notAvailableTimepanel2.Controls.Add(childForm);
            notAvailableTimepanel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void NotTimeAvailable2_Load(object sender, EventArgs e)
        {
            GetNotTimeAvailable();
        }

        private void stNotAvailableViewbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new NotTimeAvailable1());
        }

        private void nottimeavalibale_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
