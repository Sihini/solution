
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
            this.wdClear = new System.Windows.Forms.Button();
            this.wdUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkboxpanel = new System.Windows.Forms.Panel();
            this.cbox7 = new System.Windows.Forms.CheckBox();
            this.cbox6 = new System.Windows.Forms.CheckBox();
            this.cbox5 = new System.Windows.Forms.CheckBox();
            this.cbox4 = new System.Windows.Forms.CheckBox();
            this.cbox3 = new System.Windows.Forms.CheckBox();
            this.cbox2 = new System.Windows.Forms.CheckBox();
            this.cbox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.upDownHrs = new System.Windows.Forms.NumericUpDown();
            this.upDownDays = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.checkboxpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownHrs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.wdClear);
            this.panel1.Controls.Add(this.wdUpdate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.checkboxpanel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.upDownHrs);
            this.panel1.Controls.Add(this.upDownDays);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 476);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // wdClear
            // 
            this.wdClear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wdClear.BackColor = System.Drawing.Color.Firebrick;
            this.wdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.wdClear.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wdClear.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.wdClear.Location = new System.Drawing.Point(635, 407);
            this.wdClear.Name = "wdClear";
            this.wdClear.Size = new System.Drawing.Size(110, 37);
            this.wdClear.TabIndex = 42;
            this.wdClear.Text = "Clear";
            this.wdClear.UseVisualStyleBackColor = false;
            // 
            // wdUpdate
            // 
            this.wdUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wdUpdate.BackColor = System.Drawing.Color.MidnightBlue;
            this.wdUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.wdUpdate.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wdUpdate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.wdUpdate.Location = new System.Drawing.Point(481, 407);
            this.wdUpdate.Name = "wdUpdate";
            this.wdUpdate.Size = new System.Drawing.Size(110, 37);
            this.wdUpdate.TabIndex = 41;
            this.wdUpdate.Text = "Update";
            this.wdUpdate.UseVisualStyleBackColor = false;
            this.wdUpdate.Click += new System.EventHandler(this.wdUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 23);
            this.label3.TabIndex = 35;
            this.label3.Text = "Working Days";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // checkboxpanel
            // 
            this.checkboxpanel.Controls.Add(this.cbox7);
            this.checkboxpanel.Controls.Add(this.cbox6);
            this.checkboxpanel.Controls.Add(this.cbox5);
            this.checkboxpanel.Controls.Add(this.cbox4);
            this.checkboxpanel.Controls.Add(this.cbox3);
            this.checkboxpanel.Controls.Add(this.cbox2);
            this.checkboxpanel.Controls.Add(this.cbox1);
            this.checkboxpanel.Location = new System.Drawing.Point(222, 210);
            this.checkboxpanel.Name = "checkboxpanel";
            this.checkboxpanel.Size = new System.Drawing.Size(533, 99);
            this.checkboxpanel.TabIndex = 40;
            // 
            // cbox7
            // 
            this.cbox7.AutoSize = true;
            this.cbox7.BackColor = System.Drawing.Color.Transparent;
            this.cbox7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbox7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbox7.Location = new System.Drawing.Point(119, 61);
            this.cbox7.Name = "cbox7";
            this.cbox7.Size = new System.Drawing.Size(85, 27);
            this.cbox7.TabIndex = 34;
            this.cbox7.Text = "Sunday";
            this.cbox7.UseVisualStyleBackColor = false;
            // 
            // cbox6
            // 
            this.cbox6.AutoSize = true;
            this.cbox6.BackColor = System.Drawing.Color.Transparent;
            this.cbox6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbox6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbox6.Location = new System.Drawing.Point(12, 61);
            this.cbox6.Name = "cbox6";
            this.cbox6.Size = new System.Drawing.Size(96, 27);
            this.cbox6.TabIndex = 33;
            this.cbox6.Text = "Saturday";
            this.cbox6.UseVisualStyleBackColor = false;
            // 
            // cbox5
            // 
            this.cbox5.AutoSize = true;
            this.cbox5.BackColor = System.Drawing.Color.Transparent;
            this.cbox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbox5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbox5.Location = new System.Drawing.Point(454, 15);
            this.cbox5.Name = "cbox5";
            this.cbox5.Size = new System.Drawing.Size(74, 27);
            this.cbox5.TabIndex = 32;
            this.cbox5.Text = "Friday";
            this.cbox5.UseVisualStyleBackColor = false;
            // 
            // cbox4
            // 
            this.cbox4.AutoSize = true;
            this.cbox4.BackColor = System.Drawing.Color.Transparent;
            this.cbox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbox4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbox4.Location = new System.Drawing.Point(350, 15);
            this.cbox4.Name = "cbox4";
            this.cbox4.Size = new System.Drawing.Size(98, 27);
            this.cbox4.TabIndex = 31;
            this.cbox4.Text = "Thursday";
            this.cbox4.UseVisualStyleBackColor = false;
            // 
            // cbox3
            // 
            this.cbox3.AutoSize = true;
            this.cbox3.BackColor = System.Drawing.Color.Transparent;
            this.cbox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbox3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbox3.Location = new System.Drawing.Point(228, 15);
            this.cbox3.Name = "cbox3";
            this.cbox3.Size = new System.Drawing.Size(116, 27);
            this.cbox3.TabIndex = 30;
            this.cbox3.Text = "Wednesday";
            this.cbox3.UseVisualStyleBackColor = false;
            // 
            // cbox2
            // 
            this.cbox2.AutoSize = true;
            this.cbox2.BackColor = System.Drawing.Color.Transparent;
            this.cbox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbox2.Location = new System.Drawing.Point(119, 15);
            this.cbox2.Name = "cbox2";
            this.cbox2.Size = new System.Drawing.Size(91, 27);
            this.cbox2.TabIndex = 29;
            this.cbox2.Text = "Tuesday";
            this.cbox2.UseVisualStyleBackColor = false;
            // 
            // cbox1
            // 
            this.cbox1.AutoSize = true;
            this.cbox1.BackColor = System.Drawing.Color.Transparent;
            this.cbox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbox1.Location = new System.Drawing.Point(12, 14);
            this.cbox1.Name = "cbox1";
            this.cbox1.Size = new System.Drawing.Size(91, 27);
            this.cbox1.TabIndex = 28;
            this.cbox1.Text = "Monday";
            this.cbox1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(510, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 23);
            this.label6.TabIndex = 39;
            this.label6.Text = "Minutes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(321, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 38;
            this.label5.Text = "Hours";
            // 
            // upDownHrs
            // 
            this.upDownHrs.Location = new System.Drawing.Point(234, 142);
            this.upDownHrs.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.upDownHrs.Name = "upDownHrs";
            this.upDownHrs.Size = new System.Drawing.Size(81, 27);
            this.upDownHrs.TabIndex = 36;
            this.upDownHrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // upDownDays
            // 
            this.upDownDays.Location = new System.Drawing.Point(235, 57);
            this.upDownDays.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.upDownDays.Name = "upDownDays";
            this.upDownDays.Size = new System.Drawing.Size(81, 27);
            this.upDownDays.TabIndex = 35;
            this.upDownDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.upDownDays.ValueChanged += new System.EventHandler(this.upDownDays_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 23);
            this.label4.TabIndex = 34;
            this.label4.Text = "Working Time Per Day";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "No of Working Days";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.Firebrick;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnClear.Location = new System.Drawing.Point(724, 417);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 40);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnUpdate.Location = new System.Drawing.Point(525, 523);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 40);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(265, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(233, 35);
            this.label10.TabIndex = 43;
            this.label10.Text = "Working Days";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(423, 143);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(81, 27);
            this.numericUpDown1.TabIndex = 43;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // workingDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 639);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Name = "workingDays";
            this.Text = "workingDays";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.checkboxpanel.ResumeLayout(false);
            this.checkboxpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownHrs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel checkboxpanel;
        private System.Windows.Forms.CheckBox cbox7;
        private System.Windows.Forms.CheckBox cbox6;
        private System.Windows.Forms.CheckBox cbox5;
        private System.Windows.Forms.CheckBox cbox4;
        private System.Windows.Forms.CheckBox cbox3;
        private System.Windows.Forms.CheckBox cbox2;
        private System.Windows.Forms.CheckBox cbox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown upDownHrs;
        private System.Windows.Forms.NumericUpDown upDownDays;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button wdClear;
        private System.Windows.Forms.Button wdUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}