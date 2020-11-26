using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace RestaurantManagement
{
    public class Food_Fix : Food
    {
        FormMain parent;
        private PictureBox btDelete = new PictureBox();

        private PictureBox btFix = new PictureBox();
        public Food_Fix()
        {
            btFix.Image = Image.FromFile("images/fix_icon.png");
            btFix.SizeMode = PictureBoxSizeMode.Zoom;
            btFix.Size = new Size(lPrice.Size.Height, lPrice.Size.Height);
            btDelete.Image = Image.FromFile("images/remove.png");
            btDelete.SizeMode = PictureBoxSizeMode.Zoom;
            btDelete.Size = new Size(lPrice.Size.Height, lPrice.Size.Height);
            btDelete.Location = new Point((int)Math.Truncate(this.Location.X + this.lPrice.Size.Height * 6.65f), this.Location.Y);
            //btDelete.Location = new Point(btDelete.Size.Height, 0);
            btFix.Location = new Point((int)Math.Truncate(this.Location.X + this.lPrice.Size.Height * 6.65f) - btFix.Width, this.Location.Y);
            HideButton();
            this.Controls.Add(btDelete);
            this.Controls.Add(btFix);
            this.btDelete.Click += new System.EventHandler(OnbtDelete_Click);
            this.btFix.Click += new System.EventHandler(OnbtFix_Click);
        }
        public void OnbtDelete_Click(object sender, EventArgs e)
        {
            // Khi ẩn món ,form tự động dồn những món bên phải (dưới) lên
            if (parent.DeleteFood(lName.Text))
                this.Hide();
        }
        public void OnbtFix_Click(object sender, EventArgs e)
        {
            FixFood fix = new FixFood(this, parent, lName.Text, lPrice.Text, pFood.Image);
            fix.ShowDialog();
        }
        public void SetWithoutImage(string name, string price)
        {
            this.lName.Text = name;
            this.lPrice.Text = price + "000 VNĐ";
        }
        public void SetParent(FormMain parent)
        {
            this.parent = parent;
        }
        public void ShowButton()
        {
            btDelete.Show();
            btFix.Show();
        }
        public void HideButton()
        {
            btDelete.Hide();
            btFix.Hide();
        }
        string ChuanHoa(string S)
        {
            Console.WriteLine("0");
            while (S.Length > 0 && S[0] == ' ')
            {
                Console.WriteLine(S);
                S = S.Remove(0, 1);
            };
            Console.WriteLine("1");
            while (S.Length > 0 && S[S.Length - 1] == ' ')
            {
                S = S.Remove(S.Length - 1, 1);
            };
            Console.WriteLine("2");
            if (S.Length > 0 && S[0] >= 'a' && S[0] <= 'z')
            {
                char c = S[0];
                string s = c.ToString();
                s = s.ToUpper();
                Console.WriteLine(s);
                S = S.Remove(0, 1);
                S = s + S;
            }
            Console.WriteLine("3!");
            for (int i = 0; i < S.Length - 1; i++)
            {
                while (S[i] == S[i + 1] & S[i + 1] == ' ')
                {
                    S = S.Remove(i + 1, 1);
                }
            }
            return S;
        }
    }
}