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
    public partial class FormChangePass : Form
    {
        void ReSize()
        {
            int sWidth = SystemInformation.VirtualScreen.Width;
            int sHeight = SystemInformation.VirtualScreen.Height;
            Size sScreen = new Size(sWidth, sHeight);
            //sScreen = new Size(600, 330);

            this.Size = new Size(sScreen.Width / 2, (int)(sScreen.Height)/2);
            this.StartPosition = FormStartPosition.CenterScreen;

            float heightFont = sScreen.Height / 48f;
            lbCurPass.Font = new Font("Times New Roman", heightFont / 1.2f);
            lbCurPass.Location = new Point(lbCurPass.Width / 5,lbCurPass.Height * 2);

            tbCurPass.Font = new Font("Times New Roman", heightFont / 1.2f);
            tbCurPass.Size = new Size(this.Width / 2, lbCurPass.Height);
            tbCurPass.Location = new Point(this.Width - this.Width / 3 * 2, lbCurPass.Location.Y);

            lbNewPass.Font = new Font("Times New Roman", heightFont / 1.2f);
            lbNewPass.Location = new Point(lbCurPass.Location.X, lbCurPass.Location.Y + tbCurPass.Height / 5 * 10);

            tbNewPass.Font = new Font("Times New Roman", heightFont / 1.2f);
            tbNewPass.Size = tbCurPass.Size;
            tbNewPass.Location = new Point(this.Width - this.Width / 3 * 2,lbNewPass.Location.Y);

            lbRePass.Font = new Font("Times New Roman", heightFont / 1.2f);
            lbRePass.Location = new Point(lbCurPass.Location.X,lbNewPass.Location.Y + tbCurPass.Height / 5 * 10);

            tbRePassword.Font = new Font("Times New Roman", heightFont / 1.2f);
            tbRePassword.Size = tbCurPass.Size;
            tbRePassword.Location = new Point(this.Width - this.Width / 3 * 2, lbRePass.Location.Y);

            btExit.StateCommon.Content.ShortText.Font = new Font("Times New Roman", heightFont / 1.5f);
            btExit.Size = new Size(tbRePassword.Width / 3, (int)(tbRePassword.Height * 1.3f));
            btExit.Location = new Point(tbRePassword.Location.X + btExit.Width / 4, tbRePassword.Location.Y + tbRePassword.Height + btExit.Height / 2);

           btChangePass.StateCommon.Content.ShortText.Font = new Font("Times New Roman", heightFont / 1.5f);
           btChangePass.Size = new Size(tbRePassword.Width / 3, (int)(tbRePassword.Height * 1.3f));
           btChangePass.Location = new Point(btExit.Location.X + btExit.Width + btExit.Width / 2, btExit.Location.Y);
        }
    }
}