namespace ui
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.order_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branch_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.dateFilterCheckbox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(15, 196);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSearch.Location = new System.Drawing.Point(15, 49);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(163, 144);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Order Number";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order_number,
            this.order_date,
            this.sale_price,
            this.deposit,
            this.customer_number,
            this.forename,
            this.surname,
            this.telephone_number,
            this.branch_name,
            this.postcode});
            this.dataGridView1.Location = new System.Drawing.Point(184, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(788, 207);
            this.dataGridView1.TabIndex = 2;
            // 
            // order_number
            // 
            this.order_number.DataPropertyName = "order_number";
            this.order_number.HeaderText = "Order No.";
            this.order_number.Name = "order_number";
            // 
            // order_date
            // 
            this.order_date.DataPropertyName = "order_date";
            this.order_date.HeaderText = "Order Date";
            this.order_date.Name = "order_date";
            // 
            // sale_price
            // 
            this.sale_price.DataPropertyName = "sale_price";
            this.sale_price.HeaderText = "Sale Price";
            this.sale_price.Name = "sale_price";
            // 
            // deposit
            // 
            this.deposit.DataPropertyName = "deposit";
            this.deposit.HeaderText = "Deposit";
            this.deposit.Name = "deposit";
            // 
            // customer_number
            // 
            this.customer_number.DataPropertyName = "customer_number";
            this.customer_number.HeaderText = "Customer No.";
            this.customer_number.Name = "customer_number";
            // 
            // forename
            // 
            this.forename.DataPropertyName = "forename";
            this.forename.HeaderText = "Forename";
            this.forename.Name = "forename";
            // 
            // surname
            // 
            this.surname.DataPropertyName = "surname";
            this.surname.HeaderText = "Surname";
            this.surname.Name = "surname";
            // 
            // telephone_number
            // 
            this.telephone_number.DataPropertyName = "telephone_number";
            this.telephone_number.HeaderText = "Telephone No.";
            this.telephone_number.Name = "telephone_number";
            // 
            // branch_name
            // 
            this.branch_name.DataPropertyName = "branch_name";
            this.branch_name.HeaderText = "Branch Name";
            this.branch_name.Name = "branch_name";
            // 
            // postcode
            // 
            this.postcode.DataPropertyName = "postcode";
            this.postcode.HeaderText = "Postcode";
            this.postcode.Name = "postcode";
            // 
            // startDatePicker
            // 
            this.startDatePicker.CustomFormat = "yyyy/MM/dd";
            this.startDatePicker.Location = new System.Drawing.Point(184, 259);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 20);
            this.startDatePicker.TabIndex = 7;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(181, 239);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(29, 13);
            this.startDateLabel.TabIndex = 9;
            this.startDateLabel.Text = "After";
            // 
            // dateFilterCheckbox
            // 
            this.dateFilterCheckbox.AutoSize = true;
            this.dateFilterCheckbox.Location = new System.Drawing.Point(96, 239);
            this.dateFilterCheckbox.Name = "dateFilterCheckbox";
            this.dateFilterCheckbox.Size = new System.Drawing.Size(15, 14);
            this.dateFilterCheckbox.TabIndex = 12;
            this.dateFilterCheckbox.UseVisualStyleBackColor = true;
            this.dateFilterCheckbox.CheckedChanged += new System.EventHandler(this.dateFilterCheckbox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Filter by Date?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.dateFilterCheckbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn deposit;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn forename;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn branch_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn postcode;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.CheckBox dateFilterCheckbox;
        private System.Windows.Forms.Label label4;
    }
}

