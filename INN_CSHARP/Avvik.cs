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
    public partial class Avvik : Form
    {
        public int x;
        public Avvik(int orderNumber)
        {
            x = orderNumber;
            InitializeComponent();
        }

        private void Avvik_Load(object sender, EventArgs e)
        {
            lblOrderNumberTitle.Text = x.ToString();
            var mySql = new mySql();
            mySql.loadAvvik(x);
            dataGridViewTest.DataSource = bindingSourceOrders;
            mySql.GetData(mySql.loadAvvikStatement, bindingSourceOrders);

            dataGridViewTest.Columns[0].Visible = false;
            dataGridViewTest.Columns[1].Visible = false;
            dataGridViewTest.Columns[2].Visible = false;
            dataGridViewTest.Columns[3].Visible = false;
            dataGridViewTest.Columns["variety"].Width = 200;
            dataGridViewTest.Columns["boxes"].DisplayIndex = 15;
            mySql.fillupLabelsAvvik(lblOrdreNumber, lblDeparture, lblArrival, lblDatecode, lblAmountBoxes, dataGridViewTest);
        }

        private void btnButikkExport_Click(object sender, EventArgs e)
        {
            _Application excel = new Microsoft.Office.Interop.Excel.Application();
            _Workbook workbook = excel.Workbooks.Add(Type.Missing);
            _Worksheet worksheet = null;
            try
            {
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Avviksskjema_order_ " + lblDatecode.Text;
                worksheet.Range["A1"].Value2 = "Ordre nummer:";
                worksheet.Range["B1"].Value2 = lblOrdreNumber.Text.ToString();
                worksheet.Range["A2"].Value2 = "Departure:";
                worksheet.Range["B2"].Value2 = lblDeparture.Text.ToString();
                worksheet.Range["A3"].Value2 = "Arrival:";
                worksheet.Range["B3"].Value2 = lblArrival.Text.ToString();
                worksheet.Range["A4"].Value2 = "Datecode:";
                worksheet.Range["B4"].Value2 = lblDatecode.Text.ToString();
                for (int colIndex = 4; colIndex < dataGridViewTest.Columns.Count; colIndex++)//copy columns headers
                {
                    worksheet.Cells[6, colIndex - 3] = dataGridViewTest.Columns[colIndex].HeaderText;
                    worksheet.Cells[6, colIndex - 3].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                }
                for (int rowIndex = 0; rowIndex < dataGridViewTest.Rows.Count; rowIndex++)//copy rest of rows
                {
                    for (int colIndex = 4; colIndex < dataGridViewTest.Columns.Count; colIndex++)
                    {
                        worksheet.Cells[rowIndex + 7, colIndex - 3] = dataGridViewTest.Rows[rowIndex].Cells[colIndex].Value.ToString();
                        worksheet.Rows[rowIndex + 7].Rowheight = 13;
                    }
                }
                int lastRow = dataGridViewTest.Rows.Count + 6;
                worksheet.Cells[dataGridViewTest.Rows.Count + 7, 12].Formula = "=sum(L7:L" + lastRow + ")";
                lastRow++;
                worksheet.Range[string.Format("L{0}", lastRow.ToString(), lastRow.ToString())].Font.Bold = true;
                worksheet.Range[string.Format("L{0}", lastRow.ToString(), lastRow.ToString())].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGreen);
                worksheet.Columns[1].ColumnWidth = 16;
                worksheet.Columns[2].ColumnWidth = 30;
                worksheet.Rows[6].Font.Bold = true;
                worksheet.Range["A1:B4"].Font.Bold = true;
                worksheet.Range["B1:B4"].Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                string file = @"C:\innkjop\avvik_orders\avviksskjema_order_" + lblDatecode.Text.ToString() + ".xlsx";
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
