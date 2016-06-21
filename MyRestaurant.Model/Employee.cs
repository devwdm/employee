using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRestaurant.Model
{

    /// <summary>
    /// 描述：Employee 实体类
    /// </summary>

    public class Employee
    {
        public int EmployeeID { get; set; }
        public int StatusID { get; set; }
        public string EmployeeLoginName { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePwd { get; set; }
        public string EmployeeCollephone { get; set; }
        public string EmployeeSex { get; set; }
        public int EmployeeAge { get; set; }
        public string EmployeeExplation { get; set; }
        public decimal EmployeeMoney { get; set; }
        public string StatusName { get; set; }

    }
}
