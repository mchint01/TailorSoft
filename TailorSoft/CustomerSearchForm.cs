using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TailorSoft.Business;
using TailorSoft.Business.Interfaces;
using TailorSoft.Business.Models;

namespace TailorSoft
{
    public partial class CustomerSearchForm : Form
    {
        private readonly ICustomerManager _customerManager;

        public CustomerSearchForm()
        {
            InitializeComponent();

            _customerManager = new CustomerManager();
        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            txtCustomerPhoneSearch_TextChanged(sender, e);
            txtCustomerPhoneSearch.Text = null;

            var addCustomerForm = new CustomerInfoForm();

            addCustomerForm.ShowDialog();
        }

        private void btnSearchCustomerByPhone_Click(object sender, EventArgs e)
        {
            txtCustomerPhoneSearch_TextChanged(sender, e);

            if (string.IsNullOrWhiteSpace(txtCustomerPhoneSearch.Text) ||
                txtCustomerPhoneSearch.Text.Length > 14 ||
                txtCustomerPhoneSearch.Text.Length < 5)
            {
                lblCustomerSearchError.Text = @"Customer phone number is required to search, and it should be in valid format.";

                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            // get customer
            var customer = _customerManager.GetCustomerInfo(txtCustomerPhoneSearch.Text);

            if (customer == null)
            {
                lblCustomerSearchError.Text = $@"Customer with phone number {txtCustomerPhoneSearch.Text} not found." +
                                              Environment.NewLine + @"Add Customer to create a new record.";

                Cursor.Current = Cursors.Arrow;

                return;
            }

            dgCustomers.DataSource = new List<CustomerInfo>
            {
                customer
            };

            dgCustomers.Visible = true;
            lblForDgCustomers.Visible = true;
            btnAddBill.Visible = true;

            // hide ID column
            dgCustomers.Columns[0].Visible = false;

            // get customer bills
            var customerBills = _customerManager.GetCustomerBills(customer.Id);

            if (!customerBills.Any()) return;

            // add customer name
            foreach (var bill in customerBills)
            {
                bill.CustomerName = customer.Name;
            }

            // customer bills data source
            dgCustomerBills.DataSource = customerBills;
            dgCustomerBills.Visible = true;
            lblForDgCustomerBills.Visible = true;

            // hide columns
            if (dgCustomerBills.Columns["Id"] != null)
            {
                dgCustomerBills.Columns["Id"].Visible = false;
            }

            if (dgCustomerBills.Columns["CustomerId"] != null)
            {
                dgCustomerBills.Columns["CustomerId"].Visible = false;
            }

            if (dgCustomerBills.Columns["CustomerName"] != null)
            {
                dgCustomerBills.Columns["CustomerName"].Visible = false;
            }

            if (dgCustomerBills.Columns["SuitMeasurements"] != null)
            {
                dgCustomerBills.Columns["SuitMeasurements"].Visible = false;
            }

            if (dgCustomerBills.Columns["JacketMeasurements"] != null)
            {
                dgCustomerBills.Columns["JacketMeasurements"].Visible = false;
            }

            if (dgCustomerBills.Columns["SafaryMeasurements"] != null)
            {
                dgCustomerBills.Columns["SafaryMeasurements"].Visible = false;
            }

            if (dgCustomerBills.Columns["TrouserMeasurements"] != null)
            {
                dgCustomerBills.Columns["TrouserMeasurements"].Visible = false;
            }

            if (dgCustomerBills.Columns["ShirtMeasurements"] != null)
            {
                dgCustomerBills.Columns["ShirtMeasurements"].Visible = false;
            }

            if (dgCustomerBills.Columns["OtherMeasurements"] != null)
            {
                dgCustomerBills.Columns["OtherMeasurements"].Visible = false;
            }

            if (dgCustomerBills.Columns["SuitRate"] != null)
            {
                dgCustomerBills.Columns["SuitRate"].Visible = false;
            }

            if (dgCustomerBills.Columns["JacketRate"] != null)
            {
                dgCustomerBills.Columns["JacketRate"].Visible = false;
            }

            if (dgCustomerBills.Columns["SafaryRate"] != null)
            {
                dgCustomerBills.Columns["SafaryRate"].Visible = false;
            }

            if (dgCustomerBills.Columns["TrouserRate"] != null)
            {
                dgCustomerBills.Columns["TrouserRate"].Visible = false;
            }

            if (dgCustomerBills.Columns["ShirtRate"] != null)
            {
                dgCustomerBills.Columns["ShirtRate"].Visible = false;
            }

            if (dgCustomerBills.Columns["OtherRate"] != null)
            {
                dgCustomerBills.Columns["OtherRate"].Visible = false;
            }

            if (dgCustomerBills.Columns["SentToTailorDt"] != null)
            {
                dgCustomerBills.Columns["SentToTailorDt"].Visible = false;
            }

            if (dgCustomerBills.Columns["ReadyForDeliveryDt"] != null)
            {
                dgCustomerBills.Columns["ReadyForDeliveryDt"].Visible = false;
            }

            if (dgCustomerBills.Columns["DeliveredDt"] != null)
            {
                dgCustomerBills.Columns["DeliveredDt"].Visible = false;
            }

            if (dgCustomerBills.Columns["PreferredInternalDeliveryDt"] != null)
            {
                dgCustomerBills.Columns["PreferredInternalDeliveryDt"].Visible = false;
            }

            if (dgCustomerBills.Columns["Notes"] != null)
            {
                dgCustomerBills.Columns["Notes"].Visible = false;
            }

            Cursor.Current = Cursors.Arrow;
        }

        private void dgCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = e.RowIndex;

            var row = dgCustomers.Rows[rowIndex];

            var customerId = Guid.Parse(Convert.ToString(row.Cells[0].Value));

            var customerForm = new CustomerInfoForm(customerId);

            customerForm.ShowDialog();
        }

        private void dgCustomerBills_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = e.RowIndex;

            var row = dgCustomerBills.Rows[rowIndex];

            var billId = Guid.Parse(Convert.ToString(row.Cells["Id"].Value));
            var customerId = Guid.Parse(Convert.ToString(row.Cells["CustomerId"].Value));
            var customerName = Convert.ToString(row.Cells["CustomerName"].Value);

            var billForm = new CustomerBillForm(customerId, customerName, billId);

            var dialogResult = billForm.ShowDialog();

            btnSearchCustomerByPhone_Click(sender, e);
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            lblCustomerSearchError.Text = null;

            // get customer
            var customer = _customerManager.GetCustomerInfo(txtCustomerPhoneSearch.Text);

            if (customer == null)
            {
                lblCustomerSearchError.Text = $@"Customer with phone number {txtCustomerPhoneSearch.Text} not found." +
                                              Environment.NewLine + @"Add Customer to create a new record.";

                return;
            }

            var addBillForm = new CustomerBillForm(customer.Id, customer.Name);

            var dialogResult = addBillForm.ShowDialog();

            btnSearchCustomerByPhone_Click(sender, e);
        }

        private void MenuAccounts_Click(object sender, EventArgs e)
        {
            var accountForm = new AccountForm();

            accountForm.ShowDialog();
        }

        private void txtCustomerPhoneSearch_TextChanged(object sender, EventArgs e)
        {
            lblCustomerSearchError.Text = null;
            btnAddBill.Visible = false;
            dgCustomers.Visible = false;
            lblForDgCustomers.Visible = false;
            dgCustomerBills.Visible = false;
            lblForDgCustomerBills.Visible = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();

            aboutForm.ShowDialog();
        }
    }
}
