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
    public partial class CheakoutRoom : Form
    {
        public CheakoutRoom()
        {
            InitializeComponent();
        }
       
        int index = -1;
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = ("select Room.RoomId, ClientName,sex,IdCrad,Telephone,MemberGrade,RoomType,RoomTel,Time ,remark from Room  inner join Client on Room.RoomId=Client.RoomId inner join  RoomState on Room.RoomStateID=RoomState.RoomStateID inner join  RoomType on Room.RoomTypeId=RoomType.RoomTypeId where Room.RoomStateID=2");
            DataTable dt = new DataTable();
            dt = DBHelper.getTable(sql);
            DataRow dr = dt.Rows[index];
            string id = dr[0].ToString();
            string sql5 = string.Format("update room set roomstateid=3 where roomid='{0}'", id);
            DBHelper.getTable(sql5);
            this.CheakoutRoom_Load(null, null);
        }

        private void CheakoutRoom_Load(object sender, EventArgs e)
        {

            string sql = ("select Room.RoomId '房间编号', ClientName '客户姓名',sex '性别',IdCrad '身份证号码',Telephone '电话号码',MemberGrade '会员等级',RoomType '房间类型',RoomTel '房间电话',Time '入住时间' ,remark '房间设备' from Room  inner join Client on Room.RoomId=Client.RoomId inner join  RoomState on Room.RoomStateID=RoomState.RoomStateID inner join  RoomType on Room.RoomTypeId=RoomType.RoomTypeId where Room.RoomStateID=2");
            DataTable dt = new DataTable();
            dt = DBHelper.getTable(sql);
            this.dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }
    }
}
