
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    class Food_Delete : Food
    {
        FormMain parent;
        public override void OnPicter_DClick(object sender, EventArgs e)
        {
            // Khi ẩn món ,form tự động dồn những món bên phải (dưới) lên
            if (parent.DeleteFood(lName.Text))
                this.Hide();
        }
        public void SetParent(FormMain parent)
        {
            this.parent = parent;
        }
    }
}