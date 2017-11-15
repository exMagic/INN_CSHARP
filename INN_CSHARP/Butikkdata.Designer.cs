namespace INN_CSHARP
{
    partial class Butikkdata
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Butikkdata));
            this.dataGridViewTest = new System.Windows.Forms.DataGridView();
            this.bindingSourceOrders = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTest2 = new System.Windows.Forms.DataGridView();
            this.btnButikkExport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAmountPrice = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblAmountBuckets = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblAmountStems = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblAmountBoxes = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDatecode = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblArrival = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnButikkSkriv = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lblOrdreNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTest2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTest.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTest.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridViewTest.Location = new System.Drawing.Point(9, 599);
            this.dataGridViewTest.Name = "dataGridViewTest";
            this.dataGridViewTest.ReadOnly = true;
            this.dataGridViewTest.RowHeadersVisible = false;
            this.dataGridViewTest.Size = new System.Drawing.Size(26, 23);
            this.dataGridViewTest.TabIndex = 2;
            this.dataGridViewTest.Visible = false;
            // 
            // bindingSourceOrders
            // 
            this.bindingSourceOrders.DataSource = typeof(INN_CSHARP.orders);
            // 
            // dataGridViewTest2
            // 
            this.dataGridViewTest2.AllowUserToAddRows = false;
            this.dataGridViewTest2.AllowUserToDeleteRows = false;
            this.dataGridViewTest2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTest2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTest2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataGridViewTest2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTest2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTest2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTest2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTest2.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridViewTest2.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTest2.Name = "dataGridViewTest2";
            this.dataGridViewTest2.ReadOnly = true;
            this.dataGridViewTest2.RowHeadersVisible = false;
            this.dataGridViewTest2.Size = new System.Drawing.Size(814, 610);
            this.dataGridViewTest2.TabIndex = 3;
            // 
            // btnButikkExport
            // 
            this.btnButikkExport.Location = new System.Drawing.Point(9, 232);
            this.btnButikkExport.Name = "btnButikkExport";
            this.btnButikkExport.Size = new System.Drawing.Size(92, 50);
            this.btnButikkExport.TabIndex = 4;
            this.btnButikkExport.Text = "Eksportere til Excel";
            this.btnButikkExport.UseVisualStyleBackColor = true;
            this.btnButikkExport.Click += new System.EventHandler(this.btnButikkExport_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewTest2);
            this.panel1.Location = new System.Drawing.Point(148, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 610);
            this.panel1.TabIndex = 5;
            // 
            // lblAmountPrice
            // 
            this.lblAmountPrice.AutoSize = true;
            this.lblAmountPrice.Location = new System.Drawing.Point(89, 145);
            this.lblAmountPrice.Name = "lblAmountPrice";
            this.lblAmountPrice.Size = new System.Drawing.Size(10, 13);
            this.lblAmountPrice.TabIndex = 48;
            this.lblAmountPrice.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "Antall price:";
            // 
            // lblAmountBuckets
            // 
            this.lblAmountBuckets.AutoSize = true;
            this.lblAmountBuckets.Location = new System.Drawing.Point(89, 119);
            this.lblAmountBuckets.Name = "lblAmountBuckets";
            this.lblAmountBuckets.Size = new System.Drawing.Size(10, 13);
            this.lblAmountBuckets.TabIndex = 46;
            this.lblAmountBuckets.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Antall buckets:";
            // 
            // lblAmountStems
            // 
            this.lblAmountStems.AutoSize = true;
            this.lblAmountStems.Location = new System.Drawing.Point(89, 173);
            this.lblAmountStems.Name = "lblAmountStems";
            this.lblAmountStems.Size = new System.Drawing.Size(10, 13);
            this.lblAmountStems.TabIndex = 44;
            this.lblAmountStems.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Antall stems:";
            // 
            // lblAmountBoxes
            // 
            this.lblAmountBoxes.AutoSize = true;
            this.lblAmountBoxes.Location = new System.Drawing.Point(89, 197);
            this.lblAmountBoxes.Name = "lblAmountBoxes";
            this.lblAmountBoxes.Size = new System.Drawing.Size(10, 13);
            this.lblAmountBoxes.TabIndex = 42;
            this.lblAmountBoxes.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Antall bokser:";
            // 
            // lblDatecode
            // 
            this.lblDatecode.AutoSize = true;
            this.lblDatecode.Location = new System.Drawing.Point(84, 77);
            this.lblDatecode.Name = "lblDatecode";
            this.lblDatecode.Size = new System.Drawing.Size(10, 13);
            this.lblDatecode.TabIndex = 40;
            this.lblDatecode.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Datecode:";
            // 
            // lblArrival
            // 
            this.lblArrival.AutoSize = true;
            this.lblArrival.Location = new System.Drawing.Point(84, 52);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(10, 13);
            this.lblArrival.TabIndex = 38;
            this.lblArrival.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Arrival:";
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Location = new System.Drawing.Point(84, 30);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(10, 13);
            this.lblDeparture.TabIndex = 36;
            this.lblDeparture.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Departure:";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Excel Files (*.xlsx)|*.xlsx";
            // 
            // btnButikkSkriv
            // 
            this.btnButikkSkriv.Location = new System.Drawing.Point(9, 297);
            this.btnButikkSkriv.Name = "btnButikkSkriv";
            this.btnButikkSkriv.Size = new System.Drawing.Size(92, 50);
            this.btnButikkSkriv.TabIndex = 49;
            this.btnButikkSkriv.Text = "Skriv ut";
            this.btnButikkSkriv.UseVisualStyleBackColor = true;
            this.btnButikkSkriv.Click += new System.EventHandler(this.btnButikkSkriv_Click);
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
            // lblOrdreNumber
            // 
            this.lblOrdreNumber.AutoSize = true;
            this.lblOrdreNumber.Location = new System.Drawing.Point(84, 12);
            this.lblOrdreNumber.Name = "lblOrdreNumber";
            this.lblOrdreNumber.Size = new System.Drawing.Size(10, 13);
            this.lblOrdreNumber.TabIndex = 51;
            this.lblOrdreNumber.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Ordre nummer:";
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(9, 561);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(79, 61);
            this.picLogo.TabIndex = 52;
            this.picLogo.TabStop = false;
            this.picLogo.Visible = false;
            // 
            // Butikkdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 634);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblOrdreNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnButikkSkriv);
            this.Controls.Add(this.lblAmountPrice);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblAmountBuckets);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblAmountStems);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblAmountBoxes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblDatecode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblArrival);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDeparture);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnButikkExport);
            this.Controls.Add(this.dataGridViewTest);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Butikkdata";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Butikkdata";
            this.Load += new System.EventHandler(this.Butikkdata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTest2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewTest;
        private System.Windows.Forms.BindingSource bindingSourceOrders;
        private System.Windows.Forms.DataGridView dataGridViewTest2;
        private System.Windows.Forms.Button btnButikkExport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAmountPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblAmountBuckets;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblAmountStems;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAmountBoxes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDatecode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblArrival;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnButikkSkriv;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label lblOrdreNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picLogo;
    }
}