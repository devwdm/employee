using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MyRestaurant.Model;
using MyRestaurant.DAL;
using MyRestaurant.BLL;


namespace MyRestaurant
{
    public partial class FrmEmployee : Form
    {
        //定义私有变量
        private BLLStatus bllStatus = new BLLStatus();
        private BLLEmployee bllEmployee = new BLLEmployee();

        public FrmEmployee()
        {
            InitializeComponent();
        }

        //窗体载入事件
        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            cmbStatusFrmEmployeeIntBing();//绑定下拉框的值
            




        }


        #region  窗体载入事件
        //绑定下拉框的值
        private void cmbStatusFrmEmployeeIntBing()
        {

            cmbStatusFrmEmployee.DisplayMember = "StatusName";//cmbStatusFrmEmployee空间显示成员
            cmbStatusFrmEmployee.ValueMember = "StatusID";//空间cmbStatusFrmEmployee值
            cmbStatusFrmEmployee.DataSource = bllStatus.GetAllDALStatus();//cmbStatusFrmEmployee空间绑定数据源
        }


        #endregion
        //新增按钮
        private void btnAddFrmEmployee_Click(object sender, EventArgs e)
        {
            string EmployeeName = txtNameEmployee.Text.Trim();
            string EmployeeLoginName = txtLoginNameEmployee.Text.Trim();
            string EmployeePwd = txtPwdEmployee.Text.Trim();
            if (string.IsNullOrEmpty(EmployeeName) && string.IsNullOrEmpty(EmployeeLoginName) && string.IsNullOrEmpty(EmployeePwd))
            {
                MessageBox.Show("请您填好信息！", "温馨提示");
            }
            else if (string.IsNullOrEmpty(EmployeeName))
            {
                lblMerror.Text = "用户名不能为空！";
                lblNameFrmEmployee.Text = "*";
            }
            else if (string.IsNullOrEmpty(EmployeeLoginName))
            {
                lblMerror.Text = "登入名不能为空！";
                lblLoginNameEmployee.Text = "*";
            }
            else if (string.IsNullOrEmpty(EmployeePwd))
            {
                lblMerror.Text = "登入密码不能为空！";
                lblPwdEmployee.Text = "*";
            }
            else
            {
                Employee employee = new Employee();
                employee.EmployeeName = EmployeeName;
                employee.EmployeeLoginName = EmployeeName;
                employee.EmployeePwd = EmployeePwd;
                employee.EmployeeAge = Convert.ToInt32(txtAge.Text);
                employee.EmployeeSex = txtSex.Text;
                employee.EmployeeExplation = txtDescription.Text;
                employee.EmployeeCollephone = txtCollephone.Text;
                employee.EmployeeMoney = Convert.ToDecimal(txtMoneyEmployee.Text);
                if (bllEmployee.AddEmployee(employee))
                {
                    lblMerror.Text = "添加成功！";
                }
                else
                {
                    lblMerror.Text = "添加失败！";
                }
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtAge.Text = string.Empty;
            txtCollephone.Text = string.Empty;
            txtLoginNameEmployee.Text = string.Empty;
            txtMoneyEmployee.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtPwdEmployee.Text = string.Empty;
            txtSex.Text = string.Empty;
            txtNameEmployee.Text = string.Empty;
            cmbStatusFrmEmployee.Text = "请选择";
            lblMerror.Text = "请重新输入信息！";
        }
    }
}
