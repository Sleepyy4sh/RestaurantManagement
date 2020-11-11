namespace RestaurantManagement
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.Navigator = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.pageQLBan = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.pageQLMenu = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.btDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btAddFood = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pageQLNV = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.pageThongKe = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.pageTaiKhoan = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.lb1 = new System.Windows.Forms.Label();
            this.cainaykhongdung = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.lbDelete = new System.Windows.Forms.Label();
            this.btMasterSignout = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.Navigator)).BeginInit();
            this.Navigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageQLBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageQLMenu)).BeginInit();
            this.pageQLMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageQLNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageTaiKhoan)).BeginInit();
            this.pageTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cainaykhongdung)).BeginInit();
            this.SuspendLayout();
            // 
            // Navigator
            // 
            this.Navigator.AutoSize = true;
            this.Navigator.Bar.ItemOrientation = ComponentFactory.Krypton.Toolkit.ButtonOrientation.FixedTop;
            this.Navigator.Bar.ItemSizing = ComponentFactory.Krypton.Navigator.BarItemSizing.SameWidth;
            this.Navigator.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None;
            this.Navigator.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.Navigator.Location = new System.Drawing.Point(12, 81);
            this.Navigator.Name = "Navigator";
            this.Navigator.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.pageQLBan,
            this.pageQLMenu,
            this.pageQLNV,
            this.pageThongKe,
            this.pageTaiKhoan});
            this.Navigator.SelectedIndex = 4;
            this.Navigator.Size = new System.Drawing.Size(1223, 543);
            this.Navigator.TabIndex = 0;
            this.Navigator.Text = "Navigator";
            // 
            // pageQLBan
            // 
            this.pageQLBan.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageQLBan.Flags = 65534;
            this.pageQLBan.ImageSmall = ((System.Drawing.Image)(resources.GetObject("pageQLBan.ImageSmall")));
            this.pageQLBan.LastVisibleSet = true;
            this.pageQLBan.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageQLBan.Name = "pageQLBan";
            this.pageQLBan.Size = new System.Drawing.Size(1221, 484);
            this.pageQLBan.Text = " Quản Lý Bàn";
            this.pageQLBan.ToolTipTitle = "Page ToolTip";
            this.pageQLBan.UniqueName = "E2368B99859C40256FBCE8BBB86E65E9";
            // 
            // pageQLMenu
            // 
            this.pageQLMenu.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageQLMenu.Controls.Add(this.btDelete);
            this.pageQLMenu.Controls.Add(this.btAddFood);
            this.pageQLMenu.Controls.Add(this.flowLayoutPanel1);
            this.pageQLMenu.Flags = 65534;
            this.pageQLMenu.ImageSmall = ((System.Drawing.Image)(resources.GetObject("pageQLMenu.ImageSmall")));
            this.pageQLMenu.LastVisibleSet = true;
            this.pageQLMenu.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageQLMenu.Name = "pageQLMenu";
            this.pageQLMenu.Size = new System.Drawing.Size(1221, 484);
            this.pageQLMenu.Text = "Quản Lý Menu";
            this.pageQLMenu.ToolTipTitle = "Page ToolTip";
            this.pageQLMenu.UniqueName = "D18C1773B43348FFCBAEE6F5BA9BEFC7";
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(1063, 397);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(135, 51);
            this.btDelete.TabIndex = 2;
            this.btDelete.Values.Image = ((System.Drawing.Image)(resources.GetObject("btDelete.Values.Image")));
            this.btDelete.Values.Text = " Xóa món";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAddFood
            // 
            this.btAddFood.Location = new System.Drawing.Point(1063, 324);
            this.btAddFood.Name = "btAddFood";
            this.btAddFood.Size = new System.Drawing.Size(135, 55);
            this.btAddFood.TabIndex = 1;
            this.btAddFood.Values.Image = ((System.Drawing.Image)(resources.GetObject("btAddFood.Values.Image")));
            this.btAddFood.Values.Text = "Thêm món";
            this.btAddFood.Click += new System.EventHandler(this.btAddFood_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1031, 443);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pageQLNV
            // 
            this.pageQLNV.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageQLNV.Flags = 65534;
            this.pageQLNV.ImageSmall = ((System.Drawing.Image)(resources.GetObject("pageQLNV.ImageSmall")));
            this.pageQLNV.LastVisibleSet = true;
            this.pageQLNV.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageQLNV.Name = "pageQLNV";
            this.pageQLNV.Size = new System.Drawing.Size(1221, 484);
            this.pageQLNV.Text = "Quản Lý Nhân Viên";
            this.pageQLNV.ToolTipTitle = "Page ToolTip";
            this.pageQLNV.UniqueName = "CCD8607AF223457A388AA6AB594772DA";
            // 
            // pageThongKe
            // 
            this.pageThongKe.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageThongKe.Flags = 65534;
            this.pageThongKe.ImageSmall = ((System.Drawing.Image)(resources.GetObject("pageThongKe.ImageSmall")));
            this.pageThongKe.LastVisibleSet = true;
            this.pageThongKe.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageThongKe.Name = "pageThongKe";
            this.pageThongKe.Size = new System.Drawing.Size(1221, 484);
            this.pageThongKe.Text = "Thống Kê Doanh Thu";
            this.pageThongKe.ToolTipTitle = "Page ToolTip";
            this.pageThongKe.UniqueName = "CC90403B1D8642C7A2909E6A147096A4";
            // 
            // pageTaiKhoan
            // 
            this.pageTaiKhoan.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageTaiKhoan.Controls.Add(this.btMasterSignout);
            this.pageTaiKhoan.Flags = 65534;
            this.pageTaiKhoan.ImageSmall = ((System.Drawing.Image)(resources.GetObject("pageTaiKhoan.ImageSmall")));
            this.pageTaiKhoan.LastVisibleSet = true;
            this.pageTaiKhoan.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageTaiKhoan.Name = "pageTaiKhoan";
            this.pageTaiKhoan.Size = new System.Drawing.Size(1221, 484);
            this.pageTaiKhoan.Text = "Tải Khoản";
            this.pageTaiKhoan.ToolTipTitle = "Page ToolTip";
            this.pageTaiKhoan.UniqueName = "72EE1F9F8D394B17F5BE0583764C6EB4";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(526, 26);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(117, 39);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Banner";
            // 
            // cainaykhongdung
            // 
            this.cainaykhongdung.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.cainaykhongdung.Flags = 65534;
            this.cainaykhongdung.LastVisibleSet = true;
            this.cainaykhongdung.MinimumSize = new System.Drawing.Size(50, 50);
            this.cainaykhongdung.Name = "cainaykhongdung";
            this.cainaykhongdung.Size = new System.Drawing.Size(100, 50);
            this.cainaykhongdung.StateCommon.Page.Color1 = System.Drawing.Color.LightGoldenrodYellow;
            this.cainaykhongdung.Text = "Quản Lý Bàn";
            this.cainaykhongdung.ToolTipTitle = "Page ToolTip";
            this.cainaykhongdung.UniqueName = "130293BE7D974715E19907F61B6B58C9";
            // 
            // lbDelete
            // 
            this.lbDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDelete.AutoSize = true;
            this.lbDelete.BackColor = System.Drawing.Color.Gold;
            this.lbDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDelete.Location = new System.Drawing.Point(381, 26);
            this.lbDelete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDelete.Name = "lbDelete";
            this.lbDelete.Size = new System.Drawing.Size(462, 39);
            this.lbDelete.TabIndex = 4;
            this.lbDelete.Text = "Nhấn đúp vào món ăn để xóa";
            // 
            // btMasterSignout
            // 
            this.btMasterSignout.Location = new System.Drawing.Point(16, 353);
            this.btMasterSignout.Name = "btMasterSignout";
            this.btMasterSignout.Size = new System.Drawing.Size(323, 72);
            this.btMasterSignout.TabIndex = 0;
            this.btMasterSignout.Values.Text = "Đăng xuất tài khoản nhà hàng";
            this.btMasterSignout.Click += new System.EventHandler(this.btMasterSignout_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 628);
            this.Controls.Add(this.lbDelete);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.Navigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant Management";
            this.TransparencyKey = System.Drawing.Color.Beige;
            ((System.ComponentModel.ISupportInitialize)(this.Navigator)).EndInit();
            this.Navigator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageQLBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageQLMenu)).EndInit();
            this.pageQLMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageQLNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageTaiKhoan)).EndInit();
            this.pageTaiKhoan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cainaykhongdung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Navigator.KryptonNavigator Navigator;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageQLMenu;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageQLNV;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageThongKe;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageTaiKhoan;
        private System.Windows.Forms.Label lb1;
        private ComponentFactory.Krypton.Navigator.KryptonPage cainaykhongdung;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageQLBan;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btAddFood;
        private System.Windows.Forms.Label lbDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btMasterSignout;
    }
}