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
using System.Data.SqlClient;

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

                string nameDB;
                using (StreamReader sr = new StreamReader("database.txt"))
                {
                    nameDB = sr.ReadLine();
                }

                String connString = @"Server=DESKTOP-7N34GNC,1433;Database=" + nameDB + ";User Id=sa;Password=abc123;";
                SqlConnection connection = new SqlConnection(connString);
                connection.Open();

                String sqlQuery = "select * from USERS";
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                SqlDataReader reader = command.ExecuteReader();

                bool flag = false;

                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    if (reader.GetString(0) == tbUsername.Text)
                    {
                        flag = true;
                        if (reader.GetString(1) == sb.ToString())
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
                    }
                }
                connection.Close();
                if (!flag)
                {
                    MessageBox.Show("Không tìm thấy tài khoản");
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
