
namespace solution
{
    partial class parallelSt
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
            this.parallelView = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.parallelGridView = new System.Windows.Forms.DataGridView();
            this.parallelView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parallelGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // parallelView
            // 
            this.parallelView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.parallelView.Controls.Add(this.button2);
            this.parallelView.Controls.Add(this.button1);
            this.parallelView.Controls.Add(this.parallelGridView);
            this.parallelView.Location = new System.Drawing.Point(0, 69);
            this.parallelView.Name = "parallelView";
            this.parallelView.Size = new System.Drawing.Size(1093, 519);
            this.parallelView.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(509, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(352, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // parallelGridView
            // 
            this.parallelGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parallelGridView.Location = new System.Drawing.Point(33, 78);
            this.parallelGridView.Name = "parallelGridView";
            this.parallelGridView.RowHeadersWidth = 62;
            this.parallelGridView.RowTemplate.Height = 33;
            this.parallelGridView.Size = new System.Drawing.Size(907, 225);
            this.parallelGridView.TabIndex = 0;
            this.parallelGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // parallelSt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 779);
            this.Controls.Add(this.parallelView);
            this.Name = "parallelSt";
            this.Text = "parallelSt";
            this.Load += new System.EventHandler(this.parallelSt_Load);
            this.parallelView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.parallelGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel parallelView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView parallelGridView;
    }
}