
namespace solution
{
    partial class workingDays
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
            this.wdUpdate = new System.Windows.Forms.Button();
            this.wdClear = new System.Windows.Forms.Button();
            this.cb7 = new System.Windows.Forms.CheckBox();
            this.cb6 = new System.Windows.Forms.CheckBox();
            this.cb5 = new System.Windows.Forms.CheckBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.updownDays = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.updownMin = new System.Windows.Forms.NumericUpDown();
            this.updownHrs = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownHrs)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.wdUpdate);
            this.panel1.Controls.Add(this.wdClear);
            this.panel1.Controls.Add(this.cb7);
            this.panel1.Controls.Add(this.cb6);
            this.panel1.Controls.Add(this.cb5);
            this.panel1.Controls.Add(this.cb4);
            this.panel1.Controls.Add(this.cb3);
            this.panel1.Controls.Add(this.cb2);
            this.panel1.Controls.Add(this.cb1);
            this.panel1.Controls.Add(this.updownDays);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.updownMin);
            this.panel1.Controls.Add(this.updownHrs);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(75, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 438);
            this.panel1.TabIndex = 0;
            // 
            // wdUpdate
            // 
            this.wdUpdate.BackColor = System.Drawing.Color.Navy;
            this.wdUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.wdUpdate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wdUpdate.ForeColor = System.Drawing.Color.White;
            this.wdUpdate.Location = new System.Drawing.Point(520, 357);
            this.wdUpdate.Name = "wdUpdate";
            this.wdUpdate.Size = new System.Drawing.Size(110, 35);
            this.wdUpdate.TabIndex = 18;
            this.wdUpdate.Text = "Update";
            this.wdUpdate.UseVisualStyleBackColor = false;
            this.wdUpdate.Click += new System.EventHandler(this.wdUpdate_Click);
            // 
            // wdClear
            // 
            this.wdClear.BackColor = System.Drawing.Color.Maroon;
            this.wdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.wdClear.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wdClear.ForeColor = System.Drawing.Color.White;
            this.wdClear.Location = new System.Drawing.Point(654, 357);
            this.wdClear.Name = "wdClear";
            this.wdClear.Size = new System.Drawing.Size(110, 35);
            this.wdClear.TabIndex = 16;
            this.wdClear.Text = "Clear";
            this.wdClear.UseVisualStyleBackColor = false;
            this.wdClear.Click += new System.EventHandler(this.wdClear_Click);
            // 
            // cb7
            // 
            this.cb7.AutoSize = true;
            this.cb7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb7.ForeColor = System.Drawing.Color.Black;
            this.cb7.Location = new System.Drawing.Point(339, 234);
            this.cb7.Name = "cb7";
            this.cb7.Size = new System.Drawing.Size(93, 29);
            this.cb7.TabIndex = 15;
            this.cb7.Text = "Sunday";
            this.cb7.UseVisualStyleBackColor = true;
            this.cb7.CheckedChanged += new System.EventHandler(this.cb7_CheckedChanged);
            // 
            // cb6
            // 
            this.cb6.AutoSize = true;
            this.cb6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb6.ForeColor = System.Drawing.Color.Black;
            this.cb6.Location = new System.Drawing.Point(224, 234);
            this.cb6.Name = "cb6";
            this.cb6.Size = new System.Drawing.Size(104, 29);
            this.cb6.TabIndex = 14;
            this.cb6.Text = "Saturday";
            this.cb6.UseVisualStyleBackColor = true;
            this.cb6.CheckedChanged += new System.EventHandler(this.cb6_CheckedChanged);
            // 
            // cb5
            // 
            this.cb5.AutoSize = true;
            this.cb5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb5.ForeColor = System.Drawing.Color.Black;
            this.cb5.Location = new System.Drawing.Point(708, 199);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(82, 29);
            this.cb5.TabIndex = 13;
            this.cb5.Text = "Friday";
            this.cb5.UseVisualStyleBackColor = true;
            this.cb5.CheckedChanged += new System.EventHandler(this.cb5_CheckedChanged);
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb4.ForeColor = System.Drawing.Color.Black;
            this.cb4.Location = new System.Drawing.Point(589, 199);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(106, 29);
            this.cb4.TabIndex = 12;
            this.cb4.Text = "Thursday";
            this.cb4.UseVisualStyleBackColor = true;
            this.cb4.CheckedChanged += new System.EventHandler(this.cb4_CheckedChanged);
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb3.ForeColor = System.Drawing.Color.Black;
            this.cb3.Location = new System.Drawing.Point(454, 199);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(126, 29);
            this.cb3.TabIndex = 11;
            this.cb3.Text = "Wednesday";
            this.cb3.UseVisualStyleBackColor = true;
            this.cb3.CheckedChanged += new System.EventHandler(this.cb3_CheckedChanged);
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb2.ForeColor = System.Drawing.Color.Black;
            this.cb2.Location = new System.Drawing.Point(339, 199);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(99, 29);
            this.cb2.TabIndex = 10;
            this.cb2.Text = "Tuesday";
            this.cb2.UseVisualStyleBackColor = true;
            this.cb2.CheckedChanged += new System.EventHandler(this.cb2_CheckedChanged);
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb1.ForeColor = System.Drawing.Color.Black;
            this.cb1.Location = new System.Drawing.Point(224, 199);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(100, 29);
            this.cb1.TabIndex = 9;
            this.cb1.Text = "Monday";
            this.cb1.UseVisualStyleBackColor = true;
            this.cb1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // updownDays
            // 
            this.updownDays.Location = new System.Drawing.Point(224, 42);
            this.updownDays.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.updownDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updownDays.Name = "updownDays";
            this.updownDays.Size = new System.Drawing.Size(96, 27);
            this.updownDays.TabIndex = 8;
            this.updownDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updownDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updownDays.ValueChanged += new System.EventHandler(this.updownDays_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(538, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Minutes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(326, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hours";
            // 
            // updownMin
            // 
            this.updownMin.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.updownMin.Location = new System.Drawing.Point(435, 124);
            this.updownMin.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.updownMin.Name = "updownMin";
            this.updownMin.Size = new System.Drawing.Size(96, 27);
            this.updownMin.TabIndex = 5;
            this.updownMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updownMin.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // updownHrs
            // 
            this.updownHrs.Location = new System.Drawing.Point(224, 124);
            this.updownHrs.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.updownHrs.Name = "updownHrs";
            this.updownHrs.Size = new System.Drawing.Size(96, 27);
            this.updownHrs.TabIndex = 4;
            this.updownHrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updownHrs.ValueChanged += new System.EventHandler(this.updownHrs_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Working Days";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Working Time Per Day";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "No of Working Days";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(208, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 107);
            this.panel2.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(354, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Working Days";
            // 
            // workingDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(975, 639);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "workingDays";
            this.Text = "workingDays";
            this.Load += new System.EventHandler(this.workingDays_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownHrs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown updownMin;
        private System.Windows.Forms.NumericUpDown updownHrs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb7;
        private System.Windows.Forms.CheckBox cb6;
        private System.Windows.Forms.CheckBox cb5;
        private System.Windows.Forms.CheckBox cb4;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.NumericUpDown updownDays;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button wdClear;
        private System.Windows.Forms.Button wdUpdate;
        private System.Windows.Forms.Panel panel2;
    }
}