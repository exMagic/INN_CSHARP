﻿using System;
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
    public partial class Avvik : Form
    {
        public int x;
        public Avvik(int orderNumber)
        {
            x = orderNumber;
            InitializeComponent();
        }

        private void Avvik_Load(object sender, EventArgs e)
        {
            lblOrderNumberTitle.Text = x.ToString();
            var mySql = new mySql();
            mySql.loadAvvik(x);
            dataGridViewTest.DataSource = bindingSourceOrders;
            mySql.GetData(mySql.loadAvvikStatement, bindingSourceOrders);
        }
    }
}
