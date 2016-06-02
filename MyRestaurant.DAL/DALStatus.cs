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
   public class DALStatus
    {
        public IList<Status> GetAllStatus()
        {
            IList<Status> listStatus =new List<Status>() ;//通过泛型集合返回所有Status的信息

            string sql = "select * from Status";//定义SQl语句
            SqlDataReader reader = DBHelper.ExecuteReader(sql);//执行SQL语句并返回一天记录
            
                while (reader.Read())
                {
                    Status status = new Status();
                    status.StatusID = int.Parse(reader["StatusID"].ToString());
                    status.StatusName = reader["StatusName"].ToString();
                    listStatus.Add(status);
                }
            

            return listStatus;
        }

    }
}
