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
    public partial class AddFood : Form
    {
        FormMain Fix;
        public AddFood(FormMain fix)
        {
            Fix = fix;
            InitializeComponent();
        }
        string path = "";
        private void bBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            path = openFileDialog.FileName;
            try
            {
                pictureBox1.Image = Image.FromFile(path);
            }
            catch (Exception ex)
            {
                path = "";
                MessageBox.Show("File không phải hình ảnh, vui lòng chọn lại");
            }
            //MessageBox.Show(path);
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên món ăn", "Thiếu thông tin");
            }
            else if (tbPrice.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá", "Thiếu thông tin");
            }
            else if (pictureBox1.Image == null)
            {
                MessageBox.Show("Vui lòng chọn hình ảnh ", "Thiếu thông tin");
            }
            else
            {
                if (Fix.InsertData(tbName.Text, tbPrice.Text, converImgToByte(path)))
                {
                    MessageBox.Show("Thêm món " + tbName.Text + " thành công");
                    tbName.Text = "";
                    tbPrice.Text = "";
                    pictureBox1.Image = null;
                    this.Close();
                }

            }
        }

        private void AddFood_Load(object sender, EventArgs e)
        {

        }
        private byte[] converImgToByte(string url)
        {
            FileStream fs;
            fs = new FileStream(url, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }
    }
}
