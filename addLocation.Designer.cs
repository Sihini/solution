
namespace solution
{
    partial class addLocation
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnsavelaction = new System.Windows.Forms.Button();
            this.txtcapacity = new System.Windows.Forms.TextBox();
            this.btnclearlocation = new System.Windows.Forms.Button();
            this.labradiobtn = new System.Windows.Forms.RadioButton();
            this.lecturradiobtn = new System.Windows.Forms.RadioButton();
            this.txtroomname = new System.Windows.Forms.TextBox();
            this.txtBuildingname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnsavelaction);
            this.panel1.Controls.Add(this.txtcapacity);
            this.panel1.Controls.Add(this.btnclearlocation);
            this.panel1.Controls.Add(this.labradiobtn);
            this.panel1.Controls.Add(this.lecturradiobtn);
            this.panel1.Controls.Add(this.txtroomname);
            this.panel1.Controls.Add(this.txtBuildingname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 444);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Add Rooms Building wise:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnsavelaction
            // 
            this.btnsavelaction.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnsavelaction.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsavelaction.ForeColor = System.Drawing.SystemColors.HighlightText;

            this.btnsavelaction.Image = global::solution.Properties.Resources.save1;
            this.btnsavelaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.btnsavelaction.Location = new System.Drawing.Point(721, 346);
            this.btnsavelaction.Name = "btnsavelaction";
            this.btnsavelaction.Size = new System.Drawing.Size(128, 44);
            this.btnsavelaction.TabIndex = 22;
            this.btnsavelaction.Text = "Save";
            this.btnsavelaction.UseVisualStyleBackColor = false;
            this.btnsavelaction.Click += new System.EventHandler(this.btnsavelaction_Click);
            // 
            // txtcapacity
            // 
            this.txtcapacity.Location = new System.Drawing.Point(289, 217);
            this.txtcapacity.Name = "txtcapacity";
            this.txtcapacity.Size = new System.Drawing.Size(246, 32);
            this.txtcapacity.TabIndex = 17;
            // 
            // btnclearlocation
            // 
            this.btnclearlocation.BackColor = System.Drawing.Color.DarkOrange;
            this.btnclearlocation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnclearlocation.ForeColor = System.Drawing.SystemColors.HighlightText;

            this.btnclearlocation.Image = global::solution.Properties.Resources.clear;
            this.btnclearlocation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.btnclearlocation.Location = new System.Drawing.Point(530, 346);
            this.btnclearlocation.Name = "btnclearlocation";
            this.btnclearlocation.Size = new System.Drawing.Size(137, 44);
            this.btnclearlocation.TabIndex = 21;
            this.btnclearlocation.Text = "Clear";
            this.btnclearlocation.UseVisualStyleBackColor = false;
            this.btnclearlocation.Click += new System.EventHandler(this.btnclearlocation_Click);
            // 
            // labradiobtn
            // 
            this.labradiobtn.AutoSize = true;
            this.labradiobtn.Location = new System.Drawing.Point(422, 175);
            this.labradiobtn.Name = "labradiobtn";
            this.labradiobtn.Size = new System.Drawing.Size(138, 27);
            this.labradiobtn.TabIndex = 16;
            this.labradiobtn.TabStop = true;
            this.labradiobtn.Text = "Laboratory";
            this.labradiobtn.UseVisualStyleBackColor = true;
            // 
            // lecturradiobtn
            // 
            this.lecturradiobtn.AutoSize = true;
            this.lecturradiobtn.Location = new System.Drawing.Point(289, 175);
            this.lecturradiobtn.Name = "lecturradiobtn";
            this.lecturradiobtn.Size = new System.Drawing.Size(154, 27);
            this.lecturradiobtn.TabIndex = 15;
            this.lecturradiobtn.TabStop = true;
            this.lecturradiobtn.Text = "Lecturer Hall";
            this.lecturradiobtn.UseVisualStyleBackColor = true;
            // 
            // txtroomname
            // 
            this.txtroomname.Location = new System.Drawing.Point(289, 121);
            this.txtroomname.Name = "txtroomname";
            this.txtroomname.Size = new System.Drawing.Size(246, 32);
            this.txtroomname.TabIndex = 14;
            // 
            // txtBuildingname
            // 
            this.txtBuildingname.BackColor = System.Drawing.SystemColors.Window;
            this.txtBuildingname.Location = new System.Drawing.Point(289, 77);
            this.txtBuildingname.Name = "txtBuildingname";
            this.txtBuildingname.Size = new System.Drawing.Size(246, 32);
            this.txtBuildingname.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(97, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Room Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(97, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Room Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(97, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Capacity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(97, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Building Name";
            // 
            // addLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 647);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "addLocation";
            this.Text = "addLocation";
            this.Load += new System.EventHandler(this.addLocation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtcapacity;
        private System.Windows.Forms.RadioButton labradiobtn;
        private System.Windows.Forms.RadioButton lecturradiobtn;
        private System.Windows.Forms.TextBox txtroomname;
        private System.Windows.Forms.TextBox txtBuildingname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsavelaction;
        private System.Windows.Forms.Button btnclearlocation;
        private System.Windows.Forms.Label label5;
    }
}