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
            FrmEmployee frmEmployee = new FrmEmployee();
            frmEmployee.MdiParent = this;
            frmEmployee.Show();            
        }

        private void 员工信息ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmInfoEmployee frmInfoEmployee = new FrmInfoEmployee();
            frmInfoEmployee.MdiParent = this;
            frmInfoEmployee.Show();
        }
    }
}
