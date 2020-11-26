namespace RestaurantManagement
{
    partial class AddTable
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
            this.btAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tbName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(167, 94);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(90, 25);
            this.btAdd.TabIndex = 0;
            this.btAdd.Values.Text = "Thêm";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(157, 38);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(113, 23);
            this.tbName.TabIndex = 1;
            // 
            // AddTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 149);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btAdd);
            this.Name = "AddTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbName;
    }
}