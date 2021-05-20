
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
            this.label10 = new System.Windows.Forms.Label();
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
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panelChildForm);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-480, -135);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3085, 1522);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelChildForm.Controls.Add(this.label10);
            this.panelChildForm.Controls.Add(this.button5);
            this.panelChildForm.Controls.Add(this.selecttags);
            this.panelChildForm.Controls.Add(this.clearbtnsession);
            this.panelChildForm.Controls.Add(this.label3);
            this.panelChildForm.Controls.Add(this.label1);
            this.panelChildForm.Controls.Add(this.label6);
            this.panelChildForm.Controls.Add(this.selettextlect);
            this.panelChildForm.Controls.Add(this.selectLecturer);
            this.panelChildForm.Location = new System.Drawing.Point(493, 304);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1222, 419);
            this.panelChildForm.TabIndex = 16;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(422, 24);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(244, 42);
            this.label10.TabIndex = 30;
            this.label10.Text = "Add Session";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.RoyalBlue;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(905, 314);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(170, 55);
            this.button5.TabIndex = 29;
            this.button5.Text = "Next";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // selecttags
            // 
            this.selecttags.FormattingEnabled = true;
            this.selecttags.Location = new System.Drawing.Point(702, 131);
            this.selecttags.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selecttags.Name = "selecttags";
            this.selecttags.Size = new System.Drawing.Size(215, 33);
            this.selecttags.TabIndex = 28;
            // 
            // clearbtnsession
            // 
            this.clearbtnsession.BackColor = System.Drawing.Color.DarkOrange;
            this.clearbtnsession.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearbtnsession.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.clearbtnsession.Location = new System.Drawing.Point(702, 314);
            this.clearbtnsession.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearbtnsession.Name = "clearbtnsession";
            this.clearbtnsession.Size = new System.Drawing.Size(171, 55);
            this.clearbtnsession.TabIndex = 26;
            this.clearbtnsession.Text = "Clear";
            this.clearbtnsession.UseVisualStyleBackColor = false;
            this.clearbtnsession.Click += new System.EventHandler(this.clearbtnsession_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(509, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 28);
            this.label3.TabIndex = 24;
            this.label3.Text = "Select Tag";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 229);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 28);
            this.label1.TabIndex = 23;
            this.label1.Text = "Selected Lecturer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(24, 131);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 28);
            this.label6.TabIndex = 22;
            this.label6.Text = "Select Lecturer";
            // 
            // selettextlect
            // 
            this.selettextlect.Location = new System.Drawing.Point(250, 225);
            this.selettextlect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selettextlect.Name = "selettextlect";
            this.selettextlect.Size = new System.Drawing.Size(419, 31);
            this.selettextlect.TabIndex = 21;
            // 
            // selectLecturer
            // 
            this.selectLecturer.FormattingEnabled = true;
            this.selectLecturer.Location = new System.Drawing.Point(242, 128);
            this.selectLecturer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectLecturer.Name = "selectLecturer";
            this.selectLecturer.Size = new System.Drawing.Size(215, 33);
            this.selectLecturer.TabIndex = 20;
            this.selectLecturer.SelectedIndexChanged += new System.EventHandler(this.selectLecturer_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(922, 195);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(380, 51);
            this.button3.TabIndex = 15;
            this.button3.Text = "Select  Group And Subject";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.Location = new System.Drawing.Point(596, 195);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(331, 51);
            this.button4.TabIndex = 14;
            this.button4.Text = "Select Lecturer And  Tag";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(45, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 28);
            this.label2.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(458, 32);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(380, 50);
            this.button2.TabIndex = 11;
            this.button2.Text = "Select  Group And Subject";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 32);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(331, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = "Select Lecturer And  Tag";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // sessionadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label label10;
    }
}