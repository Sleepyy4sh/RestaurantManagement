﻿using System;
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
    public partial class LoginForm : Form
    {
        void ReSize()
        {
            int sWidth = SystemInformation.VirtualScreen.Width;
            int sHeight = SystemInformation.VirtualScreen.Height;
            Size sScreen = new Size(sWidth, sHeight);
            //sScreen = new Size(600, 330);

            this.Size = new Size(sScreen.Width / 2, (int)(sScreen.Height / 1.345f));

            // Pannel tiêu đề
            float heightFont = sScreen.Height / 48f;

            //MessageBox.Show(sScreen.Height.ToString() + " " + lbUser.Font.Height.ToString());
            pnTitle.Location = new Point(0, 0);
            pnTitle.Size = new Size(this.Size.Width, this.Size.Height / 4);

            pbImage.Size = new Size(pnTitle.Size.Height, pnTitle.Size.Height);
            pbImage.Location = new Point(0, 0);

            lbTitle.Font = new Font("Times New Roman", pnTitle.Height / 3 / 1.51f);
            lbTitle.Location = new Point(pnTitle.Size.Width / 2 - lbTitle.Size.Width / 2, pnTitle.Size.Height / 2 - lbTitle.Height / 2);


            // Pannel thông tin
            pnInfor.Size = new Size(this.Size.Width, this.Size.Height - pnTitle.Height);
            pnInfor.Location = new Point(0, pnTitle.Size.Height);

            lbUser.Font = new Font("Times New Roman", heightFont / 1.51f);
            lbUser.Location = new Point(pnInfor.Width / 5, pnInfor.Height / 6);

            tbUsername.StateActive.Content.Font = new Font("Times New Roman", heightFont / 1.0f);
            tbUsername.Size = new Size(pnInfor.Width / 5 * 3, pnInfor.Height / 10);
            tbUsername.Location = new Point(lbUser.Location.X, lbUser.Location.Y + lbUser.Height );

            lbPass.Font = new Font("Times New Roman", heightFont / 1.51f);
            lbPass.Location = new Point(tbUsername.Location.X, tbUsername.Location.Y + tbUsername.Height + lbUser.Height*3);

            tbPassword.StateActive.Content.Font = new Font("Times New Roman", heightFont / 1.0f);
            tbPassword.Size = new Size(pnInfor.Width / 5 * 3, pnInfor.Height / 10);
            tbPassword.Location = new Point(lbPass.Location.X, lbPass.Location.Y + lbPass.Height );

            // btSignup.StateCommon.Content.ShortText.Font = new Font("Times New Roman", heightFont / 1.5f);
            // btSignup.Size = 
            // btSignup.Location = 

            btLogin.StateCommon.Content.ShortText.Font = new Font("Times New Roman", heightFont / 1.5f);
            btLogin.Size = new Size(tbPassword.Width / 3, (int)(tbPassword.Height * 1.3f));
            btLogin.Location = new Point(pnInfor.Width/2-btLogin.Width/2, tbPassword.Location.Y + tbPassword.Height + btLogin.Height / 2);
        }
    }
}
