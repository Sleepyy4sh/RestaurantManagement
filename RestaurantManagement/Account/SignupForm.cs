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
using System.Globalization;
using System.Configuration;

namespace RestaurantManagement
{
    public partial class SignupForm : Form
    {
        SqlConnection connection;
        public SignupForm()
        {
            initIn4Server();
            InitializeComponent();
            tbUsername.Enabled = false;
            tbPassword.Enabled = false;
            tbRepassword.Enabled = false;
            this.tbRepassword.KeyDown += new KeyEventHandler(Enter_Event);
            ReSize();
        }
        private void Enter_Event(object sender, KeyEventArgs args)
        {

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

        private void OnlyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void OnlyNumberForDoB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar.ToString() != "/")
            {
                e.Handled = true;
            }
        }

        private bool CheckFormat()
        {
            DateTime dt;
            CultureInfo enUS = new CultureInfo("en-US");

            if (tbSFname.Text == "" || tbSFname.Text[0] == ' ' || tbSFname.Text.Contains("  "))
            {
                MessageBox.Show("Tên không hợp lệ");
                return false;
            }
            if (tbSPnumber.Text == "" || tbSPnumber.Text.Contains(" "))
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                return false;
            }
            if (tbSAddress.Text == "" || tbSAddress.Text.Contains("  "))
            {
                MessageBox.Show("Địa chỉ không hợp lệ" + tbSAddress.Text + "1");
                return false;
            }
            if (tbSDoB.Text == "" || (!DateTime.TryParseExact(tbSDoB.Text, "M/d/yyyy", enUS, DateTimeStyles.None, out dt)))
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                return false;
            }
            if (tbSICnumber.Text == "" || tbSICnumber.Text.Contains("  "))
            {
                MessageBox.Show("CMND/CCCD không hợp lệ");
                return false;
            }
            if (tbSEmail.Text == "" || tbSEmail.Text.Contains("  ") || !tbSEmail.Text.Contains("@") || !tbSEmail.Text.Contains("."))
            {
                MessageBox.Show("Email không hợp lệ");
                return false;
            }
            return true;
        }

        private void ckboxType_CheckedChanged(object sender, EventArgs e)
        {
            if (!ckboxType.Checked)
            {
                tbUsername.Enabled = false;
                tbPassword.Enabled = false;
                tbRepassword.Enabled = false;
            }
            else
            {
                tbUsername.Enabled = true;
                tbPassword.Enabled = true;
                tbRepassword.Enabled = true;
            }

        }

        private void btSignup_Click(object sender, EventArgs e)
        {
            if (CheckFormat())
            {
                if (ckboxType.Checked)
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
                                    nameDB = ConfigurationManager.AppSettings["database"];
                                    String connString = @"Server=" + server + ";Database=" + nameDB + ";User Id=" + ID + ";Password=" + Svpassword + ";";
                                    connection = new SqlConnection(connString);
                                    connection.Open();

                                    //CheckAccount
                                    String sqlQuery = "select * from USERS where USERNAME =  @Username";
                                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                                    command.Parameters.AddWithValue("@Username", tbUsername.Text);
                                    SqlDataReader reader = command.ExecuteReader();
                                    while (reader.HasRows)
                                    {
                                        if (reader.Read() == false) break;
                                        MessageBox.Show("Tài khoản đã tồn tại");
                                        reader.Close();
                                        return;
                                    }
                                    reader.Close();
                                    //AddNV
                                    connection = new SqlConnection(connString);
                                    connection.Open();
                                    sqlQuery = "insert into NV(FULLNAME, USERNAME, PHONENUMBER , ADDRESS , DOB , ICNUMBER , EMAIL) values (@Fname, @Username, @Pnumber, @Address, @DoB, @ICnumber, @Email)";
                                    command = new SqlCommand(sqlQuery, connection);
                                    command.Parameters.AddWithValue("@Fname", tbSFname.Text);
                                    command.Parameters.AddWithValue("@Username", tbUsername.Text);
                                    command.Parameters.AddWithValue("@Pnumber", tbSPnumber.Text);
                                    command.Parameters.AddWithValue("@Address", tbSAddress.Text);
                                    command.Parameters.AddWithValue("@DoB", tbSDoB.Text);
                                    command.Parameters.AddWithValue("@ICnumber", tbSICnumber.Text);
                                    command.Parameters.AddWithValue("@Email", tbSEmail.Text);
                                    command.ExecuteNonQuery();

                                    //AddAccount
                                    string password = EncodePass(tbPassword.Text);
                                    sqlQuery = "insert into USERS(USERNAME, PASS, AD) values(@username, @pass, @ad)";
                                    command = new SqlCommand(sqlQuery, connection);
                                    command.Parameters.AddWithValue("@username", tbUsername.Text);
                                    command.Parameters.AddWithValue("@pass", password);
                                    command.Parameters.AddWithValue("@ad", 0);
                                    command.ExecuteNonQuery();
                                    MessageBox.Show("Thêm nhân viên thành công");
                                    this.Close();
                                }
                                catch
                                {
                                    MessageBox.Show("Lỗi kết nối hoặc thông tin bị trùng, sai định dạng");
                                }
                                finally
                                {
                                    connection.Close();
                                }
                        }
                    }
                }
                else
                {
                    try
                    {
                        string nameDB;
                        nameDB = ConfigurationManager.AppSettings["database"];
                        String connString = @"Server=" + server + ";Database=" + nameDB + ";User Id=" + ID + ";Password=" + Svpassword + ";";
                        connection = new SqlConnection(connString);
                        connection.Open();

                        string sqlQuery = "insert into NV(FULLNAME, PHONENUMBER , ADDRESS , DOB , ICNUMBER , EMAIL) values (@Fname, @Pnumber, @Address, @DoB, @ICnumber, @Email)";
                        SqlCommand command = new SqlCommand(sqlQuery, connection);
                        command.Parameters.AddWithValue("@Fname", tbSFname.Text);
                        command.Parameters.AddWithValue("@Pnumber", tbSPnumber.Text);
                        command.Parameters.AddWithValue("@Address", tbSAddress.Text);
                        command.Parameters.AddWithValue("@DoB", tbSDoB.Text);
                        command.Parameters.AddWithValue("@ICnumber", tbSICnumber.Text);
                        command.Parameters.AddWithValue("@Email", tbSEmail.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm nhân viên thành công");
                        this.Close();

                    }
                    catch
                    {
                        MessageBox.Show("Lỗi kết nối hoặc dữ liệu bị trùng");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

    }
}
