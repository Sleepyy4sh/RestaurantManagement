namespace RestaurantManagement
{
    partial class FormQLMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLMenu));
            this.bAddFood = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.lbDelete = new System.Windows.Forms.Label();
            this.btQLMenu = new System.Windows.Forms.Button();
            this.lTitle = new System.Windows.Forms.Label();
            this.btQLBan = new System.Windows.Forms.Button();
            this.btSignout = new System.Windows.Forms.Button();
            this.btQLNhanvien = new System.Windows.Forms.Button();
            this.btThongke = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAddFood
            // 
            this.bAddFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bAddFood.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddFood.Location = new System.Drawing.Point(984, 528);
            this.bAddFood.Name = "bAddFood";
            this.bAddFood.Size = new System.Drawing.Size(151, 55);
            this.bAddFood.TabIndex = 3;
            this.bAddFood.Text = "Thêm món";
            this.bAddFood.UseVisualStyleBackColor = false;
            this.bAddFood.Click += new System.EventHandler(this.bAddFood_Click);
            // 
            // bDelete
            // 
            this.bDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDelete.Location = new System.Drawing.Point(984, 589);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(151, 53);
            this.bDelete.TabIndex = 2;
            this.bDelete.Text = "Xóa";
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // lbDelete
            // 
            this.lbDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDelete.AutoSize = true;
            this.lbDelete.BackColor = System.Drawing.Color.Gold;
            this.lbDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDelete.Location = new System.Drawing.Point(463, 94);
            this.lbDelete.Name = "lbDelete";
            this.lbDelete.Size = new System.Drawing.Size(365, 31);
            this.lbDelete.TabIndex = 3;
            this.lbDelete.Text = "Nhấn đúp vào món ăn để xóa";
            // 
            // btQLMenu
            // 
            this.btQLMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btQLMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btQLMenu.Location = new System.Drawing.Point(13, 120);
            this.btQLMenu.Name = "btQLMenu";
            this.btQLMenu.Size = new System.Drawing.Size(156, 66);
            this.btQLMenu.TabIndex = 1;
            this.btQLMenu.Text = "Quản lý Menu";
            this.btQLMenu.UseVisualStyleBackColor = false;
            // 
            // lTitle
            // 
            this.lTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lTitle.Location = new System.Drawing.Point(485, 48);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(280, 46);
            this.lTitle.TabIndex = 9;
            this.lTitle.Text = "Quản Lý Menu";
            // 
            // btQLBan
            // 
            this.btQLBan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btQLBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btQLBan.Location = new System.Drawing.Point(13, 27);
            this.btQLBan.Name = "btQLBan";
            this.btQLBan.Size = new System.Drawing.Size(156, 66);
            this.btQLBan.TabIndex = 2;
            this.btQLBan.Text = "Quản lý bàn";
            this.btQLBan.UseVisualStyleBackColor = false;
            this.btQLBan.Click += new System.EventHandler(this.btQLBan_Click);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btQLBan);
            this.panel1.Controls.Add(this.btSignout);
            this.panel1.Controls.Add(this.btQLMenu);
            this.panel1.Controls.Add(this.btQLNhanvien);
            this.panel1.Controls.Add(this.btThongke);
            this.panel1.Location = new System.Drawing.Point(12, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 495);
            this.panel1.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(210, 147);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(774, 512);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // FormQLMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(1138, 652);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.bAddFood);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.lbDelete);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormQLMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bAddFood;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Label lbDelete;
        private System.Windows.Forms.Button btQLMenu;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Button btQLBan;
        private System.Windows.Forms.Button btSignout;
        private System.Windows.Forms.Button btQLNhanvien;
        private System.Windows.Forms.Button btThongke;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}