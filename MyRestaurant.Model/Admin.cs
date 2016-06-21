using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRestaurant.Model
{
    /// <summary>
    /// 描述：Admin实体类
    /// </summary>
    public class Admin
    {
        public int AdminID { get; set; }
        public string AdminLoginName { get; set; }
        public string AdminPwd { get; set; }
        public int StatusID { get; set; }

    }
}
