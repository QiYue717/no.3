﻿namespace WindowsFormsApplication1
{
    partial class Single
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Single));
            this.cobdate = new System.Windows.Forms.ComboBox();
            this.labrent = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtForegift = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cobsex = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cobRoomTypeId = new System.Windows.Forms.ComboBox();
            this.cobRoomId = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhonenumber = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtRoomprice = new System.Windows.Forms.TextBox();
            this.TXTClientName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cobdate
            // 
            this.cobdate.FormattingEnabled = true;
            this.cobdate.Location = new System.Drawing.Point(379, 375);
            this.cobdate.Margin = new System.Windows.Forms.Padding(4);
            this.cobdate.Name = "cobdate";
            this.cobdate.Size = new System.Drawing.Size(56, 23);
            this.cobdate.TabIndex = 84;
            this.cobdate.SelectedIndexChanged += new System.EventHandler(this.cobdate_SelectedIndexChanged);
            // 
            // labrent
            // 
            this.labrent.AutoSize = true;
            this.labrent.Location = new System.Drawing.Point(375, 450);
            this.labrent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labrent.Name = "labrent";
            this.labrent.Size = new System.Drawing.Size(0, 15);
            this.labrent.TabIndex = 81;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(312, 385);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 82;
            this.label9.Text = "天数";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(280, 450);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 83;
            this.label10.Text = "总计租金";
            // 
            // txtForegift
            // 
            this.txtForegift.Location = new System.Drawing.Point(384, 482);
            this.txtForegift.Margin = new System.Windows.Forms.Padding(4);
            this.txtForegift.Name = "txtForegift";
            this.txtForegift.Size = new System.Drawing.Size(109, 25);
            this.txtForegift.TabIndex = 80;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 493);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 79;
            this.label8.Text = "押金收取";
            // 
            // cobsex
            // 
            this.cobsex.FormattingEnabled = true;
            this.cobsex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cobsex.Location = new System.Drawing.Point(377, 193);
            this.cobsex.Margin = new System.Windows.Forms.Padding(4);
            this.cobsex.Name = "cobsex";
            this.cobsex.Size = new System.Drawing.Size(56, 23);
            this.cobsex.TabIndex = 78;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(525, 528);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 35);
            this.button2.TabIndex = 76;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(260, 528);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 35);
            this.button1.TabIndex = 77;
            this.button1.Text = "登记";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cobRoomTypeId
            // 
            this.cobRoomTypeId.FormattingEnabled = true;
            this.cobRoomTypeId.Location = new System.Drawing.Point(240, 58);
            this.cobRoomTypeId.Margin = new System.Windows.Forms.Padding(4);
            this.cobRoomTypeId.Name = "cobRoomTypeId";
            this.cobRoomTypeId.Size = new System.Drawing.Size(109, 23);
            this.cobRoomTypeId.TabIndex = 74;
            this.cobRoomTypeId.SelectedIndexChanged += new System.EventHandler(this.cobRoomTypeId_SelectedIndexChanged);
            // 
            // cobRoomId
            // 
            this.cobRoomId.FormattingEnabled = true;
            this.cobRoomId.Location = new System.Drawing.Point(444, 56);
            this.cobRoomId.Margin = new System.Windows.Forms.Padding(4);
            this.cobRoomId.Name = "cobRoomId";
            this.cobRoomId.Size = new System.Drawing.Size(109, 23);
            this.cobRoomId.TabIndex = 75;
            this.cobRoomId.SelectedIndexChanged += new System.EventHandler(this.cobRoomId_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 72;
            this.label6.Text = "房间类型";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 73;
            this.label5.Text = "房间号";
            // 
            // txtPhonenumber
            // 
            this.txtPhonenumber.Location = new System.Drawing.Point(379, 304);
            this.txtPhonenumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhonenumber.MaxLength = 11;
            this.txtPhonenumber.Name = "txtPhonenumber";
            this.txtPhonenumber.Size = new System.Drawing.Size(192, 25);
            this.txtPhonenumber.TabIndex = 69;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(377, 252);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.MaxLength = 18;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(192, 25);
            this.txtID.TabIndex = 68;
            // 
            // txtRoomprice
            // 
            this.txtRoomprice.Location = new System.Drawing.Point(652, 56);
            this.txtRoomprice.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomprice.Name = "txtRoomprice";
            this.txtRoomprice.Size = new System.Drawing.Size(103, 25);
            this.txtRoomprice.TabIndex = 71;
            // 
            // TXTClientName
            // 
            this.TXTClientName.Location = new System.Drawing.Point(377, 136);
            this.TXTClientName.Margin = new System.Windows.Forms.Padding(4);
            this.TXTClientName.Name = "TXTClientName";
            this.TXTClientName.Size = new System.Drawing.Size(192, 25);
            this.TXTClientName.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 308);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 64;
            this.label4.Text = "电话号码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 255);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 63;
            this.label3.Text = "身份证号码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 65;
            this.label2.Text = "性别";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(592, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 67;
            this.label7.Text = "单价";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 66;
            this.label1.Text = "姓名";
            // 
            // Single
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(959, 660);
            this.Controls.Add(this.cobdate);
            this.Controls.Add(this.labrent);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtForegift);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cobsex);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cobRoomTypeId);
            this.Controls.Add(this.cobRoomId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPhonenumber);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtRoomprice);
            this.Controls.Add(this.TXTClientName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "Single";
            this.Text = "入住登记";
            this.Load += new System.EventHandler(this.Single_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cobdate;
        private System.Windows.Forms.Label labrent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtForegift;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cobsex;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cobRoomTypeId;
        private System.Windows.Forms.ComboBox cobRoomId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhonenumber;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtRoomprice;
        private System.Windows.Forms.TextBox TXTClientName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}