
namespace solution
{
    partial class ManageSessionRooms
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
            this.stNotAvailablebtn = new System.Windows.Forms.Button();
            this.stNonOverlappingbtn = new System.Windows.Forms.Button();
            this.stConsecutivebtn = new System.Windows.Forms.Button();
            this.sessionTimeAllocationpanel = new System.Windows.Forms.Panel();
            this.notAvailableTimepanel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.sessionTimeAllocationpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // stNotAvailablebtn
            // 
            this.stNotAvailablebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.stNotAvailablebtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stNotAvailablebtn.Location = new System.Drawing.Point(210, 1);
            this.stNotAvailablebtn.Name = "stNotAvailablebtn";
            this.stNotAvailablebtn.Size = new System.Drawing.Size(171, 29);
            this.stNotAvailablebtn.TabIndex = 28;
            this.stNotAvailablebtn.Text = "Not Available Times";
            this.stNotAvailablebtn.UseVisualStyleBackColor = false;
            // 
            // stNonOverlappingbtn
            // 
            this.stNonOverlappingbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.stNonOverlappingbtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stNonOverlappingbtn.Location = new System.Drawing.Point(0, 0);
            this.stNonOverlappingbtn.Name = "stNonOverlappingbtn";
            this.stNonOverlappingbtn.Size = new System.Drawing.Size(92, 29);
            this.stNonOverlappingbtn.TabIndex = 27;
            this.stNonOverlappingbtn.Text = "Sessions";
            this.stNonOverlappingbtn.UseVisualStyleBackColor = false;
            // 
            // stConsecutivebtn
            // 
            this.stConsecutivebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.stConsecutivebtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stConsecutivebtn.Location = new System.Drawing.Point(95, 1);
            this.stConsecutivebtn.Name = "stConsecutivebtn";
            this.stConsecutivebtn.Size = new System.Drawing.Size(112, 29);
            this.stConsecutivebtn.TabIndex = 25;
            this.stConsecutivebtn.Text = "Consecutive";
            this.stConsecutivebtn.UseVisualStyleBackColor = false;
            // 
            // sessionTimeAllocationpanel
            // 
            this.sessionTimeAllocationpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sessionTimeAllocationpanel.Controls.Add(this.stConsecutivebtn);
            this.sessionTimeAllocationpanel.Controls.Add(this.notAvailableTimepanel3);
            this.sessionTimeAllocationpanel.Controls.Add(this.stNotAvailablebtn);
            this.sessionTimeAllocationpanel.Controls.Add(this.stNonOverlappingbtn);
            this.sessionTimeAllocationpanel.Location = new System.Drawing.Point(90, 145);
            this.sessionTimeAllocationpanel.Name = "sessionTimeAllocationpanel";
            this.sessionTimeAllocationpanel.Size = new System.Drawing.Size(794, 438);
            this.sessionTimeAllocationpanel.TabIndex = 32;
            // 
            // notAvailableTimepanel3
            // 
            this.notAvailableTimepanel3.Location = new System.Drawing.Point(3, 30);
            this.notAvailableTimepanel3.Name = "notAvailableTimepanel3";
            this.notAvailableTimepanel3.Size = new System.Drawing.Size(788, 379);
            this.notAvailableTimepanel3.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(390, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 35);
            this.label7.TabIndex = 33;
            this.label7.Text = "Add Location";
            // 
            // ManageSessionRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 639);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sessionTimeAllocationpanel);
            this.Name = "ManageSessionRooms";
            this.Text = "ManageSessionRooms";
            this.Load += new System.EventHandler(this.ManageSessionRooms_Load);
            this.sessionTimeAllocationpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stNotAvailablebtn;
        private System.Windows.Forms.Button stNonOverlappingbtn;
        private System.Windows.Forms.Button stConsecutivebtn;
        private System.Windows.Forms.Panel sessionTimeAllocationpanel;
        private System.Windows.Forms.Panel notAvailableTimepanel3;
        private System.Windows.Forms.Label label7;
    }
}