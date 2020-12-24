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
    public partial class SignupForm : Form
    {
        void ReSize()
        {
            int sWidth = SystemInformation.VirtualScreen.Width;
            int sHeight = SystemInformation.VirtualScreen.Height;
            Size sScreen = new Size(sWidth, sHeight);
            //sScreen = new Size(600, 330);

            this.Size = new Size(sScreen.Width / 2, (int)(sScreen.Height));

            float heightFont = sScreen.Height / 48f;

            // Pannel tiêu đề
            pnTitle.Location = new Point(0, 0);
            pnTitle.Size = new Size(this.Size.Width, this.Size.Height / 5);

            pbImage.Size = new Size(pnTitle.Size.Height, pnTitle.Size.Height);
            pbImage.Location = new Point(0, 0);

            lbTitle.Font = new Font("Times New Roman", pnTitle.Height / 3 / 1.51f);
            lbTitle.Location = new Point(pnTitle.Size.Width / 2 - lbTitle.Size.Width / 2, pnTitle.Size.Height / 2 - lbTitle.Height / 2);

            // Pannel thông tin

            pnInfor.Size = new Size(this.Size.Width, this.Size.Height - pnTitle.Height);
            pnInfor.Location = new Point(0, pnTitle.Size.Height);

            lbSFname.Font = new Font("Times New Roman", heightFont / 1.51f);
            lbSFname.Location = new Point(lbSFname.Width/5, lbSFname.Height);

            tbSFname.Font = new Font("Times New Roman", heightFont / 1.51f);
            tbSFname.Size = new Size(this.Width / 2,lbSFname.Height);
            tbSFname.Location = new Point(this.Width - this.Width / 3 * 2, lbSFname.Location.Y);

            lbSPnumber.Font = new Font("Times New Roman", heightFont / 1.51f);
            lbSPnumber.Location = new Point(lbSFname.Location.X, lbSFname.Location.Y + tbSFname.Height / 6 * 8);

            tbSPnumber.Font = new Font("Times New Roman", heightFont / 1.51f);
            tbSPnumber.Size = tbSFname.Size;
            tbSPnumber.Location = new Point(this.Width - this.Width / 3 * 2, lbSPnumber.Location.Y);

            lbSAddress.Font = new Font("Times New Roman", heightFont / 1.51f);
            lbSAddress.Location = new Point(lbSFname.Location.X, lbSPnumber.Location.Y + tbSFname.Height / 6 * 8);

            tbSAddress.Font = new Font("Times New Roman", heightFont / 1.51f);
            tbSAddress.Size = tbSFname.Size;
            tbSAddress.Location = new Point(this.Width - this.Width / 3 * 2, lbSAddress.Location.Y);

            lbSDoB.Font = new Font("Times New Roman", heightFont / 1.51f);
            lbSDoB.Location = new Point(lbSFname.Location.X, lbSAddress.Location.Y + tbSFname.Height / 6 * 8);

            tbSDoB.Font = new Font("Times New Roman", heightFont / 1.51f);
            tbSDoB.Size = tbSFname.Size;
            tbSDoB.Location = new Point(this.Width - this.Width / 3 * 2, lbSDoB.Location.Y);

            lbSICnumber.Font = new Font("Times New Roman", heightFont / 1.51f);
            lbSICnumber.Location = new Point(lbSFname.Location.X, lbSAddress.Location.Y + tbSFname.Height / 6 * 8);

            tbSICnumber.Font = new Font("Times New Roman", heightFont / 1.51f);
            tbSICnumber.Size = tbSFname.Size;
            tbSICnumber.Location = new Point(this.Width - this.Width / 3 * 2, lbSAddress.Location.Y);

            lbSEmail.Font = new Font("Times New Roman", heightFont / 1.51f);
            lbSEmail.Location = new Point(lbSFname.Location.X, lbSICnumber.Location.Y + tbSFname.Height / 6 * 8);

            tbSEmail.Font = new Font("Times New Roman", heightFont / 1.51f);
            tbSEmail.Size = tbSFname.Size;
            tbSEmail.Location = new Point(this.Width - this.Width / 3 * 2, lbSEmail.Location.Y);

            lbUser.Font = new Font("Times New Roman", heightFont / 1.51f);
            lbUser.Location = new Point(lbSFname.Location.X, lbSEmail.Location.Y + tbSFname.Height / 6 * 8);

            tbUsername.Font = new Font("Times New Roman", heightFont / 1.51f);
            tbUsername.Size = tbSFname.Size;
            tbUsername.Location = new Point(this.Width - this.Width / 3 * 2, lbUser.Location.Y);

            lbPass.Font = new Font("Times New Roman", heightFont / 1.51f);
            lbPass.Location = new Point(lbUser.Location.X, tbUsername.Location.Y + +tbSFname.Height / 6 * 8);

            tbPassword.Font = new Font("Times New Roman", heightFont / 1.51f);
            tbPassword.Size = tbSFname.Size;
            tbPassword.Location = new Point(this.Width - this.Width / 3 * 2, lbPass.Location.Y );

            lbRePass.Font = new Font("Times New Roman", heightFont / 1.51f);
            lbRePass.Location = new Point(lbPass.Location.X, tbPassword.Location.Y+ tbSFname.Height / 6 * 8);

            tbRepassword.Font = new Font("Times New Roman", heightFont / 1.51f);
            tbRepassword.Size = tbSFname.Size;
            tbRepassword.Location = new Point(this.Width - this.Width / 3 * 2, lbRePass.Location.Y);

            btExit.StateCommon.Content.ShortText.Font = new Font("Times New Roman", heightFont / 1.5f);
            btExit.Size = new Size(tbPassword.Width / 3, (int)(tbPassword.Height * 1.3f));
            btExit.Location = new Point(tbRepassword.Location.X + btExit.Width / 4, tbRepassword.Location.Y + tbRepassword.Height + btExit.Height / 2);

            btSignup.StateCommon.Content.ShortText.Font = new Font("Times New Roman", heightFont / 1.5f);
            btSignup.Size = new Size(tbPassword.Width / 3, (int)(tbPassword.Height * 1.3f));
            btSignup.Location = new Point(btExit.Location.X + btExit.Width + btExit.Width / 2, btExit.Location.Y);
        }
    }
    }
