using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRestaurant.Model
{
  public  class Admin
    {
        public int AdminID { get; set; }
        public string AdminLoginName { get; set; }
        public string AdminPwd { get; set; }
        public int StatusID { get; set; }

    }
}
