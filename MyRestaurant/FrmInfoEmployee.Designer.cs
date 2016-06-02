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
            this.ltvInfoEmployee = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ltvInfoEmployee
            // 
            this.ltvInfoEmployee.Location = new System.Drawing.Point(-1, 12);
            this.ltvInfoEmployee.Name = "ltvInfoEmployee";
            this.ltvInfoEmployee.Size = new System.Drawing.Size(417, 326);
            this.ltvInfoEmployee.TabIndex = 0;
            this.ltvInfoEmployee.UseCompatibleStateImageBehavior = false;
            // 
            // FrmInfoEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 403);
            this.Controls.Add(this.ltvInfoEmployee);
            this.Name = "FrmInfoEmployee";
            this.Text = "FrmInfoEmployee";
            this.Load += new System.EventHandler(this.FrmInfoEmployee_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ltvInfoEmployee;
    }
}