using System;
using System.Globalization;
using System.Windows.Forms;
using TailorSoft.Business;
using TailorSoft.Business.Interfaces;
using TailorSoft.Business.Models;

namespace TailorSoft
{
    public partial class CustomerBillForm : Form
    {
        private readonly Guid _customerId;

        private readonly ICustomerManager _customerManager;

        private readonly ILogManager _logManager;

        private readonly Guid? _billId;

        public CustomerBillForm(Guid customerId, string customerName, Guid? billId = null)
        {
            InitializeComponent();

            OnLoad();

            _customerId = customerId;

            _billId = billId;

            lblCustomerName.Text = $@"(Bill for {customerName})";

            _customerManager = new CustomerManager();

            _logManager = new LogManager();

            if (_billId == null || _billId.Value == Guid.Empty) return;

            var billInfo = _customerManager.GetBillInfo(_billId.Value);

            txtBillNumber.Text = Convert.ToString(billInfo.BillNumber);

            cmbBillStatus.SelectedValue = billInfo.BillStatus;

            txtSuitMeasurement.Text = billInfo.SuitMeasurements;
            txtSuitQty.Text = Convert.ToString(billInfo.NumberOfSuits);
            txtSuitRate.Text = Convert.ToString(billInfo.SuitRate, CultureInfo.InvariantCulture);

            txtJacketMeasurement.Text = billInfo.JacketMeasurements;
            txtJacketQty.Text = Convert.ToString(billInfo.NumberOfJackets);
            txtJacketRate.Text = Convert.ToString(billInfo.JacketRate, CultureInfo.InvariantCulture);

            txtSafaryMeasurement.Text = billInfo.SafaryMeasurements;
            txtSafaryQty.Text = Convert.ToString(billInfo.NumberOfSafary);
            txtSafaryRate.Text = Convert.ToString(billInfo.SafaryRate, CultureInfo.InvariantCulture);

            txtTrouserMeasurement.Text = billInfo.TrouserMeasurements;
            txtTrouserQty.Text = Convert.ToString(billInfo.NumberOfTrousers);
            txtTrouserRate.Text = Convert.ToString(billInfo.TrouserRate, CultureInfo.InvariantCulture);

            txtShirtMeasurement.Text = billInfo.ShirtMeasurements;
            txtShirtQty.Text = Convert.ToString(billInfo.NumberOfShirts);
            txtShirtRate.Text = Convert.ToString(billInfo.ShirtRate, CultureInfo.InvariantCulture);

            txtOtherMeasurement.Text = billInfo.OtherMeasurements;
            txtOtherQty.Text = Convert.ToString(billInfo.NumberOfOthers);
            txtOtherRate.Text = Convert.ToString(billInfo.OtherRate, CultureInfo.InvariantCulture);

            txtNote.Text = billInfo.Notes;

            dtBillDt.Value = billInfo.BillDt;
            dtPreferredDeliveryDt.Value = billInfo.PreferredDeliveryDt;

            if (billInfo.PreferredInternalDeliveryDt != null && billInfo.PreferredInternalDeliveryDt.Value != null)
            {
                dtPreferredInternalDeliveryDt.Value = billInfo.PreferredInternalDeliveryDt.Value;
            }

            if (billInfo.SentToTailorDt != null && billInfo.SentToTailorDt.Value != null)
            {
                dtSentToTailor.Value = billInfo.SentToTailorDt.Value;
            }

            if (billInfo.ReadyForDeliveryDt != null && billInfo.ReadyForDeliveryDt.Value != null)
            {
                dtReadyForDeliveryDt.Value = billInfo.ReadyForDeliveryDt.Value;
            }

            if (billInfo.DeliveredDt != null && billInfo.DeliveredDt.Value != null)
            {
                dtDeliveredDt.Value = billInfo.DeliveredDt.Value;
            }

            txtSuitAmount.Text = (Convert.ToInt32(txtSuitQty.Text) * Convert.ToDecimal(txtSuitRate.Text)).
                   ToString("F");

            txtJacketAmount.Text = (Convert.ToInt32(txtJacketQty.Text) * Convert.ToDecimal(txtJacketRate.Text)).
                   ToString("F");

            txtSafaryAmount.Text = (Convert.ToInt32(txtSafaryQty.Text) * Convert.ToDecimal(txtSafaryRate.Text)).
                  ToString("F");

            txtTrouserAmount.Text = (Convert.ToInt32(txtTrouserQty.Text) * Convert.ToDecimal(txtTrouserRate.Text)).
                   ToString("F");

            txtShirtAmount.Text = (Convert.ToInt32(txtShirtQty.Text) * Convert.ToDecimal(txtShirtRate.Text)).
                   ToString("F");

            txtOtherAmount.Text = (Convert.ToInt32(txtOtherQty.Text) * Convert.ToDecimal(txtOtherRate.Text)).
                   ToString("F");

            CalculateTotalAmount();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblBillFormErrorMessage.Text = null;

            if (string.IsNullOrWhiteSpace(txtBillNumber.Text))
            {
                lblBillFormErrorMessage.Text = @"Bill number is required.";

                return;
            }

            var bill = new BillInfo
            {
                CustomerId = _customerId,
                BillNumber = Convert.ToInt32(ConvertToNullIfEmpty(txtBillNumber.Text)),
                BillStatus = cmbBillStatus.SelectedValue.ToString(),

                SuitMeasurements = ConvertToNullIfEmpty(txtSuitMeasurement.Text),
                NumberOfSuits = Convert.ToInt32(ConvertToNullIfEmpty(txtSuitQty.Text)),
                SuitRate = Convert.ToDecimal(ConvertToNullIfEmpty(txtSuitRate.Text)),

                JacketMeasurements = ConvertToNullIfEmpty(txtJacketMeasurement.Text),
                NumberOfJackets = Convert.ToInt32(ConvertToNullIfEmpty(txtJacketQty.Text)),
                JacketRate = Convert.ToDecimal(ConvertToNullIfEmpty(txtJacketRate.Text)),

                SafaryMeasurements = ConvertToNullIfEmpty(txtSafaryMeasurement.Text),
                NumberOfSafary = Convert.ToInt32(ConvertToNullIfEmpty(txtSafaryQty.Text)),
                SafaryRate = Convert.ToDecimal(ConvertToNullIfEmpty(txtSafaryRate.Text)),

                TrouserMeasurements = ConvertToNullIfEmpty(txtTrouserMeasurement.Text),
                NumberOfTrousers = Convert.ToInt32(ConvertToNullIfEmpty(txtTrouserQty.Text)),
                TrouserRate = Convert.ToDecimal(ConvertToNullIfEmpty(txtTrouserRate.Text)),

                ShirtMeasurements = ConvertToNullIfEmpty(txtShirtMeasurement.Text),
                NumberOfShirts = Convert.ToInt32(ConvertToNullIfEmpty(txtShirtQty.Text)),
                ShirtRate = Convert.ToDecimal(ConvertToNullIfEmpty(txtShirtRate.Text)),

                OtherMeasurements = ConvertToNullIfEmpty(txtOtherMeasurement.Text),
                NumberOfOthers = Convert.ToInt32(ConvertToNullIfEmpty(txtOtherQty.Text)),
                OtherRate = Convert.ToDecimal(ConvertToNullIfEmpty(txtOtherRate.Text)),

                Notes = txtNote.Text,

                BillDt = dtBillDt.Value,
                PreferredDeliveryDt = dtPreferredDeliveryDt.Value
            };

            if (dtPreferredInternalDeliveryDt.Value != DateTime.Parse("1/1/1990"))
            {
                bill.PreferredInternalDeliveryDt = dtPreferredInternalDeliveryDt.Value;
            }

            if (dtSentToTailor.Value != DateTime.Parse("1/1/1990"))
            {
                bill.SentToTailorDt = dtSentToTailor.Value;
            }

            if (dtReadyForDeliveryDt.Value != DateTime.Parse("1/1/1990"))
            {
                bill.ReadyForDeliveryDt = dtReadyForDeliveryDt.Value;
            }

            if (dtDeliveredDt.Value != DateTime.Parse("1/1/1990"))
            {
                bill.DeliveredDt = dtDeliveredDt.Value;
            }

            try
            {
                if (_billId == null || _billId.Value == Guid.Empty)
                {
                    _customerManager.AddBillInfo(bill);
                }

                else
                {
                    bill.Id = _billId.Value;

                    _customerManager.UpdateBillInfo(bill);
                }

                Close();
            }

            catch (Exception ex)
            {
                _logManager.LogMessage(ex.Message,
                    ex.InnerException?.ToString());

                lblBillFormErrorMessage.Text = ex.Message;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSuitQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumberOnly(e);
        }

        private void txtSuitRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowDecimalNumberOnly(sender, e);
        }

