namespace TailorSoft
{
    partial class CustomerSearchForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerSearchForm));
            this.AddCustomer = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnSearchCustomerByPhone = new System.Windows.Forms.Button();
            this.txtCustomerPhoneSearch = new System.Windows.Forms.TextBox();
            this.dgCustomers = new System.Windows.Forms.DataGridView();
            this.lblCustomerSearchError = new System.Windows.Forms.Label();
            this.lblEnterCustomerPhone = new System.Windows.Forms.Label();
            this.dgCustomerBills = new System.Windows.Forms.DataGridView();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.lblForDgCustomers = new System.Windows.Forms.Label();
            this.lblForDgCustomerBills = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAccounts = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomerBills)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddCustomer
            // 
            this.AddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustomer.Location = new System.Drawing.Point(607, 57);
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.Size = new System.Drawing.Size(123, 28);
            this.AddCustomer.TabIndex = 2;
            this.AddCustomer.Text = "Add Customer";
            this.AddCustomer.UseVisualStyleBackColor = true;
            this.AddCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Red;
            this.lblHeader.Location = new System.Drawing.Point(12, 24);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(98, 24);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "TailorSoft";
            // 
            // btnSearchCustomerByPhone
            // 
            this.btnSearchCustomerByPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCustomerByPhone.Location = new System.Drawing.Point(470, 57);
            this.btnSearchCustomerByPhone.Name = "btnSearchCustomerByPhone";
            this.btnSearchCustomerByPhone.Size = new System.Drawing.Size(119, 28);
            this.btnSearchCustomerByPhone.TabIndex = 1;
            this.btnSearchCustomerByPhone.Text = "Search";
            this.btnSearchCustomerByPhone.UseVisualStyleBackColor = true;
            this.btnSearchCustomerByPhone.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // txtCustomerPhoneSearch
            // 
            this.txtCustomerPhoneSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerPhoneSearch.Location = new System.Drawing.Point(231, 60);
            this.txtCustomerPhoneSearch.Name = "txtCustomerPhoneSearch";
            this.txtCustomerPhoneSearch.Size = new System.Drawing.Size(211, 23);
            this.txtCustomerPhoneSearch.TabIndex = 0;
            this.txtCustomerPhoneSearch.TextChanged += new System.EventHandler(this.txtCustomerPhoneSearch_TextChanged);
            // 
            // dgCustomers
            // 
            this.dgCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCustomers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCustomers.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgCustomers.Location = new System.Drawing.Point(19, 177);
            this.dgCustomers.Name = "dgCustomers";
            this.dgCustomers.Size = new System.Drawing.Size(1121, 46);
            this.dgCustomers.TabIndex = 6;
            this.dgCustomers.Visible = false;
            this.dgCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomers_CellClick);
            // 
            // lblCustomerSearchError
            // 
            this.lblCustomerSearchError.AutoSize = true;
            this.lblCustomerSearchError.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerSearchError.ForeColor = System.Drawing.Color.Red;
            this.lblCustomerSearchError.Location = new System.Drawing.Point(16, 100);
            this.lblCustomerSearchError.Name = "lblCustomerSearchError";
            this.lblCustomerSearchError.Size = new System.Drawing.Size(20, 18);
            this.lblCustomerSearchError.TabIndex = 7;
            this.lblCustomerSearchError.Text = "   ";
            // 
            // lblEnterCustomerPhone
            // 
            this.lblEnterCustomerPhone.AutoSize = true;
            this.lblEnterCustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterCustomerPhone.Location = new System.Drawing.Point(16, 60);
            this.lblEnterCustomerPhone.Name = "lblEnterCustomerPhone";
            this.lblEnterCustomerPhone.Size = new System.Drawing.Size(203, 17);
            this.lblEnterCustomerPhone.TabIndex = 8;
            this.lblEnterCustomerPhone.Text = "Customer phone or Bill number";
            // 
            // dgCustomerBills
            // 
            this.dgCustomerBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCustomerBills.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgCustomerBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomerBills.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCustomerBills.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgCustomerBills.Location = new System.Drawing.Point(19, 300);
            this.dgCustomerBills.Name = "dgCustomerBills";
            this.dgCustomerBills.Size = new System.Drawing.Size(1121, 150);
            this.dgCustomerBills.TabIndex = 9;
            this.dgCustomerBills.Visible = false;
            this.dgCustomerBills.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomerBills_CellClick);
            // 
            // btnAddBill
            // 
            this.btnAddBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBill.Location = new System.Drawing.Point(19, 239);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(77, 27);
            this.btnAddBill.TabIndex = 10;
            this.btnAddBill.Text = "Add Bill";
            this.btnAddBill.UseVisualStyleBackColor = true;
            this.btnAddBill.Visible = false;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // lblForDgCustomers
            // 
            this.lblForDgCustomers.AutoSize = true;
            this.lblForDgCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForDgCustomers.Location = new System.Drawing.Point(16, 145);
            this.lblForDgCustomers.Name = "lblForDgCustomers";
            this.lblForDgCustomers.Size = new System.Drawing.Size(517, 17);
            this.lblForDgCustomers.TabIndex = 11;
            this.lblForDgCustomers.Text = "Customer Information (Click on record below to edit or view customer information)" +
    "";
            this.lblForDgCustomers.Visible = false;
            // 
            // lblForDgCustomerBills
            // 
            this.lblForDgCustomerBills.AutoSize = true;
            this.lblForDgCustomerBills.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForDgCustomerBills.Location = new System.Drawing.Point(16, 269);
            this.lblForDgCustomerBills.Name = "lblForDgCustomerBills";
            this.lblForDgCustomerBills.Size = new System.Drawing.Size(493, 17);
            this.lblForDgCustomerBills.TabIndex = 12;
            this.lblForDgCustomerBills.Text = "Customer Bills (Click on record below to edit or view customer bill information)";
            this.lblForDgCustomerBills.Visible = false;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1152, 24);
            this.menu.TabIndex = 13;
            this.menu.Text = "menuStrip1";
            // 
            // MenuItem
            // 
            this.MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAccounts,
            this.aboutToolStripMenuItem});
            this.MenuItem.Name = "MenuItem";
            this.MenuItem.Size = new System.Drawing.Size(50, 20);
            this.MenuItem.Text = "Menu";
            // 
            // MenuAccounts
            // 
            this.MenuAccounts.Name = "MenuAccounts";
            this.MenuAccounts.Size = new System.Drawing.Size(124, 22);
            this.MenuAccounts.Text = "Accounts";
            this.MenuAccounts.Click += new System.EventHandler(this.MenuAccounts_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // CustomerSearchForm
            // 
            this.AcceptButton = this.btnSearchCustomerByPhone;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 561);
            this.Controls.Add(this.lblForDgCustomerBills);
            this.Controls.Add(this.lblForDgCustomers);
            this.Controls.Add(this.btnAddBill);
            this.Controls.Add(this.dgCustomerBills);
            this.Controls.Add(this.lblEnterCustomerPhone);
            this.Controls.Add(this.lblCustomerSearchError);
            this.Controls.Add(this.dgCustomers);
            this.Controls.Add(this.txtCustomerPhoneSearch);
            this.Controls.Add(this.btnSearchCustomerByPhone);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.AddCustomer);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "CustomerSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TailorSoft - Search Customer";
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomerBills)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddCustomer;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnSearchCustomerByPhone;
        private System.Windows.Forms.TextBox txtCustomerPhoneSearch;
        private System.Windows.Forms.DataGridView dgCustomers;
        private System.Windows.Forms.Label lblCustomerSearchError;
        private System.Windows.Forms.Label lblEnterCustomerPhone;
        private System.Windows.Forms.DataGridView dgCustomerBills;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.Label lblForDgCustomers;
        private System.Windows.Forms.Label lblForDgCustomerBills;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem MenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuAccounts;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}