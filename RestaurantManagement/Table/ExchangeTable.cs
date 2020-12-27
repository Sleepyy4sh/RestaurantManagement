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
    public partial class ExchangeTable : Form
    {
        FormMain FormQLBan;
        Table tabletmp;
        public ExchangeTable(FormMain formQLBan,Table table)
        {
            tabletmp = table;
            InitializeComponent();
            ReSize();
            this.FormQLBan = formQLBan;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (tabletmp.Name != tbName.Text && tbName.Text != "") 
            {
                if  (FormQLBan.ExchangeTable(tabletmp, tbName.Text))
                    this.Close();
            }    
        }
    }
}
