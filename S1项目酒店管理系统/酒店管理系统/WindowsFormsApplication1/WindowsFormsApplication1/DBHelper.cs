using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    class DBHelper
    {
        public static string strcon = "server=.;database=HotelSystems;Integrated Security=true";
        public static SqlConnection con = new SqlConnection(strcon);
        
       /// <summary>
       /// 获得单个数据的方法
       /// </summary>
       /// <param name="sql"></param>
       /// <returns></returns>
        public static object getSingle(string sql)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql,con);
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        /// <summary>
        /// 读取数据的方法
        /// </summary>
        /// <param name="sql"></param>
        public static SqlDataReader getReader(string sql)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql,con);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// 增删改的方法
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int setDataBySql(string sql)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql,con);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public static DataTable getTable(string sql)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sql,strcon);
            try
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }
            
        }
    }
}
