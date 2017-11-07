using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INN_CSHARP
{
    public partial class Butikkdata : Form
    {
        public int x;
        public Butikkdata(int orderNumber)
        {
            x = orderNumber;
            InitializeComponent();
        }

        
        private void Butikkdata_Load(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mySql = new mySql();
            mySql.loadButikk(x);
            dataGridViewTest.DataSource = bindingSourceOrders;
            mySql.GetData(mySql.loadButikkStatement, bindingSourceOrders);
            for (int c = 0; c < dataGridViewTest.Columns.Count; ++c)
            {
                dataGridViewTest2.Columns.Add(dataGridViewTest.Columns[c].HeaderText, dataGridViewTest.Columns[c].HeaderText);
            }
            int Nindex = 0;
            for (int i = 0; i < dataGridViewTest.Rows.Count; i++)//each row
            {
                if (i < 1)
                {
                    dataGridViewTest2.Rows.Add();
                    for (int j = 0; j < dataGridViewTest.Columns.Count; ++j)//each cell in row
                    {
                        dataGridViewTest2.Rows[Nindex].Cells[j].Value = dataGridViewTest.Rows[i].Cells[j].Value;
                    }
                    Nindex++;
                    MessageBox.Show("Test");
                }
                else
                {
                    //MessageBox.Show(dataGridViewTest.Rows[i].Cells["plu"].Value.ToString() + " xx " + dataGridViewTest.Rows[i - 1].Cells["plu"].Value.ToString());
                    if (dataGridViewTest.Rows[i].Cells["plu"].Value.ToString() == dataGridViewTest.Rows[i - 1].Cells["plu"].Value.ToString() & dataGridViewTest.Rows[i].Cells["farm"].Value.ToString() == dataGridViewTest.Rows[i - 1].Cells["farm"].Value.ToString())//if above is the same
                    {
                        MessageBox.Show("dodaje " + Convert.ToInt32(dataGridViewTest2.Rows[Nindex - 1].Cells[10].Value) + " + " + Convert.ToInt32(dataGridViewTest.Rows[i].Cells[10].Value)+ " czyli "+ (Nindex - 1) + " i  "+ i);
                        dataGridViewTest2.Rows[Nindex - 1].Cells[10].Value = Convert.ToInt32(dataGridViewTest2.Rows[Nindex - 1].Cells[10].Value) + Convert.ToInt32(dataGridViewTest.Rows[i].Cells[10].Value);
                    }
                    else
                    {
                        dataGridViewTest2.Rows.Add();
                        for (int j = 0; j < dataGridViewTest.Columns.Count; ++j)//each cell in row
                        {
                            dataGridViewTest2.Rows[Nindex].Cells[j].Value = dataGridViewTest.Rows[i].Cells[j].Value;
                        }
                        Nindex++;
                    }
                }
            }
        }
    }
}
