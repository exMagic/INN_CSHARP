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
    public partial class EditFl : Form
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
                flowers.fl_id,
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


        public EditFl()
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


        private void EditFl_Load(object sender, EventArgs e)
        {
            int idToEdit2 = Form1.idToEdit;
            label2.Text = idToEdit2.ToString();
            dataGridView1.DataSource = bindingSource1;
            GetData(selectionStatement3, bindingSource1);
        }
    }
}
