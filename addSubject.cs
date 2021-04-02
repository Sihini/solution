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

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-58O0VLLG;Initial Catalog=ITPMSOLUTION;Integrated Security=True");
        string semseter;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addSubject_Load(object sender, EventArgs e)
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
                else
                {
                    semseter = "2nd semester";
                }
                cmd.Parameters.AddWithValue("@offsemes", semseter);
                cmd.Parameters.AddWithValue("@subname", txtsubName.Text);
                cmd.Parameters.AddWithValue("@subcode", txtsubjecode.Text);
                cmd.Parameters.AddWithValue("@nooflechours", txtNokecHourse.Text);
                cmd.Parameters.AddWithValue("@nooftuthours", txtNooftuteHourse.Text);
                cmd.Parameters.AddWithValue("@nooflabhours", txtNoofLabHourse.Text);
                cmd.Parameters.AddWithValue("@noofevelhours", txtnoOfEvelphour.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Lecturer is Successfully saved in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //   GetStudentsRecord();


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
                MessageBox.Show("Department Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtNokecHourse.Value !=0 )
            {
                MessageBox.Show("Subject Code Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
           
            else if (txtNokecHourse.Text == string.Empty)
            {
                MessageBox.Show("Subject Code Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtNooftuteHourse.Text == string.Empty)
            {
                MessageBox.Show("Selected to No of Lecture hourse", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // clearing radio Button
            addsubjectradiobtn1.Checked = false;
            addsubjectradiobtn2.Checked = false;

            // clearing combobox
            offyearsubadd.SelectedIndex = -1;


        }
    }
}
