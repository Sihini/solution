
namespace solution
{
    partial class ManageSessionRoomNext
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
            this.btnNotav = new System.Windows.Forms.Button();
            this.consbtn = new System.Windows.Forms.Button();
            this.btnaddRoom = new System.Windows.Forms.Button();
            this.MSRGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.select = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sesbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MSRGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.sesbtn);
            this.panel1.Controls.Add(this.btnNotav);
            this.panel1.Controls.Add(this.consbtn);
            this.panel1.Controls.Add(this.btnaddRoom);
            this.panel1.Controls.Add(this.MSRGridView);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 391);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnNotav
            // 
            this.btnNotav.Location = new System.Drawing.Point(206, 12);
            this.btnNotav.Name = "btnNotav";
            this.btnNotav.Size = new System.Drawing.Size(143, 23);
            this.btnNotav.TabIndex = 15;
            this.btnNotav.Text = "NotAvailable Times";
            this.btnNotav.UseVisualStyleBackColor = true;
            // 
            // consbtn
            // 
            this.consbtn.Location = new System.Drawing.Point(112, 12);
            this.consbtn.Name = "consbtn";
            this.consbtn.Size = new System.Drawing.Size(97, 23);
            this.consbtn.TabIndex = 14;
            this.consbtn.Text = "Consecutive";
            this.consbtn.UseVisualStyleBackColor = true;
            this.consbtn.Click += new System.EventHandler(this.consbtn_Click);
            // 
            // btnaddRoom
            // 
            this.btnaddRoom.BackColor = System.Drawing.Color.LimeGreen;
            this.btnaddRoom.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnaddRoom.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnaddRoom.Location = new System.Drawing.Point(764, 262);
            this.btnaddRoom.Name = "btnaddRoom";
            this.btnaddRoom.Size = new System.Drawing.Size(100, 41);
            this.btnaddRoom.TabIndex = 12;
            this.btnaddRoom.Text = "Add Room";
            this.btnaddRoom.UseVisualStyleBackColor = false;
            this.btnaddRoom.Click += new System.EventHandler(this.btnaddRoom_Click_2);
            // 
            // MSRGridView
            // 
            this.MSRGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MSRGridView.Location = new System.Drawing.Point(18, 34);
            this.MSRGridView.Name = "MSRGridView";
            this.MSRGridView.RowTemplate.Height = 25;
            this.MSRGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MSRGridView.Size = new System.Drawing.Size(862, 129);
            this.MSRGridView.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(-2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(939, 391);
            this.panel2.TabIndex = 0;
            // 
            // select
            // 
            this.select.HeaderText = "Select";
            this.select.Name = "select";
            // 
            // sesbtn
            // 
            this.sesbtn.Location = new System.Drawing.Point(18, 12);
            this.sesbtn.Name = "sesbtn";
            this.sesbtn.Size = new System.Drawing.Size(97, 23);
            this.sesbtn.TabIndex = 16;
            this.sesbtn.Text = "Sessions";
            this.sesbtn.UseVisualStyleBackColor = true;
            // 
            // ManageSessionRoomNext
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 500);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ManageSessionRoomNext";
            this.Text = "ManageSessionRoomNext";
            this.Load += new System.EventHandler(this.ManageSessionRoomNext_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MSRGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNotav;
        private System.Windows.Forms.Button consbtn;
        private System.Windows.Forms.Button btnaddRoom;
        private System.Windows.Forms.DataGridView MSRGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn select;
        private System.Windows.Forms.Button sesbtn;
    }
}