namespace RestaurantManagement
{
    partial class FormChangeInfo
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbSEmail = new System.Windows.Forms.Label();
            this.lbSICnumber = new System.Windows.Forms.Label();
            this.lbSDoB = new System.Windows.Forms.Label();
            this.lbSPnumber = new System.Windows.Forms.Label();
            this.lbSAddress = new System.Windows.Forms.Label();
            this.lbSFname = new System.Windows.Forms.Label();
            this.tbSFname = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbSDoB = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbSAddress = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbSPnumber = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbSICnumber = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbSEmail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btSaveInfo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btExit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.lbTitle.Location = new System.Drawing.Point(311, 64);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(278, 52);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Sửa thông tin";
            // 
            // lbSEmail
            // 
            this.lbSEmail.AutoSize = true;
            this.lbSEmail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbSEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbSEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbSEmail.Location = new System.Drawing.Point(45, 604);
            this.lbSEmail.Name = "lbSEmail";
            this.lbSEmail.Size = new System.Drawing.Size(89, 31);
            this.lbSEmail.TabIndex = 23;
            this.lbSEmail.Text = "Email:";
            // 
            // lbSICnumber
            // 
            this.lbSICnumber.AutoSize = true;
            this.lbSICnumber.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbSICnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbSICnumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbSICnumber.Location = new System.Drawing.Point(43, 518);
            this.lbSICnumber.Name = "lbSICnumber";
            this.lbSICnumber.Size = new System.Drawing.Size(232, 31);
            this.lbSICnumber.TabIndex = 22;
            this.lbSICnumber.Text = "Số CMND/CCCD:";
            // 
            // lbSDoB
            // 
            this.lbSDoB.AutoSize = true;
            this.lbSDoB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbSDoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbSDoB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbSDoB.Location = new System.Drawing.Point(43, 268);
            this.lbSDoB.Name = "lbSDoB";
            this.lbSDoB.Size = new System.Drawing.Size(277, 31);
            this.lbSDoB.TabIndex = 21;
            this.lbSDoB.Text = "Ngày sinh (M/d/yyyy):";
            // 
            // lbSPnumber
            // 
            this.lbSPnumber.AutoSize = true;
            this.lbSPnumber.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbSPnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbSPnumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbSPnumber.Location = new System.Drawing.Point(45, 430);
            this.lbSPnumber.Name = "lbSPnumber";
            this.lbSPnumber.Size = new System.Drawing.Size(171, 31);
            this.lbSPnumber.TabIndex = 20;
            this.lbSPnumber.Text = "Số điện thoại";
            // 
            // lbSAddress
            // 
            this.lbSAddress.AutoSize = true;
            this.lbSAddress.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbSAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbSAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbSAddress.Location = new System.Drawing.Point(43, 350);
            this.lbSAddress.Name = "lbSAddress";
            this.lbSAddress.Size = new System.Drawing.Size(105, 31);
            this.lbSAddress.TabIndex = 19;
            this.lbSAddress.Text = "Địa chỉ:";
            // 
            // lbSFname
            // 
            this.lbSFname.AutoSize = true;
            this.lbSFname.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbSFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbSFname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbSFname.Location = new System.Drawing.Point(43, 181);
            this.lbSFname.Name = "lbSFname";
            this.lbSFname.Size = new System.Drawing.Size(102, 31);
            this.lbSFname.TabIndex = 18;
            this.lbSFname.Text = "Họ tên:";
            // 
            // tbSFname
            // 
            this.tbSFname.Location = new System.Drawing.Point(320, 181);
            this.tbSFname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSFname.MaxLength = 30;
            this.tbSFname.Name = "tbSFname";
            this.tbSFname.Size = new System.Drawing.Size(525, 38);
            this.tbSFname.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSFname.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbSFname.StateCommon.Border.Rounding = 6;
            this.tbSFname.TabIndex = 0;
            // 
            // tbSDoB
            // 
            this.tbSDoB.Location = new System.Drawing.Point(320, 268);
            this.tbSDoB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSDoB.MaxLength = 10;
            this.tbSDoB.Name = "tbSDoB";
            this.tbSDoB.Size = new System.Drawing.Size(525, 38);
            this.tbSDoB.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSDoB.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbSDoB.StateCommon.Border.Rounding = 6;
            this.tbSDoB.TabIndex = 3;
            // 
            // tbSAddress
            // 
            this.tbSAddress.Location = new System.Drawing.Point(320, 343);
            this.tbSAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSAddress.MaxLength = 50;
            this.tbSAddress.Name = "tbSAddress";
            this.tbSAddress.Size = new System.Drawing.Size(525, 38);
            this.tbSAddress.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSAddress.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbSAddress.StateCommon.Border.Rounding = 6;
            this.tbSAddress.TabIndex = 2;
            // 
            // tbSPnumber
            // 
            this.tbSPnumber.Location = new System.Drawing.Point(320, 422);
            this.tbSPnumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSPnumber.MaxLength = 15;
            this.tbSPnumber.Name = "tbSPnumber";
            this.tbSPnumber.Size = new System.Drawing.Size(525, 38);
            this.tbSPnumber.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSPnumber.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbSPnumber.StateCommon.Border.Rounding = 6;
            this.tbSPnumber.TabIndex = 1;
            // 
            // tbSICnumber
            // 
            this.tbSICnumber.Location = new System.Drawing.Point(320, 511);
            this.tbSICnumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSICnumber.MaxLength = 15;
            this.tbSICnumber.Name = "tbSICnumber";
            this.tbSICnumber.Size = new System.Drawing.Size(525, 38);
            this.tbSICnumber.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSICnumber.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbSICnumber.StateCommon.Border.Rounding = 6;
            this.tbSICnumber.TabIndex = 4;
            // 
            // tbSEmail
            // 
            this.tbSEmail.Location = new System.Drawing.Point(320, 597);
            this.tbSEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSEmail.MaxLength = 50;
            this.tbSEmail.Name = "tbSEmail";
            this.tbSEmail.Size = new System.Drawing.Size(525, 38);
            this.tbSEmail.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSEmail.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbSEmail.StateCommon.Border.Rounding = 6;
            this.tbSEmail.TabIndex = 5;
            // 
            // btSaveInfo
            // 
            this.btSaveInfo.Location = new System.Drawing.Point(497, 658);
            this.btSaveInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSaveInfo.Name = "btSaveInfo";
            this.btSaveInfo.Size = new System.Drawing.Size(131, 54);
            this.btSaveInfo.TabIndex = 6;
            this.btSaveInfo.Values.Text = "Lưu";
            this.btSaveInfo.Click += new System.EventHandler(this.btSaveInfo_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(805, 735);
            this.btExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(117, 52);
            this.btExit.TabIndex = 7;
            this.btExit.Values.Text = "Thoát";
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // FormChangeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(935, 750);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btSaveInfo);
            this.Controls.Add(this.tbSEmail);
            this.Controls.Add(this.tbSICnumber);
            this.Controls.Add(this.tbSPnumber);
            this.Controls.Add(this.tbSAddress);
            this.Controls.Add(this.tbSDoB);
            this.Controls.Add(this.tbSFname);
            this.Controls.Add(this.lbSEmail);
            this.Controls.Add(this.lbSICnumber);
            this.Controls.Add(this.lbSDoB);
            this.Controls.Add(this.lbSPnumber);
            this.Controls.Add(this.lbSAddress);
            this.Controls.Add(this.lbSFname);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormChangeInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa thông tin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbSEmail;
        private System.Windows.Forms.Label lbSICnumber;
        private System.Windows.Forms.Label lbSDoB;
        private System.Windows.Forms.Label lbSPnumber;
        private System.Windows.Forms.Label lbSAddress;
        private System.Windows.Forms.Label lbSFname;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbSFname;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbSDoB;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbSAddress;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbSPnumber;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbSICnumber;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbSEmail;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btSaveInfo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btExit;
    }
}