﻿using System;
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
        // PC
        //
        string connString = @"Data Source=DESKTOP-PC\SQLEXPRESS;Initial Catalog=MG_inkjop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //
        /*/WINMAC
        string connString = @"Data Source=MACBOOKW10\SQLEXPRESS;Initial Catalog=MG_inkjop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //*/
        SqlDataAdapter dataAdapter;
        System.Data.DataTable table;

        public string whFarm;
        public string whLen;
        public string selectionStatement4;
        string loadOrdersStatement;
        string loadLengthsStatement = @"SELECT * FROM lengths";
        void loadOrders(int orderNumber)
        {
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
            loadOrdersStatement = @"
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
          WHERE flowers.farm_id = farms.farm_id and flowers.length_id = lengths.length_id and flowers.colour_id = colours.colour_id and flowers.sleeve_id = sleeves.sleeve_id and flowers.fl_id = orders.fl_id and orders.order_number = " + orderNumber + "  ORDER BY farm_name, length";
        }
        

        string selectionStatement22 = @"
        SELECT 
        farms.farm_id, farms.farm_name  
        FROM [MG_inkjop].[dbo].[farms]
        ";
        string selectionStatement3 = @"
        SELECT 
                flowers.fl_id
              ,flowers.variety as 'Variety'
              ,flowers.sticker_text as 'Sticker text'
              ,colours.colour as 'Colour'
              ,flowers.plu as 'PLU'
              ,farms.farm_name as 'Farm'
              ,lengths.length as 'Lenght'
	          ,flowers.mix as 'MIX'
              ,sleeves.sleeve as 'Sleeve'
              ,flowers.fob as 'FOB'
              ,flowers.fairtrade as 'Fairtrade'
              ,flowers.bunch_pr_bucket as 'Bunch pr bucket'
              ,flowers.stems_pr_bunch as 'Stems pr bunch'
              ,flowers.pak_rate as 'pak rate'
          FROM [MG_inkjop].[dbo].[flowers], [MG_inkjop].[dbo].[farms], [MG_inkjop].[dbo].[lengths], [MG_inkjop].[dbo].[colours], [MG_inkjop].[dbo].[sleeves]
          WHERE flowers.farm_id = farms.farm_id and flowers.length_id = lengths.length_id and flowers.colour_id = colours.colour_id and flowers.sleeve_id = sleeves.sleeve_id ";

        public void resBtn()
        {
            Color _leftBG = System.Drawing.ColorTranslator.FromHtml("#3b3a3f");
            button1.BackColor = _leftBG;
            button2.BackColor = _leftBG;
            button3.BackColor = _leftBG;
            button4.BackColor = _leftBG;
        }
        public Form1()
        {
            InitializeComponent();
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
            resBtn();
            Color _leftBG = System.Drawing.ColorTranslator.FromHtml("#3b3a3f");
            pictureBox1.BackColor = _leftBG;
            Color _selected = System.Drawing.ColorTranslator.FromHtml("#353439");
            button1.BackColor = _selected;
            dataGridView3.DataSource = bindingSource3;
            GetData(loadLengthsStatement, bindingSource3);
            dataGridView2.DataSource = bindingSource2;
            GetData(selectionStatement22, bindingSource2);
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
        private void button1_Click(object sender, EventArgs e)
        {
            resBtn();
            Color _selected = System.Drawing.ColorTranslator.FromHtml("#353439");
            button1.BackColor = _selected;
            tabControl1.SelectedIndex = 0;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            resBtn();
            Color _selected = System.Drawing.ColorTranslator.FromHtml("#353439");
            button2.BackColor = _selected;
            tabControl1.SelectedIndex = 1;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            resBtn();
            Color _selected = System.Drawing.ColorTranslator.FromHtml("#353439");
            button3.BackColor = _selected;
            tabControl1.SelectedIndex = 2;

        }
        private void button4_Click(object sender, EventArgs e)
        {
            resBtn();
            Color _selected = System.Drawing.ColorTranslator.FromHtml("#353439");
            button4.BackColor = _selected;
            tabControl1.SelectedIndex = 3;
        }
        /////////////////////// END MENU  //////////////////////////////////////////////////////////////////////
        
        // FARM FILTER ///////////////////////////////////////////////////////////////
        private void cbFarm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFarm.SelectedIndex == 0)
            {
                whFarm = " ";
                btnRemoveFF.Visible = false;
            }
            else
            {
                int selectedFarmId;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells[1].Value.ToString() == cbFarm.SelectedItem.ToString())
                    {
                        selectedFarmId = Convert.ToInt32(row.Cells[0].Value);
                        whFarm = "and farms.farm_id=" + selectedFarmId.ToString();
                        break;
                    }
                }
                btnRemoveFF.Visible = true;
            }
            selectionStatement4 = selectionStatement3 + whFarm + whLen;
            GetData(selectionStatement4, bindingSource1);
            label2.Text = dataGridView1.RowCount.ToString();//count amount of rows
        }
        private void btnRemoveFF_Click(object sender, EventArgs e)
        {
            cbFarm.SelectedIndex = 0;
        }
        // LENGTH FILTER ///////////////////////////////////////////////////////////////
        private void cbLength_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLength.SelectedIndex == 0)
            {
                whLen = " ";
                btnRemoveFL.Visible = false;
            }
            else
            {
                int selectedLengthId;
                foreach (DataGridViewRow row in dataGridView3.Rows)
                {
                    if (row.Cells[1].Value.ToString() == cbLength.SelectedItem.ToString())
                    {
                        selectedLengthId = Convert.ToInt32(row.Cells[0].Value);
                        whLen = "and lengths.length_id=" + selectedLengthId.ToString();
                        break;
                    }
                }
                btnRemoveFL.Visible = true;
            }
            selectionStatement4 = selectionStatement3 + whFarm + whLen;
            GetData(selectionStatement4, bindingSource1);
            label2.Text = dataGridView1.RowCount.ToString();//count amount of rows
        }
        private void btnRemoveFL_Click(object sender, EventArgs e)
        {
            cbLength.SelectedIndex = 0;
        }
        // EDIT ///////////////////////////////////////////////////////////////
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
        // ADD ///////////////////////////////////////////////////////////////
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
        // DELETE ///////////////////////////////////////////////////////////////
        private void btnFDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete "+ dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString() + " flower from database? This Action can not be undone", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                //MessageBox.Show(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                var idToDelete = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                string delete = @"DELETE FROM [dbo].[flowers] WHERE fl_id=" + idToDelete;
                GetData(delete, bindingSource1);
            }
            GetData(selectionStatement4, bindingSource1);
        }
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
            loadOrders(Convert.ToInt32(cbOrders.SelectedItem));
            dataGridViewO1.DataSource = bindingSourceOrders;
            GetData(loadOrdersStatement, bindingSourceOrders);
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

            int sumB = 0;
            int sumS = 0;
            int sumBu = 0;
            for (int i = 0; i < dataGridViewO1.Rows.Count; ++i)
            {
                sumB += Convert.ToInt32(dataGridViewO1.Rows[i].Cells[9].Value);
                sumS += Convert.ToInt32(dataGridViewO1.Rows[i].Cells[10].Value);
                sumBu += Convert.ToInt32(dataGridViewO1.Rows[i].Cells[11].Value);
            }
            lblAmountBoxes.Text = sumB.ToString();
            lblAmountSteems.Text = sumS.ToString();
            lblAmountBuckets.Text = sumBu.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
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
