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
    public partial class Ny : Form
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

        //string selectionStatement3 = @"
        //SELECT 
        //          flowers.fl_id
        //          ,flowers.variety
        //          ,flowers.colour
        //          ,flowers.plu
        //          ,farms.farm_id
        //        ,flowers.mix
        //        ,flowers.sticker_text
        //        ,flowers.length_id
        //        ,flowers.sleeve_type
        //        ,flowers.fob
        //        ,flowers.fairtrade
        //        ,flowers.bunch_pr_bucket
        //        ,flowers.stems_pr_bunch
        //        ,flowers.pak_rate
	  
        //  FROM [MG_inkjop].[dbo].[flowers], [MG_inkjop].[dbo].[farms], [MG_inkjop].[dbo].[lengths]
        //  WHERE flowers.farm_id = farms.farm_id and flowers.length_id = lengths.length_id ";
        public Ny()
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
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cheMix.Checked) mix = "1";
            if (cheFt.Checked) ft = "1";

            string add = @" INSERT INTO[MG_inkjop].[dbo].[flowers]

           ([variety]
           ,[colour]
           ,[plu]
           ,[farm_id]
           ,[mix]
           ,[sticker_text]
           ,[length_id]
           ,[sleeve_type]
           ,[fob]
           ,[fairtrade]
           ,[bunch_pr_bucket]
           ,[stems_pr_bunch]
           ,[pak_rate])
     VALUES
           ('" + txtEVariety.Text + "'" +
                ",'" + txtEColour.Text + "'" +
                ",'" + txtEPlu.Text + "'" +
                ",'" + selectedFarmId + "'" +
                ",'" + mix + "'" +
                ",'" + txtESticker.Text + "'" +
                ",'" + txtELength.Text + "'" +
                ",'" + txtESleeve.Text + "'" +
                ",'" + txtEFob.Text + "'" +
                ",'" + ft + "'" +
                ",'" + txtEBunchPBucket.Text + "'" +
                ",'" + txtEStems.Text + "'" +
                ",'" + txtEPak.Text + "')";


            GetData(add, bindingSource1);
            this.Close();

        }
        string select = @"SELECT * FROM [MG_inkjop].[dbo].[farms]";

        private void AddFl_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData(select, bindingSource1);

            string Sql = "SELECT farms.farm_name FROM[MG_inkjop].[dbo].[farms]";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                cbFarm.Items.Add(DR[0]);

            }
            cbFarm.SelectedIndex = 0;
            conn.Close();

        }
        private void cbFarm_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value.ToString() == cbFarm.SelectedItem.ToString())
                {
                    selectedFarmId = row.Cells[0].Value.ToString();
                    break;
                }
            }


            
        }

        private void txtEPlu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}
