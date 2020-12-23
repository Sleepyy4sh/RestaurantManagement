namespace RestaurantManagement
{
    partial class Menu_Select
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Select));
            this.fpFoodSelected = new System.Windows.Forms.FlowLayoutPanel();
            this.fpDrinkSelected = new System.Windows.Forms.FlowLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btFinished = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cbIsFood = new System.Windows.Forms.ComboBox();
            this.btSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tbSearch = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.SuspendLayout();
            // 
            // fpFoodSelected
            // 
            this.fpFoodSelected.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fpFoodSelected.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fpFoodSelected.BackColor = System.Drawing.SystemColors.Control;
            this.fpFoodSelected.Location = new System.Drawing.Point(0, 0);
            this.fpFoodSelected.Name = "fpFoodSelected";
            this.fpFoodSelected.Size = new System.Drawing.Size(1136, 597);
            this.fpFoodSelected.TabIndex = 3;
            // 
            // fpDrinkSelected
            // 
            this.fpDrinkSelected.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fpDrinkSelected.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fpDrinkSelected.BackColor = System.Drawing.SystemColors.Control;
            this.fpDrinkSelected.Location = new System.Drawing.Point(0, 0);
            this.fpDrinkSelected.Name = "fpDrinkSelected";
            this.fpDrinkSelected.Size = new System.Drawing.Size(1136, 597);
            this.fpDrinkSelected.TabIndex = 4;
            // 
            // btFinished
            // 
            this.btFinished.Location = new System.Drawing.Point(502, 603);
            this.btFinished.Name = "btFinished";
            this.btFinished.Size = new System.Drawing.Size(120, 46);
            this.btFinished.TabIndex = 4;
            this.btFinished.Values.Text = "Xong";
            this.btFinished.Click += new System.EventHandler(this.btFinished_Click);
            // 
            // cbIsFood
            // 
            this.cbIsFood.FormattingEnabled = true;
            this.cbIsFood.Items.AddRange(new object[] {
            "Thức ăn",
            "Đồ uống"});
            this.cbIsFood.Location = new System.Drawing.Point(670, 20);
            this.cbIsFood.Name = "cbIsFood";
            this.cbIsFood.Size = new System.Drawing.Size(121, 21);
            this.cbIsFood.TabIndex = 47;
            this.cbIsFood.SelectedIndexChanged += new System.EventHandler(this.cbIsFood_SelectedIndexChanged);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(1319, 152);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(163, 32);
            this.btSearch.TabIndex = 4;
            this.btSearch.Values.Image = ((System.Drawing.Image)(resources.GetObject("btSearch.Values.Image")));
            this.btSearch.Values.Text = "Tìm kiếm";
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.AllowDrop = true;
            this.tbSearch.Location = new System.Drawing.Point(1319, 110);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(163, 26);
            this.tbSearch.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.TabIndex = 3;
            // 
            // Menu_Select
            // 
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.btFinished);
            this.Controls.Add(this.fpFoodSelected);
            this.Controls.Add(this.fpDrinkSelected);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Size = new System.Drawing.Size(1138, 652);
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpFoodSelected;
        private System.Windows.Forms.FlowLayoutPanel fpDrinkSelected;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btFinished;
        private System.Windows.Forms.ComboBox cbIsFood;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbSearch;
    }
}