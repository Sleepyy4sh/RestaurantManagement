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
            //this.TopMost = true;
            this.MaximumSize = this.MinimumSize = sScreen;
            this.WindowState = FormWindowState.Maximized;
            //  this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;

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
            fpTables.Size = new Size(this.Size.Width / 4 * 3, (int)((this.Size.Height - pictureBox1.Height - Navigator.Bar.ItemMinimumSize.Height) * 1f));


            fpTables.Location = new Point(0, 0);

            fpListFood.AutoScroll = fpFoods.AutoScroll = fpDrinks.AutoScroll  = fpTables.AutoScroll = true;
            lbListFood.Font = new Font("Times New Roman", heightFont / 1f);
            fpListFood.Size = new Size((int)((this.Size.Width - fpTables.Size.Width) * 0.98f), (int)(fpTables.Size.Height / 10 * 9.5f));
            fpListFood.Location = new Point(fpTables.Size.Width + 1, fpTables.Location.Y);

            btOrder.StateCommon.Content.ShortText.Font = new Font("Times New Roman", heightFont / 1.5f);
            btOrder.Size = new Size(fpListFood.Size.Width / 3, (int)((fpTables.Size.Height - fpListFood.Size.Height) * 0.9f));
            btOrder.Location = new Point(fpListFood.Location.X, fpListFood.Location.Y + fpListFood.Size.Height + btOrder.Height / 10);

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
            tbSearch.Location = new Point(fpFoods.Location.X + fpFoods.Size.Width + sizeOptions.Width / 2 - tbSearch.Size.Width / 2, tbSearch.Height * 3);

            btSearch.StateCommon.Content.ShortText.Font = new Font("Times New Roman", heightFont / 1.5f);
            btSearch.Size = new Size(sizeOptions.Width / 3, sizeOptions.Width / 3 / 3);
            btSearch.Location = new Point(fpFoods.Location.X + fpFoods.Size.Width + sizeOptions.Width / 2 - btSearch.Size.Width / 2, tbSearch.Location.Y + tbSearch.Size.Height);

            btFix.StateCommon.Content.ShortText.Font = new Font("Times New Roman", heightFont / 1.5f);
            btFix.Size = new Size(sizeOptions.Width / 2, sizeOptions.Width / 2 / 3);
            btFix.Location = new Point(fpFoods.Location.X + fpFoods.Size.Width + sizeOptions.Width / 2 - btFix.Size.Width / 2, sizeOptions.Height - btFix.Size.Height);

            btAddFood.StateCommon.Content.ShortText.Font = new Font("Times New Roman", heightFont / 1.5f);
            btAddFood.Size = btFix.Size;
            btAddFood.Location = new Point(btFix.Location.X, btFix.Location.Y - btFix.Size.Height - btAddFood.Height / 10);


            btFood.Size = btSearch.Size;
            new Font("Times New Roman", heightFont / 1.5f);
            btFood.Location = new Point(fpFoods.Location.X + fpFoods.Width, 0);

            btDrink.Size = btSearch.Size;
            new Font("Times New Roman", heightFont / 1.5f);
            btDrink.Location = new Point(fpFoods.Location.X + fpFoods.Width, btFood.Height);

            fpFoods.Show();
            fpDrinks.Hide();
            fpDrinks.Size = fpFoods.Size;
            fpDrinks.Location = fpFoods.Location;

            btReFresh.Image = Image.FromFile("images/refresh.jpg");
            btReFresh.SizeMode = PictureBoxSizeMode.Zoom;
            btReFresh.Size = new Size(tbSearch.Height, tbSearch.Height);
            btReFresh.Location = new Point(btFood.Location.X, btDrink.Location.Y + btDrink.Height);
            btReFresh.Click += new EventHandler(btReFresh_Click);

            btExit.StateCommon.Content.ShortText.Font = new Font("Times New Roman", heightFont / 1.5f);
            btExit.Size = new Size(pictureBox1.Height, pictureBox1.Height);
            btExit.Location = new Point(this.Width - btExit.Width, 0);
     
            // Page thông tin tài khoản
            pageTaiKhoan.Size = pageQLBan.Size;

            lbADetail.Font = new Font("Times New Roman", heightFont / 0.5f);
            lbADetail.Location = new Point(pageTaiKhoan.Width / 2 - lbADetail.Width + pageTaiKhoan.Width/20, lbADetail.Height);

            lbAUsername.Size = new Size(pageTaiKhoan.Width / 6 * 4, pageTaiKhoan.Height / 6 * 5);
            lbAUsername.Location = new Point(lbADetail.Location.X + lbADetail.Width / 2 - lbAUsername.Width / 2, lbADetail.Location.Y + lbADetail.Height);

            btUpdateAccount.Size = new Size(Navigator.Bar.ItemMaximumSize.Width /6 *5, Navigator.Bar.ItemMaximumSize.Height /2*3);
            btUpdateAccount.Location = new Point(lbAUsername.Location.X + lbAUsername.Width + btUpdateAccount.Width / 4, lbAUsername.Location.Y);


            btChangeInfo.Size = btUpdateAccount.Size;
            btChangeInfo.Location = new Point(btUpdateAccount.Location.X, btUpdateAccount.Location.Y + btUpdateAccount.Height + btUpdateAccount.Height / 2);

            btACPassword.Size = btUpdateAccount.Size;
            btACPassword.Location = new Point(btChangeInfo.Location.X, btChangeInfo.Location.Y + btUpdateAccount.Height + btUpdateAccount.Height / 2);

            btSignout.Size = btUpdateAccount.Size;
            btSignout.Location = new Point(btACPassword.Location.X, btACPassword.Location.Y + btUpdateAccount.Height + btUpdateAccount.Height / 2);

            btMasterSignout.Size = btUpdateAccount.Size;
            btMasterSignout.Location = new Point(btSignout.Location.X, btSignout.Location.Y + btUpdateAccount.Height + btUpdateAccount.Height / 2);

            lbTaiKhoan.Font = new Font("Times New Roman", heightFont / 0.8f);
            lbTaiKhoan.Location = new Point(lbAUsername.Width / 20, lbAUsername.Height / 9);

            lbTen.Font = lbTaiKhoan.Font;
            lbTen.Location = new Point(lbTaiKhoan.Location.X, lbTaiKhoan.Location.Y + lbTaiKhoan.Height * 2);
            


            lbNgaysinh.Font = lbTaiKhoan.Font;
            lbNgaysinh.Location = new Point(lbTen.Location.X, lbTen.Location.Y + lbTaiKhoan.Height * 2);

            lbDiaCHi.Font = lbTaiKhoan.Font;
            lbDiaCHi.Location = new Point(lbNgaysinh.Location.X, lbNgaysinh.Location.Y + lbTaiKhoan.Height * 2);

            lbSdt.Font = lbTaiKhoan.Font;
            lbSdt.Location = new Point(lbDiaCHi.Location.X, lbDiaCHi.Location.Y + lbTaiKhoan.Height * 2);

            lbCMNd.Font = lbTaiKhoan.Font;
            lbCMNd.Location = new Point(lbSdt.Location.X, lbSdt.Location.Y + lbTaiKhoan.Height * 2);

            lbMail.Font = lbTaiKhoan.Font;
            lbMail.Location = new Point(lbCMNd.Location.X, lbCMNd.Location.Y + lbTaiKhoan.Height * 2);


            lbUsername.Font = lbTaiKhoan.Font;
            lbUsername.Location = new Point(lbAUsername.Width / 7*3, lbTaiKhoan.Location.Y);

            lbFname.Font = lbTaiKhoan.Font;
            lbFname.Location = new Point(lbAUsername.Width / 7*3, lbTen.Location.Y);

            lbDoB.Font = lbTaiKhoan.Font;
            lbDoB.Location = new Point(lbAUsername.Width / 7*3, lbNgaysinh.Location.Y);

            lbAddress.Font = lbTaiKhoan.Font;
            lbAddress.Location = new Point(lbAUsername.Width / 7*3, lbDiaCHi.Location.Y);

            lbPnumber.Font = lbTaiKhoan.Font;
            lbPnumber.Location = new Point(lbAUsername.Width / 7*3, lbSdt .Location.Y);

            lbICnumber.Font = lbTaiKhoan.Font;
            lbICnumber.Location = new Point(lbAUsername.Width / 7*3, lbCMNd.Location.Y);

            lbEmail.Font = lbTaiKhoan.Font;
            lbEmail.Location = new Point(lbAUsername.Width / 7*3, lbMail.Location.Y);

            //PageQLNV
            pageQLNV.Size = new Size(this.Size.Width, this.Size.Height - pictureBox1.Height - Navigator.Bar.ItemMinimumSize.Height);
            float h = pageQLNV.Size.Height / 100;
            float w = pageQLNV.Size.Width / 100;

            cbSType.Font = new Font("Times New Roman", heightFont / 1.6f);
            cbSType.Size = new Size((int)w * 8, 0);
            cbSType.Location = new Point((int)w / 6, (int)h / 4);

            tbSSearch.Font = new Font("Times New Roman", heightFont / 1.4f);
            tbSSearch.Size = cbSType.Size;
            tbSSearch.Location = new Point(cbSType.Location.X, cbSType.Location.Y + cbSType.Size.Height + (int)h / 4);

            btSSearch.Font = cbSType.Font;
            btSSearch.Size = new Size(cbSType.Size.Width / 5 * 3, 0);
            btSSearch.Location = new Point(tbSSearch.Location.X + tbSSearch.Size.Width - btSSearch.Size.Width, tbSSearch.Location.Y + tbSSearch.Size.Height + (int)h / 3);

            dgStaff.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", heightFont / 1.5f);
            dgStaff.DefaultCellStyle.Font = new Font("Times New Roman", heightFont / 2.0f);
            dgStaff.Size = new Size((int)w * 70, pageQLNV.Size.Height - btSSearch.Location.Y - (int)h * 2);
            dgStaff.Location = new Point(-1, btSSearch.Location.Y + btSSearch.Size.Height + (int)h * 2);

            lbStaff.Font = new Font("Times New Roman", heightFont / 1.0f, FontStyle.Bold);
            lbStaff.Size = new Size((int)w * 15, 0);
            lbStaff.Location = new Point((int)w * 27, (int)h * 5);

            lbSDetail.Font = new Font("Times New Roman", heightFont / 1.0f, FontStyle.Bold);
            lbSDetail.Size = new Size((int)w * 15, 0);
            lbSDetail.Location = new Point((int)w * 79, (int)h * 15);

            //////
            int tw = (int)w * 85;
            int lw = (int)w * 73;
            int th = (int)h * 8 / 3;
            int lh = (int)h * 7 / 3;

            //Label

            lbSUser.StateCommon.ShortText.Font = lbSFname.StateCommon.ShortText.Font = lbSPnumber.StateCommon.ShortText.Font = lbSAddress.StateCommon.ShortText.Font = lbSDoB.StateCommon.ShortText.Font = lbSICnumber.StateCommon.ShortText.Font = lbSEmail.StateCommon.ShortText.Font = new Font("Times New Roman", heightFont / 1.4f);
            lbSUser.Size = lbSFname.Size = lbSPnumber.Size = lbSAddress.Size = lbSDoB.Size = lbSICnumber.Size = lbSEmail.Size = new Size((int)w * 1, 0);

            lbSUser.Location = new Point(lw, (int)h * 28);
            lbSFname.Location = new Point(lw, lbSUser.Location.Y + lbSUser.Size.Height + lh);
            lbSPnumber.Location = new Point(lw, lbSFname.Location.Y + lbSUser.Size.Height + lh);
            lbSAddress.Location = new Point(lw, lbSPnumber.Location.Y + lbSUser.Size.Height + lh);
            lbSDoB.Location = new Point(lw, lbSAddress.Location.Y + lbSUser.Size.Height + lh);
            lbSICnumber.Location = new Point(lw, lbSDoB.Location.Y + lbSUser.Size.Height + lh);
            lbSEmail.Location = new Point(lw, lbSICnumber.Location.Y + lbSUser.Size.Height + lh);

            //Textbox

            //tbSEmail.StateCommon.Content.Font = tbSUser.StateCommon.Content.Font = tbSFname.StateCommon.Content.Font = tbSPnumber.StateCommon.Content.Font = tbSAddress.StateCommon.Content.Font = tbSDoB.StateCommon.Content.Font = tbSICnumber.StateCommon.Content.font;  //new Font("Times New Roman", heightFont / 2.4f);
            tbSUser.Size = tbSFname.Size = tbSPnumber.Size = tbSAddress.Size = tbSDoB.Size = tbSICnumber.Size = tbSEmail.Size = new Size((int)w * 17, (int)h);

            tbSUser.Location = new Point(tw, (int)h * 28);
            tbSFname.Location = new Point(tw, tbSUser.Location.Y + tbSUser.Size.Height + th);
            tbSPnumber.Location = new Point(tw, tbSFname.Location.Y + tbSUser.Size.Height + th);
            tbSAddress.Location = new Point(tw, tbSPnumber.Location.Y + tbSUser.Size.Height + th);
            tbSDoB.Location = new Point(tw, tbSAddress.Location.Y + tbSUser.Size.Height + th);
            tbSICnumber.Location = new Point(tw, tbSDoB.Location.Y + tbSUser.Size.Height + th);
            tbSEmail.Location = new Point(tw, tbSICnumber.Location.Y + tbSUser.Size.Height + th);

            btSReg.StateCommon.Content.ShortText.Font = new Font("Times New Roman", heightFont / 1.8f);
            btSDelete.StateCommon.Content.ShortText.Font = new Font("Times New Roman", heightFont / 1.8f);
            btSUpdate.StateCommon.Content.ShortText.Font = new Font("Times New Roman", heightFont / 1.8f);

            btSReg.Size = btSUpdate.Size = btSDelete.Size = new Size((int)w * 8, (int)h * 6);

            btSReg.Location = new Point((int)w * 75, (int)h * 80);
            btSUpdate.Location = new Point(btSReg.Location.X + btSReg.Size.Width + (int)w, (int)h * 80);
            btSDelete.Location = new Point(btSUpdate.Location.X + btSUpdate.Size.Width + (int)w, (int)h * 80);


            //PageThongKe

            pageThongKe.Size = pageQLNV.Size;

            w = pageThongKe.Size.Width / 100;
            h = pageThongKe.Size.Height / 100;

            lbRType.StateCommon.ShortText.Font = new Font("Times New Roman", heightFont / 1.8f);
            lbRType.Size = new Size((int)w * 6, 0);
            lbRType.Location = new Point((int)w, (int)h * 2);

            cbRType.Font = new Font("Times New Roman", heightFont / 1.8f);
            cbRType.Size = new Size((int)w * 5, 0);
            cbRType.Location = new Point(lbRType.Location.X + lbRType.Size.Width + (int)w / 3 , (int)h * 2);

            lbRYear.StateCommon.ShortText.Font = lbRType.StateCommon.ShortText.Font;
            lbRYear.Size = lbRType.Size;
            lbRYear.Location = new Point(lbRType.Location.X, lbRType.Location.Y + lbRType.Size.Height + (int)h * 7 / 2);

            cbRYear.Font = cbRType.Font;
            cbRYear.Size = new Size((int)w * 4, 0);
            cbRYear.Location = new Point(lbRYear.Location.X + lbRYear.Size.Width + (int)w / 2, lbRType.Location.Y + lbRType.Size.Height + (int)h * 3);


            lbRMonth.StateCommon.ShortText.Font = lbRType.StateCommon.ShortText.Font;
            lbRMonth.Size = lbRType.Size;
            lbRMonth.Location = new Point(cbRYear.Location.X + cbRYear.Size.Width + (int)w / 2, lbRYear.Location.Y);

            cbRMonth.Font = cbRYear.Font;
            cbRMonth.Size = cbRType.Size;
            cbRMonth.Location = new Point(lbRMonth.Location.X + lbRMonth.Size.Width + (int)w /2, cbRYear.Location.Y);

            lbRDay.StateCommon.ShortText.Font = lbRType.StateCommon.ShortText.Font;
            lbRDay.Size = lbRType.Size;
            lbRDay.Location = new Point(cbRMonth.Location.X + cbRMonth.Size.Width + (int)w / 2, lbRYear.Location.Y);

            cbRDay.Font = cbRYear.Font;
            cbRDay.Size = cbRType.Size;
            cbRDay.Location = new Point(lbRDay.Location.X + lbRDay.Size.Width + (int)w / 2, cbRYear.Location.Y);

            btRWRevenue.StateCommon.Content.ShortText.Font = new Font("Times New Roman", heightFont / 1.8f);
            btRWBill.StateCommon.Content.ShortText.Font = new Font("Times New Roman", heightFont / 1.8f);
            btRUpdate.StateCommon.Content.ShortText.Font = new Font("Times New Roman", heightFont / 1.8f);

            btRWRevenue.Size = btRUpdate.Size = btRWBill.Size = new Size((int)w * 8, (int)h * 4);

            btRWRevenue.Location = new Point((int)w * 3 / 2, cbRDay.Location.Y + cbRDay.Size.Height + (int)h * 2);
            btRWBill.Location = new Point(btRWRevenue.Location.X + btRWRevenue.Size.Width + (int)w , btRWRevenue.Location.Y);
            btRUpdate.Location = new Point(btRWBill.Location.X + btRWBill.Size.Width + (int)w , btRWRevenue.Location.Y);

            dgRevenue.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", heightFont / 1.2f);
            dgRevenue.DefaultCellStyle.Font = new Font("Times New Roman", heightFont / 1.8f);
            dgRevenue.Size = new Size((int)w * 65, pageThongKe.Size.Height - btRWRevenue.Location.Y - btRWRevenue.Size.Height - (int)h);
            dgRevenue.Location = new Point(-1, btRWRevenue.Location.Y + btRWRevenue.Size.Height + (int)h * 2);

            lbRBDetail.Font = new Font("Times New Roman", heightFont / 0.9f);
            lbRBDetail.Size = new Size((int)w * 20, (int)h * 6);
            lbRBDetail.Location = new Point((int)w * 75, (int)h * 8);

            fpRBDetail.Size = new Size((int)w * 28, (int)h * 68);
            fpRBDetail.Location = new Point((int)w * 70, lbRBDetail.Location.Y + lbRBDetail.Size.Height + (int)h * 2);

            fpRBDTotal.Size = new Size((int)w * 20, pageThongKe.Size.Height - fpRBDetail.Location.Y - fpRBDetail.Size.Height);
            fpRBDTotal.Location = new Point(fpRBDetail.Location.X + fpRBDetail.Size.Width - fpRBDTotal.Size.Width, fpRBDetail.Location.Y + fpRBDetail.Size.Height);

            lbRBDCost.Font = new Font("Times New Roman", heightFont / 1.8f);
            lbRBDCost.Size = new Size(fpRBDTotal.Size.Width, (int)h * 4);

            lbRBDTotal.Font = lbRBDDiscount.Font = lbRBDCost.Font;
            lbRBDTotal.Size = lbRBDDiscount.Size = lbRBDCost.Size;

            fpRDBTlb.Size = new Size((int)w * 8, pageThongKe.Size.Height - fpRBDetail.Location.Y - fpRBDetail.Size.Height);
            fpRDBTlb.Location = new Point(fpRBDetail.Location.X, fpRBDetail.Location.Y + fpRBDetail.Size.Height);

            lbRBDClb.Font = new Font("Times New Roman", heightFont / 1.8f);
            lbRBDClb.Size = new Size(fpRBDTotal.Size.Width, (int)h * 4);

            lbRBDDlb.Font = lbRBDTlb.Font = lbRBDClb.Font;
            lbRBDDlb.Size = lbRBDTlb.Size = lbRBDClb.Size;

            fpRlbName.Font = new Font("Times New Roman", heightFont / 1.5f, FontStyle.Bold);
            fpRlbName.Size = new Size((int)fpRBDetail.Width/6*3 -10, (int)h * 10);

            fpRlbCnt.Text = "SL";
            fpRlbCnt.Font = new Font("Times New Roman", heightFont / 1.4f, FontStyle.Bold);
            fpRlbCnt.Size = new Size((int)fpRBDetail.Width / 6*1 -10, (int)h * 10);
            
            fpRlbPrice.Font = new Font("Times New Roman", heightFont / 1.5f, FontStyle.Bold);
            fpRlbPrice.Size = new Size(fpRBDetail.Width / 6*2-10, (int)h * 10);

            fpRlbN.Font = new Font("Times New Roman", heightFont / 2.0f);
            fpRlbN.Size = new Size((int)fpRBDetail.Width / 6*3 - 10, (int)h * 4);

            fpRlbC.Font = new Font("Times New Roman", heightFont / 2.0f);
            fpRlbC.Size = new Size((int)fpRBDetail.Width / 6*1 - 10, (int)h * 4);

            fpRlbP.Font = new Font("Times New Roman", heightFont / 2.0f);
            fpRlbP.Size = new Size((int)fpRBDetail.Width / 6*2 - 10, (int)h * 4);


        }
    }
}
