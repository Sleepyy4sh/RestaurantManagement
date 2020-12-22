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

namespace RestaurantManagement
{
    public partial class FormMain : Form
    {
        DataTable dataTable;
        Table tableSelected;
        public List<FoodInList> listFoodInList;
        private void InitTable()
        {
            dataTable = new DataTable(this);
            dataTable.ReadListTable();
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
                Table table = new Table(this);
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
                    dataTable.DeleteData(tableSelected.Name,listFoodInList[i].name);
                    listFoodInList[i].Hide();
                    listFoodInList.RemoveAt(i);
                    //if (menu_Select != null) menu_Select.UnTick(name);
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
                    if (!dataTable.InSertData(tableSelected.Name, tableSelected.cbStatus.Text, listFoodInList[i].name, listFoodInList[i].index))
                    {
                        dataTable.FixData(tableSelected.Name, tableSelected.Name, tableSelected.cbStatus.Text, listFoodInList[i].name, listFoodInList[i].name, listFoodInList[i].index);
                    };
                }
                tableSelected.CheckEmpty();
            }
        }
        public void SaveStatus(string name,string status)
        {
             dataTable.FixStatus(name,status);
        }
        public void InitFoodInlist(Table table)
        {
            dataTable.ReadListFood(table.Name);
        }
        public void Add_FoodINLIST(string name,string index)
        {
            FoodInList food= new FoodInList(this);
            food.Set(name, index);
            listFoodInList.Add(food);
            this.fpListFood.Controls.Add(food);
            tableSelected.isEmpty = false;
            tableSelected.CheckEmpty();
        }
        public void InSertTable(string nameTable,string status,string food,string index)
        {
            dataTable.InSertData(nameTable, status, food, index);
        }
        private void btAddTable_Click(object sender, EventArgs e)
        {
            AddTable addTable = new AddTable(this);
            
            addTable.ShowDialog();
            this.btAddTable.Location = new Point(5000, 5000);
            addTable.Hide();
        }
        Menu_Select menu_Select;
        private void btOrder_Click(object sender, EventArgs e)
        {
            menu_Select = new Menu_Select(this);
            menu_Select.Size = fpTables.Size;
            menu_Select.ShowDialog();
            menu_Select.Location = fpTables.Location;
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
                bill = new Bill(tableSelected, this);
                dataTable.ReadToBILL(tableSelected.Name);
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
                dataTable.DeleteData(table.Name, listFoodInList[i].name);
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
                dataTable.DeleteTable(table.Name);
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
            if (dataTable.CountFoodTable(table.Name) == 1)
                return true;
            return false;
        }
        DataBill dataBill = new DataBill();
        string[] foods ;
        int[] indexs;
        public void SaveBill(string Total)
        {
            foods = new string[listFoodInList.Count];
            indexs = new int[listFoodInList.Count];
            for (int i=0;i<listFoodInList.Count; i++)
            {
                foods[i] = listFoodInList[i].name;
                indexs[i] =Int32.Parse(listFoodInList[i].index);
            }
            dataBill.InsertCTHD(foods,indexs, Total, DateTime.Now.ToString("MM/dd/yyyy HH:mm"));
        }
    }
}