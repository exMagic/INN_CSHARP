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
    public partial class AddFl : Form
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

       
        public AddFl()
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
        string mix;
        string ft;
        string selectedFarmId;
        string selectedLength;
        string selectedColour ="1";
        string selectedSleeve="1";

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cheMix.Checked) mix = "1";
            if (cheFt.Checked) ft = "1";

            string add = @" INSERT INTO[MG_inkjop].[dbo].[flowers]

           ([variety]
           ,[colour_id]
           ,[plu]
           ,[farm_id]
           ,[mix]
           ,[sticker_text]
           ,[length_id]
           ,[sleeve_id]
           ,[fob]
           ,[fairtrade]
           ,[bunch_pr_bucket]
           ,[stems_pr_bunch]
           ,[pak_rate])
     VALUES
           ('" + txtEVariety.Text + "'" +
                ",'" + selectedColour + "'" +
                ",'" + txtEPlu.Text + "'" +
                ",'" + selectedFarmId + "'" +
                ",'" + mix + "'" +
                ",'" + txtESticker.Text + "'" +
                ",'" + selectedLength + "'" +
                ",'" + selectedSleeve + "'" +
                ",'" + txtEFob.Text + "'" +
                ",'" + ft + "'" +
                ",'" + txtEBunchPBucket.Text + "'" +
                ",'" + txtEStems.Text + "'" +
                ",'" + txtEPak.Text + "')";

            GetData(add, bindingSource1);
            this.Close();
        }

        string select = @"SELECT * FROM [MG_inkjop].[dbo].[farms]";
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
            while (DR.Read()) cb.Items.Add(DR[0]);
            cb.SelectedIndex = 0;
            conn.Close();
        }
        private void AddFl_Load(object sender, EventArgs e)
        {
            //fill up dataGridView by Farms
            dataGridView1.DataSource = bindingSource1;
            GetData(select, bindingSource1);
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



        }
        string valueFromCb;
        private void findValueCb(DataGridView dgv, int col, ComboBox cb)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[col].Value.ToString() == cb.SelectedItem.ToString())
                {
                    valueFromCb = row.Cells[0].Value.ToString();
                    break;
                }
            }
        }

        private void cbFarm_SelectedIndexChanged(object sender, EventArgs e)
        {
            findValueCb(dataGridView1, 1, cbFarm);
            selectedFarmId = valueFromCb;
        }
        private void cbLengths_SelectedIndexChanged(object sender, EventArgs e)
        {
            findValueCb(dataGridView2, 1, cbLengths);
            selectedLength = valueFromCb;
        }
        private void cbColour_SelectedIndexChanged(object sender, EventArgs e)
        {
            findValueCb(dataGridView3, 1, cbColour);
            selectedColour = valueFromCb;
        }
        private void cbSleeve_SelectedIndexChanged(object sender, EventArgs e)
        {
            findValueCb(dataGridView4, 1, cbSleeve);
            selectedSleeve = valueFromCb;
        }

        private void txtEPlu_KeyPress(object sender, KeyPressEventArgs e)// allow only digit
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtEBunchPBucket_KeyPress(object sender, KeyPressEventArgs e)// allow only digit
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtEStems_KeyPress(object sender, KeyPressEventArgs e)// allow only digit
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtEPak_KeyPress(object sender, KeyPressEventArgs e)// allow only digit
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtEFob_KeyPress(object sender, KeyPressEventArgs e)// allow only decimal
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) e.Handled = true;
        }


    }
}
