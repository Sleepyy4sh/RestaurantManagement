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
        bool AD;
        bool ableDelete = false;
        DataFood_Fix dataFood;
        public FormMain(bool AD)
        {
            this.AD = AD;
            InitializeComponent();
            InitFood();
            InitAccount();
        }

        public void Add_Food(string name, string price, Byte[] byt)
        {
            Food_Delete f = new Food_Delete();
            f.Set(byt, name, price);
            f.SetParent(this);
            f.SetTransform(175, 245, 0, 0);
            this.flowLayoutPanel1.Controls.Add(f);
        }

        public bool DeleteFood(string name)
        {
            if (ableDelete)
            {
                if (dataFood.DeleteData(name))
                    MessageBox.Show("Món " + name + " đã được xóa");
                return true;
            }
            return false;
        }

        void CheckDelete()
        {
            if (ableDelete)
            {
                lbDelete.Show();
                btDelete.BackColor = Color.Yellow;
            }
            else
            {
                lbDelete.Hide();
                btDelete.BackColor = Color.White;
            }
        }
        public bool InsertData(string name, string price, Byte[] byt)
        {
            if (dataFood.InSertData(name, price, byt))
            {
                Add_Food(name, price, byt);
                return true;
            }
            return false;
        }

        private void InitFood()
        {
            dataFood = new DataFood_Fix(this);
            CheckDelete();
            dataFood.ReadDATA();
            if (this.AD)
            {
                btAddFood.Enabled = true;
                btDelete.Enabled = true;
            }
            else
            {
                btAddFood.Enabled = false;
                btDelete.Enabled = false;
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
    }
}
