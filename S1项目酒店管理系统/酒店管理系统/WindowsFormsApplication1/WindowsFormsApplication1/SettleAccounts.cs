using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication1
{
    public partial class SettleAccounts : Form
    {
        public SettleAccounts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SettleAccounts_Load(null,null);
        }

        private void SettleAccounts_Load(object sender, EventArgs e)
        {
            string sql1 = "select deskId,foodName,foodPrice,foodCount,explain,numberId,sent from foodconsumption";
            DataTable dt1 = DBHelper.getTable(sql1);
            this.dataGridView1.DataSource = dt1;
            comdesk.DataSource = dt1;
            this.comdesk.DisplayMember = "deskId";
        }

        private void butSELECT_Click(object sender, EventArgs e)
        {
            if(this.comdesk.Text.Length ==0)
            {
                MessageBox.Show("请选择要查询的桌号：");
            }
            else
            {
                string sql = string.Format("select deskId,foodName,foodPrice,foodCount,explain,numberId from foodconsumption where deskId={0}", this.comdesk.Text);
                DataTable dt = DBHelper.getTable(sql);
                this.dataGridView1.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.comdesk.Text.Length == 0)
            {
                MessageBox.Show("请选择要结账的桌号:");
            }
            else
            {
                string sql1 = string.Format("select foodPrice,foodcount from foodconsumption where deskId={0} and sent='true'", this.comdesk.Text);
                
                string sql3 = string.Format("select sum(Foodprice) from foodconsumption where DeskID={0}", this.comdesk.Text);
                SqlDataReader sdr = DBHelper.getReader(sql3);
                double  sumMoney = 0;
                while (sdr.Read())
                {
                    sumMoney = double.Parse(sdr[0].ToString());
                    //sumMoney =sumMoney+ double.Parse(sdr["foodprice"].ToString());
                    //    sumMoney += (double.Parse(sdr[0].ToString()) * double.Parse(sdr[1].ToString()));
                }
                sdr.Close();
                //SqlDataReader sda = DBHelper.getReader(sql3);
                
                MessageBox.Show(string.Format("总金额是{0}元", sumMoney));


                string sql2 = string.Format("delete from foodconsumption where deskId={0}", this.comdesk.Text);
                int count = 0;
                count = DBHelper.setDataBySql(sql2);
                if (count > 0)
                {
                    MessageBox.Show(" 结账成功!");
                    this.SettleAccounts_Load(null, null);
                    this.comdesk.Text = null;
                }
                else
                {
                    MessageBox.Show("结账失败!");
                }
            }
        }
    }
    }

