
namespace solution
{
    partial class selectLandgroup
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
            this.groupSubject = new System.Windows.Forms.Panel();

            this.label10 = new System.Windows.Forms.Label();

            this.sybjectname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.noofstudent = new System.Windows.Forms.TextBox();
            this.selectgroup = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.selectsubject = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.addnext = new System.Windows.Forms.Button();
            this.clearbtnsession = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.TextBox();

            this.label10 = new System.Windows.Forms.Label();

            this.groupSubject.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupSubject
            // 
            this.groupSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupSubject.Controls.Add(this.label10);
            this.groupSubject.Controls.Add(this.sybjectname);
            this.groupSubject.Controls.Add(this.label7);
            this.groupSubject.Controls.Add(this.noofstudent);
            this.groupSubject.Controls.Add(this.selectgroup);
            this.groupSubject.Controls.Add(this.label5);
            this.groupSubject.Controls.Add(this.label4);
            this.groupSubject.Controls.Add(this.selectsubject);
            this.groupSubject.Controls.Add(this.button1);
            this.groupSubject.Controls.Add(this.addnext);
            this.groupSubject.Controls.Add(this.clearbtnsession);
            this.groupSubject.Controls.Add(this.label3);
            this.groupSubject.Controls.Add(this.label1);
            this.groupSubject.Controls.Add(this.label6);
            this.groupSubject.Controls.Add(this.duration);
            this.groupSubject.Location = new System.Drawing.Point(3, 0);
            this.groupSubject.Name = "groupSubject";
            this.groupSubject.Size = new System.Drawing.Size(866, 349);
            this.groupSubject.TabIndex = 15;
            this.groupSubject.Paint += new System.Windows.Forms.PaintEventHandler(this.groupSubject_Paint);
            // 

            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(293, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(204, 35);
            this.label10.TabIndex = 41;
            this.label10.Text = "Add Session";
            // 

            // sybjectname
            // 
            this.sybjectname.Location = new System.Drawing.Point(259, 222);
            this.sybjectname.Name = "sybjectname";
            this.sybjectname.ReadOnly = true;
            this.sybjectname.Size = new System.Drawing.Size(142, 27);
            this.sybjectname.TabIndex = 40;
            this.sybjectname.TextChanged += new System.EventHandler(this.sybjectname_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(13, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 23);
            this.label7.TabIndex = 39;
            this.label7.Text = "Selected Subject Name";
            // 
            // noofstudent
            // 
            this.noofstudent.Location = new System.Drawing.Point(509, 102);
            this.noofstudent.Name = "noofstudent";
            this.noofstudent.Size = new System.Drawing.Size(142, 27);
            this.noofstudent.TabIndex = 35;
            // 
            // selectgroup
            // 
            this.selectgroup.FormattingEnabled = true;
            this.selectgroup.Location = new System.Drawing.Point(197, 97);
            this.selectgroup.Name = "selectgroup";
            this.selectgroup.Size = new System.Drawing.Size(128, 28);
            this.selectgroup.TabIndex = 34;
            //this.selectgroup.SelectedIndexChanged += new System.EventHandler(this.selectgroup_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(634, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "Hrs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(353, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "Duration";
            // 
            // selectsubject
            // 
            this.selectsubject.FormattingEnabled = true;
            this.selectsubject.Location = new System.Drawing.Point(197, 178);
            this.selectsubject.Name = "selectsubject";
            this.selectsubject.Size = new System.Drawing.Size(128, 28);
            this.selectsubject.TabIndex = 31;
            this.selectsubject.SelectedIndexChanged += new System.EventHandler(this.selectsubject_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;

          //  this.button1.Image = global::solution.Properties.Resources.back;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.button1.Location = new System.Drawing.Point(213, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 44);
            this.button1.TabIndex = 30;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addnext
            // 
            this.addnext.BackColor = System.Drawing.Color.DodgerBlue;
            this.addnext.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addnext.ForeColor = System.Drawing.SystemColors.HighlightText;

        //    this.addnext.Image = global::solution.Properties.Resources.next;
            this.addnext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.addnext.Location = new System.Drawing.Point(523, 261);
            this.addnext.Name = "addnext";
            this.addnext.Size = new System.Drawing.Size(128, 44);
            this.addnext.TabIndex = 29;
            this.addnext.Text = "Next";
            this.addnext.UseVisualStyleBackColor = false;
            this.addnext.Click += new System.EventHandler(this.addnext_Click);
            // 
            // clearbtnsession
            // 
            this.clearbtnsession.BackColor = System.Drawing.Color.DarkOrange;
            this.clearbtnsession.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearbtnsession.ForeColor = System.Drawing.SystemColors.HighlightText;
 //   this.clearbtnsession.Image = global::solution.Properties.Resources.clear;
            this.clearbtnsession.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.clearbtnsession.Location = new System.Drawing.Point(366, 260);
            this.clearbtnsession.Name = "clearbtnsession";
            this.clearbtnsession.Size = new System.Drawing.Size(137, 44);
            this.clearbtnsession.TabIndex = 28;
            this.clearbtnsession.Text = "Clear";
            this.clearbtnsession.UseVisualStyleBackColor = false;
           // this.clearbtnsession.Click += new System.EventHandler(this.clearbtnsession_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(354, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "No Of Students";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Selected Subject";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(17, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "Select Group";
            // 
            // duration
            // 
            this.duration.Location = new System.Drawing.Point(486, 179);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(142, 27);
            this.duration.TabIndex = 21;
            // 

            // selectLandgroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 639);
            this.Controls.Add(this.groupSubject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "selectLandgroup";
            this.Text = "selectLandgroup";
            this.Load += new System.EventHandler(this.selectLandgroup_Load);
            this.groupSubject.ResumeLayout(false);
            this.groupSubject.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel groupSubject;
        private System.Windows.Forms.TextBox noofstudent;
        private System.Windows.Forms.ComboBox selectgroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox selectsubject;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addnext;
        private System.Windows.Forms.Button clearbtnsession;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox duration;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sybjectname;
        private System.Windows.Forms.Label label10;
    }
}