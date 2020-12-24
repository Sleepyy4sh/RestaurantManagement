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
            this.btCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fpFoods
            // 
            this.fpFoods.AutoScroll = true;
            this.fpFoods.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fpFoods.Location = new System.Drawing.Point(3, 3);
            this.fpFoods.Name = "fpFoods";
            this.fpFoods.Size = new System.Drawing.Size(356, 313);
            this.fpFoods.TabIndex = 0;
            // 
            // lbSumAll
            // 
            this.lbSumAll.Location = new System.Drawing.Point(3, 351);
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
            this.cbType.Location = new System.Drawing.Point(2, 443);
            this.cbType.Margin = new System.Windows.Forms.Padding(2);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(92, 21);
            this.cbType.TabIndex = 3;
            this.cbType.TextChanged += new System.EventHandler(this.cbType_TextChanged);
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(2, 415);
            this.tbValue.Margin = new System.Windows.Forms.Padding(2);
            this.tbValue.MaxLength = 8;
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(103, 20);
            this.tbValue.TabIndex = 4;
            this.tbValue.TextChanged += new System.EventHandler(this.tbValue_TextChanged);
            // 
            // lbTotal
            // 
            this.lbTotal.Location = new System.Drawing.Point(3, 481);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(104, 23);
            this.lbTotal.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.TabIndex = 6;
            this.lbTotal.Values.Text = "Thành tiền =";
            // 
            // lbDiscount
            // 
            this.lbDiscount.Location = new System.Drawing.Point(2, 384);
            this.lbDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(82, 23);
            this.lbDiscount.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscount.TabIndex = 7;
            this.lbDiscount.Values.Text = "Giảm giá:";
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(12, 541);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(90, 25);
            this.btCancel.TabIndex = 8;
            this.btCancel.Values.Text = "Hủy";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.fpFoods, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbSumAll, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbDiscount, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbValue, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbTotal, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbType, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(362, 511);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(383, 605);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btComfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel fpFoods;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbSumAll;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btComfirm;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox tbValue;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbTotal;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbDiscount;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}