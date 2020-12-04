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

            this.Size = sScreen;
            this.MaximumSize = this.MinimumSize = sScreen;
            this.WindowState = FormWindowState.Maximized;
            MessageBox.Show(sScreen.ToString());
            // Quản lí bàn
            this.pageQLBan.Size = new Size(this.Size.Width, this.Size.Height / 4 * 3); 

            //fpTables.Size = new Size(this.Size.Width / 4 * 3, this.Size.Height / 4 * 3);
            MessageBox.Show(fpTables.Size.ToString());
            fpTables.Location = new Point(0, 0);

            fpListFood.Location = new Point(fpTables.Size.Width + 5, fpTables.Location.Y);
            fpListFood.Size = new Size(this.Size.Width - fpTables.Size.Width - 10, fpTables.Size.Height / 10 * 8);

            btOrder.Location = new Point(fpListFood.Location.X, fpListFood.Location.Y + fpListFood.Size.Height + 0);
            btPay.Location = new Point(fpListFood.Location.X+fpListFood.Size.Width-btPay.Size.Width, btOrder.Location.Y);

        }
    }
}
