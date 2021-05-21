
namespace solution
{
    partial class SessionTimeAllocation1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.sessionTimeAllocationpanel = new System.Windows.Forms.Panel();
            this.timeAllocationsubpannel = new System.Windows.Forms.Panel();
            this.stNotAvailablebtn = new System.Windows.Forms.Button();
            this.stNonOverlappingbtn = new System.Windows.Forms.Button();
            this.stParallelbtn = new System.Windows.Forms.Button();
            this.stConsecutivebtn = new System.Windows.Forms.Button();
            this.sessionTimeAllocationpanel.SuspendLayout();
            this.SuspendLayout();
            // 
<<<<<<< HEAD
=======
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.sessionavalibale);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);

 
            this.panel1.Location = new System.Drawing.Point(75, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 438);

            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // sessionavalibale
            // 
            this.sessionavalibale.Controls.Add(this.timesessionnot);
            this.sessionavalibale.Controls.Add(this.selectsessionID);
            this.sessionavalibale.Controls.Add(this.selectGroupsubsesesion);
            this.sessionavalibale.Controls.Add(this.selectgroupsession);
            this.sessionavalibale.Controls.Add(this.selectLecturersession);
            this.sessionavalibale.Controls.Add(this.label6);
            this.sessionavalibale.Controls.Add(this.label5);
            this.sessionavalibale.Controls.Add(this.label1);
            this.sessionavalibale.Controls.Add(this.sessionviewnotavi);
            this.sessionavalibale.Controls.Add(this.button1);
            this.sessionavalibale.Controls.Add(this.wdClear);
            this.sessionavalibale.Controls.Add(this.label4);
            this.sessionavalibale.Controls.Add(this.label3);
            this.sessionavalibale.Controls.Add(this.label2);

            this.sessionavalibale.Location = new System.Drawing.Point(2, 49);
            this.sessionavalibale.Name = "sessionavalibale";
            this.sessionavalibale.Size = new System.Drawing.Size(788, 379);
            this.sessionavalibale.TabIndex = 29;
            // 
            // timesessionnot
            // 
            this.timesessionnot.Location = new System.Drawing.Point(594, 163);
            this.timesessionnot.Name = "timesessionnot";
            this.timesessionnot.Size = new System.Drawing.Size(185, 27);

            this.timesessionnot.TabIndex = 50;
            // 
            // selectsessionID
            // 
            this.selectsessionID.FormattingEnabled = true;

            this.selectsessionID.Location = new System.Drawing.Point(594, 96);
            this.selectsessionID.Name = "selectsessionID";
            this.selectsessionID.Size = new System.Drawing.Size(185, 28);

            this.selectsessionID.TabIndex = 49;
            // 
            // selectGroupsubsesesion
            // 
            this.selectGroupsubsesesion.FormattingEnabled = true;

            this.selectGroupsubsesesion.Location = new System.Drawing.Point(194, 236);
            this.selectGroupsubsesesion.Name = "selectGroupsubsesesion";
            this.selectGroupsubsesesion.Size = new System.Drawing.Size(185, 28);

            this.selectGroupsubsesesion.TabIndex = 48;
            // 
            // selectgroupsession
            // 
            this.selectgroupsession.FormattingEnabled = true;

            this.selectgroupsession.Location = new System.Drawing.Point(194, 166);
            this.selectgroupsession.Name = "selectgroupsession";
            this.selectgroupsession.Size = new System.Drawing.Size(185, 28);

            this.selectgroupsession.TabIndex = 47;
            this.selectgroupsession.SelectedIndexChanged += new System.EventHandler(this.selectGroupsesion_SelectedIndexChanged);
            // 
            // selectLecturersession
            // 
            this.selectLecturersession.FormattingEnabled = true;

            this.selectLecturersession.Location = new System.Drawing.Point(194, 96);
            this.selectLecturersession.Name = "selectLecturersession";
            this.selectLecturersession.Size = new System.Drawing.Size(185, 28);

            this.selectLecturersession.TabIndex = 46;
            this.selectLecturersession.SelectedIndexChanged += new System.EventHandler(this.selectLecturersession_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;

            this.label6.Location = new System.Drawing.Point(14, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(294, 21);

            this.label6.TabIndex = 45;
            this.label6.Text = "Lecturers, Groups and Sub Groups";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;

            this.label5.Location = new System.Drawing.Point(424, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 23);

            this.label5.TabIndex = 44;
            this.label5.Text = "Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;

            this.label1.Location = new System.Drawing.Point(424, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 23);

            this.label1.TabIndex = 43;
            this.label1.Text = "Select Session ID";
            // 
            // sessionviewnotavi
            // 
            this.sessionviewnotavi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(159)))), ((int)(((byte)(2)))));
            this.sessionviewnotavi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sessionviewnotavi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sessionviewnotavi.ForeColor = System.Drawing.Color.White;

            this.sessionviewnotavi.Location = new System.Drawing.Point(517, 313);
            this.sessionviewnotavi.Name = "sessionviewnotavi";
            this.sessionviewnotavi.Size = new System.Drawing.Size(110, 35);

            this.sessionviewnotavi.TabIndex = 42;
            this.sessionviewnotavi.Text = "View";
            this.sessionviewnotavi.UseVisualStyleBackColor = false;
            this.sessionviewnotavi.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;

            this.button1.Location = new System.Drawing.Point(383, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 35);

            this.button1.TabIndex = 41;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // wdClear
            // 
            this.wdClear.BackColor = System.Drawing.Color.Maroon;
            this.wdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.wdClear.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wdClear.ForeColor = System.Drawing.Color.White;

            this.wdClear.Location = new System.Drawing.Point(651, 313);
            this.wdClear.Name = "wdClear";
            this.wdClear.Size = new System.Drawing.Size(110, 35);

            this.wdClear.TabIndex = 40;
            this.wdClear.Text = "Clear";
            this.wdClear.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;

            this.label4.Location = new System.Drawing.Point(14, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 23);

            this.label4.TabIndex = 39;
            this.label4.Text = "Select Sub Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;

            this.label3.Location = new System.Drawing.Point(14, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);

            this.label3.TabIndex = 38;
            this.label3.Text = "Select Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;

            this.label2.Location = new System.Drawing.Point(14, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 23);

            this.label2.TabIndex = 37;
            this.label2.Text = "Select Lecturer";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);

            this.button6.Location = new System.Drawing.Point(349, 1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(171, 29);

            this.button6.TabIndex = 28;
            this.button6.Text = "Not Available Times";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);

            this.button5.Location = new System.Drawing.Point(198, 1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(149, 29);
            this.button5.TabIndex = 27;
            this.button5.Text = "Non Overlapping";
            this.button5.UseVisualStyleBackColor = false;

            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);

            this.button4.Location = new System.Drawing.Point(116, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 29);

            this.button4.TabIndex = 26;
            this.button4.Text = "Parallel";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(1, 1);

            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 29);
            this.button3.TabIndex = 25;
            this.button3.Text = "Consecutive";
            this.button3.UseVisualStyleBackColor = false;

            // 
