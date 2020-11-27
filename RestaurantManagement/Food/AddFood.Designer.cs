namespace RestaurantManagement

{
    partial class AddFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFood));
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lVND = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bBrowser = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.bAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tbName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbPrice = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(150, 155);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(60, 20);
            this.kryptonLabel3.TabIndex = 37;
            this.kryptonLabel3.Values.Text = "Hình ảnh";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(150, 84);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(6, 2);
            this.kryptonLabel2.TabIndex = 36;
            this.kryptonLabel2.Values.Text = "";
            // 
            // lVND
            // 
            this.lVND.Location = new System.Drawing.Point(434, 84);
            this.lVND.Name = "lVND";
            this.lVND.Size = new System.Drawing.Size(59, 20);
            this.lVND.TabIndex = 34;
            this.lVND.Values.Text = "000 VNĐ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(252, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // bBrowser
            // 
            this.bBrowser.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bBrowser.Location = new System.Drawing.Point(271, 220);
            this.bBrowser.Name = "bBrowser";
            this.bBrowser.Size = new System.Drawing.Size(90, 25);
            this.bBrowser.TabIndex = 38;
            this.bBrowser.Values.Text = "Duyệt";
            this.bBrowser.Click += new System.EventHandler(this.bBrowser_Click);
            // 
            // bAdd
            // 
            this.bAdd.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bAdd.Location = new System.Drawing.Point(264, 268);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(110, 42);
            this.bAdd.TabIndex = 39;
            this.bAdd.Values.Text = "Thêm";
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(225, 45);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(203, 23);
            this.tbName.TabIndex = 40;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(225, 81);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(203, 23);
            this.tbPrice.TabIndex = 41;
            this.tbPrice.TextChanged += new System.EventHandler(this.tbPrice_TextChanged);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(151, 45);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(59, 20);
            this.kryptonLabel4.TabIndex = 42;
            this.kryptonLabel4.Values.Text = "Tên món";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(162, 81);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(28, 20);
            this.kryptonLabel5.TabIndex = 43;
            this.kryptonLabel5.Values.Text = "Giá";
            // 
            // AddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(591, 375);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bBrowser);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.lVND);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm món";
            this.Load += new System.EventHandler(this.AddFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lVND;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton bBrowser;
        private ComponentFactory.Krypton.Toolkit.KryptonButton bAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbPrice;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
    }
}