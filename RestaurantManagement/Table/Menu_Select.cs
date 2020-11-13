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
        public Menu_Select()
        {
            InitializeComponent();
            data = new DataFood_ReadOnly(this);
            data.ReadDATA();
        }
        public void Add(string name, string price, Byte[] url)
        {
            Food_Select f = new Food_Select();
            f.Set(url, name, price);
            f.SetParent(this);
            f.SetTransform(150, 210, 0, 0);
            this.flowLayoutPanel1.Controls.Add(f);
        }
    }
}
