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
        bool AD;
        string username;
        bool ableDelete = false;
        public DataFood_Fix dataFood;
        string server, ID, Svpassword, nameDB;
        String connString, sqlQuery;
        SqlConnection connection;
        List<Food_Fix> ListFood = new List<Food_Fix>();


        public FormMain(bool AD, string usrname)
        {
            this.AD = AD;
            this.username = usrname; 
            InitializeComponent();
            ReSize();
            initIn4Server();
            InitFood();
            InitTable();
            InitRevenue();
            if (AD)
                InitStaff();
            else
                this.pageQLNV.Visible = false;
            UnSelectTable();
            InitAccount();
            btAddTable.Size = new Size(fpTables.Size.Width / 5 - 6, fpTables.Size.Width / 5 / 5 * 7);
        }

        private void initIn4Server()
        {
            string[] in4 = File.ReadAllLines("inforServer.txt");
            server = in4[0];
            ID = in4[1];
            Svpassword = in4[2];
            using (StreamReader sr = new StreamReader("database.txt"))
            {
                nameDB = sr.ReadLine();
            }
        }

        public void AddFood(string name, string price, Byte[] byt,int isFood)
        {
            Food_Fix f = new Food_Fix();
            ListFood.Add(f);
            f.Set(byt, name, price,isFood);
            f.SetParent(this);
            int unitFood = 5;
            f.SetTransform(fpFoods.Size.Width / unitFood - unitFood, (fpFoods.Size.Width / unitFood - unitFood) / 5 * 7, 0, 0);
            if (isFood == 0) 
                this.fpFoods.Controls.Add(f);
            else
                this.fpDrinks.Controls.Add(f);
        }
        void DeleteInList(string name)
        {
            for (int i = 0; i < ListFood.Count; i++)
            {
                if (ListFood[i].GetName() == name)
                {
                    ListFood.RemoveAt(i);
                }
            }
        }
        public bool DeleteFood(string name)
        {
            if (ableDelete)
            {
                if (dataFood.DeleteData(name))
                {
                    MessageBox.Show("Món " + name + " đã được xóa");
                    DeleteInList(name);
                    return true;
                }
            }
            return false;
        }
        public bool FixFood(string name)
        {
            if (ableDelete)
            {
                if (dataFood.DeleteData(name))
                {
                    MessageBox.Show("Món " + name + " đã được xóa");
                    DeleteInList(name);
                }
                return true;
            }
            return false;
        }

        void ShowButton()
        {
            for (int i = 0; i < ListFood.Count; i++)
            {
                ListFood[i].ShowButton();
            }
        }
        void HideButton()
        {
            for (int i = 0; i < ListFood.Count; i++)
            {
                ListFood[i].HideButton();
            }
        }
        void CheckDelete()
        {
            if (ableDelete)
            {
                //lbDelete.Hide();
                ShowButton();
                btFix.BackColor = Color.Yellow;
            }
            else
            {
                //lbDelete.Hide();
                HideButton();
                btFix.BackColor = Color.White;
            }
        }
        public bool InsertData(string name, string price, Byte[] byt,int isfood)
        {
            if (dataFood.InSertData(name, price, byt,isfood))
            {
                AddFood(name, price, byt,isfood);
                return true;
            }
            return false;
        }
        public bool FixData(Food_Fix food, string nametemp, string name, string price, Byte[] byt)
        {
            //MessageBox.Show(nametemp + " " + name + " " + price);
            if (dataFood.FixData(nametemp, name, price, byt))
            {
                food.Set(byt, name, price);
                return true;
            }
            return false;
        }
        public bool FixDataWithoutImage(Food_Fix food, string nametemp, string name, string price)
        {
            //MessageBox.Show(nametemp + " " + name + " " + price);
            if (dataFood.FixDataWithoutImage(nametemp, name, price))
            {
                food.SetWithoutImage(name, price);
                return true;
            }
            return false;
        }
        private void InitFood()
        {
            fpFoods.Controls.Clear();
            fpDrinks.Controls.Clear();
            dataFood = new DataFood_Fix(this);
            CheckDelete();
            dataFood.ReadDATA();
            if (this.AD)
            {
                btAddFood.Enabled = true;
                btFix.Enabled = true;
            }
            else
            {
                btAddFood.Enabled = false;
                btFix.Enabled = false;
            }
        }


        private void btAddFood_Click(object sender, EventArgs e)
        {
            AddFood addFood = new AddFood(this);
            addFood.ShowDialog();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            ableDelete = !ableDelete;
            CheckDelete();
        }

        private void btMasterSignout_Click(object sender, EventArgs e)
        {
            this.Hide();
            File.Delete("database.txt");
            this.Close();
            Form formLoginMaster = new LoginMasterForm();
            formLoginMaster.ShowDialog();
        }

        void InitAccount()
        {
            btMasterSignout.Enabled = AD;
            String connString = @"Server=" + server + ";Database=" + nameDB + ";User Id=" + ID + ";Password=" + Svpassword + ";";
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();

            String sqlQuery = "SELECT * FROM NV WHERE USERNAME='" +username +"'";
            SqlCommand command = new SqlCommand(sqlQuery, connection);

            SqlDataReader reader = command.ExecuteReader();

            lbUsername.Text = username;

            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                lbFname.Text = reader.GetString(0);
                lbDoB.Text = reader.GetDateTime(4).ToShortDateString();
                lbAddress.Text = reader.GetString(3);
                lbPnumber.Text = reader.GetString(2);
                lbICnumber.Text = reader.GetString(5);
                lbEmail.Text = reader.GetString(6);
            }
        }

        private void btSignout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            CheckSearch();
        }
        void CheckSearch()
        {
            fpFoods.Controls.Clear();
            fpListFood.Controls.Clear();
            //Xóa mấy dấu cách nhập thừa
            tbSearch.Text = ChuanHoa(tbSearch.Text);
            // Không nhập gì thì hiện hết
            if (tbSearch.Text == "")
                ShowAll();
            else
            {
                Search(tbSearch.Text);
            }
        }
        void ShowAll()
        {
            for (int i = 0; i < ListFood.Count; i++)
            {
                if (ListFood[i].isFood==0)
                    fpFoods.Controls.Add(ListFood[i]);
                else
                    fpDrinks.Controls.Add(ListFood[i]);
            }
        }
        void Search(string child)
        {
            for (int i = 0; i < ListFood.Count(); i++)
            {
                if ( IsChild(FixFormatString(child), FixFormatString(ListFood[i].GetName())))
                {
                    if (ListFood[i].isFood == 0)
                        fpFoods.Controls.Add(ListFood[i]);
                    else
                        fpDrinks.Controls.Add(ListFood[i]);
                }
            }
        }
        bool IsChild(string child, string parent)
        {
            child = ChuanHoa(child);
            child = FixFormatString(child);

            string[] unitChild = new string[50];
            int count = 0;
            for (int i = 0; i < child.Length; i++)
            {
                if (child[i] == ' ')
                    count++;
                else
                    unitChild[count] += child[i];
            }
            int d = 0;
            if (parent.Length >= child.Length)
            {
                for (int j = 0; j <= count; j++)
                {
                    for (int i = 0; i < parent.Length - unitChild[j].Length + 1; i++)
                    {
                     //   MessageBox.Show(unitChild[j]+"   "+ parent.Substring(i,unitChild[j].Length));
                        if (parent.Substring(i, unitChild[j].Length) == unitChild[j])
                        {
                            d++;
                            i = parent.Length - unitChild[j].Length + 1;
                        }
                    }
                }
            }
            if (d == count + 1 && d != 0)
                return true;
            return false;
        }
        List<char> ListOfA = new List<char>() { 'a', 'á', 'à', 'ả', 'ã', 'ạ', 'ă', 'ắ', 'ằ', 'ẳ', 'ẵ', 'ặ', 'â', 'ấ', 'ầ', 'ẩ', 'ẫ', 'ậ' };
        List<char> ListOfE = new List<char>() { 'e', 'é', 'è', 'ẻ', 'ẽ', 'ẹ', 'ê', 'ế', 'ề', 'ể', 'ễ', 'ệ' };
        List<char> ListOfI = new List<char>() { 'i', 'í', 'ì', 'ỉ', 'ĩ', 'ị' };
        List<char> ListOfO = new List<char>() { 'o', 'ó', 'ò', 'ỏ', 'õ', 'ọ', 'ô', 'ố', 'ồ', 'ổ', 'ỗ', 'ộ', 'ơ', 'ớ', 'ờ', 'ở', 'ỡ', 'ợ' };
        List<char> ListOfU = new List<char>() { 'u', 'ú', 'ù', 'ủ', 'ũ', 'ụ', 'ư', 'ứ', 'ừ', 'ử', 'ữ', 'ự' };
        List<char> ListOfY = new List<char>() { 'y', 'ý', 'ỳ', 'ỷ', 'ỹ', 'ỵ' };
        string FixFormatString(string S)
        {
            S = ChuanHoa(S);
            S = S.ToLower();
            S = FixFormatChar(S, ListOfA);
            S = FixFormatChar(S, ListOfE);
            S = FixFormatChar(S, ListOfI);
            S = FixFormatChar(S, ListOfO);
            S = FixFormatChar(S, ListOfU);
            S = FixFormatChar(S, ListOfY);
            for (int i = 0; i < S.Length; i++)
            {
                while (S.Length > i + 1 && S[i] == S[i + 1])
                {
                    S = S.Remove(i, 1);
                }
            }
            return S;
        }
        string FixFormatChar(string S, List<char> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                S = S.Replace(list[i], list[0]);
            }
            return S;
        }

        private void btFood_Click(object sender, EventArgs e)
        {
            fpFoods.Show();
            fpDrinks.Hide();
        }

        private void btDrink_Click(object sender, EventArgs e)
        {
            fpFoods.Hide();
            fpDrinks.Show();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btChangeInfo_Click(object sender, EventArgs e)
        {
            Form formChangeInfor = 
            new FormChangeInfo(lbFname.Text,
                lbDoB.Text,
                lbAddress.Text,
                lbPnumber.Text,
                lbICnumber.Text,
                lbEmail.Text);
            formChangeInfor.ShowDialog();
        }

        private void btUpdateAccount_Click(object sender, EventArgs e)
        {
            InitAccount();
        }

        string ChuanHoa(string S)
        {
            while (S.Length > 0 && S[0] == ' ')
            {
                Console.WriteLine(S);
                S = S.Remove(0, 1);
            };
            while (S.Length > 0 && S[S.Length - 1] == ' ')
            {
                S = S.Remove(S.Length - 1, 1);
            };
            for (int i = 0; i < S.Length - 1; i++)
            {
                while (S[i] == S[i + 1] & S[i + 1] == ' ')
                {
                    S = S.Remove(i + 1, 1);
                }
            }
            return S;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            //String S = tbSearch.Text;
            //int pos = S.Length;
            //for (int i = 0; i < S.Length; i++)
            //{
            //    if (!(S[i] >= '0' && S[i] <= '9') && !(S[i] >= 'a' && S[i] <= 'z') && !(S[i] >= 'a' && S[i] <= 'z') && S[i] != ' ')
            //    {
            //        S = S.Remove(i, 1);
            //        pos = i;
            //        break;
            //    }
            //}
            //tbSearch.Text = S;
            //tbSearch.SelectionStart = pos;
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckSearch();
            }
        }
        private void btReFresh_Click(object sender, EventArgs e)    
        {
            InitFood();
        }

    }
}
