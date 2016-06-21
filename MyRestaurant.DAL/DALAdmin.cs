using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Data;
using System.Data.SqlClient;
using MyRestaurant.Model;

namespace MyRestaurant.DAL
{
    public class DALAdmin
    {
        /// <summary>
        /// 描述：获取所有管理员信息
        /// </summary>
        /// <returns></returns>
        public IList<Admin> GetAllAdmin()
        {
            IList<Admin> listAdmin = new List<Admin>();
            string sql = @"select * from Admin";
            using (SqlDataReader reader = DBHelper.ExecuteReader(sql))
            {
                while (reader.Read())
                {
                    Admin admin = new Admin();
                    admin.AdminID = Convert.ToInt32(reader["AdminID"]);
                    admin.AdminLoginName = reader["AdminLoginName"].ToString();
                    admin.AdminPwd = reader["AdminPwd"].ToString();

                    listAdmin.Add(admin);
                }
                
            }
            return listAdmin;
        }
    }
}
