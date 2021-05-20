
namespace solution
{
    partial class managesessionnew
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.selectviewsession = new System.Windows.Forms.Button();
            this.selectdelete = new System.Windows.Forms.Button();
            this.selectclear = new System.Windows.Forms.Button();
            this.selectupdate = new System.Windows.Forms.Button();
            this.sybjectname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.noofstudent = new System.Windows.Forms.TextBox();
            this.selectgroup = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.selectsubject = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.TextBox();
            this.selecttags = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.selettextlect = new System.Windows.Forms.TextBox();
            this.selectLecturer = new System.Windows.Forms.ComboBox();
            this.selectlecgropsear = new System.Windows.Forms.TextBox();
            this.selectsession = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectsession)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.selectviewsession);
            this.panel1.Controls.Add(this.selectdelete);
            this.panel1.Controls.Add(this.selectclear);
            this.panel1.Controls.Add(this.selectupdate);
            this.panel1.Controls.Add(this.sybjectname);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.noofstudent);
            this.panel1.Controls.Add(this.selectgroup);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.selectsubject);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.duration);
            this.panel1.Controls.Add(this.selecttags);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.selettextlect);
            this.panel1.Controls.Add(this.selectLecturer);
            this.panel1.Controls.Add(this.selectlecgropsear);
            this.panel1.Controls.Add(this.selectsession);
            this.panel1.Location = new System.Drawing.Point(4, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 583);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(221, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(262, 35);
            this.label10.TabIndex = 2;
            this.label10.Text = "Manage Session";
            // 
            // selectviewsession
            // 
            this.selectviewsession.BackColor = System.Drawing.Color.RoyalBlue;
            this.selectviewsession.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectviewsession.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.selectviewsession.Image = global::solution.Properties.Resources.view;
            this.selectviewsession.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectviewsession.Location = new System.Drawing.Point(799, 516);
            this.selectviewsession.Name = "selectviewsession";
            this.selectviewsession.Size = new System.Drawing.Size(137, 44);
            this.selectviewsession.TabIndex = 59;
            this.selectviewsession.Text = "View";
            this.selectviewsession.UseVisualStyleBackColor = false;
            this.selectviewsession.Click += new System.EventHandler(this.selectviewsession_Click);
            // 
            // selectdelete
            // 
            this.selectdelete.BackColor = System.Drawing.Color.Red;
            this.selectdelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectdelete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.selectdelete.Image = global::solution.Properties.Resources.delete;
            this.selectdelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectdelete.Location = new System.Drawing.Point(799, 459);
            this.selectdelete.Name = "selectdelete";
            this.selectdelete.Size = new System.Drawing.Size(137, 44);
            this.selectdelete.TabIndex = 58;
            this.selectdelete.Text = "Delete";
            this.selectdelete.UseVisualStyleBackColor = false;
            this.selectdelete.Click += new System.EventHandler(this.selectdelete_Click);
            // 
            // selectclear
            // 
            this.selectclear.BackColor = System.Drawing.Color.DarkOrange;
            this.selectclear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectclear.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.selectclear.Image = global::solution.Properties.Resources.clear;
            this.selectclear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectclear.Location = new System.Drawing.Point(799, 390);
            this.selectclear.Name = "selectclear";
            this.selectclear.Size = new System.Drawing.Size(137, 44);
            this.selectclear.TabIndex = 57;
            this.selectclear.Text = "Clear";
            this.selectclear.UseVisualStyleBackColor = false;
            this.selectclear.Click += new System.EventHandler(this.selectclear_Click);
            // 
            // selectupdate
            // 
            this.selectupdate.BackColor = System.Drawing.Color.LimeGreen;
            this.selectupdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectupdate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.selectupdate.Image = global::solution.Properties.Resources.update;
            this.selectupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectupdate.Location = new System.Drawing.Point(799, 326);
            this.selectupdate.Name = "selectupdate";
            this.selectupdate.Size = new System.Drawing.Size(137, 44);
            this.selectupdate.TabIndex = 56;
            this.selectupdate.Text = "Update";
            this.selectupdate.UseVisualStyleBackColor = false;
            this.selectupdate.Click += new System.EventHandler(this.selectupdate_Click);
            // 
            // sybjectname
            // 
            this.sybjectname.Location = new System.Drawing.Point(300, 533);
            this.sybjectname.Name = "sybjectname";
            this.sybjectname.Size = new System.Drawing.Size(142, 27);
            this.sybjectname.TabIndex = 55;
            this.sybjectname.TextChanged += new System.EventHandler(this.sybjectname_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(54, 537);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 23);
            this.label7.TabIndex = 54;
            this.label7.Text = "Selected Subject Name";
            // 
            // noofstudent
            // 
            this.noofstudent.Location = new System.Drawing.Point(606, 401);
            this.noofstudent.Name = "noofstudent";
            this.noofstudent.Size = new System.Drawing.Size(142, 27);
            this.noofstudent.TabIndex = 53;
            // 
            // selectgroup
            // 
            this.selectgroup.FormattingEnabled = true;
            this.selectgroup.Location = new System.Drawing.Point(235, 401);
            this.selectgroup.Name = "selectgroup";
            this.selectgroup.Size = new System.Drawing.Size(128, 28);
            this.selectgroup.TabIndex = 52;
            this.selectgroup.SelectedIndexChanged += new System.EventHandler(this.selectgroup_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(383, 496);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 23);
            this.label5.TabIndex = 51;
            this.label5.Text = "Hrs";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(54, 496);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 50;
            this.label4.Text = "Duration";
            // 
            // selectsubject
            // 
            this.selectsubject.FormattingEnabled = true;
            this.selectsubject.Location = new System.Drawing.Point(235, 450);
            this.selectsubject.Name = "selectsubject";
            this.selectsubject.Size = new System.Drawing.Size(128, 28);
            this.selectsubject.TabIndex = 49;
            this.selectsubject.SelectedIndexChanged += new System.EventHandler(this.selectsubject_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(446, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 23);
            this.label2.TabIndex = 48;
            this.label2.Text = "No Of Students";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(54, 455);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 23);
            this.label8.TabIndex = 47;
            this.label8.Text = "Selected Subject";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(54, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 23);
            this.label9.TabIndex = 46;
            this.label9.Text = "Select Group";
            // 
            // duration
            // 
            this.duration.Location = new System.Drawing.Point(235, 494);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(142, 27);
            this.duration.TabIndex = 45;
            // 
            // selecttags
            // 
            this.selecttags.FormattingEnabled = true;
            this.selecttags.Location = new System.Drawing.Point(586, 297);
            this.selecttags.Name = "selecttags";
            this.selecttags.Size = new System.Drawing.Size(173, 28);
            this.selecttags.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(448, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 23);
            this.label3.TabIndex = 43;
            this.label3.Text = "Select Tag";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(53, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 23);
            this.label1.TabIndex = 42;
            this.label1.Text = "Selected Lecturer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(54, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 23);
            this.label6.TabIndex = 41;
            this.label6.Text = "Select Lecturer";
            // 
            // selettextlect
            // 
            this.selettextlect.Location = new System.Drawing.Point(235, 352);
            this.selettextlect.Name = "selettextlect";
            this.selettextlect.Size = new System.Drawing.Size(336, 27);
            this.selettextlect.TabIndex = 40;
            // 
            // selectLecturer
            // 
            this.selectLecturer.FormattingEnabled = true;
            this.selectLecturer.Location = new System.Drawing.Point(235, 296);
            this.selectLecturer.Name = "selectLecturer";
            this.selectLecturer.Size = new System.Drawing.Size(173, 28);
            this.selectLecturer.TabIndex = 39;
            this.selectLecturer.SelectedIndexChanged += new System.EventHandler(this.selectLecturer_SelectedIndexChanged);
            // 
            // selectlecgropsear
            // 
            this.selectlecgropsear.Location = new System.Drawing.Point(537, 46);
            this.selectlecgropsear.Name = "selectlecgropsear";
            this.selectlecgropsear.PlaceholderText = "Search";
            this.selectlecgropsear.Size = new System.Drawing.Size(378, 27);
            this.selectlecgropsear.TabIndex = 38;
            this.selectlecgropsear.TextChanged += new System.EventHandler(this.selectlecgropsear_TextChanged);
            // 
            // selectsession
            // 
            this.selectsession.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectsession.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.selectsession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectsession.Location = new System.Drawing.Point(1, 103);
            this.selectsession.Name = "selectsession";
            this.selectsession.RowHeadersWidth = 62;
            this.selectsession.RowTemplate.Height = 33;
            this.selectsession.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.selectsession.Size = new System.Drawing.Size(927, 159);
            this.selectsession.TabIndex = 0;
            this.selectsession.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectsession_CellContentClick);
            // 
            // managesessionnew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 679);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "managesessionnew";
            this.Text = "managesessionnew";
            this.Load += new System.EventHandler(this.managesessionnew_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectsession)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox selectlecgropsear;
        private System.Windows.Forms.DataGridView selectsession;
        private System.Windows.Forms.ComboBox selecttags;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox selettextlect;
        private System.Windows.Forms.ComboBox selectLecturer;
        private System.Windows.Forms.TextBox sybjectname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox noofstudent;
        private System.Windows.Forms.ComboBox selectgroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox selectsubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox duration;
        private System.Windows.Forms.Button selectdelete;
        private System.Windows.Forms.Button selectclear;
        private System.Windows.Forms.Button selectupdate;
        private System.Windows.Forms.Button selectviewsession;
        private System.Windows.Forms.Label label10;
    }
}