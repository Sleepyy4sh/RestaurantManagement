namespace RestaurantManagement
{
    partial class FixFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FixFood));
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tbPrice = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.bAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.bBrowser = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lVND = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(199, 110);
            this.kryptonLabel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(34, 24);
            this.kryptonLabel5.TabIndex = 54;
            this.kryptonLabel5.Values.Text = "Giá";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(199, 65);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(72, 24);
            this.kryptonLabel4.TabIndex = 53;
            this.kryptonLabel4.Values.Text = "Tên món";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(297, 110);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(271, 27);
            this.tbPrice.TabIndex = 52;
            this.tbPrice.TextChanged += new System.EventHandler(this.tbPrice_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(297, 65);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(271, 27);
            this.tbName.TabIndex = 51;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // bAdd
            // 
            this.bAdd.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bAdd.Location = new System.Drawing.Point(349, 340);
            this.bAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(147, 52);
            this.bAdd.TabIndex = 50;
            this.bAdd.Values.Text = "Sửa";
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bBrowser
            // 
            this.bBrowser.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bBrowser.Location = new System.Drawing.Point(359, 281);
            this.bBrowser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bBrowser.Name = "bBrowser";
            this.bBrowser.Size = new System.Drawing.Size(120, 31);
            this.bBrowser.TabIndex = 49;
            this.bBrowser.Values.Text = "Duyệt";
            this.bBrowser.Click += new System.EventHandler(this.bBrowser_Click);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(197, 201);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(73, 24);
            this.kryptonLabel3.TabIndex = 48;
            this.kryptonLabel3.Values.Text = "Hình ảnh";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(197, 113);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(6, 2);
            this.kryptonLabel2.TabIndex = 47;
            this.kryptonLabel2.Values.Text = "";
            // 
            // lVND
            // 
            this.lVND.Location = new System.Drawing.Point(576, 113);
            this.lVND.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lVND.Name = "lVND";
            this.lVND.Size = new System.Drawing.Size(73, 24);
            this.lVND.TabIndex = 46;
            this.lVND.Values.Text = "000 VNĐ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(333, 151);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // FixFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(788, 462);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FixFood";
            this.Text = "FixFood";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbPrice;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbName;
        private ComponentFactory.Krypton.Toolkit.KryptonButton bAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonButton bBrowser;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lVND;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}