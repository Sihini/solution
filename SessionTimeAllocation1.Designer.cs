
namespace solution
{
    partial class SessionTimeAllocation1
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
            this.label7 = new System.Windows.Forms.Label();
            this.sessionTimeAllocationpanel = new System.Windows.Forms.Panel();
            this.timeAllocationsubpannel = new System.Windows.Forms.Panel();
            this.stNotAvailablebtn = new System.Windows.Forms.Button();
            this.stNonOverlappingbtn = new System.Windows.Forms.Button();
            this.stParallelbtn = new System.Windows.Forms.Button();
            this.stConsecutivebtn = new System.Windows.Forms.Button();
            this.sessionTimeAllocationpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(120, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(708, 35);
            this.label7.TabIndex = 3;
            this.label7.Text = "Sessions and Not Available Time Allocations";
            // 
            // sessionTimeAllocationpanel
            // 
            this.sessionTimeAllocationpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sessionTimeAllocationpanel.Controls.Add(this.stNotAvailablebtn);
            this.sessionTimeAllocationpanel.Controls.Add(this.timeAllocationsubpannel);
            this.sessionTimeAllocationpanel.Controls.Add(this.stNonOverlappingbtn);
            this.sessionTimeAllocationpanel.Controls.Add(this.stParallelbtn);
            this.sessionTimeAllocationpanel.Controls.Add(this.stConsecutivebtn);
            this.sessionTimeAllocationpanel.Location = new System.Drawing.Point(82, 164);
            this.sessionTimeAllocationpanel.Name = "sessionTimeAllocationpanel";
            this.sessionTimeAllocationpanel.Size = new System.Drawing.Size(794, 438);
            this.sessionTimeAllocationpanel.TabIndex = 30;
            // 
            // timeAllocationsubpannel
            // 
            this.timeAllocationsubpannel.Location = new System.Drawing.Point(12, 56);
            this.timeAllocationsubpannel.Name = "timeAllocationsubpannel";
            this.timeAllocationsubpannel.Size = new System.Drawing.Size(770, 359);
            this.timeAllocationsubpannel.TabIndex = 29;
            this.timeAllocationsubpannel.Paint += new System.Windows.Forms.PaintEventHandler(this.timeAllocationsubpannel_Paint);
            // 
            // stNotAvailablebtn
            // 
            this.stNotAvailablebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.stNotAvailablebtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stNotAvailablebtn.Location = new System.Drawing.Point(353, 4);
            this.stNotAvailablebtn.Name = "stNotAvailablebtn";
            this.stNotAvailablebtn.Size = new System.Drawing.Size(171, 29);
            this.stNotAvailablebtn.TabIndex = 32;
            this.stNotAvailablebtn.Text = "Not Available Times";
            this.stNotAvailablebtn.UseVisualStyleBackColor = false;
            this.stNotAvailablebtn.Click += new System.EventHandler(this.stNotAvailablebtn_Click_1);
            // 
            // stNonOverlappingbtn
            // 
            this.stNonOverlappingbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.stNonOverlappingbtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stNonOverlappingbtn.Location = new System.Drawing.Point(202, 4);
            this.stNonOverlappingbtn.Name = "stNonOverlappingbtn";
            this.stNonOverlappingbtn.Size = new System.Drawing.Size(149, 29);
            this.stNonOverlappingbtn.TabIndex = 31;
            this.stNonOverlappingbtn.Text = "Non Overlapping";
            this.stNonOverlappingbtn.UseVisualStyleBackColor = false;
            // 
            // stParallelbtn
            // 
            this.stParallelbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.stParallelbtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stParallelbtn.Location = new System.Drawing.Point(120, 4);
            this.stParallelbtn.Name = "stParallelbtn";
            this.stParallelbtn.Size = new System.Drawing.Size(80, 29);
            this.stParallelbtn.TabIndex = 30;
            this.stParallelbtn.Text = "Parallel";
            this.stParallelbtn.UseVisualStyleBackColor = false;
            // 
            // stConsecutivebtn
            // 
            this.stConsecutivebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.stConsecutivebtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stConsecutivebtn.Location = new System.Drawing.Point(5, 4);
            this.stConsecutivebtn.Name = "stConsecutivebtn";
            this.stConsecutivebtn.Size = new System.Drawing.Size(112, 29);
            this.stConsecutivebtn.TabIndex = 29;
            this.stConsecutivebtn.Text = "Consecutive";
            this.stConsecutivebtn.UseVisualStyleBackColor = false;
            // 
            // SessionTimeAllocation1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 639);
            this.Controls.Add(this.sessionTimeAllocationpanel);
            this.Controls.Add(this.label7);
            this.Name = "SessionTimeAllocation1";
            this.Text = "SessionTimeAllocation1";
            this.Load += new System.EventHandler(this.SessionTimeAllocation1_Load);
            this.sessionTimeAllocationpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel sessionTime;
        private System.Windows.Forms.Panel sessionTimeAllocationpanel;
        private System.Windows.Forms.Panel timeAllocationsubpannel;
        private System.Windows.Forms.Button stNotAvailablebtn;
        private System.Windows.Forms.Button stNonOverlappingbtn;
        private System.Windows.Forms.Button stParallelbtn;
        private System.Windows.Forms.Button stConsecutivebtn;
    }
}