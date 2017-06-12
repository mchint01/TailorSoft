using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using TailorSoft.Business;
using TailorSoft.Business.Interfaces;
using TailorSoft.Business.Models;

namespace TailorSoft
{
    public partial class AccountForm : Form
    {
        private readonly ICustomerManager _customerManager;

        public AccountForm()
        {
            InitializeComponent();

            OnLoad();

            _customerManager = new CustomerManager();
        }

        private void OnLoad()
        {
            var years = new List<ComboItem>();

            var currentMonth = TimeHelper.GetCurrentDateTime().Month;
            var currentYear = TimeHelper.GetCurrentDateTime().Year;

            for (var year = 1990; year <= currentYear + 2; year++)
            {
                years.Add(new ComboItem
                {
                    Id = year.ToString(),
                    Text = year.ToString()
                });
            }

            cmbYear.DataSource = years;

            cmbYear.SelectedValue = currentYear.ToString();

            cmbMonths.DataSource = new[]
            {
                new ComboItem
                {
                    Id = "1",
                    Text = "January"
                },
                new ComboItem
                {
                    Id = "2",
                    Text = "February"
                },
                new ComboItem
                {
                    Id = "3",
                    Text = "March"
                },
                new ComboItem
                {
                    Id = "4",
                    Text = "April"
                },
                new ComboItem
                {
                    Id = "5",
                    Text = "May"
                },
                new ComboItem
                {
                    Id = "6",
                    Text = "June"
                },
                new ComboItem
                {
                    Id = "7",
                    Text = "July"
                },
                new ComboItem
                {
                    Id = "8",
                    Text = "August"
                },
                new ComboItem
                {
                    Id = "9",
                    Text = "September"
                },
                new ComboItem
                {
                    Id = "10",
                    Text = "October"
                },
                new ComboItem
                {
                    Id = "11",
                    Text = "November"
                },
                new ComboItem
                {
                    Id = "12",
                    Text = "December"
                }
            };

            cmbMonths.SelectedValue = currentMonth.ToString();

            lblFilePath.Text = $@"Excel reports are located at {ConfigurationManager.AppSettings["ExportPath"]}";
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            lblAccountsErrorMessage.Text = null;
            lblAccountsErrorMessage.Visible = false;
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                var startDate = new DateTime(
                    Convert.ToInt32(cmbYear.SelectedValue),
                    Convert.ToInt32(cmbMonths.SelectedValue),
                    1);

                var endDate = new DateTime(Convert.ToInt32(cmbYear.SelectedValue),
                    Convert.ToInt32(cmbMonths.SelectedValue),
                    DateTime.DaysInMonth(Convert.ToInt32(cmbYear.SelectedValue),
                        Convert.ToInt32(cmbMonths.SelectedValue)), 23, 59, 59
                );

                var file = _customerManager.ExportMonthlyBillDetailsAsExcel(startDate, endDate);

                var fs = new FileStream(
                    Path.Combine(ConfigurationManager.AppSettings["ExportPath"], file.FileName),
                    FileMode.Create);

                var bw = new BinaryWriter(fs);

                bw.Write(file.Data, 0, file.Data.Length);
                bw.Flush();
                bw.Close();
                fs.Close();

                Cursor.Current = Cursors.Arrow;

                Close();

                // opens folder
                Process.Start(ConfigurationManager.AppSettings["ExportPath"]);
            }

            catch (Exception ex)
            {
                Cursor.Current = Cursors.Arrow;

                lblAccountsErrorMessage.Visible = true;
                lblAccountsErrorMessage.Text = ex.Message;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
