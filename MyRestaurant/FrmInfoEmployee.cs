using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using MyRestaurant.BLL;
using MyRestaurant.Model;

namespace MyRestaurant
{
    public partial class FrmInfoEmployee : Form
    {


        private BLLEmployee bllEmployee = new BLLEmployee();
        private Employee employee = null;

        public FrmInfoEmployee()
        {
            InitializeComponent();
        }
        //加载窗体事件
        private void FrmInfoEmployee_Load(object sender, EventArgs e)
        {
             dgvInfoEmployee.AutoGenerateColumns = false;
            dgvInfoEmployee.DataSource = bllEmployee.GetAllEmployee();
        }

        private void btnDeleteEmp_Click(object sender, EventArgs e)
        {
           
            int EmployeeID =Convert.ToInt32( dgvInfoEmployee.SelectedRows[0].Cells[0].Value);
            bllEmployee.DeleteEmployeeID(EmployeeID);
            if (EmployeeID > 0)
            {
                MessageBox.Show(string.Format("已删除工号为{0}的员工", EmployeeID), "删除成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvInfoEmployee.DataSource = bllEmployee.GetAllEmployee();
            }
            else {
                MessageBox.Show("请选择要删除的数据");
            }
           
        }
        //修改员工信息按钮
        private void btnModefilyEmp_Click(object sender, EventArgs e)
        {

            int EmployeeID = Convert.ToInt32(dgvInfoEmployee.SelectedRows[0].Cells[0].Value);
            bllEmployee.GetEmployeeByEmployeeID(EmployeeID);
            if (EmployeeID > 0)
            {
                 int n = Convert.ToInt32(dgvInfoEmployee.SelectedRows[0].Cells[0].Value);
                employee = bllEmployee.GetEmployeeByEmployeeID(n);
                txtUpdataEmpName.Text = employee.EmployeeName;
                txtUpdataEmpLoginName.Text = employee.EmployeeLoginName;
                txtUpdataEmpPwd.Text = employee.EmployeePwd;
                txtUpdataEmpCollephone.Text = employee.EmployeeCollephone;
                txtUpdataEmpExplation.Text = employee.EmployeeExplation;





            }
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
