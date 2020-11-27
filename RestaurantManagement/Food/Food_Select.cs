using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace RestaurantManagement
{
    //Class này để món ăn có thể được chọn vào bàn/hóa đơn
    public class Food_Select :Food
    {
        Menu_Select parent;
        FormMain formQLBan;
        public Food_Select(FormMain formQL)
        {
            pSelected.Hide();
            this.formQLBan = formQL;
            this.pFood.Click += new EventHandler(OnPicter_click);
        }
        public void OnPicter_click(object sender, EventArgs e)
        {
            if (!Exist(lName.Text))
            {
                //MessageBox.Show("Món " + lName.Text + " đã được chọn");
                formQLBan.Add_FoodINLIST(lName.Text, "1");
                formQLBan.SaveListFood();
                pSelected.Show();
            }
        }
        bool Exist(string food)
        {
            for (int i = 0; i < formQLBan.listFoodInList.Count; i++)
                if (food == formQLBan.listFoodInList[i].name) 
                    return true;
            return false;
        }
        public void SetParent(Menu_Select parent)
        {
            this.parent = parent;
        }
    }
}