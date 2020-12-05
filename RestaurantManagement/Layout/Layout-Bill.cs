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
    public partial class Bill : Form
    {
        void ReSize()
        {
            int sWidth = SystemInformation.VirtualScreen.Width;
            int sHeight = SystemInformation.VirtualScreen.Height;
            Size sScreen = new Size(sWidth, sHeight);

            float heightFont = sScreen.Height / 48;
            this.Size = new Size((int)(sScreen.Width / 4f), (int)(sScreen.Height / 10 *8));

            fpFoods.Size = new Size(this.Width, this.Width);
            fpFoods.Location = new Point(0, this.Height / 18);

            lbSumAll.StateCommon.ShortText.Font = new Font("Times New Roman", heightFont / 1.2f);
            lbSumAll.Location = new Point(fpFoods.Width / 2 - lbSumAll.Width / 2, fpFoods.Location.Y + fpFoods.Height);

            lbDiscount.StateCommon.ShortText.Font = new Font("Times New Roman", heightFont / 1.2f);
            lbDiscount.Location = new Point(this.Width / 3 - lbDiscount.Width, lbSumAll.Location.Y + lbSumAll.Height * 2);

            tbValue.Font = new Font("Times New Roman", heightFont / 1.2f);
            tbValue.Size = new Size(this.Width / 4, this.Width / 4 / 3);
            tbValue.Location = new Point(lbDiscount.Location.X + lbDiscount.Width + lbDiscount.Width / 5 * 1, lbDiscount.Location.Y);

            cbType.Font = new Font("Times New Roman", heightFont / 1.5f);
            cbType.Size = tbValue.Size;
            cbType.Location = new Point(tbValue.Location.X + lbDiscount.Width + lbDiscount.Width / 5 * 1, lbDiscount.Location.Y);

            lbTotal.Font = lbSumAll.Font;
            lbTotal.Size = lbSumAll.Size;
            lbTotal.Location = new Point(fpFoods.Width / 2 - lbTotal.Width / 2, tbValue.Location.Y + tbValue.Height + tbValue.Height / 2);

            btComfirm.Font = tbValue.Font;
            btComfirm.Size = tbValue.Size;
            btComfirm.Location = new Point(tbValue.Location.X, lbTotal.Location.Y +tbValue.Height + tbValue.Height / 2);
        }
    }
}
