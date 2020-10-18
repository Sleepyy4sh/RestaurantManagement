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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignup));
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbRepassword = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbRepassword = new System.Windows.Forms.TextBox();
            this.btSignup = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbUsername.Location = new System.Drawing.Point(130, 147);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(146, 36);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "Tài khoản";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbPassword.Location = new System.Drawing.Point(139, 207);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(137, 36);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Mật khẩu";
            // 
            // lbRepassword
            // 
            this.lbRepassword.AutoSize = true;
            this.lbRepassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbRepassword.Location = new System.Drawing.Point(23, 269);
            this.lbRepassword.Name = "lbRepassword";
            this.lbRepassword.Size = new System.Drawing.Size(253, 36);
            this.lbRepassword.TabIndex = 2;
            this.lbRepassword.Text = "Nhập lại mật khẩu";
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.tbUsername.Location = new System.Drawing.Point(310, 142);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(377, 41);
            this.tbUsername.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.tbPassword.Location = new System.Drawing.Point(310, 202);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(377, 41);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbRepassword
            // 
            this.tbRepassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.tbRepassword.Location = new System.Drawing.Point(310, 264);
            this.tbRepassword.Name = "tbRepassword";
            this.tbRepassword.Size = new System.Drawing.Size(377, 41);
            this.tbRepassword.TabIndex = 5;
            this.tbRepassword.UseSystemPasswordChar = true;
            // 
            // btSignup
            // 
            this.btSignup.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btSignup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btSignup.Location = new System.Drawing.Point(555, 330);
            this.btSignup.Name = "btSignup";
            this.btSignup.Size = new System.Drawing.Size(132, 59);
            this.btSignup.TabIndex = 6;
            this.btSignup.Text = "Đăng ký";
            this.btSignup.UseVisualStyleBackColor = false;
            this.btSignup.Click += new System.EventHandler(this.btSignup_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btExit.Location = new System.Drawing.Point(417, 330);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(132, 59);
            this.btExit.TabIndex = 7;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbUsername);
            this.panel1.Controls.Add(this.btSignup);
            this.panel1.Controls.Add(this.btExit);
            this.panel1.Controls.Add(this.tbPassword);
            this.panel1.Controls.Add(this.tbRepassword);
            this.panel1.Controls.Add(this.lbRepassword);
            this.panel1.Controls.Add(this.lbUsername);
            this.panel1.Controls.Add(this.lbPassword);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 63);
            this.label1.TabIndex = 8;
            this.label1.Text = "Đăng ký";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FormSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormSignup";
            this.Text = "Đăng ký tài khoản";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSignup_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}