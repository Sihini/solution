using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System;

namespace solution
{
    public partial class manageSubjects : Form
    {
        public manageSubjects()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3CRQS4E;Initial Catalog=ITPMSOLUTION;Integrated Security=True");
        public int SubjectID;
        string semseter;




        private void managesubjectview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from SubjectTable ", con);
                DataTable dt = new DataTable();

                con.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                con.Close();

                SubjectID = Convert.ToInt32(managesubjectview.SelectedRows[0].Cells[0].Value);
                offyearsubadd.Text = managesubjectview.SelectedRows[0].Cells[1].Value.ToString();
                semseter = managesubjectview.SelectedRows[0].Cells[2].Value.ToString();
                if (semseter == "1st semeseter")
                {
                    addsubjectradiobtn1.Checked = true;
                }
                else if (semseter == "2nd semeseter")
                {
                    addsubjectradiobtn2.Checked = true; 
                }
               
                txtsubName.Text = managesubjectview.SelectedRows[0].Cells[3].Value.ToString();
                txtsubjecode.Text = managesubjectview.SelectedRows[0].Cells[4].Value.ToString();
                txtNokecHourse.Text = managesubjectview.SelectedRows[0].Cells[5].Value.ToString();
                txtNooftuteHourse.Text = managesubjectview.SelectedRows[0].Cells[6].Value.ToString();
                txtNoofLabHourse.Text = managesubjectview.SelectedRows[0].Cells[7].Value.ToString();
                txtnoOfEvelphour.Text = managesubjectview.SelectedRows[0].Cells[8].Value.ToString();
            }
            catch(Exception ex)
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

                GETManageSubject();



            }

         
        }

        private bool IsValid()
        {
            return true;
        }

        private void manageSubjects_Load(object sender, EventArgs e)
        {
            GETManageSubject();
        }

        private void GETManageSubject()
        {

                SqlCommand cmd = new SqlCommand("Select * from SubjectTable ", con);
                DataTable dt = new DataTable();

                con.Open();

                SqlDataReader sdr1 = cmd.ExecuteReader();
                dt.Load(sdr1);
                con.Close();

                managesubjectview.DataSource = dt;



            }

        private void addsubjectradiobtn1_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void offyearsubadd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearSubjctbtn_Click(object sender, EventArgs e)
        {
            clearManagementSubject();



        }

        private void clearManagementSubject()
        {
            SubjectID = 0;
            
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

        private void manageSubjectbtn_Click(object sender, EventArgs e)
        {

            if (SubjectID > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE SubjectTable  SET  OfferedYear=@offyear,OfferedSemester= @offsemester,SubjectName= @sybname,SubjectCode= @subcode,NoOfLectHours= @noofLec,NoOfTutHourse= @noofTute,NoOfLabHourse= @noofhours,NoOFEvaluHourse= @noofEvalu WHERE SubjectID =@Id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@offyear", offyearsubadd.Text);
                
                if (addsubjectradiobtn1.Checked == true)
                {
                    semseter = "1st semeseter";
                }
                else if (addsubjectradiobtn2.Checked == true)
                {
                    semseter = "2nd semeseter";
                }
                cmd.Parameters.AddWithValue("@offsemester", semseter);
                // cmd.Parameters.AddWithValue("@offsemester", addsubjectradiobtn2.Text);
                cmd.Parameters.AddWithValue("@sybname", txtsubName.Text);
                cmd.Parameters.AddWithValue("@subcode", txtsubjecode.Text);
                cmd.Parameters.AddWithValue("@noofLec", txtNokecHourse.Text);
                cmd.Parameters.AddWithValue("@noofTute", txtNooftuteHourse.Text);
                cmd.Parameters.AddWithValue("@noofhours", txtNoofLabHourse.Text);
                cmd.Parameters.AddWithValue("@noofEvalu", txtnoOfEvelphour.Text);
                cmd.Parameters.AddWithValue("@Id", this.SubjectID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Lecturer is Successfully Updated the database", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GETManageSubject();
                clearManagementSubject();
            }
            else
            {
                MessageBox.Show("Please select an Lecturer to update his information", "Select ?", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

       

        private void txtsearchsubjectmanage1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-58O0VLLG;Initial Catalog=ITPMSOLUTION;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM SubjectTable where OfferedYear like'" + txtsearchsubjectmanage1.Text+ "%' OR OfferedSemester LIKE '"+txtsearchsubjectmanage1.Text+ "%' OR SubjectName LIKE '"+txtsearchsubjectmanage1.Text+ "%' OR  SubjectCode LIKE '"+txtsearchsubjectmanage1.Text+"%'", con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            managesubjectview.DataSource = dt;


        }

        private void deleteSubjectbtn_Click(object sender, EventArgs e)
        {

            if (SubjectID > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM SubjectTable WHERE SubjectID =@Id ", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", this.SubjectID);
                

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Lecturer is Deleted from this System", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GETManageSubject();
                clearManagementSubject();

            }
            else
            {
                MessageBox.Show("Please select an Lecturer to update his information", "Select ?", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }

       
    }
