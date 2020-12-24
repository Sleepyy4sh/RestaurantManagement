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
    public partial class Menu_Select : Panel
    {
        DataFood_ReadOnly data;
        FormMain formQLMenu;
        public Menu_Select(FormMain formQL,Size size)
        {
            InitializeComponent();
            formQLMenu = formQL;
            this.Size = size;
            this.Location = new Point(0, 0);
            ReSize();
            InitFood();
        }
        void InitFood()
        {
            fpFoodSelected.Controls.Clear();
            fpDrinkSelected.Controls.Clear();
            data = new DataFood_ReadOnly(this);
            data.ReadDATA();
        }
        List<Food_Select> foods = new List<Food_Select>(); 
        public void Add(string name, string price, Byte[] url,int isfood)
        {
            Food_Select f = new Food_Select(formQLMenu);
            foods.Add(f);
            f.name = name;
            f.Set(url, name, price,isfood);
            f.SetParent(this);
            int scale = 5;
            f.SetTransform(this.Width/scale -3, (this.Width/scale-3)/5*7, 0, 0);
            if (f.isFood==0)
                this.fpFoodSelected.Controls.Add(f);
            else
                this.fpDrinkSelected.Controls.Add(f);
            if (formQLMenu.InList(f.name))
            {
                f.Tick();
                //MessageBox.Show(f.name);
            }
            else;
            // f.UnTick();
        }
        public void UnTick(string name)
        {
            for (int i=0;i<foods.Count;i++)
            {
                if (foods[i].name == name) ;
                    foods[i].UnTick();
            }    
        }
        public void Tick(string name)
        {
            for (int i = 0; i < foods.Count; i++)
            {
                if (foods[i].name == name)
                    foods[i].Tick();
            }
        }

        private void Menu_Select_FormClosed(object sender, FormClosedEventArgs e)
        {
            //formQLMenu.UnSelectTable();
        }

        private void btFinished_Click(object sender, EventArgs e)
        {
            this.Hide();
            formQLMenu.fpTables.Show();
        }
        private void btFood_Click(object sender, EventArgs e)
        {
            fpFoodSelected.Show();
            fpDrinkSelected.Hide();
        }

        private void btDrink_Click(object sender, EventArgs e)
        {
            fpFoodSelected.Hide();
            fpDrinkSelected.Show();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            CheckSearch();
        }
        void CheckSearch()
        {
           fpFoodSelected.Controls.Clear();
            //Xóa mấy dấu cách nhập thừa
            tbSearch.Text = ChuanHoa(tbSearch.Text);
            // Không nhập gì thì hiện hết
            if (tbSearch.Text == "")
                ShowAll();
            else
            {
                Search(tbSearch.Text);
            }
        }
        void ShowAll()
        {
            for (int i = 0; i < foods.Count; i++)
            {
                if (foods[i].isFood == 0)
                   fpFoodSelected.Controls.Add(foods[i]);
                else
                   fpDrinkSelected.Controls.Add(foods[i]);
            }
        }
        void Search(string child)
        {
            for (int i = 0; i < foods.Count(); i++)
            {
                if (IsChild(child, foods[i].GetName()))
                {
                    if (foods[i].isFood == 0)
                       fpFoodSelected.Controls.Add(foods[i]);
                    else
                       fpDrinkSelected.Controls.Add(foods[i]);
                }
            }
        }
        bool IsChild(string child, string parent)
        {
            if (parent.Length >= child.Length)
                for (int i = 0; i < parent.Count() - child.Length + 1; i++)
                {
                    if (parent.Substring(i, child.Length) == child)
                    {
                        return true;
                    }
                }
            return false;
        }
        string ChuanHoa(string S)
        {
            while (S.Length > 0 && S[0] == ' ')
            {
                Console.WriteLine(S);
                S = S.Remove(0, 1);
            };
            while (S.Length > 0 && S[S.Length - 1] == ' ')
            {
                S = S.Remove(S.Length - 1, 1);
            };
            for (int i = 0; i < S.Length - 1; i++)
            {
                while (S[i] == S[i + 1] & S[i + 1] == ' ')
                {
                    S = S.Remove(i + 1, 1);
                }
            }
            return S;
        }
        private void btReFresh_Click(object sender, EventArgs e)
        {
            InitFood();
        }

    }
}
