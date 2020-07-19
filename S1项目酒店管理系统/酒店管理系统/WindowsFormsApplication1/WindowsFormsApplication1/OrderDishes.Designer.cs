namespace WindowsFormsApplication1
{
    partial class OrderDishes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDishes));
            this.button2 = new System.Windows.Forms.Button();
            this.txtexplain = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.价格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labfoodprice = new System.Windows.Forms.Label();
            this.labfoodname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.菜名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comdesk = new System.Windows.Forms.ComboBox();
            this.cmbfoodtype = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(547, 565);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 42);
            this.button2.TabIndex = 31;
            this.button2.Text = "选择";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtexplain
            // 
            this.txtexplain.BackColor = System.Drawing.Color.White;
            this.txtexplain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtexplain.Location = new System.Drawing.Point(91, 498);
            this.txtexplain.Margin = new System.Windows.Forms.Padding(4);
            this.txtexplain.Multiline = true;
            this.txtexplain.Name = "txtexplain";
            this.txtexplain.Size = new System.Drawing.Size(396, 122);
            this.txtexplain.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "桌号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 479);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "备注";
            // 
            // 类型
            // 
            this.类型.DataPropertyName = "foodType";
            this.类型.HeaderText = "类型";
            this.类型.Name = "类型";
            // 
            // 价格
            // 
            this.价格.DataPropertyName = "foodPrice";
            this.价格.HeaderText = "价格";
            this.价格.Name = "价格";
            // 
            // labfoodprice
            // 
            this.labfoodprice.AutoSize = true;
            this.labfoodprice.Location = new System.Drawing.Point(564, 97);
            this.labfoodprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labfoodprice.Name = "labfoodprice";
            this.labfoodprice.Size = new System.Drawing.Size(15, 15);
            this.labfoodprice.TabIndex = 26;
            this.labfoodprice.Text = "0";
            // 
            // labfoodname
            // 
            this.labfoodname.AutoSize = true;
            this.labfoodname.Location = new System.Drawing.Point(395, 97);
            this.labfoodname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labfoodname.Name = "labfoodname";
            this.labfoodname.Size = new System.Drawing.Size(22, 15);
            this.labfoodname.TabIndex = 27;
            this.labfoodname.Text = "无";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(501, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "单价：";
            // 
            // 编号
            // 
            this.编号.DataPropertyName = "foodID";
            this.编号.HeaderText = "编号";
            this.编号.Name = "编号";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.编号,
            this.菜名,
            this.价格,
            this.类型});
            this.dataGridView1.Location = new System.Drawing.Point(91, 137);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(544, 319);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // 菜名
            // 
            this.菜名.DataPropertyName = "foodName";
            this.菜名.HeaderText = "菜名";
            this.菜名.Name = "菜名";
            // 
            // comdesk
            // 
            this.comdesk.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "12"});
            this.comdesk.FormattingEnabled = true;
            this.comdesk.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comdesk.Location = new System.Drawing.Point(215, 93);
            this.comdesk.Margin = new System.Windows.Forms.Padding(4);
            this.comdesk.Name = "comdesk";
            this.comdesk.Size = new System.Drawing.Size(69, 23);
            this.comdesk.TabIndex = 21;
            // 
            // cmbfoodtype
            // 
            this.cmbfoodtype.FormattingEnabled = true;
            this.cmbfoodtype.Location = new System.Drawing.Point(216, 47);
            this.cmbfoodtype.Margin = new System.Windows.Forms.Padding(4);
            this.cmbfoodtype.Name = "cmbfoodtype";
            this.cmbfoodtype.Size = new System.Drawing.Size(68, 23);
            this.cmbfoodtype.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(55, 27);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 45);
            this.button1.TabIndex = 20;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "菜名 ：";
            // 
            // OrderDishes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1123, 700);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtexplain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labfoodprice);
            this.Controls.Add(this.labfoodname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comdesk);
            this.Controls.Add(this.cmbfoodtype);
            this.Controls.Add(this.button1);
            this.Name = "OrderDishes";
            this.Text = "点菜";
            this.Load += new System.EventHandler(this.OrderDishes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtexplain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 价格;
        private System.Windows.Forms.Label labfoodprice;
        private System.Windows.Forms.Label labfoodname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn 编号;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 菜名;
        private System.Windows.Forms.ComboBox comdesk;
        private System.Windows.Forms.ComboBox cmbfoodtype;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}