        private void txtJacketRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowDecimalNumberOnly(sender, e);
        }

        private void txtSafaryRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowDecimalNumberOnly(sender, e);
        }

        private void txtTrouserRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowDecimalNumberOnly(sender, e);
        }

        private void txtShirtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowDecimalNumberOnly(sender, e);
        }

        private void txtOtherRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowDecimalNumberOnly(sender, e);
        }

        private void txtJacketQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumberOnly(e);
        }

        private void txtSafaryQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumberOnly(e);
        }

        private void txtTrouserQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumberOnly(e);
        }

        private void txtShirtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumberOnly(e);
        }

        private void txtOtherQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumberOnly(e);
        }

        private void txtSuitQty_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSuitQty.Text) &&
                !string.IsNullOrWhiteSpace(txtSuitRate.Text))
            {
                txtSuitAmount.Text = (Convert.ToInt32(txtSuitQty.Text)*Convert.ToDecimal(txtSuitRate.Text)).
                    ToString("F");
            }
        }

        private void txtSuitRate_Validated(object sender, EventArgs e)
        {
            txtSuitQty_Validated(sender, e);
        }

        private void txtJacketQty_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtJacketQty.Text) &&
                !string.IsNullOrWhiteSpace(txtJacketRate.Text))
            {
                txtJacketAmount.Text = (Convert.ToInt32(txtJacketQty.Text)*Convert.ToDecimal(txtJacketRate.Text)).
                    ToString("F");
            }
        }

        private void txtJacketRate_Validated(object sender, EventArgs e)
        {
            txtJacketQty_Validated(sender, e);
        }

        private void txtSafaryQty_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSafaryQty.Text) &&
                !string.IsNullOrWhiteSpace(txtSafaryRate.Text))
            {
                txtSafaryAmount.Text = (Convert.ToInt32(txtSafaryQty.Text)*Convert.ToDecimal(txtSafaryRate.Text)).
                    ToString("F");
            }
        }

        private void txtSafaryRate_Validated(object sender, EventArgs e)
        {
            txtSafaryQty_Validated(sender, e);
        }

        private void txtTrouserQty_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTrouserQty.Text) &&
                !string.IsNullOrWhiteSpace(txtTrouserRate.Text))
            {
                txtTrouserAmount.Text = (Convert.ToInt32(txtTrouserQty.Text)*Convert.ToDecimal(txtTrouserRate.Text)).
                    ToString("F");
            }
        }

        private void txtTrouserRate_Validated(object sender, EventArgs e)
        {
            txtTrouserQty_Validated(sender, e);
        }

        private void txtShirtQty_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtShirtQty.Text) &&
                !string.IsNullOrWhiteSpace(txtShirtRate.Text))
            {
                txtShirtAmount.Text = (Convert.ToInt32(txtShirtQty.Text)*Convert.ToDecimal(txtShirtRate.Text)).
                    ToString("F");
            }
        }

        private void txtShirtRate_Validated(object sender, EventArgs e)
        {
            txtShirtQty_Validated(sender, e);
        }

        private void txtOtherQty_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtOtherQty.Text) &&
                !string.IsNullOrWhiteSpace(txtOtherRate.Text))
            {
                txtOtherAmount.Text = (Convert.ToInt32(txtOtherQty.Text)*Convert.ToDecimal(txtOtherRate.Text)).
                    ToString("F");
            }
        }

        private void txtOtherRate_Validated(object sender, EventArgs e)
        {
            txtOtherQty_Validated(sender, e);
        }

        private void txtSuitAmount_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }

        private void txtJacketAmount_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }

        private void txtSafaryAmount_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }

        private void txtTrouserAmount_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }

        private void txtShirtAmount_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }

        private void txtOtherAmount_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }

        private void txtBillNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumberOnly(e);
        }

        #region Internal Members

        private static void AllowNumberOnly(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private static void AllowDecimalNumberOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            var textBox = sender as TextBox;

            if (textBox != null && ((e.KeyChar == '.') && (textBox.Text.IndexOf('.') > -1)))
            {
                e.Handled = true;
            }
        }

        private void CalculateTotalAmount()
        {
            var total = 0.00M;

            if (!string.IsNullOrWhiteSpace(txtSuitAmount.Text))
            {
                total += Convert.ToDecimal(txtSuitAmount.Text);
            }

            if (!string.IsNullOrWhiteSpace(txtJacketAmount.Text))
            {
                total += Convert.ToDecimal(txtJacketAmount.Text);
            }

            if (!string.IsNullOrWhiteSpace(txtSafaryAmount.Text))
            {
                total += Convert.ToDecimal(txtSafaryAmount.Text);
            }

            if (!string.IsNullOrWhiteSpace(txtTrouserAmount.Text))
            {
                total += Convert.ToDecimal(txtTrouserAmount.Text);
            }

            if (!string.IsNullOrWhiteSpace(txtShirtAmount.Text))
            {
                total += Convert.ToDecimal(txtShirtAmount.Text);
            }

            if (!string.IsNullOrWhiteSpace(txtOtherAmount.Text))
            {
                total += Convert.ToDecimal(txtOtherAmount.Text);
            }

            txtTotalAmount.Text = total.ToString("F");
        }

        private static string ConvertToNullIfEmpty(string obj)
        {
            return string.IsNullOrWhiteSpace(obj) ? null : obj;
        }

        #endregion

        private void OnLoad()
        {
            dtBillDt.Value = TimeHelper.GetCurrentDateTime();
            dtPreferredDeliveryDt.Value = TimeHelper.GetCurrentDateTime().AddDays(5);

            cmbBillStatus.DataSource = new[]
            {
                new ComboItem
                {
                    Id = BillStatus.WaitingForPickup.ToString(),
                    Text = BillStatus.WaitingForPickup.ToString()
                },

                new ComboItem
                {
                    Id = BillStatus.InStitching.ToString(),
                    Text = BillStatus.InStitching.ToString()
                },

                new ComboItem
                {
                    Id = BillStatus.ReadyForDelivery.ToString(),
                    Text = BillStatus.ReadyForDelivery.ToString()
                },

                new ComboItem
                {
                    Id = BillStatus.Delivered.ToString(),
                    Text = BillStatus.Delivered.ToString()
                }
            };
        }
    }
}
