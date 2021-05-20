
namespace solution
{
    partial class addTag
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
            this.tagpanel = new System.Windows.Forms.Panel();
            this.SaveBtnTag = new System.Windows.Forms.Button();
            this.ClearBtnTag = new System.Windows.Forms.Button();
            this.related_tag = new System.Windows.Forms.ComboBox();
            this.t_code = new System.Windows.Forms.TextBox();
            this.t_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tagpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tagpanel
            // 
            this.tagpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tagpanel.Controls.Add(this.label1);
            this.tagpanel.Controls.Add(this.SaveBtnTag);
            this.tagpanel.Controls.Add(this.ClearBtnTag);
            this.tagpanel.Controls.Add(this.related_tag);
            this.tagpanel.Controls.Add(this.t_code);
            this.tagpanel.Controls.Add(this.t_name);
            this.tagpanel.Controls.Add(this.label4);
            this.tagpanel.Controls.Add(this.label3);
            this.tagpanel.Controls.Add(this.label2);
            this.tagpanel.Location = new System.Drawing.Point(44, 41);
            this.tagpanel.Name = "tagpanel";
            this.tagpanel.Size = new System.Drawing.Size(1094, 602);
            this.tagpanel.TabIndex = 0;
            this.tagpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SaveBtnTag
            // 
            this.SaveBtnTag.BackColor = System.Drawing.Color.DodgerBlue;
            this.SaveBtnTag.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveBtnTag.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SaveBtnTag.Location = new System.Drawing.Point(346, 410);
            this.SaveBtnTag.Name = "SaveBtnTag";
            this.SaveBtnTag.Size = new System.Drawing.Size(128, 44);
            this.SaveBtnTag.TabIndex = 20;
            this.SaveBtnTag.Text = "Save";
            this.SaveBtnTag.UseVisualStyleBackColor = false;
            this.SaveBtnTag.Click += new System.EventHandler(this.SaveBtnTag_Click);
            // 
            // ClearBtnTag
            // 
            this.ClearBtnTag.BackColor = System.Drawing.Color.DarkOrange;
            this.ClearBtnTag.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearBtnTag.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ClearBtnTag.Location = new System.Drawing.Point(515, 410);
            this.ClearBtnTag.Name = "ClearBtnTag";
            this.ClearBtnTag.Size = new System.Drawing.Size(137, 44);
            this.ClearBtnTag.TabIndex = 19;
            this.ClearBtnTag.Text = "Clear";
            this.ClearBtnTag.UseVisualStyleBackColor = false;
            this.ClearBtnTag.Click += new System.EventHandler(this.button2_Click);
            // 
            // related_tag
            // 
            this.related_tag.FormattingEnabled = true;
            this.related_tag.Items.AddRange(new object[] {
            "Lecture",
            "Tutorial",
            "Lab"});
            this.related_tag.Location = new System.Drawing.Point(411, 309);
            this.related_tag.Name = "related_tag";
            this.related_tag.Size = new System.Drawing.Size(256, 38);
            this.related_tag.TabIndex = 5;
            // 
            // t_code
            // 
            this.t_code.Location = new System.Drawing.Point(411, 235);
            this.t_code.Name = "t_code";
            this.t_code.Size = new System.Drawing.Size(256, 37);
            this.t_code.TabIndex = 4;
            this.t_code.TextChanged += new System.EventHandler(this.t_code_TextChanged);
            // 
            // t_name
            // 
            this.t_name.Location = new System.Drawing.Point(411, 153);
            this.t_name.Name = "t_name";
            this.t_name.Size = new System.Drawing.Size(256, 37);
            this.t_name.TabIndex = 3;
            this.t_name.TextChanged += new System.EventHandler(this.t_name_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(196, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Related Tag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(203, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tag Code";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(196, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tag Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(355, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Tag";
            // 
            // addTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1219, 799);
            this.Controls.Add(this.tagpanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "addTag";
            this.Text = "addTag";
            this.Load += new System.EventHandler(this.addTag_Load);
            this.tagpanel.ResumeLayout(false);
            this.tagpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tagpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox related_tag;
        private System.Windows.Forms.TextBox t_code;
        private System.Windows.Forms.TextBox t_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ClearBtnTag;
        private System.Windows.Forms.Button SaveBtnTag;
    }
}