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
    public partial class SignupMasterForm : Form
    {
        Form formLoginMaster;
        bool loginSucessful = false;
        public SignupMasterForm(Form f)
        {
            this.formLoginMaster = f;
            initIn4Server();
            InitializeComponent();
            ReSize();
        }
        string server, ID, Svpassword;
        void initIn4Server()
        {
            string[] in4 = File.ReadAllLines("inforServer.txt");
            server = in4[0];
            ID = in4[1];
            Svpassword = in4[2];
        }
        void CreateDataBase(string nameDB, string password)
        {
            String connString = @"Server=" + server +";User Id=" + ID + ";Password=" + Svpassword + ";";
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

            sqlQuery = "CREATE TABLE MENU(NAME NVARCHAR(30) PRIMARY KEY, PRICE VARCHAR(32), Image Image,ISFood TINYINT)";
            command = new SqlCommand(sqlQuery, connection);
            reader = command.ExecuteReader();
            reader.Close();

            sqlQuery = "CREATE TABLE ListTable(NAME NVARCHAR(30) NOT NULL, FOOD NVARCHAR(255) NOT NULL,Price NVARCHAR(255) NOT NULL, STATUS NVARCHAR(100), INDEXFOOD VARCHAR(100), CONSTRAINT PK_FOOD PRIMARY KEY (NAME,FOOD))";
            command = new SqlCommand(sqlQuery, connection);
            reader = command.ExecuteReader();
            reader.Close();

            sqlQuery = "CREATE TABLE HD(ID UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID() NOT NULL, TRIGIA BIGINT,TIME SMALLDATETIME,GIAMGIA int,TYPE int)";
            command = new SqlCommand(sqlQuery, connection);
            reader = command.ExecuteReader();
            reader.Close();

            sqlQuery = "CREATE TABLE CTHD(ID UNIQUEIDENTIFIER NOT NULL, NAMEFOOD NVARCHAR(50) NOT NULL,PRICEFOOD NVARCHAR(50) NOT NULL,SOLUONG INT, CONSTRAINT PK_CTHD PRIMARY KEY(ID, NAMEFOOD))";
            command = new SqlCommand(sqlQuery, connection);
            reader = command.ExecuteReader();
            reader.Close();

            sqlQuery = "CREATE TABLE NV(FULLNAME NVARCHAR(30), USERNAME NVARCHAR(30),  PHONENUMBER NVARCHAR(15) UNIQUE, ADDRESS NVARCHAR(50), DOB SMALLDATETIME, ICNUMBER NVARCHAR(15) PRIMARY KEY, EMAIL NVARCHAR(50) UNIQUE)";
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
            if (!((tbUsername.Text[0] >= 'a' && tbUsername.Text[0] <= 'z') || (tbUsername.Text[0] >= 'A' && tbUsername.Text[0] <= 'Z')))
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

                            string password = EncodePass(tbPassword.Text);

                            String connString = @"Server=" + server + ";Database=" + nameDB + ";User Id=" + ID + ";Password=" + Svpassword + ";";

                            SqlConnection connection = new SqlConnection(connString);
                            connection.Open();
                            String sqlQuery = "insert into USERS(USERNAME, PASS) values(@username, @pass)";
                            SqlCommand command = new SqlCommand(sqlQuery, connection);

                            command.Parameters.AddWithValue("@username", tbUsername.Text);
                            command.Parameters.AddWithValue("@pass", password);
                            command.ExecuteNonQuery();
                            CreateDataBase(tbUsername.Text, password);
                            connection.Close();

                            loginSucessful = true;
                            this.Hide();
                            Form formQLMenu = new FormMain(true);
                            formQLMenu.ShowDialog();
                        }
                      catch
                        {
                            MessageBox.Show("Tài khoản đã tồn tại");
                        }
                }
            }
        }

        private void SignupMasterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!loginSucessful)
                formLoginMaster.Show();
            else
                formLoginMaster.Close();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
