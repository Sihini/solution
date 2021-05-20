
namespace solution
{
    partial class manageSubjects
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
            this.txtsearchsubjectmanage1 = new System.Windows.Forms.TextBox();
            this.deleteSubjectbtn = new System.Windows.Forms.Button();
            this.clearSubjctbtn = new System.Windows.Forms.Button();
            this.manageSubjectbtn = new System.Windows.Forms.Button();
            this.managesubjectview = new System.Windows.Forms.DataGridView();
            this.addsubjectradiobtn2 = new System.Windows.Forms.RadioButton();
            this.addsubjectradiobtn1 = new System.Windows.Forms.RadioButton();
            this.txtnoOfEvelphour = new System.Windows.Forms.NumericUpDown();
            this.txtNoofLabHourse = new System.Windows.Forms.NumericUpDown();
            this.txtNooftuteHourse = new System.Windows.Forms.NumericUpDown();
            this.txtNokecHourse = new System.Windows.Forms.NumericUpDown();
            this.txtsubjecode = new System.Windows.Forms.TextBox();
            this.txtsubName = new System.Windows.Forms.TextBox();
            this.offyearsubadd = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.managesubjectview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnoOfEvelphour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoofLabHourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNooftuteHourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNokecHourse)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.txtsearchsubjectmanage1);
            this.panel1.Controls.Add(this.deleteSubjectbtn);
            this.panel1.Controls.Add(this.clearSubjctbtn);
            this.panel1.Controls.Add(this.manageSubjectbtn);
            this.panel1.Controls.Add(this.managesubjectview);
            this.panel1.Controls.Add(this.addsubjectradiobtn2);
            this.panel1.Controls.Add(this.addsubjectradiobtn1);
            this.panel1.Controls.Add(this.txtnoOfEvelphour);
            this.panel1.Controls.Add(this.txtNoofLabHourse);
            this.panel1.Controls.Add(this.txtNooftuteHourse);
            this.panel1.Controls.Add(this.txtNokecHourse);
            this.panel1.Controls.Add(this.txtsubjecode);
            this.panel1.Controls.Add(this.txtsubName);
            this.panel1.Controls.Add(this.offyearsubadd);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 539);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtsearchsubjectmanage1
            // 
            this.txtsearchsubjectmanage1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtsearchsubjectmanage1.Location = new System.Drawing.Point(436, 31);
            this.txtsearchsubjectmanage1.Name = "txtsearchsubjectmanage1";
            this.txtsearchsubjectmanage1.PlaceholderText = "Search";
            this.txtsearchsubjectmanage1.Size = new System.Drawing.Size(438, 32);
            this.txtsearchsubjectmanage1.TabIndex = 51;
            this.txtsearchsubjectmanage1.TextChanged += new System.EventHandler(this.txtsearchsubjectmanage1_TextChanged);
            // 
            // deleteSubjectbtn
            // 
            this.deleteSubjectbtn.BackColor = System.Drawing.Color.Red;
            this.deleteSubjectbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteSubjectbtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.deleteSubjectbtn.Image = global::solution.Properties.Resources.delete;
            this.deleteSubjectbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteSubjectbtn.Location = new System.Drawing.Point(804, 445);
            this.deleteSubjectbtn.Name = "deleteSubjectbtn";
            this.deleteSubjectbtn.Size = new System.Drawing.Size(137, 44);
            this.deleteSubjectbtn.TabIndex = 49;
            this.deleteSubjectbtn.Text = "Delete";
            this.deleteSubjectbtn.UseVisualStyleBackColor = false;
            this.deleteSubjectbtn.Click += new System.EventHandler(this.deleteSubjectbtn_Click);
            // 
            // clearSubjctbtn
            // 
            this.clearSubjctbtn.BackColor = System.Drawing.Color.DarkOrange;
            this.clearSubjctbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearSubjctbtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.clearSubjctbtn.Image = global::solution.Properties.Resources.clear;
            this.clearSubjctbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearSubjctbtn.Location = new System.Drawing.Point(804, 376);
            this.clearSubjctbtn.Name = "clearSubjctbtn";
            this.clearSubjctbtn.Size = new System.Drawing.Size(137, 44);
            this.clearSubjctbtn.TabIndex = 48;
            this.clearSubjctbtn.Text = "Clear";
            this.clearSubjctbtn.UseVisualStyleBackColor = false;
            this.clearSubjctbtn.Click += new System.EventHandler(this.clearSubjctbtn_Click);
            // 
            // manageSubjectbtn
            // 
            this.manageSubjectbtn.BackColor = System.Drawing.Color.LimeGreen;
            this.manageSubjectbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.manageSubjectbtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.manageSubjectbtn.Image = global::solution.Properties.Resources.update;
            this.manageSubjectbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageSubjectbtn.Location = new System.Drawing.Point(804, 312);
            this.manageSubjectbtn.Name = "manageSubjectbtn";
            this.manageSubjectbtn.Size = new System.Drawing.Size(137, 44);
            this.manageSubjectbtn.TabIndex = 47;
            this.manageSubjectbtn.Text = "Update";
            this.manageSubjectbtn.UseVisualStyleBackColor = false;
            this.manageSubjectbtn.Click += new System.EventHandler(this.manageSubjectbtn_Click);
            // 
            // managesubjectview
            // 
            this.managesubjectview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.managesubjectview.Location = new System.Drawing.Point(16, 89);
            this.managesubjectview.Name = "managesubjectview";
            this.managesubjectview.RowHeadersWidth = 51;
            this.managesubjectview.RowTemplate.Height = 29;
            this.managesubjectview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.managesubjectview.Size = new System.Drawing.Size(858, 201);
            this.managesubjectview.TabIndex = 46;
            this.managesubjectview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.managesubjectview_CellContentClick);
            this.managesubjectview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.managesubjectview_CellContentClick);
            // 
            // addsubjectradiobtn2
            // 
            this.addsubjectradiobtn2.AutoSize = true;
            this.addsubjectradiobtn2.Location = new System.Drawing.Point(232, 397);
            this.addsubjectradiobtn2.Name = "addsubjectradiobtn2";
            this.addsubjectradiobtn2.Size = new System.Drawing.Size(161, 27);
            this.addsubjectradiobtn2.TabIndex = 45;
            this.addsubjectradiobtn2.TabStop = true;
            this.addsubjectradiobtn2.Text = "2nd semester";
            this.addsubjectradiobtn2.UseVisualStyleBackColor = true;
            // 
            // addsubjectradiobtn1
            // 
            this.addsubjectradiobtn1.AutoSize = true;
            this.addsubjectradiobtn1.Location = new System.Drawing.Point(232, 363);
            this.addsubjectradiobtn1.Name = "addsubjectradiobtn1";
            this.addsubjectradiobtn1.Size = new System.Drawing.Size(150, 27);
            this.addsubjectradiobtn1.TabIndex = 44;
            this.addsubjectradiobtn1.TabStop = true;
            this.addsubjectradiobtn1.Text = "1st semester";
            this.addsubjectradiobtn1.UseVisualStyleBackColor = true;
            this.addsubjectradiobtn1.CheckedChanged += new System.EventHandler(this.addsubjectradiobtn1_CheckedChanged);
            // 
            // txtnoOfEvelphour
            // 
            this.txtnoOfEvelphour.Location = new System.Drawing.Point(638, 485);
            this.txtnoOfEvelphour.Name = "txtnoOfEvelphour";
            this.txtnoOfEvelphour.Size = new System.Drawing.Size(150, 32);
            this.txtnoOfEvelphour.TabIndex = 43;
            // 
            // txtNoofLabHourse
            // 
            this.txtNoofLabHourse.Location = new System.Drawing.Point(638, 434);
            this.txtNoofLabHourse.Name = "txtNoofLabHourse";
            this.txtNoofLabHourse.Size = new System.Drawing.Size(150, 32);
            this.txtNoofLabHourse.TabIndex = 42;
            // 
            // txtNooftuteHourse
            // 
            this.txtNooftuteHourse.Location = new System.Drawing.Point(638, 376);
            this.txtNooftuteHourse.Name = "txtNooftuteHourse";
            this.txtNooftuteHourse.Size = new System.Drawing.Size(150, 32);
            this.txtNooftuteHourse.TabIndex = 41;
            // 
            // txtNokecHourse
            // 
            this.txtNokecHourse.Location = new System.Drawing.Point(638, 310);
            this.txtNokecHourse.Name = "txtNokecHourse";
            this.txtNokecHourse.Size = new System.Drawing.Size(150, 32);
            this.txtNokecHourse.TabIndex = 40;
            // 
            // txtsubjecode
            // 
            this.txtsubjecode.Location = new System.Drawing.Point(232, 487);
            this.txtsubjecode.Name = "txtsubjecode";
            this.txtsubjecode.Size = new System.Drawing.Size(173, 32);
            this.txtsubjecode.TabIndex = 39;
            // 
            // txtsubName
            // 
            this.txtsubName.Location = new System.Drawing.Point(232, 436);
            this.txtsubName.Name = "txtsubName";
            this.txtsubName.Size = new System.Drawing.Size(173, 32);
            this.txtsubName.TabIndex = 38;
            // 
            // offyearsubadd
            // 
            this.offyearsubadd.FormattingEnabled = true;
            this.offyearsubadd.Items.AddRange(new object[] {
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011"});
            this.offyearsubadd.Location = new System.Drawing.Point(232, 309);
            this.offyearsubadd.Name = "offyearsubadd";
            this.offyearsubadd.Size = new System.Drawing.Size(173, 31);
            this.offyearsubadd.TabIndex = 37;
            this.offyearsubadd.SelectedIndexChanged += new System.EventHandler(this.offyearsubadd_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(421, 487);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 23);
            this.label9.TabIndex = 36;
            this.label9.Text = "No Of Evalution Hours";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(421, 436);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 23);
            this.label8.TabIndex = 35;
            this.label8.Text = "No Of Lab Hours";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(421, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 23);
            this.label7.TabIndex = 34;
            this.label7.Text = "No Of tutorial Hours";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(421, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 23);
            this.label6.TabIndex = 33;
            this.label6.Text = "No Of Lecturer Hours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(10, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 23);
            this.label5.TabIndex = 32;
            this.label5.Text = "Subject Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(10, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Subject Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Offered Semester";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Offered Year";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(376, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(278, 35);
            this.label10.TabIndex = 2;
            this.label10.Text = "Manage Subjects";
            // 
            // manageSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1085, 639);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "manageSubjects";
            this.Text = "manageSubjects";
            this.Load += new System.EventHandler(this.manageSubjects_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.managesubjectview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnoOfEvelphour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoofLabHourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNooftuteHourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNokecHourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView managesubjectview;
        private System.Windows.Forms.RadioButton addsubjectradiobtn2;
        private System.Windows.Forms.RadioButton addsubjectradiobtn1;
        private System.Windows.Forms.NumericUpDown txtnoOfEvelphour;
        private System.Windows.Forms.NumericUpDown txtNoofLabHourse;
        private System.Windows.Forms.NumericUpDown txtNooftuteHourse;
        private System.Windows.Forms.NumericUpDown txtNokecHourse;
        private System.Windows.Forms.TextBox txtsubjecode;
        private System.Windows.Forms.TextBox txtsubName;
        private System.Windows.Forms.ComboBox offyearsubadd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteSubjectbtn;
        private System.Windows.Forms.Button clearSubjctbtn;
        private System.Windows.Forms.Button manageSubjectbtn;
        private System.Windows.Forms.TextBox txtsearchsubjectmanage1;
        private System.Windows.Forms.Label label10;
    }
}