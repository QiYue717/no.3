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
    public partial class SelectFood : Form
    {
        public SelectFood()
        {
            InitializeComponent();
        }

        private void SelectFood_Load(object sender, EventArgs e)
        {
            string sql1 = string.Format("select deskId '桌号',foodName '菜名',foodPrice '价格' from foodconsumption");
            DataTable dt1 = DBHelper.getTable(sql1);
            dataGridView1.DataSource = dt1;
        }

        private void butSELECT_Click(object sender, EventArgs e)
        {
            if (this.comdesk.Text.Length == 0)
            {
                MessageBox.Show("请选择要查询的桌号：");
            }
            else
            {
                string sql1 = string.Format("select  deskId '桌号',foodName '菜名',foodPrice '价格'from foodconsumption where deskId={0}", this.comdesk.Text);
                DataTable dt1 = DBHelper.getTable(sql1);
                this.dataGridView1.DataSource = dt1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string numberid = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[6].Value.ToString();
            string sql = string.Format("delete from foodconsumption where numberid={0}",numberid );
            DBHelper.setDataBySql(sql);
            MessageBox.Show("送餐成功！");
            this.SelectFood_Load(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from foodconsumption";
            DataTable ds2 = DBHelper.getTable(sql);
            this.dataGridView1.DataSource = ds2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
