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
        FormQLMenu parent;
        public override void OnPicter_DClick(object sender, EventArgs e)
        {
            // Khi ẩn món ,form tự động dồn những món bên phải (dưới) lên
            if (parent.DeleteFood(lName.Text))
                this.Hide();
        }
        public void SetParent(FormQLMenu parent)
        {
            this.parent = parent;
        }
    }
}
