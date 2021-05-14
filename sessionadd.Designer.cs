
namespace solution
{
    partial class sessionadd
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
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.selecttags = new System.Windows.Forms.ComboBox();
            this.clearbtnsession = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.selettextlect = new System.Windows.Forms.TextBox();
            this.selectLecturer = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panelChildForm);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-384, -108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2468, 1218);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.button5);
            this.panelChildForm.Controls.Add(this.selecttags);
            this.panelChildForm.Controls.Add(this.clearbtnsession);
            this.panelChildForm.Controls.Add(this.label3);
            this.panelChildForm.Controls.Add(this.label1);
            this.panelChildForm.Controls.Add(this.label6);
            this.panelChildForm.Controls.Add(this.selettextlect);
            this.panelChildForm.Controls.Add(this.selectLecturer);
            this.panelChildForm.Location = new System.Drawing.Point(435, 260);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(978, 335);
            this.panelChildForm.TabIndex = 16;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(766, 258);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 29);
            this.button5.TabIndex = 29;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // selecttags
            // 
            this.selecttags.FormattingEnabled = true;
            this.selecttags.Location = new System.Drawing.Point(562, 105);
            this.selecttags.Name = "selecttags";
            this.selecttags.Size = new System.Drawing.Size(173, 28);
            this.selecttags.TabIndex = 28;
            // 
            // clearbtnsession
            // 
            this.clearbtnsession.BackColor = System.Drawing.Color.DarkOrange;
            this.clearbtnsession.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearbtnsession.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.clearbtnsession.Location = new System.Drawing.Point(562, 251);
            this.clearbtnsession.Name = "clearbtnsession";
            this.clearbtnsession.Size = new System.Drawing.Size(137, 44);
            this.clearbtnsession.TabIndex = 26;
            this.clearbtnsession.Text = "Clear";
            this.clearbtnsession.UseVisualStyleBackColor = false;
            this.clearbtnsession.Click += new System.EventHandler(this.clearbtnsession_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(407, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Select Tag";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Selected Lecturer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(19, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "Select Lecturer";
            // 
            // selettextlect
            // 
            this.selettextlect.Location = new System.Drawing.Point(200, 180);
            this.selettextlect.Name = "selettextlect";
            this.selettextlect.Size = new System.Drawing.Size(336, 27);
            this.selettextlect.TabIndex = 21;
            // 
            // selectLecturer
            // 
            this.selectLecturer.FormattingEnabled = true;
            this.selectLecturer.Location = new System.Drawing.Point(194, 102);
            this.selectLecturer.Name = "selectLecturer";
            this.selectLecturer.Size = new System.Drawing.Size(173, 28);
            this.selectLecturer.TabIndex = 20;
            this.selectLecturer.SelectedIndexChanged += new System.EventHandler(this.selectLecturer_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(780, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(304, 40);
            this.button3.TabIndex = 15;
            this.button3.Text = "Select  Group And Subject";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(477, 156);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(265, 41);
            this.button4.TabIndex = 14;
            this.button4.Text = "Select Lecturer And  Tag";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(36, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(366, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(304, 40);
            this.button2.TabIndex = 11;
            this.button2.Text = "Select  Group And Subject";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Select Lecturer And  Tag";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // sessionadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 1003);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "sessionadd";
            this.Text = "sessionadd";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox selecttags;
        private System.Windows.Forms.Button clearbtnsession;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox selettextlect;
        private System.Windows.Forms.ComboBox selectLecturer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}