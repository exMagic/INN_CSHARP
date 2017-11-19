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
    public partial class Farms : Form
    {
        public int x;
        public Farms(int orderNumber)
        {
            x = orderNumber;
            InitializeComponent();
        }

        public void updateFarmsForm()
        {
            var mySql = new mySql();
            int y = Convert.ToInt32(dataGridViewFarms.Rows[dataGridViewFarms.CurrentRow.Index].Cells[1].Value);
            mySql.loadOneFarm(x, y);
            dataGridViewFarmBestilling.DataSource = bindingSourceOrders2;
            mySql.GetData(mySql.farmsLoadOneFarmStatement, bindingSourceOrders2);
            lblOrdreNumber.Text = dataGridViewFarmBestilling.Rows[0].Cells["order_number"].Value.ToString();
            lblDeparture.Text = dataGridViewFarmBestilling.Rows[0].Cells["departure"].Value.ToString().Substring(0, 10); ;
            lblArrival.Text = dataGridViewFarmBestilling.Rows[0].Cells["arrival"].Value.ToString().Substring(0, 10); ;
            lblDatecode.Text = dataGridViewFarmBestilling.Rows[0].Cells["datecode"].Value.ToString();
            int sumBoxes = 0;
            decimal sumPrice = 0;
            for (int i = 0; i < dataGridViewFarmBestilling.Rows.Count; ++i)
            {
                sumBoxes += Convert.ToInt32(dataGridViewFarmBestilling.Rows[i].Cells["boxes"].Value);
                sumPrice += Convert.ToDecimal(dataGridViewFarmBestilling.Rows[i].Cells["price"].Value);
            }
            lblAmountPrice.Text = sumPrice.ToString();
            lblAmountBoxes.Text = sumBoxes.ToString();
            dataGridViewFarmBestilling.Columns["variety"].Width = 200;
            dataGridViewFarmBestilling.Columns["order_number"].Visible = false;
            dataGridViewFarmBestilling.Columns["departure"].Visible = false;
            dataGridViewFarmBestilling.Columns["arrival"].Visible = false;
            dataGridViewFarmBestilling.Columns["datecode"].Visible = false;
            dataGridViewFarmBestilling.Columns["farm"].Visible = false;
            dataGridViewFarmBestilling.Columns["boxes"].DisplayIndex = 16;

        }
        private void Farms_Load(object sender, EventArgs e)
        {
            lblOrderNumberTitle.Text = x.ToString();
            var mySql = new mySql();
            mySql.loadFarms(x);
            dataGridViewFarms.DataSource = bindingSourceOrders;
            mySql.GetData(mySql.farmsLoadFarmsStatement, bindingSourceOrders);
            dataGridViewFarms.Columns["farm_id"].Visible = false;
            dataGridViewFarms.Columns[0].Width = 170;

            updateFarmsForm();
        }

        private void dataGridViewFarms_SelectionChanged(object sender, EventArgs e)
        {
            updateFarmsForm();
            MessageBox.Show("Test"+ dataGridViewFarms.Rows[dataGridViewFarms.CurrentRow.Index].Cells[0].Value.ToString() +"Test");
        }

        private void btnButikkExport_Click(object sender, EventArgs e)
        {
            _Application excel = new Microsoft.Office.Interop.Excel.Application();
            _Workbook workbook = excel.Workbooks.Add(Type.Missing);
            _Worksheet worksheet = null;
            try
            {
                string farm_name = dataGridViewFarms.Rows[dataGridViewFarms.CurrentRow.Index].Cells[0].Value.ToString();
                worksheet = workbook.ActiveSheet;
                worksheet.Name = farm_name + "_order_ " + lblDatecode.Text;
                worksheet.Range["A1"].Value2 = "Ordre nummer:";
                worksheet.Range["B1"].Value2 = lblOrdreNumber.Text.ToString();
                worksheet.Range["A2"].Value2 = "Departure:";
                worksheet.Range["B2"].Value2 = lblDeparture.Text.ToString();
                worksheet.Range["A3"].Value2 = "Arrival:";
                worksheet.Range["B3"].Value2 = lblArrival.Text.ToString();
                worksheet.Range["A4"].Value2 = "Datecode:";
                worksheet.Range["B4"].Value2 = lblDatecode.Text.ToString();
                for (int colIndex = 4; colIndex < dataGridViewFarmBestilling.Columns.Count; colIndex++)//copy columns headers
                {
                    worksheet.Cells[6, colIndex - 3] = dataGridViewFarmBestilling.Columns[colIndex].HeaderText;
                    worksheet.Cells[6, colIndex - 3].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                }
                for (int rowIndex = 0; rowIndex < dataGridViewFarmBestilling.Rows.Count; rowIndex++)//copy rest of rows
                {
                    for (int colIndex = 4; colIndex < dataGridViewFarmBestilling.Columns.Count; colIndex++)
                    {
                        worksheet.Cells[rowIndex + 7, colIndex - 3] = dataGridViewFarmBestilling.Rows[rowIndex].Cells[colIndex].Value.ToString();
                        worksheet.Rows[rowIndex + 7].Rowheight = 13;
                    }
                }
                int lastRow = dataGridViewFarmBestilling.Rows.Count + 6;
                worksheet.Cells[dataGridViewFarmBestilling.Rows.Count + 7, 12].Formula = "=sum(L7:L" + lastRow + ")";
                lastRow++;
                worksheet.Range[string.Format("L{0}", lastRow.ToString(), lastRow.ToString())].Font.Bold = true;
                worksheet.Range[string.Format("L{0}", lastRow.ToString(), lastRow.ToString())].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGreen);
                worksheet.Columns[1].ColumnWidth = 16;
                worksheet.Columns[2].ColumnWidth = 30;
                worksheet.Rows[6].Font.Bold = true;
                worksheet.Range["A1:B4"].Font.Bold = true;
                worksheet.Range["B1:B4"].Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                string file = @"C:\innkjop\farms_orders\" + farm_name + "_order_" + lblDatecode.Text.ToString() + ".xlsx";
                MessageBox.Show("xxx" + farm_name + "xxx");
                MessageBox.Show(file);
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
