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
using System.Configuration;

namespace RestaurantManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.tbPassword.KeyDown += new KeyEventHandler(Enter_Event);
            initIn4Server();
            ReSize();
        }
        private void Enter_Event(object sender, KeyEventArgs args)
        {
            if (args.KeyCode == Keys.Enter)
                btLogin_Click(sender, args);
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
        string server, ID, Svpassword;
        void initIn4Server()
        {
            string[] in4 = File.ReadAllLines("inforServer.txt");
            server = in4[0];
            ID = in4[1];
            Svpassword = in4[2];
            //MessageBox.Show(server + ID + Svpassword);
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

                string nameDB;
                nameDB = ConfigurationManager.AppSettings["database"];

                String connString = @"Server=" + server + ";Database=" + nameDB + ";User Id=" + ID + ";Password=" + Svpassword + ";";
                SqlConnection connection = new SqlConnection(connString);
                try
                {
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
                                int temp = reader.GetInt32(2);
                                bool AD;
                                if (temp == 1) AD = true; else AD = false;

                                this.Hide();
                                Form FormQLMenu = new FormMain(AD, tbUsername.Text);
                                FormQLMenu.ShowDialog();
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
                catch
                {
                    MessageBox.Show("Kết nối tới máy chủ bị lỗi");
                }
            }
        }

        private void btSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form signupForm = new SignupForm();
            signupForm.ShowDialog();
        }
    }
}
