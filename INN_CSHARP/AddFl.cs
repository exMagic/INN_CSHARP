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
        /*
        string connString = @"Data Source=DESKTOP-PC\SQLEXPRESS;Initial Catalog=MG_inkjop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        */
        //WINMAC
        string connString = @"Data Source=MACBOOKW10\SQLEXPRESS;Initial Catalog=MG_inkjop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //*/
        SqlDataAdapter dataAdapter;
        System.Data.DataTable table;

        string selectionStatement3 = @"
        SELECT 
                  flowers.fl_id
                  ,flowers.variety
                  ,flowers.colour
                  ,flowers.plu
                  ,farms.farm_id
                ,flowers.mix
                ,flowers.sticker_text
                ,flowers.length_id
                ,flowers.bucket_size
                ,flowers.sleeve_type
                ,flowers.fob
                ,flowers.fairtrade
                ,flowers.bunch_pr_bucket
                ,flowers.stems_pr_bunch
                ,flowers.pak_rate
	  
          FROM [MG_inkjop].[dbo].[flowers], [MG_inkjop].[dbo].[farms], [MG_inkjop].[dbo].[lengths]
          WHERE flowers.farm_id = farms.farm_id and flowers.length_id = lengths.length_id ";
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string add = @" INSERT INTO[MG_inkjop].[dbo].[flowers]

           ([variety]
           ,[colour]
           ,[plu]
           ,[farm_id]
           ,[mix]
           ,[sticker_text]
           ,[length_id]
           ,[bucket_size]
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
                ",'" + txtEFarm.Text + "'" +
                ",'" + txtEMix.Text + "'" +
                ",'" + txtESticker.Text + "'" +
                ",'" + txtELength.Text + "'" +
                ",'" + txtEBucket.Text + "'" +
                ",'" + txtESleeve.Text + "'" +
                ",'" + txtEFob.Text + "'" +
                ",'" + txtEFaitrade.Text + "'" +
                ",'" + txtEBunchPBucket.Text + "'" +
                ",'" + txtEStems.Text + "'" +
                ",'" + txtEPak.Text + "')";

            GetData(add, bindingSource1);
            this.Close();

        }
    }
}
