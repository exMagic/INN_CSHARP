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
        /* PC
        string connString = @"Data Source=DESKTOP-PC\SQLEXPRESS;Initial Catalog=MG_inkjop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        */
        string connString = @"Data Source=MACBOOKW10\SQLEXPRESS;Initial Catalog=MG_inkjop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlDataAdapter dataAdapter;
        System.Data.DataTable table;

        string farm_id;
        

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
	          ,flowers.mix
              ,flowers.lenght
              ,flowers.sleeve_type
              ,flowers.fob
              ,flowers.fairtrade
              ,flowers.stems_pr_bunch
	  
          FROM [MG_inkjop].[dbo].[flowers], [MG_inkjop].[dbo].[farms]
          WHERE flowers.farm_id = farms.farm_id and farms.farm_id=2";

        string selectionStatement = @"
        SELECT 
              flowers.variety
              ,flowers.colour
              ,flowers.plu
              ,farms.farm_name
	          ,flowers.mix
              ,flowers.lenght
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
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resBtn();
            Color _leftBG = System.Drawing.ColorTranslator.FromHtml("#3b3a3f");
            pictureBox1.BackColor = _leftBG;
            Color _selected = System.Drawing.ColorTranslator.FromHtml("#353439");
            button1.BackColor = _selected;



            dataGridView2.DataSource = bindingSource2;
            GetData(selectionStatement22, bindingSource2);

            dataGridView1.DataSource = bindingSource1;
            GetData(selectionStatement , bindingSource1);

            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;          
       
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            farm_id = dataGridView2[0,dataGridView2.CurrentCell.RowIndex].Value.ToString();
            int sid = Convert.ToInt16(farm_id);



            dataGridView1.DataSource = bindingSource1;
            GetData(selectionStatement3, bindingSource1);
        }
    }
}