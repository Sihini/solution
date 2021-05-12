using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace solution
{
    public partial class addSubject : Form
    {
        public addSubject()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3CRQS4E;Initial Catalog=ITPMSOLUTION;Integrated Security=True");
        string semseter;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addSubject_Load(object sender, EventArgs e)
        {
           



        }

        private void GETManageSubject()
        {
           
        }

        private void Btnsujectadd_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO SubjectTable VALUES (@offyear, @offsemes, @subname, @subcode, @nooflechours, @nooftuthours, @nooflabhours, @noofevelhours)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@offyear", offyearsubadd.Text);
             
                if (addsubjectradiobtn1.Checked == true)
                {
                    semseter = "1st semeseter";
                }
                else if(addsubjectradiobtn2.Checked==true)
                {
                    semseter = "2nd semeseter";
                }
                cmd.Parameters.AddWithValue("@offsemes", semseter);
                cmd.Parameters.AddWithValue("@subname", txtsubName.Text);
                cmd.Parameters.AddWithValue("@subcode", txtsubjecode.Text);
                cmd.Parameters.AddWithValue("@nooflechours", txtNokecHourse.Value);
                cmd.Parameters.AddWithValue("@nooftuthours", txtNooftuteHourse.Value);
                cmd.Parameters.AddWithValue("@nooflabhours", txtNoofLabHourse.Value);
                cmd.Parameters.AddWithValue("@noofevelhours", txtnoOfEvelphour.Value);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Lecturer is Successfully saved in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //   GetStudentsRecord();
                clearaddsubject();


            }
         
        }

        private bool IsValid()
        {
            if (offyearsubadd.Text == String.Empty)
            {
                MessageBox.Show("Selected  to Offered year", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (semseter == string.Empty)
            {
                MessageBox.Show("Selected to offered semester", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (txtsubName.Text == string.Empty)
            {
                MessageBox.Show("Subject Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (txtsubjecode.Text == string.Empty)
            {
                MessageBox.Show("Sunject code  is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
          
           
            else if (txtNokecHourse.Text == string.Empty)
            {
                MessageBox.Show("Selected to No of Lectures hourse", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtNooftuteHourse.Text == string.Empty)
            {
                MessageBox.Show("Selected to No of tute hourse", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtNoofLabHourse.Text == string.Empty)
            {
                MessageBox.Show("Selected to No of lab hourse", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtnoOfEvelphour.Text == string.Empty)
            {
                MessageBox.Show("Selected to No of evaluation hourse", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnclearsubectadd_Click(object sender, EventArgs e)
        {
            clearaddsubject();
        }

        private void clearaddsubject()
        {
            txtsubName.Clear();
            txtsubjecode.Clear();

            //radio button
            addsubjectradiobtn1.Checked = false;
            addsubjectradiobtn2.Checked = false;


            //numric value
            txtNoofLabHourse.Value = 0;
            txtNokecHourse.Value = 0;
            txtnoOfEvelphour.Value = 0;
            txtNooftuteHourse.Value = 0;


            //clearing combo box
            offyearsubadd.SelectedIndex = -1;

        }
    }
}
