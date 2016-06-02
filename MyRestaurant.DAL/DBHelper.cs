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
        public static readonly string connString = "Data Source=.;Initial Catalog=CanYinGuanLi;Integrated Security=True";
        #region 数据库访问方法

        #region 添加
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

        public static SqlDataReader ExecuteReader(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }
        #endregion





        #endregion

    }
}
