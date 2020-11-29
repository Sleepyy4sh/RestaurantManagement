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
            this.FlowPanelFood = new System.Windows.Forms.FlowLayoutPanel();
            this.lbSumAll = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btComfirm = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.lbTotal = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // FlowPanelFood
            // 
            this.FlowPanelFood.AutoScroll = true;
            this.FlowPanelFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlowPanelFood.Location = new System.Drawing.Point(0, 37);
            this.FlowPanelFood.Margin = new System.Windows.Forms.Padding(4);
            this.FlowPanelFood.Name = "FlowPanelFood";
            this.FlowPanelFood.Size = new System.Drawing.Size(498, 446);
            this.FlowPanelFood.TabIndex = 0;
            // 
            // lbSumAll
            // 
            this.lbSumAll.Location = new System.Drawing.Point(130, 491);
            this.lbSumAll.Margin = new System.Windows.Forms.Padding(4);
            this.lbSumAll.Name = "lbSumAll";
            this.lbSumAll.Size = new System.Drawing.Size(78, 28);
            this.lbSumAll.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSumAll.TabIndex = 1;
            this.lbSumAll.Values.Text = "Tổng = ";
            // 
            // btComfirm
            // 
            this.btComfirm.Location = new System.Drawing.Point(182, 704);
            this.btComfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btComfirm.Name = "btComfirm";
            this.btComfirm.Size = new System.Drawing.Size(120, 31);
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
            this.cbType.Location = new System.Drawing.Point(324, 591);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 24);
            this.cbType.TabIndex = 3;
            this.cbType.TextChanged += new System.EventHandler(this.cbType_TextChanged);
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(182, 591);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(136, 22);
            this.tbValue.TabIndex = 4;
            this.tbValue.TextChanged += new System.EventHandler(this.tbValue_TextChanged);
            // 
            // lbTotal
            // 
            this.lbTotal.Location = new System.Drawing.Point(80, 668);
            this.lbTotal.Margin = new System.Windows.Forms.Padding(4);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(128, 28);
            this.lbTotal.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.TabIndex = 6;
            this.lbTotal.Values.Text = "Thành tiền =";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(66, 585);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(101, 28);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 7;
            this.kryptonLabel1.Values.Text = "Giảm giá:";
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(511, 748);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.btComfirm);
            this.Controls.Add(this.lbSumAll);
            this.Controls.Add(this.FlowPanelFood);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel FlowPanelFood;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbSumAll;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btComfirm;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox tbValue;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbTotal;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}