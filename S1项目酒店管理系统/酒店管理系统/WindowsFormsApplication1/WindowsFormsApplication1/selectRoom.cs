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
    public partial class selectRoom : Form
    {
        public selectRoom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql2 = string.Format("select Room.RoomId '房间编号', ClientName '客户姓名',sex '性别',IdCrad '身份证',Telephone '电话号码',MemberGrade 'VIP等级',RoomType '房间类型' ,RoomTel '房间电话',Time '入住时间' ,remark '备注' from Room  inner join Client on Room.RoomId=Client.RoomId inner join  RoomState on Room.RoomStateID=RoomState.RoomStateID inner join  RoomType on Room.RoomTypeId=RoomType.RoomTypeId where Room.RoomStateID=2 ");
            dt = DBHelper.getTable(sql2);
            this.dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select RoomId '房间编号',roomtel '房间电话',roomtype '房间类型',remark '备注' from room as r inner join roomtype as rt on r.roomtypeid=rt.roomtypeid where RoomStateID=1");
            DataTable dt = new DataTable();
            dt = DBHelper.getTable(sql);
            this.dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql1 = string.Format("select RoomId '房间编号',roomtel '房间电话',roomtype '房间类型',remark '备注' from room as r inner join roomtype as rt on r.roomtypeid=rt.roomtypeid where RoomStateID=3");
            DataTable dt = new DataTable();
            dt = DBHelper.getTable(sql1);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
