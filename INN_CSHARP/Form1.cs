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
    
    public partial class Form1 : Form
    {

        SqlDataAdapter dataAdapter;
        System.Data.DataTable table;
        public string connString;
        public string whFarm;
        public string whLen;
        public string selectionStatement4;

        public Form1()
        {
            InitializeComponent();
            mySql mySql2 = new mySql();
            connString = mySql2.connString;

        }
        private void GetData(string selectCommand, BindingSource bin)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand, connString);
                table = new System.Data.DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);

                bin.DataSource = table;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {
            var mySql = new mySql();
            resBtn();
            Color _leftBG = System.Drawing.ColorTranslator.FromHtml("#3b3a3f");
            pictureBox1.BackColor = _leftBG;
            Color _selected = System.Drawing.ColorTranslator.FromHtml("#353439");
            button1.BackColor = _selected;
            dataGridViewFL.DataSource = bindingSource3;
            GetData(mySql.loadLengthsStatement, bindingSource3);
            dataGridViewFF.DataSource = bindingSourceFarms;
            GetData(mySql.loadFarmsStatement, bindingSourceFarms);
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Columns[0].Visible = false;
            //GetData(selectionStatement, bindingSource1);
            tabControl1.Appearance = TabAppearance.Buttons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            //////////////// fil up comboBox
            string Sql = "SELECT farms.farm_name FROM[MG_inkjop].[dbo].[farms]";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            SqlDataReader DR = cmd.ExecuteReader();
            string All = "All";
            cbFarm.Items.Add(All);
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
            cbLength.Items.Add(All);
            while (DR2.Read())
            {
                cbLength.Items.Add(DR2[0]);
            }
            cbLength.SelectedIndex = 0;
            conn.Close();
            label2.Text = dataGridView1.RowCount.ToString();//count amount of rows
        }
        ///////////////////////  MENU  //////////////////////////////////////////////////////////////////////
        public void resBtn()
        {
            Color _leftBG = System.Drawing.ColorTranslator.FromHtml("#3b3a3f");
            button1.BackColor = _leftBG;
            button2.BackColor = _leftBG;
            button3.BackColor = _leftBG;
            button4.BackColor = _leftBG;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            resBtn();
            var menu = new Design();
            menu.colorBtn(button1, tabControl1, 0);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            resBtn();
            var menu = new Design();
            menu.colorBtn(button2, tabControl1, 1);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            resBtn();
            var menu = new Design();
            menu.colorBtn(button3, tabControl1, 2);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            resBtn();
            var menu = new Design();
            menu.colorBtn(button4, tabControl1, 3);
        }
        /////////////////////// END MENU  //////////////////////////////////////////////////////////////////////

        // Flowers - FARM FILTER ///////////
        private void cbFarm_SelectedIndexChanged(object sender, EventArgs e)// FARM FILTER ///////////
        {
            var CB = new CB();
            whFarm = CB.cbChange(cbFarm, whFarm, btnRemoveFF, dataGridViewFF);
            var mySql = new mySql();
            selectionStatement4 = mySql.FlowersMainStatement + whFarm + whLen;
            GetData(selectionStatement4, bindingSource1);
            label2.Text = dataGridView1.RowCount.ToString();//count amount of rows
        }
        private void btnRemoveFF_Click(object sender, EventArgs e) { cbFarm.SelectedIndex = 0; }
        // Flowers - LENGTH FILTER ///////////
        private void cbLength_SelectedIndexChanged(object sender, EventArgs e) // LENGTH FILTER ///////////
        {
            var CB = new CB();
            whLen = CB.cbChange(cbLength, whLen, btnRemoveFL, dataGridViewFL);
            var mySql = new mySql();
            selectionStatement4 = mySql.FlowersMainStatement + whFarm + whLen;
            GetData(selectionStatement4, bindingSource1);
            label2.Text = dataGridView1.RowCount.ToString();//count amount of rows
        }
        private void btnRemoveFL_Click(object sender, EventArgs e) { cbLength.SelectedIndex = 0; }
        
        // EDIT Flower///////////////////////////////////////////////////////////////
        public static int idToEdit;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idToEdit = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            EditFl frm = new EditFl();
            frm.FormClosing += new FormClosingEventHandler(this.Edit_FormClosing);
            frm.Show();
        }
        private void btnFEdit_Click(object sender, EventArgs e)
        {
            idToEdit = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
            EditFl frm = new EditFl();
            frm.FormClosing += new FormClosingEventHandler(this.Edit_FormClosing);
            frm.Show();
        }
        private void Edit_FormClosing(object sender, FormClosingEventArgs e)
        {
            GetData(selectionStatement4, bindingSource1);
            label2.Text = dataGridView1.RowCount.ToString();//count amount of rows
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
            GetData(selectionStatement4, bindingSource1);
            label2.Text = dataGridView1.RowCount.ToString();//count amount of rows
        }
        // DELETE Flower///////////////////////////////////////////////////////////////
        private void btnFDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete "+ dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString() + " flower from database? This Action can not be undone", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                var idToDelete = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                string delete = @"DELETE FROM [dbo].[flowers] WHERE fl_id=" + idToDelete;
                GetData(delete, bindingSource1);
            }
            GetData(selectionStatement4, bindingSource1);
        }
        /// <summary>
        /// -------------------------------------------------- ORDERS---------------------------------
        /// </summary>
        void updateCbOrders()
        {
            cbOrders.Items.Clear();
            string Sql = "select order_number from [MG_inkjop].[dbo].[orders] group by order_number";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                cbOrders.Items.Add(DR[0]);
            }
            conn.Close();
        }
        private void tabPage6_Enter(object sender, EventArgs e)
        {
            updateCbOrders();
        }


        private void cbOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mySql = new mySql();
            mySql.loadOrders(Convert.ToInt32(cbOrders.SelectedItem));
            dataGridViewO1.DataSource = bindingSourceOrders;
            GetData(mySql.loadOrdersStatement, bindingSourceOrders);
            dataGridViewO1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            /*
             * order_id 0
             * departure 1
             * arrival 2
             * datecode 3
             * variety 4
             * farm_name 5
             * plu 6
             * length 7
             * pak_rate 8
             * boxes 9
             * steems 10
             * buckets 11
            */
            dataGridViewO1.Columns[0].Visible = false; //order_id
            dataGridViewO1.Columns[1].Visible = false; //departure
            dataGridViewO1.Columns[2].Visible = false; //arrival
            dataGridViewO1.Columns[3].Visible = false; //datecode
            dataGridViewO1.Columns[4].DisplayIndex = 5; //variety
            dataGridViewO1.Columns[5].DisplayIndex = 4; //farm_name
            dataGridViewO1.Columns[6].DisplayIndex = 6; //plu
            dataGridViewO1.Columns[7].DisplayIndex = 7; //length
            dataGridViewO1.Columns[8].DisplayIndex = 8; //pak_rate
            dataGridViewO1.Columns[9].DisplayIndex = 9; //boxes
            dataGridViewO1.Columns[10].DisplayIndex = 10; //steems
            dataGridViewO1.Columns[11].DisplayIndex = 11; //buckets

            lblDeparture.Text = dataGridViewO1.Rows[0].Cells[1].Value.ToString();
            lblArrival.Text = dataGridViewO1.Rows[0].Cells[2].Value.ToString();
            lblDatecode.Text = dataGridViewO1.Rows[0].Cells[3].Value.ToString();

            int sumBoxes = 0;
            int sumSteems = 0;
            int sumBucket = 0;
            for (int i = 0; i < dataGridViewO1.Rows.Count; ++i)
            {
                sumBoxes += Convert.ToInt32(dataGridViewO1.Rows[i].Cells[9].Value);
                sumSteems += Convert.ToInt32(dataGridViewO1.Rows[i].Cells[10].Value);
                sumBucket += Convert.ToInt32(dataGridViewO1.Rows[i].Cells[11].Value);
            }
            lblAmountBoxes.Text = sumBoxes.ToString();
            lblAmountSteems.Text = sumSteems.ToString();
            lblAmountBuckets.Text = sumBucket.ToString();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            AddOr frm = new AddOr();
            frm.FormClosing += new FormClosingEventHandler(this.AddOr_FormClosing);
            frm.Show();
        }
        private void AddOr_FormClosing(object sender, FormClosingEventArgs e)
        {
            updateCbOrders();
        }


    }
}
