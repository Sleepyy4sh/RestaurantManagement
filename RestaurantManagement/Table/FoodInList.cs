using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace RestaurantManagement
{
    public class FoodInList :Panel 
    {
        Label lbNameFood = new Label();
        Button btPlusIndexFood = new Button();
        TextBox tbIndexFood = new TextBox();
        Button btSubtractIndexFood = new Button();
        Button btDelete = new Button();
        public string name;
        public string index;

        FormMain formQLBan;
        public FoodInList(FormMain form)
        {
            formQLBan = form;
            SetSize();
            Init();
            this.Controls.Add(lbNameFood);
            this.Controls.Add(btPlusIndexFood);
            this.Controls.Add(tbIndexFood);
            this.Controls.Add(btSubtractIndexFood);
            this.Controls.Add(btDelete);
        }
        public void SetSize(int x =254,int y=30)
        {
            this.Size = new Size(x, y);
        }
        public void Set(string name, string index)
        {
            this.name = lbNameFood.Text = name;
            this.index =  tbIndexFood.Text = index;
        }
        void Init()
        {
            lbNameFood.Text = "1";
            lbNameFood.Size = new Size(this.Size.Width / 6 * 3, this.Size.Height);


            btSubtractIndexFood.Size = new Size(this.Size.Height, this.Size.Height);
            btSubtractIndexFood.Location = new Point(lbNameFood.Size.Width, 0);
            btSubtractIndexFood.Text = "-";
            btSubtractIndexFood.Click += new EventHandler(btSubtract_Click) ;

            tbIndexFood.Size = new Size(this.Size.Height, this.Size.Height);
            tbIndexFood.Location = new Point(btSubtractIndexFood.Size.Width + btSubtractIndexFood.Location.X, 5);
            tbIndexFood.Text = "1";
            tbIndexFood.TextChanged += new EventHandler(tbIndexFood_Change);
            tbIndexFood.Leave += new EventHandler(tbIndexFood_Leave);

            btPlusIndexFood.Size = new Size(this.Size.Height, this.Size.Height);
            btPlusIndexFood.Location = new Point(tbIndexFood.Location.X + tbIndexFood.Size.Width,0) ;
            btPlusIndexFood.Text = "+";
            btPlusIndexFood.Click += new EventHandler(btPlusIndexFood_Click);
           

            btDelete.Size = new Size(this.Size.Height, this.Size.Height);
            btDelete.Location = new Point(btPlusIndexFood.Location.X + btPlusIndexFood.Size.Width,0) ;
            btDelete.Text = "x";
            btDelete.Click += new EventHandler(btDelete_Click);
        }
        void btSubtract_Click(object sender,EventArgs args)
        {
            int temp = Int32.Parse(tbIndexFood.Text);
            if (temp > 1)
            {
                temp--;
                tbIndexFood.Text = temp.ToString();
                this.index = temp.ToString();
                formQLBan.SaveListFood();
            }
        }
        void tbIndexFood_Change(object sender,EventArgs args)
        {
            String S = tbIndexFood.Text;
            int pos = S.Length;
            for (int i = 0; i < S.Length; i++)
            {
                if (!(S[i] >= '0' && S[i] <= '9'))
                {
                    S = S.Remove(i, 1);
                    pos = i;
                    break;
                }
            }
            index = tbIndexFood.Text = S;
            tbIndexFood.SelectionStart = pos;
            formQLBan.SaveListFood();
        }
        void tbIndexFood_Leave(object sender,EventArgs args)
        {
            if (tbIndexFood.Text == "")
                tbIndexFood.Text = "1";
            formQLBan.SaveListFood();
        }
        void btPlusIndexFood_Click(object sender, EventArgs args)
        {
            int temp = Int32.Parse(tbIndexFood.Text);
            //if (temp < 99)
            {
                temp++;
                tbIndexFood.Text = temp.ToString();
                this.index = temp.ToString();
                formQLBan.SaveListFood();
            }
        }      
        void btDelete_Click(object sender, EventArgs args)
        {
            formQLBan.DeleteFoodInList(name);
            formQLBan.SaveListFood();
        }
    }
}
