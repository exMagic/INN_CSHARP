namespace INN_CSHARP
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLength = new System.Windows.Forms.ComboBox();
            this.dataGridViewFL = new System.Windows.Forms.DataGridView();
            this.cbFarm = new System.Windows.Forms.ComboBox();
            this.dataGridViewFF = new System.Windows.Forms.DataGridView();
            this.dataGridViewFlMain = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnRemoveFL = new System.Windows.Forms.Button();
            this.btnRemoveFF = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFAdd = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnFEdit = new System.Windows.Forms.Button();
            this.btnFDelete = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnAddOr = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.lblAmountBuckets = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblAmountSteems = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblAmountBoxes = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDatecode = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblArrival = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewO1 = new System.Windows.Forms.DataGridView();
            this.cbOrders = new System.Windows.Forms.ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceFarms = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceOrders = new System.Windows.Forms.BindingSource(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlMain)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewO1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFarms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Length:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Farm:";
            // 
            // cbLength
            // 
            this.cbLength.ForeColor = System.Drawing.Color.DimGray;
            this.cbLength.FormattingEnabled = true;
            this.cbLength.Location = new System.Drawing.Point(274, 234);
            this.cbLength.Name = "cbLength";
            this.cbLength.Size = new System.Drawing.Size(104, 21);
            this.cbLength.TabIndex = 4;
            this.cbLength.SelectedIndexChanged += new System.EventHandler(this.cbLength_SelectedIndexChanged);
            // 
            // dataGridViewFL
            // 
            this.dataGridViewFL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewFL.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewFL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFL.Location = new System.Drawing.Point(271, 314);
            this.dataGridViewFL.Name = "dataGridViewFL";
            this.dataGridViewFL.RowHeadersVisible = false;
            this.dataGridViewFL.Size = new System.Drawing.Size(118, 10);
            this.dataGridViewFL.TabIndex = 3;
            this.dataGridViewFL.Visible = false;
            // 
            // cbFarm
            // 
            this.cbFarm.ForeColor = System.Drawing.Color.DimGray;
            this.cbFarm.FormattingEnabled = true;
            this.cbFarm.Location = new System.Drawing.Point(274, 179);
            this.cbFarm.Name = "cbFarm";
            this.cbFarm.Size = new System.Drawing.Size(104, 21);
            this.cbFarm.TabIndex = 2;
            this.cbFarm.SelectedIndexChanged += new System.EventHandler(this.cbFarm_SelectedIndexChanged);
            // 
            // dataGridViewFF
            // 
            this.dataGridViewFF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewFF.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewFF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFF.Location = new System.Drawing.Point(271, 272);
            this.dataGridViewFF.Name = "dataGridViewFF";
            this.dataGridViewFF.RowHeadersVisible = false;
            this.dataGridViewFF.Size = new System.Drawing.Size(118, 10);
            this.dataGridViewFF.TabIndex = 1;
            this.dataGridViewFF.Visible = false;
            // 
            // dataGridViewFlMain
            // 
            this.dataGridViewFlMain.AllowUserToAddRows = false;
            this.dataGridViewFlMain.AllowUserToDeleteRows = false;
            this.dataGridViewFlMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFlMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewFlMain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataGridViewFlMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewFlMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFlMain.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFlMain.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridViewFlMain.Location = new System.Drawing.Point(411, 163);
            this.dataGridViewFlMain.Name = "dataGridViewFlMain";
            this.dataGridViewFlMain.ReadOnly = true;
            this.dataGridViewFlMain.RowHeadersVisible = false;
            this.dataGridViewFlMain.Size = new System.Drawing.Size(818, 473);
            this.dataGridViewFlMain.TabIndex = 0;
            this.dataGridViewFlMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(210)))), ((int)(((byte)(212)))));
            this.button1.Location = new System.Drawing.Point(-1, 89);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(30, 5, 5, 5);
            this.button1.Size = new System.Drawing.Size(229, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Flowers";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(210)))), ((int)(((byte)(212)))));
            this.button3.Location = new System.Drawing.Point(-1, 185);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(30, 5, 5, 5);
            this.button3.Size = new System.Drawing.Size(229, 48);
            this.button3.TabIndex = 6;
            this.button3.Text = "Avviksjkemma";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(210)))), ((int)(((byte)(212)))));
            this.button4.Location = new System.Drawing.Point(-1, 233);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(30, 5, 5, 5);
            this.button4.Size = new System.Drawing.Size(229, 48);
            this.button4.TabIndex = 7;
            this.button4.Text = "Export";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(210)))), ((int)(((byte)(212)))));
            this.button2.Location = new System.Drawing.Point(-1, 137);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(30, 5, 5, 5);
            this.button2.Size = new System.Drawing.Size(229, 48);
            this.button2.TabIndex = 8;
            this.button2.Text = "Orders";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1245, 765);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnRemoveFL);
            this.tabPage5.Controls.Add(this.btnRemoveFF);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Controls.Add(this.btnFAdd);
            this.tabPage5.Controls.Add(this.button5);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.btnFEdit);
            this.tabPage5.Controls.Add(this.dataGridViewFlMain);
            this.tabPage5.Controls.Add(this.btnFDelete);
            this.tabPage5.Controls.Add(this.dataGridViewFF);
            this.tabPage5.Controls.Add(this.cbFarm);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.dataGridViewFL);
            this.tabPage5.Controls.Add(this.cbLength);
            this.tabPage5.Controls.Add(this.pictureBox3);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1237, 739);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnRemoveFL
            // 
            this.btnRemoveFL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveFL.BackgroundImage")));
            this.btnRemoveFL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRemoveFL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveFL.FlatAppearance.BorderSize = 0;
            this.btnRemoveFL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFL.ForeColor = System.Drawing.Color.Gray;
            this.btnRemoveFL.Location = new System.Drawing.Point(380, 235);
            this.btnRemoveFL.Name = "btnRemoveFL";
            this.btnRemoveFL.Size = new System.Drawing.Size(21, 20);
            this.btnRemoveFL.TabIndex = 15;
            this.btnRemoveFL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnRemoveFL, "fjern filter");
            this.btnRemoveFL.UseVisualStyleBackColor = true;
            this.btnRemoveFL.Click += new System.EventHandler(this.btnRemoveFL_Click);
            // 
            // btnRemoveFF
            // 
            this.btnRemoveFF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveFF.BackgroundImage")));
            this.btnRemoveFF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRemoveFF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveFF.FlatAppearance.BorderSize = 0;
            this.btnRemoveFF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFF.ForeColor = System.Drawing.Color.Gray;
            this.btnRemoveFF.Location = new System.Drawing.Point(380, 180);
            this.btnRemoveFF.Name = "btnRemoveFF";
            this.btnRemoveFF.Size = new System.Drawing.Size(21, 20);
            this.btnRemoveFF.TabIndex = 14;
            this.btnRemoveFF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnRemoveFF, "fjern filter");
            this.btnRemoveFF.UseVisualStyleBackColor = true;
            this.btnRemoveFF.Click += new System.EventHandler(this.btnRemoveFF_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "999";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Antall:";
            // 
            // btnFAdd
            // 
            this.btnFAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btnFAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFAdd.BackgroundImage")));
            this.btnFAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.btnFAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFAdd.ForeColor = System.Drawing.Color.White;
            this.btnFAdd.Location = new System.Drawing.Point(412, 87);
            this.btnFAdd.Name = "btnFAdd";
            this.btnFAdd.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnFAdd.Size = new System.Drawing.Size(86, 28);
            this.btnFAdd.TabIndex = 7;
            this.btnFAdd.Text = "Ny";
            this.btnFAdd.UseVisualStyleBackColor = false;
            this.btnFAdd.Click += new System.EventHandler(this.btnFAdd_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Gray;
            this.button5.Location = new System.Drawing.Point(504, 87);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 28);
            this.button5.TabIndex = 10;
            this.button5.Text = "Lagre som kopi";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnFEdit
            // 
            this.btnFEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFEdit.BackgroundImage")));
            this.btnFEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnFEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFEdit.ForeColor = System.Drawing.Color.Gray;
            this.btnFEdit.Location = new System.Drawing.Point(642, 87);
            this.btnFEdit.Name = "btnFEdit";
            this.btnFEdit.Size = new System.Drawing.Size(88, 28);
            this.btnFEdit.TabIndex = 9;
            this.btnFEdit.Text = "Rediger";
            this.btnFEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFEdit.UseVisualStyleBackColor = true;
            this.btnFEdit.Click += new System.EventHandler(this.btnFEdit_Click);
            // 
            // btnFDelete
            // 
            this.btnFDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFDelete.BackgroundImage")));
            this.btnFDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnFDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFDelete.ForeColor = System.Drawing.Color.Gray;
            this.btnFDelete.Location = new System.Drawing.Point(736, 87);
            this.btnFDelete.Name = "btnFDelete";
            this.btnFDelete.Size = new System.Drawing.Size(72, 28);
            this.btnFDelete.TabIndex = 8;
            this.btnFDelete.Text = "Slett";
            this.btnFDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFDelete.UseVisualStyleBackColor = true;
            this.btnFDelete.Click += new System.EventHandler(this.btnFDelete_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Silver;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1231, 55);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btnAddOr);
            this.tabPage6.Controls.Add(this.button7);
            this.tabPage6.Controls.Add(this.button8);
            this.tabPage6.Controls.Add(this.button9);
            this.tabPage6.Controls.Add(this.lblAmountBuckets);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.lblAmountSteems);
            this.tabPage6.Controls.Add(this.label10);
            this.tabPage6.Controls.Add(this.lblAmountBoxes);
            this.tabPage6.Controls.Add(this.label9);
            this.tabPage6.Controls.Add(this.lblDatecode);
            this.tabPage6.Controls.Add(this.label8);
            this.tabPage6.Controls.Add(this.lblArrival);
            this.tabPage6.Controls.Add(this.label7);
            this.tabPage6.Controls.Add(this.lblDeparture);
            this.tabPage6.Controls.Add(this.label3);
            this.tabPage6.Controls.Add(this.dataGridViewO1);
            this.tabPage6.Controls.Add(this.cbOrders);
            this.tabPage6.Controls.Add(this.pictureBox4);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1237, 739);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            this.tabPage6.Enter += new System.EventHandler(this.tabPage6_Enter);
            // 
            // btnAddOr
            // 
            this.btnAddOr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btnAddOr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddOr.BackgroundImage")));
            this.btnAddOr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddOr.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.btnAddOr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOr.ForeColor = System.Drawing.Color.White;
            this.btnAddOr.Location = new System.Drawing.Point(412, 87);
            this.btnAddOr.Name = "btnAddOr";
            this.btnAddOr.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnAddOr.Size = new System.Drawing.Size(86, 28);
            this.btnAddOr.TabIndex = 28;
            this.btnAddOr.Text = "Ny";
            this.btnAddOr.UseVisualStyleBackColor = false;
            this.btnAddOr.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Gray;
            this.button7.Location = new System.Drawing.Point(504, 87);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(132, 28);
            this.button7.TabIndex = 31;
            this.button7.Text = "Lagre som kopi";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Gray;
            this.button8.Location = new System.Drawing.Point(642, 87);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(88, 28);
            this.button8.TabIndex = 30;
            this.button8.Text = "Rediger";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Gray;
            this.button9.Location = new System.Drawing.Point(736, 87);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(72, 28);
            this.button9.TabIndex = 29;
            this.button9.Text = "Slett";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // lblAmountBuckets
            // 
            this.lblAmountBuckets.AutoSize = true;
            this.lblAmountBuckets.Location = new System.Drawing.Point(968, 205);
            this.lblAmountBuckets.Name = "lblAmountBuckets";
            this.lblAmountBuckets.Size = new System.Drawing.Size(35, 13);
            this.lblAmountBuckets.TabIndex = 27;
            this.lblAmountBuckets.Text = "label8";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(894, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Antall buckets:";
            // 
            // lblAmountSteems
            // 
            this.lblAmountSteems.AutoSize = true;
            this.lblAmountSteems.Location = new System.Drawing.Point(969, 184);
            this.lblAmountSteems.Name = "lblAmountSteems";
            this.lblAmountSteems.Size = new System.Drawing.Size(35, 13);
            this.lblAmountSteems.TabIndex = 25;
            this.lblAmountSteems.Text = "label8";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(902, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Antall steems:";
            // 
            // lblAmountBoxes
            // 
            this.lblAmountBoxes.AutoSize = true;
            this.lblAmountBoxes.Location = new System.Drawing.Point(969, 160);
            this.lblAmountBoxes.Name = "lblAmountBoxes";
            this.lblAmountBoxes.Size = new System.Drawing.Size(35, 13);
            this.lblAmountBoxes.TabIndex = 23;
            this.lblAmountBoxes.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(902, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Antall bokser:";
            // 
            // lblDatecode
            // 
            this.lblDatecode.AutoSize = true;
            this.lblDatecode.Location = new System.Drawing.Point(829, 133);
            this.lblDatecode.Name = "lblDatecode";
            this.lblDatecode.Size = new System.Drawing.Size(35, 13);
            this.lblDatecode.TabIndex = 21;
            this.lblDatecode.Text = "label8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(775, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Datecode:";
            // 
            // lblArrival
            // 
            this.lblArrival.AutoSize = true;
            this.lblArrival.Location = new System.Drawing.Point(639, 133);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(35, 13);
            this.lblArrival.TabIndex = 19;
            this.lblArrival.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(603, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Arrival:";
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Location = new System.Drawing.Point(464, 133);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(35, 13);
            this.lblDeparture.TabIndex = 17;
            this.lblDeparture.Text = "label6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Departure:";
            // 
            // dataGridViewO1
            // 
            this.dataGridViewO1.AllowUserToAddRows = false;
            this.dataGridViewO1.AllowUserToDeleteRows = false;
            this.dataGridViewO1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewO1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewO1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataGridViewO1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewO1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewO1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewO1.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridViewO1.Location = new System.Drawing.Point(411, 163);
            this.dataGridViewO1.Name = "dataGridViewO1";
            this.dataGridViewO1.ReadOnly = true;
            this.dataGridViewO1.RowHeadersVisible = false;
            this.dataGridViewO1.Size = new System.Drawing.Size(463, 473);
            this.dataGridViewO1.TabIndex = 15;
            // 
            // cbOrders
            // 
            this.cbOrders.FormattingEnabled = true;
            this.cbOrders.Location = new System.Drawing.Point(274, 163);
            this.cbOrders.Name = "cbOrders";
            this.cbOrders.Size = new System.Drawing.Size(121, 21);
            this.cbOrders.TabIndex = 14;
            this.cbOrders.Text = "Velg order nummer";
            this.cbOrders.SelectedIndexChanged += new System.EventHandler(this.cbOrders_SelectedIndexChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Silver;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox4.Location = new System.Drawing.Point(3, 3);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1231, 55);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.button10);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1237, 739);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "tabPage7";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(495, 139);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 0;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.pictureBox2);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(1237, 739);
            this.tabPage8.TabIndex = 3;
            this.tabPage8.Text = "tabPage8";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::INN_CSHARP.Properties.Resources.logo22_01;
            this.pictureBox2.Location = new System.Drawing.Point(-5, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(229, 55);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 1064);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(INN_CSHARP.flower);
            // 
            // bindingSourceFarms
            // 
            this.bindingSourceFarms.DataSource = typeof(INN_CSHARP.farm);
            // 
            // bindingSource3
            // 
            this.bindingSource3.DataSource = typeof(INN_CSHARP.lengths);
            // 
            // bindingSourceOrders
            // 
            this.bindingSourceOrders.DataSource = typeof(INN_CSHARP.orders);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1245, 765);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Innkjop";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlMain)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewO1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFarms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion



        private System.Windows.Forms.DataGridView dataGridViewFlMain;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewFF;
        private System.Windows.Forms.BindingSource bindingSourceFarms;
        private System.Windows.Forms.ComboBox cbFarm;
        private System.Windows.Forms.DataGridView dataGridViewFL;
        private System.Windows.Forms.BindingSource bindingSource3;
        private System.Windows.Forms.ComboBox cbLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnFAdd;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnFEdit;
        private System.Windows.Forms.Button btnFDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.BindingSource bindingSourceOrders;
        private System.Windows.Forms.ComboBox cbOrders;
        private System.Windows.Forms.Button btnRemoveFF;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnRemoveFL;
        private System.Windows.Forms.DataGridView dataGridViewO1;
        private System.Windows.Forms.Label lblArrival;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDatecode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAmountBoxes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAmountSteems;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAmountBuckets;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAddOr;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}

