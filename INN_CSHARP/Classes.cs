using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace INN_CSHARP
{
    public class mySql
    {
        SqlDataAdapter dataAdapter;
        System.Data.DataTable table;
        //PC
        public string connString = @"Data Source=DESKTOP-PC\SQLEXPRESS;Initial Catalog=MG_inkjop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        /*/WINMAC
        public string connString = @"Data Source=MACBOOKW10\SQLEXPRESS;Initial Catalog=MG_inkjop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //*/
        public void GetData(string selectCommand, BindingSource bin)
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



        public string FlowersMainStatement = @"
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
        public string loadFarmsStatement = @"SELECT farms.farm_id, farms.farm_name FROM [MG_inkjop].[dbo].[farms]";
        public string loadLengthsStatement = @"SELECT * FROM lengths";
        public string loadOrdersStatement;
        public void loadOrders(int orderNumber)
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
        //
        public string select = @"SELECT * FROM [MG_inkjop].[dbo].[farms]";
        public string selectLengths = @"SELECT * FROM [MG_inkjop].[dbo].[lengths]";
        public string selectColour = @"SELECT * FROM [MG_inkjop].[dbo].[colours]";
        public string selectSleeve = @"SELECT * FROM [MG_inkjop].[dbo].[sleeves]";



    }
    public class Design
    {
        public void colorBtn(Button b, TabControl t, int index)
        {
            Color _selected = System.Drawing.ColorTranslator.FromHtml("#353439");
            b.BackColor = _selected;
            t.SelectedIndex = index;
        }
    }
    public class CB
    {
        public string cbChange(ComboBox cb, string sqlStatement, Button b, DataGridView dg)
        {
            var mySql = new mySql();
            if (cb.SelectedIndex == 0)
            {
                sqlStatement = " ";
                b.Visible = false;
            }
            else
            {
                int selectedFarmId;
                foreach (DataGridViewRow row in dg.Rows)
                {
                    if (row.Cells[1].Value.ToString() == cb.SelectedItem.ToString())
                    {
                        selectedFarmId = Convert.ToInt32(row.Cells[0].Value);
                        sqlStatement = "and farms.farm_id=" + selectedFarmId.ToString();
                        break;
                    }
                }
                b.Visible = true;
            }
            return sqlStatement;

        }
    }


}
