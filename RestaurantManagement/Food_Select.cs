using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    //Class này để món ăn có thể được chọn vào bàn/hóa đơn
    class Food_Select :Food
    {
        Menu_Select parent;
        public override void OnPicter_DClick(object sender, EventArgs e)
        {
            // Viết hàm xử lí với bàn cha con vô đây
            MessageBox.Show("Món " + lName.Text + " đã được chọn");
        }
        public void SetParent(Menu_Select parent)
        {
            this.parent = parent;
        }
    }
}