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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "select * from logging";
            DataTable ds = DBHelper.getTable(sql);
            this.comboBox1.DataSource = ds;
            this.comboBox1.DisplayMember = "UserName";
            this.comboBox1.ValueMember = "PassWord";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Length == 0)
            {
                MessageBox.Show("请输入用户密码");
            }
            else
            {
                string sql = string.Format("select count(*)from Logging where UserName='{0}'and passWord='{1}'", this.comboBox1.Text, this.textBox1.Text);
                object o = DBHelper.getSingle(sql);
                int count = Convert.ToInt32(o);
                if (count > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    Main m = new Main();
                    m.ShowDialog();
                   
                }
                else
                {
                    MessageBox.Show("登录失败");
                }
               

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("您真的要退出吗？", "退出", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
