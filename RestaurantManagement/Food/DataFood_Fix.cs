using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace RestaurantManagement
{
    class DataFood_Fix
    {
        String connString;
        SqlConnection connection;
        FormMain parent;
        public DataFood_Fix()
        {
            initIn4Server();
        }
        string server, ID, Svpassword;
        void initIn4Server()
        {
            string[] in4 = File.ReadAllLines("inforServer.txt");
            server = in4[0];
            ID = in4[1];
            Svpassword = in4[2];
        }
        public DataFood_Fix(FormMain parentf, string database = "User")
        {
            initIn4Server();
            string nameDB;
            using (StreamReader sr = new StreamReader("database.txt"))
            {
                nameDB = sr.ReadLine();
            }
            database = nameDB;
            this.parent = parentf;
            connString = @"Server=" + server + ";Database=" + database + ";User Id="+ ID+";Password="+Svpassword+";";

            connection = new SqlConnection(connString);
            connection.Open();
        }
        public void ReadDATA(string table = "MENU")
        {
            String sqlQuery = "select * from " + table;
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                parent.Add_Food(reader.GetString(0), reader.GetString(1), (Byte[])reader[2]);
            }
            reader.Close();
        }
        public bool InSertData(string name, string price, Byte[] bye)
        {
            string table = "Menu";
            try
            {
                String sqlQuery = "insert into " + table + "(NAME,PRICE,IMAGE) VALUES (@name,@price,@Image)";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@price", price);
                SqlParameter parImage = new SqlParameter("@Image", SqlDbType.Image);
                parImage.Value = bye;
                command.Parameters.Add(parImage);
                int rs = command.ExecuteNonQuery();
                if (rs != 1)
                {
                    throw new Exception("Failed Query");
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Món ăn đã tồn tại", "Lổi trùng lặp");
                return false;
            }
        }
        public bool FixData(string nametemp, string name, string price, Byte[] bye)
        {
            string table = "Menu";
            try
            {
                String sqlQuery = "update " + table + " set name = " + "'" + name + "'" + ", price = " + "'" + price + "'" + ", image = @Image" + " where name =" + "'" + nametemp + "'";
                MessageBox.Show(sqlQuery);
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlParameter parImage = new SqlParameter("@Image", SqlDbType.Image);
                parImage.Value = bye;
                command.Parameters.Add(parImage);
                int rs = command.ExecuteNonQuery();
                if (rs != 1)
                {
                    throw new Exception("Failed Query");
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Sửa thất bại", "Lổi");
                return false;
            }
        }
        public bool FixDataWithoutImage(string nametemp, string name, string price)
        {
            string table = "Menu";
            try
            {
                String sqlQuery = "update " + table + " set name = " + "'" + name + "'" + ", price = " + "'" + price + "'" + " where name =" + "'" + nametemp + "'";
                //MessageBox.Show(sqlQuery);
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                int rs = command.ExecuteNonQuery();
                if (rs != 1)
                {
                    throw new Exception("Failed Query");
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Sửa thất bại", "Lổi");
                return false;
            }
        }
        public bool DeleteData(string name = "", string table = "MENU")
        {
            try
            {
                String sqlQuery = "DELETE FROM " + table + " WHERE NAME= @name";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@name", name);
                int rs = command.ExecuteNonQuery();
                if (rs != 1)
                {
                    throw new Exception("Failed Query");
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Món ăn " + name + " không tồn tại", "Lỗi");
                return false;
            }
        }
    }
}
