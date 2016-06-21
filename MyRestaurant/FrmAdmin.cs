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
    public partial class FrmAdmin : Form
    {
        private BLLAdmin bllAdmin = new BLLAdmin();
        public FrmAdmin()
        {
            InitializeComponent();
        }
        //窗体加载事件
        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            IList<Admin> listAdmin = bllAdmin.GetAllAdmin();
            dgvAdminInfo.DataSource = listAdmin;
        }
    }
}
