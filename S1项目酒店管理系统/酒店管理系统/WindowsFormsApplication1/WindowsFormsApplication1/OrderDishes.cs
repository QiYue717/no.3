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
    public partial class OrderDishes : Form
    {
        public OrderDishes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sql1 = string.Format("select FoodID,FoodName,foodPrice,Foodtype from food inner join Foodtype on food.foodtypeID=Foodtype.foodtypeID where Foodtype='{0}'", this.cmbfoodtype.Text);
            DataTable dt1 = DBHelper.getTable(sql1);
            this.dataGridView1.DataSource = dt1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.labfoodname.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            this.labfoodprice.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();

        }

        private void OrderDishes_Load(object sender, EventArgs e)
        {
            string sql = "select*from Foodtype";
            DataTable dt = DBHelper.getTable(sql);
            this.cmbfoodtype.DataSource = dt;
            this.cmbfoodtype.DisplayMember = "Foodtype";
            this.cmbfoodtype.ValueMember = "foodtypeID";

            string sql1 = "select FoodID,FoodName,foodPrice ,Foodtype.Foodtype from food inner join Foodtype on food.foodtypeID=Foodtype.foodtypeID";
            DataTable dt1 = DBHelper.getTable(sql1);
            this.dataGridView1.DataSource = dt1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.comdesk.Text.Length == 0)
            {
                MessageBox.Show("请选择桌号：");
            }
            else
            {
                string sql = string.Format("insert into foodconsumption values({0},'{1}','{2}','{3}','false','{4}')", this.comdesk.Text, this.labfoodname.Text, this.labfoodprice.Text, "1", this.txtexplain.Text);
                int count = DBHelper.setDataBySql(sql);
                if (count > 0)
                {
                    MessageBox.Show("添加成功!");
                }
                else
                {
                    MessageBox.Show("添加失败!");
                }
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(this.dataGridView1.SelectedRows.Count>0)
            {
                this.labfoodname.Text = this.dataGridView1.SelectedRows[0].Cells["foodname"].Value.ToString();
                this.labfoodprice.Text = this.dataGridView1.SelectedRows[0].Cells["foodprice"].Value.ToString();
            }
        }
    }
}
