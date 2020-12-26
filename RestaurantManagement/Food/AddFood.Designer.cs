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
            this.lbImage = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbVND = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bBrowser = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.bAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbPrice = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tbName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbPrice = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cbIsFood = new System.Windows.Forms.ComboBox();
            this.btExit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbImage
            // 
            this.lbImage.Location = new System.Drawing.Point(235, 256);
            this.lbImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbImage.Name = "lbImage";
            this.lbImage.Size = new System.Drawing.Size(95, 28);
            this.lbImage.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImage.TabIndex = 37;
            this.lbImage.Values.Text = "Hình ảnh";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(200, 103);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(6, 2);
            this.kryptonLabel2.TabIndex = 36;
            this.kryptonLabel2.Values.Text = "";
            // 
            // lbVND
            // 
            this.lbVND.Location = new System.Drawing.Point(681, 126);
            this.lbVND.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbVND.Name = "lbVND";
            this.lbVND.Size = new System.Drawing.Size(73, 24);
            this.lbVND.TabIndex = 34;
            this.lbVND.Values.Text = "000 VNĐ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(19, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(413, 206);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // bBrowser
            // 
            this.bBrowser.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bBrowser.Location = new System.Drawing.Point(464, 334);
            this.bBrowser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bBrowser.Name = "bBrowser";
            this.bBrowser.Size = new System.Drawing.Size(120, 31);
            this.bBrowser.TabIndex = 38;
            this.bBrowser.Values.Text = "Duyệt";
            this.bBrowser.Click += new System.EventHandler(this.bBrowser_Click);
            // 
            // bAdd
            // 
            this.bAdd.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bAdd.Location = new System.Drawing.Point(612, 406);
            this.bAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(148, 57);
            this.bAdd.TabIndex = 39;
            this.bAdd.Values.Text = "Thêm";
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(235, 68);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(94, 28);
            this.lbName.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.TabIndex = 42;
            this.lbName.Values.Text = "Tên món";
            // 
            // lbPrice
            // 
            this.lbPrice.Location = new System.Drawing.Point(251, 118);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(45, 28);
            this.lbPrice.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.TabIndex = 43;
            this.lbPrice.Values.Text = "Giá";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(357, 64);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbName.MaxLength = 30;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(316, 32);
            this.tbName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbName.StateCommon.Border.Rounding = 4;
            this.tbName.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.TabIndex = 44;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(357, 118);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPrice.MaxLength = 8;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(316, 32);
            this.tbPrice.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbPrice.StateCommon.Border.Rounding = 4;
            this.tbPrice.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.TabIndex = 45;
            this.tbPrice.TextChanged += new System.EventHandler(this.tbPrice_TextChanged);
            // 
            // cbIsFood
            // 
            this.cbIsFood.FormattingEnabled = true;
            this.cbIsFood.Items.AddRange(new object[] {
            "Thức ăn",
            "Đồ uống"});
            this.cbIsFood.Location = new System.Drawing.Point(357, 15);
            this.cbIsFood.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbIsFood.Name = "cbIsFood";
            this.cbIsFood.Size = new System.Drawing.Size(160, 24);
            this.cbIsFood.TabIndex = 46;
            // 
            // btExit
            // 
            this.btExit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btExit.Location = new System.Drawing.Point(235, 406);
            this.btExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(148, 57);
            this.btExit.TabIndex = 47;
            this.btExit.Values.Text = "Thoát";
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // AddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(875, 571);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.cbIsFood);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bBrowser);
            this.Controls.Add(this.lbImage);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.lbVND);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbImage;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbVND;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton bBrowser;
        private ComponentFactory.Krypton.Toolkit.KryptonButton bAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbPrice;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbPrice;
        private System.Windows.Forms.ComboBox cbIsFood;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btExit;
    }
}