using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class Bill : Form
    {
        int Sum = 0;
        Table tableSelected;
        FormMain formMain;
        public Bill(Table table,FormMain form)
        {
            this.formMain = form;
            tableSelected = table;
            InitializeComponent();
        }
        public void AddFood(string name,string index, string price)
        {
            FoodInBill foodInBill = new FoodInBill(this);
            //MessageBox.Show(name);
            foodInBill.Set(name,index, price);
            int temp = Int32.Parse(index) * Int32.Parse(price);
            Sum += temp;
            this.FlowPanelFood.Controls.Add(foodInBill);
            lbSumAll.Text = "Tổng = " +Sum.ToString() +"000 VNĐ";
        }

        private void btComfirm_Click(object sender, EventArgs e)
        {
            formMain.ClearAllFood(tableSelected);
            this.Hide();
        }
    }
}
