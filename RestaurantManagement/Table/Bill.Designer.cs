namespace RestaurantManagement
{
    partial class Bill
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
            this.fpFoods = new System.Windows.Forms.FlowLayoutPanel();
            this.lbSumAll = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btComfirm = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.lbTotal = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbDiscount = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // fpFoods
            // 
            this.fpFoods.AutoScroll = true;
            this.fpFoods.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fpFoods.Location = new System.Drawing.Point(0, 30);
            this.fpFoods.Name = "fpFoods";
            this.fpFoods.Size = new System.Drawing.Size(374, 363);
            this.fpFoods.TabIndex = 0;
            // 
            // lbSumAll
            // 
            this.lbSumAll.Location = new System.Drawing.Point(98, 399);
            this.lbSumAll.Name = "lbSumAll";
            this.lbSumAll.Size = new System.Drawing.Size(63, 23);
            this.lbSumAll.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSumAll.TabIndex = 1;
            this.lbSumAll.Values.Text = "Tổng = ";
            // 
            // btComfirm
            // 
            this.btComfirm.Location = new System.Drawing.Point(136, 572);
            this.btComfirm.Name = "btComfirm";
            this.btComfirm.Size = new System.Drawing.Size(90, 25);
            this.btComfirm.TabIndex = 2;
            this.btComfirm.Values.Text = "Xác nhận";
            this.btComfirm.Click += new System.EventHandler(this.btComfirm_Click);
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "%",
            "VND"});
            this.cbType.Location = new System.Drawing.Point(243, 480);
            this.cbType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(92, 21);
            this.cbType.TabIndex = 3;
            this.cbType.TextChanged += new System.EventHandler(this.cbType_TextChanged);
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(136, 480);
            this.tbValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbValue.MaxLength = 8;
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(103, 20);
            this.tbValue.TabIndex = 4;
            this.tbValue.TextChanged += new System.EventHandler(this.tbValue_TextChanged);
            // 
            // lbTotal
            // 
            this.lbTotal.Location = new System.Drawing.Point(60, 543);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(104, 23);
            this.lbTotal.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.TabIndex = 6;
            this.lbTotal.Values.Text = "Thành tiền =";
            // 
            // lbDiscount
            // 
            this.lbDiscount.Location = new System.Drawing.Point(50, 475);
            this.lbDiscount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(82, 23);
            this.lbDiscount.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscount.TabIndex = 7;
            this.lbDiscount.Values.Text = "Giảm giá:";
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(383, 605);
            this.Controls.Add(this.lbDiscount);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.btComfirm);
            this.Controls.Add(this.lbSumAll);
            this.Controls.Add(this.fpFoods);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel fpFoods;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbSumAll;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btComfirm;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox tbValue;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbTotal;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbDiscount;
    }
}