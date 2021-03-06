﻿namespace RestaurantManagement
{
    partial class LoginMasterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginMasterForm));
            this.tbPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.lbGuild = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.btSignup = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tbUsername = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btLogin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pnInfor = new System.Windows.Forms.Panel();
            this.pnTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.pnInfor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(149, 181);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '●';
            this.tbPassword.Size = new System.Drawing.Size(374, 41);
            this.tbPassword.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbPassword.StateCommon.Border.Rounding = 9;
            this.tbPassword.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.DarkCyan;
            this.pnTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTitle.Controls.Add(this.lbGuild);
            this.pnTitle.Controls.Add(this.pbImage);
            this.pnTitle.Controls.Add(this.lbTitle);
            this.pnTitle.Location = new System.Drawing.Point(12, 12);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(658, 137);
            this.pnTitle.TabIndex = 8;
            // 
            // lbGuild
            // 
            this.lbGuild.AutoSize = true;
            this.lbGuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbGuild.ForeColor = System.Drawing.Color.Transparent;
            this.lbGuild.Location = new System.Drawing.Point(98, 111);
            this.lbGuild.Name = "lbGuild";
            this.lbGuild.Size = new System.Drawing.Size(479, 18);
            this.lbGuild.TabIndex = 2;
            this.lbGuild.Text = "Vui lòng đăng nhập tài khoản nhà hàng trong lần đầu sử dụng phần mềm";
            // 
            // pbImage
            // 
            this.pbImage.Image = ((System.Drawing.Image)(resources.GetObject("pbImage.Image")));
            this.pbImage.Location = new System.Drawing.Point(102, -1);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(111, 122);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 1;
            this.pbImage.TabStop = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Transparent;
            this.lbTitle.Location = new System.Drawing.Point(228, 56);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(252, 44);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "ĐĂNG NHẬP";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Location = new System.Drawing.Point(145, 154);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(88, 18);
            this.lbPass.TabIndex = 6;
            this.lbPass.Text = "MẬT KHẨU:";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(145, 58);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(90, 18);
            this.lbUser.TabIndex = 5;
            this.lbUser.Text = "TÀI KHOẢN:";
            // 
            // btSignup
            // 
            this.btSignup.Location = new System.Drawing.Point(185, 258);
            this.btSignup.Name = "btSignup";
            this.btSignup.Size = new System.Drawing.Size(143, 48);
            this.btSignup.TabIndex = 3;
            this.btSignup.Values.Text = "ĐĂNG KÝ";
            this.btSignup.Click += new System.EventHandler(this.btSignup_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(149, 85);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(374, 41);
            this.tbUsername.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbUsername.StateCommon.Border.Rounding = 9;
            this.tbUsername.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.TabIndex = 0;
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(350, 258);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(143, 48);
            this.btLogin.TabIndex = 2;
            this.btLogin.Values.Text = "ĐĂNG NHẬP";
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // pnInfor
            // 
            this.pnInfor.Controls.Add(this.lbUser);
            this.pnInfor.Controls.Add(this.btSignup);
            this.pnInfor.Controls.Add(this.tbUsername);
            this.pnInfor.Controls.Add(this.btLogin);
            this.pnInfor.Controls.Add(this.lbPass);
            this.pnInfor.Controls.Add(this.tbPassword);
            this.pnInfor.Location = new System.Drawing.Point(12, 155);
            this.pnInfor.Name = "pnInfor";
            this.pnInfor.Size = new System.Drawing.Size(658, 369);
            this.pnInfor.TabIndex = 9;
            // 
            // LoginMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 553);
            this.Controls.Add(this.pnTitle);
            this.Controls.Add(this.pnInfor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "LoginMasterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập lần đầu";
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.pnInfor.ResumeLayout(false);
            this.pnInfor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbPassword;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbUser;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btSignup;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbUsername;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btLogin;
        private System.Windows.Forms.Panel pnInfor;
        private System.Windows.Forms.Label lbGuild;
    }
}