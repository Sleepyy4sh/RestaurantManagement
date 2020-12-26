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

namespace RestaurantManagement
{
    public partial class FormMain : Form
    {
        DataSQLTable DataSQLTable;
        Table tableSelected;
        public List<FoodInList> listFoodInList;
        private void InitTable()
        {
            if (AD == false)
                btAddTable.Enabled = false;
            DataSQLTable = new DataSQLTable(this);
            DataSQLTable.ReadListTable();
            btAddTable.Hide();
            fpTables.Controls.Add(btAddTable);
            btAddTable.Show();
        }
        public void UnSelectTable()
        { 
            tableSelected = null;
            listFoodInList = null;
            lbListFood.Hide();
            btPay.Hide();
            btOrder.Hide();
            fpListFood.Controls.Clear();
        }
        public void SelectedTable(Table table)
        {
            fpListFood.Controls.Clear();
            tableSelected = null;
            listFoodInList = null;
            tableSelected = table;
            listFoodInList = new List<FoodInList>();
            lbListFood.Text = "Danh sách món bàn: " + table.Name;
            fpListFood.Controls.Add(lbListFood);
            lbListFood.Show();
            btPay.Show();
            btOrder.Show();
        }
        List<Table> listTable = new List<Table>();
        public bool Add_Table(string name,string Status)
        {
           
            if (!TableExist(name))
            {
                Table table = new Table(this,AD);
                listTable.Add(table);
                table.SetName(name, Status);
                table.CheckEmpty();
                //f.SetParent(this);
                int scale = 5;
                table.SetTransform(fpTables.Size.Width / scale - 10, fpTables.Size.Width / scale / scale * 7, -1, -1);
                this.fpTables.Controls.Add(table);
                return true;
            }
            else
            {
                MessageBox.Show("Bàn đã tồn tại", "Lỗi");
                return false;
            }    
        }
        bool TableExist(string name)
        {
            for (int i = 0; i < listTable.Count; i++)
            {
                if (name == listTable[i].Name)
                    return true;
            }

            return false;
        }
        public void SetTableNotEmpty(string name)
        {
            for (int i=0;i<listTable.Count;i++)
            {
                if (listTable[i].Name == name)
                {
                    listTable[i].isEmpty = false;
                    listTable[i].CheckEmpty();
                }
            }    
        }
        public void DeleteFoodInList(string name)
        {
            for (int i = 0; i < listFoodInList.Count; i++) 
            {
                while (i<listFoodInList.Count && listFoodInList[i].name == name )
                {
                    DataSQLTable.DeleteData(tableSelected.Name,listFoodInList[i].name);
                    listFoodInList[i].Hide();
                    listFoodInList.RemoveAt(i);
                    if (menu_Select != null) menu_Select.UnTick(name);
                }
            }
            if (listFoodInList.Count == 0)
                tableSelected.isEmpty = true;
            tableSelected.CheckEmpty();
        }
        public void SaveListFood()
        {
            if (tableSelected != null)
            {
                for (int i = 0; i < listFoodInList.Count; i++)
                {
                    if (!DataSQLTable.InSertData(tableSelected.Name, tableSelected.cbStatus.Text, listFoodInList[i].name,listFoodInList[i].price, listFoodInList[i].index))
                    {
                        DataSQLTable.FixData(tableSelected.Name, tableSelected.Name, tableSelected.cbStatus.Text, listFoodInList[i].name, listFoodInList[i].name, listFoodInList[i].index);
                    };
                }
                tableSelected.CheckEmpty();
            }
        }
        public void SaveStatus(string name,string status)
        {
             DataSQLTable.FixStatus(name,status);
        }
        public void InitFoodInlist(Table table)
        {
            DataSQLTable.ReadListFood(table.Name);
        }
        public void Add_FoodINLIST(string name,string price, string index)
        {
            FoodInList food= new FoodInList(this);
            food.Set(name,price, index);
            listFoodInList.Add(food);
            this.fpListFood.Controls.Add(food);
            tableSelected.isEmpty = false;
            tableSelected.CheckEmpty();
        }
        public void InSertTable(string nameTable,string status,string food,string price,string index)
        {
            DataSQLTable.InSertData(nameTable, status, food,price, index);
        }
        private void btAddTable_Click(object sender, EventArgs e)
        {
            AddTable addTable = new AddTable(this);
            
            addTable.ShowDialog();
            this.btAddTable.Location = new Point(5000, 5000);
            addTable.Hide();
        }
        Menu_Select menu_Select;
        public void ExitMenuSelected()
        {
            pageQLMenu.Enabled = true;
            pageQLNV.Enabled = true;
            pageTaiKhoan.Enabled = true;
            pageThongKe.Enabled = true;
            btPay.Enabled = true;
            btOrder.Enabled = true;
        }
        private void btOrder_Click(object sender, EventArgs e)
        {
            menu_Select = new Menu_Select(this, fpTables.Size);
            pageQLMenu.Enabled = false;
            pageQLNV.Enabled = false;
            pageTaiKhoan.Enabled = false;
            pageThongKe.Enabled = false;
            btPay.Enabled = false;
            btOrder.Enabled = false;
            this.fpTables.Hide();
            this.pageQLBan.Controls.Add(menu_Select);
            menu_Select.Location = new Point(0, 0);
              menu_Select.Show();
        }
        public bool InList(string name)
        {
            for (int i = 0; i < listFoodInList.Count; i++) 
            {
                if (listFoodInList[i].name == name)
                    return true;
            }    
            return false ;
        }
        public void AddToBill(string name,string index,string price)
        {
            bill.AddFood(name,index,price);
        }
        Bill bill;
        private void btPay_Click(object sender, EventArgs e)
        {
            if (!tableSelected.isEmpty)
            {
                bill = new Bill(tableSelected, this,lbFname.Text);
                DataSQLTable.ReadToBILL(tableSelected.Name);
                bill.ShowDialog();
            } else
            {
                MessageBox.Show("Bàn đang trống");
            }    
        }
        public void ClearAllFood(Table table)
        {
            for (int i = 0; i < listFoodInList.Count; i++)
            {
                DataSQLTable.DeleteData(table.Name, listFoodInList[i].name);
                listFoodInList[i].Hide();
                //listFoodInList.RemoveAt(i,1);
            }
            listFoodInList = new List<FoodInList>();
            table.isEmpty = true;
            table.CheckEmpty();
            table.cbStatus.SelectedIndex = 3;
            UnSelectTable();
        }
        public void DeleteTable(Table table)
        {
            if ( table.cbStatus.SelectedIndex == 0 || table.cbStatus.SelectedIndex == 3)
            {
                table.Hide();
                DataSQLTable.DeleteTable(table.Name);
                for (int i = 0; i < listTable.Count; i++)
                {
                    if (listTable[i].Name == table.Name)
                    {
                        listTable.RemoveAt(i);
                    }    
                }                    
            }
            else
            {
                if (table.cbStatus.SelectedIndex == 2)
                    MessageBox.Show("Bàn còn món ăn", "Không thể xóa");
                else
                    MessageBox.Show("Bàn đã được đặt", "Lỗi");
            }
        }
        public bool TableEmpty(Table table)
        {
            if (DataSQLTable.CountFoodTable(table.Name) == 1)
                return true;
            return false;
        }
        DataBill dataBill;
        string[] foods ;
        string[] price ;
        int[] indexs;
        public void SaveBill(string Total,long giamgia,int type)
        {
            dataBill = new DataBill(this);
            foods = new string[listFoodInList.Count];
            price = new string[listFoodInList.Count];
            indexs = new int[listFoodInList.Count];
            for (int i=0;i<listFoodInList.Count; i++)
            {
                foods[i] = listFoodInList[i].name;
                price[i] = listFoodInList[i].price;
                indexs[i] =Int32.Parse(listFoodInList[i].index);
            }
            dataBill.InsertCTHD(foods,price,indexs, Total, DateTime.Now.ToString("MM/dd/yyyy HH:mm"),giamgia,type);
        }
        public bool ExchangeTable(Table table,string nameTable)
        {
            bool Exist=false;
            Table table1 = new Table(this,AD);
            for (int i=0;i<listTable.Count;i++)
            {
                if (nameTable==listTable[i].Name)
                {
                    table1 = listTable[i];
                    Exist = true;
                }
            }
            if (!Exist)
            {
                MessageBox.Show("Bàn không tồn tại");
                return false;
            } else
            {
                DataSQLTable.ExchangeNameTable(table.Name, table1.Name);
                bool tg = table.isEmpty;
                table.isEmpty = table1.isEmpty;
                table1.isEmpty = tg;
                UnSelectTable();
                int g = table.cbStatus.SelectedIndex;
                table.cbStatus.SelectedIndex = table1.cbStatus.SelectedIndex;
                table1.cbStatus.SelectedIndex = g;
            }    
            return true;
        }
        public void SetMSHD(string ID)
        {
            if (bill != null)
            {
                bill.PDF(ID);
            }
        }
        public void Reset()
        {
            if (menu_Select != null)
                menu_Select.Hide();
            fpTables.Show();
        }
    }
}
