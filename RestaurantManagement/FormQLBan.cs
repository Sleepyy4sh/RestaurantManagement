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
    public partial class FormQLMenu : Form
    {
        DataTable dataTable;
        Table tableSelected;
        public List<FoodInList> listFoodInList;
        private void InitTable()
        {
            dataTable = new DataTable(this);
            dataTable.ReadListTable();
            btAddTable.Hide();
            flowTable.Controls.Add(btAddTable);
            btAddTable.Show();
        }
        public void UnSelectTable()
        { 
            tableSelected = null;
            listFoodInList = null;
            lbListFood.Hide();
            btPay.Hide();
            btOrder.Hide();
            flowListFood.Controls.Clear();
        }
        public void SelectedTable(Table table)
        {
            flowListFood.Controls.Clear();
            tableSelected = null;
            listFoodInList = null;
            tableSelected = table;
            listFoodInList = new List<FoodInList>();
            lbListFood.Text = "Danh sách món; bàn: " + table.Name;
            flowListFood.Controls.Add(lbListFood);
            lbListFood.Show();
            btPay.Show();
            btOrder.Show();
        }
        public void Add_Table(string name,string Status)
        {
            Table table = new Table(this);
            table.SetName(name, Status);
            //f.SetParent(this);
            table.SetTransform(flowTable.Size.Width/5-6, flowTable.Size.Width/5/5*7, -1, -1);
            this.flowTable.Controls.Add(table);
        }     
        public void DeleteFoodInList(string name)
        {
            for (int i = 0; i < listFoodInList.Count; i++) 
            {
                if (listFoodInList[i].name == name )
                {
                    dataTable.DeleteData(tableSelected.Name,listFoodInList[i].name);
                    listFoodInList[i].Hide();
                    listFoodInList.RemoveAt(i);
                    return;
                }
            }
        }
        public void SaveListFood()
        {
            if (tableSelected != null) 
            for (int i = 0; i < listFoodInList.Count; i++)
            {
                    if (!dataTable.InSertData(tableSelected.Name, tableSelected.cbStatus.Text, listFoodInList[i].name, listFoodInList[i].index))
                    {
                        dataTable.FixData(tableSelected.Name, tableSelected.Name, tableSelected.cbStatus.Text, listFoodInList[i].name, listFoodInList[i].name, listFoodInList[i].index);
                    };
            }
        }
        public void InitFoodInlist(string nameTable)
        {
            dataTable.ReadListFood(nameTable);
        }
        public void Add_FoodINLIST(string name,string index)
        {
            FoodInList food= new FoodInList(this);
            food.Set(name, index);
            listFoodInList.Add(food);
            this.flowListFood.Controls.Add(food);
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
        }

        private void btOrder_Click(object sender, EventArgs e)
        {
            Menu_Select menu_Select = new Menu_Select(this);
            menu_Select.Size = flowTable.Size;
            menu_Select.Location = flowTable.Location;
            menu_Select.ShowDialog();
        }
    }
}
