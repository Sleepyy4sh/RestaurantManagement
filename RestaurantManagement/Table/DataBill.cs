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
    class DataBill
    {
        String connString;
        SqlConnection connection;
        FormMain parent;
        public DataBill()
        {
            initIn4Server();
            string nameDB;
            using (StreamReader sr = new StreamReader("database.txt"))
            {
                nameDB = sr.ReadLine();
            }
            connString = @"Server=" + server + ";Database=" + nameDB + ";User Id=" + ID + ";Password=" + Svpassword + ";";
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
        public bool InsertCTHD(string[] foods,int[] indexs,string TRIGIA, string TIME)
        {
            string id = InsertHoaDon(TRIGIA, TIME);
            if (id != "")
            {
                string table = "CTHD";
                //try
                //{
                    for (int i = 0; i < foods.Length; i++)
                    {
                        String sqlQuery = "insert into " + table + "( ID,NAMEFOOD,SOLUONG ) VALUES (@ID,@NAMEFOOD,@index)";
                        SqlCommand command = new SqlCommand(sqlQuery, connection);
                        command.Parameters.AddWithValue("@ID", id);
                        command.Parameters.AddWithValue("@NAMEFOOD", foods[i]);
                    command.Parameters.AddWithValue("@index", indexs[i]);
                    int rs = command.ExecuteNonQuery();
                        if (rs != 1)
                        {
                            throw new Exception("Failed Query");
                        }
                    }
                    return true;
                //}
                //catch
                //{
                //    MessageBox.Show("Thêm dữ liệu vào bàn thất bại", "Lỗi");
                //    return false;
                //}
            }
            else MessageBox.Show("false");
            return false;
        }
        public string InsertHoaDon(string TRIGIA, string TIME)
        {
            string table = "HD";
            //try
            //{
                int trigia = Int32.Parse(TRIGIA);
                MessageBox.Show(trigia.ToString());
                string id = "";
                String sqlQuery = "insert into " + table + "(TRIGIA,TIME) VALUES (@TRIGIA,@TIME)";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@TRIGIA", trigia);
                command.Parameters.AddWithValue("@TIME", TIME);
                MessageBox.Show(TIME);
                int rs = command.ExecuteNonQuery();

                sqlQuery = "select ID from " + table + " WHERE TRIGIA = @TRIGIAA AND @TIMEE = TIME";
                command = new SqlCommand(sqlQuery, connection);
                 command.Parameters.AddWithValue("@TRIGIAA", trigia);
                command.Parameters.AddWithValue("@TIMEE", TIME);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    id = reader.GetGuid(0).ToString();
                }
                reader.Close();
                return id;
            //}
            //catch
            //{
            //    MessageBox.Show("Thêm dữ liệu vào bàn thất bại", "Lỗi");
            //    return "";
            //}
        }
    }
}
