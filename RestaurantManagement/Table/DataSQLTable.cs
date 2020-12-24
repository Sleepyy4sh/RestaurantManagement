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
    class DataSQLTable
    {
        String connString;
        SqlConnection connection;
        FormMain parent;
        public DataSQLTable(FormMain parentf, string database = "User")
        {
            initIn4Server();
            string nameDB;
            using (StreamReader sr = new StreamReader("database.txt"))
            {
                nameDB = sr.ReadLine();
            }
            database = nameDB;
            this.parent = parentf;
            connString = @"Server=" + server + ";Database=" + database + ";User Id=" + ID + ";Password=" + Svpassword + ";";
            connection = new SqlConnection(connString);
            connection.Open();
        }
        string server, ID, Svpassword;
        void initIn4Server()
        {
            string[] in4 = File.ReadAllLines("inforServer.txt");
            server = in4[0];
            ID = in4[1];
            Svpassword = in4[2];
        }
        public void ReadListTable(string table = "Listtable")
        {
            string tmp = "";
            String sqlQuery = "select * from " + table;
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                if (reader.GetString(0) != tmp)
                {
                    parent.Add_Table(reader.GetString(0), reader.GetString(2));
                    tmp = reader.GetString(0);
                }
                else parent.SetTableNotEmpty(reader.GetString(0));
            }
            reader.Close();
        }  
        public void ReadListFood(string nameTable,string table = "Listtable")
        {
            String sqlQuery = "select * from " + table;
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                if (reader.GetString(0) == nameTable && reader.GetString(1) != "")
                    parent.Add_FoodINLIST(reader.GetString(1), reader.GetString(3));
            }
            reader.Close();
        }
        public void ReadToBILL(string nameTable, string table = "Listtable")
        {
            String sqlQuery = "select * from " + table+ " JOIN MENU ON ListTable.FOOD = MENU.NAME WHERE LISTTABLE.NAME = '"+nameTable +"'";
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                    parent.AddToBill(reader.GetString(1), reader.GetString(3),reader.GetString(5));
                //MessageBox.Show("d" + reader.GetString(3));
                //parent.Add_Table(reader.GetString(0), reader.GetString(2));
            }
            reader.Close();
        }
        public bool InSertData(string name,string status, string Food, string index)
        {
            string table = "ListTable";
            try
            {
                String sqlQuery = "insert into " + table + "(NAME,STATUS,FOOD,INDEXFOOD) VALUES (@name,@status,@food,@index)";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@food", Food);
                command.Parameters.AddWithValue("@index", index);
                int rs = command.ExecuteNonQuery();
                if (rs != 1)
                {
                    throw new Exception("Failed Query");
                }
                return true;
            }
            catch
            {
                //MessageBox.Show("Thêm dữ liệu vào bàn thất bại", "Lỗi");
                return false;
            }
        }
        public bool FixData(string nametemp, string name, string status,string foodtemp, string food,string Index)
        {
            string table = "listtable";
            try
            {
                String sqlQuery = "update " + table + " set name = @name , status = @status , Food = @food, indexfood = @index  where name = @nametemp and food = @foodtemp";
                //MessageBox.Show(sqlQuery);
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@food", food);
                command.Parameters.AddWithValue("@index", Index);
                command.Parameters.AddWithValue("@nametemp", nametemp);
                command.Parameters.AddWithValue("@foodtemp", foodtemp);
                int rs = command.ExecuteNonQuery();
                if (rs != 1)
                {
                    throw new Exception("Failed Query");
                }
                return true;
            }
            catch
            {
                //MessageBox.Show("Sửa thất bại", "Lổi");
                return false;
            }
        }
        public bool FixStatus(string name, string status)
        {
            string table = "listtable";
            try
            {
                String sqlQuery = "update " + table + " set status = @status where name = @name";
                //MessageBox.Show(sqlQuery);
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@status", status);
                int rs = command.ExecuteNonQuery();
                if (rs != 1)
                {
                    throw new Exception("Failed Query");
                }
                return true;
            }
            catch
            {
                //MessageBox.Show("Sửa thất bại", "Lổi");
                return false;
            }
        }
        public bool DeleteData(string nametable, string nameFood)
        {
            try
            {
                string table = "listtable";
                String sqlQuery = "DELETE FROM " + table + " WHERE name= @name and food = @food";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@name", nametable);
                command.Parameters.AddWithValue("@food", nameFood);
                int rs = command.ExecuteNonQuery();
                if (rs != 1)
                {
                    throw new Exception("Failed Query");
                }
                return true;
            }
            catch
            {
                //MessageBox.Show("Món ăn " + nameFood + " không tồn tại", "Lỗi");
                return false;
            }
        }
        public void ReadToPay(string table = "Listtable")
        {
            String sqlQuery = "select * from " + table;
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.HasRows)
            {
                if (reader.Read() == false) 
                    
                    break;
                //parent.Add_Table(reader.GetString(0), reader.GetString(2));
            }
            reader.Close();
        }
        public bool DeleteTable(string nametable)
        {
            try
            {
                string table = "listtable";
                String sqlQuery = "DELETE FROM " + table + " WHERE name= @name";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@name", nametable);
                int rs = command.ExecuteNonQuery();
                if (rs != 1)
                {
                    throw new Exception("Failed Query");
                }
                return true;
            }
            catch
            {
                //MessageBox.Show("Món ăn " + nameFood + " không tồn tại", "Lỗi");
                return false;
            }
        }
        public int CountFoodTable(string nametable)
        {
            String sqlQuery = "select Count(food) from listtable where name = '" + nametable + "'" ;
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader;
            bool kt = false;
            int i = 1;
                try
                {
                    reader = command.ExecuteReader();
                    while (reader.HasRows)
                    {
                        if (reader.Read() == false)
                        {
                            reader.Close();
                            return i;
                        }
                        i = reader.GetInt32(0);
                        reader.Close();
                    }
                    kt = true;
                }
                catch
                {
                    kt = false;
                }
            return i;
        }
        public bool ExchangeNameTable(string name1,string name2)
        {
            string tmp = name1.Remove(name1.Length - 1, 1) + '/';
            FixName(name1, tmp);
            string tmp2 = name2;
            FixName(name2, name1);
            FixName(tmp, tmp2);
            return true;
        }
        public bool FixName(string nametemp, string name)
        {
                string table = "listtable";
                try
                {
                    String sqlQuery = "update " + table + " set name = " + "'" + name +"'"+" where name =" + "'" + nametemp + "'";
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
                   // MessageBox.Show("Sửa thất bại", "Lỗi");
                    return false;
                }
        }
    }
}
