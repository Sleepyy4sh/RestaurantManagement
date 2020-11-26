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
            this.SuspendLayout();
            // 
            // FlowPanelFood
            // 
            this.FlowPanelFood.AutoScroll = true;
            this.FlowPanelFood.Location = new System.Drawing.Point(0, 30);
            this.FlowPanelFood.Name = "FlowPanelFood";
            this.FlowPanelFood.Size = new System.Drawing.Size(376, 362);
            this.FlowPanelFood.TabIndex = 0;
            // 
            // lbSumAll
            // 
            this.lbSumAll.Location = new System.Drawing.Point(231, 398);
            this.lbSumAll.Name = "lbSumAll";
            this.lbSumAll.Size = new System.Drawing.Size(50, 20);
            this.lbSumAll.TabIndex = 1;
            this.lbSumAll.Values.Text = "Tổng = ";
            // 
            // btComfirm
            // 
            this.btComfirm.Location = new System.Drawing.Point(131, 478);
            this.btComfirm.Name = "btComfirm";
            this.btComfirm.Size = new System.Drawing.Size(90, 25);
            this.btComfirm.TabIndex = 2;
            this.btComfirm.Values.Text = "Xác nhận";
            this.btComfirm.Click += new System.EventHandler(this.btComfirm_Click);
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 541);
            this.Controls.Add(this.btComfirm);
            this.Controls.Add(this.lbSumAll);
            this.Controls.Add(this.FlowPanelFood);
            this.Name = "Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel FlowPanelFood;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbSumAll;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btComfirm;
    }
}