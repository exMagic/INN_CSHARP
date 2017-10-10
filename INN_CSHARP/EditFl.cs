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
        //
        string connString = @"Data Source=DESKTOP-PC\SQLEXPRESS;Initial Catalog=MG_inkjop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        //
        /*/WINMAC
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
                ,flowers.sleeve_type
                ,flowers.fob
                ,flowers.fairtrade
                ,flowers.bunch_pr_bucket
                ,flowers.stems_pr_bunch
                ,flowers.pak_rate
	  
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

            
            int rowIndex = -1;
            
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
               // MessageBox.Show(row.Cells[0].Value.ToString());
                if (row.Cells[0].Value.ToString() == idToEdit2.ToString())
                {
                    rowIndex = row.Index;
                    break;
                }
            }

            txtEVariety.Text = dataGridView1[1, rowIndex].Value.ToString();
            txtEColour.Text = dataGridView1[2, rowIndex].Value.ToString();
            txtEPlu.Text = dataGridView1[3, rowIndex].Value.ToString();
            txtEFarm.Text = dataGridView1[4, rowIndex].Value.ToString();
            txtEMix.Text = dataGridView1[5, rowIndex].Value.ToString();
            txtESticker.Text = dataGridView1[6, rowIndex].Value.ToString();
            txtELength.Text = dataGridView1[7, rowIndex].Value.ToString();
            txtESleeve.Text = dataGridView1[9, rowIndex].Value.ToString();
            txtEFob.Text = dataGridView1[10, rowIndex].Value.ToString();
            txtEFaitrade.Text = dataGridView1[11, rowIndex].Value.ToString();
            txtEBunchPBucket.Text = dataGridView1[12, rowIndex].Value.ToString();
            txtEStems.Text = dataGridView1[13, rowIndex].Value.ToString();
            txtEPak.Text = dataGridView1[14, rowIndex].Value.ToString();
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string save = @" UPDATE[MG_inkjop].[dbo].[flowers]
                SET flowers.variety = '" + txtEVariety.Text + "'" +
                ", flowers.colour = '"+txtEColour.Text+"'" +
                ", flowers.plu = '" + txtEPlu.Text + "'" +
                ", flowers.farm_id = '" + txtEFarm.Text + "'" +
                ", flowers.mix = '" + txtEMix.Text + "'" +
                ", flowers.sticker_text = '" + txtESticker.Text + "'" +
                ", flowers.length_id = '" + txtELength.Text + "'" +
                ", flowers.sleeve_type = '" + txtESleeve.Text + "'" +
                ", flowers.fob = '" + txtEFob.Text + "'" +
                ", flowers.fairtrade = '" + txtEFaitrade.Text + "'" +
                ", flowers.bunch_pr_bucket = '" + txtEBunchPBucket.Text + "'" +
                ", flowers.stems_pr_bunch = '" + txtEStems.Text + "'" +
                ", flowers.pak_rate = '" + txtEPak.Text + "'" +

                "WHERE fl_id = " + label2.Text;
            string save2 = @" UPDATE[MG_inkjop].[dbo].[flowers]
                SET flowers.variety = '" + txtEVariety.Text + "'" +
                ", flowers.colour = '" + txtEColour.Text + "'" +
                ", flowers.plu = '" + txtEPlu.Text + "'" +
                ", flowers.farm_id = '" + txtEFarm.Text + "'" +
                ", flowers.mix = '" + txtEMix.Text + "'" +
                ", flowers.sticker_text = '" + txtESticker.Text + "'" +
                ", flowers.length_id = '" + txtELength.Text + "'" +
                ", flowers.sleeve_type = '" + txtESleeve.Text + "'" +
                ", flowers.fob = '" + txtEFob.Text + "'" +
                ", flowers.fairtrade = '" + txtEFaitrade.Text + "'" +
                ", flowers.bunch_pr_bucket = '" + txtEBunchPBucket.Text + "'" +
                ", flowers.stems_pr_bunch = '" + txtEStems.Text + "'" +
                ", flowers.pak_rate = '" + txtEPak.Text + "'" +

                "WHERE fl_id = " + label2.Text;

            GetData(save2, bindingSource1);
            this.Close();
        }
    }
}
