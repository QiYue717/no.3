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
    public partial class dirty : Form
    {
        public dirty()
        {
            InitializeComponent();
        }
        int index = -1;

        private void dirty_Load(object sender, EventArgs e)
        {

            string sql = string.Format("select RoomId '客服编号',roomtel '房间电话',roomtype '房间类型',remark '房间设备' from room as r inner join roomtype as rt on r.roomtypeid=rt.roomtypeid where RoomStateID=3");

            DataTable dt = new DataTable();
            dt = DBHelper.getTable(sql);

            this.dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select RoomId '客服编号',roomtel '房间电话',roomtype '房间类型',remark '房间设备' from room as r inner join roomtype as rt on r.roomtypeid=rt.roomtypeid where RoomStateID=3");
            DataTable dt = new DataTable();
            dt = DBHelper.getTable(sql);
            DataRow dr = dt.Rows[index];
            string id = dr[0].ToString();
            string sql1 = string.Format("update room set roomstateid=1 where roomid='{0}'", id);
            DBHelper.getTable(sql1);
            this.dirty_Load(null,null);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
