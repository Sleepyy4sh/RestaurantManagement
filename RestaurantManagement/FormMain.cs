﻿using System;
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
        bool ableDelete = false;
        public DataFood_Fix dataFood;
        string server, ID, Svpassword, nameDB;
        String connString, sqlQuery;
        SqlConnection connection;
        List<Food_Fix> ListFood = new List<Food_Fix>();


        public FormMain(bool AD)
        {
            this.AD = AD;
            InitializeComponent();
            ReSize();
            initIn4Server();
            InitFood();
            InitTable();
            InitRevenue();
            InitStaff();
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
                if (IsChild(child, ListFood[i].GetName()))
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
            if (parent.Length >= child.Length)
                for (int i = 0; i < parent.Count() - child.Length + 1; i++)
                {
                    if (parent.Substring(i, child.Length) == child)
                    {
                        return true;
                    }
                }
            return false;
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
