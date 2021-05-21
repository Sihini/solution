
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
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 386);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnsavelaction);
            this.panel2.Controls.Add(this.txtcapacity);
            this.panel2.Controls.Add(this.btnclearlocation);
            this.panel2.Controls.Add(this.labradiobtn);
            this.panel2.Controls.Add(this.lecturradiobtn);
            this.panel2.Controls.Add(this.txtroomname);
            this.panel2.Controls.Add(this.txtBuildingname);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(974, 385);
            this.panel2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 21);
            this.label5.TabIndex = 35;
            this.label5.Text = "Add Rooms Building wise:";
            // 
            // btnsavelaction
            // 
            this.btnsavelaction.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnsavelaction.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsavelaction.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnsavelaction.Location = new System.Drawing.Point(653, 282);
            this.btnsavelaction.Name = "btnsavelaction";
            this.btnsavelaction.Size = new System.Drawing.Size(128, 44);
            this.btnsavelaction.TabIndex = 34;
            this.btnsavelaction.Text = "Save";
            this.btnsavelaction.UseVisualStyleBackColor = false;
            this.btnsavelaction.Click += new System.EventHandler(this.btnsavelaction_Click_1);
            // 
            // txtcapacity
            // 
            this.txtcapacity.Location = new System.Drawing.Point(244, 199);
            this.txtcapacity.Name = "txtcapacity";
            this.txtcapacity.Size = new System.Drawing.Size(246, 27);
            this.txtcapacity.TabIndex = 32;
            // 
            // btnclearlocation
            // 
            this.btnclearlocation.BackColor = System.Drawing.Color.DarkOrange;
            this.btnclearlocation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnclearlocation.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnclearlocation.Location = new System.Drawing.Point(467, 282);
            this.btnclearlocation.Name = "btnclearlocation";
            this.btnclearlocation.Size = new System.Drawing.Size(137, 44);
            this.btnclearlocation.TabIndex = 33;
            this.btnclearlocation.Text = "Clear";
            this.btnclearlocation.UseVisualStyleBackColor = false;
            this.btnclearlocation.Click += new System.EventHandler(this.btnclearlocation_Click_1);
            // 
            // labradiobtn
            // 
            this.labradiobtn.AutoSize = true;
            this.labradiobtn.Location = new System.Drawing.Point(377, 157);
            this.labradiobtn.Name = "labradiobtn";
            this.labradiobtn.Size = new System.Drawing.Size(113, 25);
            this.labradiobtn.TabIndex = 31;
            this.labradiobtn.TabStop = true;
            this.labradiobtn.Text = "Laboratory";
            this.labradiobtn.UseVisualStyleBackColor = true;
            // 
            // lecturradiobtn
            // 
            this.lecturradiobtn.AutoSize = true;
            this.lecturradiobtn.Location = new System.Drawing.Point(244, 157);
            this.lecturradiobtn.Name = "lecturradiobtn";
            this.lecturradiobtn.Size = new System.Drawing.Size(124, 25);
            this.lecturradiobtn.TabIndex = 30;
            this.lecturradiobtn.TabStop = true;
            this.lecturradiobtn.Text = "Lecturer Hall";
            this.lecturradiobtn.UseVisualStyleBackColor = true;
            // 
            // txtroomname
            // 
            this.txtroomname.Location = new System.Drawing.Point(244, 103);
            this.txtroomname.Name = "txtroomname";
            this.txtroomname.Size = new System.Drawing.Size(246, 27);
            this.txtroomname.TabIndex = 29;
            // 
            // txtBuildingname
            // 
            this.txtBuildingname.BackColor = System.Drawing.SystemColors.Window;
            this.txtBuildingname.Location = new System.Drawing.Point(244, 59);
            this.txtBuildingname.Name = "txtBuildingname";
            this.txtBuildingname.Size = new System.Drawing.Size(246, 27);
            this.txtBuildingname.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(52, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "Room Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(52, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Room Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(52, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Capacity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(52, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Building Name";
            // 
            // addLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 500);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(-1, -1);
            this.Name = "addLocation";
            this.Text = "addLocation";
            this.Load += new System.EventHandler(this.addLocation_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsavelaction;
        private System.Windows.Forms.TextBox txtcapacity;
        private System.Windows.Forms.Button btnclearlocation;
        private System.Windows.Forms.RadioButton labradiobtn;
        private System.Windows.Forms.RadioButton lecturradiobtn;
        private System.Windows.Forms.TextBox txtroomname;
        private System.Windows.Forms.TextBox txtBuildingname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}