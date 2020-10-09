namespace RestaurantManagement
{
    partial class FormSignup
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
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbRepassword = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbRepassword = new System.Windows.Forms.TextBox();
            this.btSignup = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbUsername.Location = new System.Drawing.Point(163, 92);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(146, 36);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "Tài khoản";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbPassword.Location = new System.Drawing.Point(172, 160);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(137, 36);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Mật khẩu";
            // 
            // lbRepassword
            // 
            this.lbRepassword.AutoSize = true;
            this.lbRepassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbRepassword.Location = new System.Drawing.Point(56, 229);
            this.lbRepassword.Name = "lbRepassword";
            this.lbRepassword.Size = new System.Drawing.Size(253, 36);
            this.lbRepassword.TabIndex = 2;
            this.lbRepassword.Text = "Nhập lại mật khẩu";
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.tbUsername.Location = new System.Drawing.Point(342, 87);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(377, 41);
            this.tbUsername.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.tbPassword.Location = new System.Drawing.Point(342, 155);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(377, 41);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbRepassword
            // 
            this.tbRepassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.tbRepassword.Location = new System.Drawing.Point(342, 224);
            this.tbRepassword.Name = "tbRepassword";
            this.tbRepassword.Size = new System.Drawing.Size(377, 41);
            this.tbRepassword.TabIndex = 5;
            this.tbRepassword.UseSystemPasswordChar = true;
            // 
            // btSignup
            // 
            this.btSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btSignup.Location = new System.Drawing.Point(576, 286);
            this.btSignup.Name = "btSignup";
            this.btSignup.Size = new System.Drawing.Size(132, 59);
            this.btSignup.TabIndex = 6;
            this.btSignup.Text = "Đăng ký";
            this.btSignup.UseVisualStyleBackColor = true;
            this.btSignup.Click += new System.EventHandler(this.btSignup_Click);
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btExit.Location = new System.Drawing.Point(438, 286);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(132, 59);
            this.btExit.TabIndex = 7;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // FormSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btSignup);
            this.Controls.Add(this.tbRepassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lbRepassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Name = "FormSignup";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbRepassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbRepassword;
        private System.Windows.Forms.Button btSignup;
        private System.Windows.Forms.Button btExit;
    }
}