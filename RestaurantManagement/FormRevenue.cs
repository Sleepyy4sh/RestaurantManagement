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
    public partial class FormMain : Form
    {
        bool isBill = false;
        string RCountInBill, RNameInBill, RPriceInBill;
        long TotalBill;
        private void InitRevenue()
        {
            lbRBDCost.Text = "";
            lbRBDDiscount.Text = "";
            lbRBDTotal.Text = "";
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
                cbRMonth.Items.Clear();
                cbRDay.Items.Clear();
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
            if (cbRYear.Items.Count == 0)
            {
                MessageBox.Show("Chưa có hóa đơn được phát sinh");
                return;
            }
            switch (cbRType.Text)
            {
                case "Năm":
                    lbRYear.Visible = true;
                    cbRYear.Visible = true;
                    cbRMonth.SelectedIndex = -1;
                    lbRMonth.Visible = false;
                    cbRMonth.Visible = false;
                    cbRDay.SelectedIndex = -1;
                    lbRDay.Visible = false;
                    cbRDay.Visible = false;
                    break;
                case "Tháng":
                    lbRYear.Visible = true;
                    cbRYear.Visible = true;
                    lbRMonth.Visible = true;
                    cbRMonth.Visible = true;
                    cbRDay.SelectedIndex = -1;
                    lbRDay.Visible = false;
                    cbRDay.Visible = false;
                    break;
                case "Ngày":
                    lbRYear.Visible = true;
                    cbRYear.Visible = true;
                    lbRMonth.Visible = true;
                    cbRMonth.Visible = true;
                    lbRDay.Visible = true;
                    cbRDay.Visible = true;
                    break;
            }
        }

        private void cbRYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbRMonth.Items.Clear();
            cbRDay.Items.Clear();
            try
            {
                connString = @"Server=" + server + ";Database=" + nameDB + ";User Id=" + ID + ";Password=" + Svpassword + ";";
                connection = new SqlConnection(connString);
                connection.Open();
                sqlQuery = "select DISTINCT MONTH(TIME) from HD where YEAR(TIME) = @Year";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@Year", cbRYear.Text);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    cbRMonth.Items.Add(reader.GetInt32(0).ToString());
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
        }

        private void cbRMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbRDay.Items.Clear();
            try
            {
                connString = @"Server=" + server + ";Database=" + nameDB + ";User Id=" + ID + ";Password=" + Svpassword + ";";
                connection = new SqlConnection(connString);
                connection.Open();
                sqlQuery = "select DISTINCT DAY(TIME) from HD where YEAR(TIME) = @Year and MONTH(TIME) = @MONTH";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@Year", cbRYear.Text);
                command.Parameters.AddWithValue("@Month", cbRMonth.Text);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    cbRDay.Items.Add(reader.GetInt32(0).ToString());
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
        }

        private void btRWRenevue_Click(object sender, EventArgs e)
        {
            switch(cbRType.Text)
            {
                case "":
                    MessageBox.Show("Vui lòng chọn thời gian");
                    break;
                case "Năm":
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

                        sqlQuery = "select MONTH(TIME), COUNT(ID), SUM(TRIGIA) from HD where YEAR(TIME) = @Year group by MONTH(TIME)";
                        SqlCommand command = new SqlCommand(sqlQuery, connection);
                        command.Parameters.AddWithValue("@Year", cbRYear.Text);
                        SqlDataReader reader = command.ExecuteReader();
                        this.dgRevenue.EnableHeadersVisualStyles = false;
                        dgRevenue.Rows.Clear();
                        dgRevenue.Columns.Clear();
                        dgRevenue.Columns.Add("dgRYear", "Tháng");
                        dgRevenue.Columns.Add("dgRBill", "Tổng Số Hóa Đơn");
                        dgRevenue.Columns.Add("dgRIncome", "Doanh Thu");
                        while (reader.HasRows)
                        {
                            if (reader.Read() == false) break;
                            dgRevenue.Rows.Add(reader.GetInt32(0).ToString() + "/" +cbRYear.Text, reader.GetInt32(1).ToString(), CurrencyFormat(reader.GetInt64(2) * 1000) + " VND");
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

                            sqlQuery = "select DAY(TIME), COUNT(ID), SUM(TRIGIA) from HD where YEAR(TIME) = @Year and MONTH(TIME) = @Month group by DAY(TIME)";
                            SqlCommand command = new SqlCommand(sqlQuery, connection);
                            command.Parameters.AddWithValue("@Year", cbRYear.Text);
                            command.Parameters.AddWithValue("@Month", cbRMonth.Text);
                            SqlDataReader reader = command.ExecuteReader();
                            this.dgRevenue.EnableHeadersVisualStyles = false;
                            dgRevenue.Rows.Clear();
                            dgRevenue.Columns.Clear();
                            dgRevenue.Columns.Add("dgRYear", "Ngày");
                            dgRevenue.Columns.Add("dgRBill", "Tổng Số Hóa Đơn");
                            dgRevenue.Columns.Add("dgRIncome", "Doanh Thu");
                            while (reader.HasRows)
                            {
                                if (reader.Read() == false) break;
                                dgRevenue.Rows.Add(reader.GetInt32(0).ToString() + "/" + cbRMonth.Text + "/" + cbRYear.Text, reader.GetInt32(1).ToString(), CurrencyFormat(reader.GetInt64(2) * 1000) + " VND");
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
                    if (cbRDay.Text == "")
                    {
                        MessageBox.Show("Chưa chọn ngày");
                    }
                    else
                    try
                        {
                            connString = @"Server=" + server + ";Database=" + nameDB + ";User Id=" + ID + ";Password=" + Svpassword + ";";
                            connection = new SqlConnection(connString);
                            connection.Open();
                            sqlQuery = "select DAY(TIME), COUNT(ID), SUM(TRIGIA) from HD where YEAR(TIME) = @Year and MONTH(TIME) = @Month and DAY(TIME) = @Day group by DAY(TIME)";
                            SqlCommand command = new SqlCommand(sqlQuery, connection);
                            command.Parameters.AddWithValue("@Year", cbRYear.Text);
                            command.Parameters.AddWithValue("@Month", cbRMonth.Text);
                            command.Parameters.AddWithValue("@Day", cbRDay.Text);
                            SqlDataReader reader = command.ExecuteReader();
                            this.dgRevenue.EnableHeadersVisualStyles = false;
                            dgRevenue.Rows.Clear();
                            dgRevenue.Columns.Clear();
                            dgRevenue.Columns.Add("dgRYear", "Ngày");
                            dgRevenue.Columns.Add("dgRBill", "Tổng Số Hóa Đơn");
                            dgRevenue.Columns.Add("dgRIncome", "Doanh Thu");
                            while (reader.HasRows)
                            {
                                if (reader.Read() == false) break;
                                dgRevenue.Rows.Add(reader.GetInt32(0).ToString() + "/" + cbRMonth.Text + "/" + cbRYear.Text, reader.GetInt32(1).ToString(), CurrencyFormat(reader.GetInt64(2) * 1000) + " VND");
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

        private void btRUpdate_Click(object sender, EventArgs e)
        {
            InitRevenue();
        }

        private string CurrencyFormat(long c)
        {
            return string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", c);
        }

        private string GetBillInfo(long cost, int discount, int type)
        {
            cost *= 1000;

            if (discount == 0)
            {
                TotalBill = cost;
                return "Không";
            }
            if (type == 0)
            {
                TotalBill = cost - cost * discount / 100;
                return discount.ToString() + "%";
            }
            else
            {
                TotalBill = cost - discount;
                return CurrencyFormat(discount) + " VND";
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

                            sqlQuery = "select ID, TRIGIA, TIME, GIAMGIA, TYPE from HD where YEAR(TIME) = @Year order by TIME";
                            SqlCommand command = new SqlCommand(sqlQuery, connection);
                            command.Parameters.AddWithValue("@Year", cbRYear.Text);
                            SqlDataReader reader = command.ExecuteReader();
                            this.dgRevenue.EnableHeadersVisualStyles = false;
                            dgRevenue.Rows.Clear();
                            dgRevenue.Columns.Clear();
                            dgRevenue.Columns.Add("dgRID", "Mã Hóa Đơn");
                            dgRevenue.Columns.Add("dgRBCost", "Tổng Hóa Đơn");
                            dgRevenue.Columns.Add("dgDiscount", "Giảm Giá");
                            dgRevenue.Columns.Add("dgRTotal", "Thành Tiền");
                            dgRevenue.Columns.Add("dgRYear", "Ngày Hóa Đơn");
                            while (reader.HasRows)
                            {
                                if (reader.Read() == false) break;
                                dgRevenue.Rows.Add(reader.GetGuid(0).ToString(), CurrencyFormat(reader.GetInt64(1) * 1000) + " VND", GetBillInfo(reader.GetInt64(1), reader.GetInt32(3), reader.GetInt32(4)), CurrencyFormat(TotalBill) + " VND", reader.GetDateTime(2).ToString("dd/MM/yyyy HH:mm"));
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
                            sqlQuery = "select ID, TRIGIA, TIME, GIAMGIA, TYPE from HD where YEAR(TIME) = @Year and MONTH(TIME) = @Month order by TIME";
                            SqlCommand command = new SqlCommand(sqlQuery, connection);
                            command.Parameters.AddWithValue("@Year", cbRYear.Text);
                            command.Parameters.AddWithValue("@Month", cbRMonth.Text);
                            SqlDataReader reader = command.ExecuteReader();
                            this.dgRevenue.EnableHeadersVisualStyles = false;
                            dgRevenue.Rows.Clear();
                            dgRevenue.Columns.Clear();
                            dgRevenue.Columns.Add("dgRID", "Mã Hóa Đơn");
                            dgRevenue.Columns.Add("dgRBCost", "Tổng Hóa Đơn");
                            dgRevenue.Columns.Add("dgDiscount", "Giảm Giá");
                            dgRevenue.Columns.Add("dgRTotal", "Thành Tiền");
                            dgRevenue.Columns.Add("dgRYear", "Ngày Hóa Đơn");
                            while (reader.HasRows)
                            {
                                if (reader.Read() == false) break;
                                dgRevenue.Rows.Add(reader.GetGuid(0).ToString(), CurrencyFormat(reader.GetInt64(1) * 1000) + " VND", GetBillInfo(reader.GetInt64(1), reader.GetInt32(3), reader.GetInt32(4)), CurrencyFormat(TotalBill) + " VND", reader.GetDateTime(2).ToString("dd/MM/yyyy HH:mm"));
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
                    if (cbRDay.Text == "")
                    {
                        MessageBox.Show("Chưa chọn tháng");
                    }
                    else
                        try
                        {
                            connString = @"Server=" + server + ";Database=" + nameDB + ";User Id=" + ID + ";Password=" + Svpassword + ";";
                            connection = new SqlConnection(connString);
                            connection.Open();
                            sqlQuery = "select ID, TRIGIA, TIME, GIAMGIA, TYPE from HD where YEAR(TIME) = @Year and MONTH(TIME) = @Month and DAY(TIME) = @Day order by TIME";
                            SqlCommand command = new SqlCommand(sqlQuery, connection);
                            command.Parameters.AddWithValue("@Year", cbRYear.Text);
                            command.Parameters.AddWithValue("@Month", cbRMonth.Text);
                            command.Parameters.AddWithValue("@Day", cbRDay.Text);
                            SqlDataReader reader = command.ExecuteReader();
                            this.dgRevenue.EnableHeadersVisualStyles = false;
                            dgRevenue.Rows.Clear();
                            dgRevenue.Columns.Clear();
                            dgRevenue.Columns.Add("dgRID", "Mã Hóa Đơn");
                            dgRevenue.Columns.Add("dgRBCost", "Tổng Hóa Đơn");
                            dgRevenue.Columns.Add("dgDiscount", "Giảm Giá");
                            dgRevenue.Columns.Add("dgRTotal", "Thành Tiền");
                            dgRevenue.Columns.Add("dgRYear", "Ngày Hóa Đơn");
                            while (reader.HasRows)
                            {
                                if (reader.Read() == false) break;
                                dgRevenue.Rows.Add(reader.GetGuid(0).ToString(), CurrencyFormat(reader.GetInt64(1) * 1000) + " VND", GetBillInfo(reader.GetInt64(1), reader.GetInt32(3), reader.GetInt32(4)), CurrencyFormat(TotalBill) + " VND", reader.GetDateTime(2).ToString("dd/MM/yyyy HH:mm"));
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

        private void dgRevenue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex >= 0))
                return;
            if (isBill)
            {
                lbRBDId.Text = dgRevenue.CurrentRow.Cells[0].Value.ToString();
                try
                {
                    connString = @"Server=" + server + ";Database=" + nameDB + ";User Id=" + ID + ";Password=" + Svpassword + ";";
                    connection = new SqlConnection(connString);
                    connection.Open();

                    sqlQuery = "select NAMEFOOD, SOLUONG, PRICEFOOD from CTHD where ID = @Id";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@Id", lbRBDId.Text);
                    SqlDataReader reader = command.ExecuteReader();
                    RCountInBill = "";
                    RNameInBill = "";
                    fpRBDetail.Controls.Clear();
                    fpRBDetail.Controls.Add(fpRlbName);
                    fpRBDetail.Controls.Add(fpRlbCnt);
                    while (reader.HasRows)
                    {
                        Label n = new Label();
                        Label p = new Label();
                        Label c = new Label();
                        n.AutoSize = false;
                        c.AutoSize = false;
                        p.Size = fplbcP.Size;
                        n.Size = fplbcName.Size;
                        c.Size = fplbcCnt.Size;
                        p.Size = fplbcP.Size;
                        n.Font = new Font("Microsoft Sans Serif", 10);
                        c.Font = new Font("Microsoft Sans Serif", 10);
                        c.TextAlign = ContentAlignment.TopCenter;
                        p.TextAlign = ContentAlignment.TopCenter;
                        if (reader.Read() == false) break;
                        RNameInBill = reader.GetString(0);
                        RCountInBill = reader.GetInt32(1).ToString();
                        RPriceInBill = reader.GetString(2);
                        n.Text = RNameInBill; 
                        c.Text = RCountInBill;
                        p.Text = RPriceInBill;
                        fpRBDetail.Controls.Add(n);
                        fpRBDetail.Controls.Add(p);
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
                lbRBDCost.Text = dgRevenue.CurrentRow.Cells[1].Value.ToString();
                lbRBDDiscount.Text = dgRevenue.CurrentRow.Cells[2].Value.ToString();
                lbRBDTotal.Text = dgRevenue.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                switch(cbRType.Text)
                {
                    case "Năm":
                        try
                        {
                            connString = @"Server=" + server + ";Database=" + nameDB + ";User Id=" + ID + ";Password=" + Svpassword + ";";
                            connection = new SqlConnection(connString);
                            connection.Open();

                            sqlQuery = "SELECT NAMEFOOD, SUM(SOLUONG), PRICEFOOD  from CTHD join HD on CTHD.ID = HD.ID  where YEAR(TIME) = @Year AND MONTH(TIME) = @Month group by namefood, PRICEFOOD";
                            SqlCommand command = new SqlCommand(sqlQuery, connection);
                            command.Parameters.AddWithValue("@Year", cbRYear.Text);
                            string tmp = dgRevenue.CurrentRow.Cells[0].Value.ToString();
                            if (tmp[1] != '/')
                                tmp = tmp.Remove(2);
                            else
                                tmp = tmp.Remove(1);
                            command.Parameters.AddWithValue("@Month", tmp);
                            SqlDataReader reader = command.ExecuteReader();
                            RCountInBill = "";
                            RNameInBill = "";
                            fpRBDetail.Controls.Clear();
                            fpRBDetail.Controls.Add(fpRlbName);
                            fpRBDetail.Controls.Add(fpRlbCnt);
                            while (reader.HasRows)
                            {
                                Label n = new Label();
                                Label p = new Label();
                                Label c = new Label();
                                n.AutoSize = false;
                                c.AutoSize = false;
                                p.Size = fplbcP.Size;
                                n.Size = fplbcName.Size;
                                c.Size = fplbcCnt.Size;
                                p.Size = fplbcP.Size;
                                n.Font = new Font("Microsoft Sans Serif", 10);
                                c.Font = new Font("Microsoft Sans Serif", 10);
                                c.TextAlign = ContentAlignment.TopCenter;
                                p.TextAlign = ContentAlignment.TopCenter;
                                if (reader.Read() == false) break;
                                RNameInBill = reader.GetString(0);
                                RCountInBill = reader.GetInt32(1).ToString();
                                RPriceInBill = reader.GetString(2);
                                n.Text = RNameInBill;
                                c.Text = RCountInBill;
                                p.Text = RPriceInBill;
                                fpRBDetail.Controls.Add(n);
                                fpRBDetail.Controls.Add(p);
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
                        break;
                    case "Tháng":
                        try
                        {
                            connString = @"Server=" + server + ";Database=" + nameDB + ";User Id=" + ID + ";Password=" + Svpassword + ";";
                            connection = new SqlConnection(connString);
                            connection.Open();

                            sqlQuery = "SELECT NAMEFOOD, SUM(SOLUONG), PRICEFOOD  from CTHD join HD on CTHD.ID = HD.ID  where YEAR(TIME) = @Year AND MONTH(TIME) = @Month and DAY(TIME) = @Day group by namefood, PRICEFOOD";
                            SqlCommand command = new SqlCommand(sqlQuery, connection);
                            command.Parameters.AddWithValue("@Year", cbRYear.Text);
                            string tmpd = dgRevenue.CurrentRow.Cells[0].Value.ToString();
                            if (tmpd[1] != '/')
                                tmpd = tmpd.Remove(2);
                            else
                                tmpd = tmpd.Remove(1);
                            string tmp = dgRevenue.CurrentRow.Cells[0].Value.ToString();
                            tmp = tmp.Remove(0, tmpd.Length + 1);
                            if (tmp[1] != '/')
                                tmp = tmp.Remove(2);
                            else
                                tmp = tmp.Remove(1);
                            command.Parameters.AddWithValue("@Month", tmp);
                            command.Parameters.AddWithValue("@Day", tmpd);
                            SqlDataReader reader = command.ExecuteReader();
                            RCountInBill = "";
                            RNameInBill = "";
                            fpRBDetail.Controls.Clear();
                            fpRBDetail.Controls.Add(fpRlbName);
                            fpRBDetail.Controls.Add(fpRlbCnt);
                            while (reader.HasRows)
                            {
                                Label n = new Label();
                                Label p = new Label();
                                Label c = new Label();
                                n.AutoSize = false;
                                c.AutoSize = false;
                                p.Size = fplbcP.Size;
                                n.Size = fplbcName.Size;
                                c.Size = fplbcCnt.Size;
                                p.Size = fplbcP.Size;
                                n.Font = new Font("Microsoft Sans Serif", 10);
                                c.Font = new Font("Microsoft Sans Serif", 10);
                                c.TextAlign = ContentAlignment.TopCenter;
                                p.TextAlign = ContentAlignment.TopCenter;
                                if (reader.Read() == false) break;
                                RNameInBill = reader.GetString(0);
                                RCountInBill = reader.GetInt32(1).ToString();
                                RPriceInBill = reader.GetString(2);
                                n.Text = RNameInBill;
                                c.Text = RCountInBill;
                                p.Text = RPriceInBill;
                                fpRBDetail.Controls.Add(n);
                                fpRBDetail.Controls.Add(p);
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
                        break;
                    case "Ngày":
                        try
                        {
                            connString = @"Server=" + server + ";Database=" + nameDB + ";User Id=" + ID + ";Password=" + Svpassword + ";";
                            connection = new SqlConnection(connString);
                            connection.Open();

                            sqlQuery = "SELECT NAMEFOOD, SUM(SOLUONG), PRICEFOOD  from CTHD join HD on CTHD.ID = HD.ID  where YEAR(TIME) = @Year AND MONTH(TIME) = @Month and DAY(TIME) = @Day group by namefood, PRICEFOOD";
                            SqlCommand command = new SqlCommand(sqlQuery, connection);
                            command.Parameters.AddWithValue("@Year", cbRYear.Text);
                            string tmpd = dgRevenue.CurrentRow.Cells[0].Value.ToString();
                            if (tmpd[1] != '/')
                                tmpd = tmpd.Remove(2);
                            else
                                tmpd = tmpd.Remove(1);
                            string tmp = dgRevenue.CurrentRow.Cells[0].Value.ToString();
                            tmp = tmp.Remove(0, tmpd.Length + 1);
                            if (tmp[1] != '/')
                                tmp = tmp.Remove(2);
                            else
                                tmp = tmp.Remove(1);
                            command.Parameters.AddWithValue("@Month", tmp);
                            command.Parameters.AddWithValue("@Day", tmpd);
                            SqlDataReader reader = command.ExecuteReader();
                            RCountInBill = "";
                            RNameInBill = "";
                            fpRBDetail.Controls.Clear();
                            fpRBDetail.Controls.Add(fpRlbName);
                            fpRBDetail.Controls.Add(fpRlbCnt);
                            while (reader.HasRows)
                            {
                                Label n = new Label();
                                Label p = new Label();
                                Label c = new Label();
                                n.AutoSize = false;
                                c.AutoSize = false;
                                p.Size = fplbcP.Size;
                                n.Size = fplbcName.Size;
                                c.Size = fplbcCnt.Size;
                                p.Size = fplbcP.Size;
                                n.Font = new Font("Microsoft Sans Serif", 10);
                                c.Font = new Font("Microsoft Sans Serif", 10);
                                c.TextAlign = ContentAlignment.TopCenter;
                                p.TextAlign = ContentAlignment.TopCenter;
                                if (reader.Read() == false) break;
                                RNameInBill = reader.GetString(0);
                                RCountInBill = reader.GetInt32(1).ToString();
                                RPriceInBill = reader.GetString(2);
                                n.Text = RNameInBill;
                                c.Text = RCountInBill;
                                p.Text = RPriceInBill;
                                fpRBDetail.Controls.Add(n);
                                fpRBDetail.Controls.Add(p);
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
                        break;
                }
            }
        }


    }
}
