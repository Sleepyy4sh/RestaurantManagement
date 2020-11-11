using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;

namespace RestaurantManagement
{
    public partial class FormSignupMaster : Form
    {
        Form formLoginMaster;
        bool loginSucessful = false;
        public FormSignupMaster(Form f)
        {
            formLoginMaster = f;
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void CreateDataBase(string nameDB, string password)
        {         
            String connString = @"Server=DESKTOP-7N34GNC,1433;User Id=sa;Password=abc123;";
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();

            String sqlQuery = "CREATE DATABASE " + nameDB;
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Close();

            sqlQuery = "USE " + nameDB;
            command = new SqlCommand(sqlQuery, connection);
            reader = command.ExecuteReader();
            reader.Close();

            sqlQuery = "CREATE TABLE USERS(USERNAME VARCHAR(30) PRIMARY KEY, PASS VARCHAR(32), AD int)";
            command = new SqlCommand(sqlQuery, connection);
            reader = command.ExecuteReader();
            reader.Close();

            sqlQuery = "insert into USERS(USERNAME, PASS, AD) values(@username, @pass, @ad)";
            command = new SqlCommand(sqlQuery, connection);

            command.Parameters.AddWithValue("@username", nameDB);
            command.Parameters.AddWithValue("@pass", password);
            command.Parameters.AddWithValue("@ad", 1);
            command.ExecuteNonQuery();

            sqlQuery = "CREATE TABLE MENU(NAME NVARCHAR(30) PRIMARY KEY, PRICE VARCHAR(32), Image Image)";
            command = new SqlCommand(sqlQuery, connection);
            reader = command.ExecuteReader();
            reader.Close();

            connection.Close();

            var myFile = File.Create("database.txt");
            myFile.Close();
            using (StreamWriter sw = new StreamWriter("database.txt"))
            {
                sw.WriteLine(nameDB);
            }                
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
            if (! ((tbUsername.Text[0] >= 'a' && tbUsername.Text[0] <= 'z') || (tbUsername.Text[0] >= 'A' && tbUsername.Text[0] <= 'Z')))
            {
                MessageBox.Show("Tài khoản phải bắt đầu bằng chữ cái");
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
                            string nameDB = "MASTER_USER";

                            MD5 mh = MD5.Create();
                            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(tbPassword.Text);
                            byte[] hash = mh.ComputeHash(inputBytes);
                            StringBuilder sb = new StringBuilder();
                            for (int i = 0; i < hash.Length; i++)
                                sb.Append(hash[i].ToString("x2"));

                            String connString = @"Server=DESKTOP-7N34GNC,1433;Database=" + nameDB + ";User Id=sa;Password=abc123;";

                            SqlConnection connection = new SqlConnection(connString);
                            connection.Open();
                            String sqlQuery = "insert into USERS(USERNAME, PASS) values(@username, @pass)";
                            SqlCommand command = new SqlCommand(sqlQuery, connection);

                            command.Parameters.AddWithValue("@username", tbUsername.Text);
                            command.Parameters.AddWithValue("@pass", sb.ToString());
                            command.ExecuteNonQuery();
                            connection.Close();
                            CreateDataBase(tbUsername.Text, sb.ToString());
                            loginSucessful = true;
                            this.Hide();
                            Form formQLBan = new FormQLBan(true);
                            formQLBan.ShowDialog();
                        }
                        catch
                        {
                             MessageBox.Show("Tài khoản đã tồn tại");
                        }
                }
            }
        }

        private void FormSignupMaster_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!loginSucessful)
                formLoginMaster.Show();
            else
                formLoginMaster.Close();
        }
    }
}
