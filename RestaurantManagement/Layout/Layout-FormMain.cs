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
    public partial class FormMain : Form
    {
        void ReSize()
        {
            int sWidth = SystemInformation.VirtualScreen.Width;
            int sHeight = SystemInformation.VirtualScreen.Height;
            Size sScreen = new Size(sWidth, sHeight);
           // sScreen = new Size(600, 330);

            float heightFont = sScreen.Height / 48f;

            this.Size = sScreen;
            this.MaximumSize = this.MinimumSize = sScreen;
            this.WindowState = FormWindowState.Maximized;

            this.Location = new Point(this.Width / 2, this.Height / 2);

            pictureBox1.Size = new Size(this.Size.Width, this.Size.Height / 11);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            Navigator.Location = new Point(0, pictureBox1.Size.Height - 5);
            Navigator.StateCommon.Tab.Content.ShortText.Font = new Font("Times New Roman", heightFont / 1.5f);
            // MessageBox.Show(Navigator.Font.Size.ToString());
            //MessageBox.Show(Navigator.StateCommon.Tab.Content.ShortText.Font.Size.ToString());
            Navigator.AutoSize = false;
            Navigator.Size = new Size(this.Size.Width - 0, this.Size.Height);
            Navigator.Bar.ItemMaximumSize = new Size(9999, 9999);
             Navigator.Bar.ItemMinimumSize = new Size(Navigator.Size.Width / 5, this.Height / 15);
            Navigator.Bar.ItemMaximumSize = Navigator.Bar.ItemMinimumSize;
            Navigator.Bar.ResetBarMapImage();

            // Quản lí bàn
            pageQLBan.Size = new Size(this.Size.Width, this.Size.Height - pictureBox1.Height - Navigator.Bar.ItemMinimumSize.Height);
            //pageQLBan.ImageLarge = pageQLBan.ImageLarge = pageQLBan.ImageMedium;

            fpTables.Size = new Size(this.Size.Width / 4 * 3, (int)((this.Size.Height - pictureBox1.Height - Navigator.Bar.ItemMinimumSize.Height) * 0.95f));


            fpTables.Location = new Point(0, 0);

            lbListFood.Font = new Font("Times New Roman", heightFont / 1f);
            fpListFood.Size = new Size((int)((this.Size.Width - fpTables.Size.Width) * 0.98f), (int)(fpTables.Size.Height / 10 * 9.5f));
            fpListFood.Location = new Point(fpTables.Size.Width +1, fpTables.Location.Y);

            btOrder.StateCommon.Content.ShortText.Font = new Font("Times New Roman", heightFont / 1.5f);
            btOrder.Size = new Size(fpListFood.Size.Width / 3, fpTables.Size.Height - fpListFood.Size.Height);
            btOrder.Location = new Point(fpListFood.Location.X, fpListFood.Location.Y + fpListFood.Size.Height + 0);

            btPay.StateCommon.Content.ShortText.Font = new Font("Times New Roman", heightFont / 1.5f);
            btPay.Size = btOrder.Size;
            btPay.Location = new Point(fpListFood.Location.X + fpListFood.Size.Width - btPay.Size.Width, btOrder.Location.Y);

            // // Quản lí Menu
            pageQLMenu.ImageSmall = pageQLMenu.ImageMedium = pageQLMenu.ImageLarge = Image.FromFile("images/menu_icon.png");


            fpFoods.Size = fpTables.Size;
            fpFoods.Location = new Point(0, 0);

            Size sizeOptions = new Size(pageQLBan.Size.Width - fpFoods.Size.Width, fpFoods.Size.Height);

            tbSearch.StateActive.Content.Font = new Font("Times New Roman", heightFont / 1.0f);
            tbSearch.Size = new Size(sizeOptions.Width / 2, sizeOptions.Width / 3 / 3);
            tbSearch.Location = new Point(fpFoods.Location.X + fpFoods.Size.Width + sizeOptions.Width / 2 - tbSearch.Size.Width / 2, tbSearch.Height);

            btSearch.StateCommon.Content.ShortText.Font = new Font("Times New Roman", heightFont / 1.5f);
            btSearch.Size = new Size(sizeOptions.Width / 3, sizeOptions.Width / 3 / 3);
            btSearch.Location = new Point(fpFoods.Location.X + fpFoods.Size.Width + sizeOptions.Width / 2 - btSearch.Size.Width / 2 ,tbSearch.Location.Y + tbSearch.Size.Height );

            btFix.StateCommon.Content.ShortText.Font = new Font("Times New Roman", heightFont / 1.5f);
            btFix.Size = new Size(sizeOptions.Width / 2, sizeOptions.Width / 2 / 3);
            btFix.Location = new Point(fpFoods.Location.X + fpFoods.Size.Width + sizeOptions.Width / 2 - btFix.Size.Width / 2, sizeOptions.Height - btFix.Size.Height);

            btAddFood.StateCommon.Content.ShortText.Font = new Font("Times New Roman", heightFont / 1.5f);
            btAddFood.Size = btFix.Size;
            btAddFood.Location = new Point(btFix.Location.X, btFix.Location.Y - btFix.Size.Height );
        }
    }
}
