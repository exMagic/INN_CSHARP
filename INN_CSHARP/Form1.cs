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
using System.Data.OleDb;

namespace INN_CSHARP
{

    public partial class Form1 : Form
    {


        public string whFarm;
        public string whLen;
        public string selectionStatement4;
        bool loaded = false;
        bool loadOrders = false;


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            var mySql = new mySql();
            var menu = new Design();
            
            menu.resBtn(button1, button2, button3, button4, menuArrow1, menuArrow2, menuArrow3, menuArrow4);
            Color _selected = System.Drawing.ColorTranslator.FromHtml("#243240");
            button1.BackColor = _selected;
            menuArrow1.Visible = true;
            dataGridViewFL.DataSource = bindingSource3;
            mySql.GetData(mySql.loadLengthsStatement, bindingSource3);
            dataGridViewFF.DataSource = bindingSourceFarms;
            mySql.GetData(mySql.loadFarmsStatement, bindingSourceFarms);
           

            dataGridViewFlMain.DataSource = bindingSource1;
            mySql.GetData(mySql.FlowersMainStatement, bindingSource1);

            dataGridViewFlMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;



            dataGridViewFlMain.Columns["fl_id"].Visible = false;
            dataGridViewFlMain.Columns["Variety"].Width = 100;

            dataGridViewFlMain.Columns["Sticker text"].Visible = false;
            dataGridViewFlMain.Columns["Colour"].Width = 60;
            dataGridViewFlMain.Columns["PLU"].Width = 40;
            dataGridViewFlMain.Columns["Farm"].Width = 40;
            dataGridViewFlMain.Columns["mix"].Visible = false;
            dataGridViewFlMain.Columns["Sleeve"].Visible = false;
            dataGridViewFlMain.Columns["With sleeves"].Visible = false;
            dataGridViewFlMain.Columns["fob"].Visible = false;
            int s = 41;
            dataGridViewFlMain.Columns["Fairtrade"].Width = s;
            dataGridViewFlMain.Columns["Bunch_pr bucket"].Width = s;
            dataGridViewFlMain.Columns["Stems_pr bunch"].Width = s;
            dataGridViewFlMain.Columns["pak rate"].Width = 48;



            tabControl1.Appearance = TabAppearance.Buttons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            //////////////// fil up comboBox
            string Sql = "SELECT farms.farm_name FROM[MG_inkjop].[dbo].[farms]";
            SqlConnection conn = new SqlConnection(mySql.connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            SqlDataReader DR = cmd.ExecuteReader();

            cbFarm.Items.Add("All");
            while (DR.Read())
            {
                cbFarm.Items.Add(DR[0]);
            }
            cbFarm.SelectedIndex = 0;
            conn.Close();
            //////////////// fil up comboBox
            string Sql2 = "SELECT lengths.length FROM[MG_inkjop].[dbo].[lengths]";
            conn.Open();
            SqlCommand cmd2 = new SqlCommand(Sql2, conn);
            SqlDataReader DR2 = cmd2.ExecuteReader();
            cbLength.Items.Add("All");
            while (DR2.Read())
            {
                cbLength.Items.Add(DR2[0]);
            }
            cbLength.SelectedIndex = 0;
            conn.Close();
            label2.Text = dataGridViewFlMain.RowCount.ToString();//count amount of rows



            fillUpInspectorFl();
           
            loaded = true;
        }
        ///////////////////////  MENU  //////////////////////////////////////////////////////////////////////
        //public void resBtn()

