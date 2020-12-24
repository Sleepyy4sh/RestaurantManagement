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
    public partial class AddFood : Form
    {
        void ReSize()
        {
            int sWidth = SystemInformation.VirtualScreen.Width;
            int sHeight = SystemInformation.VirtualScreen.Height;
            Size sScreen = new Size(sWidth, sHeight);
            //sScreen = new Size(600, 330);

            //this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(sScreen.Width / 2, (int)(sScreen.Height / 7.5f * 5));
            float heightFont = sScreen.Height / 48;

            pictureBox2.Size = new Size(this.Height / 5, this.Height / 5);
            lbName.StateCommon.ShortText.Font  = new Font("Times New Roman", heightFont / 1.2f);
            lbName.Location = new Point(this.Width / 4, this.Height / 8);

            tbName.StateActive.Content.Font = new Font("Times New Roman", heightFont / 1.2f);
            tbName.Size = new Size((int)(this.Width / 2.5f), 0);
            tbName.Location = new Point(lbName.Location.X + lbName.Width +lbName.Width/3 , lbName.Location.Y);

            lbPrice.StateCommon.ShortText.Font = new Font("Times New Roman", heightFont / 1.2f);
            lbPrice.Location = new Point(lbName.Location.X, lbName.Location.Y + lbName.Height + lbName.Height / 2);

            tbPrice.StateActive.Content.Font = new Font("Times New Roman", heightFont / 1.2f);
            tbPrice.Size = new Size((int)(this.Width / 2.5f), 0);
            tbPrice.Location = new Point(tbName.Location.X , lbPrice.Location.Y);

            lbVND.StateCommon.ShortText.Font = new Font("Times New Roman", heightFont / 1.2f);
            lbVND.Location = new Point(tbPrice.Location.X + tbPrice.Width + 5, tbPrice.Location.Y);

            lbImage.StateCommon.ShortText.Font = new Font("Times New Roman", heightFont / 1.2f);
            lbImage.Location = new Point(lbPrice.Location.X, this.Height / 2 - lbImage.Height);

            pictureBox1.Size = new Size(this.Height / 4, this.Height / 5);
            pictureBox1.Location = new Point(tbName.Location.X + tbName.Width / 2 - pictureBox1.Width / 2, lbImage.Location.Y - pictureBox1.Height / 2);

            bBrowser.StateCommon.Content.ShortText.Font = new Font("Times New Roman", heightFont / 1.5f);
            bBrowser.Size = new Size(pictureBox1.Width / 3 * 2, pictureBox1.Width / 3 * 2 / 5 * 2);
            bBrowser.Location = new Point(pictureBox1.Location.X + pictureBox1.Width / 2 - bBrowser.Width / 2,pictureBox1.Location.Y + pictureBox1.Height);

            bAdd.StateCommon.Content.ShortText.Font = new Font("Times New Roman", heightFont / 1.2f);
            bAdd.Size = new Size(pictureBox1.Width / 4 * 3, pictureBox1.Width / 4 * 3 / 5 * 3);
            bAdd.Location = new Point(pictureBox1.Location.X + pictureBox1.Width / 2 - bAdd.Width / 2, bBrowser.Location.Y + bBrowser.Height *2);

            btExit.StateCommon.Content.ShortText.Font = new Font("Times New Roman", heightFont / 1.2f);
            btExit.Size = new Size(pictureBox1.Width / 4 * 3, pictureBox1.Width / 4 * 3 / 5 * 3);
            btExit.Location = new Point(lbName.Location.X, bBrowser.Location.Y + bBrowser.Height * 2);

            cbIsFood.Font = new Font("Times New Roman", heightFont / 1.5f);
            cbIsFood.Size = bBrowser.Size;
            cbIsFood.Location = new Point(tbName.Location.X, tbName.Location.Y - tbName.Height / 2 * 3 );
            cbIsFood.SelectedIndex = 0;
        }
    }
}
