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
    public partial class FixFood : Form
    {
        FormMain mainform;
        string name, price;
        Food_Fix food;
        public FixFood(Food_Fix food, FormMain fix, string name, string price, Image image)
        {
            InitializeComponent();
            price = price.Remove(price.Length - 7, 7);
            this.food = food;
            this.mainform = fix;
            this.tbName.Text = this.name = name;
            this.tbPrice.Text = this.price = price;
            pictureBox1.Image = image;

        }
        bool isFixImage = false;
        string path = "";
        private void bBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            string pathtemp = openFileDialog.FileName;
            if (pathtemp != "")
                try
                {
                    pictureBox1.Image = Image.FromFile(pathtemp);
                    path = pathtemp;
                    isFixImage = true;
                }
                catch
                {
                    MessageBox.Show("File không phải hình ảnh, vui lòng chọn lại");
                    isFixImage = false;
                }
            //MessageBox.Show(path);
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "")           // MessageBox.Show("Clicked");

            {
                MessageBox.Show("Vui lòng nhập tên món ăn", "Thiếu thông tin");
            }
            else if (tbPrice.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá", "Thiếu thông tin");
            }
            else if (!CheckNumber(RemoveSpace(tbPrice.Text)))
            {
                MessageBox.Show("Giá chỉ được nhập số", "Sai định dạng");
            }
            else if (path == "" & isFixImage)
            {
                MessageBox.Show("Vui lòng chọn hình ảnh ", "Thiếu thông tin");
            }
            else
            {
                if (isFixImage)
                {
                    if (mainform.FixData(food, this.name, ChuanHoa(tbName.Text), tbPrice.Text, converImgToByte(path)))
                    {
                        MessageBox.Show("Sửa món " + ChuanHoa(tbName.Text) + " thành công");
                        tbName.Text = "";
                        tbPrice.Text = "";
                        pictureBox1.Image = null;
                        this.Close();
                    }
                }
                else
                if (mainform.FixDataWithoutImage(food, this.name, ChuanHoa(tbName.Text), RemoveSpace(tbPrice.Text)))
                {
                    MessageBox.Show("Sửa món " + ChuanHoa(tbName.Text) + " thành công");
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
        string ChuanHoa(string S)
        {
            while (S.Length > 0 && S[0] == ' ')
            {
                Console.WriteLine(S);
                S = S.Remove(0, 1);
            };
            while (S.Length > 0 && S[S.Length - 1] == ' ')
            {
                S = S.Remove(S.Length - 1, 1);
            };
            if (S.Length > 0 && S[0] >= 'a' && S[0] <= 'z')
            {
                char c = S[0];
                string s = c.ToString();
                s = s.ToUpper();
                Console.WriteLine(s);
                S = S.Remove(0, 1);
                S = s + S;
            }
            for (int i = 0; i < S.Length - 1; i++)
            {
                while (S[i] == S[i + 1] & S[i + 1] == ' ')
                {
                    S = S.Remove(i + 1, 1);
                }
            }
            return S;
        }
        string RemoveSpace(string S)
        {
            for (int i = 0; i < S.Length; i++)
            {
                while (i <= S.Length && S[i] == ' ')
                {
                    S = S.Remove(i, 1);
                }
            }
            return S;
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {
            String S = tbPrice.Text;
            int pos = S.Length;
            for (int i = 0; i < S.Length; i++)
            {
                if (!(S[i] >= '0' && S[i] <= '9'))
                {
                    S = S.Remove(i, 1);
                    pos = i;
                    break;
                }
            }
            tbPrice.Text = S;
            tbPrice.SelectionStart = pos;
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            //String S = tbName.Text;
            //int pos = S.Length;
            //for (int i = 0; i < S.Length; i++)
            //{
            //    if (!(S[i] >= '0' && S[i] <= '9') && !(S[i] >= 'a' && S[i] <= 'z') && !(S[i] >= 'a' && S[i] <= 'z') && S[i] != ' ')
            //    {
            //        S = S.Remove(i, 1);
            //        pos = i;
            //        break;
            //    }
            //}
            //tbName.Text = S;
            //tbName.SelectionStart = pos;
        }

        bool CheckNumber(string num)
        {
            for (int i = 0; i < num.Length; i++)
                if (num[i] < '0' || num[i] > '9')
                {
                    return false;
                }
            return true;
        }
    }
}
