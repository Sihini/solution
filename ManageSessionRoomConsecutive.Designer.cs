
namespace solution
{
    partial class ManageSessionRoomConsecutive
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
            this.CRpanel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.deleteLocationbtn = new System.Windows.Forms.Button();
            this.MSRconsecutive = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.CRpanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MSRconsecutive)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.CRpanel2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 391);
            this.panel1.TabIndex = 0;
            // 
            // CRpanel2
            // 
            this.CRpanel2.Controls.Add(this.button1);
            this.CRpanel2.Controls.Add(this.deleteLocationbtn);
            this.CRpanel2.Controls.Add(this.MSRconsecutive);
            this.CRpanel2.Location = new System.Drawing.Point(0, 0);
            this.CRpanel2.Name = "CRpanel2";
            this.CRpanel2.Size = new System.Drawing.Size(939, 391);
            this.CRpanel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(453, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 44);
            this.button1.TabIndex = 54;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteLocationbtn
            // 
            this.deleteLocationbtn.BackColor = System.Drawing.Color.Red;
            this.deleteLocationbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteLocationbtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.deleteLocationbtn.Location = new System.Drawing.Point(622, 176);
            this.deleteLocationbtn.Name = "deleteLocationbtn";
            this.deleteLocationbtn.Size = new System.Drawing.Size(137, 44);
            this.deleteLocationbtn.TabIndex = 53;
            this.deleteLocationbtn.Text = "Delete";
            this.deleteLocationbtn.UseVisualStyleBackColor = false;
            this.deleteLocationbtn.Click += new System.EventHandler(this.deleteLocationbtn_Click_1);
            // 
            // MSRconsecutive
            // 
            this.MSRconsecutive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MSRconsecutive.Location = new System.Drawing.Point(24, 24);
            this.MSRconsecutive.Name = "MSRconsecutive";
            this.MSRconsecutive.RowTemplate.Height = 25;
            this.MSRconsecutive.Size = new System.Drawing.Size(772, 125);
            this.MSRconsecutive.TabIndex = 0;
            this.MSRconsecutive.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MSRconsecutive_CellContentClick);
            // 
            // ManageSessionRoomConsecutive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ManageSessionRoomConsecutive";
            this.Text = "ManageSessionRoomConsecutive";
            this.Load += new System.EventHandler(this.ManageSessionRoomConsecutive_Load);
            this.panel1.ResumeLayout(false);
            this.CRpanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MSRconsecutive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel CRpanel2;
        private System.Windows.Forms.DataGridView MSRconsecutive;
        private System.Windows.Forms.Button deleteLocationbtn;
        private System.Windows.Forms.Button button1;
    }
}