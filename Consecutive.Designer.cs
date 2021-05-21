
namespace solution
{
    partial class Consecutive
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.selectroomMS = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsaveMSR = new System.Windows.Forms.Button();
            this.MSRGrid2 = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MSRGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 391);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.selectroomMS);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnsaveMSR);
            this.panel2.Controls.Add(this.MSRGrid2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(939, 391);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(536, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 44);
            this.button1.TabIndex = 111;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // selectroomMS
            // 
            this.selectroomMS.FormattingEnabled = true;
            this.selectroomMS.Location = new System.Drawing.Point(165, 154);
            this.selectroomMS.Name = "selectroomMS";
            this.selectroomMS.Size = new System.Drawing.Size(173, 23);
            this.selectroomMS.TabIndex = 110;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(42, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 109;
            this.label2.Text = "Select Room";
            // 
            // btnsaveMSR
            // 
            this.btnsaveMSR.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnsaveMSR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsaveMSR.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnsaveMSR.Location = new System.Drawing.Point(679, 202);
            this.btnsaveMSR.Name = "btnsaveMSR";
            this.btnsaveMSR.Size = new System.Drawing.Size(128, 44);
            this.btnsaveMSR.TabIndex = 108;
            this.btnsaveMSR.Text = "Save";
            this.btnsaveMSR.UseVisualStyleBackColor = false;
            this.btnsaveMSR.Click += new System.EventHandler(this.btnsaveMSR_Click);
            // 
            // MSRGrid2
            // 
            this.MSRGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MSRGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select});
            this.MSRGrid2.Location = new System.Drawing.Point(24, 35);
            this.MSRGrid2.Name = "MSRGrid2";
            this.MSRGrid2.RowTemplate.Height = 25;
            this.MSRGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MSRGrid2.Size = new System.Drawing.Size(783, 110);
            this.MSRGrid2.TabIndex = 7;
            // 
            // select
            // 
            this.select.HeaderText = "Select";
            this.select.Name = "select";
            // 
            // Consecutive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Consecutive";
            this.Text = "Consecutive";
            this.Load += new System.EventHandler(this.Consecutive_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MSRGrid2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView MSRGrid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn select;
        private System.Windows.Forms.ComboBox selectroomMS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsaveMSR;
        private System.Windows.Forms.Button button1;
    }
}