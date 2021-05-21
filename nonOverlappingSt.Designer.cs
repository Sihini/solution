
namespace solution
{
    partial class nonOverlappingSt
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
            this.nonOvelappingPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nonOverlappingGrid = new System.Windows.Forms.DataGridView();
            this.nonOvelappingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nonOverlappingGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // nonOvelappingPanel
            // 
            this.nonOvelappingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nonOvelappingPanel.Controls.Add(this.button2);
            this.nonOvelappingPanel.Controls.Add(this.button1);
            this.nonOvelappingPanel.Controls.Add(this.nonOverlappingGrid);
            this.nonOvelappingPanel.Location = new System.Drawing.Point(0, 74);
            this.nonOvelappingPanel.Name = "nonOvelappingPanel";
            this.nonOvelappingPanel.Size = new System.Drawing.Size(1093, 519);
            this.nonOvelappingPanel.TabIndex = 0;
            this.nonOvelappingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.nonOvelappingPanel_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(417, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 51);
            this.button2.TabIndex = 50;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(264, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 51);
            this.button1.TabIndex = 49;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nonOverlappingGrid
            // 
            this.nonOverlappingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nonOverlappingGrid.Location = new System.Drawing.Point(24, 66);
            this.nonOverlappingGrid.Name = "nonOverlappingGrid";
            this.nonOverlappingGrid.RowHeadersWidth = 62;
            this.nonOverlappingGrid.RowTemplate.Height = 33;
            this.nonOverlappingGrid.Size = new System.Drawing.Size(923, 234);
            this.nonOverlappingGrid.TabIndex = 0;
            this.nonOverlappingGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nonOverlappingGrid_CellContentClick);
            // 
            // nonOverlappingSt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 779);
            this.Controls.Add(this.nonOvelappingPanel);
            this.Name = "nonOverlappingSt";
            this.Text = "nonOverlappingSt";
            this.Load += new System.EventHandler(this.nonOverlappingSt_Load);
            this.nonOvelappingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nonOverlappingGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel nonOvelappingPanel;
        private System.Windows.Forms.DataGridView nonOverlappingGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}