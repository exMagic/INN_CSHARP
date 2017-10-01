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
        /*
        string connString = @"Data Source=DESKTOP-PC\SQLEXPRESS;Initial Catalog=MG_inkjop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        */
        //WINMAC
        string connString = @"Data Source=MACBOOKW10\SQLEXPRESS;Initial Catalog=MG_inkjop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //*/
        SqlDataAdapter dataAdapter;
        System.Data.DataTable table;

        string farm_id;

        string loadLengths = @"SELECT * FROM lengths";

        string selectionStatement22 = @"
        SELECT 
        farms.farm_id, farms.farm_name  
        FROM [MG_inkjop].[dbo].[farms]
        ";

        string selectionStatement3 = @"
        SELECT 
              flowers.variety
              ,flowers.colour
              ,flowers.plu
              ,farms.farm_name
              ,lengths.length
	          ,flowers.mix
              ,flowers.sleeve_type
              ,flowers.fob
              ,flowers.fairtrade
              ,flowers.stems_pr_bunch
	  
          FROM [MG_inkjop].[dbo].[flowers], [MG_inkjop].[dbo].[farms], [MG_inkjop].[dbo].[lengths]
          WHERE flowers.farm_id = farms.farm_id and flowers.length_id = lengths.length_id ";



        string selectionStatement = @"
        SELECT 
              flowers.variety
              ,flowers.colour
              ,flowers.plu
              ,farms.farm_name
	          ,flowers.mix
              ,flowers.sleeve_type
              ,flowers.fob
              ,flowers.fairtrade
              ,flowers.stems_pr_bunch
	  
          FROM [MG_inkjop].[dbo].[flowers], [MG_inkjop].[dbo].[farms]
          WHERE flowers.farm_id = farms.farm_id
        ";



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
            GetData(loadLengths, bindingSource3);

            dataGridView2.DataSource = bindingSource2;
            GetData(selectionStatement22, bindingSource2);

            dataGridView1.DataSource = bindingSource1;
            GetData(selectionStatement , bindingSource1);

            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            //////////////// fil up comboBox
            string Sql = "SELECT farms.farm_name FROM[MG_inkjop].[dbo].[farms]";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                comboBox1.Items.Add(DR[0]);

            }
            comboBox1.SelectedIndex = 0;
            conn.Close();
            //////////////// fil up comboBox
            string Sql2 = "SELECT lengths.length FROM[MG_inkjop].[dbo].[lengths]";
            conn.Open();

            SqlCommand cmd2 = new SqlCommand(Sql2, conn);
            SqlDataReader DR2 = cmd2.ExecuteReader();

            while (DR2.Read())
            {
                comboBox2.Items.Add(DR2[0]);

            }
            comboBox2.SelectedIndex = 0;
            conn.Close();
        }

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



        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            farm_id = dataGridView2[0,dataGridView2.CurrentCell.RowIndex].Value.ToString();
            int sid = Convert.ToInt16(farm_id);

            var selectionStatement4 = selectionStatement3 + sid;


            dataGridView1.DataSource = bindingSource1;
            GetData(selectionStatement4, bindingSource1);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var farm_id2 = comboBox1.SelectedIndex;
            var farm_id3 = dataGridView2[0, farm_id2].Value.ToString();
            MessageBox.Show(farm_id3);
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string far = "and farms.farm_id=";
            var farm_id2 = comboBox1.SelectedIndex;
            farm_id = dataGridView2[0, farm_id2].Value.ToString();
            
            
            int sid = Convert.ToInt16(farm_id);
            //var farm_id3 = dataGridView2[0, farm_id2].Value.ToString();
            string selectionStatement4;
            if (sid == 1)
            {
                selectionStatement4 = selectionStatement3;
                dataGridView1.DataSource = bindingSource1;
                GetData(selectionStatement4, bindingSource1);
            }
            else
            {
                selectionStatement4 = selectionStatement3 + far + sid;
                dataGridView1.DataSource = bindingSource1;
                GetData(selectionStatement4, bindingSource1);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string far = "and lengths.length_id=";
            var farm_id2 = comboBox2.SelectedIndex;
            farm_id = dataGridView3[0, farm_id2].Value.ToString();


            int sid = Convert.ToInt16(farm_id);
            //var farm_id3 = dataGridView2[0, farm_id2].Value.ToString();
            string selectionStatement4;
            if (sid == 1)
            {
                selectionStatement4 = selectionStatement3;
                dataGridView1.DataSource = bindingSource1;
                GetData(selectionStatement4, bindingSource1);
            }
            else
            {
                selectionStatement4 = selectionStatement3 + far + sid;
                dataGridView1.DataSource = bindingSource1;
                GetData(selectionStatement4, bindingSource1);
            }
        }
    }
}
