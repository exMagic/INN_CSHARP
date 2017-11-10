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
            dataGridViewTest2.Columns[0].Visible = false;
            dataGridViewTest2.Columns[1].Visible = false;
            dataGridViewTest2.Columns[2].Visible = false;
            dataGridViewTest2.Columns[3].Visible = false;

            mySql.fillupLabels(lblDeparture, lblArrival, lblDatecode, lblAmountBoxes, lblAmountStems, lblAmountBuckets, lblAmountPrice, dataGridViewTest2);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            _Application excel = new Microsoft.Office.Interop.Excel.Application();
            _Workbook workbook = excel.Workbooks.Add(Type.Missing);
            _Worksheet worksheet = null;
            try
            {
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Butikkdata_order_ " + lblDatecode.Text;
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
                worksheet.Cells[dataGridViewTest2.Rows.Count + 7, 12].Formula = "=sum(L7:L" + lastRow + ")";
                worksheet.Cells[dataGridViewTest2.Rows.Count + 7, 13].Formula = "=sum(M7:M" + lastRow + ")";
                worksheet.Cells[dataGridViewTest2.Rows.Count + 7, 14].Formula = lblAmountPrice.Text.ToString();
                worksheet.Cells[dataGridViewTest2.Rows.Count + 7, 15].Formula = "=sum(O7:O" + lastRow + ")";
                lastRow++;
                worksheet.Range[string.Format("L{0}:O{1}", lastRow.ToString(), lastRow.ToString())].Font.Bold = true;
                worksheet.Range[string.Format("L{0}:O{1}", lastRow.ToString(), lastRow.ToString())].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGreen);
                worksheet.Columns[1].ColumnWidth = 40;
                worksheet.Rows[6].Font.Bold = true;
                worksheet.Range["A2:B4"].Font.Bold = true;
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



    }
}
