using System;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Globalization;

namespace RestaurantManagement
{
    public partial class FormMain : Form
    {
        private void LoadDG()
        {
            try
            {
                connString = @"Server=" + server + ";Database=" + nameDB + ";User Id=" + ID + ";Password=" + Svpassword + ";";
                connection = new SqlConnection(connString);
                connection.Open();

                sqlQuery = "select * from NV";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    this.dgStaff.Rows.Add(reader.GetString(0), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetDateTime(5).ToString("MM/dd/yyyy"), reader.GetString(6), reader.GetString(7));
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

        private void UpdateTbStaff(string s1 ="", string s2 ="", string s3="", string s4 ="", string s5 ="", string s6 ="", string s7 ="")
        {
            tbSUsername.Text = s1;
            tbSFname.Text = s2;
            tbSPnumber.Text = s3;
            tbSAddress.Text = s4;
            tbSDoB.Text = s5;
            tbSICnumber.Text = s6;
            tbSEmail.Text = s7;
        }

        private void InitDG()
        {
            this.dgStaff.ClearSelection();
            this.dgStaff.CurrentCell = null;
            this.dgStaff.EnableHeadersVisualStyles = false;
        }

        private void dgStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UpdateTbStaff
                (
                    this.dgStaff.CurrentRow.Cells[0].Value.ToString(),
                    this.dgStaff.CurrentRow.Cells[1].Value.ToString(),
                    this.dgStaff.CurrentRow.Cells[2].Value.ToString(),
                    this.dgStaff.CurrentRow.Cells[3].Value.ToString(),
                    this.dgStaff.CurrentRow.Cells[4].Value.ToString(),
                    this.dgStaff.CurrentRow.Cells[5].Value.ToString(),
                    this.dgStaff.CurrentRow.Cells[6].Value.ToString()
                );
            }
        }

        private void InitStaff()
        {
            initIn4Server();
            LoadDG();
            InitDG();
        }

        private void btSDelete_Click(object sender, EventArgs e)
        {
            if (this.dgStaff.SelectedRows.Count > 0)
            {
                //DeleteAccount
                try
                {
                    connection = new SqlConnection(connString);
                    connection.Open();
                    sqlQuery = "delete from NV where USERNAME = @Username";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@Username", tbSUsername.Text);
                    command.ExecuteNonQuery();
                    //Refresh
                    dgStaff.Rows.RemoveAt(dgStaff.SelectedRows[0].Index);
                    this.dgStaff.ClearSelection();
                    this.dgStaff.CurrentCell = null;
                    UpdateTbStaff();
                }
                catch
                {
                    MessageBox.Show("Lỗi kết nối");
                }
                finally
                {
                    connection.Close();
                }
            }
            else
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa");
        }

        private void btSUpdate_Click(object sender, EventArgs e)
        {
            //UpdateOnline
            if (this.dgStaff.SelectedRows.Count > 0)
            {
                if (CheckFormat())
                {
                    try
                    {
                        connection = new SqlConnection(connString);
                        connection.Open();
                        sqlQuery = "update NV set FULLNAME = @Fname, PHONENUMBER = @Pnumber, ADDRESS = @Address, DOB = @DoB, ICNUMBER = @ICnumber, EMAIL = @Email where USERNAME = @Username";
                        SqlCommand command = new SqlCommand(sqlQuery, connection);
                        command.Parameters.AddWithValue("@Username", tbSUsername.Text);
                        command.Parameters.AddWithValue("@Fname", tbSFname.Text);
                        command.Parameters.AddWithValue("@Pnumber", tbSPnumber.Text);
                        command.Parameters.AddWithValue("@Address", tbSAddress.Text);
                        command.Parameters.AddWithValue("@DoB", tbSDoB.Text);
                        command.Parameters.AddWithValue("@ICnumber", tbSICnumber.Text);
                        command.Parameters.AddWithValue("@Email", tbSEmail.Text);
                        command.ExecuteNonQuery();
                        //UpdateOffline
                        this.dgStaff.CurrentRow.Cells[1].Value = tbSFname.Text;
                        this.dgStaff.CurrentRow.Cells[2].Value = tbSPnumber.Text;
                        this.dgStaff.CurrentRow.Cells[3].Value = tbSAddress.Text;
                        this.dgStaff.CurrentRow.Cells[4].Value = tbSDoB.Text;
                        this.dgStaff.CurrentRow.Cells[5].Value = tbSICnumber.Text;
                        this.dgStaff.CurrentRow.Cells[6].Value = tbSEmail.Text;
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
            else
                MessageBox.Show("Vui lòng chọn tài khoản cần cập nhật");
        }

        private void btSReg_Click(object sender, EventArgs e)
        {
            Form signupForm = new SignupForm();
            signupForm.ShowDialog();
        }

        private void OnlyNumber_KeyDown(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
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
                MessageBox.Show("Địa chỉ không hợp lệ");
                return false;
            }
            if (tbSDoB.Text == "" || (!DateTime.TryParseExact(tbSDoB.Text, "M/dd/yyyy", enUS, DateTimeStyles.None, out dt)))
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
    }
}
