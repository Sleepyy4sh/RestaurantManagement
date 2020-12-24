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
    public partial class AddTable : Form
    {
        void ReSize()
        {
            int sWidth = SystemInformation.VirtualScreen.Width;
            int sHeight = SystemInformation.VirtualScreen.Height;
            Size sScreen = new Size(sWidth, sHeight);

            //this.FormBorderStyle = FormBorderStyle.None;
            float heightFont = sScreen.Height / 48;
            this.Size = new Size(sScreen.Width / 7 * 3, (int)(sScreen.Height / 3f));

            lbName.StateCommon.ShortText.Font = new Font("Times New Roman", heightFont / 1.3f);
            lbName.Location = new Point(this.Width / 2 - lbName.Width / 2, this.Height / 3 - lbName.Height);

            tbName.StateActive.Content.Font = new Font("Times New Roman", heightFont / 1.3f);
            tbName.Size = new Size(this.Width / 2, 0) ;
            tbName.Location = new Point(this.Width / 2 - tbName.Width / 2, this.Height / 2 - tbName.Height );

            btAdd.StateCommon.Content.ShortText.Font = new Font("Times New Roman", heightFont / 1.3f);
            btAdd.Size = new Size(this.Width / 7, this.Width / 7 / 5*2);
            btAdd.Location = new Point(this.Width / 2 - btAdd.Width / 2, tbName.Location.Y + tbName.Height);
        }
    }
}
