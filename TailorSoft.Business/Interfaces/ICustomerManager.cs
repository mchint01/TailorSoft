using System;
using System.Collections.Generic;
using TailorSoft.Business.Models;

namespace TailorSoft.Business.Interfaces
{
    public interface ICustomerManager
    {
        CustomerInfo GetCustomerInfo(string phoneNumber);

        CustomerInfo GetCustomerInfo(Guid customerId);

        void AddCustomerInfo(CustomerInfo customerInfo);

        void UpdateCustomerInfo(CustomerInfo customerInfo);

        Guid AddBillInfo(BillInfo billInfo);

        void UpdateBillInfo(BillInfo billInfo);

        BillInfo GetBillInfo(Guid billId);

        IList<BillInfo> GetCustomerBills(Guid customerId);

        IList<BillInfo> GetBills(int billNumber);

        IDictionary<Guid, string> GetCustomerNames(IList<Guid> customerIds);

        FileExportResponse ExportMonthlyBillDetailsAsExcel(DateTime start, DateTime end);

        Measurements GetLatestCustomerMeasurements(Guid customerId);
    }
}
