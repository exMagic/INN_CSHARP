using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Office.Interop.Excel;

namespace INN_CSHARP
{
    public partial class Butikkdata : Form
    {
        public int x;
        public Butikkdata(int orderNumber)
        {
            x = orderNumber;
            InitializeComponent();
        }


        private void Butikkdata_Load(object sender, EventArgs e)
        {
            var mySql = new mySql();
            mySql.loadButikk(x);
            dataGridViewTest.DataSource = bindingSourceOrders;
            mySql.GetData(mySql.loadButikkStatement, bindingSourceOrders);
            for (int c = 0; c < dataGridViewTest.Columns.Count; ++c)
            {
                dataGridViewTest2.Columns.Add(dataGridViewTest.Columns[c].HeaderText, dataGridViewTest.Columns[c].HeaderText);
            }
            int Nindex = 0;
            for (int i = 0; i < dataGridViewTest.Rows.Count; i++)//each row
            {
                if (i < 1)
                {
                    dataGridViewTest2.Rows.Add();
                    for (int j = 0; j < dataGridViewTest.Columns.Count; ++j)//each cell in row
                    {
                        dataGridViewTest2.Rows[Nindex].Cells[j].Value = dataGridViewTest.Rows[i].Cells[j].Value;
                    }
                    Nindex++;
                }
                else
                {
                    if (dataGridViewTest.Rows[i].Cells["plu"].Value.ToString() == dataGridViewTest.Rows[i - 1].Cells["plu"].Value.ToString() & dataGridViewTest.Rows[i].Cells["farm"].Value.ToString() == dataGridViewTest.Rows[i - 1].Cells["farm"].Value.ToString())//if above is the same
                    {
                        dataGridViewTest2.Rows[Nindex - 1].Cells["stems"].Value = Convert.ToInt32(dataGridViewTest2.Rows[Nindex - 1].Cells["stems"].Value) + Convert.ToInt32(dataGridViewTest.Rows[i].Cells["stems"].Value);
                        dataGridViewTest2.Rows[Nindex - 1].Cells["buckets"].Value = Convert.ToInt32(dataGridViewTest2.Rows[Nindex - 1].Cells["stems"].Value) / Convert.ToInt32(dataGridViewTest2.Rows[Nindex - 1].Cells["Stems pr bunch"].Value) / Convert.ToInt32(dataGridViewTest2.Rows[Nindex - 1].Cells["Bunch pr bucket"].Value);
                    }
                    else
                    {
                        dataGridViewTest2.Rows.Add();
                        for (int j = 0; j < dataGridViewTest.Columns.Count; ++j)//each cell in row
                        {
                            dataGridViewTest2.Rows[Nindex].Cells[j].Value = dataGridViewTest.Rows[i].Cells[j].Value;
                        }
                        Nindex++;
                    }
                }
            }
            dataGridViewTest2.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("arial", 7);
            dataGridViewTest2.Columns[0].Visible = false;
            dataGridViewTest2.Columns[1].Visible = false;
            dataGridViewTest2.Columns[2].Visible = false;
            dataGridViewTest2.Columns[3].Visible = false;
            dataGridViewTest2.Columns["variety"].Visible = false;
            dataGridViewTest2.Columns["length"].Width = 45;
            dataGridViewTest2.Columns["mix"].Width = 45;
            dataGridViewTest2.Columns["sleeve"].Width = 80;
            dataGridViewTest2.Columns["with sleeves"].Width = 40;
            dataGridViewTest2.Columns["fairtrade"].Width = 40;
            dataGridViewTest2.Columns["bunch pr bucket"].Width = 40;
            dataGridViewTest2.Columns["stems pr bunch"].Width = 40;
            dataGridViewTest2.Columns["plu"].Width = 50;
            dataGridViewTest2.Columns["boxes"].Width = 45;
            dataGridViewTest2.Columns["stems"].Width = 45;
            dataGridViewTest2.Columns["price"].Width = 45;
            dataGridViewTest2.Columns["buckets"].Width = 45;

            mySql.fillupLabelsButikk(lblOrdreNumber, lblDeparture, lblArrival, lblDatecode, lblAmountBoxes, lblAmountStems, lblAmountBuckets, lblAmountPrice, dataGridViewTest2);
            lblOrderNumberTitle.Text = lblOrdreNumber.Text;


        }

