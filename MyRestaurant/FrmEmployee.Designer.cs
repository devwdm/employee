namespace MyRestaurant
{
    partial class FrmEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStatusFrmEmployee = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNameEmployee = new System.Windows.Forms.TextBox();
            this.txtLoginNameEmployee = new System.Windows.Forms.TextBox();
            this.txtPwdEmployee = new System.Windows.Forms.TextBox();
            this.btnAddFrmEmployee = new System.Windows.Forms.Button();
            this.lblMerror = new System.Windows.Forms.Label();
            this.lblNameFrmEmployee = new System.Windows.Forms.Label();
            this.lblLoginNameEmployee = new System.Windows.Forms.Label();
            this.lblPwdEmployee = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCollephone = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMoneyEmployee = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "身份类型";
            // 
            // cmbStatusFrmEmployee
            // 
            this.cmbStatusFrmEmployee.FormattingEnabled = true;
            this.cmbStatusFrmEmployee.Location = new System.Drawing.Point(128, 132);
            this.cmbStatusFrmEmployee.Name = "cmbStatusFrmEmployee";
            this.cmbStatusFrmEmployee.Size = new System.Drawing.Size(121, 20);
            this.cmbStatusFrmEmployee.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "登入名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "登入密码";
            // 
            // txtNameEmployee
            // 
            this.txtNameEmployee.Location = new System.Drawing.Point(128, 17);
            this.txtNameEmployee.Name = "txtNameEmployee";
            this.txtNameEmployee.Size = new System.Drawing.Size(100, 21);
            this.txtNameEmployee.TabIndex = 5;
            // 
            // txtLoginNameEmployee
            // 
            this.txtLoginNameEmployee.Location = new System.Drawing.Point(128, 46);
            this.txtLoginNameEmployee.Name = "txtLoginNameEmployee";
            this.txtLoginNameEmployee.Size = new System.Drawing.Size(100, 21);
            this.txtLoginNameEmployee.TabIndex = 6;
            // 
            // txtPwdEmployee
            // 
            this.txtPwdEmployee.Location = new System.Drawing.Point(128, 89);
            this.txtPwdEmployee.Name = "txtPwdEmployee";
            this.txtPwdEmployee.Size = new System.Drawing.Size(100, 21);
            this.txtPwdEmployee.TabIndex = 7;
            // 
            // btnAddFrmEmployee
            // 
            this.btnAddFrmEmployee.Location = new System.Drawing.Point(601, 384);
            this.btnAddFrmEmployee.Name = "btnAddFrmEmployee";
            this.btnAddFrmEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnAddFrmEmployee.TabIndex = 8;
            this.btnAddFrmEmployee.Text = "新增员工";
            this.btnAddFrmEmployee.UseVisualStyleBackColor = true;
            this.btnAddFrmEmployee.Click += new System.EventHandler(this.btnAddFrmEmployee_Click);
            // 
            // lblMerror
            // 
            this.lblMerror.AutoSize = true;
            this.lblMerror.ForeColor = System.Drawing.Color.Coral;
            this.lblMerror.Location = new System.Drawing.Point(259, 20);
            this.lblMerror.Name = "lblMerror";
            this.lblMerror.Size = new System.Drawing.Size(41, 12);
            this.lblMerror.TabIndex = 9;
            this.lblMerror.Text = "label5";
            // 
            // lblNameFrmEmployee
            // 
            this.lblNameFrmEmployee.AutoSize = true;
            this.lblNameFrmEmployee.ForeColor = System.Drawing.Color.Red;
            this.lblNameFrmEmployee.Location = new System.Drawing.Point(234, 26);
            this.lblNameFrmEmployee.Name = "lblNameFrmEmployee";
            this.lblNameFrmEmployee.Size = new System.Drawing.Size(0, 12);
            this.lblNameFrmEmployee.TabIndex = 10;
            // 
            // lblLoginNameEmployee
            // 
            this.lblLoginNameEmployee.AutoSize = true;
            this.lblLoginNameEmployee.ForeColor = System.Drawing.Color.Red;
            this.lblLoginNameEmployee.Location = new System.Drawing.Point(234, 55);
            this.lblLoginNameEmployee.Name = "lblLoginNameEmployee";
            this.lblLoginNameEmployee.Size = new System.Drawing.Size(0, 12);
            this.lblLoginNameEmployee.TabIndex = 11;
            // 
            // lblPwdEmployee
            // 
            this.lblPwdEmployee.AutoSize = true;
            this.lblPwdEmployee.ForeColor = System.Drawing.Color.Red;
            this.lblPwdEmployee.Location = new System.Drawing.Point(234, 98);
            this.lblPwdEmployee.Name = "lblPwdEmployee";
            this.lblPwdEmployee.Size = new System.Drawing.Size(0, 12);
            this.lblPwdEmployee.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "年龄";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "性别";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(128, 181);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 21);
            this.txtAge.TabIndex = 15;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(128, 232);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(100, 21);
            this.txtSex.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "手机号码";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "个人简介";
            // 
            // txtCollephone
            // 
            this.txtCollephone.Location = new System.Drawing.Point(134, 285);
            this.txtCollephone.Name = "txtCollephone";
            this.txtCollephone.Size = new System.Drawing.Size(100, 21);
            this.txtCollephone.TabIndex = 19;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(443, 37);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(265, 269);
            this.txtDescription.TabIndex = 20;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(153, 384);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "重置";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "月收入";
            // 
            // txtMoneyEmployee
            // 
            this.txtMoneyEmployee.Location = new System.Drawing.Point(134, 332);
            this.txtMoneyEmployee.Name = "txtMoneyEmployee";
            this.txtMoneyEmployee.Size = new System.Drawing.Size(100, 21);
            this.txtMoneyEmployee.TabIndex = 23;
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 460);
            this.Controls.Add(this.txtMoneyEmployee);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtCollephone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPwdEmployee);
            this.Controls.Add(this.lblLoginNameEmployee);
            this.Controls.Add(this.lblNameFrmEmployee);
            this.Controls.Add(this.lblMerror);
            this.Controls.Add(this.btnAddFrmEmployee);
            this.Controls.Add(this.txtPwdEmployee);
            this.Controls.Add(this.txtLoginNameEmployee);
            this.Controls.Add(this.txtNameEmployee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbStatusFrmEmployee);
            this.Controls.Add(this.label1);
            this.Name = "FrmEmployee";
            this.Text = "FrmEmployee";
            this.Load += new System.EventHandler(this.FrmEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStatusFrmEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNameEmployee;
        private System.Windows.Forms.TextBox txtLoginNameEmployee;
        private System.Windows.Forms.TextBox txtPwdEmployee;
        private System.Windows.Forms.Button btnAddFrmEmployee;
        private System.Windows.Forms.Label lblMerror;
        private System.Windows.Forms.Label lblNameFrmEmployee;
        private System.Windows.Forms.Label lblLoginNameEmployee;
        private System.Windows.Forms.Label lblPwdEmployee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCollephone;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMoneyEmployee;
    }
}