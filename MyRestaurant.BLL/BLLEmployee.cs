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
    {

        /// <summary>
        /// BLLEmployee的业务逻辑层
        /// </summary>
        private DALEmployee dalEmployee = new DALEmployee();
        /// <summary>
        /// 描述获取所有员工信息
        /// </summary>
        /// <returns></returns>
        public IList<Employee> GetAllEmployee()
        {
            return dalEmployee.GetAllEmployee();
        }
        /// <summary>
        /// 描述：添加新员工
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public bool AddEmployee(Employee employee)
        {
            return dalEmployee.AddEmployee(employee);
        }
        /// <summary>
        /// 描述：通过employeeID 删除员工
        /// </summary>
        /// <param name="employeeID"></param>
        /// <returns></returns>
        public int DeleteEmployeeID(int employeeID)
        {
            return dalEmployee.DeleteEmployee(employeeID);
        }
        /// <summary>
        /// 描述：修改员工信息
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public bool ModifyEmployee(Employee employee)
        {
            return dalEmployee.ModifyEmployee(employee);
        }

        /// <summary>
        /// 描述：GetEmployeeByEmployeeID 按员工编好获取一条记录
        /// </summary>
        /// <param name="employeeID"></param>
        /// <returns></returns>
        public Employee GetEmployeeByEmployeeID(int employeeID)
        {
            return dalEmployee.GetEmployeeByEmployeeID(employeeID);
        }
        }
}
