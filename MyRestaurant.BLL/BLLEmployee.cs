using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyRestaurant.Model;
using MyRestaurant.DAL;

namespace MyRestaurant.BLL
{
   public class BLLEmployee
    {/// <summary>
     /// BLLEmployee的业务逻辑层
     /// </summary>
        private DALEmployee dalEmployee = new DALEmployee();
        public IList<Employee> GetAllDALEmployee()
        {
            return dalEmployee.GetAllEmployee();
        }
        public bool AddEmployee(Employee employee)
        {
            return dalEmployee.AddEmployee(employee);
        }
    }
}
