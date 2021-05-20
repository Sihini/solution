
namespace solution
{
    partial class consecutive
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
            this.consectivepanle = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.consecutiveViewgrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.consectivepanle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consecutiveViewgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // consectivepanle
            // 
            this.consectivepanle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.consectivepanle.Controls.Add(this.button2);
            this.consectivepanle.Controls.Add(this.button1);
            this.consectivepanle.Controls.Add(this.consecutiveViewgrid);
            this.consectivepanle.Controls.Add(this.label2);
            this.consectivepanle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.consectivepanle.Location = new System.Drawing.Point(0, 70);
            this.consectivepanle.Name = "consectivepanle";
            this.consectivepanle.Size = new System.Drawing.Size(1042, 519);
            this.consectivepanle.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(502, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 45);
            this.button2.TabIndex = 49;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(343, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 45);
            this.button1.TabIndex = 48;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // consecutiveViewgrid
            // 
            this.consecutiveViewgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consecutiveViewgrid.Location = new System.Drawing.Point(26, 109);
            this.consecutiveViewgrid.Name = "consecutiveViewgrid";
            this.consecutiveViewgrid.RowHeadersWidth = 51;
            this.consecutiveViewgrid.RowTemplate.Height = 29;
            this.consecutiveViewgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.consecutiveViewgrid.Size = new System.Drawing.Size(920, 251);
            this.consecutiveViewgrid.TabIndex = 47;
            this.consecutiveViewgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.managesubjectview_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(-172, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "]";
            // 
            // consecutive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 779);
            this.Controls.Add(this.consectivepanle);
            this.Name = "consecutive";
            this.Text = "consecutive";
            this.Load += new System.EventHandler(this.consecutive_Load);
            this.consectivepanle.ResumeLayout(false);
            this.consectivepanle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consecutiveViewgrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel consectivepanle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView consecutiveViewgrid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}