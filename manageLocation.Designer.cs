
namespace solution
{
    partial class manageLocation
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
            this.LocationdataGridView = new System.Windows.Forms.DataGridView();
            this.txtcapacity = new System.Windows.Forms.TextBox();
            this.labradiobtn = new System.Windows.Forms.RadioButton();
            this.lecturradiobtn = new System.Windows.Forms.RadioButton();
            this.txtroomname = new System.Windows.Forms.TextBox();
            this.txtBuildingname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearlocationtbtn = new System.Windows.Forms.Button();
            this.deleteLocationbtn = new System.Windows.Forms.Button();
            this.manageLocationbtn = new System.Windows.Forms.Button();
            this.txtsearchlocation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LocationdataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LocationdataGridView
            // 
            this.LocationdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LocationdataGridView.Location = new System.Drawing.Point(10, 51);
            this.LocationdataGridView.Name = "LocationdataGridView";
            this.LocationdataGridView.RowTemplate.Height = 25;
            this.LocationdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LocationdataGridView.Size = new System.Drawing.Size(803, 110);
            this.LocationdataGridView.TabIndex = 1;
            this.LocationdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LocationdataGridView_CellContentClick);
            // 
            // txtcapacity
            // 
            this.txtcapacity.Location = new System.Drawing.Point(565, 253);
            this.txtcapacity.Name = "txtcapacity";
            this.txtcapacity.Size = new System.Drawing.Size(179, 23);
            this.txtcapacity.TabIndex = 26;
            // 
            // labradiobtn
            // 
            this.labradiobtn.AutoSize = true;
            this.labradiobtn.Location = new System.Drawing.Point(565, 208);
            this.labradiobtn.Name = "labradiobtn";
            this.labradiobtn.Size = new System.Drawing.Size(82, 19);
            this.labradiobtn.TabIndex = 25;
            this.labradiobtn.TabStop = true;
            this.labradiobtn.Text = "Laboratory";
            this.labradiobtn.UseVisualStyleBackColor = true;
            // 
            // lecturradiobtn
            // 
            this.lecturradiobtn.AutoSize = true;
            this.lecturradiobtn.Location = new System.Drawing.Point(565, 183);
            this.lecturradiobtn.Name = "lecturradiobtn";
            this.lecturradiobtn.Size = new System.Drawing.Size(92, 19);
            this.lecturradiobtn.TabIndex = 24;
            this.lecturradiobtn.TabStop = true;
            this.lecturradiobtn.Text = "Lecturer Hall";
            this.lecturradiobtn.UseVisualStyleBackColor = true;
            // 
            // txtroomname
            // 
            this.txtroomname.Location = new System.Drawing.Point(194, 253);
            this.txtroomname.Name = "txtroomname";
            this.txtroomname.Size = new System.Drawing.Size(192, 23);
            this.txtroomname.TabIndex = 23;
            // 
            // txtBuildingname
            // 
            this.txtBuildingname.Location = new System.Drawing.Point(194, 179);
            this.txtBuildingname.Name = "txtBuildingname";
            this.txtBuildingname.Size = new System.Drawing.Size(192, 23);
            this.txtBuildingname.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(65, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Lecturer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(411, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Lecturer Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(411, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Lecturer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(65, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Lecturer Name";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.txtsearchlocation);
            this.panel1.Controls.Add(this.clearlocationtbtn);
            this.panel1.Controls.Add(this.deleteLocationbtn);
            this.panel1.Controls.Add(this.manageLocationbtn);
            this.panel1.Controls.Add(this.LocationdataGridView);
            this.panel1.Controls.Add(this.txtcapacity);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labradiobtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lecturradiobtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtroomname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtBuildingname);
            this.panel1.Location = new System.Drawing.Point(23, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 351);
            this.panel1.TabIndex = 27;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // clearlocationtbtn
            // 
            this.clearlocationtbtn.BackColor = System.Drawing.Color.DarkOrange;
            this.clearlocationtbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearlocationtbtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.clearlocationtbtn.Location = new System.Drawing.Point(520, 294);
            this.clearlocationtbtn.Name = "clearlocationtbtn";
            this.clearlocationtbtn.Size = new System.Drawing.Size(137, 44);
            this.clearlocationtbtn.TabIndex = 53;
            this.clearlocationtbtn.Text = "Clear";
            this.clearlocationtbtn.UseVisualStyleBackColor = false;
            this.clearlocationtbtn.Click += new System.EventHandler(this.clearlocationtbtn_Click);
            // 
            // deleteLocationbtn
            // 
            this.deleteLocationbtn.BackColor = System.Drawing.Color.Red;
            this.deleteLocationbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteLocationbtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.deleteLocationbtn.Location = new System.Drawing.Point(712, 305);
            this.deleteLocationbtn.Name = "deleteLocationbtn";
            this.deleteLocationbtn.Size = new System.Drawing.Size(137, 44);
            this.deleteLocationbtn.TabIndex = 52;
            this.deleteLocationbtn.Text = "Delete";
            this.deleteLocationbtn.UseVisualStyleBackColor = false;
            this.deleteLocationbtn.Click += new System.EventHandler(this.deleteLocationbtn_Click);
            // 
            // manageLocationbtn
            // 
            this.manageLocationbtn.BackColor = System.Drawing.Color.LimeGreen;
            this.manageLocationbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.manageLocationbtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.manageLocationbtn.Location = new System.Drawing.Point(712, 172);
            this.manageLocationbtn.Name = "manageLocationbtn";
            this.manageLocationbtn.Size = new System.Drawing.Size(137, 44);
            this.manageLocationbtn.TabIndex = 50;
            this.manageLocationbtn.Text = "Update";
            this.manageLocationbtn.UseVisualStyleBackColor = false;
            this.manageLocationbtn.Click += new System.EventHandler(this.manageLocationbtn_Click);
            // 
            // txtsearchlocation
            // 
            this.txtsearchlocation.Location = new System.Drawing.Point(580, 22);
            this.txtsearchlocation.Name = "txtsearchlocation";
            this.txtsearchlocation.Size = new System.Drawing.Size(215, 23);
            this.txtsearchlocation.TabIndex = 54;
            this.txtsearchlocation.TextChanged += new System.EventHandler(this.txtsearchlocation_TextChanged);
            // 
            // manageLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "manageLocation";
            this.Text = "manageLocation";
            this.Load += new System.EventHandler(this.manageLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LocationdataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView LocationdataGridView;
        private System.Windows.Forms.TextBox txtcapacity;
        private System.Windows.Forms.RadioButton labradiobtn;
        private System.Windows.Forms.RadioButton lecturradiobtn;
        private System.Windows.Forms.TextBox txtroomname;
        private System.Windows.Forms.TextBox txtBuildingname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteLocationbtn;
        private System.Windows.Forms.Button manageLocationbtn;
        private System.Windows.Forms.Button clearlocationtbtn;
        private System.Windows.Forms.TextBox txtsearchlocation;
    }
}