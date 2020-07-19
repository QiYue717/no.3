using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton3_ButtonClick(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.label1.Visible = false;
            this.解锁密码textBox1.Visible = false;
            this.解锁button1.Visible = false;
        }

        private void 解锁button1_Click(object sender, EventArgs e)
        {
            if(Form2.NewPwd==Convert.ToInt32(this.解锁密码textBox1.Text))
            {
                this.label1.Visible = false;
                this.解锁密码textBox1.Visible  = false;
                this.解锁button1.Visible = false;
                this.解锁密码textBox1.Text = "";
                this.toolStrip1.Visible = true;
                this.button1.Visible = true;
            }
            else
            {
                MessageBox.Show("密码输入错误");
                this.解锁密码textBox1.Text = "";
            }
        }

        private void 脏房打扫ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dirty d1 = new dirty();
           
            d1.ShowDialog();
        }

        private void 客房查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectRoom s1 = new selectRoom();
       
            s1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Visible = true;
            this.解锁密码textBox1.Visible = true;
            this.解锁button1.Visible = true;
            this.toolStrip1.Visible = false;
            this.button1.Visible = false;
        }

        private void 锁屏设置toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            Form2 fro2 = new Form2();
            fro2.ShowDialog();
        }

        private void 入住历史查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History li = new History();
          
            li.Show();
        }

        private void 设置toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            Set s2 = new Set();
            
            s2.ShowDialog();
        }

        private void 团队登记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupRoom gr = new GroupRoom();
         
            gr.ShowDialog();
        }

        private void 员工信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee e2 = new Employee();

            e2.ShowDialog();
        }

        private void 退房操作ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheakoutRoom ck = new CheakoutRoom();
      
            ck.ShowDialog();
        }

        private void 修改员工密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update up = new Update();
            up.ShowDialog();
        }

        private void 单人登记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Single s5 = new Single();
            s5.ShowDialog();
        }

        private void 入户登记toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            Single s5 = new Single();
            s5.ShowDialog();
        }

        private void 点餐ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderDishes od = new OrderDishes();
            od.ShowDialog();
        }

        private void 点菜查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectFood sf = new SelectFood();
            sf.ShowDialog();
        }

        private void 结账ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettleAccounts sa = new SettleAccounts();
            sa.ShowDialog();
        }
    }
}