        private void btnButikkExport_Click(object sender, EventArgs e)//---------------excel export
        {
            _Application excel = new Microsoft.Office.Interop.Excel.Application();
            _Workbook workbook = excel.Workbooks.Add(Type.Missing);
            _Worksheet worksheet = null;
            try
            {
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Butikkdata_order_ " + lblDatecode.Text;
                worksheet.Range["A1"].Value2 = "Ordre nummer:";
                worksheet.Range["B1"].Value2 = lblOrdreNumber.Text.ToString();
                worksheet.Range["A2"].Value2 = "Departure:";
                worksheet.Range["B2"].Value2 = lblDeparture.Text.ToString();
                worksheet.Range["A3"].Value2 = "Arrival:";
                worksheet.Range["B3"].Value2 = lblArrival.Text.ToString();
                worksheet.Range["A4"].Value2 = "Datecode:";
                worksheet.Range["B4"].Value2 = lblDatecode.Text.ToString();
                for (int colIndex = 5; colIndex < dataGridViewTest2.Columns.Count; colIndex++)//copy columns headers
                {
                    worksheet.Cells[6, colIndex - 4] = dataGridViewTest2.Columns[colIndex].HeaderText;
                    worksheet.Cells[6, colIndex - 4].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                }
                for (int rowIndex = 0; rowIndex < dataGridViewTest2.Rows.Count; rowIndex++)//copy rest of rows
                {
                    for (int colIndex = 5; colIndex < dataGridViewTest2.Columns.Count; colIndex++)
                    {
                        worksheet.Cells[rowIndex + 7, colIndex - 4] = dataGridViewTest2.Rows[rowIndex].Cells[colIndex].Value.ToString();
                        worksheet.Rows[rowIndex + 7].Rowheight = 13;
                    }
                }
                int lastRow = dataGridViewTest2.Rows.Count + 6;
                worksheet.Cells[dataGridViewTest2.Rows.Count + 7, 11].Formula = "=sum(K7:K" + lastRow + ")";
                worksheet.Cells[dataGridViewTest2.Rows.Count + 7, 12].Formula = "=sum(L7:L" + lastRow + ")";
                worksheet.Cells[dataGridViewTest2.Rows.Count + 7, 13].Formula = lblAmountPrice.Text.ToString();
                worksheet.Cells[dataGridViewTest2.Rows.Count + 7, 14].Formula = "=sum(N7:N" + lastRow + ")";
                lastRow++;
                worksheet.Range[string.Format("K{0}:N{1}", lastRow.ToString(), lastRow.ToString())].Font.Bold = true;
                worksheet.Range[string.Format("K{0}:N{1}", lastRow.ToString(), lastRow.ToString())].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGreen);
                worksheet.Columns[1].ColumnWidth = 40;
                worksheet.Rows[6].Font.Bold = true;
                worksheet.Range["A1:B4"].Font.Bold = true;
                string file = @"C:\innkjop\butikk_orders\butikkdata_order_" + lblDatecode.Text.ToString() + ".xlsx";
                workbook.SaveAs(file);
                Process.Start("excel.exe", file);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }

        private void btnButikkSkriv_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var drawPoint = new PointF(150.0F, 150.0F);
            var drawFont = new System.Drawing.Font("Arial", 16);
            var drawBrush = new SolidBrush(Color.Black);
            string s1 = "Ordre nummer: " + lblOrdreNumber.Text.ToString();
            var drawPoint1 = new PointF(150.0F, 150.0F);
            e.Graphics.DrawString(s1, drawFont, drawBrush, drawPoint1);

            string s2 = "Antall boxes: " + lblAmountBoxes.Text.ToString();
            var drawPoint2 = new PointF(150.0F, 190.0F);
            e.Graphics.DrawString(s2, drawFont, drawBrush, drawPoint2);

            string s3 = "Table view coming soon";
            var drawPoint3 = new PointF(150.0F, 300.0F);
            e.Graphics.DrawString(s3, drawFont, drawBrush, drawPoint3);
            var drawPoint4 = new PointF(150.0F, 50.0F);
            e.Graphics.DrawImage(picLogo.Image, drawPoint4);
        }

    }
}
