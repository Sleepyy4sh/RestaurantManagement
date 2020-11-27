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
    // Tạo nhóm để hiển thị món ăn
    abstract public class Food : Panel
    {
        protected string name;
        protected PictureBox pSelected = new PictureBox();
        protected PictureBox pFood = new PictureBox();
        protected Label lName = new Label();
        protected Label lPrice = new Label();
        public void Set(Byte[] url, string name, string price)
        {
            this.name = name;
            pFood.Image = ByteToImg(url);
            lName.Text = name;
            lPrice.Text = price + "000 VNĐ";
            init();
            //this.pFood.DoubleClick += new System.EventHandler(OnPicter_DClick);
        }
        public string GetName()
        {
            return name;
        }
        private Image ByteToImg(Byte[] byteString)
        {
            MemoryStream ms = new MemoryStream(byteString, 0, byteString.Length);
            ms.Write(byteString, 0, byteString.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        public void init()
        {
            //cài chế độ 
            this.AutoSize = false;
            lName.AutoSize = false;
            lName.ForeColor = Color.Black;
            lPrice.ForeColor = Color.Black;
            lPrice.AutoSize = false;
            pFood.SizeMode = PictureBoxSizeMode.Zoom;
            this.BackColor = Color.White;
        }
        // cài đặt thông số
        public void SetTransform(int sizeX, int sizeY, int posX, int posY)
        {
            this.Size = new Size(sizeX, sizeY);
            this.Location = new Point(posX, posY);

            // tỉ lệ 5:7
            //////////////////
            //vị trí
            pFood.Location = new Point(posX, posY);
            lName.Location = new Point(posX, posY + (int)(5f * (sizeY / 7)));
            lPrice.Location = new Point(posX, posY + (int)(6f * (sizeY / 7)));

            //kích thước
            pFood.Size = new Size(sizeX, sizeX);
            lName.Size = new Size(sizeX, sizeY / 7);
            lPrice.Size = new Size(sizeX, sizeY / 7);
            /////////////////////
            ///
            pSelected.Image = Image.FromFile("images/SelectedFood_Icon.png");
            pSelected.SizeMode = PictureBoxSizeMode.Zoom;
            pSelected.Size = new Size(lPrice.Size.Height, lPrice.Size.Height);
            //pSelected.Location = new Point((int)Math.Truncate(this.Location.X + this.lPrice.Size.Height * 6.65f), this.Location.Y);
            
            this.Controls.Add(pSelected);
            pSelected.Hide();

            //thêm vào nhóm
            this.Controls.Add(pFood);
            this.Controls.Add(lName);
            this.Controls.Add(lPrice);
        }
    }
}
