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
    public partial class FormQLBan : Form
    {
        bool AD;
        public FormQLBan(bool AD)
        {
            this.AD = AD;
            InitializeComponent();
        }
        private void btSignout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formLogin = new FormLogin();
            formLogin.ShowDialog();
            this.Close();
        }

        private void btQLMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formQLMenu = new FormQLMenu(AD);
            formQLMenu.ShowDialog();
            this.Close();
        }
    }
}
