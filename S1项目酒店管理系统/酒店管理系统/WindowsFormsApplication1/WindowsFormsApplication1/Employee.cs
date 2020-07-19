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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            //创建sql语句
            string sql = "select*from Employee";
            this.cobEmployeeID.DataSource = DBHelper.getTable(sql);
            //前台值
            this.cobEmployeeID.DisplayMember = "EmployeeID";
            //sql语句查询各项信息
            string sql1 = "select EmployeeID '员工编号',EmployeeName '员工姓名',EmployeeLaborage '月收入',EmployeeType '职位' from Employee inner join EmployeeType on Employee.EmployeeTypeId=EmployeeType.EmployeeTypeId ";
            DataTable dt2 = DBHelper.getTable(sql1);
            this.dataGridView1.DataSource = dt2;
            //sql语句，查询员工类型添加到下拉列表框中
            string sql2 = "select * from Employee";
            DataTable dt1 = DBHelper.getTable(sql2);
            this.cobEmployeeType.DataSource = dt1;
            //前台值
            this.cobEmployeeType.DisplayMember = "EmployeeType";
            this.cobEmployeeType.ValueMember = "EmployeeTypeid";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select EmployeeName,EmployeeType,EmployeeLaborage from Employee inner join EmployeeType on Employee.EmployeeTypeId=EmployeeType.EmployeeTypeId where Employee.EmployeeID='{0}'", this.cobEmployeeID.Text);
            SqlDataReader dr = DBHelper.getReader(sql);
            while (dr.Read())
            {
                this.txtName.Text = dr[0].ToString();
                this.cobEmployeeType.Text = dr[1].ToString();
                this.txtEmployeeLaborage.Text = dr[2].ToString();
            }
            dr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.cobEmployeeID.SelectedIndex = 0;
            this.txtName.Text = "";
            this.cobEmployeeType.SelectedIndex = 0;
            this.txtEmployeeLaborage.Text = "";
            string sql1 = "select EmployeeID,EmployeeName,EmployeeLaborage,EmployeeType from Employee inner join EmployeeType on Employee.EmployeeTypeId=EmployeeType.EmployeeTypeId ";
            DataTable dt2 = DBHelper.getTable(sql1);
            this.dataGridView1.DataSource = dt2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.cobEmployeeID.Text != "" && this.cobEmployeeType.Text != "" && this.txtName.Text != "" && this.txtEmployeeLaborage.Text != "")
            {
                string sql = string.Format("select COUNT(*)from Employee where EmployeeID='{0}'", this.cobEmployeeID.Text);

                int count = Convert.ToInt32(DBHelper.getSingle(sql));

                if (count != 1)
                {
                    //sql语句添加员工信息
                    double moeny = Convert.ToDouble(this.txtEmployeeLaborage.Text);
                    string sql1 = string.Format("insert into Employee values('{0}','{1}',{2},'{3}')", this.txtName.Text, this.cobEmployeeID.Text, moeny, this.cobEmployeeType.SelectedValue.ToString());

                    int count1 = DBHelper.setDataBySql(sql1);

                    if (count1 > 0)
                    {
                        MessageBox.Show("保存成功");

                        string sql2 = "select EmployeeId,EmployeeName,EmployeeType,EmployeeLaborage from Employee inner join EmployeeType on Employee.EmployeeTypeId=Employee.EmployeeTypeId";

                        this.dataGridView1.DataSource = DBHelper.getTable(sql2);

                        //Insert_Logging FF1 = new Insert_Logging();
                        //FF1.Show();
                    }
                    else
                    {
                        MessageBox.Show("保存失败");
                    }
                }
                else
                {
                    MessageBox.Show("该用户名已存在");
                }
            }
            else
            {
                MessageBox.Show("信息不完整");
            }
        }
        int index = -1;
        private void button4_Click(object sender, EventArgs e)
        {
            string sql3 = string.Format("delete from logging where EmployeeId='{0}'", this.dataGridView1.Rows[index].Cells[0].Value.ToString());

            DBHelper.setDataBySql(sql3);
            string sql4 = string.Format("delete from Employee where EmployeeId='{0}'", this.dataGridView1.Rows[index].Cells[0].Value.ToString());
            int count = DBHelper.setDataBySql(sql4);
            if (count > 0)
            {
                MessageBox.Show("删除成功");
                cobEmployeeID.Items.Remove(this.cobEmployeeType.SelectedValue);
                //cobEmployeeID.Text = "";
                //string sql5 = "select EmployeeID from Employee ";
                //this.dataGridView1.DataSource = DBHelper.gettable(sql5);
                this.Employee_Load(null, null);
            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            if (index != -1)
            {
                this.cobEmployeeID.Text = this.dataGridView1.Rows[index].Cells[0].Value.ToString();
                this.txtName.Text = this.dataGridView1.Rows[index].Cells[1].Value.ToString();
                this.txtEmployeeLaborage.Text = this.dataGridView1.Rows[index].Cells[2].Value.ToString();
                this.cobEmployeeType.Text = this.dataGridView1.Rows[index].Cells[3].Value.ToString();
            }
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            if (index != -1)
            {
                this.cobEmployeeID.Text = this.dataGridView1.Rows[index].Cells[0].Value.ToString();
                this.txtName.Text = this.dataGridView1.Rows[index].Cells[1].Value.ToString();
                this.txtEmployeeLaborage.Text = this.dataGridView1.Rows[index].Cells[2].Value.ToString();
                this.cobEmployeeType.Text = this.dataGridView1.Rows[index].Cells[3].Value.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
