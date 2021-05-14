
namespace solution
{
    partial class sessionView
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
            this.sessionviewdataGridView = new System.Windows.Forms.DataGridView();
            this.exportsessionbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionviewdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.exportsessionbtn);
            this.panel1.Controls.Add(this.sessionviewdataGridView);
            this.panel1.Location = new System.Drawing.Point(-2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 610);
            this.panel1.TabIndex = 1;
            // 
            // sessionviewdataGridView
            // 
            this.sessionviewdataGridView.AllowUserToAddRows = false;
            this.sessionviewdataGridView.AllowUserToDeleteRows = false;
            this.sessionviewdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sessionviewdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sessionviewdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sessionviewdataGridView.Location = new System.Drawing.Point(4, 106);
            this.sessionviewdataGridView.Name = "sessionviewdataGridView";
            this.sessionviewdataGridView.ReadOnly = true;
            this.sessionviewdataGridView.RowHeadersWidth = 51;
            this.sessionviewdataGridView.RowTemplate.Height = 29;
            this.sessionviewdataGridView.Size = new System.Drawing.Size(925, 504);
            this.sessionviewdataGridView.TabIndex = 0;
            this.sessionviewdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sessionviewdataGridView_CellContentClick);
            // 
            // exportsessionbtn
            // 
            this.exportsessionbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.exportsessionbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exportsessionbtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.exportsessionbtn.Location = new System.Drawing.Point(839, 38);
            this.exportsessionbtn.Name = "exportsessionbtn";
            this.exportsessionbtn.Size = new System.Drawing.Size(137, 44);
            this.exportsessionbtn.TabIndex = 27;
            this.exportsessionbtn.Text = "Export";
            this.exportsessionbtn.UseVisualStyleBackColor = false;
            this.exportsessionbtn.Click += new System.EventHandler(this.exportsessionbtn_Click);
            // 
            // sessionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 625);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "sessionView";
            this.Text = "sessionView";
            this.Load += new System.EventHandler(this.sessionView_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sessionviewdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView sessionviewdataGridView;
        private System.Windows.Forms.Button exportsessionbtn;
    }
}