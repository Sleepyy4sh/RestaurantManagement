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
    public partial class Menu_Select : Panel
    {
        DataFood_ReadOnly data;
        FormMain formQLMenu;
        public Menu_Select(FormMain formQL,Size size)
        {
            InitializeComponent();
            formQLMenu = formQL;
            this.Size = size;
            this.Location = new Point(0, 0);
            ReSize();
            InitFood();
        }
        void InitFood()
        {
            fpFoodSelected.Controls.Clear();
            fpDrinkSelected.Controls.Clear();
            data = new DataFood_ReadOnly(this);
            data.ReadDATA();
        }
        List<Food_Select> foods = new List<Food_Select>(); 
        public void Add(string name, string price, Byte[] url,int isfood)
        {
            Food_Select f = new Food_Select(formQLMenu);
            foods.Add(f);
            f.name = name;
            f.Set(url, name, price,isfood);
            f.SetParent(this);
            int scale = 5;
            f.SetTransform(this.Width/scale -3, (this.Width/scale-3)/5*7, 0, 0);
            if (f.isFood==0)
                this.fpFoodSelected.Controls.Add(f);
            else
                this.fpDrinkSelected.Controls.Add(f);
            if (formQLMenu.InList(f.name))
            {
                f.Tick();
                //MessageBox.Show(f.name);
            }
            else;
            // f.UnTick();
        }
        public void UnTick(string name)
        {
            for (int i=0;i<foods.Count;i++)
            {
                if (foods[i].name == name)
                    foods[i].UnTick();
            }    
        }
        public void Tick(string name)
        {
            for (int i = 0; i < foods.Count; i++)
            {
                if (foods[i].name == name)
                    foods[i].Tick();
            }
        }

        private void Menu_Select_FormClosed(object sender, FormClosedEventArgs e)
        {
            //formQLMenu.UnSelectTable();
        }

        private void btFinished_Click(object sender, EventArgs e)
        {
            formQLMenu.fpTables.Show();
            formQLMenu.ExitMenuSelected();
            this.Hide();
        }
        private void btFood_Click(object sender, EventArgs e)
        {
            fpFoodSelected.Show();
            fpDrinkSelected.Hide();
        }

        private void btDrink_Click(object sender, EventArgs e)
        {
            fpFoodSelected.Hide();
            fpDrinkSelected.Show();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            CheckSearch();
        }
        void CheckSearch()
        {
           fpFoodSelected.Controls.Clear();
            //Xóa mấy dấu cách nhập thừa
            tbSearch.Text = ChuanHoa(tbSearch.Text);
            // Không nhập gì thì hiện hết
            if (tbSearch.Text == "")
                ShowAll();
            else
            {
                Search(tbSearch.Text);
            }
        }
        void ShowAll()
        {
            for (int i = 0; i < foods.Count; i++)
            {
                if (foods[i].isFood == 0)
                   fpFoodSelected.Controls.Add(foods[i]);
                else
                   fpDrinkSelected.Controls.Add(foods[i]);
            }
        }
        void Search(string child)
        {
            for (int i = 0; i < foods.Count(); i++)
            {
                if (IsChild(FixFormatString(child),FixFormatString(foods[i].GetName())))
                {
                    if (foods[i].isFood == 0)
                       fpFoodSelected.Controls.Add(foods[i]);
                    else
                       fpDrinkSelected.Controls.Add(foods[i]);
                }
            }
        }
        bool IsChild(string child, string parent)
        {
            child = ChuanHoa(child);
            child = FixFormatString(child);

            string[] unitChild = new string[50];
            int count = 0;

            for (int i = 0; i < child.Length; i++)
            {
                if (child[i] == ' ')
                    count++;
                else
                    unitChild[count] += child[i];
            }
            int d = 0;
            if (parent.Length >= child.Length)
            {
                for (int j = 0; j <= count; j++)
                {
                    for (int i = 0; i < parent.Length - unitChild[j].Length + 1; i++)
                    {
                        if (parent.Substring(i, unitChild[j].Length) == unitChild[j])
                        {
                            d++;
                            i = parent.Length - unitChild[j].Length + 1;
                        }
                    }
                }
            }
            if (d == count + 1 && d != 0)
                return true;
            return false;
        }
        List<char> ListOfA = new List<char>() { 'a', 'á', 'à', 'ả', 'ã', 'ạ', 'ă', 'ắ', 'ằ', 'ẳ', 'ẵ', 'ặ', 'â', 'ấ', 'ầ', 'ẩ', 'ẫ', 'ậ' };
        List<char> ListOfE = new List<char>() { 'e', 'é', 'è', 'ẻ', 'ẽ', 'ẹ', 'ê', 'ế', 'ề', 'ể', 'ễ', 'ệ' };
        List<char> ListOfI = new List<char>() { 'i', 'í', 'ì', 'ỉ', 'ĩ', 'ị' };
        List<char> ListOfO = new List<char>() { 'o', 'ó', 'ò', 'ỏ', 'õ', 'ọ', 'ô', 'ố', 'ồ', 'ổ', 'ỗ', 'ộ', 'ơ', 'ớ', 'ờ', 'ở', 'ỡ', 'ợ' };
        List<char> ListOfU = new List<char>() { 'u', 'ú', 'ù', 'ủ', 'ũ', 'ụ', 'ư', 'ứ', 'ừ', 'ử', 'ữ', 'ự' };
        List<char> ListOfY = new List<char>() { 'y', 'ý', 'ỳ', 'ỷ', 'ỹ', 'ỵ' };
        string FixFormatString(string S)
        {
            S = ChuanHoa(S);
            S = S.ToLower();
            S = FixFormatChar(S, ListOfA);
            S = FixFormatChar(S, ListOfE);
            S = FixFormatChar(S, ListOfI);
            S = FixFormatChar(S, ListOfO);
            S = FixFormatChar(S, ListOfU);
            S = FixFormatChar(S, ListOfY);
            for (int i = 0; i < S.Length; i++)
            {
                while (S.Length > i + 1 && S[i] == S[i + 1])
                {
                    S = S.Remove(i, 1);
                }
            }
            return S;
        }
        string FixFormatChar(string S, List<char> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                S = S.Replace(list[i], list[0]);
            }
            return S;
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
            for (int i = 0; i < S.Length - 1; i++)
            {
                while (S[i] == S[i + 1] & S[i + 1] == ' ')
                {
                    S = S.Remove(i + 1, 1);
                }
            }
            return S;
        }
        private void btReFresh_Click(object sender, EventArgs e)
        {
            InitFood();
        }

    }
}
