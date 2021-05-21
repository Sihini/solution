
namespace solution
{
    partial class parallelView
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
            this.parallelPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.parallelDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.parallelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parallelDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.parallelPanel);
            this.panel1.Location = new System.Drawing.Point(0, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 499);
            this.panel1.TabIndex = 0;
            // 
            // parallelPanel
            // 
            this.parallelPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.parallelPanel.Controls.Add(this.button2);
            this.parallelPanel.Controls.Add(this.button1);
            this.parallelPanel.Controls.Add(this.parallelDataGridView);
            this.parallelPanel.Location = new System.Drawing.Point(27, 35);
            this.parallelPanel.Name = "parallelPanel";
            this.parallelPanel.Size = new System.Drawing.Size(1006, 405);
            this.parallelPanel.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(493, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(351, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // parallelDataGridView
            // 
            this.parallelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parallelDataGridView.Location = new System.Drawing.Point(16, 17);
            this.parallelDataGridView.Name = "parallelDataGridView";
            this.parallelDataGridView.RowHeadersWidth = 62;
            this.parallelDataGridView.RowTemplate.Height = 33;
            this.parallelDataGridView.Size = new System.Drawing.Size(910, 285);
            this.parallelDataGridView.TabIndex = 0;
            this.parallelDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // parallelView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 799);
            this.Controls.Add(this.panel1);
            this.Name = "parallelView";
            this.Text = "parallelView";
            this.Load += new System.EventHandler(this.parallelView_Load);
            this.panel1.ResumeLayout(false);
            this.parallelPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.parallelDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel parallelPanel;
        private System.Windows.Forms.DataGridView parallelDataGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}