
namespace solution
{
    partial class ManageSessionRooms
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
<<<<<<< HEAD
            this.stNotAvailablebtn = new System.Windows.Forms.Button();
            this.stNonOverlappingbtn = new System.Windows.Forms.Button();
            this.stConsecutivebtn = new System.Windows.Forms.Button();
            this.sessionTimeAllocationpanel = new System.Windows.Forms.Panel();
            this.notAvailableTimepanel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.sessionTimeAllocationpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // stNotAvailablebtn
            // 
            this.stNotAvailablebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.stNotAvailablebtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stNotAvailablebtn.Location = new System.Drawing.Point(210, 1);
            this.stNotAvailablebtn.Name = "stNotAvailablebtn";
            this.stNotAvailablebtn.Size = new System.Drawing.Size(171, 29);
            this.stNotAvailablebtn.TabIndex = 28;
            this.stNotAvailablebtn.Text = "Not Available Times";
            this.stNotAvailablebtn.UseVisualStyleBackColor = false;
            // 
            // stNonOverlappingbtn
            // 
            this.stNonOverlappingbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.stNonOverlappingbtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stNonOverlappingbtn.Location = new System.Drawing.Point(0, 0);
            this.stNonOverlappingbtn.Name = "stNonOverlappingbtn";
            this.stNonOverlappingbtn.Size = new System.Drawing.Size(92, 29);
            this.stNonOverlappingbtn.TabIndex = 27;
            this.stNonOverlappingbtn.Text = "Sessions";
            this.stNonOverlappingbtn.UseVisualStyleBackColor = false;
            // 
            // stConsecutivebtn
            // 
            this.stConsecutivebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.stConsecutivebtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stConsecutivebtn.Location = new System.Drawing.Point(95, 1);
            this.stConsecutivebtn.Name = "stConsecutivebtn";
            this.stConsecutivebtn.Size = new System.Drawing.Size(112, 29);
            this.stConsecutivebtn.TabIndex = 25;
            this.stConsecutivebtn.Text = "Consecutive";
            this.stConsecutivebtn.UseVisualStyleBackColor = false;
            // 
            // sessionTimeAllocationpanel
            // 
            this.sessionTimeAllocationpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sessionTimeAllocationpanel.Controls.Add(this.stConsecutivebtn);
            this.sessionTimeAllocationpanel.Controls.Add(this.notAvailableTimepanel3);
            this.sessionTimeAllocationpanel.Controls.Add(this.stNotAvailablebtn);
            this.sessionTimeAllocationpanel.Controls.Add(this.stNonOverlappingbtn);
            this.sessionTimeAllocationpanel.Location = new System.Drawing.Point(90, 145);
            this.sessionTimeAllocationpanel.Name = "sessionTimeAllocationpanel";
            this.sessionTimeAllocationpanel.Size = new System.Drawing.Size(794, 438);
            this.sessionTimeAllocationpanel.TabIndex = 32;
            // 
            // notAvailableTimepanel3
            // 
            this.notAvailableTimepanel3.Location = new System.Drawing.Point(3, 30);
            this.notAvailableTimepanel3.Name = "notAvailableTimepanel3";
            this.notAvailableTimepanel3.Size = new System.Drawing.Size(788, 379);
            this.notAvailableTimepanel3.TabIndex = 30;
=======
            this.panelMSR = new System.Windows.Forms.Panel();
            this.panelMSRIN = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Box8 = new System.Windows.Forms.TextBox();
            this.Box7 = new System.Windows.Forms.TextBox();
            this.Box6 = new System.Windows.Forms.TextBox();
            this.Box5 = new System.Windows.Forms.TextBox();
            this.Box4 = new System.Windows.Forms.TextBox();
            this.Box3 = new System.Windows.Forms.TextBox();
            this.Box2 = new System.Windows.Forms.TextBox();
            this.Box1 = new System.Windows.Forms.TextBox();
            this.btnclearMSR = new System.Windows.Forms.Button();
            this.btnsaveMSR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.selectroom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectsession = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelMSR.SuspendLayout();
            this.panelMSRIN.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMSR
            // 
            this.panelMSR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelMSR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMSR.Controls.Add(this.panelMSRIN);
            this.panelMSR.Location = new System.Drawing.Point(12, 88);
            this.panelMSR.Name = "panelMSR";
            this.panelMSR.Size = new System.Drawing.Size(934, 388);
            this.panelMSR.TabIndex = 0;
            this.panelMSR.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelMSRIN
            // 
            this.panelMSRIN.Controls.Add(this.label12);
            this.panelMSRIN.Controls.Add(this.label11);
            this.panelMSRIN.Controls.Add(this.label9);
            this.panelMSRIN.Controls.Add(this.label8);
            this.panelMSRIN.Controls.Add(this.label7);
            this.panelMSRIN.Controls.Add(this.label6);
            this.panelMSRIN.Controls.Add(this.label5);
            this.panelMSRIN.Controls.Add(this.label4);
            this.panelMSRIN.Controls.Add(this.Box8);
            this.panelMSRIN.Controls.Add(this.Box7);
            this.panelMSRIN.Controls.Add(this.Box6);
            this.panelMSRIN.Controls.Add(this.Box5);
            this.panelMSRIN.Controls.Add(this.Box4);
            this.panelMSRIN.Controls.Add(this.Box3);
            this.panelMSRIN.Controls.Add(this.Box2);
            this.panelMSRIN.Controls.Add(this.Box1);
            this.panelMSRIN.Controls.Add(this.btnclearMSR);
            this.panelMSRIN.Controls.Add(this.btnsaveMSR);
            this.panelMSRIN.Controls.Add(this.label3);
            this.panelMSRIN.Controls.Add(this.selectroom);
            this.panelMSRIN.Controls.Add(this.label2);
            this.panelMSRIN.Controls.Add(this.selectsession);
            this.panelMSRIN.Controls.Add(this.label1);
            this.panelMSRIN.Location = new System.Drawing.Point(-1, -1);
            this.panelMSRIN.Name = "panelMSRIN";
            this.panelMSRIN.Size = new System.Drawing.Size(934, 388);
            this.panelMSRIN.TabIndex = 0;
            this.panelMSRIN.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMSRIN_Paint);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(820, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 15);
            this.label12.TabIndex = 118;
            this.label12.Text = "Selected Duration";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(726, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 15);
            this.label11.TabIndex = 117;
            this.label11.Text = "No Of Students";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(636, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 15);
            this.label9.TabIndex = 116;
            this.label9.Text = "Subject Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(549, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 15);
            this.label8.TabIndex = 115;
            this.label8.Text = "Subject Code";
