
namespace solution
{
    partial class consecutiveView
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
            this.sessionavalibale = new System.Windows.Forms.Panel();
            this.conView = new System.Windows.Forms.Panel();
            this.consecutiveGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sessionavalibale.SuspendLayout();
            this.conView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consecutiveGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sessionavalibale
            // 
            this.sessionavalibale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sessionavalibale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sessionavalibale.Controls.Add(this.conView);
            this.sessionavalibale.Location = new System.Drawing.Point(0, 0);
            this.sessionavalibale.Margin = new System.Windows.Forms.Padding(4);
            this.sessionavalibale.Name = "sessionavalibale";
            this.sessionavalibale.Size = new System.Drawing.Size(1089, 499);
            this.sessionavalibale.TabIndex = 32;
            this.sessionavalibale.Paint += new System.Windows.Forms.PaintEventHandler(this.sessionavalibale_Paint);
            // 
            // conView
            // 
            this.conView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.conView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.conView.Controls.Add(this.consecutiveGridView1);
            this.conView.Controls.Add(this.button2);
            this.conView.Controls.Add(this.button1);
            this.conView.Location = new System.Drawing.Point(13, 35);
            this.conView.Margin = new System.Windows.Forms.Padding(4);
            this.conView.Name = "conView";
            this.conView.Size = new System.Drawing.Size(1006, 427);
            this.conView.TabIndex = 30;
            this.conView.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // consecutiveGridView1
            // 
            this.consecutiveGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consecutiveGridView1.Location = new System.Drawing.Point(0, 23);
            this.consecutiveGridView1.Name = "consecutiveGridView1";
            this.consecutiveGridView1.RowHeadersWidth = 62;
            this.consecutiveGridView1.RowTemplate.Height = 33;
            this.consecutiveGridView1.Size = new System.Drawing.Size(910, 282);
            this.consecutiveGridView1.TabIndex = 47;
            this.consecutiveGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.consecutiveGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(463, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 52);
            this.button2.TabIndex = 46;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(159)))), ((int)(((byte)(2)))));
            this.button1.Location = new System.Drawing.Point(301, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 52);
            this.button1.TabIndex = 44;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // consecutiveView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 799);
            this.Controls.Add(this.sessionavalibale);
            this.Name = "consecutiveView";
            this.Text = "consecutiveView";
            this.Load += new System.EventHandler(this.consecutiveView_Load);
            this.sessionavalibale.ResumeLayout(false);
            this.conView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.consecutiveGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sessionavalibale;
        private System.Windows.Forms.Panel conView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView consecutiveGridView1;
    }
}