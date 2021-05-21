
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
            this.label10 = new System.Windows.Forms.Label();

            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionviewdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
           
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(297, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(273, 35);
            this.label10.TabIndex = 28;
            this.label10.Text = "View All Session";
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
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionviewdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView sessionviewdataGridView;
        private System.Windows.Forms.Label label10;
    }
}