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
            this.lbRePass = new System.Windows.Forms.Label();
            this.btExit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // tbCurPass
            // 
            this.tbCurPass.Location = new System.Drawing.Point(142, 85);
            this.tbCurPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCurPass.Name = "tbCurPass";
            this.tbCurPass.PasswordChar = '●';
            this.tbCurPass.Size = new System.Drawing.Size(306, 41);
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
            this.tbNewPass.Location = new System.Drawing.Point(142, 173);
            this.tbNewPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.PasswordChar = '●';
            this.tbNewPass.Size = new System.Drawing.Size(306, 41);
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
            this.tbRePassword.Location = new System.Drawing.Point(142, 263);
            this.tbRePassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbRePassword.Name = "tbRePassword";
            this.tbRePassword.PasswordChar = '●';
            this.tbRePassword.Size = new System.Drawing.Size(306, 41);
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
            this.btChangePass.Location = new System.Drawing.Point(224, 320);
            this.btChangePass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btChangePass.Name = "btChangePass";
            this.btChangePass.Size = new System.Drawing.Size(117, 46);
            this.btChangePass.TabIndex = 3;
            this.btChangePass.Values.Text = "Đổi mật khẩu";
            this.btChangePass.Click += new System.EventHandler(this.btChangePass_Click);
            // 
            // lbCurPass
            // 
            this.lbCurPass.AutoSize = true;
            this.lbCurPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbCurPass.Location = new System.Drawing.Point(139, 59);
            this.lbCurPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCurPass.Name = "lbCurPass";
            this.lbCurPass.Size = new System.Drawing.Size(156, 24);
            this.lbCurPass.TabIndex = 4;
            this.lbCurPass.Text = "Mật khẩu hiện tại:";
            // 
            // lbNewPass
            // 
            this.lbNewPass.AutoSize = true;
            this.lbNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbNewPass.Location = new System.Drawing.Point(139, 147);
            this.lbNewPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNewPass.Name = "lbNewPass";
            this.lbNewPass.Size = new System.Drawing.Size(127, 24);
            this.lbNewPass.TabIndex = 5;
            this.lbNewPass.Text = "Mật khẩu mới:";
            // 
            // lbRePass
            // 
            this.lbRePass.AutoSize = true;
            this.lbRePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbRePass.Location = new System.Drawing.Point(139, 237);
            this.lbRePass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRePass.Name = "lbRePass";
            this.lbRePass.Size = new System.Drawing.Size(201, 24);
            this.lbRePass.TabIndex = 6;
            this.lbRePass.Text = "Nhập lại mật khẩu mới:";
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(448, 397);
            this.btExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(98, 37);
            this.btExit.TabIndex = 7;
            this.btExit.Values.Text = "Thoát";
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // FormChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(562, 445);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.lbRePass);
            this.Controls.Add(this.lbNewPass);
            this.Controls.Add(this.lbCurPass);
            this.Controls.Add(this.btChangePass);
            this.Controls.Add(this.tbRePassword);
            this.Controls.Add(this.tbNewPass);
            this.Controls.Add(this.tbCurPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label lbRePass;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btExit;
    }
}