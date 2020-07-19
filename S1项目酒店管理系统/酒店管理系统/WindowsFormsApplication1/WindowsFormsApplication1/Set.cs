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
    public partial class Set : Form
    {
        public Set()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.txtUserName.Text != "" && this.txtPwd.Text != "" && this.txtNewPwd.Text != "" && this.txtNewPwd2.Text != "")
            {
                if (this.txtNewPwd.Text.Equals(this.txtNewPwd2.Text))
                {
                    //修改,根据新的密码修改
                    string sql = string.Format("update logging set PassWord='{0}'where username='{1}'and password='{2}'", this.txtNewPwd.Text, this.txtUserName.Text, this.txtPwd.Text);

                    int count = DBHelper.setDataBySql(sql);

                    if (count > 0)
                    {
                        MessageBox.Show("修改成功");

                    }
                    else
                    {
                        MessageBox.Show("修改失败");
                    }
                }
                else
                {
                    MessageBox.Show("密码不一致");
                }
            }
            else
            {
                MessageBox.Show("输入不完整");
            }
        }

        private void txtNewPwd2_TextChanged(object sender, EventArgs e)
        {
            if (this.txtNewPwd2.Text.Equals(this.txtNewPwd.Text))
            {
                this.label5.Text = "密码一致";
            }
            else
            {
                this.label5.Text = "两次密码不一致，请重新输入";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
