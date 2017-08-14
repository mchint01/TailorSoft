using System;
using System.Windows.Forms;
using TailorSoft.Business;
using TailorSoft.Business.Interfaces;
using TailorSoft.Business.Models;

namespace TailorSoft
{
    public partial class CustomerInfoForm : Form
    {
        private readonly ICustomerManager _customerManager;

        private readonly ILogManager _logManager;

        private readonly Guid? _customerId;

        public CustomerInfoForm(Guid? customerId = null)
        {
            InitializeComponent();

            _customerManager = new CustomerManager();

            _logManager = new LogManager();

            _customerId = customerId;

            if (_customerId == null || _customerId.Value == Guid.Empty) return;

            Cursor.Current = Cursors.WaitCursor;

            var customer = _customerManager.GetCustomerInfo(_customerId.Value);

            txtCustomerName.Text = customer.Name;
            txtCustomerAddress.Text = customer.Address;
            txtCustomerPhone.Text = customer.Phone;

            Cursor.Current = Cursors.Arrow;
        }

        public CustomerInfoForm(Phone phoneNumber)
        {
            InitializeComponent();

            _customerManager = new CustomerManager();

            _logManager = new LogManager();

            txtCustomerPhone.Text = phoneNumber.PhoneNumber;
        }

        private void btnAddCustomerInfo_Click(object sender, EventArgs e)
        {
            lblAddCustomerFormError.Text = null;

            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                lblAddCustomerFormError.Text = @"Customer Name is required." + Environment.NewLine;
            }

            if (string.IsNullOrWhiteSpace(txtCustomerPhone.Text))
            {
                lblAddCustomerFormError.Text += @"Customer Phone number is required.";
            }

            if (!string.IsNullOrWhiteSpace(lblAddCustomerFormError.Text))
            {
                return;
            }

            var customerInfo = new CustomerInfo
            {
                Name = txtCustomerName.Text,
                Address = txtCustomerAddress.Text,
                Phone = txtCustomerPhone.Text
            };

            Cursor.Current = Cursors.WaitCursor;

            try
            {
                if (_customerId == null || _customerId.Value == Guid.Empty)
                {
                    _customerManager.AddCustomerInfo(customerInfo);
                }

                else
                {
                    customerInfo.Id = _customerId.Value;
                    _customerManager.UpdateCustomerInfo(customerInfo);
                }

                Close();
            }

            catch (Exception ex)
            {
                _logManager.LogMessage(ex.Message, ex.InnerException != null ? ex.InnerException.ToString() : null);

                lblAddCustomerFormError.Text = ex.Message;
            }

            Cursor.Current = Cursors.Arrow;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
