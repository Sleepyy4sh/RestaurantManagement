using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace RestaurantManagement
{
    class FoodInBill :Panel
    {
        public string name;
        Label lbName = new Label();
        Label lbIndex = new Label();
        Label lbSum = new Label();

        Bill bill;
        public FoodInBill(Bill bill)
        {
            this.bill = bill;
            this.Size = new Size(bill.FlowPanelFood.Size.Width,30);
            init();
        }

        void init()
        {
            lbName.Size = new Size((int)(this.Size.Width / 6 * 2.5f), 30);
            //MessageBox.Show(lbName.Size.ToString());
            lbName.Location = new Point(0, 0);
            name = lbName.Text = "Tênnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnn";

            lbIndex.Size = new Size((int)(this.Size.Width / 6 * 1.5f), 30);
            lbIndex.Location = new Point(lbName.Size.Width, 0);
            //MessageBox.Show(lbIndex.Location.ToString());
            lbIndex.Text = "X Số lượng ";

            lbSum.Size = new Size((int)(this.Size.Width / 6 * 2f), 30);
            lbSum.Location = new Point(lbIndex.Size.Width+lbIndex.Location.X, 0);
           
            lbSum.Text = "= Tổng";

            this.Controls.Add(lbName);
            this.Controls.Add(lbIndex);
            this.Controls.Add(lbSum);
        }
        public void Set(string name,string index ,string price)
        {
            this.name = lbName.Text = name;
            lbIndex.Text = "X " + index;
            int i = Int32.Parse(index);
            int p = Int32.Parse(price);
            lbSum.Text = "= " + (i*p).ToString()+ "000 VNĐ" ;
           // MessageBox.Show(index);
        }
    }
}
