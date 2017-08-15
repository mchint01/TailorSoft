using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TailorSoft.Business;
using TailorSoft.Business.Interfaces;
using TailorSoft.Business.Models;

namespace TailorSoft
{
    public partial class BillSearchForm : Form
    {
        private readonly ICustomerManager _customerManager;

        public BillSearchForm(int searchedBillNumber, IList<BillInfo> bills)
        {
            InitializeComponent();

            _customerManager = new CustomerManager();

            // customer bills data source
            dgCustomerBills.DataSource = bills;
            dgCustomerBills.Visible = true;

            // hide columns
            if (dgCustomerBills.Columns["Id"] != null)
            {
                dgCustomerBills.Columns["Id"].Visible = false;
            }

            if (dgCustomerBills.Columns["CustomerId"] != null)
            {
                dgCustomerBills.Columns["CustomerId"].Visible = false;
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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
