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
        public FormQLBan()
        {
            InitializeComponent();
        }

        private void btSignout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formLogin = new FormLogin();
            formLogin.ShowDialog();
            this.Close();
        }
    }
}
