using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Data.SqlClient;

namespace RestaurantManagement
{
    public partial class FormChangeInfo : Form
    {
        void ReSize()
        {
            int sWidth = SystemInformation.VirtualScreen.Width;
            int sHeight = SystemInformation.VirtualScreen.Height;
            Size sScreen = new Size(sWidth, sHeight);
            //sScreen = new Size(600, 330);

            this.Size = new Size(sScreen.Width / 2, (int)(sScreen.Height/1.5f));
            this.StartPosition = FormStartPosition.CenterScreen;

            float heightFont = sScreen.Height / 48f;

            // Pannel thông tin
            lbTitle.Font = new Font("Times New Roman", heightFont / 0.5f);
            lbTitle.Location = new Point(this.Width / 2 - lbTitle.Width / 2);

            lbSFname.Font = new Font("Times New Roman", heightFont /1.2f);
            lbSFname.Location = new Point(lbSFname.Width / 5,lbTitle.Location.Y+ lbSFname.Height*4);

            tbSFname.Font = new Font("Times New Roman", heightFont /1.2f);
            tbSFname.Size = new Size(this.Width / 2, lbSFname.Height);
            tbSFname.Location = new Point(this.Width - this.Width / 3 * 2, lbSFname.Location.Y);

            lbSPnumber.Font = new Font("Times New Roman", heightFont /1.2f);
            lbSPnumber.Location = new Point(lbSFname.Location.X, lbSFname.Location.Y + tbSFname.Height /5 * 10);

            tbSPnumber.Font = new Font("Times New Roman", heightFont /1.2f);
            tbSPnumber.Size = tbSFname.Size;
            tbSPnumber.Location = new Point(this.Width - this.Width / 3 * 2, lbSPnumber.Location.Y);

            lbSAddress.Font = new Font("Times New Roman", heightFont /1.2f);
            lbSAddress.Location = new Point(lbSFname.Location.X, lbSPnumber.Location.Y + tbSFname.Height /5 * 10);

            tbSAddress.Font = new Font("Times New Roman", heightFont /1.2f);
            tbSAddress.Size = tbSFname.Size;
            tbSAddress.Location = new Point(this.Width - this.Width / 3 * 2, lbSAddress.Location.Y);

            lbSDoB.Font = new Font("Times New Roman", heightFont /1.2f);
            lbSDoB.Location = new Point(lbSFname.Location.X, lbSAddress.Location.Y + tbSFname.Height /5 * 10);

            tbSDoB.Font = new Font("Times New Roman", heightFont /1.2f);
            tbSDoB.Size = tbSFname.Size;
            tbSDoB.Location = new Point(this.Width - this.Width / 3 * 2, lbSDoB.Location.Y);

            lbSICnumber.Font = new Font("Times New Roman", heightFont /1.2f);
            lbSICnumber.Location = new Point(lbSFname.Location.X, lbSDoB.Location.Y + tbSFname.Height /5 * 10);

            tbSICnumber.Font = new Font("Times New Roman", heightFont /1.2f);
            tbSICnumber.Size = tbSFname.Size;
            tbSICnumber.Location = new Point(this.Width - this.Width / 3 * 2, lbSICnumber.Location.Y);

            lbSEmail.Font = new Font("Times New Roman", heightFont /1.2f);
            lbSEmail.Location = new Point(lbSFname.Location.X, lbSICnumber.Location.Y + tbSFname.Height /5 * 10);

            tbSEmail.Font = new Font("Times New Roman", heightFont /1.2f);
            tbSEmail.Size = tbSFname.Size;
            tbSEmail.Location = new Point(this.Width - this.Width / 3 * 2, lbSEmail.Location.Y);

            btExit.StateCommon.Content.ShortText.Font = new Font("Times New Roman", heightFont / 1.5f);
            btExit.Size = new Size(tbSEmail.Width / 3, (int)(tbSEmail.Height * 1.3f));
            btExit.Location = new Point(tbSEmail.Location.X + btExit.Width / 4, tbSEmail.Location.Y + tbSEmail.Height + btExit.Height / 2);

            btSaveInfo.StateCommon.Content.ShortText.Font = new Font("Times New Roman", heightFont / 1.5f);
            btSaveInfo.Size = new Size(tbSEmail.Width / 3, (int)(tbSEmail.Height * 1.3f));
            btSaveInfo.Location = new Point(btExit.Location.X + btExit.Width + btExit.Width / 2, btExit.Location.Y);

        }
    }
}