        private void button1_Click(object sender, EventArgs e)
        {
            var menu = new Design();
            menu.resBtn(button1, button2, button3, button4, menuArrow1, menuArrow2, menuArrow3, menuArrow4);
            menu.colorBtn(button1, tabControl1, 0, menuArrow1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var menu = new Design();
            menu.resBtn(button1, button2, button3, button4, menuArrow1, menuArrow2, menuArrow3, menuArrow4);
            menu.colorBtn(button2, tabControl1, 1, menuArrow2);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var menu = new Design();
            menu.resBtn(button1, button2, button3, button4, menuArrow1, menuArrow2, menuArrow3, menuArrow4);
            menu.colorBtn(button3, tabControl1, 2, menuArrow3);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            var menu = new Design();
            menu.resBtn(button1, button2, button3, button4, menuArrow1, menuArrow2, menuArrow3, menuArrow4);
            menu.colorBtn(button4, tabControl1, 3, menuArrow4);
        }
        /////////////////////// END MENU  //////////////////////////////////////////////////////////////////////

        // Flowers - FARM FILTER ///////////
        public void setWidth(DataGridView dg)
        {
            dg.Width = (dg.Rows.Count > 22) ? 718: 701;
        }
        private void cbFarm_SelectedIndexChanged(object sender, EventArgs e)// FARM FILTER ///////////
        {
            var CB = new CB();
            whFarm = CB.cbChange(cbFarm, whFarm, btnRemoveFF, dataGridViewFF, "and farms.farm_id=");
            var mySql = new mySql();
            selectionStatement4 = mySql.FlowersMainStatement + whFarm + whLen;
            mySql.GetData(selectionStatement4, bindingSource1);
            label2.Text = dataGridViewFlMain.RowCount.ToString();//count amount of rows
            fillUpInspectorFl();
            setWidth(dataGridViewFlMain);
        }
        private void btnRemoveFF_Click(object sender, EventArgs e) { cbFarm.SelectedIndex = 0; }
        // Flowers - LENGTH FILTER ///////////
        private void cbLength_SelectedIndexChanged(object sender, EventArgs e) // LENGTH FILTER ///////////
        {
            var CB = new CB();
            whLen = CB.cbChange(cbLength, whLen, btnRemoveFL, dataGridViewFL, "and flowers.length_id=");
            var mySql = new mySql();
            selectionStatement4 = mySql.FlowersMainStatement + whFarm + whLen;
            mySql.GetData(selectionStatement4, bindingSource1);
            label2.Text = dataGridViewFlMain.RowCount.ToString();//count amount of rows
            fillUpInspectorFl();
            setWidth(dataGridViewFlMain);
        }
        private void btnRemoveFL_Click(object sender, EventArgs e) { cbLength.SelectedIndex = 0; }

        // EDIT Flower///////////////////////////////////////////////////////////////
        public static int idToEdit;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idToEdit = Convert.ToInt32(dataGridViewFlMain.Rows[e.RowIndex].Cells[0].Value.ToString());
                EditFl frm = new EditFl();
                frm.FormClosing += new FormClosingEventHandler(this.Edit_FormClosing);
                frm.Show();
            }
        }
        private void btnFEdit_Click(object sender, EventArgs e)
        {
            idToEdit = Convert.ToInt32(dataGridViewFlMain[0, dataGridViewFlMain.CurrentRow.Index].Value.ToString());
            EditFl frm = new EditFl();
            frm.FormClosing += new FormClosingEventHandler(this.Edit_FormClosing);
            frm.Show();
        }
        private void Edit_FormClosing(object sender, FormClosingEventArgs e)
        {
            var mySql = new mySql();
            mySql.GetData(selectionStatement4, bindingSource1);
            label2.Text = dataGridViewFlMain.RowCount.ToString();//count amount of rows
        }
        // ADD Flower///////////////////////////////////////////////////////////////
        private void btnFAdd_Click(object sender, EventArgs e)
        {
            AddFl frm = new AddFl();
            frm.FormClosing += new FormClosingEventHandler(this.Add_FormClosing);
            frm.Show();
        }
        private void Add_FormClosing(object sender, FormClosingEventArgs e)
        {
            var mySql = new mySql();
            mySql.GetData(selectionStatement4, bindingSource1);
            label2.Text = dataGridViewFlMain.RowCount.ToString();//count amount of rows
            dataGridViewFlMain.CurrentCell = dataGridViewFlMain.Rows[dataGridViewFlMain.RowCount - 1].Cells["plu"];
        }
        // DELETE Flower///////////////////////////////////////////////////////////////
        private void btnFDelete_Click(object sender, EventArgs e)
        {
            var mySql = new mySql();
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + dataGridViewFlMain[0, dataGridViewFlMain.CurrentRow.Index].Value.ToString() + " flower from database? This Action can not be undone", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                var idToDelete = dataGridViewFlMain[0, dataGridViewFlMain.CurrentRow.Index].Value.ToString();
                string delete = @"DELETE FROM [dbo].[flowers] WHERE fl_id=" + idToDelete;
                mySql.GetData(delete, bindingSource1);
            }
            mySql.GetData(selectionStatement4, bindingSource1);
        }
        /// -------------------------------------------------- ORDERS---------------------------------




        //private void cbOrders_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    var mySql = new mySql();


        //    dataGridViewO1.DataSource = bindingSourceOrders;
        //    mySql.GetData(mySql.loadOrdersStatement, bindingSourceOrders);
        //    dataGridViewO1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    dataGridViewO2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        //    dataGridViewO1.Columns["order_id"].Visible = false; //order_id
        //    dataGridViewO1.Columns["departure"].Visible = false; //departure
        //    dataGridViewO1.Columns["arrival"].Visible = false; //arrival
        //    dataGridViewO1.Columns["datecode"].Visible = false; //datecode
        //    dataGridViewO1.Columns["variety"].Width = 110; //variety
        //    //dataGridViewO1.Columns["farm"].DisplayIndex = 4; //farm_name
        //    //dataGridViewO1.Columns["plu"].DisplayIndex = 6; //plu
        //    //dataGridViewO1.Columns["length"].DisplayIndex = 7; //length
        //    //dataGridViewO1.Columns["pak_rate"].DisplayIndex = 8; //pak_rate
        //    dataGridViewO1.Columns["boxes"].DisplayIndex = 13; //boxes
        //    //dataGridViewO1.Columns["stems"].DisplayIndex = 10; //stems
        //    //dataGridViewO1.Columns["buckets"].DisplayIndex = 11; //buckets

        //    lblDateCreated.Text = dataGridViewO1.Rows[0].Cells[1].Value.ToString().Substring(0, 10);
        //    lblDateModified.Text = dataGridViewO1.Rows[0].Cells[2].Value.ToString().Substring(0, 10);

        //    int sumBoxes = 0;
        //    int sumStems = 0;
        //    int sumBucket = 0;
        //    decimal sumPrice = 0;
        //    for (int i = 0; i < dataGridViewO1.Rows.Count; ++i)
        //    {
        //        sumBoxes += Convert.ToInt32(dataGridViewO1.Rows[i].Cells["boxes"].Value);
        //        sumStems += Convert.ToInt32(dataGridViewO1.Rows[i].Cells["stems"].Value);
        //        sumBucket += Convert.ToInt32(dataGridViewO1.Rows[i].Cells["buckets"].Value);
        //        sumPrice += Convert.ToDecimal(dataGridViewO1.Rows[i].Cells["price"].Value);
        //    }
        //    lblAmountBoxes.Text = sumBoxes.ToString();
        //    lblAmountStems.Text = sumStems.ToString();
        //    lblAmountBuckets.Text = sumBucket.ToString();
        //    lblAmountPrice.Text = sumPrice.ToString();
        //    btnButikkdata.Visible = true;
        //    PnButtonsOrderTabel.Visible = true;
        //    PnInsOrdre.Visible = true;
        //}

        private void btnAddOr_Click(object sender, EventArgs e)
        {
            AddOr frm = new AddOr();
            frm.FormClosing += new FormClosingEventHandler(this.AddOr_FormClosing);
            frm.Show();
        }


        private void AddOr_FormClosing(object sender, FormClosingEventArgs e)
        {
            var mySql = new mySql();

            string Sql1 = " select distinct orders.order_number as 'Order number', departure as 'Departure', arrival as 'Arrival', datecode as 'Datecode' from orders";
            dataGridViewO1.DataSource = bindingSourceOrders;
            mySql.GetData(Sql1, bindingSourceOrders);
            mySql.updateOrderInspecor(dataGridViewO1, dataGridViewO2, bindingSourceOrders2, lblDateCreated, lblDateModified, lblAmountBuckets, lblAmountPrice, lblAmountStems, lblAmountBoxes);
        }
        string st = @"
        SELECT
            orders.order_id
            ,orders.departure
            ,orders.arrival
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
          WHERE flowers.farm_id = farms.farm_id and flowers.length_id = lengths.length_id and flowers.colour_id = colours.colour_id and flowers.sleeve_id = sleeves.sleeve_id and flowers.fl_id = orders.fl_id and orders.order_number = 72  ORDER BY plu, length";





        private void button6_Click(object sender, EventArgs e)
        {
            
        }
        private void btnButkikkdata_Click(object sender, EventArgs e)
        {
            var frm = new Butikkdata(Convert.ToInt32(dataGridViewO1[0, dataGridViewO1.CurrentRow.Index].Value));
            frm.Show();
        }

        private void txtTopSearch_Click(object sender, EventArgs e)
        {
            txtTopSearch.Text = "";
        }

        private void txtTopSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                MessageBox.Show("You are trying search \"" + txtTopSearch.Text.ToString() + "\", but search engine is not ready yet... Sorry :)", "Coming soon", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                button1.Focus();
                txtTopSearch.Text = "Søk";
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            btnClose.Visible = !btnClose.Visible;
            PnNotifi.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PnNotifi.Visible = false;
            MessageBox.Show("Notifications system is not ready yet", "Coming soon", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);


        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PnNotifi.Visible = !PnNotifi.Visible;
            PnNotifi.Height = 215;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            PnNotifi.Visible = false;
            btnClose.Visible = false;
        }
        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            PnNotifi.Visible = false;
            btnClose.Visible = false;
        }
        private void tabPage5_MouseEnter(object sender, EventArgs e)
        {
            PnNotifi.Visible = false;
            btnClose.Visible = false;
        }

        private void tabPage8_MouseEnter(object sender, EventArgs e)
        {
            PnNotifi.Visible = false;
            btnClose.Visible = false;
        }

        private void tabPage7_MouseEnter(object sender, EventArgs e)
        {
            PnNotifi.Visible = false;
            btnClose.Visible = false;
        }

        private void tabPage6_MouseEnter(object sender, EventArgs e)
        {
            PnNotifi.Visible = false;
            btnClose.Visible = false;
        }

        private void PnInspector_MouseEnter(object sender, EventArgs e)
        {
            PnNotifi.Visible = false;
            btnClose.Visible = false;
        }
        public void fillUpInspectorFl()
        {
            if (dataGridViewFlMain.Rows.Count > 1)
            {
                int row = dataGridViewFlMain.CurrentCell.RowIndex;
                var mySql = new mySql();
                int fl_id = Convert.ToInt32(dataGridViewFlMain.Rows[row].Cells[0].Value);
                string loadOrdersStatement2 = @"
                SELECT top 1
                    orders.order_id
                    ,orders.departure
                    ,orders.order_number
                    ,orders.arrival
                    ,orders.boxes
                  FROM[MG_inkjop].[dbo].[flowers], [MG_inkjop].[dbo].[farms], [MG_inkjop].[dbo].[lengths], [MG_inkjop].[dbo].[colours], [MG_inkjop].[dbo].[sleeves], [MG_inkjop].[dbo].[orders]
                  WHERE flowers.farm_id = farms.farm_id and flowers.length_id = lengths.length_id and flowers.colour_id = colours.colour_id and flowers.sleeve_id = sleeves.sleeve_id and flowers.fl_id = orders.fl_id and orders.fl_id = " + fl_id + "  ORDER BY arrival desc";
                dataGridViewFlOr.DataSource = bindingSourceOrders3;
                mySql.GetData(loadOrdersStatement2, bindingSourceOrders3);
                lblInsFob.Text = dataGridViewFlMain.Rows[row].Cells["Fob"].Value.ToString();
                lblInsSticker.Text = dataGridViewFlMain.Rows[row].Cells["Sticker text"].Value.ToString();
                lblInsSleeve.Text = dataGridViewFlMain.Rows[row].Cells["Sleeve"].Value.ToString();
                cheInsWtSleeve.Checked = (dataGridViewFlMain.Rows[row].Cells["With sleeves"].Value.ToString() == "True") ? true : false;
                cheInsMix.Checked = (dataGridViewFlMain.Rows[row].Cells["mix"].Value.ToString() == "True") ? true : false;
                lblInsSisteOr.Text = (dataGridViewFlOr.Rows.Count < 2) ? "aldri" : dataGridViewFlOr.Rows[0].Cells["order_number"].Value.ToString();
                lblInsBoxes.Text = (dataGridViewFlOr.Rows.Count < 2) ? "aldri" : dataGridViewFlOr.Rows[0].Cells["boxes"].Value.ToString();
            }
            else
            {
                lblInsFob.Text = "-";
                lblInsSticker.Text = "-";
                lblInsSleeve.Text = "-";
                cheInsWtSleeve.Checked = false;
                cheInsMix.Checked = false;
                lblInsSisteOr.Text = "-";
                lblInsBoxes.Text = "-";
            }
        }
        private void dataGridViewFlMain_SelectionChanged(object sender, EventArgs e)
        {
            if (loaded)
            {
                fillUpInspectorFl();
            }
        }





        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                var mySql = new mySql();

                string Sql1 = " select distinct orders.order_number as 'Order number', departure as 'Departure', arrival as 'Arrival', datecode as 'Datecode' from orders";
                dataGridViewO1.DataSource = bindingSourceOrders;
                mySql.GetData(Sql1, bindingSourceOrders);
                mySql.updateOrderInspecor(dataGridViewO1, dataGridViewO2, bindingSourceOrders2, lblDateCreated, lblDateModified, lblAmountBuckets, lblAmountPrice, lblAmountStems, lblAmountBoxes);
                
                dataGridViewO1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewO2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                //dataGridViewO1.Rows[0].Selected = () ? false : true;
                setWidth(dataGridViewO1);
                loadOrders = true;
            }
        }

        private void tabPage6_Enter(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewO1_SelectionChanged(object sender, EventArgs e)
        {
            if (loadOrders)
            {
                var mySql = new mySql();
                mySql.updateOrderInspecor(dataGridViewO1, dataGridViewO2, bindingSourceOrders2, lblDateCreated, lblDateModified, lblAmountBuckets, lblAmountPrice, lblAmountStems, lblAmountBoxes);

            }
           
        }

        private void btnAvvik_Click(object sender, EventArgs e)
        {
            var frm = new Avvik(Convert.ToInt32(dataGridViewO1[0, dataGridViewO1.CurrentRow.Index].Value));
            frm.Show();
        }

        private void btnFarms_Click(object sender, EventArgs e)
        {
            var frm = new Farms(Convert.ToInt32(dataGridViewO1[0, dataGridViewO1.CurrentRow.Index].Value));
            frm.Show();
        }
    }
}
