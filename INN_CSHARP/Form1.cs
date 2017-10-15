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

        string loadLengthsStatement = @"SELECT * FROM lengths";
        string loadOrdersStatement = @"
        SELECT
                orders.order_id
,orders.fl_id
,orders.order_nummer
,flowers.variety
,farms.farm_name
,orders.boxes
              
          FROM[MG_inkjop].[dbo].[flowers], [MG_inkjop].[dbo].[farms], [MG_inkjop].[dbo].[lengths], [MG_inkjop].[dbo].[colours], [MG_inkjop].[dbo].[sleeves], [MG_inkjop].[dbo].[orders]
          WHERE flowers.farm_id = farms.farm_id and flowers.length_id = lengths.length_id and flowers.colour_id = colours.colour_id and flowers.sleeve_id = sleeves.sleeve_id and flowers.fl_id = orders.fl_id ";

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
            //uncoment this...
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
            if (cbFarm.SelectedIndex == 0) whFarm = " ";
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
            }
            selectionStatement4 = selectionStatement3 + whFarm + whLen;
            GetData(selectionStatement4, bindingSource1);
            label2.Text = dataGridView1.RowCount.ToString();//count amount of rows
        }
        // LENGTH FILTER ///////////////////////////////////////////////////////////////
        private void cbLength_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLength.SelectedIndex == 0) whLen = " ";
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
            }
            selectionStatement4 = selectionStatement3 + whFarm + whLen;
            GetData(selectionStatement4, bindingSource1);
            label2.Text = dataGridView1.RowCount.ToString();//count amount of rows
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
        }
        // ADD ///////////////////////////////////////////////////////////////
        private void btnFAdd_Click(object sender, EventArgs e)
        {
            Ny frm = new Ny();
            frm.FormClosing += new FormClosingEventHandler(this.Add_FormClosing);
            frm.Show();
        }
        private void Add_FormClosing(object sender, FormClosingEventArgs e)
        {
            GetData(selectionStatement4, bindingSource1);
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

        private void tabPage6_Enter(object sender, EventArgs e)
        {
            dataGridViewO1.DataSource = bindingSourceOrders;
            GetData(loadOrdersStatement, bindingSourceOrders);
        }
    }
}
