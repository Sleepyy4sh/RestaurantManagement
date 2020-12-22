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

namespace RestaurantManagement
{
    public partial class FormMain : Form
    {
        bool isBill = false;
        string RCountInBill, RNameInBill;
        private void InitRevenue()
        {
            try
            {
                connString = @"Server=" + server + ";Database=" + nameDB + ";User Id=" + ID + ";Password=" + Svpassword + ";";
                connection = new SqlConnection(connString);
                connection.Open();

                //AddYear
                sqlQuery = "select YEAR(TIME) from HD group by YEAR(TIME)";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlDataReader reader = command.ExecuteReader();
                cbRYear.Items.Clear();
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    cbRYear.Items.Add(reader.GetInt32(0).ToString());
                }
                reader.Close();
            }
            catch
            {
                MessageBox.Show("Dữ liệu lỗi, vui lòng khởi động lại chương trình");
            }
            finally
            {
                connection.Close();
            }
        }

        private void cbRType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbRType.Text)
            {
                case "Năm":
                    lbRYear.Visible = false;
                    cbRYear.Visible = false;
                    cbRYear.SelectedIndex = -1;
                    lbRMonth.Visible = false;
                    cbRMonth.Visible = false;
                    cbRMonth.SelectedIndex = -1;
                    break;
                case "Tháng":
                    lbRYear.Visible = true;
                    cbRYear.Visible = true;
                    cbRMonth.SelectedIndex = -1;
                    lbRMonth.Visible = false;
                    cbRMonth.Visible = false;
                    break;
                case "Ngày":
                    lbRYear.Visible = true;
                    cbRYear.Visible = true;
                    lbRMonth.Visible = true;
                    cbRMonth.Visible = true;
                    break;
            }
        }

        private void btRWRenevue_Click(object sender, EventArgs e)
        {
            switch(cbRType.Text)
            {
                case "":
                    MessageBox.Show("Vui lòng chọn thời gian");
                    break;
                case "Năm":
                    try
                    {
                        connString = @"Server=" + server + ";Database=" + nameDB + ";User Id=" + ID + ";Password=" + Svpassword + ";";
                        connection = new SqlConnection(connString);
                        connection.Open();

                        sqlQuery = "select YEAR(TIME), (select top(1) NAMEFOOD from CTHD group by NAMEFOOD order by COUNT(SOLUONG) DESC), COUNT(ID), SUM(TRIGIA) from HD group by YEAR(TIME)";
                        SqlCommand command = new SqlCommand(sqlQuery, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        this.dgRevenue.EnableHeadersVisualStyles = false;
                        dgRevenue.Rows.Clear();
                        dgRevenue.Columns.Clear();
                        dgRevenue.Columns.Add("dgRYear", "Năm");
                        dgRevenue.Columns.Add("dgRBFood", "Món Bán Chạy Nhất");
                        dgRevenue.Columns.Add("dgRBill", "Tổng Số Hóa Đơn");
                        dgRevenue.Columns.Add("dgRIncome", "Doanh Thu");
                        while (reader.HasRows)
                        {
                            if (reader.Read() == false) break;
                            dgRevenue.Rows.Add(reader.GetInt32(0).ToString(), reader.GetString(1), reader.GetInt32(2).ToString(), reader.GetInt32(3).ToString());
                        }
                        this.dgRevenue.ClearSelection();
                        this.dgRevenue.CurrentCell = null;
                        reader.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Dữ liệu lỗi, vui lòng khởi động lại chương trình");
                    }
                    finally
                    {
                        connection.Close();
                    }
                    isBill = false;
                    break;
                case "Tháng":
                    if (cbRYear.Text == "")
                    {
                        MessageBox.Show("Chưa chọn năm");
                    }
                    else
                    try
                    {
                        connString = @"Server=" + server + ";Database=" + nameDB + ";User Id=" + ID + ";Password=" + Svpassword + ";";
                        connection = new SqlConnection(connString);
                        connection.Open();
                        sqlQuery = "select MONTH(TIME), (select top(1) NAMEFOOD from CTHD group by NAMEFOOD order by COUNT(SOLUONG) DESC), COUNT(ID), SUM(TRIGIA) from HD where YEAR(TIME) = @Year group by MONTH(TIME)";
                        SqlCommand command = new SqlCommand(sqlQuery, connection);
                        command.Parameters.AddWithValue("@Year", cbRYear.Text);
                        SqlDataReader reader = command.ExecuteReader();
                        this.dgRevenue.EnableHeadersVisualStyles = false;
                        dgRevenue.Rows.Clear();
                        dgRevenue.Columns.Clear();
                        dgRevenue.Columns.Add("dgRYear", "Tháng");
                        dgRevenue.Columns.Add("dgRBFood", "Món Bán Chạy Nhất");
                        dgRevenue.Columns.Add("dgRBill", "Tổng Số Hóa Đơn");
                        dgRevenue.Columns.Add("dgRIncome", "Doanh Thu");
                        while (reader.HasRows)
                        {
                            if (reader.Read() == false) break;
                            dgRevenue.Rows.Add(reader.GetInt32(0).ToString() + "/" + cbRYear.Text, reader.GetString(1), reader.GetInt32(2).ToString(), reader.GetInt32(3).ToString());
                        }
                        this.dgRevenue.ClearSelection();
                        this.dgRevenue.CurrentCell = null;
                        reader.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Dữ liệu lỗi, vui lòng khởi động lại chương trình");
                    }
                    finally
                    {
                        connection.Close();
                    }
                    isBill = false;
                    break;
                case "Ngày":
                    if (cbRYear.Text == "")
                    {
                        MessageBox.Show("Chưa chọn năm");
                    }
                    else
                    if (cbRMonth.Text == "")
                    {
                        MessageBox.Show("Chưa chọn tháng");
                    }
                    else
                        try
                        {
                            connString = @"Server=" + server + ";Database=" + nameDB + ";User Id=" + ID + ";Password=" + Svpassword + ";";
                            connection = new SqlConnection(connString);
                            connection.Open();
                            sqlQuery = "select DAY(TIME), (select top(1) NAMEFOOD from CTHD group by NAMEFOOD order by COUNT(SOLUONG) DESC), COUNT(ID), SUM(TRIGIA) from HD where YEAR(TIME) = @Year and MONTH(TIME) = @Month group by DAY(TIME)";
                            SqlCommand command = new SqlCommand(sqlQuery, connection);
                            command.Parameters.AddWithValue("@Year", cbRYear.Text);
                            command.Parameters.AddWithValue("@Month", cbRMonth.Text);
                            SqlDataReader reader = command.ExecuteReader();
                            this.dgRevenue.EnableHeadersVisualStyles = false;
                            dgRevenue.Rows.Clear();
                            dgRevenue.Columns.Clear();
                            dgRevenue.Columns.Add("dgRYear", "Ngày");
                            dgRevenue.Columns.Add("dgRBFood", "Món Bán Chạy Nhất");
                            dgRevenue.Columns.Add("dgRBill", "Tổng Số Hóa Đơn");
                            dgRevenue.Columns.Add("dgRIncome", "Doanh Thu");
                            while (reader.HasRows)
                            {
                                if (reader.Read() == false) break;
                                dgRevenue.Rows.Add(reader.GetInt32(0).ToString() + "/" + cbRMonth.Text + "/" + cbRYear.Text, reader.GetString(1), reader.GetInt32(2).ToString(), reader.GetInt32(3).ToString());
                            }
                            this.dgRevenue.ClearSelection();
                            this.dgRevenue.CurrentCell = null;
                            reader.Close();
                        }
                        catch
                        {
                            MessageBox.Show("Dữ liệu lỗi, vui lòng khởi động lại chương trình");
                        }
                        finally
                        {
                            connection.Close();
                        }
                    isBill = false;
                    break;
            }

        }

        private void btRWBill_Click(object sender, EventArgs e)
        {
            switch (cbRType.Text)
            {
                case "":
                    MessageBox.Show("Vui lòng chọn thời gian");
                    break;
                case "Năm":
                    try
                    {
                        connString = @"Server=" + server + ";Database=" + nameDB + ";User Id=" + ID + ";Password=" + Svpassword + ";";
                        connection = new SqlConnection(connString);
                        connection.Open();

                        sqlQuery = "select ID, TRIGIA, TIME from HD order by TIME";
                        SqlCommand command = new SqlCommand(sqlQuery, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        this.dgRevenue.EnableHeadersVisualStyles = false;
                        dgRevenue.Rows.Clear();
                        dgRevenue.Columns.Clear();
                        dgRevenue.Columns.Add("dgRID", "Mã Hóa Đơn");
                        dgRevenue.Columns.Add("dgRBTotal", "Trị Giá Hóa Đơn");
                        dgRevenue.Columns.Add("dgRYear", "Ngày Hóa Đơn");
                        while (reader.HasRows)
                        {
                            if (reader.Read() == false) break;
                            dgRevenue.Rows.Add(reader.GetGuid(0).ToString(), reader.GetInt32(1).ToString(), reader.GetDateTime(2).ToString("dd/MM/yyyy HH:mm"));
                        }
                        this.dgRevenue.ClearSelection();
                        this.dgRevenue.CurrentCell = null;
                        reader.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Dữ liệu lỗi, vui lòng khởi động lại chương trình");
                    }
                    finally
                    {
                        connection.Close();
                    }
                    isBill = true;
                    break;
                case "Tháng":
                    if (cbRYear.Text == "")
                    {
                        MessageBox.Show("Chưa chọn năm");
                    }
                    else
                        try
                        {
                            connString = @"Server=" + server + ";Database=" + nameDB + ";User Id=" + ID + ";Password=" + Svpassword + ";";
                            connection = new SqlConnection(connString);
                            connection.Open();
                            sqlQuery = "select ID, TRIGIA, TIME from HD where YEAR(TIME) = @Year order by TIME";
                            SqlCommand command = new SqlCommand(sqlQuery, connection);
                            command.Parameters.AddWithValue("@Year", cbRYear.Text);
                            SqlDataReader reader = command.ExecuteReader();
                            this.dgRevenue.EnableHeadersVisualStyles = false;
                            dgRevenue.Rows.Clear();
                            dgRevenue.Columns.Clear();
                            dgRevenue.Columns.Add("dgRID", "Mã Hóa Đơn");
                            dgRevenue.Columns.Add("dgRBTotal", "Trị Giá Hóa Đơn");
                            dgRevenue.Columns.Add("dgRYear", "Ngày Hóa Đơn");
                            while (reader.HasRows)
                            {
                                if (reader.Read() == false) break;
                                dgRevenue.Rows.Add(reader.GetGuid(0).ToString(), reader.GetInt32(1).ToString(), reader.GetDateTime(2).ToString("dd/MM/yyyy HH:mm"));
                            }
                            this.dgRevenue.ClearSelection();
                            this.dgRevenue.CurrentCell = null;
                            reader.Close();
                        }
                        catch
                        {
                            MessageBox.Show("Dữ liệu lỗi, vui lòng khởi động lại chương trình");
                        }
                        finally
                        {
                            connection.Close();
                        }
                    isBill = true;
                    break;
                case "Ngày":
                    if (cbRYear.Text == "")
                    {
                        MessageBox.Show("Chưa chọn năm");
                    }
                    else
                    if (cbRMonth.Text == "")
                    {
                        MessageBox.Show("Chưa chọn tháng");
                    }
                    else
                        try
                        {
                            connString = @"Server=" + server + ";Database=" + nameDB + ";User Id=" + ID + ";Password=" + Svpassword + ";";
                            connection = new SqlConnection(connString);
                            connection.Open();
                            sqlQuery = "select ID, TRIGIA, TIME from HD where YEAR(TIME) = @Year and MONTH(TIME) = @Month order by TIME";
                            SqlCommand command = new SqlCommand(sqlQuery, connection);
                            command.Parameters.AddWithValue("@Year", cbRYear.Text);
                            command.Parameters.AddWithValue("@Month", cbRMonth.Text);
                            SqlDataReader reader = command.ExecuteReader();
                            this.dgRevenue.EnableHeadersVisualStyles = false;
                            dgRevenue.Rows.Clear();
                            dgRevenue.Columns.Clear();
                            dgRevenue.Columns.Add("dgRID", "Mã Hóa Đơn");
                            dgRevenue.Columns.Add("dgRBTotal", "Trị Giá Hóa Đơn");
                            dgRevenue.Columns.Add("dgRYear", "Ngày Hóa Đơn");
                            while (reader.HasRows)
                            {
                                if (reader.Read() == false) break;
                                dgRevenue.Rows.Add(reader.GetGuid(0).ToString(), reader.GetInt32(1).ToString(), reader.GetDateTime(2).ToString("dd/MM/yyyy HH:mm"));
                            }
                            this.dgRevenue.ClearSelection();
                            this.dgRevenue.CurrentCell = null;
                            reader.Close();
                        }
                        catch
                        {
                            MessageBox.Show("Dữ liệu lỗi, vui lòng khởi động lại chương trình");
                        }
                        finally
                        {
                            connection.Close();
                        }
                    isBill = true;
                    break;
            }
        }

        private void btRUpdate_Click(object sender, EventArgs e)
        {
            InitRevenue();
        }


        private void dgRevenue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && isBill)
            {
                string IDB = dgRevenue.CurrentRow.Cells[0].Value.ToString();
                try
                {
                    connString = @"Server=" + server + ";Database=" + nameDB + ";User Id=" + ID + ";Password=" + Svpassword + ";";
                    connection = new SqlConnection(connString);
                    connection.Open();

                    sqlQuery = "select NAMEFOOD, SOLUONG from CTHD where ID = @Id";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@Id", IDB);
                    SqlDataReader reader = command.ExecuteReader();
                    RCountInBill = "";
                    RNameInBill = "";
                    fpRBDetail.Controls.Clear();
                    fpRBDetail.Controls.Add(fpRlbName);
                    fpRBDetail.Controls.Add(fpRlbCnt);
                    while (reader.HasRows)
                    {
                        Label n = new Label();
                        Label w = new Label();
                        Label c = new Label();
                        n.AutoSize = false;
                        w.AutoSize = false;
                        c.AutoSize = false;
                        n.Size = fplbcName.Size;
                        w.Size = fplbcW.Size;
                        c.Size = fplbcCnt.Size;
                        n.Font = new Font("Microsoft Sans Serif", 10);
                        c.Font = new Font("Microsoft Sans Serif", 10);
                        c.TextAlign = ContentAlignment.TopCenter;
                        if (reader.Read() == false) break;
                        RNameInBill = reader.GetString(0);
                        RCountInBill = reader.GetInt32(1).ToString();
                        n.Text = RNameInBill; 
                        c.Text = RCountInBill;
                        fpRBDetail.Controls.Add(n);
                        fpRBDetail.Controls.Add(w);
                        fpRBDetail.Controls.Add(c);
                    }
                    reader.Close();
                }
                catch
                {
                    MessageBox.Show("Dữ liệu lỗi, vui lòng khởi động lại chương trình");
                }
                finally
                {
                    connection.Close();
                }
            }
        }


    }
}
