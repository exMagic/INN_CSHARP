using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
        }
    }
}
