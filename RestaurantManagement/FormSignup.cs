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
    public partial class FormSignup : Form
    {
        private Form formLogin;
        public FormSignup(Form f)
        {
            formLogin = f;
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            formLogin.Show();
            this.Close();
        }

        private void btSignup_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                MessageBox.Show("Hãy nhập tài khoản");
            }
            else
            {
                if (tbPassword.Text == "")
                {
                    MessageBox.Show("Hãy nhập mật khẩu");
                }
                else
                {
                    if (tbPassword.Text != tbRepassword.Text)
                    {
                        MessageBox.Show("Mật khẩu không khớp");
                    }
                    else
                    {
                        bool flag = false;
                        if (!File.Exists("account.txt"))
                        {
                            var myFile = File.Create("account.txt");
                            myFile.Close();
                        }

                        using (StreamReader sr = new StreamReader("account.txt"))
                        {
                            string line;
                            int i = 1;
                            while ((line = sr.ReadLine()) != null)
                            {
                                if (i % 2 == 1 && line == tbUsername.Text)
                                {
                                    MessageBox.Show("Tài khoản đã tồn tại");
                                    flag = true;
                                    break;
                                }
                                i++;
                            }
                        }
                        if (!flag)
                        {
                            using (StreamWriter sw = new StreamWriter("account.txt", true))
                            {
                                sw.WriteLine(tbUsername.Text);
                                MD5 mh = MD5.Create();
                                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(tbPassword.Text);
                                byte[] hash = mh.ComputeHash(inputBytes);
                                StringBuilder sb = new StringBuilder();
                                for (int i = 0; i < hash.Length; i++)
                                    sb.Append(hash[i].ToString("x2"));

                                sw.WriteLine(sb.ToString());
                            }
                            this.Hide();
                            Form formQLBan = new FormQLBan();
                            formQLBan.ShowDialog();
                            formLogin.Close();
                        }
                    }
                }
            }
        }
    }
}
