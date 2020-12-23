using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RestaurantManagement
{
    public partial class Menu_Select : Panel
    {
        void ReSize()
        {
            int sWidth = SystemInformation.VirtualScreen.Width;
            int sHeight = SystemInformation.VirtualScreen.Height;
            Size sScreen = new Size(sWidth, sHeight);
            float heightFont = sScreen.Height / 48f;

            this.Location = new Point(0, 0);
            fpDrinkSelected.Size = fpFoodSelected.Size = new Size(this.Width, this.Height / 10 * 9);
            fpDrinkSelected.Location = fpFoodSelected.Location = new Point(0, 0);


            btFinished.Size = new Size(this.Width / 10, this.Height / 10);
            btFinished.Font = new Font("Times New Roman", heightFont / 1.5f);
            btFinished.Location = new Point(this.Width / 2 - btFinished.Size.Width / 2, this.Height / 10 * 9);

            cbIsFood.Font = new Font("Times New Roman", heightFont / 1.5f);
            cbIsFood.Size = btFinished.Size;
            cbIsFood.Location = new Point(0, btFinished.Location.Y);
            cbIsFood.DropDownStyle = ComboBoxStyle.DropDownList;
            cbIsFood.SelectedIndex = 0;

            tbSearch.Size = new Size(cbIsFood.Size.Width/2*3,cbIsFood.Height);
            tbSearch.Font = new Font("Times New Roman", heightFont / 1.9f);
            tbSearch.Location = new Point(cbIsFood.Width / 2 * 3, btFinished.Location.Y + btFinished.Height / 2 - tbSearch.Height / 2);

            btSearch.Size = btFinished.Size;
            btSearch.Font = new Font("Times New Roman", heightFont / 1.5f);
            btSearch.Location = new Point(tbSearch.Location.X+tbSearch.Width, this.Height / 10 * 9);

            PictureBox btReFresh = new PictureBox(); 
            btReFresh.Image = Image.FromFile("images/refresh.jpg");
            btReFresh.SizeMode = PictureBoxSizeMode.Zoom;
            btReFresh.Size = new Size(tbSearch.Height, tbSearch.Height);
            btReFresh.Location = new Point(cbIsFood.Location.X, cbIsFood.Location.Y + btReFresh.Height);
            btReFresh.Click += new EventHandler(btReFresh_Click);

            this.Controls.Add(cbIsFood);
            this.Controls.Add(tbSearch);
            this.Controls.Add(btSearch);
            this.Controls.Add(btReFresh);
            fpDrinkSelected.Hide();
            fpFoodSelected.Show();
        }
    }
}