>>>>>>> faa6b63ee8cb3e42e00707fe6d559ce084c16c29
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;

            this.label7.Location = new System.Drawing.Point(120, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(708, 35);

            this.label7.TabIndex = 3;
            this.label7.Text = "Sessions and Not Available Time Allocations";
            // 
            // sessionTimeAllocationpanel
            // 
            this.sessionTimeAllocationpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sessionTimeAllocationpanel.Controls.Add(this.stNotAvailablebtn);
            this.sessionTimeAllocationpanel.Controls.Add(this.timeAllocationsubpannel);
            this.sessionTimeAllocationpanel.Controls.Add(this.stNonOverlappingbtn);
            this.sessionTimeAllocationpanel.Controls.Add(this.stParallelbtn);
            this.sessionTimeAllocationpanel.Controls.Add(this.stConsecutivebtn);
            this.sessionTimeAllocationpanel.Location = new System.Drawing.Point(82, 164);
            this.sessionTimeAllocationpanel.Name = "sessionTimeAllocationpanel";
            this.sessionTimeAllocationpanel.Size = new System.Drawing.Size(794, 438);
            this.sessionTimeAllocationpanel.TabIndex = 30;
            // 
            // timeAllocationsubpannel
            // 
            this.timeAllocationsubpannel.Location = new System.Drawing.Point(12, 56);
            this.timeAllocationsubpannel.Name = "timeAllocationsubpannel";
            this.timeAllocationsubpannel.Size = new System.Drawing.Size(770, 359);
            this.timeAllocationsubpannel.TabIndex = 29;
            this.timeAllocationsubpannel.Paint += new System.Windows.Forms.PaintEventHandler(this.timeAllocationsubpannel_Paint);
            // 
            // stNotAvailablebtn
            // 
            this.stNotAvailablebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.stNotAvailablebtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stNotAvailablebtn.Location = new System.Drawing.Point(353, 4);
            this.stNotAvailablebtn.Name = "stNotAvailablebtn";
            this.stNotAvailablebtn.Size = new System.Drawing.Size(171, 29);
            this.stNotAvailablebtn.TabIndex = 32;
            this.stNotAvailablebtn.Text = "Not Available Times";
            this.stNotAvailablebtn.UseVisualStyleBackColor = false;
            this.stNotAvailablebtn.Click += new System.EventHandler(this.stNotAvailablebtn_Click_1);
            // 
            // stNonOverlappingbtn
            // 
            this.stNonOverlappingbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.stNonOverlappingbtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stNonOverlappingbtn.Location = new System.Drawing.Point(202, 4);
            this.stNonOverlappingbtn.Name = "stNonOverlappingbtn";
            this.stNonOverlappingbtn.Size = new System.Drawing.Size(149, 29);
            this.stNonOverlappingbtn.TabIndex = 31;
            this.stNonOverlappingbtn.Text = "Non Overlapping";
            this.stNonOverlappingbtn.UseVisualStyleBackColor = false;
            // 
            // stParallelbtn
            // 
            this.stParallelbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.stParallelbtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stParallelbtn.Location = new System.Drawing.Point(120, 4);
            this.stParallelbtn.Name = "stParallelbtn";
            this.stParallelbtn.Size = new System.Drawing.Size(80, 29);
            this.stParallelbtn.TabIndex = 30;
            this.stParallelbtn.Text = "Parallel";
            this.stParallelbtn.UseVisualStyleBackColor = false;
            // 
            // stConsecutivebtn
            // 
            this.stConsecutivebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.stConsecutivebtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stConsecutivebtn.Location = new System.Drawing.Point(5, 4);
            this.stConsecutivebtn.Name = "stConsecutivebtn";
            this.stConsecutivebtn.Size = new System.Drawing.Size(112, 29);
            this.stConsecutivebtn.TabIndex = 29;
            this.stConsecutivebtn.Text = "Consecutive";
            this.stConsecutivebtn.UseVisualStyleBackColor = false;
            // 
            // SessionTimeAllocation1
            // 

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 639);
            this.Controls.Add(this.sessionTimeAllocationpanel);
            this.Controls.Add(this.label7);
<<<<<<< HEAD
=======
            this.Controls.Add(this.panel1);

>>>>>>> faa6b63ee8cb3e42e00707fe6d559ce084c16c29
            this.Name = "SessionTimeAllocation1";
            this.Text = "SessionTimeAllocation1";
            this.Load += new System.EventHandler(this.SessionTimeAllocation1_Load);
            this.sessionTimeAllocationpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel sessionTime;
        private System.Windows.Forms.Panel sessionTimeAllocationpanel;
        private System.Windows.Forms.Panel timeAllocationsubpannel;
        private System.Windows.Forms.Button stNotAvailablebtn;
        private System.Windows.Forms.Button stNonOverlappingbtn;
        private System.Windows.Forms.Button stParallelbtn;
        private System.Windows.Forms.Button stConsecutivebtn;
    }
}