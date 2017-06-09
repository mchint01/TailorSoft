﻿using System;
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

        void AddBillInfo(BillInfo billInfo);

        void UpdateBillInfo(BillInfo billInfo);

        BillInfo GetBillInfo(Guid billId);

        IList<BillInfo> GetCustomerBills(Guid customerId);

        FileExportResponse ExportMonthlyBillDetailsAsExcel(DateTime start, DateTime end);
    }
}