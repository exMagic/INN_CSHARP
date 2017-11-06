using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace INN_CSHARP
{
    public partial class AddOr : Form
    {
        //TODO: 4 labeles like antall buckets fob steems boxes
        public AddOr()
        {
            InitializeComponent();
        }
        string CBselect;
        public string whFarm;
        public string whLen;
        public string whColour;
        public string whSleeve;
        public string whMix = "and flowers.mix=0";
        public string whFt = "and flowers.fairtrade=0";
        string date_created;
        string insertFltoOrder;
        string selectOrder;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //TODO: check if fl_id is not exist in that order
            var mySql = new mySql();
            createSQLSelelct();
            createSQLInsert();

            mySql.GetData(insertFltoOrder, bindingSourceOrders);
            dataGridViewAON.DataSource = bindingSourceOrders;
            mySql.GetData(selectOrder, bindingSourceOrders);
            dataGridViewAON.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            int i = 0;
            while (i < 5)
            {
                dataGridViewAON.Columns[i].Visible = false;//TODO Erro when 543 order number
                i++;
            }
        }
        void createSQLInsert()
        {
            string boxes = Prompt.ShowDialog("Hvor mange esker?", "Antall boxes").ToString();
            string fl_id = dataGridViewOA[0, dataGridViewOA.CurrentRow.Index].Value.ToString();
            string date_modified = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss").Replace('.', ':');
            string departure = dateTimePickerDeparture.Value.Date.ToString("yyyy-MM-dd");
            string arrival = dateTimePickerArrival.Value.Date.ToString("yyyy-MM-dd");
            insertFltoOrder = @"INSERT INTO [dbo].[orders]
           ([order_number]
           ,[departure]
           ,[arrival]
           ,[datecode]
           ,[fl_id]
           ,[boxes]
           ,[date_created]
           ,[date_modified])
     VALUES     ('" + lblOrderNumber.Text + "'" +
                ",'" + departure + "'" +
                ",'" + arrival + "'" +
                ",'" + lblDatecode.Text + "'" +
                ",'" + fl_id + "'" +
                ",'" + boxes + "'" +
                ",'" + date_created + "'" +
                ",'" + date_modified + "')"
                ;
        }
        void createSQLSelelct()
        {
            string orderNumber = txtOrderNumber.Text.ToString();
            selectOrder = @"SELECT
            orders.order_id
            ,orders.departure
            ,orders.arrival
            ,orders.order_number
            ,orders.datecode
            ,flowers.variety as 'Variety'
            ,farms.farm_name as 'Farm'
            ,flowers.plu as 'PLU'
            ,lengths.length as 'Lenght'
            ,flowers.pak_rate as 'pak rate'
            ,orders.boxes
            ,(SELECT orders.boxes) * (SELECT flowers.pak_rate) as stems
            , ((SELECT orders.boxes) * (SELECT flowers.pak_rate) / (SELECT flowers.stems_pr_bunch) / (SELECT flowers.bunch_pr_bucket))as buckets
            
          FROM[MG_inkjop].[dbo].[flowers], [MG_inkjop].[dbo].[farms], [MG_inkjop].[dbo].[lengths], [MG_inkjop].[dbo].[colours], [MG_inkjop].[dbo].[sleeves], [MG_inkjop].[dbo].[orders]
          WHERE flowers.farm_id = farms.farm_id and flowers.length_id = lengths.length_id and flowers.colour_id = colours.colour_id and flowers.sleeve_id = sleeves.sleeve_id and flowers.fl_id = orders.fl_id and orders.order_number = " + orderNumber + "  ORDER BY farm_name, length";
            
        }
        public string order_numer;
        public string datecode;
        public string departure;
        public string arrival;
        private void AddOr_Load(object sender, EventArgs e)
        {
            var mySql = new mySql();
            CBselect = mySql.selectFlAddOr + whFarm + whLen + whColour + whSleeve + whMix + whFt;
            dataGridViewOA.DataSource = bindingSource1;
            mySql.GetData(CBselect, bindingSource1);
            dataGridViewOA.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //fill up dataGridView by Farms
            dataGridView1.DataSource = bindingSource5;
            mySql.GetData(mySql.selectFarms, bindingSource5);
            //fill up dataGridView by Lengths
            dataGridView2.DataSource = bindingSource2;
            mySql.GetData(mySql.selectLengths, bindingSource2);
            ////fill up dataGridView by Colours
            dataGridView3.DataSource = bindingSource3;
            mySql.GetData(mySql.selectColour, bindingSource3);
            ////fill up dataGridView by Sleeves
            dataGridView4.DataSource = bindingSource4;
            mySql.GetData(mySql.selectSleeve, bindingSource4);
            //fill up combo boxes
            mySql.fillUpCb(cbFarm, "SELECT farms.farm_name FROM[MG_inkjop].[dbo].[farms]");
            mySql.fillUpCb(cbLengths, "SELECT lengths.length FROM[MG_inkjop].[dbo].[lengths]");
            mySql.fillUpCb(cbColour, "SELECT colours.colour FROM[MG_inkjop].[dbo].[colours]");
            mySql.fillUpCb(cbSleeve, "SELECT sleeves.sleeve FROM[MG_inkjop].[dbo].[sleeves]");
            dataGridViewOA.Columns[0].Visible = true;

            dataGridViewOrders.DataSource = bindingSourceOrders;
            mySql.GetData("select order_number from [MG_inkjop].[dbo].[orders] group by order_number", bindingSourceOrders);
            dataGridViewOrders.AllowUserToAddRows = false;//prevent from create empt row on the end

            tabControlAddOrder.Appearance = TabAppearance.Buttons;
            tabControlAddOrder.ItemSize = new Size(0, 1);
            tabControlAddOrder.SizeMode = TabSizeMode.Fixed;

            radioButtonMix1.Checked = true;
            radioButtonFt1.Checked = true;
            mySql.updateAntall(lblAddOrAntalFl, dataGridViewOA);
        }
        private void cbFarm_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mySql = new mySql();
            whFarm = mySql.findCbValue(cbFarm, whFarm, btnRemoveAOF, dataGridView1, "and farms.farm_id=", txtSearch);

            CBselect = mySql.selectFlAddOr + whFarm + whLen + whColour + whSleeve + whMix + whFt;
            mySql.GetData(CBselect, bindingSource1);
            mySql.updateAntall(lblAddOrAntalFl, dataGridViewOA);
        }
        private void cbLengths_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mySql = new mySql();
            whLen = mySql.findCbValue(cbLengths, whLen, btnRemoveAOL, dataGridView2, "and lengths.length_id=", txtSearch);
            CBselect = mySql.selectFlAddOr + whFarm + whLen + whColour + whSleeve + whMix + whFt;
            mySql.GetData(CBselect, bindingSource1);
            mySql.updateAntall(lblAddOrAntalFl, dataGridViewOA);
        }
        private void cbColour_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mySql = new mySql();
            whColour = mySql.findCbValue(cbColour, whColour, btnRemoveAOC, dataGridView3, "and colours.colour_id=", txtSearch);
            CBselect = mySql.selectFlAddOr + whFarm + whLen + whColour + whSleeve + whMix + whFt;
            mySql.GetData(CBselect, bindingSource1);
            mySql.updateAntall(lblAddOrAntalFl, dataGridViewOA);
        }
        private void cbSleeve_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mySql = new mySql();
            whSleeve = mySql.findCbValue(cbSleeve, whSleeve, btnRemoveAOS, dataGridView4, "and sleeves.sleeve_id=", txtSearch);
            CBselect = mySql.selectFlAddOr + whFarm + whLen + whColour + whSleeve + whMix + whFt;
            mySql.GetData(CBselect, bindingSource1);
            mySql.updateAntall(lblAddOrAntalFl, dataGridViewOA);
        }
        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOrderNumber.Text)) MessageBox.Show("Legg in Ordrenummer", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (string.IsNullOrWhiteSpace(txtDatecode.Text)) MessageBox.Show("Legg in Datecode", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    bool newOrder = true;
                    foreach (DataGridViewRow row in dataGridViewOrders.Rows)
                    {
                        if (row.Cells[0].Value.ToString() == txtOrderNumber.Text)
                        {
                            newOrder = false;
                            break;
                        }
                    }
                    if (newOrder)
                    {
                        date_created = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss").Replace('.', ':');
                        tabControlAddOrder.SelectedIndex = 1;
                        order_numer = txtOrderNumber.Text;
                        datecode = txtDatecode.Text;
                        departure = dateTimePickerDeparture.Text;
                        arrival = dateTimePickerArrival.Text;
                        lblOrderNumber.Text = order_numer;
                        lblDatecode.Text = datecode;
                        lblDeparture.Text = departure;
                        lblArrival.Text = arrival;
                    }
                    else MessageBox.Show("Dette ordrenummer finnes allerede", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnRemoveAOF_Click(object sender, EventArgs e)
        {
            cbFarm.SelectedIndex = 0;
        }
        private void btnRemoveAOL_Click(object sender, EventArgs e)
        {
            cbLengths.SelectedIndex = 0;
        }
        private void btnRemoveAOC_Click(object sender, EventArgs e)
        {
            cbColour.SelectedIndex = 0;
        }
        private void btnRemoveAOS_Click(object sender, EventArgs e)
        {
            cbSleeve.SelectedIndex = 0;
        }
        private void txtOrderNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtDatecode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void radioButtonMix1_CheckedChanged(object sender, EventArgs e)//------------------MIX
        {
            var mySql = new mySql();
            if (radioButtonMix1.Checked) whMix = "";
            CBselect = mySql.selectFlAddOr + whFarm + whLen + whColour + whSleeve + whMix + whFt;
            mySql.GetData(CBselect, bindingSource1);
            txtSearch.Text = "";
            mySql.updateAntall(lblAddOrAntalFl, dataGridViewOA);
        }
        private void radioButtonMix2_CheckedChanged(object sender, EventArgs e)
        {
            var mySql = new mySql();
            if (radioButtonMix2.Checked) whMix = "and flowers.mix=1";
            CBselect = mySql.selectFlAddOr + whFarm + whLen + whColour + whSleeve + whMix + whFt;
            mySql.GetData(CBselect, bindingSource1);
            txtSearch.Text = "";
            mySql.updateAntall(lblAddOrAntalFl, dataGridViewOA);
        }
        private void radioButtonMix3_CheckedChanged(object sender, EventArgs e)
        {
            var mySql = new mySql();
            if (radioButtonMix3.Checked) whMix = "and flowers.mix=0";
            CBselect = mySql.selectFlAddOr + whFarm + whLen + whColour + whSleeve + whMix + whFt;
            mySql.GetData(CBselect, bindingSource1);
            txtSearch.Text = "";
            mySql.updateAntall(lblAddOrAntalFl, dataGridViewOA);
        }
        private void radioButtonFt1_CheckedChanged(object sender, EventArgs e)//------------------FT
        {
            var mySql = new mySql();
            if (radioButtonFt1.Checked) whFt = "";
            CBselect = mySql.selectFlAddOr + whFarm + whLen + whColour + whSleeve + whMix + whFt;
            mySql.GetData(CBselect, bindingSource1);
            txtSearch.Text = "";
            mySql.updateAntall(lblAddOrAntalFl, dataGridViewOA);
        }

        private void radioButtonFt2_CheckedChanged(object sender, EventArgs e)
        {
            var mySql = new mySql();
            if (radioButtonFt2.Checked) whFt = "and flowers.fairtrade=1";
            CBselect = mySql.selectFlAddOr + whFarm + whLen + whColour + whSleeve + whMix + whFt;
            mySql.GetData(CBselect, bindingSource1);
            txtSearch.Text = "";
            mySql.updateAntall(lblAddOrAntalFl, dataGridViewOA);
        }

        private void radioButtonFt3_CheckedChanged(object sender, EventArgs e)
        {
            var mySql = new mySql();
            if (radioButtonFt3.Checked) whFt = "and flowers.fairtrade=0";
            CBselect = mySql.selectFlAddOr + whFarm + whLen + whColour + whSleeve + whMix + whFt;
            mySql.GetData(CBselect, bindingSource1);
            txtSearch.Text = "";
            mySql.updateAntall(lblAddOrAntalFl, dataGridViewOA);
        }

        private void btnSearchFl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text)) { }
            else{
                string tmp = txtSearch.Text;
                cbLengths.SelectedIndex = 0;
                cbColour.SelectedIndex = 0;
                cbFarm.SelectedIndex = 0;
                cbSleeve.SelectedIndex = 0;
                radioButtonMix1.Checked = true;
                radioButtonFt1.Checked = true;
                txtSearch.Text = tmp;
                var mySql = new mySql();
                string search = "and flowers.plu=" + txtSearch.Text;
                CBselect = mySql.selectFlAddOr + search;
                mySql.GetData(CBselect, bindingSource1);
                mySql.updateAntall(lblAddOrAntalFl, dataGridViewOA);
            }
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void keypressed(Object o, KeyPressEventArgs e)//ENTER key
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                if (string.IsNullOrWhiteSpace(txtSearch.Text)) { }
                else
                {
                    string tmp = txtSearch.Text;
                    cbLengths.SelectedIndex = 0;
                    cbColour.SelectedIndex = 0;
                    cbFarm.SelectedIndex = 0;
                    cbSleeve.SelectedIndex = 0;
                    radioButtonMix1.Checked = true;
                    radioButtonFt1.Checked = true;
                    txtSearch.Text = tmp;
                    var mySql = new mySql();
                    string search = "and flowers.plu=" + txtSearch.Text;
                    CBselect = mySql.selectFlAddOr + search;
                    mySql.GetData(CBselect, bindingSource1);
                    mySql.updateAntall(lblAddOrAntalFl, dataGridViewOA);
                }
            }
        }




        

    }
}
