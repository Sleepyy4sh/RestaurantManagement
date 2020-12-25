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

            tbFname.Text = fname;
            tbDoB.Text = dob;
            tbAddress.Text = address;
            tbPnumber.Text = pnumber;
            tbICnumber.Text = icnumber;
            tbEmail.Text = email;
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

            if (tbFname.Text == "" || tbFname.Text[0] == ' ' || tbFname.Text.Contains("  "))
            {
                MessageBox.Show("Tên không hợp lệ");
                return false;
            }
            if (tbPnumber.Text == "" || tbPnumber.Text.Contains(" "))
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                return false;
            }
            if (tbAddress.Text == "" || tbAddress.Text.Contains("  "))
            {
                MessageBox.Show("Địa chỉ không hợp lệ");
                return false;
            }
            if (tbDoB.Text == "" || (!DateTime.TryParseExact(tbDoB.Text, "M/d/yyyy", enUS, DateTimeStyles.None, out dt)))
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                return false;
            }
            if (tbICnumber.Text == "" || tbICnumber.Text.Contains("  "))
            {
                MessageBox.Show("CMND/CCCD không hợp lệ");
                return false;
            }
            if (tbEmail.Text == "" || tbEmail.Text.Contains("  ") || !tbEmail.Text.Contains("@") || !tbEmail.Text.Contains("."))
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
                    "FULLNAME = '" + tbFname.Text + "', " +
                    "DOB = '" + tbDoB.Text + "', " +
                    "ADDRESS = '" + tbAddress.Text + "', " +
                    "PHONENUMBER = '" + tbPnumber.Text + "', " +
                    "ICNUMBER = '" + tbICnumber.Text + "', " +
                    "EMAIL = '" + tbEmail.Text + "' " +
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
