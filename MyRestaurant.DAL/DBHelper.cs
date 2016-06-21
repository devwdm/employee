using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using MyRestaurant.Model;

namespace MyRestaurant.DAL
{
    class DBHelper
    {
        public static readonly string connString = @"Data Source=.;Initial Catalog=CanYinGuanLi;Integrated Security=True";
        #region 数据库访问方法

        #region 添加
        /// <summary>
        /// 描述：添加
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static int ExecuteCommand(string sql, params SqlParameter[] values)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddRange(values);
                    int rows = cmd.ExecuteNonQuery();
                    return rows;
                }
            }
        }
        #endregion

        #region 查询所有信息
        /// <summary>
        /// ExecuteReader(string sql):查询并返回SqlDataReader,调用后一定要关闭连接
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new    SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }
        #endregion
        /// <summary>
        /// ExecuteReader(string sql):查询并返回SqlDataReader,调用后一定要关闭连接
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="values">数据组形式的SQL语句参数</param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] values)
        {
            SqlDataReader reader = null;
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.Parameters.AddRange(values);
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            return reader;
        }


   




        #endregion

    }
}
