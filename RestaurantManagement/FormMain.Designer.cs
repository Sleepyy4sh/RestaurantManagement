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
            this.btPay = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btOrder = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.flowListFood = new System.Windows.Forms.FlowLayoutPanel();
            this.lbListFood = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.flowTable = new System.Windows.Forms.FlowLayoutPanel();
            this.btAddTable = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pageQLMenu = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.btSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tbSearch = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btFix = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btAddFood = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pageQLNV = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.pageThongKe = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.pageTaiKhoan = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.btSignout = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btMasterSignout = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cainaykhongdung = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Navigator)).BeginInit();
            this.Navigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageQLBan)).BeginInit();
            this.pageQLBan.SuspendLayout();
            this.flowListFood.SuspendLayout();
            this.flowTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageQLMenu)).BeginInit();
            this.pageQLMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageQLNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageTaiKhoan)).BeginInit();
            this.pageTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cainaykhongdung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Navigator
            // 
            this.Navigator.AutoSize = true;
            this.Navigator.Bar.ItemMaximumSize = new System.Drawing.Size(310, 200);
            this.Navigator.Bar.ItemMinimumSize = new System.Drawing.Size(310, 20);
            this.Navigator.Bar.ItemOrientation = ComponentFactory.Krypton.Toolkit.ButtonOrientation.FixedTop;
            this.Navigator.Bar.ItemSizing = ComponentFactory.Krypton.Navigator.BarItemSizing.SameWidth;
            this.Navigator.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None;
            this.Navigator.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.Navigator.Location = new System.Drawing.Point(0, 120);
            this.Navigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Navigator.Name = "Navigator";
            this.Navigator.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.pageQLBan,
            this.pageQLMenu,
            this.pageQLNV,
            this.pageThongKe,
            this.pageTaiKhoan});
            this.Navigator.SelectedIndex = 1;
            this.Navigator.Size = new System.Drawing.Size(2025, 897);
            this.Navigator.TabIndex = 0;
            this.Navigator.Text = "Navigator";
            // 
            // pageQLBan
            // 
            this.pageQLBan.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageQLBan.Controls.Add(this.btPay);
            this.pageQLBan.Controls.Add(this.btOrder);
            this.pageQLBan.Controls.Add(this.flowListFood);
            this.pageQLBan.Controls.Add(this.flowTable);
            this.pageQLBan.Flags = 65534;
            this.pageQLBan.ImageSmall = ((System.Drawing.Image)(resources.GetObject("pageQLBan.ImageSmall")));
            this.pageQLBan.LastVisibleSet = true;
            this.pageQLBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageQLBan.MinimumSize = new System.Drawing.Size(51, 50);
            this.pageQLBan.Name = "pageQLBan";
            this.pageQLBan.Size = new System.Drawing.Size(2023, 838);
            this.pageQLBan.Text = " Quản Lý Bàn";
            this.pageQLBan.ToolTipTitle = "Page ToolTip";
            this.pageQLBan.UniqueName = "E2368B99859C40256FBCE8BBB86E65E9";
            // 
            // btPay
            // 
            this.btPay.Location = new System.Drawing.Point(1804, 707);
            this.btPay.Margin = new System.Windows.Forms.Padding(4);
            this.btPay.Name = "btPay";
            this.btPay.Size = new System.Drawing.Size(158, 49);
            this.btPay.TabIndex = 2;
            this.btPay.Values.Text = "Thanh Toán";
            this.btPay.Click += new System.EventHandler(this.btPay_Click);
            // 
            // btOrder
            // 
            this.btOrder.Location = new System.Drawing.Point(1556, 707);
            this.btOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btOrder.Name = "btOrder";
            this.btOrder.Size = new System.Drawing.Size(162, 49);
            this.btOrder.TabIndex = 1;
            this.btOrder.Values.Text = "Gọi món";
            this.btOrder.Click += new System.EventHandler(this.btOrder_Click);
            // 
            // flowListFood
            // 
            this.flowListFood.AutoScroll = true;
            this.flowListFood.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.flowListFood.Controls.Add(this.lbListFood);
            this.flowListFood.Location = new System.Drawing.Point(1474, 4);
            this.flowListFood.Margin = new System.Windows.Forms.Padding(4);
            this.flowListFood.Name = "flowListFood";
            this.flowListFood.Size = new System.Drawing.Size(545, 683);
            this.flowListFood.TabIndex = 0;
            // 
            // lbListFood
            // 
            this.lbListFood.AutoSize = false;
            this.flowListFood.SetFlowBreak(this.lbListFood, true);
            this.lbListFood.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lbListFood.Location = new System.Drawing.Point(4, 4);
            this.lbListFood.Margin = new System.Windows.Forms.Padding(4);
            this.lbListFood.Name = "lbListFood";
            this.lbListFood.Size = new System.Drawing.Size(325, 31);
            this.lbListFood.TabIndex = 0;
            this.lbListFood.Values.Text = " Danh sách món ";
            // 
            // flowTable
            // 
            this.flowTable.AutoScroll = true;
            this.flowTable.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.flowTable.Controls.Add(this.btAddTable);
            this.flowTable.Location = new System.Drawing.Point(4, 0);
            this.flowTable.Margin = new System.Windows.Forms.Padding(4);
            this.flowTable.Name = "flowTable";
            this.flowTable.Size = new System.Drawing.Size(1448, 762);
            this.flowTable.TabIndex = 0;
            // 
            // btAddTable
            // 
            this.btAddTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btAddTable.Location = new System.Drawing.Point(4, 4);
            this.btAddTable.Margin = new System.Windows.Forms.Padding(4);
            this.btAddTable.Name = "btAddTable";
            this.btAddTable.Size = new System.Drawing.Size(155, 185);
            this.btAddTable.TabIndex = 0;
            this.btAddTable.Values.Image = ((System.Drawing.Image)(resources.GetObject("btAddTable.Values.Image")));
            this.btAddTable.Values.Text = "";
            this.btAddTable.Click += new System.EventHandler(this.btAddTable_Click);
            // 
            // pageQLMenu
            // 
            this.pageQLMenu.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageQLMenu.Controls.Add(this.btSearch);
            this.pageQLMenu.Controls.Add(this.tbSearch);
            this.pageQLMenu.Controls.Add(this.btFix);
            this.pageQLMenu.Controls.Add(this.btAddFood);
            this.pageQLMenu.Controls.Add(this.flowLayoutPanel1);
            this.pageQLMenu.Flags = 65534;
            this.pageQLMenu.ImageSmall = ((System.Drawing.Image)(resources.GetObject("pageQLMenu.ImageSmall")));
            this.pageQLMenu.LastVisibleSet = true;
            this.pageQLMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageQLMenu.MinimumSize = new System.Drawing.Size(51, 50);
            this.pageQLMenu.Name = "pageQLMenu";
            this.pageQLMenu.Size = new System.Drawing.Size(2023, 838);
            this.pageQLMenu.Text = "Quản Lý Menu";
            this.pageQLMenu.ToolTipTitle = "Page ToolTip";
            this.pageQLMenu.UniqueName = "D18C1773B43348FFCBAEE6F5BA9BEFC7";
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(1759, 187);
            this.btSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(217, 39);
            this.btSearch.TabIndex = 4;
            this.btSearch.Values.Image = ((System.Drawing.Image)(resources.GetObject("btSearch.Values.Image")));
            this.btSearch.Values.Text = "Tìm kiếm";
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.AllowDrop = true;
            this.tbSearch.Location = new System.Drawing.Point(1759, 135);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(217, 30);
            this.tbSearch.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.TabIndex = 3;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // btFix
            // 
            this.btFix.Location = new System.Drawing.Point(1794, 707);
            this.btFix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btFix.Name = "btFix";
            this.btFix.Size = new System.Drawing.Size(168, 70);
            this.btFix.TabIndex = 2;
            this.btFix.Values.Image = ((System.Drawing.Image)(resources.GetObject("btFix.Values.Image")));
            this.btFix.Values.Text = "Chỉnh sửa";
            this.btFix.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAddFood
            // 
            this.btAddFood.Location = new System.Drawing.Point(1794, 618);
            this.btAddFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAddFood.Name = "btAddFood";
            this.btAddFood.Size = new System.Drawing.Size(168, 69);
            this.btAddFood.TabIndex = 1;
            this.btAddFood.Values.Image = ((System.Drawing.Image)(resources.GetObject("btAddFood.Values.Image")));
            this.btAddFood.Values.Text = "Thêm món";
            this.btAddFood.Click += new System.EventHandler(this.btAddFood_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, 2);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1696, 805);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pageQLNV
            // 
            this.pageQLNV.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageQLNV.Flags = 65534;
            this.pageQLNV.ImageSmall = ((System.Drawing.Image)(resources.GetObject("pageQLNV.ImageSmall")));
            this.pageQLNV.LastVisibleSet = true;
            this.pageQLNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageQLNV.MinimumSize = new System.Drawing.Size(51, 50);
            this.pageQLNV.Name = "pageQLNV";
            this.pageQLNV.Size = new System.Drawing.Size(2023, 838);
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
            this.pageThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageThongKe.MinimumSize = new System.Drawing.Size(51, 50);
            this.pageThongKe.Name = "pageThongKe";
            this.pageThongKe.Size = new System.Drawing.Size(1992, 838);
            this.pageThongKe.Text = "Thống Kê";
            this.pageThongKe.ToolTipTitle = "Page ToolTip";
            this.pageThongKe.UniqueName = "CC90403B1D8642C7A2909E6A147096A4";
            // 
            // pageTaiKhoan
            // 
            this.pageTaiKhoan.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageTaiKhoan.Controls.Add(this.btSignout);
            this.pageTaiKhoan.Controls.Add(this.btMasterSignout);
            this.pageTaiKhoan.Flags = 65534;
            this.pageTaiKhoan.ImageSmall = ((System.Drawing.Image)(resources.GetObject("pageTaiKhoan.ImageSmall")));
            this.pageTaiKhoan.LastVisibleSet = true;
            this.pageTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageTaiKhoan.MinimumSize = new System.Drawing.Size(51, 50);
            this.pageTaiKhoan.Name = "pageTaiKhoan";
            this.pageTaiKhoan.Size = new System.Drawing.Size(2023, 838);
            this.pageTaiKhoan.Text = "Tải Khoản";
            this.pageTaiKhoan.ToolTipTitle = "Page ToolTip";
            this.pageTaiKhoan.UniqueName = "72EE1F9F8D394B17F5BE0583764C6EB4";
            // 
            // btSignout
            // 
            this.btSignout.Location = new System.Drawing.Point(16, 571);
            this.btSignout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSignout.Name = "btSignout";
            this.btSignout.Size = new System.Drawing.Size(323, 71);
            this.btSignout.TabIndex = 1;
            this.btSignout.Values.Text = "Đăng xuất";
            this.btSignout.Click += new System.EventHandler(this.btSignout_Click);
            // 
            // btMasterSignout
            // 
            this.btMasterSignout.Location = new System.Drawing.Point(16, 685);
            this.btMasterSignout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btMasterSignout.Name = "btMasterSignout";
            this.btMasterSignout.Size = new System.Drawing.Size(323, 71);
            this.btMasterSignout.TabIndex = 0;
            this.btMasterSignout.Values.Text = "Đăng xuất tài khoản nhà hàng";
            this.btMasterSignout.Click += new System.EventHandler(this.btMasterSignout_Click);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2050, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 953);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Navigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant Management";
            this.TransparencyKey = System.Drawing.Color.Beige;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Navigator)).EndInit();
            this.Navigator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageQLBan)).EndInit();
            this.pageQLBan.ResumeLayout(false);
            this.flowListFood.ResumeLayout(false);
            this.flowTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageQLMenu)).EndInit();
            this.pageQLMenu.ResumeLayout(false);
            this.pageQLMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageQLNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageTaiKhoan)).EndInit();
            this.pageTaiKhoan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cainaykhongdung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Navigator.KryptonNavigator Navigator;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageQLMenu;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageQLNV;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageThongKe;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageTaiKhoan;
        private ComponentFactory.Krypton.Navigator.KryptonPage cainaykhongdung;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageQLBan;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btAddFood;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btFix;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btMasterSignout;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btSignout;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbSearch;
        private System.Windows.Forms.FlowLayoutPanel flowListFood;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btAddTable;
        public System.Windows.Forms.FlowLayoutPanel flowTable;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbListFood;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btOrder;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btPay;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}