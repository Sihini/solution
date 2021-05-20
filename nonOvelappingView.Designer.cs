
namespace solution
{
    partial class nonOvelappingView
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
            this.nonOverlappingPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nonOveralappingGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.nonOverlappingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nonOveralappingGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.nonOverlappingPanel);
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 499);
            this.panel1.TabIndex = 0;
            // 
            // nonOverlappingPanel
            // 
            this.nonOverlappingPanel.Controls.Add(this.button2);
            this.nonOverlappingPanel.Controls.Add(this.button1);
            this.nonOverlappingPanel.Controls.Add(this.nonOveralappingGridView);
            this.nonOverlappingPanel.Location = new System.Drawing.Point(33, 38);
            this.nonOverlappingPanel.Name = "nonOverlappingPanel";
            this.nonOverlappingPanel.Size = new System.Drawing.Size(1006, 405);
            this.nonOverlappingPanel.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(501, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(367, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nonOveralappingGridView
            // 
            this.nonOveralappingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nonOveralappingGridView.Location = new System.Drawing.Point(21, 32);
            this.nonOveralappingGridView.Name = "nonOveralappingGridView";
            this.nonOveralappingGridView.RowHeadersWidth = 62;
            this.nonOveralappingGridView.RowTemplate.Height = 33;
            this.nonOveralappingGridView.Size = new System.Drawing.Size(910, 271);
            this.nonOveralappingGridView.TabIndex = 0;
            // 
            // nonOvelappingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 799);
            this.Controls.Add(this.panel1);
            this.Name = "nonOvelappingView";
            this.Text = "nonOvelappingView";
            this.Load += new System.EventHandler(this.nonOvelappingView_Load);
            this.panel1.ResumeLayout(false);
            this.nonOverlappingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nonOveralappingGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel nonOverlappingPanel;
        private System.Windows.Forms.DataGridView nonOveralappingGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}