using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace solution
{
    public partial class AddWorkingDays : Form
    {
        public AddWorkingDays()
        {
            InitializeComponent();
            customizeDesing();
        }

        //drag form
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void customizeDesing()
        {
            Lecturerpanel.Visible = false;
            Studentpanel.Visible = false;
            Subjectpanel.Visible = false;
            Locationpanel.Visible = false;
            Workingdayspanel.Visible = false;
            Sessionpanel.Visible = false;
            Tagpanel.Visible = false;
            Timetablepanel.Visible = false;
            //..
        }

        private void hideSubMenu()
        {
            if (Lecturerpanel.Visible == true)
                Lecturerpanel.Visible = false;
            if (Studentpanel.Visible == true)
                Studentpanel.Visible = false;
            if (Subjectpanel.Visible == true)
                Subjectpanel.Visible = false;
            if (Locationpanel.Visible == true)
                Locationpanel.Visible = false;
            if (Workingdayspanel.Visible == true)
                Workingdayspanel.Visible = false;
            if (Sessionpanel.Visible == true)
                Sessionpanel.Visible = false;
            if (Tagpanel.Visible == true)
                Tagpanel.Visible = false;
            if (Timetablepanel.Visible == true)
                Timetablepanel.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void btnhome_Click(object sender, EventArgs e)
        {

        }

        private void dashboardpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnLecturer_Click(object sender, EventArgs e)
        {
            showSubMenu(Lecturerpanel);
        }

        private void lecbtn1_Click(object sender, EventArgs e)
        {
            openChildForm(new addLecturer());
            //..
            hideSubMenu();
        }

        private void lecbtn2_Click(object sender, EventArgs e)
        {
            //..
            hideSubMenu();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            showSubMenu(Studentpanel);
        }

        private void stubtn1_Click(object sender, EventArgs e)
        {
            //..
            hideSubMenu();
        }

        private void stubtn2_Click(object sender, EventArgs e)
        {
            //..
            hideSubMenu();
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            showSubMenu(Subjectpanel);
        }

        private void subbtn1_Click(object sender, EventArgs e)
        {
            //..
            hideSubMenu();
        }

        private void subbtn2_Click(object sender, EventArgs e)
        {
            //..
            hideSubMenu();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            showSubMenu(Locationpanel);
        }

        private void locbtn1_Click(object sender, EventArgs e)
        {
            //..
            hideSubMenu();
        }

        private void locbtn2_Click(object sender, EventArgs e)
        {
            //..
            hideSubMenu();
        }

        private void btnWorkingdays_Click(object sender, EventArgs e)
        {
            showSubMenu(Workingdayspanel);
        }

        private void worbtn1_Click(object sender, EventArgs e)
        {
            //..
            hideSubMenu();
        }

        private void worbtn2_Click(object sender, EventArgs e)
        {
            //..
            hideSubMenu();
        }

        private void btnSession_Click(object sender, EventArgs e)
        {
            showSubMenu(Sessionpanel);
        }

        private void sesbtn1_Click(object sender, EventArgs e)
        {
            //..
            hideSubMenu();
        }

        private void sesbtn2_Click(object sender, EventArgs e)
        {
            //..
            hideSubMenu();
        }

        private void sesbtn3_Click(object sender, EventArgs e)
        {
            //..
            hideSubMenu();
        }

        private void sesbtn4_Click(object sender, EventArgs e)
        {
            //..
            hideSubMenu();
        }

        private void btnTag_Click(object sender, EventArgs e)
        {
            showSubMenu(Tagpanel);
        }

        private void tag1_Click(object sender, EventArgs e)
        {
            //..
            hideSubMenu();
        }

        private void tag2_Click(object sender, EventArgs e)
        {
            //..
            hideSubMenu();
        }

        private void btnStatistical_Click(object sender, EventArgs e)
        {

        }

        private void btnTimetable_Click(object sender, EventArgs e)
        {
            showSubMenu(Timetablepanel);
        }

        private void timbtn1_Click(object sender, EventArgs e)
        {
            //..
            hideSubMenu();
        }

        private void timbtn2_Click(object sender, EventArgs e)
        {
            //..
            hideSubMenu();
        }

        private void timbtn3_Click(object sender, EventArgs e)
        {
            //..
            hideSubMenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();//exit from application
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;//Form minimized
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //form maximizes
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {
            //code all
        }


        private void panel1__MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

       

    }
}
