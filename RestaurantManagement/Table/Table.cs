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
using System.Threading;
namespace RestaurantManagement
{
    public class Table : Panel
    {
        public bool isEmpty = true;
        FormMain FormQLBan ;
        public string Name;
        protected PictureBox pTable = new PictureBox();
        protected Label lbName= new Label();
        public  ComboBox cbStatus = new ComboBox();
        protected Button btOder = new Button();
        PictureBox btDelete = new PictureBox();
        public Table(FormMain formQL)
        {
            init();
            FormQLBan = formQL;
            this.pTable.Click += new EventHandler(Table_Click);
            //CheckEmpty();
            GetImageTable();
        }
        void Table_Click(object sender,EventArgs args)
        {
            if (cbStatus.SelectedIndex == 0)
            {
                MessageBox.Show("Bàn đang sửa");
            } else
            if (cbStatus.SelectedIndex == 1)
            {
                MessageBox.Show("Bàn đã được đặt");
            }    
            else
            {
                FormQLBan.SelectedTable(this);
                FormQLBan.InitFoodInlist(this);
            }
            //MessageBox.Show(isEmpty.ToString());
        }
        public void SetName(string Name, string Status)
        {
            this.Name = lbName.Text = Name;
            if (Status != "")
            {
                switch (Status)
                {
                    case "Đang sửa":
                        cbStatus.SelectedIndex = 0;

                        pTable.Image = Image.FromFile("images/table_Fixing.png");
                        break;
                    case "Đã đặt":
                        cbStatus.SelectedIndex = 1;
                        pTable.Image = Image.FromFile("images/table_Reserve.png");
                        break;
                    case "Đang dùng":
                        isEmpty = false;
                        cbStatus.SelectedIndex = 2;
                        pTable.Image = Image.FromFile("images/table_Using.png");
                        break;
                    case "Bàn trống":
                        cbStatus.SelectedIndex = 3;
                        pTable.Image = Image.FromFile("images/table_Free.png");
                        break;
                }
            }
            CheckEmpty();
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

            btDelete.Image = Image.FromFile("images/remove.png");
            btDelete.SizeMode = PictureBoxSizeMode.Zoom;
            btDelete.Click += new EventHandler(btDelete_Click);


            cbStatus.Items.Add("Đang sửa");
            cbStatus.Items.Add("Đã đặt");
            cbStatus.Items.Add("Đang dùng");
            cbStatus.Items.Add("Bàn trống");
            cbStatus.SelectedIndex = 3;
            pTable.Image = Image.FromFile("images/table_Free.png");

            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.SelectedIndexChanged += new EventHandler(cbStatus_Changed);
        }
        void cbStatus_Changed(object sender,EventArgs args)
        {
            GetImageTable();
            FormQLBan.SaveStatus(Name, cbStatus.SelectedItem.ToString());
                CheckEmpty();
        }
        void GetImageTable()
        {
            switch (cbStatus.SelectedIndex)
            {
                case 0:
                    pTable.Image = Image.FromFile("images/table_Fixing.png");                
                    break;
                case 1:
                    pTable.Image = Image.FromFile("images/table_Reserve.png");                       
                    break;
                case 2:
                    pTable.Image = Image.FromFile("images/table_Using.png");
                    break;
                case 3:
                     pTable.Image = Image.FromFile("images/table_Free.png");
                    break;
            }
        }
        public void CheckEmpty()
        {
            if (!isEmpty)
            {
                cbStatus.SelectedIndex = 2;
                //pTable.Image = Image.FromFile("images/table_Using.png");
            }
            else
            if (cbStatus.SelectedIndex == 2) 
            {
                cbStatus.SelectedIndex = 3;
               // pTable.Image = Image.FromFile("images/table_Free.png");
            }
            GetImageTable();
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
            btDelete.Location = new Point(this.Size.Width -this.Size.Height/8, 0);

            //kích thước
            pTable.Size = new Size(sizeX, sizeX);
            lbName.Size = new Size(sizeX , sizeY / 7);
            cbStatus.Size = new Size(sizeX / 5*3, sizeY / 7);
            btOder.Size = new Size(sizeX / 5 * 2, sizeY / 7);
            btOder.Text = "Gọi món";
            btDelete.Size = new Size(this.Size.Width/6,this.Size.Width/6);

            // MessageBox.Show(btOder.Location.ToString());
            //  MessageBox.Show(lbName.Location.ToString()) ;
            /////////////////////

            //thêm vào nhóm
            this.Controls.Add(btDelete);
            this.Controls.Add(pTable);
            this.Controls.Add(lbName);
            this.Controls.Add(cbStatus);
            //this.Controls.Add(btOder);
        }
        void btDelete_Click(object sender,EventArgs args)
        {
            FormQLBan.DeleteTable(this);
        }
    }
}
