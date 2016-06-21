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
    public class DALEmployee
    {
        #region 获取所有员工信息
        /// <summary>
        /// 描述：获取所有员工信息
        /// </summary>
        /// <returns></returns>
        public IList<Employee> GetAllEmployee()
        {
            IList<Employee> listEmployee = new List<Employee>();
            string sql = @"SELECT   Employee.EmployeeID, Employee.StatusID, Employee.EmployeeLoginName, Employee.EmployeePwd,   Employee.EmployeeName, Employee.EmployeeCollephone, Employee.EmployeeSex, Employee.EmployeeAge,     Employee.EmployeeExplation, Employee.EmployeeMoney, Status.StatusName FROM    Employee INNER JOIN     Status ON Employee.StatusID = Status.StatusID";
            using (SqlDataReader reader = DBHelper.ExecuteReader(sql))
            {
                while (reader.Read())
                {
                    Employee employee = new Employee();
                    employee.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                    employee.StatusID = Convert.ToInt32(reader["StatusID"]);
                    employee.EmployeeLoginName = reader["EmployeeLoginName"].ToString();
                    employee.EmployeePwd = reader["EmployeePwd"].ToString();
                    employee.EmployeeAge = Convert.ToInt32(reader["EmployeeAge"]);
                    employee.EmployeeSex = reader["EmployeeSex"].ToString();
                    employee.EmployeeMoney = Convert.ToDecimal(reader["EmployeeMoney"].ToString());
                    employee.EmployeeCollephone = reader["EmployeeCollephone"].ToString();
                    employee.EmployeeExplation = reader["EmployeeExplation"].ToString();
                    employee.EmployeeName = reader["EmployeeName"].ToString();
                    employee.StatusName = reader["StatusName"].ToString();
                    listEmployee.Add(employee);
                }
            }
            return listEmployee;
        }
        #endregion 描述:新增员工
        /// <summary>
        /// 描述:新增员工
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public bool AddEmployee(Employee employee)
        {
            string sql = "insert into Employee(EmployeeLoginName,EmployeePwd,EmployeeName,EmployeeCollephone,EmployeeSex,EmployeeAge,EmployeeExplation,EmployeeMoney,StatusID) values (@EmployeeLoginName,@EmployeePwd,@EmployeeName,@EmployeeCollephone,@EmployeeSex,@EmployeeAge,@EmployeeExplation,@EmployeeMoney,@StatusID)";
            SqlParameter[] parameters = {
            new SqlParameter("@EmployeeLoginName", SqlDbType.VarChar),
            new SqlParameter("@EmployeePwd", SqlDbType.VarChar),
             new SqlParameter("@EmployeeName", SqlDbType.VarChar),
             new SqlParameter("@EmployeeCollephone", SqlDbType.VarChar),
              new SqlParameter("@EmployeeSex", SqlDbType.VarChar),
               new SqlParameter("@EmployeeAge", SqlDbType.Int),
                new SqlParameter("@EmployeeExplation", SqlDbType.VarChar),
                 new SqlParameter("@EmployeeMoney", SqlDbType.Decimal),
                  new SqlParameter("@StatusID", SqlDbType.Int)
        };
            parameters[0].Value = employee.EmployeeLoginName;
            parameters[1].Value = employee.EmployeePwd;
            parameters[2].Value = employee.EmployeeName;
            parameters[3].Value = employee.EmployeeCollephone;
            parameters[4].Value = employee.EmployeeSex;
            parameters[5].Value = employee.EmployeeAge;
            parameters[6].Value = employee.EmployeeExplation;
            parameters[7].Value = employee.EmployeeMoney;
            parameters[8].Value = employee.StatusID;

            int n = DBHelper.ExecuteCommand(sql, parameters);//返回受影响的行数
            return n == 1;

        }



        #region
        /// <summary>
        /// ModifyEmployee：修改员工信息
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public bool ModifyEmployee(Employee employee)
        {
            string sql = "update Employee set StatusID=@StatusID, EmployeeLoginName=@EmployeeLoginName, EmployeePwd=@EmployeePwd, EmployeeName=@EmployeeName, EmployeeCollephone=@EmployeeCollephone, EmployeeSex=@EmployeeSex, EmployeeAge=@EmployeeAge, EmployeeExplation=@EmployeeExplation, EmployeeMoney=@EmployeeMoney where  EmployeeID=@Employee";

            SqlParameter[] parameter = {
                new SqlParameter("@EmployeeLoginName",SqlDbType.VarChar),
                 new SqlParameter("@EmployeePwd",SqlDbType.VarChar),
                  new SqlParameter("@EmployeeName",SqlDbType.VarChar),
                   new SqlParameter("@EmployeeCollephone",SqlDbType.VarChar),
                    new SqlParameter("@EmployeeSex",SqlDbType.VarChar),
                     new SqlParameter("@EmployeeAge",SqlDbType.Int),
                      new SqlParameter("@EmployeeExplation",SqlDbType.VarChar),
                       new SqlParameter("@EmployeeMoney",SqlDbType.Decimal),

            };
            parameter[0].Value = employee.EmployeeLoginName;
            parameter[1].Value = employee.EmployeePwd;
            parameter[2].Value = employee.EmployeeName;
            parameter[3].Value = employee.EmployeeCollephone;
            parameter[4].Value = employee.EmployeeSex;
            parameter[5].Value = employee.EmployeeAge;
            parameter[6].Value = employee.EmployeeExplation;
            parameter[7].Value = employee.EmployeeMoney;


            int n = DBHelper.ExecuteCommand(sql, parameter);//返回受影响的行数
            return n == 1;//修改成功
        }

        /// <summary>
        /// DeleteEmployee(int employeeID):按员工编号删除一条记录
        /// </summary>
        /// <param name="employeeID"></param>
        /// <returns></returns>
        public int DeleteEmployee(int employeeID)
        {
            string sql = "delete from Employee where EmployeeID=@EmployeeID";
            SqlParameter parmeter = new SqlParameter("@EmployeeID", SqlDbType.Int);
            parmeter.Value = employeeID;
            int n = DBHelper.ExecuteCommand(sql, parmeter);
            return n;
        }


        /// <summary>
        /// 描述：通过employeeID返回一条记录
        /// </summary>
        /// <param name="employeeID"></param>
        /// <returns></returns>
        public Employee GetEmployeeByEmployeeID(int employeeID)
        {
            Employee employee = new Employee();
            string sql = "select * from Employee where EmployeeID = @EmployeeID";
            SqlParameter parameter = new SqlParameter("@EmployeeID",SqlDbType.Int);
            parameter.Value = employeeID;
            using (SqlDataReader reader = DBHelper.ExecuteReader(sql, parameter))
            {
                if (reader.Read())
                {

                    employee.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                    employee.StatusID = Convert.ToInt32(reader["StatusID"]);
                    employee.EmployeeLoginName = reader["EmployeeLoginName"].ToString();
                    employee.EmployeePwd = reader["EmployeePwd"].ToString();
                    employee.EmployeeAge = Convert.ToInt32(reader["EmployeeAge"]);
                    employee.EmployeeSex = reader["EmployeeSex"].ToString();
                    employee.EmployeeMoney = Convert.ToDecimal(reader["EmployeeMoney"].ToString());
                    employee.EmployeeCollephone = reader["EmployeeCollephone"].ToString();
                    employee.EmployeeExplation = reader["EmployeeExplation"].ToString();
                    employee.EmployeeName = reader["EmployeeName"].ToString();
                    employee.StatusName = reader["StatusName"].ToString();

                }
            }
            return employee;
        }


        #endregion
    }
}
