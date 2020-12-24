namespace RestaurantManagement
{
    partial class SignupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            this.lbTitle = new System.Windows.Forms.Label();
            this.btSignup = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tbUsername = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pnInfor = new System.Windows.Forms.Panel();
            this.ckboxType = new System.Windows.Forms.CheckBox();
            this.lbSEmail = new System.Windows.Forms.Label();
            this.lbSICnumber = new System.Windows.Forms.Label();
            this.lbSDoB = new System.Windows.Forms.Label();
            this.lbSAddress = new System.Windows.Forms.Label();
            this.lbSPnumber = new System.Windows.Forms.Label();
            this.lbSFname = new System.Windows.Forms.Label();
            this.tbSPnumber = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbSFname = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbRePass = new System.Windows.Forms.Label();
            this.tbRepassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.btExit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbPass = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.tbSDoB = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbSEmail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbSAddress = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbSICnumber = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonContextMenu1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenu();
            this.pnInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.pnTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.2F, System.Drawing.FontStyle.Bold);
            this.lbTitle.ForeColor = System.Drawing.Color.Transparent;
            this.lbTitle.Location = new System.Drawing.Point(294, 58);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(276, 63);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "ĐĂNG KÝ";
            // 
            // btSignup
            // 
            this.btSignup.Location = new System.Drawing.Point(374, 597);
            this.btSignup.Name = "btSignup";
            this.btSignup.Size = new System.Drawing.Size(143, 48);
            this.btSignup.TabIndex = 3;
            this.btSignup.Values.Text = "ĐĂNG KÝ";
            this.btSignup.Click += new System.EventHandler(this.btSignup_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(227, 378);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(374, 47);
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
            this.tbPassword.Location = new System.Drawing.Point(227, 455);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '●';
            this.tbPassword.Size = new System.Drawing.Size(374, 47);
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
            this.pnInfor.Controls.Add(this.tbSICnumber);
            this.pnInfor.Controls.Add(this.tbSAddress);
            this.pnInfor.Controls.Add(this.tbSEmail);
            this.pnInfor.Controls.Add(this.tbSDoB);
            this.pnInfor.Controls.Add(this.ckboxType);
            this.pnInfor.Controls.Add(this.lbSEmail);
            this.pnInfor.Controls.Add(this.lbSICnumber);
            this.pnInfor.Controls.Add(this.lbSDoB);
            this.pnInfor.Controls.Add(this.lbSAddress);
            this.pnInfor.Controls.Add(this.lbSPnumber);
            this.pnInfor.Controls.Add(this.lbSFname);
            this.pnInfor.Controls.Add(this.tbSPnumber);
            this.pnInfor.Controls.Add(this.tbSFname);
            this.pnInfor.Controls.Add(this.lbRePass);
            this.pnInfor.Controls.Add(this.tbRepassword);
            this.pnInfor.Controls.Add(this.lbUser);
            this.pnInfor.Controls.Add(this.btSignup);
            this.pnInfor.Controls.Add(this.tbUsername);
            this.pnInfor.Controls.Add(this.btExit);
            this.pnInfor.Controls.Add(this.lbPass);
            this.pnInfor.Controls.Add(this.tbPassword);
            this.pnInfor.Location = new System.Drawing.Point(12, 139);
            this.pnInfor.Name = "pnInfor";
            this.pnInfor.Size = new System.Drawing.Size(713, 648);
            this.pnInfor.TabIndex = 9;
            // 
            // ckboxType
            // 
            this.ckboxType.AutoSize = true;
            this.ckboxType.Checked = true;
            this.ckboxType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckboxType.Location = new System.Drawing.Point(97, 591);
            this.ckboxType.Name = "ckboxType";
            this.ckboxType.Size = new System.Drawing.Size(303, 40);
            this.ckboxType.TabIndex = 21;
            this.ckboxType.Text = "Không tạo tài khoản";
            this.ckboxType.UseVisualStyleBackColor = true;
            // 
            // lbSEmail
            // 
            this.lbSEmail.AutoSize = true;
            this.lbSEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSEmail.Location = new System.Drawing.Point(49, 305);
            this.lbSEmail.Name = "lbSEmail";
            this.lbSEmail.Size = new System.Drawing.Size(66, 24);
            this.lbSEmail.TabIndex = 20;
            this.lbSEmail.Text = "EMAIL";
            // 
            // lbSICnumber
            // 
            this.lbSICnumber.AutoSize = true;
            this.lbSICnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSICnumber.Location = new System.Drawing.Point(49, 250);
            this.lbSICnumber.Name = "lbSICnumber";
            this.lbSICnumber.Size = new System.Drawing.Size(123, 24);
            this.lbSICnumber.TabIndex = 19;
            this.lbSICnumber.Text = "CMND/CCCD";
            // 
            // lbSDoB
            // 
            this.lbSDoB.AutoSize = true;
            this.lbSDoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDoB.Location = new System.Drawing.Point(63, 164);
            this.lbSDoB.Name = "lbSDoB";
            this.lbSDoB.Size = new System.Drawing.Size(112, 24);
            this.lbSDoB.TabIndex = 18;
            this.lbSDoB.Text = "NGÀY SINH";
            // 
            // lbSAddress
            // 
            this.lbSAddress.AutoSize = true;
            this.lbSAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSAddress.Location = new System.Drawing.Point(63, 121);
            this.lbSAddress.Name = "lbSAddress";
            this.lbSAddress.Size = new System.Drawing.Size(76, 24);
            this.lbSAddress.TabIndex = 17;
            this.lbSAddress.Text = "ĐỊA CHỈ";
            // 
            // lbSPnumber
            // 
            this.lbSPnumber.AutoSize = true;
            this.lbSPnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSPnumber.Location = new System.Drawing.Point(35, 68);
            this.lbSPnumber.Name = "lbSPnumber";
            this.lbSPnumber.Size = new System.Drawing.Size(149, 24);
            this.lbSPnumber.TabIndex = 16;
            this.lbSPnumber.Text = "SỐ ĐIỆN THOẠI";
            // 
            // lbSFname
            // 
            this.lbSFname.AutoSize = true;
            this.lbSFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSFname.Location = new System.Drawing.Point(49, 13);
            this.lbSFname.Name = "lbSFname";
            this.lbSFname.Size = new System.Drawing.Size(114, 24);
            this.lbSFname.TabIndex = 15;
            this.lbSFname.Text = "HỌ VÀ TÊN";
            // 
            // tbSPnumber
            // 
            this.tbSPnumber.Location = new System.Drawing.Point(227, 58);
            this.tbSPnumber.Name = "tbSPnumber";
            this.tbSPnumber.Size = new System.Drawing.Size(374, 47);
            this.tbSPnumber.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSPnumber.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbSPnumber.StateCommon.Border.Rounding = 9;
            this.tbSPnumber.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSPnumber.TabIndex = 10;
            // 
            // tbSFname
            // 
            this.tbSFname.Location = new System.Drawing.Point(227, 11);
            this.tbSFname.Name = "tbSFname";
            this.tbSFname.Size = new System.Drawing.Size(374, 47);
            this.tbSFname.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSFname.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbSFname.StateCommon.Border.Rounding = 9;
            this.tbSFname.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSFname.TabIndex = 9;
            // 
            // lbRePass
            // 
            this.lbRePass.AutoSize = true;
            this.lbRePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRePass.Location = new System.Drawing.Point(3, 544);
            this.lbRePass.Name = "lbRePass";
            this.lbRePass.Size = new System.Drawing.Size(203, 24);
            this.lbRePass.TabIndex = 8;
            this.lbRePass.Text = "NHẬP LẠI MẬT KHẨU:";
            // 
            // tbRepassword
            // 
            this.tbRepassword.Location = new System.Drawing.Point(227, 521);
            this.tbRepassword.Name = "tbRepassword";
            this.tbRepassword.PasswordChar = '●';
            this.tbRepassword.Size = new System.Drawing.Size(374, 47);
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
            this.lbUser.Location = new System.Drawing.Point(22, 401);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(117, 24);
            this.lbUser.TabIndex = 5;
            this.lbUser.Text = "TÀI KHOẢN:";
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(179, 597);
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
            this.lbPass.Location = new System.Drawing.Point(35, 455);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(113, 24);
            this.lbPass.TabIndex = 6;
            this.lbPass.Text = "MẬT KHẨU:";
            // 
            // pbImage
            // 
            this.pbImage.Image = ((System.Drawing.Image)(resources.GetObject("pbImage.Image")));
            this.pbImage.Location = new System.Drawing.Point(119, 7);
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
            this.pnTitle.Location = new System.Drawing.Point(12, -4);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(713, 137);
            this.pnTitle.TabIndex = 8;
            // 
            // tbSDoB
            // 
            this.tbSDoB.Location = new System.Drawing.Point(227, 164);
            this.tbSDoB.Name = "tbSDoB";
            this.tbSDoB.Size = new System.Drawing.Size(374, 47);
            this.tbSDoB.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSDoB.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbSDoB.StateCommon.Border.Rounding = 9;
            this.tbSDoB.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSDoB.TabIndex = 23;
            // 
            // tbSEmail
            // 
            this.tbSEmail.Location = new System.Drawing.Point(227, 282);
            this.tbSEmail.Name = "tbSEmail";
            this.tbSEmail.Size = new System.Drawing.Size(374, 47);
            this.tbSEmail.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSEmail.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbSEmail.StateCommon.Border.Rounding = 9;
            this.tbSEmail.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSEmail.TabIndex = 25;
            // 
            // tbSAddress
            // 
            this.tbSAddress.Location = new System.Drawing.Point(227, 111);
            this.tbSAddress.Name = "tbSAddress";
            this.tbSAddress.Size = new System.Drawing.Size(374, 47);
            this.tbSAddress.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSAddress.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbSAddress.StateCommon.Border.Rounding = 9;
            this.tbSAddress.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSAddress.TabIndex = 29;
            // 
            // tbSICnumber
            // 
            this.tbSICnumber.Location = new System.Drawing.Point(227, 229);
            this.tbSICnumber.Name = "tbSICnumber";
            this.tbSICnumber.Size = new System.Drawing.Size(374, 47);
            this.tbSICnumber.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSICnumber.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbSICnumber.StateCommon.Border.Rounding = 9;
            this.tbSICnumber.TabIndex = 30;
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 749);
            this.Controls.Add(this.pnInfor);
            this.Controls.Add(this.pnTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "SignupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký";
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
        private System.Windows.Forms.Label lbUser;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btExit;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Panel pnTitle;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbRepassword;
        private System.Windows.Forms.Label lbRePass;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbSFname;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbSPnumber;
        private System.Windows.Forms.Label lbSEmail;
        private System.Windows.Forms.Label lbSICnumber;
        private System.Windows.Forms.Label lbSDoB;
        private System.Windows.Forms.Label lbSAddress;
        private System.Windows.Forms.Label lbSPnumber;
        private System.Windows.Forms.Label lbSFname;
        private System.Windows.Forms.CheckBox ckboxType;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbSEmail;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbSDoB;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbSAddress;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbSICnumber;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
    }
}