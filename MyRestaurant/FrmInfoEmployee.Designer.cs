namespace MyRestaurant
{
    partial class FrmInfoEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvInfoEmployee = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteEmp = new System.Windows.Forms.Button();
            this.btnModefilyEmp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUpdataEmpName = new System.Windows.Forms.TextBox();
            this.txtUpdataEmpMoney = new System.Windows.Forms.TextBox();
            this.txtUpdataEmpCollephone = new System.Windows.Forms.TextBox();
            this.txtUpdataEmpPwd = new System.Windows.Forms.TextBox();
            this.txtUpdataEmpLoginName = new System.Windows.Forms.TextBox();
            this.txtUpdataEmpExplation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInfoEmployee
            // 
            this.dgvInfoEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvInfoEmployee.Location = new System.Drawing.Point(12, 188);
            this.dgvInfoEmployee.Name = "dgvInfoEmployee";
            this.dgvInfoEmployee.RowTemplate.Height = 23;
            this.dgvInfoEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfoEmployee.Size = new System.Drawing.Size(939, 273);
            this.dgvInfoEmployee.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "EmployeeID";
            this.Column1.HeaderText = "工号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "StatusID";
            this.Column2.HeaderText = "部门";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "EmployeeLoginName";
            this.Column3.HeaderText = "登入名";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "EmployeeName";
            this.Column4.HeaderText = "员工姓名";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "EmployeeSex";
            this.Column5.HeaderText = "性别";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "EmployeeAge";
            this.Column6.HeaderText = "年龄";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "EmployeeCollephone";
            this.Column7.HeaderText = "联系方式";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "EmployeeExplation";
            this.Column8.HeaderText = "备注";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "EmployeeMoney";
            this.Column9.HeaderText = "工资";
            this.Column9.Name = "Column9";
            // 
            // btnDeleteEmp
            // 
            this.btnDeleteEmp.Location = new System.Drawing.Point(840, 150);
            this.btnDeleteEmp.Name = "btnDeleteEmp";
            this.btnDeleteEmp.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteEmp.TabIndex = 1;
            this.btnDeleteEmp.Text = "删除";
            this.btnDeleteEmp.UseVisualStyleBackColor = true;
            this.btnDeleteEmp.Click += new System.EventHandler(this.btnDeleteEmp_Click);
            // 
            // btnModefilyEmp
            // 
            this.btnModefilyEmp.Location = new System.Drawing.Point(740, 150);
            this.btnModefilyEmp.Name = "btnModefilyEmp";
            this.btnModefilyEmp.Size = new System.Drawing.Size(75, 23);
            this.btnModefilyEmp.TabIndex = 2;
            this.btnModefilyEmp.Text = "修改";
            this.btnModefilyEmp.UseVisualStyleBackColor = true;
            this.btnModefilyEmp.Click += new System.EventHandler(this.btnModefilyEmp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "登入名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "登入密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(585, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "手机号码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(762, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "月收入";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "个人简介";
            // 
            // txtUpdataEmpName
            // 
            this.txtUpdataEmpName.Location = new System.Drawing.Point(92, 20);
            this.txtUpdataEmpName.Name = "txtUpdataEmpName";
            this.txtUpdataEmpName.Size = new System.Drawing.Size(116, 21);
            this.txtUpdataEmpName.TabIndex = 9;
            this.txtUpdataEmpName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtUpdataEmpMoney
            // 
            this.txtUpdataEmpMoney.Location = new System.Drawing.Point(809, 20);
            this.txtUpdataEmpMoney.Name = "txtUpdataEmpMoney";
            this.txtUpdataEmpMoney.Size = new System.Drawing.Size(100, 21);
            this.txtUpdataEmpMoney.TabIndex = 10;
            // 
            // txtUpdataEmpCollephone
            // 
            this.txtUpdataEmpCollephone.Location = new System.Drawing.Point(644, 20);
            this.txtUpdataEmpCollephone.Name = "txtUpdataEmpCollephone";
            this.txtUpdataEmpCollephone.Size = new System.Drawing.Size(100, 21);
            this.txtUpdataEmpCollephone.TabIndex = 11;
            // 
            // txtUpdataEmpPwd
            // 
            this.txtUpdataEmpPwd.Location = new System.Drawing.Point(474, 20);
            this.txtUpdataEmpPwd.Name = "txtUpdataEmpPwd";
            this.txtUpdataEmpPwd.Size = new System.Drawing.Size(100, 21);
            this.txtUpdataEmpPwd.TabIndex = 12;
            // 
            // txtUpdataEmpLoginName
            // 
            this.txtUpdataEmpLoginName.Location = new System.Drawing.Point(291, 20);
            this.txtUpdataEmpLoginName.Name = "txtUpdataEmpLoginName";
            this.txtUpdataEmpLoginName.Size = new System.Drawing.Size(100, 21);
            this.txtUpdataEmpLoginName.TabIndex = 13;
            // 
            // txtUpdataEmpExplation
            // 
            this.txtUpdataEmpExplation.Location = new System.Drawing.Point(92, 82);
            this.txtUpdataEmpExplation.Multiline = true;
            this.txtUpdataEmpExplation.Name = "txtUpdataEmpExplation";
            this.txtUpdataEmpExplation.Size = new System.Drawing.Size(807, 32);
            this.txtUpdataEmpExplation.TabIndex = 14;
            // 
            // FrmInfoEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 601);
            this.Controls.Add(this.txtUpdataEmpExplation);
            this.Controls.Add(this.txtUpdataEmpLoginName);
            this.Controls.Add(this.txtUpdataEmpPwd);
            this.Controls.Add(this.txtUpdataEmpCollephone);
            this.Controls.Add(this.txtUpdataEmpMoney);
            this.Controls.Add(this.txtUpdataEmpName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModefilyEmp);
            this.Controls.Add(this.btnDeleteEmp);
            this.Controls.Add(this.dgvInfoEmployee);
            this.Name = "FrmInfoEmployee";
            this.Text = "员工信息";
            this.Load += new System.EventHandler(this.FrmInfoEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInfoEmployee;
        private System.Windows.Forms.Button btnDeleteEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button btnModefilyEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUpdataEmpName;
        private System.Windows.Forms.TextBox txtUpdataEmpMoney;
        private System.Windows.Forms.TextBox txtUpdataEmpCollephone;
        private System.Windows.Forms.TextBox txtUpdataEmpPwd;
        private System.Windows.Forms.TextBox txtUpdataEmpLoginName;
        private System.Windows.Forms.TextBox txtUpdataEmpExplation;
    }
}