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
            this.dataGridViewTest = new System.Windows.Forms.DataGridView();
            this.bindingSourceOrders = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTest2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTest2)).BeginInit();
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
            this.dataGridViewTest.Location = new System.Drawing.Point(93, 30);
            this.dataGridViewTest.Name = "dataGridViewTest";
            this.dataGridViewTest.ReadOnly = true;
            this.dataGridViewTest.RowHeadersVisible = false;
            this.dataGridViewTest.Size = new System.Drawing.Size(818, 264);
            this.dataGridViewTest.TabIndex = 2;
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
            this.dataGridViewTest2.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridViewTest2.Location = new System.Drawing.Point(93, 314);
            this.dataGridViewTest2.Name = "dataGridViewTest2";
            this.dataGridViewTest2.ReadOnly = true;
            this.dataGridViewTest2.RowHeadersVisible = false;
            this.dataGridViewTest2.Size = new System.Drawing.Size(818, 297);
            this.dataGridViewTest2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Butikkdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 634);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewTest2);
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewTest;
        private System.Windows.Forms.BindingSource bindingSourceOrders;
        private System.Windows.Forms.DataGridView dataGridViewTest2;
        private System.Windows.Forms.Button button1;
    }
}