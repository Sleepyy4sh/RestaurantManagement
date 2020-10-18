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
        FormQLMenu parent;
        public DataFood_Fix(FormQLMenu parentf,string server = "DESKTOP-7N34GNC,1433", string database = "User")
        {
            string nameDB;
            using (StreamReader sr = new StreamReader("database.txt"))
            {
                nameDB = sr.ReadLine();
            }
            database = nameDB;
            this.parent = parentf;
            connString = @"Server=" + server + ";Database=" + database + ";User Id=sa;Password=abc123;";
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
                parent.Add(reader.GetString(0), reader.GetString(1),(Byte[])reader[2]);
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
            catch (Exception ex)
            {
                MessageBox.Show("Món ăn đã tồn tại", "Lổi trùng lặp");
                return false;
            }
        }
        public bool DeleteData(string name = "", string table = "MENU")
        {
            try
            {
                String sqlQuery = "DELETE FROM " + table +" WHERE NAME= @name";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@name", name);
                int rs = command.ExecuteNonQuery();
                if (rs != 1)
                {
                    throw new Exception("Failed Query");
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Món ăn "+name+ " không tồn tại", "Lỗi");
                return false;
            }
        }
    }
}
