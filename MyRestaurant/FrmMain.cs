using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRestaurant
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void 关闭系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddEmployee frmEmployee = new FrmAddEmployee();
            frmEmployee.MdiParent = this;
            frmEmployee.Show();            
        }

        private void 员工信息ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmInfoEmployee frmInfoEmployee = new FrmInfoEmployee();
            frmInfoEmployee.MdiParent = this;
            frmInfoEmployee.Show();
        }

        private void 基本信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 管理员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdmin frmAdmin = new FrmAdmin();
            frmAdmin.MdiParent = this;
            frmAdmin.Show();
        }

        private void 点餐ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGoods frmGoods = new FrmGoods();
            frmGoods.MdiParent = this;
            frmGoods.Show();
        }
    }
}
