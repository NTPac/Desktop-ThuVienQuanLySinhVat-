namespace BTCKv2
{
    partial class frmRegister
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
            this.lbUserNane = new System.Windows.Forms.Label();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txbPasswordConfirm = new System.Windows.Forms.TextBox();
            this.lbPasswordConfirm = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUserNane
            // 
            this.lbUserNane.AutoSize = true;
            this.lbUserNane.Location = new System.Drawing.Point(42, 25);
            this.lbUserNane.Name = "lbUserNane";
            this.lbUserNane.Size = new System.Drawing.Size(78, 13);
            this.lbUserNane.TabIndex = 0;
            this.lbUserNane.Text = "TenDangNhap";
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(126, 25);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(156, 20);
            this.txbUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(126, 51);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(156, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(67, 51);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 13);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Mat Khau";
            // 
            // txbPasswordConfirm
            // 
            this.txbPasswordConfirm.Location = new System.Drawing.Point(126, 77);
            this.txbPasswordConfirm.Name = "txbPasswordConfirm";
            this.txbPasswordConfirm.Size = new System.Drawing.Size(156, 20);
            this.txbPasswordConfirm.TabIndex = 5;
            // 
            // lbPasswordConfirm
            // 
            this.lbPasswordConfirm.AutoSize = true;
            this.lbPasswordConfirm.Location = new System.Drawing.Point(21, 77);
            this.lbPasswordConfirm.Name = "lbPasswordConfirm";
            this.lbPasswordConfirm.Size = new System.Drawing.Size(99, 13);
            this.lbPasswordConfirm.TabIndex = 4;
            this.lbPasswordConfirm.Text = "Nhap Lai Mat Khau";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(83, 103);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Tao";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(164, 103);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Huy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 138);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txbPasswordConfirm);
            this.Controls.Add(this.lbPasswordConfirm);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.txbUserName);
            this.Controls.Add(this.lbUserNane);
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUserNane;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txbPasswordConfirm;
        private System.Windows.Forms.Label lbPasswordConfirm;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
    }
}