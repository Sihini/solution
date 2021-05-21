
namespace solution
{
    partial class manageTag
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
            this.TagSearch = new System.Windows.Forms.TextBox();
            this.DeleteBtnTag = new System.Windows.Forms.Button();
            this.ClearBtnManageTag = new System.Windows.Forms.Button();
            this.UpdateBtnTag = new System.Windows.Forms.Button();
            this.SearchBtnTag = new System.Windows.Forms.Button();
            this.related_tag = new System.Windows.Forms.ComboBox();
            this.t_name = new System.Windows.Forms.TextBox();
            this.t_code = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TagdataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TagdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.TagSearch);
            this.panel1.Controls.Add(this.DeleteBtnTag);
            this.panel1.Controls.Add(this.ClearBtnManageTag);
            this.panel1.Controls.Add(this.UpdateBtnTag);
            this.panel1.Controls.Add(this.SearchBtnTag);
            this.panel1.Controls.Add(this.related_tag);
            this.panel1.Controls.Add(this.t_name);
            this.panel1.Controls.Add(this.t_code);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TagdataGridView);
            this.panel1.Location = new System.Drawing.Point(73, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 602);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TagSearch
            // 
            this.TagSearch.Location = new System.Drawing.Point(636, 41);
            this.TagSearch.Name = "TagSearch";
            this.TagSearch.Size = new System.Drawing.Size(229, 32);
            this.TagSearch.TabIndex = 25;
            this.TagSearch.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // DeleteBtnTag
            // 
            this.DeleteBtnTag.BackColor = System.Drawing.Color.Red;
            this.DeleteBtnTag.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtnTag.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DeleteBtnTag.Image = global::solution.Properties.Resources.delete;
            this.DeleteBtnTag.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteBtnTag.Location = new System.Drawing.Point(776, 460);
            this.DeleteBtnTag.Name = "DeleteBtnTag";
            this.DeleteBtnTag.Size = new System.Drawing.Size(137, 44);
            this.DeleteBtnTag.TabIndex = 24;
            this.DeleteBtnTag.Text = "Delete";
            this.DeleteBtnTag.UseVisualStyleBackColor = false;
            this.DeleteBtnTag.Click += new System.EventHandler(this.DeleteBtnTag_Click);
            // 
            // ClearBtnManageTag
            // 
            this.ClearBtnManageTag.BackColor = System.Drawing.Color.DarkOrange;
            this.ClearBtnManageTag.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearBtnManageTag.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ClearBtnManageTag.Image = global::solution.Properties.Resources.clear;
            this.ClearBtnManageTag.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClearBtnManageTag.Location = new System.Drawing.Point(776, 410);
            this.ClearBtnManageTag.Name = "ClearBtnManageTag";
            this.ClearBtnManageTag.Size = new System.Drawing.Size(137, 44);
            this.ClearBtnManageTag.TabIndex = 23;
            this.ClearBtnManageTag.Text = "Clear";
            this.ClearBtnManageTag.UseVisualStyleBackColor = false;
            this.ClearBtnManageTag.Click += new System.EventHandler(this.ClearBtnManageTag_Click);
            // 
            // UpdateBtnTag
            // 
            this.UpdateBtnTag.BackColor = System.Drawing.Color.LimeGreen;
            this.UpdateBtnTag.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateBtnTag.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.UpdateBtnTag.Image = global::solution.Properties.Resources.update;
            this.UpdateBtnTag.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateBtnTag.Location = new System.Drawing.Point(776, 360);
            this.UpdateBtnTag.Name = "UpdateBtnTag";
            this.UpdateBtnTag.Size = new System.Drawing.Size(137, 44);
            this.UpdateBtnTag.TabIndex = 22;
            this.UpdateBtnTag.Text = "Update";
            this.UpdateBtnTag.UseVisualStyleBackColor = false;
            this.UpdateBtnTag.Click += new System.EventHandler(this.UpdateBtnTag_Click);
            // 
            // SearchBtnTag
            // 
            this.SearchBtnTag.BackColor = System.Drawing.Color.DodgerBlue;
            this.SearchBtnTag.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchBtnTag.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SearchBtnTag.Location = new System.Drawing.Point(882, 34);
            this.SearchBtnTag.Name = "SearchBtnTag";
            this.SearchBtnTag.Size = new System.Drawing.Size(137, 44);
            this.SearchBtnTag.TabIndex = 21;
            this.SearchBtnTag.Text = "Search";
            this.SearchBtnTag.UseVisualStyleBackColor = false;
            // 
            // related_tag
            // 
            this.related_tag.FormattingEnabled = true;
            this.related_tag.Items.AddRange(new object[] {
            "Lecture",
            "Tutorial",
            "Lab"});
            this.related_tag.Location = new System.Drawing.Point(392, 479);
            this.related_tag.Name = "related_tag";
            this.related_tag.Size = new System.Drawing.Size(211, 31);
            this.related_tag.TabIndex = 6;
            // 
            // t_name
            // 
            this.t_name.Location = new System.Drawing.Point(392, 360);
            this.t_name.Name = "t_name";
            this.t_name.Size = new System.Drawing.Size(211, 32);
            this.t_name.TabIndex = 5;
            // 
            // t_code
            // 
            this.t_code.Location = new System.Drawing.Point(392, 417);
            this.t_code.Name = "t_code";
            this.t_code.Size = new System.Drawing.Size(211, 32);
            this.t_code.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(192, 479);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Related Tag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(192, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tag Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(192, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tag Code";
            // 
            // TagdataGridView
            // 
            this.TagdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TagdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TagdataGridView.Location = new System.Drawing.Point(119, 110);
            this.TagdataGridView.Name = "TagdataGridView";
            this.TagdataGridView.RowHeadersWidth = 62;
            this.TagdataGridView.RowTemplate.Height = 33;
            this.TagdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TagdataGridView.Size = new System.Drawing.Size(900, 199);
            this.TagdataGridView.TabIndex = 0;
            this.TagdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(514, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Tag";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(426, 233);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // manageTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1219, 799);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "manageTag";
            this.Text = "manageTag";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TagdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox related_tag;
        private System.Windows.Forms.TextBox t_name;
        private System.Windows.Forms.TextBox t_code;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView TagdataGridView;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button SearchBtnTag;
        private System.Windows.Forms.Button DeleteBtnTag;
        private System.Windows.Forms.Button ClearBtnManageTag;
        private System.Windows.Forms.Button UpdateBtnTag;
        private System.Windows.Forms.TextBox TagSearch;
    }
}