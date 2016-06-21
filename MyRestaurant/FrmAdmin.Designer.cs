namespace MyRestaurant
{
    partial class FrmAdmin
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
            this.dgvAdminInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdminInfo
            // 
            this.dgvAdminInfo.AllowUserToAddRows = false;
            this.dgvAdminInfo.AllowUserToDeleteRows = false;
            this.dgvAdminInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminInfo.Location = new System.Drawing.Point(44, 51);
            this.dgvAdminInfo.Name = "dgvAdminInfo";
            this.dgvAdminInfo.ReadOnly = true;
            this.dgvAdminInfo.RowTemplate.Height = 23;
            this.dgvAdminInfo.Size = new System.Drawing.Size(578, 150);
            this.dgvAdminInfo.TabIndex = 0;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 285);
            this.Controls.Add(this.dgvAdminInfo);
            this.Name = "FrmAdmin";
            this.Text = "FrmAdmin";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdminInfo;
    }
}