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
using System.IO;
using System.Security.Cryptography;

namespace RestaurantManagement
{
    public partial class FormChangePass : Form
    {
        string username;
        string server, ID, Svpassword;
        public FormChangePass(string usrname)
        {
            this.username = usrname;
            InitializeComponent();
            initIn4Server();
            ReSize();
        }        
        void initIn4Server()
        {
            string[] in4 = File.ReadAllLines("inforServer.txt");
            server = in4[0];
            ID = in4[1];
            Svpassword = in4[2];
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
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btChangePass_Click(object sender, EventArgs e)
        {
            if (tbCurPass.Text == "" || tbNewPass.Text == "" || tbRePassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            } else
            {
                if (tbNewPass.Text != tbRePassword.Text)
                {
                    MessageBox.Show("Mật khẩu không khớp");
                    return;
                }

                string curPass = EncodePass(tbCurPass.Text);
                string newPass = EncodePass(tbNewPass.Text);

                string nameDB;
                using (StreamReader sr = new StreamReader("database.txt"))
                {
                    nameDB = sr.ReadLine();
                }

                String connString = @"Server=" + server + ";Database=" + nameDB + ";User Id=" + ID + ";Password=" + Svpassword + ";";
                SqlConnection connection = new SqlConnection(connString);
                connection.Open();

                String sqlQuery = "select * from USERS";
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                SqlDataReader reader = command.ExecuteReader();


                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    if (reader.GetString(0) == username)
                    {
                        if (reader.GetString(1) == curPass)
                        {
                            reader.Close();
                            sqlQuery = "USE " + nameDB;
                            command = new SqlCommand(sqlQuery, connection);
                            reader = command.ExecuteReader();
                            reader.Close();

                            sqlQuery = "UPDATE USERS SET PASS = '" + newPass + "' WHERE USERNAME='" + username + "'";
                            command = new SqlCommand(sqlQuery, connection);
                            reader = command.ExecuteReader();
                            reader.Close();

                            sqlQuery = "USE MASTER_USER";
                            command = new SqlCommand(sqlQuery, connection);
                            reader = command.ExecuteReader();
                            reader.Close();

                            sqlQuery = "UPDATE USERS SET PASS = '" + newPass + "' WHERE USERNAME='" + username + "'";
                            command = new SqlCommand(sqlQuery, connection);
                            reader = command.ExecuteReader();
                            reader.Close();

                            MessageBox.Show("Đổi mật khẩu thành công");
                            this.Close();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Sai mật khẩu");
                        }
                    }
                }
                connection.Close();
            }
        }
    }
}
