using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace solution
{
    public partial class workingDays : Form
    {
        int noOfWorkingDays = 1;
        int noOfCheckedItem = 0;
        String days = "";
        int rowCount = 0;
        
        public workingDays()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EB5SPN9;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ITPMSOLUTION.mdf;Initial Catalog=ITPMSOLUTION;Integrated Security=True; Connect Timeout = 30");

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void updownDays_ValueChanged(object sender, EventArgs e)
        {
            noOfWorkingDays = Convert.ToInt32(Math.Round(updownDays.Value, 0));
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb1.Checked)
            {
                noOfCheckedItem++;
                days += "_monday";
            }
            else
            {
                noOfCheckedItem--;
            }
        }

        private void cb2_CheckedChanged(object sender, EventArgs e)
        {
            if (cb2.Checked)
            {
                noOfCheckedItem++;
                days += "_tuesday";
            }
            else
            {
                noOfCheckedItem--;
            }
        }

        private void cb3_CheckedChanged(object sender, EventArgs e)
        {
            if (cb3.Checked)
            {
                noOfCheckedItem++;
                days += "_wednesday";
            }
            else
            {
                noOfCheckedItem--;
            }
        }

        private void cb4_CheckedChanged(object sender, EventArgs e)
        {
            if (cb4.Checked)
            {
                noOfCheckedItem++;
                days += "_thursday";
            }
            else
            {
                noOfCheckedItem--;
            }
        }

        private void cb5_CheckedChanged(object sender, EventArgs e)
        {
            if (cb5.Checked)
            {
                noOfCheckedItem++;
                days += "_friday";
            }
            else
            {
                noOfCheckedItem--;
            }
        }

        private void cb6_CheckedChanged(object sender, EventArgs e)
        {
            if (cb6.Checked)
            {
                noOfCheckedItem++;
                days += "_saturday";
            }
            else
            {
                noOfCheckedItem--;
            }
        }

        private void cb7_CheckedChanged(object sender, EventArgs e)
        {
            if (cb7.Checked)
            {
                noOfCheckedItem++;
                days += "_sunday";
            }
            else
            {
                noOfCheckedItem--;
            }
        }


        private void wdUpdate_Click(object sender, EventArgs e)
        {
            if (noOfCheckedItem == noOfWorkingDays)
            {
                try
                {
                    con.Open();
                    String qry = "SELECT * FROM working_days";
                    SqlDataAdapter adapter = new SqlDataAdapter(qry, con);
                    SqlCommand command = new SqlCommand(qry, con);
                    //rowCount = (int)command.ExecuteScalar();
                    con.Close();

                    if (rowCount == 0)
                    {
                        try
                        {
                            con.Open();
                            String qryy = "INSERT INTO working_days (id, working_days, days, working_time) values(1, '" + Convert.ToInt32(Math.Round(updownDays.Value, 0)) + "', '" + days + "', '" + Convert.ToInt32(Math.Round(updownHrs.Value, 0)) + "_" + Convert.ToInt32(Math.Round(updownMin.Value, 0)) + "')";

                            SqlCommand commandd = new SqlCommand(qryy, con);
                            commandd.ExecuteNonQuery();
                            MessageBox.Show("Worcking Days Saved...");
                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        try
                        {
                            con.Open();
                            String qryy = "UPDATE working_days SET working_days = '" + Convert.ToInt32(Math.Round(updownDays.Value, 0)) + "', days = '" + days + "', working_time = '" + Convert.ToInt32(Math.Round(updownHrs.Value, 0)) + "_" + Convert.ToInt32(Math.Round(updownMin.Value, 0)) + "' WHERE id = 1";
                            MessageBox.Show(qryy);
                            SqlCommand commandd = new SqlCommand(qryy, con);
                            commandd.ExecuteNonQuery();
                            MessageBox.Show("Worcking Days Updated...");
                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Number or working days and working days are not matching!");
            }
        }

        
       

        private void workingDays_Load(object sender, EventArgs e)
        {

        }
        private void clearworkingday()
        {
           


            //numric value
           /* updownDays.Value = 1;
           updownHrs.Value = 0;
            updownMin.Value = 0;

            //checkbox
            cb1.Checked = false;
            cb2.Checked = false;
            cb3.Checked = false;
            cb4.Checked = false;
            cb5.Checked = false;
            cb6.Checked = false;
            cb7.Checked = false;*/

        }

        private void wdClear_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String qryy = "DELETE FROM working_days WHERE id = 1";
                SqlCommand commandd = new SqlCommand(qryy, con);
                commandd.ExecuteNonQuery();
                MessageBox.Show("Worcking Days Deleted...");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            clearworkingday();
        }

       

       

        private void updownHrs_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}



