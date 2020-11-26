using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace RestaurantManagement
{
    class DataFood_ReadOnly
    {
        String connString;
        SqlConnection connection;
        Menu_Select parent;
        public DataFood_ReadOnly(Menu_Select parentf, string server = "DESKTOP-J6GHMMO", string database = "User")
        {
            string nameDB;
            using (StreamReader sr = new StreamReader("database.txt"))
            {
                nameDB = sr.ReadLine();
            }
            database = nameDB;
            this.parent = parentf;
            connString = @"Server=" + server + ";Database=" + database + ";User Id=sa;Password=Turtle19520253;";
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
                parent.Add(reader.GetString(0), reader.GetString(1), (Byte[])reader[2]);
            }
            reader.Close();
        }
    }
}
