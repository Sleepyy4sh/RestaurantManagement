using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Data;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System;
using System.Data;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;


namespace RestaurantManagement
{
    public partial class Bill : Form
    {
        int Sum = 0;
        Table tableSelected;
        FormMain formMain;
        public Bill(Table table, FormMain form)
        {
            this.formMain = form;
            tableSelected = table;
            InitializeComponent();
            ReSize();
            cbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbType.SelectedIndex = 0;
            dtbl = MakeDataTable();
        }
        public void AddFood(string name, string index, string price)
        {
            if (name != "")
            {
                ADDROW(dtbl, name, index, price + "000 VNĐ");
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
            if ((cbType.SelectedIndex == 0) && (tbValue.Text != "") && (Int32.Parse(tbValue.Text) >= 100))
                MessageBox.Show("% Phải nhỏ hơn hoặc bằng 100%");
            else
            {
                int giamgia = 0;
                if (tbValue.Text != "")
                    giamgia = Int32.Parse(tbValue.Text);
                int type = cbType.SelectedIndex;


                formMain.SaveBill(value.ToString(), giamgia, type);
                formMain.ClearAllFood(tableSelected);
                formMain.Reset();
                this.Close();
            }
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
                    value = Sum * 1000 - Int32.Parse(S);
                    lbTotal.Text = " Thành tiền = " + value.ToString() + " VNĐ";
                }
            }
            else
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
                    {
                        value = Sum * 1000 - Sum * 1000 * Int32.Parse(tbValue.Text) / 100;
                        lbTotal.Text = " Thành tiền = " + value.ToString() + " VNĐ";
                    }
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

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Functions
        DataTable MakeDataTable()
        {
            //Create friend table object
            DataTable friend = new DataTable();
            //Define columns
            friend.Columns.Add("SAN PHAM");
            friend.Columns.Add("SO LUONG");
            friend.Columns.Add("GIA");


            return friend;
        }
        #endregion
        DataTable ADDROW(DataTable dataTable, string name, string index, string price)
        {
            dataTable.Rows.Add(name, index, price);
            return dataTable;
        }
        #region Events
        void ExportDataTableToPdf(DataTable dtblTable, String strPdfPath, string strHeader)
        {
            System.IO.FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            //Report Header
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntHead = new iTextSharp.text.Font(bfntHead, 16, 1, BaseColor.GRAY);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk(strHeader.ToUpper(), fntHead));
            document.Add(prgHeading);

            //Author
            Paragraph prgAuthor = new Paragraph();
            BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntAuthor = new iTextSharp.text.Font(btnAuthor, 10, 2, BaseColor.GRAY);
            prgAuthor.Alignment = Element.ALIGN_LEFT;
            prgAuthor.Add(new Chunk("NHAN VIEN: ", fntAuthor));
            prgAuthor.Add(new Chunk("\n NGAY HOA DON : " + DateTime.Now.ToShortDateString(), fntAuthor));
            document.Add(prgAuthor);

            //Add a line seperation
            Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
            document.Add(p);

            //Add line break
            document.Add(new Chunk("\n", fntHead));

            //Write the table
            PdfPTable table = new PdfPTable(dtblTable.Columns.Count);
            //Table header
            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntColumnHeader = new iTextSharp.text.Font(btnColumnHeader, 10, 1, BaseColor.WHITE);
            for (int i = 0; i < dtblTable.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                cell.BackgroundColor = BaseColor.GRAY;
                cell.AddElement(new Chunk(dtblTable.Columns[i].ColumnName.ToUpper(), fntColumnHeader));
                table.AddCell(cell);
            }
            //table Data
            for (int i = 0; i < dtblTable.Rows.Count; i++)
            {
                for (int j = 0; j < dtblTable.Columns.Count; j++)
                {
                    table.AddCell(dtblTable.Rows[i][j].ToString());
                }
            }
            document.Add(table);

            //Money
            prgAuthor = new Paragraph();
            btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            fntAuthor = new iTextSharp.text.Font(btnAuthor, 10, 2, BaseColor.GRAY);
            prgAuthor.Alignment = Element.ALIGN_CENTER;
            prgAuthor.Add(new Chunk("\nTONG : " + lbSumAll.Text.Remove(0, 4), fntAuthor));
            prgAuthor.Add(new Chunk("\nGIAM GIA : " + tbValue.Text + " " + cbType.SelectedItem.ToString(), fntAuthor));
            prgAuthor.Add(new Chunk("\nTHANH TIEN : " + lbTotal.Text.Remove(0, 12), fntAuthor));
            document.Add(prgAuthor);
            document.Close();
            writer.Close();
            fs.Close();
        }
        DataTable dtbl;
        public void PDF(string id)
        {
            try
            {
                ExportDataTableToPdf(dtbl, "bills//" + id + ".pdf", id);
                {
                    //MessageBox.Show("bills//" + id + ".pdf");
                    System.Diagnostics.Process.Start("./bills" + id + ".pdf");
                    //this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }
        #endregion
    }
}
