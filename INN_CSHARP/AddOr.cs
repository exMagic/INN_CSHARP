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
        // PC
        //
        string connString = @"Data Source=DESKTOP-PC\SQLEXPRESS;Initial Catalog=MG_inkjop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        //
        /*WINMAC
        string connString = @"Data Source=MACBOOKW10\SQLEXPRESS;Initial Catalog=MG_inkjop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //*/
        SqlDataAdapter dataAdapter;
        System.Data.DataTable table;

       
        public AddOr()
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
        string CBselect;
        string All = "All";
        public string whFarm;
        public string whLen;
        public string whColour;
        public string whSleeve;

        public string whMix = "and flowers.mix=0";
        public string whFt = "and flowers.fairtrade=0";
        string selectedFarmId;
        string selectedLength;
        string selectedColour ="1";
        string selectedSleeve="1";

        private void btnAdd_Click(object sender, EventArgs e)
        {
        }

        string select =@"
        SELECT 
                flowers.fl_id
              ,flowers.variety as 'Variety'
              
              ,colours.colour as 'Colour'
              ,flowers.plu as 'PLU'
              ,farms.farm_name as 'Farm'
              ,lengths.length as 'Lenght'
	          ,flowers.mix as 'MIX'
              ,flowers.fairtrade as 'Fairtrade'
              ,flowers.stems_pr_bunch as 'Stems pr bunch'
              ,flowers.pak_rate as 'pak rate'
          FROM [MG_inkjop].[dbo].[flowers], [MG_inkjop].[dbo].[farms], [MG_inkjop].[dbo].[lengths], [MG_inkjop].[dbo].[colours], [MG_inkjop].[dbo].[sleeves]
          WHERE flowers.farm_id = farms.farm_id and flowers.length_id = lengths.length_id and flowers.colour_id = colours.colour_id and flowers.sleeve_id = sleeves.sleeve_id ";

        string selectFarms = @"SELECT * FROM [MG_inkjop].[dbo].[farms]";
        string selectLengths = @"SELECT * FROM [MG_inkjop].[dbo].[lengths]";
        string selectColour = @"SELECT * FROM [MG_inkjop].[dbo].[colours]";
        string selectSleeve = @"SELECT * FROM [MG_inkjop].[dbo].[sleeves]";
        string Sql;

        private void fillUpCb(ComboBox cb)
        {
            //fill up combo box by Farms
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            SqlDataReader DR = cmd.ExecuteReader();
            cb.Items.Add(All);
            while (DR.Read()) cb.Items.Add(DR[0]);
            cb.SelectedIndex = 0;
            conn.Close();
        }

        public string order_numer;
        public string datecode;
        public string departure;
        public string arrival;

        public static class Prompt
        {
            public static string ShowDialog(string text, string caption)
            {
                Form prompt = new Form()
                {
                    Width = 500,
                    Height = 150,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen
                };
                Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
                TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
                Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
            }
        }
        private void AddOr_Load(object sender, EventArgs e)
        {
            //string promptValue = Prompt.ShowDialog("Test", "123");
            CBselect = select + whFarm + whLen + whColour + whSleeve + whMix + whFt;
            dataGridViewOA.DataSource = bindingSource1;
            GetData(CBselect, bindingSource1);
            dataGridViewOA.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //fill up dataGridView by Farms
            dataGridView1.DataSource = bindingSource5;
            GetData(selectFarms, bindingSource5);
            //fill up dataGridView by Lengths
            dataGridView2.DataSource = bindingSource2;
            GetData(selectLengths, bindingSource2);
            ////fill up dataGridView by Colours
            dataGridView3.DataSource = bindingSource3;
            GetData(selectColour, bindingSource3);
            ////fill up dataGridView by Sleeves
            dataGridView4.DataSource = bindingSource4;
            GetData(selectSleeve, bindingSource4);


            //fill up combo boxes
            Sql = "SELECT farms.farm_name FROM[MG_inkjop].[dbo].[farms]";
            fillUpCb(cbFarm);
            Sql = "SELECT lengths.length FROM[MG_inkjop].[dbo].[lengths]";
            fillUpCb(cbLengths);
            Sql = "SELECT colours.colour FROM[MG_inkjop].[dbo].[colours]";
            fillUpCb(cbColour);
            Sql = "SELECT sleeves.sleeve FROM[MG_inkjop].[dbo].[sleeves]";
            fillUpCb(cbSleeve);
            dataGridViewOA.Columns[0].Visible = false;



        }
        string valueFromCb;
        private void findValueCb(DataGridView dgv, int col, ComboBox cb)
        {
            //foreach (DataGridViewRow row in dgv.Rows)
            //{
            //    if (row.Cells[col].Value.ToString() == cb.SelectedItem.ToString())
            //    {
            //        valueFromCb = row.Cells[0].Value.ToString();
            //        break;
            //    }
            //}
        }

        private void cbFarm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFarm.SelectedIndex == 0)
            {
                whFarm = " ";
                btnRemoveAOF.Visible = false;
            }
            else
            {
                int selectedFarmId;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[1].Value.ToString() == cbFarm.SelectedItem.ToString())
                    {
                        selectedFarmId = Convert.ToInt32(row.Cells[0].Value);
                        whFarm = "and farms.farm_id=" + selectedFarmId.ToString();
                        break;
                    }
                }
                btnRemoveAOF.Visible = true;
            }
            CBselect = select + whFarm + whLen + whColour + whSleeve + whMix + whFt;
            GetData(CBselect, bindingSource1);
        }
        private void cbLengths_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLengths.SelectedIndex == 0)
            {
                whLen = " ";
                btnRemoveAOL.Visible = false;

            }
            else
            {
                int selectedLengthId;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells[1].Value.ToString() == cbLengths.SelectedItem.ToString())
                    {
                        selectedLengthId = Convert.ToInt32(row.Cells[0].Value);
                        whLen = "and lengths.length_id=" + selectedLengthId.ToString();
                        break;
                    }
                }
                btnRemoveAOL.Visible = true;
            }
            CBselect = select + whFarm + whLen + whColour + whSleeve + whMix + whFt;
            GetData(CBselect, bindingSource1);
        }
        private void cbColour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbColour.SelectedIndex == 0)
            {
                whColour = " ";
                btnRemoveAOC.Visible = false;

            }
            else
            {
                int selectedColourId;
                foreach (DataGridViewRow row in dataGridView3.Rows)
                {
                    if (row.Cells[1].Value.ToString() == cbColour.SelectedItem.ToString())
                    {
                        selectedColourId = Convert.ToInt32(row.Cells[0].Value);
                        whColour = "and colours.colour_id=" + selectedColourId.ToString();
                        break;
                    }
                }
                btnRemoveAOC.Visible = true;
            }
            CBselect = select + whFarm + whLen + whColour + whSleeve + whMix + whFt;
            GetData(CBselect, bindingSource1);
        }
        private void cbSleeve_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSleeve.SelectedIndex == 0)
            {
                whSleeve = " ";
                btnRemoveAOS.Visible = false;

            }
            else
            {
                int selectedSleeveId;
                foreach (DataGridViewRow row in dataGridView4.Rows)
                {
                    if (row.Cells[1].Value.ToString() == cbSleeve.SelectedItem.ToString())
                    {
                        selectedSleeveId = Convert.ToInt32(row.Cells[0].Value);
                        whSleeve = "and sleeves.sleeve_id=" + selectedSleeveId.ToString();
                        break;
                    }
                }
                btnRemoveAOS.Visible = true;
            }
            CBselect = select + whFarm + whLen + whColour + whSleeve + whMix + whFt;
            GetData(CBselect, bindingSource1);
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox1.Visible = true;
            order_numer = txtOrderNumber.Text;
            datecode = txtDatecode.Text;
            departure = dateTimePickerDeparture.Text;
            arrival = dateTimePickerArrival.Text;

            lblOrderNumber.Text = order_numer;
            lblDatecode.Text = datecode;
            lblDeparture.Text = departure;
            lblArrival.Text = arrival;
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
        //TODO: some method to display mix and ft both value togheter
        private void cheMix_CheckedChanged(object sender, EventArgs e)
        {
            if (cheMix.Checked) whMix = "and flowers.mix=1";
            else whMix = "and flowers.mix=0";
            CBselect = select + whFarm + whLen + whColour + whSleeve + whMix + whFt;
            GetData(CBselect, bindingSource1);
        }

        private void cheFt_CheckedChanged(object sender, EventArgs e)
        {
            if (cheFt.Checked) whFt = "and flowers.fairtrade=1";
            else whFt = "and flowers.fairtrade=0";
            CBselect = select + whFarm + whLen + whColour + whSleeve + whMix + whFt;
            GetData(CBselect, bindingSource1);
        }
    }
}
