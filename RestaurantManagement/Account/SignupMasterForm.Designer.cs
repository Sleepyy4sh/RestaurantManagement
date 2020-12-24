namespace RestaurantManagement
{
    partial class SignupMasterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupMasterForm));
            this.lbTitle = new System.Windows.Forms.Label();
            this.btSignup = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tbUsername = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pnInfor = new System.Windows.Forms.Panel();
            this.lbRePass = new System.Windows.Forms.Label();
            this.tbRepassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.btExit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbPass = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.pnInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.pnTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold);
            this.lbTitle.ForeColor = System.Drawing.Color.Transparent;
            this.lbTitle.Location = new System.Drawing.Point(244, 74);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(400, 36);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "ĐĂNG KÝ NHÀ HÀNG MỚI";
            // 
            // btSignup
            // 
            this.btSignup.Location = new System.Drawing.Point(408, 370);
            this.btSignup.Name = "btSignup";
            this.btSignup.Size = new System.Drawing.Size(143, 48);
            this.btSignup.TabIndex = 3;
            this.btSignup.Values.Text = "ĐĂNG KÝ";
            this.btSignup.Click += new System.EventHandler(this.btSignup_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(206, 87);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(385, 41);
            this.tbUsername.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbUsername.StateCommon.Border.Rounding = 9;
            this.tbUsername.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(206, 184);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '●';
            this.tbPassword.Size = new System.Drawing.Size(385, 41);
            this.tbPassword.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbPassword.StateCommon.Border.Rounding = 9;
            this.tbPassword.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // pnInfor
            // 
            this.pnInfor.Controls.Add(this.lbRePass);
            this.pnInfor.Controls.Add(this.tbRepassword);
            this.pnInfor.Controls.Add(this.lbUser);
            this.pnInfor.Controls.Add(this.btSignup);
            this.pnInfor.Controls.Add(this.tbUsername);
            this.pnInfor.Controls.Add(this.btExit);
            this.pnInfor.Controls.Add(this.lbPass);
            this.pnInfor.Controls.Add(this.tbPassword);
            this.pnInfor.Location = new System.Drawing.Point(0, 163);
            this.pnInfor.Name = "pnInfor";
            this.pnInfor.Size = new System.Drawing.Size(769, 449);
            this.pnInfor.TabIndex = 11;
            // 
            // lbRePass
            // 
            this.lbRePass.AutoSize = true;
            this.lbRePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRePass.Location = new System.Drawing.Point(202, 261);
            this.lbRePass.Name = "lbRePass";
            this.lbRePass.Size = new System.Drawing.Size(157, 18);
            this.lbRePass.TabIndex = 8;
            this.lbRePass.Text = "NHẬP LẠI MẬT KHẨU:";
            // 
            // tbRepassword
            // 
            this.tbRepassword.Location = new System.Drawing.Point(206, 288);
            this.tbRepassword.Name = "tbRepassword";
            this.tbRepassword.PasswordChar = '●';
            this.tbRepassword.Size = new System.Drawing.Size(385, 41);
            this.tbRepassword.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRepassword.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbRepassword.StateCommon.Border.Rounding = 9;
            this.tbRepassword.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRepassword.TabIndex = 2;
            this.tbRepassword.UseSystemPasswordChar = true;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(202, 60);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(90, 18);
            this.lbUser.TabIndex = 5;
            this.lbUser.Text = "TÀI KHOẢN:";
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(244, 370);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(143, 48);
            this.btExit.TabIndex = 4;
            this.btExit.Values.Text = "THOÁT";
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Location = new System.Drawing.Point(202, 157);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(88, 18);
            this.lbPass.TabIndex = 6;
            this.lbPass.Text = "MẬT KHẨU:";
            // 
            // pbImage
            // 
            this.pbImage.Image = ((System.Drawing.Image)(resources.GetObject("pbImage.Image")));
            this.pbImage.Location = new System.Drawing.Point(88, 7);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(150, 129);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 1;
            this.pbImage.TabStop = false;
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.DarkCyan;
            this.pnTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTitle.Controls.Add(this.pbImage);
            this.pnTitle.Controls.Add(this.lbTitle);
            this.pnTitle.Location = new System.Drawing.Point(0, 12);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(769, 137);
            this.pnTitle.TabIndex = 10;
            // 
            // SignupMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 614);
            this.Controls.Add(this.pnInfor);
            this.Controls.Add(this.pnTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "SignupMasterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignupMasterForm_FormClosing);
            this.pnInfor.ResumeLayout(false);
            this.pnInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btSignup;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbUsername;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbPassword;
        private System.Windows.Forms.Panel pnInfor;
        private System.Windows.Forms.Label lbRePass;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbRepassword;
        private System.Windows.Forms.Label lbUser;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btExit;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Panel pnTitle;
    }
}