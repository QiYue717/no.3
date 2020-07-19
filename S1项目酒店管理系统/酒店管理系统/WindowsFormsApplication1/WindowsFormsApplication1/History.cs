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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 根据时间查询入住情况
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string time = dateTimePicker1.Value.ToString();
            string sql = string.Format("select ClientName '姓名',Sex '性别',IdCrad '身份证号码', Telephone '电话号码' ,ClientId '编号', RoomId '房间编号' ,time '入住时间' ,MemberGrade '备注' from dbo.client where  datediff(DY,'{0}',time)>=0 and datediff(DY,'{0}',time)<=0", time);
            dataGridView1.DataSource = DBHelper.getTable(sql);
        }
        /// <summary>
        /// 查询所有
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select ClientName '姓名',Sex '性别',IdCrad '身份证号码', Telephone '电话号码' ,ClientId '编号', RoomId '房间编号' ,time '入住时间' ,MemberGrade '备注' from dbo.client");
            dataGridView1.DataSource = DBHelper.getTable(sql);
        }
        /// <summary>
        /// 删除功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                if (this.dataGridView1.SelectedRows.Count > 0)
                {
                    DataRowView drv =  dataGridView1.SelectedRows[0].DataBoundItem as DataRowView;
                    drv.Delete();
                }
            }
  
        }
        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void History_Load(object sender, EventArgs e)
        {

        }
    }
}
