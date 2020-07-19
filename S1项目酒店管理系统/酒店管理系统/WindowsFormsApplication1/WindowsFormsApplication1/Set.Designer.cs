namespace WindowsFormsApplication1
{
    partial class Set
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("单人入住");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("团体入住");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("入住登记", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("退房系统");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("查询入住");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("脏房打扫");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("客房系统", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("用户注册");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("员工信息管理", new System.Windows.Forms.TreeNode[] {
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("员工信息修改");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("管理系统", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("入住历史记录");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("历史记录", new System.Windows.Forms.TreeNode[] {
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("点餐");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("点菜更新");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("结账");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("餐厅系统", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("设置锁屏密码");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("锁屏设置", new System.Windows.Forms.TreeNode[] {
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("用户信息修改 ");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("项目构造图");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("退出");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("设置", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21,
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("主界面", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode7,
            treeNode11,
            treeNode13,
            treeNode17,
            treeNode19,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("登录", new System.Windows.Forms.TreeNode[] {
            treeNode24});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Set));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.用户密码修改 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNewPwd2 = new System.Windows.Forms.TextBox();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.项目构造图 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.用户密码修改.SuspendLayout();
            this.项目构造图.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(4, 4);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点14";
            treeNode1.Text = "单人入住";
            treeNode2.Name = "节点15";
            treeNode2.Text = "团体入住";
            treeNode3.Name = "节点3";
            treeNode3.Text = "入住登记";
            treeNode4.Name = "节点11";
            treeNode4.Text = "退房系统";
            treeNode5.Name = "节点12";
            treeNode5.Text = "查询入住";
            treeNode6.Name = "节点13";
            treeNode6.Text = "脏房打扫";
            treeNode7.Name = "节点4";
            treeNode7.Text = "客房系统";
            treeNode8.Name = "节点18";
            treeNode8.Text = "用户注册";
            treeNode9.Name = "节点16";
            treeNode9.Text = "员工信息管理";
            treeNode10.Name = "节点17";
            treeNode10.Text = "员工信息修改";
            treeNode11.Name = "节点5";
            treeNode11.Text = "管理系统";
            treeNode12.Name = "节点19";
            treeNode12.Text = "入住历史记录";
            treeNode13.Name = "节点6";
            treeNode13.Text = "历史记录";
            treeNode14.Name = "节点20";
            treeNode14.Text = "点餐";
            treeNode15.Name = "节点21";
            treeNode15.Text = "点菜更新";
            treeNode16.Name = "节点22";
            treeNode16.Text = "结账";
            treeNode17.Name = "节点7";
            treeNode17.Text = "餐厅系统";
            treeNode18.Name = "节点23";
            treeNode18.Text = "设置锁屏密码";
            treeNode19.Name = "节点8";
            treeNode19.Text = "锁屏设置";
            treeNode20.Name = "节点27";
            treeNode20.Text = "用户信息修改 ";
            treeNode21.Name = "节点28";
            treeNode21.Text = "项目构造图";
            treeNode22.Name = "节点29";
            treeNode22.Text = "退出";
            treeNode23.Name = "节点9";
            treeNode23.Text = "设置";
            treeNode24.Name = "节点1";
            treeNode24.Text = "主界面";
            treeNode25.Name = "节点0";
            treeNode25.Text = "登录";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode25});
            this.treeView1.Size = new System.Drawing.Size(942, 569);
            this.treeView1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.用户密码修改);
            this.tabControl1.Controls.Add(this.项目构造图);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1235, 785);
            this.tabControl1.TabIndex = 1;
            // 
            // 用户密码修改
            // 
            this.用户密码修改.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("用户密码修改.BackgroundImage")));
            this.用户密码修改.Controls.Add(this.label5);
            this.用户密码修改.Controls.Add(this.button2);
            this.用户密码修改.Controls.Add(this.button1);
            this.用户密码修改.Controls.Add(this.txtNewPwd2);
            this.用户密码修改.Controls.Add(this.txtNewPwd);
            this.用户密码修改.Controls.Add(this.txtPwd);
            this.用户密码修改.Controls.Add(this.txtUserName);
            this.用户密码修改.Controls.Add(this.label4);
            this.用户密码修改.Controls.Add(this.label3);
            this.用户密码修改.Controls.Add(this.label2);
            this.用户密码修改.Controls.Add(this.label1);
            this.用户密码修改.Location = new System.Drawing.Point(4, 25);
            this.用户密码修改.Margin = new System.Windows.Forms.Padding(4);
            this.用户密码修改.Name = "用户密码修改";
            this.用户密码修改.Padding = new System.Windows.Forms.Padding(4);
            this.用户密码修改.Size = new System.Drawing.Size(1227, 756);
            this.用户密码修改.TabIndex = 1;
            this.用户密码修改.Text = "用户密码修改";
            this.用户密码修改.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(372, 386);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 40);
            this.label5.TabIndex = 35;
            this.label5.Text = "两次密码不相同";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(616, 472);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 52);
            this.button2.TabIndex = 33;
            this.button2.Text = "关闭";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(156, 472);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 52);
            this.button1.TabIndex = 34;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNewPwd2
            // 
            this.txtNewPwd2.Location = new System.Drawing.Point(277, 288);
            this.txtNewPwd2.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPwd2.Name = "txtNewPwd2";
            this.txtNewPwd2.PasswordChar = '*';
            this.txtNewPwd2.Size = new System.Drawing.Size(416, 25);
            this.txtNewPwd2.TabIndex = 30;
            this.txtNewPwd2.TextChanged += new System.EventHandler(this.txtNewPwd2_TextChanged);
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Location = new System.Drawing.Point(277, 226);
            this.txtNewPwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.Size = new System.Drawing.Size(416, 25);
            this.txtNewPwd.TabIndex = 29;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(277, 168);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(416, 25);
            this.txtPwd.TabIndex = 32;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(277, 110);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(416, 25);
            this.txtUserName.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(193, 291);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "确认密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(193, 230);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "新密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(193, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "原密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(196, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "用户名";
            // 
            // 项目构造图
            // 
            this.项目构造图.Controls.Add(this.treeView1);
            this.项目构造图.Location = new System.Drawing.Point(4, 25);
            this.项目构造图.Margin = new System.Windows.Forms.Padding(4);
            this.项目构造图.Name = "项目构造图";
            this.项目构造图.Padding = new System.Windows.Forms.Padding(4);
            this.项目构造图.Size = new System.Drawing.Size(950, 577);
            this.项目构造图.TabIndex = 0;
            this.项目构造图.Text = "项目构造图";
            this.项目构造图.UseVisualStyleBackColor = true;
            // 
            // Set
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 785);
            this.Controls.Add(this.tabControl1);
            this.Name = "Set";
            this.Text = "设置";
            this.tabControl1.ResumeLayout(false);
            this.用户密码修改.ResumeLayout(false);
            this.用户密码修改.PerformLayout();
            this.项目构造图.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage 项目构造图;
        private System.Windows.Forms.TabPage 用户密码修改;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNewPwd2;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}