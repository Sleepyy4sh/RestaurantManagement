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
    public partial class Menu_Select : Form
    {
        DataFood_ReadOnly data;
        FormMain formQLMenu;
        public Menu_Select(FormMain formQL)
        {
            InitializeComponent();
            formQLMenu = formQL;
            data = new DataFood_ReadOnly(this);
            data.ReadDATA();
        }
        List<Food_Select> foods = new List<Food_Select>(); 
        public void Add(string name, string price, Byte[] url)
        {
            Food_Select f = new Food_Select(formQLMenu);
            foods.Add(f);
            f.name = name;
            f.Set(url, name, price);
            f.SetParent(this);
            f.SetTransform(150, 210, 0, 0);
            this.flowLayoutPanel1.Controls.Add(f);
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
            this.Close();
        }
    }
}
