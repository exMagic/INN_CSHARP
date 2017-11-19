namespace INN_CSHARP
{
    partial class Avvik
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Avvik));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnInspector = new System.Windows.Forms.Panel();
            this.PnInsFl = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PnInspectorSeparator1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOrdreNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblArrival = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDatecode = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAmountBoxes = new System.Windows.Forms.Label();
            this.PnInspectorBorder = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnButikkExport = new System.Windows.Forms.Button();
            this.btnButikkSkriv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrderNumberTitle = new System.Windows.Forms.Label();
            this.dataGridViewTest = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bindingSourceOrders = new System.Windows.Forms.BindingSource(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.PnInspector.SuspendLayout();
            this.PnInsFl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // PnInspector
            // 
            this.PnInspector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnInspector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.PnInspector.Controls.Add(this.PnInsFl);
            this.PnInspector.Controls.Add(this.PnInspectorBorder);
            this.PnInspector.Controls.Add(this.picLogo);
            this.PnInspector.Controls.Add(this.btnButikkExport);
            this.PnInspector.Controls.Add(this.btnButikkSkriv);
            this.PnInspector.Location = new System.Drawing.Point(998, -1);
            this.PnInspector.Name = "PnInspector";
            this.PnInspector.Size = new System.Drawing.Size(227, 694);
            this.PnInspector.TabIndex = 54;
            // 
            // PnInsFl
            // 
            this.PnInsFl.Controls.Add(this.panel2);
            this.PnInsFl.Controls.Add(this.PnInspectorSeparator1);
            this.PnInsFl.Controls.Add(this.label2);
            this.PnInsFl.Controls.Add(this.lblOrdreNumber);
            this.PnInsFl.Controls.Add(this.label3);
            this.PnInsFl.Controls.Add(this.lblDeparture);
            this.PnInsFl.Controls.Add(this.label7);
            this.PnInsFl.Controls.Add(this.lblArrival);
            this.PnInsFl.Controls.Add(this.label8);
            this.PnInsFl.Controls.Add(this.lblDatecode);
            this.PnInsFl.Controls.Add(this.label9);
            this.PnInsFl.Controls.Add(this.lblAmountBoxes);
            this.PnInsFl.Location = new System.Drawing.Point(17, 73);
            this.PnInsFl.Name = "PnInsFl";
            this.PnInsFl.Size = new System.Drawing.Size(198, 275);
            this.PnInsFl.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(11, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 1);
            this.panel2.TabIndex = 18;
            // 
            // PnInspectorSeparator1
            // 
            this.PnInspectorSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PnInspectorSeparator1.BackColor = System.Drawing.Color.LightGray;
            this.PnInspectorSeparator1.Location = new System.Drawing.Point(11, 8);
            this.PnInspectorSeparator1.Name = "PnInspectorSeparator1";
            this.PnInspectorSeparator1.Size = new System.Drawing.Size(180, 1);
            this.PnInspectorSeparator1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Ordre nummer:";
            // 
            // lblOrdreNumber
            // 
            this.lblOrdreNumber.AutoSize = true;
            this.lblOrdreNumber.Location = new System.Drawing.Point(101, 27);
            this.lblOrdreNumber.Name = "lblOrdreNumber";
            this.lblOrdreNumber.Size = new System.Drawing.Size(10, 13);
            this.lblOrdreNumber.TabIndex = 51;
            this.lblOrdreNumber.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Departure:";
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Location = new System.Drawing.Point(101, 53);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(10, 13);
            this.lblDeparture.TabIndex = 36;
            this.lblDeparture.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Arrival:";
            // 
            // lblArrival
            // 
            this.lblArrival.AutoSize = true;
            this.lblArrival.Location = new System.Drawing.Point(101, 79);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(10, 13);
            this.lblArrival.TabIndex = 38;
            this.lblArrival.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Datecode:";
            // 
            // lblDatecode
            // 
            this.lblDatecode.AutoSize = true;
            this.lblDatecode.Location = new System.Drawing.Point(101, 105);
            this.lblDatecode.Name = "lblDatecode";
            this.lblDatecode.Size = new System.Drawing.Size(10, 13);
            this.lblDatecode.TabIndex = 40;
            this.lblDatecode.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Antall bokser:";
            // 
            // lblAmountBoxes
            // 
            this.lblAmountBoxes.AutoSize = true;
            this.lblAmountBoxes.Location = new System.Drawing.Point(101, 158);
            this.lblAmountBoxes.Name = "lblAmountBoxes";
            this.lblAmountBoxes.Size = new System.Drawing.Size(10, 13);
            this.lblAmountBoxes.TabIndex = 42;
            this.lblAmountBoxes.Text = "-";
            // 
            // PnInspectorBorder
            // 
            this.PnInspectorBorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnInspectorBorder.BackColor = System.Drawing.Color.LightGray;
            this.PnInspectorBorder.Location = new System.Drawing.Point(0, 0);
            this.PnInspectorBorder.Name = "PnInspectorBorder";
            this.PnInspectorBorder.Size = new System.Drawing.Size(1, 696);
            this.PnInspectorBorder.TabIndex = 16;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(105, 529);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(23, 16);
            this.picLogo.TabIndex = 52;
            this.picLogo.TabStop = false;
            this.picLogo.Visible = false;
            // 
            // btnButikkExport
            // 
            this.btnButikkExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(112)))), ((int)(((byte)(68)))));
            this.btnButikkExport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnButikkExport.BackgroundImage")));
            this.btnButikkExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnButikkExport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnButikkExport.Location = new System.Drawing.Point(17, 354);
            this.btnButikkExport.Name = "btnButikkExport";
            this.btnButikkExport.Size = new System.Drawing.Size(198, 50);
            this.btnButikkExport.TabIndex = 4;
            this.btnButikkExport.Text = "Eksportere til Excel";
            this.btnButikkExport.UseVisualStyleBackColor = false;
            this.btnButikkExport.Click += new System.EventHandler(this.btnButikkExport_Click);
            // 
            // btnButikkSkriv
            // 
            this.btnButikkSkriv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(72)))), ((int)(((byte)(112)))));
            this.btnButikkSkriv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnButikkSkriv.BackgroundImage")));
            this.btnButikkSkriv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnButikkSkriv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnButikkSkriv.Location = new System.Drawing.Point(17, 410);
            this.btnButikkSkriv.Name = "btnButikkSkriv";
            this.btnButikkSkriv.Size = new System.Drawing.Size(198, 50);
            this.btnButikkSkriv.TabIndex = 49;
            this.btnButikkSkriv.Text = "Skriv ut";
            this.btnButikkSkriv.UseVisualStyleBackColor = false;
            this.btnButikkSkriv.Click += new System.EventHandler(this.btnButikkSkriv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 32);
            this.label1.TabIndex = 55;
            this.label1.Text = "Avviksskjema table - ordre nummer:";
            // 
            // lblOrderNumberTitle
            // 
            this.lblOrderNumberTitle.AutoSize = true;
            this.lblOrderNumberTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNumberTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.lblOrderNumberTitle.Location = new System.Drawing.Point(490, 33);
            this.lblOrderNumberTitle.Name = "lblOrderNumberTitle";
            this.lblOrderNumberTitle.Size = new System.Drawing.Size(24, 32);
            this.lblOrderNumberTitle.TabIndex = 56;
            this.lblOrderNumberTitle.Text = "-";
            // 
            // dataGridViewTest
            // 
            this.dataGridViewTest.AllowUserToAddRows = false;
            this.dataGridViewTest.AllowUserToDeleteRows = false;
            this.dataGridViewTest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTest.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTest.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataGridViewTest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTest.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTest.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridViewTest.Location = new System.Drawing.Point(26, 80);
            this.dataGridViewTest.Name = "dataGridViewTest";
            this.dataGridViewTest.ReadOnly = true;
            this.dataGridViewTest.RowHeadersVisible = false;
            this.dataGridViewTest.Size = new System.Drawing.Size(936, 552);
            this.dataGridViewTest.TabIndex = 57;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Excel Files (*.xlsx)|*.xlsx";
            // 
            // bindingSourceOrders
            // 
            this.bindingSourceOrders.DataSource = typeof(INN_CSHARP.orders);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Avvik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 671);
            this.Controls.Add(this.dataGridViewTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOrderNumberTitle);
            this.Controls.Add(this.PnInspector);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Avvik";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Avviksskjema";
            this.Load += new System.EventHandler(this.Avvik_Load);
            this.PnInspector.ResumeLayout(false);
            this.PnInsFl.ResumeLayout(false);
            this.PnInsFl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnInspector;
        private System.Windows.Forms.Panel PnInsFl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PnInspectorSeparator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOrdreNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblArrival;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDatecode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAmountBoxes;
        private System.Windows.Forms.Panel PnInspectorBorder;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnButikkExport;
        private System.Windows.Forms.Button btnButikkSkriv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOrderNumberTitle;
        private System.Windows.Forms.DataGridView dataGridViewTest;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.BindingSource bindingSourceOrders;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}