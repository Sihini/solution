
namespace solution
{
    partial class RoomsNotAvailableTimes2
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
            this.roomsNotAvailableTimepanel2 = new System.Windows.Forms.Panel();
            this.roomsNotAvailableGridView = new System.Windows.Forms.DataGridView();
            this.roomsNotAvailableBackbtn = new System.Windows.Forms.Button();
            this.roomsNotAvailableDeletebtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.roomsNotAvailableTimepanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsNotAvailableGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // roomsNotAvailableTimepanel2
            // 
            this.roomsNotAvailableTimepanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.roomsNotAvailableTimepanel2.Controls.Add(this.roomsNotAvailableGridView);
            this.roomsNotAvailableTimepanel2.Controls.Add(this.roomsNotAvailableBackbtn);
            this.roomsNotAvailableTimepanel2.Controls.Add(this.roomsNotAvailableDeletebtn);
            this.roomsNotAvailableTimepanel2.Controls.Add(this.label8);
            this.roomsNotAvailableTimepanel2.Location = new System.Drawing.Point(0, 0);
            this.roomsNotAvailableTimepanel2.Name = "roomsNotAvailableTimepanel2";
            this.roomsNotAvailableTimepanel2.Size = new System.Drawing.Size(788, 379);
            this.roomsNotAvailableTimepanel2.TabIndex = 32;
            // 
            // roomsNotAvailableGridView
            // 
            this.roomsNotAvailableGridView.AllowUserToAddRows = false;
            this.roomsNotAvailableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomsNotAvailableGridView.Location = new System.Drawing.Point(54, 95);
            this.roomsNotAvailableGridView.Name = "roomsNotAvailableGridView";
            this.roomsNotAvailableGridView.RowHeadersWidth = 51;
            this.roomsNotAvailableGridView.RowTemplate.Height = 29;
            this.roomsNotAvailableGridView.Size = new System.Drawing.Size(681, 188);
            this.roomsNotAvailableGridView.TabIndex = 55;
            this.roomsNotAvailableGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nottimeavalibale_CellContentClick);
            // 
            // roomsNotAvailableBackbtn
            // 
            this.roomsNotAvailableBackbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roomsNotAvailableBackbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roomsNotAvailableBackbtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roomsNotAvailableBackbtn.ForeColor = System.Drawing.Color.White;
            this.roomsNotAvailableBackbtn.Location = new System.Drawing.Point(515, 316);
            this.roomsNotAvailableBackbtn.Name = "roomsNotAvailableBackbtn";
            this.roomsNotAvailableBackbtn.Size = new System.Drawing.Size(110, 35);
            this.roomsNotAvailableBackbtn.TabIndex = 53;
            this.roomsNotAvailableBackbtn.Text = "Back";
            this.roomsNotAvailableBackbtn.UseVisualStyleBackColor = false;
            this.roomsNotAvailableBackbtn.Click += new System.EventHandler(this.roomsNotAvailableBackbtn_Click);
            // 
            // roomsNotAvailableDeletebtn
            // 
            this.roomsNotAvailableDeletebtn.BackColor = System.Drawing.Color.Maroon;
            this.roomsNotAvailableDeletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roomsNotAvailableDeletebtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roomsNotAvailableDeletebtn.ForeColor = System.Drawing.Color.White;
            this.roomsNotAvailableDeletebtn.Location = new System.Drawing.Point(649, 316);
            this.roomsNotAvailableDeletebtn.Name = "roomsNotAvailableDeletebtn";
            this.roomsNotAvailableDeletebtn.Size = new System.Drawing.Size(110, 35);
            this.roomsNotAvailableDeletebtn.TabIndex = 51;
            this.roomsNotAvailableDeletebtn.Text = "Delete";
            this.roomsNotAvailableDeletebtn.UseVisualStyleBackColor = false;
            this.roomsNotAvailableDeletebtn.Click += new System.EventHandler(this.roomsNotAvailableDeletebtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(14, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 21);
            this.label8.TabIndex = 45;
            this.label8.Text = "Not Available Times";
            // 
            // RoomsNotAvailableTimes2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roomsNotAvailableTimepanel2);
            this.Name = "RoomsNotAvailableTimes2";
            this.Text = "RoomsNotAvailableTimes2";
            this.Load += new System.EventHandler(this.RoomsNotAvailableTimes2_Load);
            this.roomsNotAvailableTimepanel2.ResumeLayout(false);
            this.roomsNotAvailableTimepanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsNotAvailableGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel roomsNotAvailableTimepanel2;
        private System.Windows.Forms.Button roomsNotAvailableBackbtn;
        private System.Windows.Forms.Button roomsNotAvailableDeletebtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView roomsNotAvailableGridView;
    }
}