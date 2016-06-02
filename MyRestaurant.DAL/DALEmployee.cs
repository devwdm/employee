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
        public IList<Employee> GetAllEmployee()
        {
            IList<Employee> listEmployee = new List<Employee>();
            string sql = "select * from Employee";

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
                    employee.EmployeeMoney = Convert.ToInt32(reader["EmployeeMoney"]);
                    employee.EmployeeCollephone = reader["EmployeeCollephone"].ToString();
                    employee.EmployeeExplation = reader["EmployeeExplation"].ToString();
                    listEmployee.Add(employee);


                }
            }
            return listEmployee;


        }
        #endregion

        #region 新增员工信息
        public bool AddEmployee(Employee employee)
        {
            //bool addtag = false;
            //using (SqlConnection conn = new SqlConnection(DBHelper.connString))
            //{
            //    conn.Open();
            //    string sql = "insert into Employee(EmployeeLoginName,EmployeePwd,EmployeeName,EmployeeCollephone,EmployeeSex,EmployeeAge,EmployeeExplation,EmployeeMoney,StatusID) value (@EmployeeLoginName,@EmployeePwd,@EmployeeName,@EmployeeCollephone,@EmployeeSex,@EmployeeAge,@EmployeeExplation,@EmployeeMoney)";

            //    SqlCommand cmd = new SqlCommand(sql, conn);
            //    cmd.Parameters.AddWithValue("@EmployeeLoginName", employee.EmployeeLoginName);
            //    cmd.Parameters.AddWithValue("@EmployeePwd", employee.EmployeePwd);
            //    cmd.Parameters.AddWithValue("@EmployeeName", employee.EmployeeName);
            //    cmd.Parameters.AddWithValue("@EmployeeCollephone", employee.EmployeeCollephone);
            //    cmd.Parameters.AddWithValue("@EmployeeSex", employee.EmployeeSex);
            //    cmd.Parameters.AddWithValue("@EmployeeAge", employee.EmployeeAge);
            //    cmd.Parameters.AddWithValue("@EmployeeExplation", employee.EmployeeExplation);
            //    cmd.Parameters.AddWithValue("@EmployeeMoney", employee.EmployeeMoney);
            //    cmd.Parameters.AddWithValue("@StatusID", employee.StatusID);
            //    int n = cmd.ExecuteNonQuery();
            //    if (n == 1)
            //    {
            //        addtag = true;
            //    }
            //    return addtag;
            //}

            string sql = "insert into Employee(EmployeeLoginName,EmployeePwd,EmployeeName,EmployeeCollephone,EmployeeSex,EmployeeAge,EmployeeExplation,EmployeeMoney,StatusID) values (@EmployeeLoginName,@EmployeePwd,@EmployeeName,@EmployeeCollephone,@EmployeeSex,@EmployeeAge,@EmployeeExplation,@EmployeeMoney,@StatusID)";
            SqlParameter[] parameters = {
            new SqlParameter("@EmployeeLoginName", SqlDbType.VarChar),
            new SqlParameter("@EmployeePwd", SqlDbType.VarChar),
             new SqlParameter("@EmployeeName", SqlDbType.VarChar),
             new SqlParameter("@EmployeeCollephone", SqlDbType.VarChar),
              new SqlParameter("@EmployeeSex", SqlDbType.VarChar),
               new SqlParameter("@EmployeeAge", SqlDbType.VarChar),
                new SqlParameter("@EmployeeExplation", SqlDbType.VarChar),
                 new SqlParameter("@EmployeeMoney", SqlDbType.Decimal),
                  new SqlParameter("@StatusID", SqlDbType.VarChar)
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

        int n = DBHelper.ExecuteCommand(sql,parameters);//返回受影响的行数
        return n == 1;
        
        }

        #endregion

    }
}
