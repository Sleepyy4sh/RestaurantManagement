namespace RestaurantManagement
{
    partial class FormChangePass
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
            this.tbCurPass = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbNewPass = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbRePassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btChangePass = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbCurPass = new System.Windows.Forms.Label();
            this.lbNewPass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btExit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // tbCurPass
            // 
            this.tbCurPass.Location = new System.Drawing.Point(190, 105);
            this.tbCurPass.Name = "tbCurPass";
            this.tbCurPass.PasswordChar = '●';
            this.tbCurPass.Size = new System.Drawing.Size(408, 47);
            this.tbCurPass.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurPass.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbCurPass.StateCommon.Border.Rounding = 9;
            this.tbCurPass.TabIndex = 0;
            this.tbCurPass.UseSystemPasswordChar = true;
            // 
            // tbNewPass
            // 
            this.tbNewPass.Location = new System.Drawing.Point(190, 213);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.PasswordChar = '●';
            this.tbNewPass.Size = new System.Drawing.Size(408, 47);
            this.tbNewPass.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewPass.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbNewPass.StateCommon.Border.Rounding = 9;
            this.tbNewPass.TabIndex = 1;
            this.tbNewPass.UseSystemPasswordChar = true;
            // 
            // tbRePassword
            // 
            this.tbRePassword.Location = new System.Drawing.Point(190, 324);
            this.tbRePassword.Name = "tbRePassword";
            this.tbRePassword.PasswordChar = '●';
            this.tbRePassword.Size = new System.Drawing.Size(408, 47);
            this.tbRePassword.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRePassword.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbRePassword.StateCommon.Border.Rounding = 9;
            this.tbRePassword.TabIndex = 2;
            this.tbRePassword.UseSystemPasswordChar = true;
            // 
            // btChangePass
            // 
            this.btChangePass.Location = new System.Drawing.Point(299, 394);
            this.btChangePass.Name = "btChangePass";
            this.btChangePass.Size = new System.Drawing.Size(156, 56);
            this.btChangePass.TabIndex = 3;
            this.btChangePass.Values.Text = "Đổi mật khẩu";
            this.btChangePass.Click += new System.EventHandler(this.btChangePass_Click);
            // 
            // lbCurPass
            // 
            this.lbCurPass.AutoSize = true;
            this.lbCurPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbCurPass.Location = new System.Drawing.Point(185, 73);
            this.lbCurPass.Name = "lbCurPass";
            this.lbCurPass.Size = new System.Drawing.Size(198, 29);
            this.lbCurPass.TabIndex = 4;
            this.lbCurPass.Text = "Mật khẩu hiện tại:";
            // 
            // lbNewPass
            // 
            this.lbNewPass.AutoSize = true;
            this.lbNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbNewPass.Location = new System.Drawing.Point(185, 181);
            this.lbNewPass.Name = "lbNewPass";
            this.lbNewPass.Size = new System.Drawing.Size(161, 29);
            this.lbNewPass.TabIndex = 5;
            this.lbNewPass.Text = "Mật khẩu mới:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(185, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập lại mật khẩu mới:";
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(597, 489);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(130, 46);
            this.btExit.TabIndex = 7;
            this.btExit.Values.Text = "Thoát";
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // FormChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(750, 548);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNewPass);
            this.Controls.Add(this.lbCurPass);
            this.Controls.Add(this.btChangePass);
            this.Controls.Add(this.tbRePassword);
            this.Controls.Add(this.tbNewPass);
            this.Controls.Add(this.tbCurPass);
            this.Name = "FormChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbCurPass;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbNewPass;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbRePassword;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btChangePass;
        private System.Windows.Forms.Label lbCurPass;
        private System.Windows.Forms.Label lbNewPass;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btExit;
    }
}