using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class Bill : Form
    {
        int Sum = 0;
        Table tableSelected;
        FormMain formMain;
        public Bill(Table table,FormMain form)
        {
            this.formMain = form;
            tableSelected = table;
            InitializeComponent();
            ReSize();
            cbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbType.SelectedIndex = 0;
        }
        public void AddFood(string name,string index, string price)
        {
            if (name != "")
            {
                FoodInBill foodInBill = new FoodInBill(this);
                foodInBill.Set(name, index, price);
                int temp = Int32.Parse(index) * Int32.Parse(price);
                value = Sum += temp;
                this.fpFoods.Controls.Add(foodInBill);
                lbSumAll.Text = "Tổng = " + Sum.ToString() + "000 VNĐ";
                lbSumAll.Location = new Point(fpFoods.Width / 2 - lbSumAll.Width / 2, fpFoods.Location.Y + fpFoods.Height);
                lbTotal.Text = "Thành tiền = " + Sum.ToString() + "000 VNĐ";
                lbTotal.Location = new Point(fpFoods.Width / 2 - lbTotal.Width / 2, tbValue.Location.Y + tbValue.Height + tbValue.Height / 2);
            }
        }

        private void btComfirm_Click(object sender, EventArgs e)
        {
            formMain.SaveBill(value.ToString());
            formMain.ClearAllFood(tableSelected);
            this.Hide();
        }
        private void tbValue_TextChanged(object sender, EventArgs e)
        {
            String S = tbValue.Text;
            int pos = S.Length;
            for (int i = 0; i < S.Length; i++)
            {
                if (!(S[i] >= '0' && S[i] <= '9'))
                {
                    S = S.Remove(i, 1);
                    pos = i;
                    break;
                }
            }
            tbValue.Text = S;
            tbValue.SelectionStart = pos;
            if (S != "")
            {
                if (cbType.SelectedIndex == 0)
                {
                    value = Sum * 1000 - Sum * 1000 * Int32.Parse(S) / 100;
                    lbTotal.Text = " Thành tiền = " + value.ToString() + " VNĐ";
                }
                else
                if (cbType.SelectedIndex == 1)
                {
                    value = Sum*1000 - Int32.Parse(S);
                    lbTotal.Text = " Thành tiền = " + value.ToString() + " VNĐ";
                }
            } else
            {
                lbTotal.Text = "Thành tiền = " + Sum.ToString() + "000 VNĐ";
            }                
        }
        int value = 0;
        private void cbType_TextChanged(object sender, EventArgs e)
        {
            if (tbValue.Text != "")
            {
                if (cbType.SelectedIndex == 0)
                {
                   value = Sum * 1000 - Sum * 1000 * Int32.Parse(tbValue.Text) / 100;
                    lbTotal.Text = " Thành tiền = " + value.ToString() + " VNĐ";
                }
                else
                if (cbType.SelectedIndex == 1)
                {
                    value = Sum * 1000 - Int32.Parse(tbValue.Text);
                    lbTotal.Text = " Thành tiền = " + value.ToString() + " VNĐ";
                }
            }
            else
            {
                lbTotal.Text = "Thành tiền = " + Sum.ToString() + "000 VNĐ";
            }
        }
    }
}
