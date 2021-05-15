
namespace solution
{
    partial class manageStudent
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
            this.stdGenId = new System.Windows.Forms.Button();
            this.sub_gno = new System.Windows.Forms.NumericUpDown();
            this.g_no = new System.Windows.Forms.NumericUpDown();
            this.textSearchBtn = new System.Windows.Forms.TextBox();
            this.sub_gid = new System.Windows.Forms.TextBox();
            this.g_id = new System.Windows.Forms.TextBox();
            this.programme = new System.Windows.Forms.ComboBox();
            this.a_year = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteBtnStd = new System.Windows.Forms.Button();
            this.clearBtnStdMan = new System.Windows.Forms.Button();
            this.UpdateBtnStd = new System.Windows.Forms.Button();
            this.SearchBtnStd = new System.Windows.Forms.Button();
            this.StudentdataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sub_gno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g_no)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.stdGenId);
            this.panel1.Controls.Add(this.sub_gno);
            this.panel1.Controls.Add(this.g_no);
            this.panel1.Controls.Add(this.textSearchBtn);
            this.panel1.Controls.Add(this.sub_gid);
            this.panel1.Controls.Add(this.g_id);
            this.panel1.Controls.Add(this.programme);
            this.panel1.Controls.Add(this.a_year);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.DeleteBtnStd);
            this.panel1.Controls.Add(this.clearBtnStdMan);
            this.panel1.Controls.Add(this.UpdateBtnStd);
            this.panel1.Controls.Add(this.SearchBtnStd);
            this.panel1.Controls.Add(this.StudentdataGridView);
            this.panel1.Location = new System.Drawing.Point(25, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 602);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // stdGenId
            // 
            this.stdGenId.BackColor = System.Drawing.Color.DarkOrange;
            this.stdGenId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stdGenId.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.stdGenId.Location = new System.Drawing.Point(682, 498);
            this.stdGenId.Name = "stdGenId";
            this.stdGenId.Size = new System.Drawing.Size(214, 44);
            this.stdGenId.TabIndex = 41;
            this.stdGenId.Text = "Generate Rank";
            this.stdGenId.UseVisualStyleBackColor = false;
            this.stdGenId.Click += new System.EventHandler(this.stdGenId_Click);
            // 
            // sub_gno
            // 
            this.sub_gno.Location = new System.Drawing.Point(402, 528);
            this.sub_gno.Name = "sub_gno";
            this.sub_gno.Size = new System.Drawing.Size(86, 37);
            this.sub_gno.TabIndex = 40;
            this.sub_gno.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // g_no
            // 
            this.g_no.Location = new System.Drawing.Point(402, 471);
            this.g_no.Name = "g_no";
            this.g_no.Size = new System.Drawing.Size(86, 37);
            this.g_no.TabIndex = 39;
            this.g_no.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textSearchBtn
            // 
            this.textSearchBtn.Location = new System.Drawing.Point(752, 50);
            this.textSearchBtn.Name = "textSearchBtn";
            this.textSearchBtn.Size = new System.Drawing.Size(231, 37);
            this.textSearchBtn.TabIndex = 38;
            this.textSearchBtn.TextChanged += new System.EventHandler(this.textSearchBtn_TextChanged);
            // 
            // sub_gid
            // 
            this.sub_gid.Location = new System.Drawing.Point(743, 419);
            this.sub_gid.Name = "sub_gid";
            this.sub_gid.Size = new System.Drawing.Size(141, 37);
            this.sub_gid.TabIndex = 37;
            this.sub_gid.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // g_id
            // 
            this.g_id.Location = new System.Drawing.Point(743, 346);
            this.g_id.Name = "g_id";
            this.g_id.Size = new System.Drawing.Size(141, 37);
            this.g_id.TabIndex = 36;
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
            this.programme.Location = new System.Drawing.Point(347, 412);
            this.programme.Name = "programme";
            this.programme.Size = new System.Drawing.Size(141, 38);
            this.programme.TabIndex = 33;
            this.programme.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // a_year
            // 
            this.a_year.Location = new System.Drawing.Point(347, 349);
            this.a_year.Name = "a_year";
            this.a_year.Size = new System.Drawing.Size(141, 37);
            this.a_year.TabIndex = 32;
            this.a_year.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(551, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 23);
            this.label7.TabIndex = 31;
            this.label7.Text = "Sub Group ID";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(68, 536);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "Sub Group No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(68, 479);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "Group No";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(68, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Programme";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(560, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Group ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(68, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Academic Year Semester";
            // 
            // DeleteBtnStd
            // 
            this.DeleteBtnStd.BackColor = System.Drawing.Color.Red;
            this.DeleteBtnStd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtnStd.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DeleteBtnStd.Location = new System.Drawing.Point(970, 397);
            this.DeleteBtnStd.Name = "DeleteBtnStd";
            this.DeleteBtnStd.Size = new System.Drawing.Size(137, 44);
            this.DeleteBtnStd.TabIndex = 25;
            this.DeleteBtnStd.Text = "Delete";
            this.DeleteBtnStd.UseVisualStyleBackColor = false;
            this.DeleteBtnStd.Click += new System.EventHandler(this.DeleteBtnStd_Click);
            // 
            // clearBtnStdMan
            // 
            this.clearBtnStdMan.BackColor = System.Drawing.Color.DarkOrange;
            this.clearBtnStdMan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearBtnStdMan.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.clearBtnStdMan.Location = new System.Drawing.Point(970, 347);
            this.clearBtnStdMan.Name = "clearBtnStdMan";
            this.clearBtnStdMan.Size = new System.Drawing.Size(137, 44);
            this.clearBtnStdMan.TabIndex = 24;
            this.clearBtnStdMan.Text = "Clear";
            this.clearBtnStdMan.UseVisualStyleBackColor = false;
            this.clearBtnStdMan.Click += new System.EventHandler(this.clearBtnStdMan_Click);
            // 
            // UpdateBtnStd
            // 
            this.UpdateBtnStd.BackColor = System.Drawing.Color.LimeGreen;
            this.UpdateBtnStd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateBtnStd.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.UpdateBtnStd.Location = new System.Drawing.Point(970, 449);
            this.UpdateBtnStd.Name = "UpdateBtnStd";
            this.UpdateBtnStd.Size = new System.Drawing.Size(137, 44);
            this.UpdateBtnStd.TabIndex = 23;
            this.UpdateBtnStd.Text = "Update";
            this.UpdateBtnStd.UseVisualStyleBackColor = false;
            this.UpdateBtnStd.Click += new System.EventHandler(this.UpdateBtnStd_Click);
            // 
            // SearchBtnStd
            // 
            this.SearchBtnStd.BackColor = System.Drawing.Color.DodgerBlue;
            this.SearchBtnStd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchBtnStd.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SearchBtnStd.Location = new System.Drawing.Point(1015, 46);
            this.SearchBtnStd.Name = "SearchBtnStd";
            this.SearchBtnStd.Size = new System.Drawing.Size(137, 44);
            this.SearchBtnStd.TabIndex = 22;
            this.SearchBtnStd.Text = "Search";
            this.SearchBtnStd.UseVisualStyleBackColor = false;
            this.SearchBtnStd.Click += new System.EventHandler(this.SearchBtnStd_Click);
            // 
            // StudentdataGridView
            // 
            this.StudentdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentdataGridView.Location = new System.Drawing.Point(28, 115);
            this.StudentdataGridView.Name = "StudentdataGridView";
            this.StudentdataGridView.RowHeadersWidth = 62;
            this.StudentdataGridView.RowTemplate.Height = 33;
            this.StudentdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentdataGridView.Size = new System.Drawing.Size(1124, 199);
            this.StudentdataGridView.TabIndex = 0;
            this.StudentdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentdataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(425, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Student Group";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // manageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1219, 799);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "manageStudent";
            this.Text = "manageStudent";
            this.Load += new System.EventHandler(this.manageStudent_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sub_gno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g_no)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView StudentdataGridView;
        private System.Windows.Forms.Button SearchBtnStd;
        private System.Windows.Forms.Button UpdateBtnStd;
        private System.Windows.Forms.Button clearBtnStdMan;
        private System.Windows.Forms.Button DeleteBtnStd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox a_year;
        private System.Windows.Forms.ComboBox programme;
        private System.Windows.Forms.TextBox sub_gid;
        private System.Windows.Forms.TextBox g_id;
        private System.Windows.Forms.TextBox textSearchBtn;
        private System.Windows.Forms.NumericUpDown sub_gno;
        private System.Windows.Forms.NumericUpDown g_no;
        private System.Windows.Forms.Button stdGenId;
    }
}