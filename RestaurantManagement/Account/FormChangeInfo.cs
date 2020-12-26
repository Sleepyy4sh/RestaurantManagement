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
using System.Data.SqlClient;
using System.Globalization;

namespace RestaurantManagement
{
    public partial class FormChangeInfo : Form
    {
        string fname, dob, pnumber, address, icnumber, email;
        string server, ID, Svpassword;

        public FormChangeInfo(string s1, string s2, string s3, string s4, string s5, string s6) // old infor
        {
            this.fname = s1;
            this.dob = s2;
            this.address = s3;
            this.pnumber = s4;
            this.icnumber = s5;
            this.email = s6;

            InitializeComponent();
            initIn4Server();

            tbSFname.Text = fname;
            tbSDoB.Text = dob;
            tbSAddress.Text = address;
            tbSPnumber.Text = pnumber;
            tbSICnumber.Text = icnumber;
            tbSEmail.Text = email;
            ReSize();
        }

        void initIn4Server()
        {
            string[] in4 = File.ReadAllLines("inforServer.txt");
            server = in4[0];
            ID = in4[1];
            Svpassword = in4[2];
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
                MessageBox.Show("Địa chỉ không hợp lệ");
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

        private void btSaveInfo_Click(object sender, EventArgs e)
        {
            if (!CheckFormat())
            {
                return;
            }

            try
            {
                string nameDB;
                using (StreamReader sr = new StreamReader("database.txt"))
                {
                    nameDB = sr.ReadLine();
                }
                String connString = @"Server=" + server + ";Database=" + nameDB + ";User Id=" + ID + ";Password=" + Svpassword + ";";
                SqlConnection connection = new SqlConnection(connString);
                connection.Open();

                String sqlQuery = "UPDATE NV SET " +
                    "FULLNAME = '" + tbSFname.Text + "', " +
                    "DOB = '" + tbSDoB.Text + "', " +
                    "ADDRESS = '" + tbSAddress.Text + "', " +
                    "PHONENUMBER = '" + tbSPnumber.Text + "', " +
                    "ICNUMBER = '" + tbSICnumber.Text + "', " +
                    "EMAIL = '" + tbSEmail.Text + "' " +
                    "WHERE PHONENUMBER = '" + pnumber + "'";

                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Đã cập nhật thông tin");
                this.Close();
            }
            catch 
            {
                MessageBox.Show("Số điện thoại đã tồn tại");
            }

        }

        

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
