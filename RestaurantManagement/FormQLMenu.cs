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
    public partial class FormQLMenu : Form
    {
        bool ableDelete = false;
        bool AD;
        DataFood_Fix data;
        public FormQLMenu(bool AD)
        {
            this.AD = AD;
            InitializeComponent();
            this.ActiveControl = btQLMenu;
            lbDelete.Hide();
            //data = new DataFood_Fix(this);
            //data.ReadDATA();
            //CheckDelete();
            //if (this.AD)
            //{
            //    bAddFood.Enabled = true;
            //    bDelete.Enabled = true;
            //}
            //else
            //{
            //    bAddFood.Enabled = false;
            //    bDelete.Enabled = false;
            //}
        }
        public void Add(string name, string price, Byte[] byt)
        {
            //Food_Delete f = new Food_Delete();
            //f.Set(byt, name, price);
            //f.SetParent(this);
            //f.SetTransform(175, 245, 0, 0);
            //this.flowLayoutPanel1.Controls.Add(f);
        }
        public bool InsertData(string name, string price, Byte[] byt)
        {
            if (data.InSertData(name, price, byt))
            {
                Add(name, price, byt);
                return true;
            }
            return false;
        }

        private void bAddFood_Click(object sender, EventArgs e)
        {
            //AddFood addFood = new AddFood(this);
            //addFood.ShowDialog();
        }
        public bool DeleteFood(string name)
        {
            if (ableDelete)
            {
                if (data.DeleteData(name))
                    MessageBox.Show("Món " + name + " đã được xóa");
                return true;
            }
            return false;
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            ableDelete = !ableDelete;
            CheckDelete();
        }
        void CheckDelete()
        {
            if (ableDelete)
            {
                lbDelete.Show();
                bDelete.BackColor = Color.Yellow;
            }
            else
            {
                lbDelete.Hide();
                bDelete.BackColor = Color.White;
            }
        }
        private void btSignout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formLogin = new FormLogin();
            formLogin.ShowDialog();
            this.Close();
        }

        private void btQLBan_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formQLBan = new FormQLBan(AD);
            formQLBan.ShowDialog();
            this.Close();
        }
    }
}
