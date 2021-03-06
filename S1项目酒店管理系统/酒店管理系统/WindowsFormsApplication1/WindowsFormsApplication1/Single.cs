﻿using System;
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
    public partial class Single : Form
    {
        public Single()
        {
            InitializeComponent();
        }

        private void Single_Load(object sender, EventArgs e)
        {
            //选择天数的控件  最大选项为30天；
            for (int i = 1; i <= 30; i++)
            {
                this.cobdate.Items.Add(i);
            }

            //创建查询语句  查询房间的类型
            string sql = "select * from RoomType";

            //调用查询方法 并获得值
            SqlDataReader dr = DBHelper.getReader(sql);

            //遍历 将房间类型添加 到界面 房间类型的combox
            while (dr.Read())
            {
                this.cobRoomTypeId.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void cobRoomTypeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            //清空
            this.cobRoomId.Items.Clear();
            this.cobRoomId.Text = "";

            string sql = string.Format("select * from room inner join RoomType on Room.RoomTypeId = RoomType.RoomTypeId   inner join RoomState on Room.RoomStateID=RoomState.RoomStateID  where roomType='{0}'and RoomState='空房'", this.cobRoomTypeId.Text);


            //调用查询方法 并获得值
            SqlDataReader dr = DBHelper.getReader(sql);

            //遍历 将房间类型添加 到界面 房间类型的combox
            while (dr.Read())
            {

                this.cobRoomId.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void cobRoomId_SelectedIndexChanged(object sender, EventArgs e)
        {
            //清空

            this.txtRoomprice.Text = "";

            string sql = string.Format("select DayMoney from room inner join RoomType on Room.RoomTypeId = RoomType.RoomTypeId  where roomType='{0}'and RoomId='{1}'", this.cobRoomTypeId.Text, this.cobRoomId.Text);

            //调用查询方法 并获得值
            SqlDataReader dr = DBHelper.getReader(sql);

            //遍历 将房间类型添加 到界面 房间类型的combox
            while (dr.Read())
            {
                this.txtRoomprice.Text = dr[0].ToString();
            }
            dr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string clientname = this.TXTClientName.Text;
            string sex = this.cobsex.Text;
            string idcard = this.txtID.Text;
            string phnumber = this.txtPhonenumber.Text;
            string roomid = this.cobRoomId.Text;
            string Foregift = this.txtForegift.Text;
            string money = null;//总租金

            DialogResult dt = MessageBox.Show("确定登记？", "登记确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dt == DialogResult.OK)
            {
                if (clientname.Length == 0 || sex.Length == 0 || idcard.Length == 0 || this.txtForegift.Text.Length == 0 || this.cobRoomId.Text.Length == 0)
                {
                    MessageBox.Show("信息不完整", "非空", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;// 不要提交 终止   
                }
                else
                {
                    if (this.txtID.Text.Length != 18)
                    {
                        MessageBox.Show("身份证长度不够");
                    }


                    int insert1 = 0;
                    int a = int.Parse(this.labrent.Text);
                    int b = int.Parse(this.txtForegift.Text);
                    if (b >= a)
                    {
                        //登记信息插入语句
                        string sql = string.Format("insert into client(ClientName,Sex,IdCrad,Telephone,RoomId,Time) values('{0}','{1}','{2}','{3}','{4}',default)", clientname, sex, idcard, phnumber, roomid);
                        //把住房状态从无人改为有人
                        string sql2 = string.Format("update Room set RoomStateID=2 where RoomId= '{0}'", roomid);

                        insert1 = DBHelper.setDataBySql(sql);
                        insert1 = insert1 + DBHelper.setDataBySql(sql2);

                        //查询出 登记信息后的客户编号  根据客户编号 往收银表里插数据
                        string sql3 = string.Format("select ClientId from Client where RoomId='{0}'", roomid);
                        SqlDataReader dr = DBHelper.getReader(sql3);
                        string cid = null;
                        while (dr.Read())
                        {
                            cid = dr[0].ToString();
                        }
                        dr.Close();



                        //往收银表里插押金数据
                        string sql5 = string.Format("insert into CashRegister (Foregift,ClientId,EmployyID) values('{0}','{1}','Z004')", this.txtForegift.Text, cid);
                        insert1 = insert1 + DBHelper.setDataBySql(sql5);
                        money = this.labrent.Text;
                        //清除已定房间  及界面数据
                        this.cobRoomId.Items.Remove(this.cobRoomId.SelectedItem);
                        this.cobRoomId.Text = "";
                        this.TXTClientName.Text = "";
                        this.cobsex.Text = "";
                        this.txtID.Text = "";
                        this.txtPhonenumber.Text = "";
                        this.txtForegift.Text = "";
                        this.labrent.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("所缴押金不足");
                        return;
                    }
                    if (insert1 >= 3)
                    {
                        MessageBox.Show(string.Format("应收{0}元,实收{1}元", money, Foregift));
                        MessageBox.Show("登记成功");
                    }
                    else
                    {
                        MessageBox.Show("登记失败");
                    }
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("确认退出吗？","退出提醒",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(dt==DialogResult.OK)
            {
                this.Close();
            }
        }

        private void cobdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sum = this.txtRoomprice.Text;
            double money = Double.Parse(sum);
            //居住天数
            double day = Convert.ToDouble(this.cobdate.Text);
            //天数乘单价等于总金额
            double aa = day * money;
            this.labrent.Text = aa.ToString();
        }
    }
}
