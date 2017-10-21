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
    public partial class EditOr : Form
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

        string selectionStatement3 = @"
        SELECT *
          FROM [MG_inkjop].[dbo].[flowers], [MG_inkjop].[dbo].[farms], [MG_inkjop].[dbo].[lengths], [MG_inkjop].[dbo].[colours], [MG_inkjop].[dbo].[sleeves]
          WHERE flowers.farm_id = farms.farm_id and flowers.length_id = lengths.length_id and flowers.colour_id = colours.colour_id and flowers.sleeve_id = sleeves.sleeve_id  ";
        
        string selectLengths = @"SELECT * FROM [MG_inkjop].[dbo].[lengths]";
        string selectColours = @"SELECT * FROM [MG_inkjop].[dbo].[colours]";
        string selectFarms = @"SELECT * FROM [MG_inkjop].[dbo].[farms]";
        string selectSleeves = @"SELECT * FROM [MG_inkjop].[dbo].[sleeves]";

        string Sql;
        int rowIndex = -1;
        int fci;
        string newLengthId;
        string newColourId;
        string newFarmId;
        string newSleeveId;
        string newMix;
        string newFt;
        string fob;



        public EditOr()
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
        private void fillUpCb(ComboBox cb)
        {
            //fill up combo box by Farms
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read()) cb.Items.Add(DR[0]);
            cb.SelectedIndex = 0;
            conn.Close();
        }
        private void findCbIndex(ComboBox cb, int col)
        {
            int i=0;
            foreach (var item in cb.Items)
            {                
                if (item.ToString() == dataGridView1[col, rowIndex].Value.ToString())
                {
                    fci = i;
                    break;
                }
                i++;
            }
        }
        private void findComboValues()
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)// find new lengthID
            {
                if (row.Cells[1].Value.ToString() == cbLengths.SelectedItem.ToString())
                {
                    newLengthId = row.Cells[0].Value.ToString();
                    break;
                }
            }
            foreach (DataGridViewRow row in dataGridView3.Rows)// find new colourID
            {
                if (row.Cells[1].Value.ToString() == cbColour.SelectedItem.ToString())
                {
                    newColourId = row.Cells[0].Value.ToString();
                    break;
                }
            }
            foreach (DataGridViewRow row in dataGridView4.Rows)// find new farmId
            {
                if (row.Cells[1].Value.ToString() == cbFarm.SelectedItem.ToString())
                {
                    newFarmId = row.Cells[0].Value.ToString();
                    break;
                }
            }
            foreach (DataGridViewRow row in dataGridView5.Rows)// find new sleeveId
            {
                if (row.Cells[1].Value.ToString() == cbSleeve.SelectedItem.ToString())
                {
                    newSleeveId = row.Cells[0].Value.ToString();
                    break;
                }
            }
            if (cheFt.Checked) newFt = "1";
            else newFt = "0";
            if (cheMix.Checked) newMix = "1";
            else newMix = "0";
            //decimal f = Convert.ToDecimal(txtEFob.Text.Replace('.',','));
            //fob = f.ToString().Replace(',','.');
        }
        private void EditFl_Load(object sender, EventArgs e)
        {
            //dataGridView2.DataSource = bindingSource2;//fill up lengths table
            //GetData(selectLengths, bindingSource2);
            //dataGridView3.DataSource = bindingSource3;//fill up colours table
            //GetData(selectColours, bindingSource3);
            //dataGridView4.DataSource = bindingSource5;//fill up farms table
            //GetData(selectFarms, bindingSource5);
            //dataGridView5.DataSource = bindingSource4;//fill up sleeves table
            //GetData(selectSleeves, bindingSource4);

            ////fill up combo boxes
            //Sql = "SELECT farms.farm_name FROM[MG_inkjop].[dbo].[farms]";
            //fillUpCb(cbFarm);
            //Sql = "SELECT lengths.length FROM[MG_inkjop].[dbo].[lengths]";
            //fillUpCb(cbLengths);
            //Sql = "SELECT colours.colour FROM[MG_inkjop].[dbo].[colours]";
            //fillUpCb(cbColour);
            //Sql = "SELECT sleeves.sleeve FROM[MG_inkjop].[dbo].[sleeves]";
            //fillUpCb(cbSleeve);

            //int idToEdit2 = Form1.idToEdit;
            //label2.Text = idToEdit2.ToString();
            //dataGridView1.DataSource = bindingSource1;
            //GetData(selectionStatement3, bindingSource1);
            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
            //    //MessageBox.Show(row.Cells[0].Value.ToString());
            //    if (row.Cells[0].Value.ToString() == idToEdit2.ToString())
            //    {
            //        rowIndex = row.Index;
            //        break;
            //    }
            //}
            //findCbIndex(cbColour, 20);//check and set proper item in combobox
            //cbColour.SelectedIndex = fci;
            //findCbIndex(cbFarm, 15);//check and set proper item in combobox
            //cbFarm.SelectedIndex = fci;
            //findCbIndex(cbLengths, 18);//check and set proper item in combobox
            //cbLengths.SelectedIndex = fci;
            //findCbIndex(cbSleeve, 22);//check and set proper item in combobox
            //cbSleeve.SelectedIndex = fci;
            //txtEVariety.Text = dataGridView1[1, rowIndex].Value.ToString();
            //txtEPlu.Text = dataGridView1[3, rowIndex].Value.ToString();
            //txtESticker.Text = dataGridView1[6, rowIndex].Value.ToString();
            //txtEFob.Text = dataGridView1[9, rowIndex].Value.ToString();
            //txtEBunchPBucket.Text = dataGridView1[11, rowIndex].Value.ToString();
            //txtEStems.Text = dataGridView1[12, rowIndex].Value.ToString();
            //txtEPak.Text = dataGridView1[13, rowIndex].Value.ToString();
            //if (dataGridView1[5, rowIndex].Value.ToString() == "True") cheMix.Checked = true; // check and set "mix" checkbox
            //else cheMix.Checked = false;
            //if (dataGridView1[10, rowIndex].Value.ToString() == "True") cheFt.Checked = true; // check and set "fairtrade" checkbox
            //else cheFt.Checked = false;
        }
        private void button1_Click(object sender, EventArgs e)//save button
        {
            //findComboValues();
            
            //string save2 = @" UPDATE[MG_inkjop].[dbo].[flowers]
            //    SET flowers.variety = '" + txtEVariety.Text + "'" +
            //    ", flowers.colour_id = '" + newColourId + "'" +
            //    ", flowers.plu = '" + txtEPlu.Text + "'" +
            //    ", flowers.farm_id = '" + newFarmId + "'" +
            //    ", flowers.mix = '" + newMix + "'" +
            //    ", flowers.sticker_text = '" + txtESticker.Text + "'" +
            //    ", flowers.length_id = '" + newLengthId + "'" +
            //    ", flowers.sleeve_id = '" + newSleeveId + "'" +
            //    ", flowers.fob = '" + fob + "'" +
            //    ", flowers.fairtrade = '" + newFt + "'" +
            //    ", flowers.bunch_pr_bucket = '" + txtEBunchPBucket.Text + "'" +
            //    ", flowers.stems_pr_bunch = '" + txtEStems.Text + "'" +
            //    ", flowers.pak_rate = '" + txtEPak.Text + "'" +

            //    "WHERE fl_id = " + label2.Text;

            //GetData(save2, bindingSource1);
            //this.Close();
        }

    }
}
