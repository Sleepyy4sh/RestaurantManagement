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
    public class Table : Panel
    {
        FormQLMenu FormQLBan ;
        public string Name;
        protected PictureBox pTable = new PictureBox();
        protected Label lbName= new Label();
        public  ComboBox cbStatus = new ComboBox();
        protected Button btOder = new Button();
        public Table(FormQLMenu formQL)
        {
            init();
            FormQLBan = formQL;
            pTable.Image = Image.FromFile("images/table.jpg");
            this.pTable.Click += new EventHandler(Table_Click);
        }
        void Table_Click(object sender,EventArgs args)
        {
            FormQLBan.SelectedTable(this);
            FormQLBan.InitFoodInlist(this.Name);
        }
        public void SetName(string Name, string Status)
        {
            this.Name = lbName.Text = Name;
            if (Status != "")
            {
                cbStatus.SelectedItem = Status;
            }
        }
        public void init()
        {
            //cài chế độ 
            this.AutoSize = false;
            lbName.AutoSize = false;
            lbName.ForeColor = Color.Black;
            cbStatus.ForeColor = Color.Black;
            cbStatus.AutoSize = false;
            pTable.SizeMode = PictureBoxSizeMode.Zoom;
            this.BackColor = Color.White;
            btOder.ForeColor = Color.Black;
            btOder.BackColor = Color.DarkCyan;
            btOder.TabIndex = 100;


            cbStatus.Items.Add("Đang sửa");
            cbStatus.Items.Add("Đã đặt");
            cbStatus.Items.Add("Đang dùng");
            cbStatus.Items.Add("Bàn trống");
            cbStatus.SelectedIndex = 3;
        }
        // cài đặt thông số
        public void SetTransform(int sizeX, int sizeY, int posX, int posY)
        {
            this.Size = new Size(sizeX, sizeY);
            this.Location = new Point(posX, posY);

            // tỉ lệ 5:7
            //////////////////
            //vị trí
            pTable.Location = new Point(posX, posY);
            lbName.Location = new Point(posX, posY + (int)(5f * (sizeY / 7)));
            cbStatus.Location = new Point(0, posY + (int)(6f * (sizeY / 7)));
            btOder.Location = new Point(posX + (int)(sizeX / 3.2f), posY + (int)(5f * (sizeY / 7)));

            //kích thước
            pTable.Size = new Size(sizeX, sizeX);
            lbName.Size = new Size(sizeX / 5, sizeY / 7);
            cbStatus.Size = new Size(sizeX / 5*3, sizeY / 7);
            btOder.Size = new Size(sizeX / 5 * 2, sizeY / 7);
            btOder.Text = "Gọi món";
           // MessageBox.Show(btOder.Location.ToString());
          //  MessageBox.Show(lbName.Location.ToString()) ;
            /////////////////////

            //thêm vào nhóm
            this.Controls.Add(pTable);
            this.Controls.Add(lbName);
            this.Controls.Add(cbStatus);
            //this.Controls.Add(btOder);
        }
    }
}
