﻿using System;
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
        /*///PC
        public string connString = @"Data Source=DESKTOP-PC\SQLEXPRESS;Initial Catalog=MG_inkjop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        /*WINMAC*/
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




        public string FlowersMainStatement = @";
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
                ,flowers.sleeve_with as 'With sleeves'
              ,flowers.fob as 'FOB'
              ,flowers.fairtrade as 'Fairtrade'
              ,flowers.bunch_pr_bucket as 'Bunch_pr bucket'
              ,flowers.stems_pr_bunch as 'Stems_pr bunch'
              ,flowers.pak_rate as 'pak rate'
          FROM [MG_inkjop].[dbo].[flowers], [MG_inkjop].[dbo].[farms], [MG_inkjop].[dbo].[lengths], [MG_inkjop].[dbo].[colours], [MG_inkjop].[dbo].[sleeves]
          WHERE flowers.farm_id = farms.farm_id and flowers.length_id = lengths.length_id and flowers.colour_id = colours.colour_id and flowers.sleeve_id = sleeves.sleeve_id ";
        public string loadFarmsStatement = @"SELECT farms.farm_id, farms.farm_name FROM [MG_inkjop].[dbo].[farms]";
        public string loadLengthsStatement = @"SELECT * FROM lengths";
        public string loadOrdersStatement;
        public string loadOrdersStatement2;
        public string loadButikkStatement;
        public string loadAvvikStatement;
        public string farmsLoadFarmsStatement;
        public string farmsLoadOneFarmStatement;

        public void loadOrders(int orderNumber)
        {

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
            ,flowers.fob as 'FOB'
            ,flowers.pak_rate as 'pak rate'
            ,(SELECT orders.boxes) * (SELECT flowers.pak_rate) * (SELECT flowers.fob) as price


            ,orders.boxes
            ,(SELECT orders.boxes) * (SELECT flowers.pak_rate) as stems

            , ((SELECT orders.boxes) * (SELECT flowers.pak_rate) / (SELECT flowers.stems_pr_bunch) / (SELECT flowers.bunch_pr_bucket))as buckets
          FROM[MG_inkjop].[dbo].[flowers], [MG_inkjop].[dbo].[farms], [MG_inkjop].[dbo].[lengths], [MG_inkjop].[dbo].[colours], [MG_inkjop].[dbo].[sleeves], [MG_inkjop].[dbo].[orders]
          WHERE flowers.farm_id = farms.farm_id and flowers.length_id = lengths.length_id and flowers.colour_id = colours.colour_id and flowers.sleeve_id = sleeves.sleeve_id and flowers.fl_id = orders.fl_id and orders.order_number = " + orderNumber + "  ORDER BY farm_name, length";
        }

        public void loadOrdersForFlowers(int fl_id)
        {
            
            loadOrdersStatement2 = @"
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
            ,flowers.fob as 'FOB'
            ,orders.boxes
            ,(SELECT orders.boxes) * (SELECT flowers.pak_rate) as stems
            ,(SELECT orders.boxes) * (SELECT flowers.pak_rate) * (SELECT flowers.fob) as price
            , ((SELECT orders.boxes) * (SELECT flowers.pak_rate) / (SELECT flowers.stems_pr_bunch) / (SELECT flowers.bunch_pr_bucket))as buckets
          FROM[MG_inkjop].[dbo].[flowers], [MG_inkjop].[dbo].[farms], [MG_inkjop].[dbo].[lengths], [MG_inkjop].[dbo].[colours], [MG_inkjop].[dbo].[sleeves], [MG_inkjop].[dbo].[orders]
          WHERE flowers.farm_id = farms.farm_id and flowers.length_id = lengths.length_id and flowers.colour_id = colours.colour_id and flowers.sleeve_id = sleeves.sleeve_id and flowers.fl_id = orders.fl_id and orders.fl_id = " + fl_id + "  ORDER BY farm_name, length";
        }

        public void loadButikk(int orderNumber)
        {
            loadButikkStatement = @"
        SELECT
            orders.order_number
            ,orders.departure
            ,orders.arrival
            ,orders.datecode
            ,flowers.variety as 'Variety'
            ,flowers.sticker_text as 'Sticker text'
            ,farms.farm_name as 'Farm'
            ,flowers.plu as 'PLU'
            ,lengths.length as 'Length'
            ,flowers.mix as 'MIX'
            ,sleeves.sleeve as 'Sleeve'
            ,flowers.sleeve_with as 'With sleeves'
            ,flowers.fairtrade as 'Fairtrade'
            ,flowers.bunch_pr_bucket as 'Bunch pr bucket'
              ,flowers.stems_pr_bunch as 'Stems pr bunch'

            ,(SELECT orders.boxes) * (SELECT flowers.pak_rate) as stems

            , ((SELECT orders.boxes) * (SELECT flowers.pak_rate) / (SELECT flowers.stems_pr_bunch) / (SELECT flowers.bunch_pr_bucket))as buckets

          FROM[MG_inkjop].[dbo].[flowers], [MG_inkjop].[dbo].[farms], [MG_inkjop].[dbo].[lengths], [MG_inkjop].[dbo].[colours], [MG_inkjop].[dbo].[sleeves], [MG_inkjop].[dbo].[orders]
          WHERE flowers.farm_id = farms.farm_id and flowers.length_id = lengths.length_id and flowers.colour_id = colours.colour_id and flowers.sleeve_id = sleeves.sleeve_id and flowers.fl_id = orders.fl_id and orders.order_number = " + orderNumber + "  ORDER BY length desc, sticker_text";
        }
        //            ,orders.boxes as 'Boxes'
        //,(SELECT orders.boxes) * (SELECT flowers.pak_rate) * (SELECT flowers.fob) as price
        public void loadAvvik(int orderNumber)
        {
            loadAvvikStatement = @"
        SELECT
            orders.order_number
            ,orders.departure
            ,orders.arrival
            ,orders.datecode

            ,farms.farm_name as 'Farm'
            ,flowers.variety as 'Variety'
            ,colours.colour as 'Colour'
            ,flowers.plu as 'PLU'
            ,lengths.length as 'Length'
            ,flowers.fairtrade as 'Fairtrade'
            ,flowers.sleeve_with as 'With sleeves'
            ,flowers.stems_pr_bunch as 'Stems pr bunch'
            ,flowers.bunch_pr_bucket as 'Bunch pr bucket'
            ,flowers.mix as 'MIX'
            ,flowers.pak_rate as 'Pak rate'
            ,orders.boxes as 'Boxes'


          FROM[MG_inkjop].[dbo].[flowers], [MG_inkjop].[dbo].[farms], [MG_inkjop].[dbo].[lengths], [MG_inkjop].[dbo].[colours], [MG_inkjop].[dbo].[sleeves], [MG_inkjop].[dbo].[orders]
          WHERE flowers.farm_id = farms.farm_id and flowers.length_id = lengths.length_id and flowers.colour_id = colours.colour_id and flowers.sleeve_id = sleeves.sleeve_id and flowers.fl_id = orders.fl_id and orders.order_number = " + orderNumber + "  ORDER BY  farm, length desc, variety";
        }

        public void loadOneFarm(int orderNumber, int farm_id)
        {
            farmsLoadOneFarmStatement = @"
        SELECT
            orders.order_number
            ,orders.departure
            ,orders.arrival
            ,orders.datecode

            ,farms.farm_name as 'Farm'
            ,flowers.variety as 'Variety'
			,lengths.length as 'Length'
            ,colours.colour as 'Colour'
            ,flowers.plu as 'PLU'
			,flowers.mix as 'MIX'
			,flowers.fairtrade as 'Fairtrade'
			,sleeves.sleeve as 'Sleeve'
            ,flowers.sleeve_with as 'With sleeves'
            ,(SELECT orders.boxes) * (SELECT flowers.pak_rate) * (SELECT flowers.fob) as price
            ,flowers.stems_pr_bunch as 'Stems_pr bunch'
            ,flowers.pak_rate as 'Pak rate'
            ,orders.boxes as 'Boxes'


          FROM[MG_inkjop].[dbo].[flowers], [MG_inkjop].[dbo].[farms], [MG_inkjop].[dbo].[lengths], [MG_inkjop].[dbo].[colours], [MG_inkjop].[dbo].[sleeves], [MG_inkjop].[dbo].[orders]
          WHERE flowers.farm_id = farms.farm_id and flowers.length_id = lengths.length_id and flowers.colour_id = colours.colour_id and flowers.sleeve_id = sleeves.sleeve_id and flowers.fl_id = orders.fl_id and orders.order_number = " + orderNumber +" and farms.farm_id = "+ farm_id +"  ORDER BY  length desc, variety";
        }

        public void loadFarms(int orderNumber)
        {
            farmsLoadFarmsStatement = @"
            SELECT distinct
            farm_name, farms.farm_id
            FROM [MG_inkjop].[dbo].[flowers], [MG_inkjop].[dbo].[farms], [MG_inkjop].[dbo].[orders]
            WHERE flowers.farm_id = farms.farm_id and flowers.fl_id = orders.fl_id and orders.order_number = " + orderNumber;
        }

        public void updateOrderInspecor(DataGridView t1, DataGridView t2,BindingSource bs, Label l1, Label l2, Label l3, Label l4, Label l5, Label l6)
        {
            string orderNumber = t1.Rows[t1.CurrentRow.Index].Cells[0].Value.ToString();
            string Sql2 = @"
        SELECT
            orders.order_number
,orders.date_created
,orders.date_modified
            
            ,orders.boxes as 'Boxes'
            ,(SELECT orders.boxes) * (SELECT flowers.pak_rate) as stems
        ,(SELECT orders.boxes) * (SELECT flowers.pak_rate) * (SELECT flowers.fob) as price
            , ((SELECT orders.boxes) * (SELECT flowers.pak_rate) / (SELECT flowers.stems_pr_bunch) / (SELECT flowers.bunch_pr_bucket))as buckets

          FROM[MG_inkjop].[dbo].[flowers], [MG_inkjop].[dbo].[farms], [MG_inkjop].[dbo].[lengths], [MG_inkjop].[dbo].[colours], [MG_inkjop].[dbo].[sleeves], [MG_inkjop].[dbo].[orders]
          WHERE flowers.farm_id = farms.farm_id and flowers.length_id = lengths.length_id and flowers.colour_id = colours.colour_id and flowers.sleeve_id = sleeves.sleeve_id and flowers.fl_id = orders.fl_id and orders.order_number = " + orderNumber + "  ORDER BY plu, length";
            t2.DataSource = bs;
            GetData(Sql2, bs);

            int sumBoxes = 0;
            int sumStems = 0;
            int sumBucket = 0;
            decimal sumPrice = 0;
            for (int i = 0; i < t2.Rows.Count; ++i)
            {
                sumBoxes += Convert.ToInt32(t2.Rows[i].Cells["boxes"].Value);
                sumStems += Convert.ToInt32(t2.Rows[i].Cells["stems"].Value);
                sumBucket += Convert.ToInt32(t2.Rows[i].Cells["buckets"].Value);
                sumPrice += Convert.ToDecimal(t2.Rows[i].Cells["price"].Value);
            }


            l1.Text = t2.Rows[0].Cells["date_created"].Value.ToString();
            l2.Text = t2.Rows[0].Cells["date_modified"].Value.ToString();
            l3.Text = sumBucket.ToString();
            l4.Text = sumPrice.ToString();
            l5.Text = sumStems.ToString();
            l6.Text = sumBoxes.ToString();

        }
        //
        public string select = @"SELECT * FROM [MG_inkjop].[dbo].[farms]";
        public string selectLengths = @"SELECT * FROM [MG_inkjop].[dbo].[lengths]";
        public string selectColour = @"SELECT * FROM [MG_inkjop].[dbo].[colours]";
        public string selectSleeve = @"SELECT * FROM [MG_inkjop].[dbo].[sleeves]";

        //AddOr
        public string selectFlAddOr = @"
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
        public string selectFarms = @"SELECT * FROM [MG_inkjop].[dbo].[farms]";

        //string All = "All";
        //string Sql;

        public void fillUpCb(ComboBox cb, string sql)
        {
            //fill up combo box by Farms
            //var mySql = new mySql();
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader DR = cmd.ExecuteReader();
            cb.Items.Add("All");
            while (DR.Read()) cb.Items.Add(DR[0]);
            cb.SelectedIndex = 0;
            conn.Close();
        }
        public void fillupLabelsButikk(Label a0, Label a1, Label a2, Label a3, Label a4, Label a5, DataGridView dg)
        {
            a0.Text = dg.Rows[0].Cells[0].Value.ToString();
            a1.Text = dg.Rows[0].Cells[1].Value.ToString().Substring(0, 10);
            a2.Text = dg.Rows[0].Cells[2].Value.ToString().Substring(0, 10);
            a3.Text = dg.Rows[0].Cells[3].Value.ToString();

            int sumStems = 0;
            int sumBucket = 0;
            for (int i = 0; i < dg.Rows.Count; ++i)
            {
                sumStems += Convert.ToInt32(dg.Rows[i].Cells["stems"].Value);
                sumBucket += Convert.ToInt32(dg.Rows[i].Cells["buckets"].Value);
            }
            a4.Text = sumStems.ToString();
            a5.Text = sumBucket.ToString();
        }
        public void fillupLabelsAvvik(Label a0, Label a1, Label a2, Label a3, Label a4, DataGridView dg)
        {
            a0.Text = dg.Rows[0].Cells[0].Value.ToString();
            a1.Text = dg.Rows[0].Cells[1].Value.ToString().Substring(0, 10);
            a2.Text = dg.Rows[0].Cells[2].Value.ToString().Substring(0, 10);
            a3.Text = dg.Rows[0].Cells[3].Value.ToString();
            int sumBoxes = 0;
            for (int i = 0; i < dg.Rows.Count; ++i)
            {
                sumBoxes += Convert.ToInt32(dg.Rows[i].Cells["boxes"].Value);
            }
            a4.Text = sumBoxes.ToString();
        }

        public string findCbValue(ComboBox cb, string wh, Button bt, DataGridView dgv, string sqlCondition, TextBox t)
        {
            t.Text = "";
            if (cb.SelectedIndex == 0)
            {
                wh = " ";
                bt.Visible = false;
            }
            else
            {
                int selectedId;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Cells[1].Value.ToString() == cb.SelectedItem.ToString())
                    {
                        selectedId = Convert.ToInt32(row.Cells[0].Value);
                        wh = sqlCondition + selectedId.ToString();
                        break;
                    }
                }
                bt.Visible = true;
            }
            return wh;
        }
        public void updateAntall(Label l, DataGridView dg)
        {
            l.Text = dg.RowCount.ToString();
        }
        public string sumColumn(DataGridView dg, string col)
        {
            int sum = 0;
                        for (int i = 0; i < dg.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dg.Rows[i].Cells[col].Value);
            }
            string sumString = sum.ToString();
            return sumString;
        }

    }
    public class Design
    {
        public void colorBtn(Button b, TabControl t, int index, PictureBox p)
        {
            Color _selected = System.Drawing.ColorTranslator.FromHtml("#243240");
            b.BackColor = _selected;
            t.SelectedIndex = index;
            p.Visible = true;
        }
        public void resBtn(Button b1, Button b2, Button b3, Button b4, PictureBox p1, PictureBox p2, PictureBox p3, PictureBox p4)
        {
            Color _leftBG = System.Drawing.ColorTranslator.FromHtml("#2c3e50");
            b1.BackColor = _leftBG;
            b2.BackColor = _leftBG;
            b3.BackColor = _leftBG;
            b4.BackColor = _leftBG;
            p1.Visible = false;
            p2.Visible = false;
            p3.Visible = false;
            p4.Visible = false;
        }
    }
    public class CB
    {
        public string cbChange(ComboBox cb, string sqlStatement, Button b, DataGridView dg, string table)
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
                        sqlStatement = table + selectedFarmId.ToString();
                        break;
                    }
                }
                b.Visible = true;
            }
            return sqlStatement;

        }
    }
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 250,
                Height = 300,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 25, Top = 40, Text = text };
            textLabel.AutoSize = true;
            textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TextBox textBox = new TextBox() { Left = 20, Top = 100, Width = 200 };
            textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(textBox_KeyPress);
            void textBox_KeyPress(object sender, KeyPressEventArgs e)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox.TextAlign = HorizontalAlignment.Center;
            Button confirmation = new Button() { Text = "Legg til", Left = 60, Width = 120, Height = 80, Top = 150, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }


}
