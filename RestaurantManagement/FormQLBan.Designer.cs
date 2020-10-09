namespace RestaurantManagement
{
    partial class FormQLBan
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
            this.btQLMenu = new System.Windows.Forms.Button();
            this.lTitle = new System.Windows.Forms.Label();
            this.btQLBan = new System.Windows.Forms.Button();
            this.btQLNhanvien = new System.Windows.Forms.Button();
            this.btThongke = new System.Windows.Forms.Button();
            this.btSignout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btQLMenu
            // 
            this.btQLMenu.Location = new System.Drawing.Point(11, 179);
            this.btQLMenu.Name = "btQLMenu";
            this.btQLMenu.Size = new System.Drawing.Size(109, 55);
            this.btQLMenu.TabIndex = 0;
            this.btQLMenu.Text = "Quản lý Menu";
            this.btQLMenu.UseVisualStyleBackColor = true;
            // 
            // lTitle
            // 
            this.lTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Segoe Print", 25F);
            this.lTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lTitle.Location = new System.Drawing.Point(109, 20);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(562, 74);
            this.lTitle.TabIndex = 1;
            this.lTitle.Text = "Restaurant Management";
            // 
            // btQLBan
            // 
            this.btQLBan.Location = new System.Drawing.Point(10, 118);
            this.btQLBan.Name = "btQLBan";
            this.btQLBan.Size = new System.Drawing.Size(110, 55);
            this.btQLBan.TabIndex = 2;
            this.btQLBan.Text = "Quản lý bàn";
            this.btQLBan.UseVisualStyleBackColor = true;
            // 
            // btQLNhanvien
            // 
            this.btQLNhanvien.Location = new System.Drawing.Point(12, 240);
            this.btQLNhanvien.Name = "btQLNhanvien";
            this.btQLNhanvien.Size = new System.Drawing.Size(109, 55);
            this.btQLNhanvien.TabIndex = 3;
            this.btQLNhanvien.Text = "Quản lý nhân viên";
            this.btQLNhanvien.UseVisualStyleBackColor = true;
            // 
            // btThongke
            // 
            this.btThongke.Location = new System.Drawing.Point(12, 301);
            this.btThongke.Name = "btThongke";
            this.btThongke.Size = new System.Drawing.Size(109, 55);
            this.btThongke.TabIndex = 4;
            this.btThongke.Text = "Thống kê doanh thu";
            this.btThongke.UseVisualStyleBackColor = true;
            // 
            // btSignout
            // 
            this.btSignout.Location = new System.Drawing.Point(12, 362);
            this.btSignout.Name = "btSignout";
            this.btSignout.Size = new System.Drawing.Size(109, 55);
            this.btSignout.TabIndex = 5;
            this.btSignout.Text = "Đăng xuất";
            this.btSignout.UseVisualStyleBackColor = true;
            this.btSignout.Click += new System.EventHandler(this.btSignout_Click);
            // 
            // FormQLBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSignout);
            this.Controls.Add(this.btThongke);
            this.Controls.Add(this.btQLNhanvien);
            this.Controls.Add(this.btQLBan);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.btQLMenu);
            this.Name = "FormQLBan";
            this.Text = "Quản lý bàn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btQLMenu;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Button btQLBan;
        private System.Windows.Forms.Button btQLNhanvien;
        private System.Windows.Forms.Button btThongke;
        private System.Windows.Forms.Button btSignout;
    }
}

