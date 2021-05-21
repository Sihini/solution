
namespace solution
{
    partial class NotTimeAvailable2
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
            this.label8 = new System.Windows.Forms.Label();
            this.stNotAvailableDeletebtn = new System.Windows.Forms.Button();
            this.stNotAvailableViewbtn = new System.Windows.Forms.Button();
            this.notAvailableTimepanel2 = new System.Windows.Forms.Panel();
            this.nottimeavalibale = new System.Windows.Forms.DataGridView();
            this.notAvailableTimepanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nottimeavalibale)).BeginInit();
            this.SuspendLayout();
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
            // stNotAvailableDeletebtn
            // 
            this.stNotAvailableDeletebtn.BackColor = System.Drawing.Color.Maroon;
            this.stNotAvailableDeletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stNotAvailableDeletebtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stNotAvailableDeletebtn.ForeColor = System.Drawing.Color.White;
            this.stNotAvailableDeletebtn.Location = new System.Drawing.Point(649, 316);
            this.stNotAvailableDeletebtn.Name = "stNotAvailableDeletebtn";
            this.stNotAvailableDeletebtn.Size = new System.Drawing.Size(110, 35);
            this.stNotAvailableDeletebtn.TabIndex = 51;
            this.stNotAvailableDeletebtn.Text = "Delete";
            this.stNotAvailableDeletebtn.UseVisualStyleBackColor = false;
            this.stNotAvailableDeletebtn.Click += new System.EventHandler(this.stNotAvailableDeletebtn_Click);
            // 
            // stNotAvailableViewbtn
            // 
            this.stNotAvailableViewbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stNotAvailableViewbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stNotAvailableViewbtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stNotAvailableViewbtn.ForeColor = System.Drawing.Color.White;
            this.stNotAvailableViewbtn.Location = new System.Drawing.Point(515, 316);
            this.stNotAvailableViewbtn.Name = "stNotAvailableViewbtn";
            this.stNotAvailableViewbtn.Size = new System.Drawing.Size(110, 35);
            this.stNotAvailableViewbtn.TabIndex = 53;
            this.stNotAvailableViewbtn.Text = "Back";
            this.stNotAvailableViewbtn.UseVisualStyleBackColor = false;
            this.stNotAvailableViewbtn.Click += new System.EventHandler(this.stNotAvailableViewbtn_Click);
            // 
            // notAvailableTimepanel2
            // 
            this.notAvailableTimepanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.notAvailableTimepanel2.Controls.Add(this.nottimeavalibale);
            this.notAvailableTimepanel2.Controls.Add(this.stNotAvailableViewbtn);
            this.notAvailableTimepanel2.Controls.Add(this.stNotAvailableDeletebtn);
            this.notAvailableTimepanel2.Controls.Add(this.label8);
            this.notAvailableTimepanel2.Location = new System.Drawing.Point(0, 0);
            this.notAvailableTimepanel2.Name = "notAvailableTimepanel2";
            this.notAvailableTimepanel2.Size = new System.Drawing.Size(788, 379);
            this.notAvailableTimepanel2.TabIndex = 31;
            // 
            // nottimeavalibale
            // 
            this.nottimeavalibale.AllowUserToAddRows = false;
            this.nottimeavalibale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nottimeavalibale.Location = new System.Drawing.Point(50, 80);
            this.nottimeavalibale.Name = "nottimeavalibale";
            this.nottimeavalibale.RowHeadersWidth = 51;
            this.nottimeavalibale.RowTemplate.Height = 29;
            this.nottimeavalibale.Size = new System.Drawing.Size(681, 188);
            this.nottimeavalibale.TabIndex = 54;
            this.nottimeavalibale.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nottimeavalibale_CellContentClick_1);
            // 
            // NotTimeAvailable2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(811, 451);
            this.Controls.Add(this.notAvailableTimepanel2);
            this.Name = "NotTimeAvailable2";
            this.Text = "NotTimeAvailable2";
            this.Load += new System.EventHandler(this.NotTimeAvailable2_Load);
            this.notAvailableTimepanel2.ResumeLayout(false);
            this.notAvailableTimepanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nottimeavalibale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button stNotAvailableDeletebtn;
        private System.Windows.Forms.Button stNotAvailableViewbtn;
        private System.Windows.Forms.Panel notAvailableTimepanel2;
        private System.Windows.Forms.DataGridView nottimeavalibale;
    }
}