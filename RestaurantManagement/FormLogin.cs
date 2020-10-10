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
using System.Security.Cryptography;

namespace RestaurantManagement
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu");
            }
            else
            {
                MD5 mh = MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(tbPassword.Text);
                byte[] hash = mh.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                    sb.Append(hash[i].ToString("x2"));
                using (StreamReader sr = new StreamReader("account.txt"))
                {
                    string line;
                    int i = 1;
                    bool flag = false;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (i % 2 == 1 && line == tbUsername.Text)
                        {
                            flag = true; // co tai khoan
                            line = sr.ReadLine();
                            if (line == sb.ToString())
                            {
                                this.Hide();
                                Form formQLBan = new FormQLBan();
                                formQLBan.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Sai mật khẩu");
                            }
                            i++;
                        }
                        i++;
                    }
                    if (!flag)
                    {
                        MessageBox.Show("Không tìm thấy tài khoản");
                    }
                }
            }                
        }

        private void btSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formSignup = new FormSignup(this);
            formSignup.ShowDialog();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
