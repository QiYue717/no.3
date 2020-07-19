namespace WindowsFormsApplication1
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.入户登记toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.客房系统toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.客房查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.脏房打扫ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退房操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理系统toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.员工信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改员工密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.历史记录toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.入住历史查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.餐厅系统toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.点餐ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.点菜查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.结账ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.锁屏设置toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.设置toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.label1 = new System.Windows.Forms.Label();
            this.解锁密码textBox1 = new System.Windows.Forms.TextBox();
            this.解锁button1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.入户登记toolStripSplitButton1,
            this.客房系统toolStripSplitButton2,
            this.管理系统toolStripSplitButton3,
            this.历史记录toolStripSplitButton1,
            this.餐厅系统toolStripSplitButton1,
            this.锁屏设置toolStripSplitButton1,
            this.设置toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStrip1.Size = new System.Drawing.Size(1507, 46);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // 入户登记toolStripSplitButton1
            // 
            this.入户登记toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.入户登记toolStripSplitButton1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.入户登记toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("入户登记toolStripSplitButton1.Image")));
            this.入户登记toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.入户登记toolStripSplitButton1.Name = "入户登记toolStripSplitButton1";
            this.入户登记toolStripSplitButton1.Size = new System.Drawing.Size(156, 43);
            this.入户登记toolStripSplitButton1.Text = "入户登记";
            this.入户登记toolStripSplitButton1.ButtonClick += new System.EventHandler(this.入户登记toolStripSplitButton1_ButtonClick);
            // 
            // 客房系统toolStripSplitButton2
            // 
            this.客房系统toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.客房系统toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.客房查询ToolStripMenuItem,
            this.脏房打扫ToolStripMenuItem,
            this.退房操作ToolStripMenuItem});
            this.客房系统toolStripSplitButton2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.客房系统toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("客房系统toolStripSplitButton2.Image")));
            this.客房系统toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.客房系统toolStripSplitButton2.Name = "客房系统toolStripSplitButton2";
            this.客房系统toolStripSplitButton2.Size = new System.Drawing.Size(156, 43);
            this.客房系统toolStripSplitButton2.Text = "客房系统";
            this.客房系统toolStripSplitButton2.ButtonClick += new System.EventHandler(this.toolStripSplitButton2_ButtonClick);
            // 
            // 客房查询ToolStripMenuItem
            // 
            this.客房查询ToolStripMenuItem.Name = "客房查询ToolStripMenuItem";
            this.客房查询ToolStripMenuItem.Size = new System.Drawing.Size(220, 44);
            this.客房查询ToolStripMenuItem.Text = "客房查询";
            this.客房查询ToolStripMenuItem.Click += new System.EventHandler(this.客房查询ToolStripMenuItem_Click);
            // 
            // 脏房打扫ToolStripMenuItem
            // 
            this.脏房打扫ToolStripMenuItem.Name = "脏房打扫ToolStripMenuItem";
            this.脏房打扫ToolStripMenuItem.Size = new System.Drawing.Size(220, 44);
            this.脏房打扫ToolStripMenuItem.Text = "脏房打扫";
            this.脏房打扫ToolStripMenuItem.Click += new System.EventHandler(this.脏房打扫ToolStripMenuItem_Click);
            // 
            // 退房操作ToolStripMenuItem
            // 
            this.退房操作ToolStripMenuItem.Name = "退房操作ToolStripMenuItem";
            this.退房操作ToolStripMenuItem.Size = new System.Drawing.Size(220, 44);
            this.退房操作ToolStripMenuItem.Text = "退房操作";
            this.退房操作ToolStripMenuItem.Click += new System.EventHandler(this.退房操作ToolStripMenuItem_Click);
            // 
            // 管理系统toolStripSplitButton3
            // 
            this.管理系统toolStripSplitButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.管理系统toolStripSplitButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.员工信息查询ToolStripMenuItem,
            this.修改员工密码ToolStripMenuItem});
            this.管理系统toolStripSplitButton3.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.管理系统toolStripSplitButton3.Image = ((System.Drawing.Image)(resources.GetObject("管理系统toolStripSplitButton3.Image")));
            this.管理系统toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.管理系统toolStripSplitButton3.Name = "管理系统toolStripSplitButton3";
            this.管理系统toolStripSplitButton3.Size = new System.Drawing.Size(156, 43);
            this.管理系统toolStripSplitButton3.Text = "管理系统";
            this.管理系统toolStripSplitButton3.ButtonClick += new System.EventHandler(this.toolStripSplitButton3_ButtonClick);
            // 
            // 员工信息查询ToolStripMenuItem
            // 
            this.员工信息查询ToolStripMenuItem.Name = "员工信息查询ToolStripMenuItem";
            this.员工信息查询ToolStripMenuItem.Size = new System.Drawing.Size(280, 44);
            this.员工信息查询ToolStripMenuItem.Text = "员工信息查询";
            this.员工信息查询ToolStripMenuItem.Click += new System.EventHandler(this.员工信息查询ToolStripMenuItem_Click);
            // 
            // 修改员工密码ToolStripMenuItem
            // 
            this.修改员工密码ToolStripMenuItem.Name = "修改员工密码ToolStripMenuItem";
            this.修改员工密码ToolStripMenuItem.Size = new System.Drawing.Size(280, 44);
            this.修改员工密码ToolStripMenuItem.Text = "修改员工密码";
            this.修改员工密码ToolStripMenuItem.Click += new System.EventHandler(this.修改员工密码ToolStripMenuItem_Click);
            // 
            // 历史记录toolStripSplitButton1
            // 
            this.历史记录toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.历史记录toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.入住历史查询ToolStripMenuItem});
            this.历史记录toolStripSplitButton1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.历史记录toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("历史记录toolStripSplitButton1.Image")));
            this.历史记录toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.历史记录toolStripSplitButton1.Name = "历史记录toolStripSplitButton1";
            this.历史记录toolStripSplitButton1.Size = new System.Drawing.Size(156, 43);
            this.历史记录toolStripSplitButton1.Text = "历史记录";
            // 
            // 入住历史查询ToolStripMenuItem
            // 
            this.入住历史查询ToolStripMenuItem.Name = "入住历史查询ToolStripMenuItem";
            this.入住历史查询ToolStripMenuItem.Size = new System.Drawing.Size(280, 44);
            this.入住历史查询ToolStripMenuItem.Text = "入住历史查询";
            this.入住历史查询ToolStripMenuItem.Click += new System.EventHandler(this.入住历史查询ToolStripMenuItem_Click);
            // 
            // 餐厅系统toolStripSplitButton1
            // 
            this.餐厅系统toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.餐厅系统toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.点餐ToolStripMenuItem,
            this.点菜查询ToolStripMenuItem,
            this.结账ToolStripMenuItem});
            this.餐厅系统toolStripSplitButton1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.餐厅系统toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("餐厅系统toolStripSplitButton1.Image")));
            this.餐厅系统toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.餐厅系统toolStripSplitButton1.Name = "餐厅系统toolStripSplitButton1";
            this.餐厅系统toolStripSplitButton1.Size = new System.Drawing.Size(156, 43);
            this.餐厅系统toolStripSplitButton1.Text = "餐厅系统";
            // 
            // 点餐ToolStripMenuItem
            // 
            this.点餐ToolStripMenuItem.Name = "点餐ToolStripMenuItem";
            this.点餐ToolStripMenuItem.Size = new System.Drawing.Size(220, 44);
            this.点餐ToolStripMenuItem.Text = "点餐";
            this.点餐ToolStripMenuItem.Click += new System.EventHandler(this.点餐ToolStripMenuItem_Click);
            // 
            // 点菜查询ToolStripMenuItem
            // 
            this.点菜查询ToolStripMenuItem.Name = "点菜查询ToolStripMenuItem";
            this.点菜查询ToolStripMenuItem.Size = new System.Drawing.Size(220, 44);
            this.点菜查询ToolStripMenuItem.Text = "点菜查询";
            this.点菜查询ToolStripMenuItem.Click += new System.EventHandler(this.点菜查询ToolStripMenuItem_Click);
            // 
            // 结账ToolStripMenuItem
            // 
            this.结账ToolStripMenuItem.Name = "结账ToolStripMenuItem";
            this.结账ToolStripMenuItem.Size = new System.Drawing.Size(220, 44);
            this.结账ToolStripMenuItem.Text = "结账";
            this.结账ToolStripMenuItem.Click += new System.EventHandler(this.结账ToolStripMenuItem_Click);
            // 
            // 锁屏设置toolStripSplitButton1
            // 
            this.锁屏设置toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.锁屏设置toolStripSplitButton1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.锁屏设置toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("锁屏设置toolStripSplitButton1.Image")));
            this.锁屏设置toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.锁屏设置toolStripSplitButton1.Name = "锁屏设置toolStripSplitButton1";
            this.锁屏设置toolStripSplitButton1.Size = new System.Drawing.Size(156, 43);
            this.锁屏设置toolStripSplitButton1.Text = "锁屏设置";
            this.锁屏设置toolStripSplitButton1.ButtonClick += new System.EventHandler(this.锁屏设置toolStripSplitButton1_ButtonClick);
            // 
            // 设置toolStripSplitButton1
            // 
            this.设置toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.设置toolStripSplitButton1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.设置toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("设置toolStripSplitButton1.Image")));
            this.设置toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.设置toolStripSplitButton1.Name = "设置toolStripSplitButton1";
            this.设置toolStripSplitButton1.Size = new System.Drawing.Size(96, 43);
            this.设置toolStripSplitButton1.Text = "设置";
            this.设置toolStripSplitButton1.ButtonClick += new System.EventHandler(this.设置toolStripSplitButton1_ButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(382, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "请输入解锁密码：";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // 解锁密码textBox1
            // 
            this.解锁密码textBox1.BackColor = System.Drawing.Color.White;
            this.解锁密码textBox1.Location = new System.Drawing.Point(589, 371);
            this.解锁密码textBox1.Multiline = true;
            this.解锁密码textBox1.Name = "解锁密码textBox1";
            this.解锁密码textBox1.PasswordChar = '●';
            this.解锁密码textBox1.Size = new System.Drawing.Size(268, 34);
            this.解锁密码textBox1.TabIndex = 2;
            this.解锁密码textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // 解锁button1
            // 
            this.解锁button1.BackColor = System.Drawing.Color.Navy;
            this.解锁button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("解锁button1.BackgroundImage")));
            this.解锁button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.解锁button1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.解锁button1.ForeColor = System.Drawing.Color.Yellow;
            this.解锁button1.Location = new System.Drawing.Point(876, 365);
            this.解锁button1.Name = "解锁button1";
            this.解锁button1.Size = new System.Drawing.Size(215, 62);
            this.解锁button1.TabIndex = 3;
            this.解锁button1.UseVisualStyleBackColor = false;
            this.解锁button1.Click += new System.EventHandler(this.解锁button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(876, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 62);
            this.button1.TabIndex = 4;
            this.button1.Text = "锁屏";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1507, 830);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.解锁button1);
            this.Controls.Add(this.解锁密码textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "主界面";
            this.Load += new System.EventHandler(this.Main_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripSplitButton 入户登记toolStripSplitButton1;
        private System.Windows.Forms.ToolStripSplitButton 客房系统toolStripSplitButton2;
        private System.Windows.Forms.ToolStripSplitButton 管理系统toolStripSplitButton3;
        private System.Windows.Forms.ToolStripMenuItem 客房查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 脏房打扫ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退房操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改员工密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton 历史记录toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem 入住历史查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton 餐厅系统toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem 点餐ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 点菜查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 结账ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton 锁屏设置toolStripSplitButton1;
        private System.Windows.Forms.ToolStripSplitButton 设置toolStripSplitButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button 解锁button1;
        public System.Windows.Forms.TextBox 解锁密码textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}