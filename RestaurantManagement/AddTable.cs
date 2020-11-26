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
    public partial class AddTable : Form
    {
        FormQLMenu FormQLBan;
        public AddTable(FormQLMenu formQLMenu)
        {
            InitializeComponent();
            this.FormQLBan = formQLMenu;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            tbName.Text = ChuanHoa(tbName.Text);
            if (tbName.Text != "")
            {
                FormQLBan.Add_Table(tbName.Text, "");
                FormQLBan.btAddTable.Hide();
                FormQLBan.flowTable.Controls.Add(FormQLBan.btAddTable);
                FormQLBan.btAddTable.Show();
                FormQLBan.InSertTable(tbName.Text, "Bàn trống", "", "");
                tbName.Text = "";
            }
            else
            {
                MessageBox.Show("Chưa nhập tên bàn", "Lỗi thiếu dữ liệu");
            }
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
            if (S.Length > 0 && S[0] >= 'a' && S[0] <= 'z')
            {
                char c = S[0];
                string s = c.ToString();
                s = s.ToUpper();
                Console.WriteLine(s);
                S = S.Remove(0, 1);
                S = s + S;
            }
            for (int i = 0; i < S.Length - 1; i++)
            {
                while (S[i] == S[i + 1] & S[i + 1] == ' ')
                {
                    S = S.Remove(i + 1, 1);
                }
            }
            return S;
        }
    }
}
