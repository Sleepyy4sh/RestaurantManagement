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
    public partial class SignupForm : Form
    {
        private Form formLogin;
        bool loginSucessful = false;
        public SignupForm(Form f)
        {
            initIn4Server();
            this.formLogin = f;
            InitializeComponent();
            this.tbRepassword.KeyDown += new KeyEventHandler(Enter_Event);
        }
        private void Enter_Event(object sender, KeyEventArgs args)
        {
            if (args.KeyCode == Keys.Enter)
                btSignup_Click(sender, args);
        }

        bool whitespaceContain(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    return true;
                    break;
                }
            }
            return false;
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
        }
        private void btSignup_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                MessageBox.Show("Hãy nhập tài khoản");
            }
            else
            if (whitespaceContain(tbUsername.Text))
            {
                MessageBox.Show("Tài khản không được có khoảng trắng");
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
                        try
                        {
                            string nameDB;
                            using (StreamReader sr = new StreamReader("database.txt"))
                            {
                                nameDB = sr.ReadLine();
                            }

                            string password = EncodePass(tbPassword.Text);

                            String connString = @"Server=" + server + ";Database=" + nameDB + ";User Id=" + ID + ";Password=" + Svpassword + ";";

                            SqlConnection connection = new SqlConnection(connString);
                            connection.Open();
                            String sqlQuery = "insert into USERS(USERNAME, PASS, AD) values(@username, @pass, @ad)";
                            SqlCommand command = new SqlCommand(sqlQuery, connection);

                            command.Parameters.AddWithValue("@username", tbUsername.Text);
                            command.Parameters.AddWithValue("@pass", password);
                            command.Parameters.AddWithValue("@ad", 0);
                            command.ExecuteNonQuery();
                            connection.Close();
                            loginSucessful = true;
                            this.Hide();
                            Form FormQLMenu = new FormMain(false);
                            FormQLMenu.ShowDialog();
                        }
                        catch
                        {
                            MessageBox.Show("Tài khoản đã tồn tại");
                        }
                }
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void SignupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (loginSucessful)
                formLogin.Close();
            else
                formLogin.Show();
        }
    }
}
