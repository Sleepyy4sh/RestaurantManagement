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
        Label lbName = new Label();
        Label lbIndex = new Label();
        Label lbSum = new Label();

        //Bill bill = new Bill();
        public FoodInBill()
        {
            //init();
        }

        void init()
        {
            //lbName.Size = new Size(bill.Size.Width / 5 * 3, 30);
            lbName.Location = new Point(0, 0);
            lbName.Text = "Tên";

           // lbIndex.Size = new Size(bill.Size.Width / 5 * 1, 30);
            lbIndex.Location = new Point(lbName.Size.Width, 0);
            lbIndex.Text = "Số lượng";

            //lbSum.Size = new Size(bill.Size.Width / 5 * 1, 30);
            lbSum.Location = new Point(lbIndex.Size.Width+lbIndex.Location.X, 0);
            lbSum.Text = "Tổng";

            this.Controls.Add(lbName);
            this.Controls.Add(lbIndex);
            this.Controls.Add(lbSum);
        }
    }
}
