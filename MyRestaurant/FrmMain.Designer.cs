namespace MyRestaurant
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.基本信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工信息ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.账单管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.点餐ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基本信息ToolStripMenuItem,
            this.商品管理ToolStripMenuItem,
            this.员工管理ToolStripMenuItem,
            this.账单管理ToolStripMenuItem,
            this.关闭系统ToolStripMenuItem,
            this.点餐ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(933, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 基本信息ToolStripMenuItem
            // 
            this.基本信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理员ToolStripMenuItem});
            this.基本信息ToolStripMenuItem.Name = "基本信息ToolStripMenuItem";
            this.基本信息ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.基本信息ToolStripMenuItem.Text = "基本信息";
            this.基本信息ToolStripMenuItem.Click += new System.EventHandler(this.基本信息ToolStripMenuItem_Click);
            // 
            // 商品管理ToolStripMenuItem
            // 
            this.商品管理ToolStripMenuItem.Name = "商品管理ToolStripMenuItem";
            this.商品管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.商品管理ToolStripMenuItem.Text = "商品管理";
            // 
            // 员工管理ToolStripMenuItem
            // 
            this.员工管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.员工信息ToolStripMenuItem,
            this.员工信息ToolStripMenuItem1});
            this.员工管理ToolStripMenuItem.Name = "员工管理ToolStripMenuItem";
            this.员工管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.员工管理ToolStripMenuItem.Text = "员工管理";
            // 
            // 员工信息ToolStripMenuItem
            // 
            this.员工信息ToolStripMenuItem.Name = "员工信息ToolStripMenuItem";
            this.员工信息ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.员工信息ToolStripMenuItem.Text = "新增员工";
            this.员工信息ToolStripMenuItem.Click += new System.EventHandler(this.员工信息ToolStripMenuItem_Click);
            // 
            // 员工信息ToolStripMenuItem1
            // 
            this.员工信息ToolStripMenuItem1.Name = "员工信息ToolStripMenuItem1";
            this.员工信息ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.员工信息ToolStripMenuItem1.Text = "员工信息";
            this.员工信息ToolStripMenuItem1.Click += new System.EventHandler(this.员工信息ToolStripMenuItem1_Click);
            // 
            // 账单管理ToolStripMenuItem
            // 
            this.账单管理ToolStripMenuItem.Name = "账单管理ToolStripMenuItem";
            this.账单管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.账单管理ToolStripMenuItem.Text = "账单管理";
            // 
            // 关闭系统ToolStripMenuItem
            // 
            this.关闭系统ToolStripMenuItem.Name = "关闭系统ToolStripMenuItem";
            this.关闭系统ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.关闭系统ToolStripMenuItem.Text = "关闭系统";
            this.关闭系统ToolStripMenuItem.Click += new System.EventHandler(this.关闭系统ToolStripMenuItem_Click);
            // 
            // 管理员ToolStripMenuItem
            // 
            this.管理员ToolStripMenuItem.Name = "管理员ToolStripMenuItem";
            this.管理员ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.管理员ToolStripMenuItem.Text = "管理员";
            this.管理员ToolStripMenuItem.Click += new System.EventHandler(this.管理员ToolStripMenuItem_Click);
            // 
            // 点餐ToolStripMenuItem
            // 
            this.点餐ToolStripMenuItem.Name = "点餐ToolStripMenuItem";
            this.点餐ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.点餐ToolStripMenuItem.Text = "点餐";
            this.点餐ToolStripMenuItem.Click += new System.EventHandler(this.点餐ToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 576);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "我的小餐馆";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 基本信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工信息ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 账单管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 点餐ToolStripMenuItem;
    }
}

