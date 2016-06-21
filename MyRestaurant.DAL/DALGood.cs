using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using MyRestaurant.Model;

namespace MyRestaurant.DAL
{
    public class DALGood
    {
        /// <summary>
        /// 描述：获取所有商品信息
        /// </summary>
        /// <returns></returns>
        public IList<Good> GetAllGood()
        {
            IList<Good> listGood = new List<Good>();
            string sql = @"select * from Good";
            using (SqlDataReader reader = DBHelper.ExecuteReader(sql))
            {
                while (reader.Read())
                {
                    Good good = new Good();
                    good.GoodID = Convert.ToInt32(reader["GoodID"]);
                    good.GoodName = reader["GoodName"].ToString();
                    good.GoodPricesIn = Convert.ToDecimal(reader["GoodPricesIn"]);
                    listGood.Add(good);
                }

            }
            return listGood;
        }
    }
}