>>>>>>> faa6b63ee8cb3e42e00707fe6d559ce084c16c29
            // 
            // label7
            // 
            this.label7.AutoSize = true;
<<<<<<< HEAD
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(390, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 35);
            this.label7.TabIndex = 33;
            this.label7.Text = "Add Location";
            // 
            // ManageSessionRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 639);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sessionTimeAllocationpanel);
            this.Name = "ManageSessionRooms";
            this.Text = "ManageSessionRooms";
            this.Load += new System.EventHandler(this.ManageSessionRooms_Load);
            this.sessionTimeAllocationpanel.ResumeLayout(false);
=======
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(456, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 114;
            this.label7.Text = "Selected Group";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(360, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 113;
            this.label6.Text = "Selected Tag";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(255, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 112;
            this.label5.Text = "Selected Lecture";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(156, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 111;
            this.label4.Text = "Selected Lecture";
            // 
            // Box8
            // 
            this.Box8.Location = new System.Drawing.Point(819, 187);
            this.Box8.Name = "Box8";
            this.Box8.Size = new System.Drawing.Size(93, 23);
            this.Box8.TabIndex = 110;
            // 
            // Box7
            // 
            this.Box7.Location = new System.Drawing.Point(726, 187);
            this.Box7.Name = "Box7";
            this.Box7.Size = new System.Drawing.Size(96, 23);
            this.Box7.TabIndex = 109;
            // 
            // Box6
            // 
            this.Box6.Location = new System.Drawing.Point(636, 187);
            this.Box6.Name = "Box6";
            this.Box6.Size = new System.Drawing.Size(95, 23);
            this.Box6.TabIndex = 108;
            // 
            // Box5
            // 
            this.Box5.Location = new System.Drawing.Point(548, 187);
            this.Box5.Name = "Box5";
            this.Box5.Size = new System.Drawing.Size(93, 23);
            this.Box5.TabIndex = 107;
            // 
            // Box4
            // 
            this.Box4.Location = new System.Drawing.Point(456, 187);
            this.Box4.Name = "Box4";
            this.Box4.Size = new System.Drawing.Size(101, 23);
            this.Box4.TabIndex = 106;
            // 
            // Box3
            // 
            this.Box3.Location = new System.Drawing.Point(360, 187);
            this.Box3.Name = "Box3";
            this.Box3.Size = new System.Drawing.Size(97, 23);
            this.Box3.TabIndex = 105;
            // 
            // Box2
            // 
            this.Box2.Location = new System.Drawing.Point(255, 187);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(109, 23);
            this.Box2.TabIndex = 104;
            // 
            // Box1
            // 
            this.Box1.Location = new System.Drawing.Point(156, 187);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(108, 23);
            this.Box1.TabIndex = 103;
            this.Box1.TextChanged += new System.EventHandler(this.Box1_TextChanged);
            // 
            // btnclearMSR
            // 
            this.btnclearMSR.BackColor = System.Drawing.Color.DarkOrange;
            this.btnclearMSR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnclearMSR.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnclearMSR.Location = new System.Drawing.Point(580, 290);
            this.btnclearMSR.Name = "btnclearMSR";
            this.btnclearMSR.Size = new System.Drawing.Size(137, 44);
            this.btnclearMSR.TabIndex = 102;
            this.btnclearMSR.Text = "Clear";
            this.btnclearMSR.UseVisualStyleBackColor = false;
            this.btnclearMSR.Click += new System.EventHandler(this.btnclearMSR_Click);
            // 
            // btnsaveMSR
            // 
            this.btnsaveMSR.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnsaveMSR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsaveMSR.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnsaveMSR.Location = new System.Drawing.Point(766, 290);
            this.btnsaveMSR.Name = "btnsaveMSR";
            this.btnsaveMSR.Size = new System.Drawing.Size(128, 44);
            this.btnsaveMSR.TabIndex = 101;
            this.btnsaveMSR.Text = "Save";
            this.btnsaveMSR.UseVisualStyleBackColor = false;
            this.btnsaveMSR.Click += new System.EventHandler(this.btnsaveMSR_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(9, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 19);
            this.label3.TabIndex = 100;
            this.label3.Text = "Selected Session";
            // 
            // selectroom
            // 
            this.selectroom.FormattingEnabled = true;
            this.selectroom.Location = new System.Drawing.Point(156, 77);
            this.selectroom.Name = "selectroom";
            this.selectroom.Size = new System.Drawing.Size(173, 23);
            this.selectroom.TabIndex = 99;
            this.selectroom.SelectedIndexChanged += new System.EventHandler(this.selectroom_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 98;
            this.label2.Text = "Select Room";
            // 
            // selectsession
            // 
            this.selectsession.FormattingEnabled = true;
            this.selectsession.Location = new System.Drawing.Point(156, 15);
            this.selectsession.Name = "selectsession";
            this.selectsession.Size = new System.Drawing.Size(173, 23);
            this.selectsession.TabIndex = 97;
            this.selectsession.SelectedIndexChanged += new System.EventHandler(this.selectsession_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 96;
            this.label1.Text = "Select Session";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(308, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(305, 30);
            this.label10.TabIndex = 2;
            this.label10.Text = "Manage Session Rooms";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // ManageSessionRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 500);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panelMSR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ManageSessionRooms";
            this.Text = "ManageSessionRooms";
            this.Load += new System.EventHandler(this.ManageSessionRooms_Load);
            this.panelMSR.ResumeLayout(false);
            this.panelMSRIN.ResumeLayout(false);
            this.panelMSRIN.PerformLayout();
>>>>>>> faa6b63ee8cb3e42e00707fe6d559ce084c16c29
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.Button stNotAvailablebtn;
        private System.Windows.Forms.Button stNonOverlappingbtn;
        private System.Windows.Forms.Button stConsecutivebtn;
        private System.Windows.Forms.Panel sessionTimeAllocationpanel;
        private System.Windows.Forms.Panel notAvailableTimepanel3;
        private System.Windows.Forms.Label label7;
=======
        private System.Windows.Forms.Panel panelMSR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TreeView selectsessiondata;
        private System.Windows.Forms.Panel panelMSRIN;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Box8;
        private System.Windows.Forms.TextBox Box7;
        private System.Windows.Forms.TextBox Box6;
        private System.Windows.Forms.TextBox Box5;
        private System.Windows.Forms.TextBox Box4;
        private System.Windows.Forms.TextBox Box3;
        private System.Windows.Forms.TextBox Box2;
        private System.Windows.Forms.TextBox Box1;
        private System.Windows.Forms.Button btnclearMSR;
        private System.Windows.Forms.Button btnsaveMSR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox selectroom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox selectsession;
        private System.Windows.Forms.Label label1;
>>>>>>> faa6b63ee8cb3e42e00707fe6d559ce084c16c29
    }
}