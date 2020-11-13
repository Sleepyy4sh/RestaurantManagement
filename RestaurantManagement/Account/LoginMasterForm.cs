using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Data.SqlClient;

namespace RestaurantManagement
{
    public partial class LoginMasterForm : Form
    {
        public LoginMasterForm()
        {
            InitializeComponent();
        }

        string EncodePass(string str)
        {
            MD5 mh = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(str);
            byte[] hash = mh.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
                sb.Append(hash[i].ToString("x2"));
            return sb.ToString();
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu");
            }
            else
            {
                string password = EncodePass(tbPassword.Text);

                string nameDB = "MASTER_USER";

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
                        if (reader.GetString(1) == password)
                        {
                            if (!File.Exists("database.txt"))
                            {
                                var myFile = File.Create("database.txt");
                                myFile.Close();
                                using (StreamWriter sw = new StreamWriter("database.txt"))
                                {
                                    sw.WriteLine(tbUsername.Text);
                                }
                            }
                            
                            this.Hide();
                            Form formMain = new FormMain(true);
                            formMain.ShowDialog();
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
            Form formSignupMaster = new SignupMasterForm(this);
            formSignupMaster.ShowDialog();
        }
    }
}
