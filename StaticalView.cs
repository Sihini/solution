using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace solution
{
    public partial class StaticalView : Form
    {
        public StaticalView()
        {
            InitializeComponent();
        }

        private void StaticalView_Load(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            
                openChildFormes(new RegisterLectureStac());
                openChildForms(new RegLecWhatsnew());

            
        }


        private Form activeForm = null;
        private Form activeForm1 = null;
        private void openChildFormes(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            StatView.Controls.Add(childForm);
            StatView.Tag = childForm;
            childForm.Show();

        }
        private void openChildForms(Form childForm)
        {
            if (activeForm1 != null)
                activeForm1.Close();
            activeForm1 = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            WhatsNew.Controls.Add(childForm);
            WhatsNew.Tag = childForm;
            childForm.Show();

        }

        private void WhatsNew_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildFormes(new RegisterStudentStac());
            openChildForms(new RegStuWhatsnew());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildFormes(new RegisterSubjectStac());
            openChildForms(new RegSubWhatsnew());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildFormes(new RegisterRoomsStac());
            openChildForms(new RegRoomWhatsnew());
        }
    }
}
