
namespace solution
{
    partial class addStudent
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
            this.stdpanel = new System.Windows.Forms.Panel();
            this.sub_gno = new System.Windows.Forms.NumericUpDown();
            this.g_no = new System.Windows.Forms.NumericUpDown();
            this.stdGenId = new System.Windows.Forms.Button();
            this.saveBtnStd = new System.Windows.Forms.Button();
            this.clearBtnStd = new System.Windows.Forms.Button();
            this.programme = new System.Windows.Forms.ComboBox();
            this.a_year = new System.Windows.Forms.TextBox();
            this.sub_gid = new System.Windows.Forms.TextBox();
            this.g_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stdpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sub_gno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g_no)).BeginInit();
            this.SuspendLayout();
            // 

            // stdpanel
            // 
            this.stdpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.stdpanel.Controls.Add(this.label1);
            this.stdpanel.Controls.Add(this.sub_gno);
            this.stdpanel.Controls.Add(this.g_no);
            this.stdpanel.Controls.Add(this.stdGenId);
            this.stdpanel.Controls.Add(this.saveBtnStd);
            this.stdpanel.Controls.Add(this.clearBtnStd);
            this.stdpanel.Controls.Add(this.programme);
            this.stdpanel.Controls.Add(this.a_year);
            this.stdpanel.Controls.Add(this.sub_gid);
            this.stdpanel.Controls.Add(this.g_id);
            this.stdpanel.Controls.Add(this.label7);
            this.stdpanel.Controls.Add(this.label6);
            this.stdpanel.Controls.Add(this.label5);
            this.stdpanel.Controls.Add(this.label4);
            this.stdpanel.Controls.Add(this.label3);
            this.stdpanel.Controls.Add(this.label2);
            this.stdpanel.Location = new System.Drawing.Point(12, 23);
            this.stdpanel.Name = "stdpanel";
            this.stdpanel.Size = new System.Drawing.Size(1172, 633);
            this.stdpanel.TabIndex = 0;

            // 
            // sub_gno
            // 
            this.sub_gno.Location = new System.Drawing.Point(409, 306);
            this.sub_gno.Name = "sub_gno";
            this.sub_gno.Size = new System.Drawing.Size(86, 32);
            this.sub_gno.TabIndex = 41;
            this.sub_gno.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // g_no
            // 
            this.g_no.Location = new System.Drawing.Point(409, 246);
            this.g_no.Name = "g_no";
            this.g_no.Size = new System.Drawing.Size(86, 32);
            this.g_no.TabIndex = 40;
            this.g_no.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // stdGenId
            // 
            this.stdGenId.BackColor = System.Drawing.Color.DarkOrange;
            this.stdGenId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stdGenId.ForeColor = System.Drawing.SystemColors.HighlightText;

            this.stdGenId.Location = new System.Drawing.Point(643, 242);

            this.stdGenId.Image = global::solution.Properties.Resources.generate;
            this.stdGenId.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stdGenId.Location = new System.Drawing.Point(648, 195);

            this.stdGenId.Name = "stdGenId";
            this.stdGenId.Size = new System.Drawing.Size(214, 44);
            this.stdGenId.TabIndex = 21;
            this.stdGenId.Text = "Generate Rank";
            this.stdGenId.UseVisualStyleBackColor = false;
            this.stdGenId.Click += new System.EventHandler(this.stdGenId_Click);
            // 
            // saveBtnStd
            // 
            this.saveBtnStd.BackColor = System.Drawing.Color.DodgerBlue;
            this.saveBtnStd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveBtnStd.ForeColor = System.Drawing.SystemColors.HighlightText;

            this.saveBtnStd.Location = new System.Drawing.Point(329, 412);

            this.saveBtnStd.Image = global::solution.Properties.Resources.save1;
            this.saveBtnStd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveBtnStd.Location = new System.Drawing.Point(325, 364);

            this.saveBtnStd.Name = "saveBtnStd";
            this.saveBtnStd.Size = new System.Drawing.Size(128, 44);
            this.saveBtnStd.TabIndex = 20;
            this.saveBtnStd.Text = "Save";
            this.saveBtnStd.UseVisualStyleBackColor = false;
            this.saveBtnStd.Click += new System.EventHandler(this.button3_Click);
            // 
            // clearBtnStd
            // 
            this.clearBtnStd.BackColor = System.Drawing.Color.DarkOrange;
            this.clearBtnStd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearBtnStd.ForeColor = System.Drawing.SystemColors.HighlightText;

            this.clearBtnStd.Location = new System.Drawing.Point(492, 412);

            this.clearBtnStd.Image = global::solution.Properties.Resources.clear;
            this.clearBtnStd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearBtnStd.Location = new System.Drawing.Point(487, 364);

            this.clearBtnStd.Name = "clearBtnStd";
            this.clearBtnStd.Size = new System.Drawing.Size(137, 44);
            this.clearBtnStd.TabIndex = 19;
            this.clearBtnStd.Text = "Clear";
            this.clearBtnStd.UseVisualStyleBackColor = false;
            this.clearBtnStd.Click += new System.EventHandler(this.clearBtnStd_Click);
            // 
            // programme
            // 
            this.programme.FormattingEnabled = true;
            this.programme.Items.AddRange(new object[] {
            "IT",
            "CS",
            "EG",
            "DS",
            "SE",
            "BS",
            "IM"});
            this.programme.Location = new System.Drawing.Point(316, 180);
            this.programme.Name = "programme";
            this.programme.Size = new System.Drawing.Size(194, 31);
            this.programme.TabIndex = 9;
            // 
            // a_year
            // 
            this.a_year.Location = new System.Drawing.Point(315, 118);
            this.a_year.Name = "a_year";
            this.a_year.Size = new System.Drawing.Size(195, 32);
            this.a_year.TabIndex = 8;
            this.a_year.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // sub_gid
            // 
            this.sub_gid.Location = new System.Drawing.Point(730, 165);
            this.sub_gid.Name = "sub_gid";
            this.sub_gid.Size = new System.Drawing.Size(195, 32);
            this.sub_gid.TabIndex = 7;
            // 
            // g_id
            // 
            this.g_id.Location = new System.Drawing.Point(730, 103);
            this.g_id.Name = "g_id";
            this.g_id.Size = new System.Drawing.Size(195, 32);
            this.g_id.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(563, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Sub Group ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(563, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Group ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(19, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Sub Group No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(19, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Group No";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Programme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Academic Year Semester";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(357, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Student Group";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1219, 799);
            this.Controls.Add(this.stdpanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "addStudent";
            this.Text = "addStudent";
            this.Load += new System.EventHandler(this.addStudent_Load_1);
            this.stdpanel.ResumeLayout(false);
            this.stdpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sub_gno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g_no)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel stdpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox programme;
        private System.Windows.Forms.TextBox a_year;
        private System.Windows.Forms.TextBox sub_gid;
        private System.Windows.Forms.TextBox g_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearBtnStd;
        private System.Windows.Forms.Button saveBtnStd;
        private System.Windows.Forms.Button stdGenId;
        private System.Windows.Forms.NumericUpDown sub_gno;
        private System.Windows.Forms.NumericUpDown g_no;
    }
}