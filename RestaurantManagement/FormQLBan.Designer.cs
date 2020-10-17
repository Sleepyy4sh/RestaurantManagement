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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLBan));
            this.btQLMenu = new System.Windows.Forms.Button();
            this.lTitle = new System.Windows.Forms.Label();
            this.btQLBan = new System.Windows.Forms.Button();
            this.btQLNhanvien = new System.Windows.Forms.Button();
            this.btThongke = new System.Windows.Forms.Button();
            this.btSignout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btQLMenu
            // 
            this.btQLMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btQLMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btQLMenu.Location = new System.Drawing.Point(13, 120);
            this.btQLMenu.Name = "btQLMenu";
            this.btQLMenu.Size = new System.Drawing.Size(156, 66);
            this.btQLMenu.TabIndex = 0;
            this.btQLMenu.Text = "Quản lý Menu";
            this.btQLMenu.UseVisualStyleBackColor = false;
            // 
            // lTitle
            // 
            this.lTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lTitle.Location = new System.Drawing.Point(485, 47);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(316, 58);
            this.lTitle.TabIndex = 1;
            this.lTitle.Text = "Quản Lý Bàn";
            // 
            // btQLBan
            // 
            this.btQLBan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btQLBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btQLBan.Location = new System.Drawing.Point(13, 27);
            this.btQLBan.Name = "btQLBan";
            this.btQLBan.Size = new System.Drawing.Size(156, 66);
            this.btQLBan.TabIndex = 2;
            this.btQLBan.Text = "Quản lý bàn";
            this.btQLBan.UseVisualStyleBackColor = false;
            // 
            // btQLNhanvien
            // 
            this.btQLNhanvien.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btQLNhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btQLNhanvien.Location = new System.Drawing.Point(13, 221);
            this.btQLNhanvien.Name = "btQLNhanvien";
            this.btQLNhanvien.Size = new System.Drawing.Size(156, 66);
            this.btQLNhanvien.TabIndex = 3;
            this.btQLNhanvien.Text = "Quản lý nhân viên";
            this.btQLNhanvien.UseVisualStyleBackColor = false;
            // 
            // btThongke
            // 
            this.btThongke.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btThongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btThongke.Location = new System.Drawing.Point(13, 311);
            this.btThongke.Name = "btThongke";
            this.btThongke.Size = new System.Drawing.Size(156, 66);
            this.btThongke.TabIndex = 4;
            this.btThongke.Text = "Thống kê doanh thu";
            this.btThongke.UseVisualStyleBackColor = false;
            // 
            // btSignout
            // 
            this.btSignout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSignout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btSignout.Location = new System.Drawing.Point(13, 403);
            this.btSignout.Name = "btSignout";
            this.btSignout.Size = new System.Drawing.Size(156, 66);
            this.btSignout.TabIndex = 5;
            this.btSignout.Text = "Đăng xuất";
            this.btSignout.UseVisualStyleBackColor = false;
            this.btSignout.Click += new System.EventHandler(this.btSignout_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btQLBan);
            this.panel1.Controls.Add(this.btSignout);
            this.panel1.Controls.Add(this.btQLMenu);
            this.panel1.Controls.Add(this.btQLNhanvien);
            this.panel1.Controls.Add(this.btThongke);
            this.panel1.Location = new System.Drawing.Point(12, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 495);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(210, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 495);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FormQLBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(1138, 652);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Name = "FormQLBan";
            this.Text = "Quản lý bàn";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

