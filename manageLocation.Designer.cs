
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsearchlocation = new System.Windows.Forms.TextBox();
            this.clearlocationtbtn = new System.Windows.Forms.Button();
            this.deleteLocationbtn = new System.Windows.Forms.Button();
            this.manageLocationbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LocationdataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LocationdataGridView
            // 
            this.LocationdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LocationdataGridView.Location = new System.Drawing.Point(14, 85);
            this.LocationdataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LocationdataGridView.Name = "LocationdataGridView";
            this.LocationdataGridView.RowHeadersWidth = 51;
            this.LocationdataGridView.RowTemplate.Height = 25;
            this.LocationdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LocationdataGridView.Size = new System.Drawing.Size(1148, 184);
            this.LocationdataGridView.TabIndex = 1;
            this.LocationdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LocationdataGridView_CellContentClick);
            // 
            // txtcapacity
            // 
            this.txtcapacity.Location = new System.Drawing.Point(674, 490);
            this.txtcapacity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcapacity.Name = "txtcapacity";

            this.txtcapacity.Size = new System.Drawing.Size(241, 27);

            this.txtcapacity.TabIndex = 26;
            // 
            // labradiobtn
            // 
            this.labradiobtn.AutoSize = true;
            this.labradiobtn.Location = new System.Drawing.Point(708, 425);
            this.labradiobtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labradiobtn.Name = "labradiobtn";

            this.labradiobtn.Size = new System.Drawing.Size(102, 24);

            this.labradiobtn.TabIndex = 25;
            this.labradiobtn.TabStop = true;
            this.labradiobtn.Text = "Laboratory";
            this.labradiobtn.UseVisualStyleBackColor = true;
            this.labradiobtn.CheckedChanged += new System.EventHandler(this.labradiobtn_CheckedChanged);
            // 
            // lecturradiobtn
            // 
            this.lecturradiobtn.AutoSize = true;
            this.lecturradiobtn.Location = new System.Drawing.Point(708, 384);
            this.lecturradiobtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lecturradiobtn.Name = "lecturradiobtn";

            this.lecturradiobtn.Size = new System.Drawing.Size(114, 24);

            this.lecturradiobtn.TabIndex = 24;
            this.lecturradiobtn.TabStop = true;
            this.lecturradiobtn.Text = "Lecturer Hall";
            this.lecturradiobtn.UseVisualStyleBackColor = true;
            // 
            // txtroomname
            // 
            this.txtroomname.Location = new System.Drawing.Point(241, 490);
            this.txtroomname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtroomname.Name = "txtroomname";

            this.txtroomname.Size = new System.Drawing.Size(241, 27);

            this.txtroomname.TabIndex = 23;
            // 
            // txtBuildingname
            // 
            this.txtBuildingname.Location = new System.Drawing.Point(241, 380);
            this.txtBuildingname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuildingname.Name = "txtBuildingname";

            this.txtBuildingname.Size = new System.Drawing.Size(241, 27);

            this.txtBuildingname.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Room Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(526, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Room Type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(526, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Capacity";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtsearchlocation);
            this.panel1.Controls.Add(this.clearlocationtbtn);
            this.panel1.Controls.Add(this.deleteLocationbtn);
            this.panel1.Controls.Add(this.manageLocationbtn);
            this.panel1.Controls.Add(this.LocationdataGridView);
            this.panel1.Controls.Add(this.txtcapacity);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labradiobtn);
            this.panel1.Controls.Add(this.lecturradiobtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtroomname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtBuildingname);
            this.panel1.Location = new System.Drawing.Point(33, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1229, 710);
            this.panel1.TabIndex = 27;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 23);
            this.label5.TabIndex = 55;
            this.label5.Text = "Building Name";
            // 
            // txtsearchlocation
            // 
            this.txtsearchlocation.Location = new System.Drawing.Point(854, 21);
            this.txtsearchlocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsearchlocation.Name = "txtsearchlocation";
            this.txtsearchlocation.PlaceholderText = "Search ";

            this.txtsearchlocation.Size = new System.Drawing.Size(306, 27);

            this.txtsearchlocation.TabIndex = 54;
            this.txtsearchlocation.TextChanged += new System.EventHandler(this.txtsearchlocation_TextChanged);
            // 
            // clearlocationtbtn
            // 
            this.clearlocationtbtn.BackColor = System.Drawing.Color.DarkOrange;
            this.clearlocationtbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearlocationtbtn.ForeColor = System.Drawing.SystemColors.HighlightText;

            this.clearlocationtbtn.Image = global::solution.Properties.Resources.clear;
            this.clearlocationtbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.clearlocationtbtn.Location = new System.Drawing.Point(994, 580);
            this.clearlocationtbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearlocationtbtn.Name = "clearlocationtbtn";
            this.clearlocationtbtn.Size = new System.Drawing.Size(196, 74);
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

         //   this.deleteLocationbtn.Image = global::solution.Properties.Resources.delete;
            this.deleteLocationbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.deleteLocationbtn.Location = new System.Drawing.Point(994, 466);
            this.deleteLocationbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteLocationbtn.Name = "deleteLocationbtn";
            this.deleteLocationbtn.Size = new System.Drawing.Size(196, 74);
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

          //  this.manageLocationbtn.Image = global::solution.Properties.Resources.update;
            this.manageLocationbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.manageLocationbtn.Location = new System.Drawing.Point(994, 345);
            this.manageLocationbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.manageLocationbtn.Name = "manageLocationbtn";
            this.manageLocationbtn.Size = new System.Drawing.Size(196, 74);
            this.manageLocationbtn.TabIndex = 50;
            this.manageLocationbtn.Text = "Update";
            this.manageLocationbtn.UseVisualStyleBackColor = false;
            this.manageLocationbtn.Click += new System.EventHandler(this.manageLocationbtn_Click);
            // 
            // manageLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1606, 956);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteLocationbtn;
        private System.Windows.Forms.Button manageLocationbtn;
        private System.Windows.Forms.Button clearlocationtbtn;
        private System.Windows.Forms.TextBox txtsearchlocation;
        private System.Windows.Forms.Label label5;
    }
}