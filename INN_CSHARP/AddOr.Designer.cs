namespace INN_CSHARP
{
    partial class AddOr
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOr));
            this.btnAdd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFarm = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cheMix = new System.Windows.Forms.CheckBox();
            this.cheFt = new System.Windows.Forms.CheckBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cbLengths = new System.Windows.Forms.ComboBox();
            this.cbSleeve = new System.Windows.Forms.ComboBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.cbColour = new System.Windows.Forms.ComboBox();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewOA = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoveAOS = new System.Windows.Forms.Button();
            this.btnRemoveAOL = new System.Windows.Forms.Button();
            this.btnRemoveAOC = new System.Windows.Forms.Button();
            this.btnRemoveAOF = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerArrival = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDeparture = new System.Windows.Forms.DateTimePicker();
            this.btnLagOrdre = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDatecode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblArrival = new System.Windows.Forms.Label();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.lblDatecode = new System.Windows.Forms.Label();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOA)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(42, 547);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(278, 39);
            this.btnAdd.TabIndex = 54;
            this.btnAdd.Text = "Add Flower to Order >>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "sleeve type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Length (cm):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Farm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Colour:";
            // 
            // cbFarm
            // 
            this.cbFarm.FormattingEnabled = true;
            this.cbFarm.Location = new System.Drawing.Point(253, 46);
            this.cbFarm.Name = "cbFarm";
            this.cbFarm.Size = new System.Drawing.Size(100, 21);
            this.cbFarm.TabIndex = 46;
            this.cbFarm.SelectedIndexChanged += new System.EventHandler(this.cbFarm_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(16, 27);
            this.dataGridView1.TabIndex = 62;
            this.dataGridView1.Visible = false;
            // 
            // cheMix
            // 
            this.cheMix.AutoSize = true;
            this.cheMix.Location = new System.Drawing.Point(172, 130);
            this.cheMix.Name = "cheMix";
            this.cheMix.Size = new System.Drawing.Size(42, 17);
            this.cheMix.TabIndex = 49;
            this.cheMix.Text = "Mix";
            this.cheMix.UseVisualStyleBackColor = true;
            this.cheMix.CheckedChanged += new System.EventHandler(this.cheMix_CheckedChanged);
            // 
            // cheFt
            // 
            this.cheFt.AutoSize = true;
            this.cheFt.Location = new System.Drawing.Point(253, 130);
            this.cheFt.Name = "cheFt";
            this.cheFt.Size = new System.Drawing.Size(67, 17);
            this.cheFt.TabIndex = 50;
            this.cheFt.Text = "Fairtrade";
            this.cheFt.UseVisualStyleBackColor = true;
            this.cheFt.CheckedChanged += new System.EventHandler(this.cheFt_CheckedChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(64, 120);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(17, 27);
            this.dataGridView2.TabIndex = 66;
            this.dataGridView2.Visible = false;
            // 
            // cbLengths
            // 
            this.cbLengths.FormattingEnabled = true;
            this.cbLengths.Location = new System.Drawing.Point(15, 46);
            this.cbLengths.Name = "cbLengths";
            this.cbLengths.Size = new System.Drawing.Size(66, 21);
            this.cbLengths.TabIndex = 44;
            this.cbLengths.SelectedIndexChanged += new System.EventHandler(this.cbLengths_SelectedIndexChanged);
            // 
            // cbSleeve
            // 
            this.cbSleeve.FormattingEnabled = true;
            this.cbSleeve.Location = new System.Drawing.Point(15, 86);
            this.cbSleeve.Name = "cbSleeve";
            this.cbSleeve.Size = new System.Drawing.Size(338, 21);
            this.cbSleeve.TabIndex = 47;
            this.cbSleeve.SelectedIndexChanged += new System.EventHandler(this.cbSleeve_SelectedIndexChanged);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(92, 120);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(23, 23);
            this.dataGridView3.TabIndex = 69;
            this.dataGridView3.Visible = false;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(121, 120);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(23, 10);
            this.dataGridView4.TabIndex = 70;
            this.dataGridView4.Visible = false;
            // 
            // cbColour
            // 
            this.cbColour.FormattingEnabled = true;
            this.cbColour.Location = new System.Drawing.Point(114, 46);
            this.cbColour.Name = "cbColour";
            this.cbColour.Size = new System.Drawing.Size(100, 21);
            this.cbColour.TabIndex = 45;
            this.cbColour.SelectedIndexChanged += new System.EventHandler(this.cbColour_SelectedIndexChanged);
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSource = typeof(INN_CSHARP.lengths);
            // 
            // bindingSource3
            // 
            this.bindingSource3.DataSource = typeof(INN_CSHARP.colour);
            // 
            // bindingSource4
            // 
            this.bindingSource4.DataSource = typeof(INN_CSHARP.sleeve);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(INN_CSHARP.flower);
            // 
            // dataGridViewOA
            // 
            this.dataGridViewOA.AllowUserToAddRows = false;
            this.dataGridViewOA.AllowUserToDeleteRows = false;
            this.dataGridViewOA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewOA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewOA.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataGridViewOA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewOA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOA.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOA.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridViewOA.Location = new System.Drawing.Point(42, 198);
            this.dataGridViewOA.Name = "dataGridViewOA";
            this.dataGridViewOA.ReadOnly = true;
            this.dataGridViewOA.RowHeadersVisible = false;
            this.dataGridViewOA.Size = new System.Drawing.Size(278, 343);
            this.dataGridViewOA.TabIndex = 71;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoveAOS);
            this.groupBox1.Controls.Add(this.btnRemoveAOL);
            this.groupBox1.Controls.Add(this.dataGridView3);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.btnRemoveAOC);
            this.groupBox1.Controls.Add(this.btnRemoveAOF);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dataGridViewOA);
            this.groupBox1.Controls.Add(this.dataGridView4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbColour);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cbSleeve);
            this.groupBox1.Controls.Add(this.cbFarm);
            this.groupBox1.Controls.Add(this.cbLengths);
            this.groupBox1.Controls.Add(this.cheMix);
            this.groupBox1.Controls.Add(this.cheFt);
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 600);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flowers Database";
            this.groupBox1.Visible = false;
            // 
            // btnRemoveAOS
            // 
            this.btnRemoveAOS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveAOS.BackgroundImage")));
            this.btnRemoveAOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRemoveAOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveAOS.FlatAppearance.BorderSize = 0;
            this.btnRemoveAOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAOS.ForeColor = System.Drawing.Color.Gray;
            this.btnRemoveAOS.Location = new System.Drawing.Point(355, 89);
            this.btnRemoveAOS.Name = "btnRemoveAOS";
            this.btnRemoveAOS.Size = new System.Drawing.Size(21, 20);
            this.btnRemoveAOS.TabIndex = 75;
            this.btnRemoveAOS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveAOS.UseVisualStyleBackColor = true;
            this.btnRemoveAOS.Click += new System.EventHandler(this.btnRemoveAOS_Click);
            // 
            // btnRemoveAOL
            // 
            this.btnRemoveAOL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveAOL.BackgroundImage")));
            this.btnRemoveAOL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRemoveAOL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveAOL.FlatAppearance.BorderSize = 0;
            this.btnRemoveAOL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAOL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAOL.ForeColor = System.Drawing.Color.Gray;
            this.btnRemoveAOL.Location = new System.Drawing.Point(82, 46);
            this.btnRemoveAOL.Name = "btnRemoveAOL";
            this.btnRemoveAOL.Size = new System.Drawing.Size(21, 20);
            this.btnRemoveAOL.TabIndex = 74;
            this.btnRemoveAOL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveAOL.UseVisualStyleBackColor = true;
            this.btnRemoveAOL.Click += new System.EventHandler(this.btnRemoveAOL_Click);
            // 
            // btnRemoveAOC
            // 
            this.btnRemoveAOC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveAOC.BackgroundImage")));
            this.btnRemoveAOC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRemoveAOC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveAOC.FlatAppearance.BorderSize = 0;
            this.btnRemoveAOC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAOC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAOC.ForeColor = System.Drawing.Color.Gray;
            this.btnRemoveAOC.Location = new System.Drawing.Point(217, 46);
            this.btnRemoveAOC.Name = "btnRemoveAOC";
            this.btnRemoveAOC.Size = new System.Drawing.Size(21, 20);
            this.btnRemoveAOC.TabIndex = 73;
            this.btnRemoveAOC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveAOC.UseVisualStyleBackColor = true;
            this.btnRemoveAOC.Click += new System.EventHandler(this.btnRemoveAOC_Click);
            // 
            // btnRemoveAOF
            // 
            this.btnRemoveAOF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveAOF.BackgroundImage")));
            this.btnRemoveAOF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRemoveAOF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveAOF.FlatAppearance.BorderSize = 0;
            this.btnRemoveAOF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAOF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAOF.ForeColor = System.Drawing.Color.Gray;
            this.btnRemoveAOF.Location = new System.Drawing.Point(355, 46);
            this.btnRemoveAOF.Name = "btnRemoveAOF";
            this.btnRemoveAOF.Size = new System.Drawing.Size(21, 20);
            this.btnRemoveAOF.TabIndex = 72;
            this.btnRemoveAOF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveAOF.UseVisualStyleBackColor = true;
            this.btnRemoveAOF.Click += new System.EventHandler(this.btnRemoveAOF_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePickerArrival);
            this.groupBox2.Controls.Add(this.dateTimePickerDeparture);
            this.groupBox2.Controls.Add(this.btnLagOrdre);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtDatecode);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtOrderNumber);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(291, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 250);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nye ordre";
            // 
            // dateTimePickerArrival
            // 
            this.dateTimePickerArrival.Location = new System.Drawing.Point(108, 118);
            this.dateTimePickerArrival.Name = "dateTimePickerArrival";
            this.dateTimePickerArrival.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerArrival.TabIndex = 8;
            // 
            // dateTimePickerDeparture
            // 
            this.dateTimePickerDeparture.Location = new System.Drawing.Point(108, 92);
            this.dateTimePickerDeparture.Name = "dateTimePickerDeparture";
            this.dateTimePickerDeparture.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDeparture.TabIndex = 7;
            // 
            // btnLagOrdre
            // 
            this.btnLagOrdre.Location = new System.Drawing.Point(108, 160);
            this.btnLagOrdre.Name = "btnLagOrdre";
            this.btnLagOrdre.Size = new System.Drawing.Size(124, 45);
            this.btnLagOrdre.TabIndex = 6;
            this.btnLagOrdre.Text = "Lag ordre";
            this.btnLagOrdre.UseVisualStyleBackColor = true;
            this.btnLagOrdre.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Arrival:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Departure:";
            // 
            // txtDatecode
            // 
            this.txtDatecode.Location = new System.Drawing.Point(108, 66);
            this.txtDatecode.Name = "txtDatecode";
            this.txtDatecode.Size = new System.Drawing.Size(100, 20);
            this.txtDatecode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datecode:";
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Location = new System.Drawing.Point(108, 38);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(100, 20);
            this.txtOrderNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order nummer:";
            // 
            // bindingSource5
            // 
            this.bindingSource5.DataSource = typeof(INN_CSHARP.farm);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(776, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 77;
            this.label7.Text = "Arrival:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(758, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 76;
            this.label9.Text = "Departure:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(757, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 75;
            this.label11.Text = "Datecode:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(739, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 74;
            this.label12.Text = "Order nummer:";
            // 
            // lblArrival
            // 
            this.lblArrival.AutoSize = true;
            this.lblArrival.Location = new System.Drawing.Point(821, 98);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(10, 13);
            this.lblArrival.TabIndex = 81;
            this.lblArrival.Text = "-";
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Location = new System.Drawing.Point(821, 73);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(10, 13);
            this.lblDeparture.TabIndex = 80;
            this.lblDeparture.Text = "-";
            // 
            // lblDatecode
            // 
            this.lblDatecode.AutoSize = true;
            this.lblDatecode.Location = new System.Drawing.Point(821, 48);
            this.lblDatecode.Name = "lblDatecode";
            this.lblDatecode.Size = new System.Drawing.Size(10, 13);
            this.lblDatecode.TabIndex = 79;
            this.lblDatecode.Text = "-";
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Location = new System.Drawing.Point(821, 23);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(10, 13);
            this.lblOrderNumber.TabIndex = 78;
            this.lblOrderNumber.Text = "-";
            // 
            // AddOr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 704);
            this.Controls.Add(this.lblArrival);
            this.Controls.Add(this.lblDeparture);
            this.Controls.Add(this.lblDatecode);
            this.Controls.Add(this.lblOrderNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOr";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = " ";
            this.Load += new System.EventHandler(this.AddOr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOA)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox cbFarm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox cheMix;
        private System.Windows.Forms.CheckBox cheFt;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.ComboBox cbLengths;
        private System.Windows.Forms.ComboBox cbSleeve;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.ComboBox cbColour;
        private System.Windows.Forms.BindingSource bindingSource3;
        private System.Windows.Forms.BindingSource bindingSource4;
        private System.Windows.Forms.DataGridView dataGridViewOA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePickerArrival;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeparture;
        private System.Windows.Forms.Button btnLagOrdre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDatecode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource5;
        private System.Windows.Forms.Button btnRemoveAOF;
        private System.Windows.Forms.Button btnRemoveAOS;
        private System.Windows.Forms.Button btnRemoveAOL;
        private System.Windows.Forms.Button btnRemoveAOC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblArrival;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.Label lblDatecode;
        private System.Windows.Forms.Label lblOrderNumber;
    }
}