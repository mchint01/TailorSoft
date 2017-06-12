using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using TailorSoft.Business.Interfaces;
using TailorSoft.Business.Models;
using TailorSoft.Database;

namespace TailorSoft.Business
{
    public class CustomerManager: ICustomerManager
    {
        private const int ExpCustomerNameColIndex = 0;
        private const int ExpBillNumberColIndex = 1;
        private const int ExpBillDtColIndex = 2;
        private const int ExpBillStatusColIndex = 3;
        private const int ExpNumberOfSuitsColIndex = 4;
        private const int ExpSuitRateColIndex = 5;
        private const int ExpAmountForSuitsColIndex = 6;
        private const int ExpNumberOfJacketsColIndex = 7;
        private const int ExpJacketRateColIndex = 8;
        private const int ExpAmountForJacketsColIndex = 9;
        private const int ExpNumberOfSafaryColIndex = 10;
        private const int ExpSafaryRateColIndex = 11;
        private const int ExpAmountForSafariesColIndex = 12;
        private const int ExpNumberOfTrousersColIndex = 13;
        private const int ExpTrouserRateColIndex = 14;
        private const int ExpAmountForTrousersColIndex = 15;
        private const int ExpNumberOfShirtsColIndex = 16;
        private const int ExpShirtRateColIndex = 17;
        private const int ExpAmountForShirtsColIndex = 18;
        private const int ExpNumberOfOthersColIndex = 19;
        private const int ExpOtherRateColIndex = 20;
        private const int ExpAmountForOthersColIndex = 21;
        private const int ExpCustomerIdColIndex = 22;
        private const int ExpBillIdColIndex = 23;
        private const int ExpTotalColCount = 24;

        private const int ExpBookingSummaryNameColIndex = 0;
        private const int ExpBookingSummaryQtyColIndex = 1;
        private const int ExpBookingSummaryAmountColIndex = 2;
        private const int ExpBookingSummaryTotalColCount = 3;

        private const int ExpDeliveredSummaryNameColIndex = 0;
        private const int ExpDeliveredSummaryQtyColIndex = 1;
        private const int ExpDeliveredSummaryAmountColIndex = 2;
        private const int ExpDeliveredSummaryTotalColCount = 3;

        private readonly ILogManager _logManager;

        public CustomerManager()
        {
            _logManager = new LogManager();
        }

        public CustomerInfo GetCustomerInfo(string phoneNumber)
        {
            using (var db = new ApplicationDbContext())
            {
                var customer =
                    db.Customers.AsNoTracking()
                        .FirstOrDefault(x => x.PrimaryPhone == phoneNumber);

                if (customer == null)
                {
                    return null;
                }

                return new CustomerInfo
                {
                    Id = customer.Id,
                    Name = customer.Name,
                    Address = customer.Address,
                    Phone = customer.PrimaryPhone
                };
            }
        }

        public CustomerInfo GetCustomerInfo(Guid customerId)
        {
            using (var db = new ApplicationDbContext())
            {
                var customer =
                    db.Customers.AsNoTracking()
                        .FirstOrDefault(x => x.Id == customerId);

                if (customer == null)
                {
                    throw new Exception("Customer record not found.");
                }

                return new CustomerInfo
                {
                    Id = customer.Id,
                    Name = customer.Name,
                    Address = customer.Address,
                    Phone = customer.PrimaryPhone
                };
            }
        }

        public void AddCustomerInfo(CustomerInfo customerInfo)
        {
            using (var db = new ApplicationDbContext())
            {
                var customerExists =
                    db.Customers.AsNoTracking()
                        .FirstOrDefault(x => x.PrimaryPhone == customerInfo.Phone);

                if (customerExists != null)
                {
                    throw new Exception($"Customer with phone {customerInfo.Phone} already exists");
                }

                db.Customers.Add(new Database.Models.Customer
                {
                    Id = Guid.NewGuid(),
                    CreatedDt = TimeHelper.GetCurrentDateTime(),
                    Name = customerInfo.Name,
                    Address = customerInfo.Address,
                    PrimaryPhone = customerInfo.Phone
                });

                db.SaveChanges();
            }
        }

        public void UpdateCustomerInfo(CustomerInfo customerInfo)
        {
            using (var db = new ApplicationDbContext())
            {
                var customer =
                    db.Customers
                        .FirstOrDefault(x => x.Id == customerInfo.Id);

                if (customer == null)
                {
                    throw new Exception($"Customer record with phone {customerInfo.Phone} not found.");
                }

                customer.Name = customerInfo.Name;
                customer.Address = customerInfo.Address;
                customer.PrimaryPhone = customerInfo.Phone;

                db.SaveChanges();
            }
        }

        public void AddBillInfo(BillInfo billInfo)
        {
            using (var db = new ApplicationDbContext())
            {
                var customer =
                    db.Customers.AsNoTracking().FirstOrDefault(x => x.Id == billInfo.CustomerId);

                if (customer == null)
                {
                    throw new Exception("Customer record not found.");
                }

                db.Bills.Add(new Database.Models.Bill
                {
                    Id = Guid.NewGuid(),
                    BillNumber = billInfo.BillNumber,
                    CustomerId = billInfo.CustomerId,
                    CreatedDt = TimeHelper.GetCurrentDateTime(),
                    BillStatus = billInfo.BillStatus,
                    BillDt = billInfo.BillDt,
                    PreferredDeliveryDt = billInfo.PreferredDeliveryDt,
                    Notes = billInfo.Notes,

                    SuitMeasurements = billInfo.SuitMeasurements,
                    NumberOfSuits = billInfo.NumberOfSuits,
                    SuitRate = billInfo.SuitRate,

                    JacketMeasurements = billInfo.JacketMeasurements,
                    NumberOfJackets = billInfo.NumberOfJackets,
                    JacketRate = billInfo.JacketRate,

                    SafaryMeasurements = billInfo.SafaryMeasurements,
                    NumberOfSafary = billInfo.NumberOfSafary,
                    SafaryRate = billInfo.SafaryRate,

                    TrouserMeasurements = billInfo.TrouserMeasurements,
                    NumberOfTrousers = billInfo.NumberOfTrousers,
                    TrouserRate = billInfo.TrouserRate,

                    ShirtMeasurements = billInfo.ShirtMeasurements,
                    NumberOfShirts = billInfo.NumberOfShirts,
                    ShirtRate = billInfo.ShirtRate,

                    OtherMeasurements = billInfo.OtherMeasurements,
                    NumberOfOthers = billInfo.NumberOfOthers,
                    OtherRate = billInfo.OtherRate,

                    PreferredInternalDeliveryDt = billInfo.PreferredInternalDeliveryDt,
                    SentToTailorDt = billInfo.SentToTailorDt,
                    ReadyForDeliveryDt = billInfo.ReadyForDeliveryDt,
                    DeliveredDt = billInfo.DeliveredDt
                });

                db.SaveChanges();
            }
        }

        public void UpdateBillInfo(BillInfo billInfo)
        {
            using (var db = new ApplicationDbContext())
            {
                var bill =
                  db.Bills.FirstOrDefault(x => x.Id == billInfo.Id);

                if (bill == null)
                {
                    throw new Exception("Customer bill record not found.");
                }

                bill.BillNumber = billInfo.BillNumber;
                bill.BillStatus = billInfo.BillStatus;
                bill.BillDt = billInfo.BillDt;
                bill.PreferredDeliveryDt = billInfo.PreferredDeliveryDt;
                bill.Notes = billInfo.Notes;

                bill.SuitMeasurements = billInfo.SuitMeasurements;
                bill.NumberOfSuits = billInfo.NumberOfSuits;
                bill.SuitRate = billInfo.SuitRate;

                bill.JacketMeasurements = billInfo.JacketMeasurements;
                bill.NumberOfJackets = billInfo.NumberOfJackets;
                bill.JacketRate = billInfo.JacketRate;

                bill.SafaryMeasurements = billInfo.SafaryMeasurements;
                bill.NumberOfSafary = billInfo.NumberOfSafary;
                bill.SafaryRate = billInfo.SafaryRate;

                bill.TrouserMeasurements = billInfo.TrouserMeasurements;
                bill.NumberOfTrousers = billInfo.NumberOfTrousers;
                bill.TrouserRate = billInfo.TrouserRate;

                bill.ShirtMeasurements = billInfo.ShirtMeasurements;
                bill.NumberOfShirts = billInfo.NumberOfShirts;
                bill.ShirtRate = billInfo.ShirtRate;

                bill.OtherMeasurements = billInfo.OtherMeasurements;
                bill.NumberOfOthers = billInfo.NumberOfOthers;
                bill.OtherRate = billInfo.OtherRate;

                bill.PreferredInternalDeliveryDt = billInfo.PreferredInternalDeliveryDt;
                bill.SentToTailorDt = billInfo.SentToTailorDt;
                bill.ReadyForDeliveryDt = billInfo.ReadyForDeliveryDt;
                bill.DeliveredDt = billInfo.DeliveredDt;

                db.SaveChanges();
            }
        }

        public BillInfo GetBillInfo(Guid billId)
        {
            using (var db = new ApplicationDbContext())
            {
                var bill =
                    db.Bills
                        .AsNoTracking().FirstOrDefault(x => x.Id == billId);

                if (bill == null)
                {
                    throw new Exception("Customer bill record not found.");
                }

                var customer = db.Customers.First(x => x.Id == bill.CustomerId);

                return new BillInfo
                {
                    BillDt = bill.BillDt,
                    BillNumber = bill.BillNumber,
                    BillStatus = bill.BillStatus,
                    CustomerId =bill.CustomerId,
                    CustomerName = customer.Name,
                    DeliveredDt = bill.DeliveredDt,
                    Id = bill.Id,
                    Notes = bill.Notes,

                    JacketMeasurements = bill.JacketMeasurements,
                    NumberOfJackets = bill.NumberOfJackets,
                    JacketRate = bill.JacketRate,

                    SuitMeasurements = bill.SuitMeasurements,
                    NumberOfSuits = bill.NumberOfSuits,
                    SuitRate = bill.SuitRate,

                    SafaryMeasurements = bill.SafaryMeasurements,
                    NumberOfSafary = bill.NumberOfSafary,
                    SafaryRate = bill.SafaryRate,

                    TrouserMeasurements = bill.TrouserMeasurements,
                    NumberOfTrousers = bill.NumberOfTrousers,
                    TrouserRate = bill.TrouserRate,

                    ShirtMeasurements = bill.ShirtMeasurements,
                    NumberOfShirts = bill.NumberOfShirts,
                    ShirtRate =bill.ShirtRate,

                    OtherMeasurements = bill.OtherMeasurements,
                    NumberOfOthers = bill.NumberOfOthers,
                    OtherRate = bill.OtherRate,

                    PreferredInternalDeliveryDt = bill.PreferredInternalDeliveryDt,
                    SentToTailorDt = bill.SentToTailorDt,
                    PreferredDeliveryDt = bill.PreferredDeliveryDt,
                    ReadyForDeliveryDt = bill.ReadyForDeliveryDt
                };
            }
        }

        public IList<BillInfo> GetCustomerBills(Guid customerId)
        {
            var list = new List<BillInfo>();

            using (var db = new ApplicationDbContext())
            {
                var bills =
                    db.Bills.AsNoTracking().Where(x => x.CustomerId == customerId).OrderByDescending(x => x.BillNumber);

                foreach (var bill in bills)
                {
                    list.Add(new BillInfo
                    {
                        BillDt = bill.BillDt,
                        BillNumber = bill.BillNumber,
                        BillStatus = bill.BillStatus,
                        CustomerId = bill.CustomerId,
                        DeliveredDt = bill.DeliveredDt,
                        Id = bill.Id,
                        Notes = bill.Notes,

                        JacketMeasurements = bill.JacketMeasurements,
                        NumberOfJackets = bill.NumberOfJackets,
                        JacketRate = bill.JacketRate,

                        SuitMeasurements = bill.SuitMeasurements,
                        NumberOfSuits = bill.NumberOfSuits,
                        SuitRate = bill.SuitRate,

                        SafaryMeasurements = bill.SafaryMeasurements,
                        NumberOfSafary = bill.NumberOfSafary,
                        SafaryRate = bill.SafaryRate,

                        TrouserMeasurements = bill.TrouserMeasurements,
                        NumberOfTrousers = bill.NumberOfTrousers,
                        TrouserRate = bill.TrouserRate,

                        ShirtMeasurements = bill.ShirtMeasurements,
                        NumberOfShirts = bill.NumberOfShirts,
                        ShirtRate = bill.ShirtRate,

                        OtherMeasurements = bill.OtherMeasurements,
                        NumberOfOthers = bill.NumberOfOthers,
                        OtherRate = bill.OtherRate,

                        PreferredInternalDeliveryDt = bill.PreferredInternalDeliveryDt,
                        PreferredDeliveryDt = bill.PreferredDeliveryDt,
                        ReadyForDeliveryDt = bill.ReadyForDeliveryDt,
                        SentToTailorDt = bill.SentToTailorDt
                    });
                }
            }

            return list;
        }

        public FileExportResponse ExportMonthlyBillDetailsAsExcel(DateTime start,
            DateTime end)
        {
            var ms = new MemoryStream();

            using (var db = new ApplicationDbContext())
            {
                try
                {
                    var bookingBills = db.Database.SqlQuery<ExportBillInfo>(
                        "EXEC [dbo].[spGetMonthlyBookingBillDetails] @param1, @param2",
                        new SqlParameter("param1", start),
                        new SqlParameter("param2", end)
                    ).ToList();

                    var billsDelivered = db.Database.SqlQuery<ExportBillInfo>(
                        "EXEC [dbo].[spGetMonthlyDeliveredBillDetails] @param1, @param2",
                        new SqlParameter("param1", start),
                        new SqlParameter("param2", end)
                    ).ToList();

                    var wb = new XSSFWorkbook();

                    var sheetBookingBillsSummary =
                        wb.CreateSheet($"TailorSoft Booking Bills Summary From {start} to {end}");
                    var sheetDeliveryBillsSummary =
                        wb.CreateSheet($"TailorSoft Delivered Bills Summary From {start} to {end}");
                    var sheetBookingBills =
                        wb.CreateSheet($"TailorSoft Booking Bills From {start} to {end}");

                    SetExcelSheetHeadersBookingBillsDetails(sheetBookingBills);
                    SetExcelSheetStylesBookingBillsDetails(sheetBookingBills);

                    SetExcelSheetHeadersBookingBillsSummary(sheetBookingBillsSummary);
                    SetExcelSheetStylesBookingBillsSummary(sheetBookingBillsSummary);

                    SetExcelSheetHeadersDeliveryBillsSummary(sheetDeliveryBillsSummary);
                    SetExcelSheetStylesDeliveryBillsSummary(sheetDeliveryBillsSummary);

                    // sheetBookingBills

                    #region Booking Details

                    var rowNumber = 0;

                    foreach (var bill in bookingBills)
                    {
                        rowNumber++;

                        var row = sheetBookingBills.CreateRow(rowNumber);

                        for (var colNumber = 0; colNumber < ExpTotalColCount; colNumber++)
                        {
                            row.CreateCell(colNumber, NPOI.SS.UserModel.CellType.String);
                        }

                        row.GetCell(ExpCustomerNameColIndex).SetCellValue(bill.CustomerName);
                        row.GetCell(ExpBillNumberColIndex).SetCellValue(bill.BillNumber);
                        row.GetCell(ExpBillDtColIndex).SetCellValue(bill.BillDt.ToString("MMMM dd, yyyy"));
                        row.GetCell(ExpBillStatusColIndex).SetCellValue(bill.BillStatus);

                        row.GetCell(ExpNumberOfSuitsColIndex).SetCellValue(bill.NumberOfSuits);
                        row.GetCell(ExpSuitRateColIndex).SetCellValue(Convert.ToDouble(bill.SuitRate));
                        row.GetCell(ExpAmountForSuitsColIndex).SetCellValue(Convert.ToDouble(bill.AmountForSuits));

                        row.GetCell(ExpNumberOfJacketsColIndex).SetCellValue(bill.NumberOfJackets);
                        row.GetCell(ExpJacketRateColIndex).SetCellValue(Convert.ToDouble(bill.JacketRate));
                        row.GetCell(ExpAmountForJacketsColIndex).SetCellValue(Convert.ToDouble(bill.AmountForJackets));

                        row.GetCell(ExpNumberOfSafaryColIndex).SetCellValue(bill.NumberOfSafary);
                        row.GetCell(ExpSafaryRateColIndex).SetCellValue(Convert.ToDouble(bill.SafaryRate));
                        row.GetCell(ExpAmountForSafariesColIndex).SetCellValue(Convert.ToDouble(bill.AmountForSafaries));

                        row.GetCell(ExpNumberOfTrousersColIndex).SetCellValue(bill.NumberOfTrousers);
                        row.GetCell(ExpTrouserRateColIndex).SetCellValue(Convert.ToDouble(bill.TrouserRate));
                        row.GetCell(ExpAmountForTrousersColIndex).SetCellValue(Convert.ToDouble(bill.AmountForTrousers));

                        row.GetCell(ExpNumberOfShirtsColIndex).SetCellValue(bill.NumberOfShirts);
                        row.GetCell(ExpShirtRateColIndex).SetCellValue(Convert.ToDouble(bill.ShirtRate));
                        row.GetCell(ExpAmountForShirtsColIndex).SetCellValue(Convert.ToDouble(bill.AmountForShirts));

                        row.GetCell(ExpNumberOfOthersColIndex).SetCellValue(bill.NumberOfOthers);
                        row.GetCell(ExpOtherRateColIndex).SetCellValue(Convert.ToDouble(bill.OtherRate));
                        row.GetCell(ExpAmountForOthersColIndex).SetCellValue(Convert.ToDouble(bill.AmountForOthers));

                        row.GetCell(ExpCustomerIdColIndex).SetCellValue(bill.CustomerId.ToString());
                        row.GetCell(ExpBillIdColIndex).SetCellValue(bill.BillId.ToString());
                    }

                    #endregion

                    // sheetBookingBillsSummary

                    #region Booking Summary

                    rowNumber = 0;

                    var billsBookingSummary = new List<ExportBillSummary>
                    {
                        new ExportBillSummary
                        {
                            Name = "SUITS",
                            Quantity = bookingBills.Sum(x => x.NumberOfSuits),
                            Amount = bookingBills.Sum(x => x.AmountForSuits)
                        },
                        new ExportBillSummary
                        {
                            Name = "JACKETS",
                            Quantity = bookingBills.Sum(x => x.NumberOfJackets),
                            Amount = bookingBills.Sum(x => x.AmountForJackets)
                        },
                        new ExportBillSummary
                        {
                            Name = "SAFARIES",
                            Quantity = bookingBills.Sum(x => x.NumberOfSafary),
                            Amount = bookingBills.Sum(x => x.AmountForSafaries)
                        },
                        new ExportBillSummary
                        {
                            Name = "TROUSERS",
                            Quantity = bookingBills.Sum(x => x.NumberOfTrousers),
                            Amount = bookingBills.Sum(x => x.AmountForTrousers)
                        },
                        new ExportBillSummary
                        {
                            Name = "SHIRTS",
                            Quantity = bookingBills.Sum(x => x.NumberOfShirts),
                            Amount = bookingBills.Sum(x => x.AmountForShirts)
                        },
                        new ExportBillSummary
                        {
                            Name = "OTHERS",
                            Quantity = bookingBills.Sum(x => x.NumberOfOthers),
                            Amount = bookingBills.Sum(x => x.AmountForOthers)
                        }
                    };

                    var totalQtyBookingSummary = billsBookingSummary.Sum(x => x.Quantity);
                    var totalAmountBookingSummary = billsBookingSummary.Sum(x => x.Amount);

                    billsBookingSummary.Add(new ExportBillSummary
                    {
                        Name = "TOTAL",
                        Quantity = totalQtyBookingSummary,
                        Amount = totalAmountBookingSummary
                    });

                    foreach (var summary in billsBookingSummary)
                    {
                        rowNumber++;

                        var row = sheetBookingBillsSummary.CreateRow(rowNumber);

                        for (var colNumber = 0; colNumber < ExpBookingSummaryTotalColCount; colNumber++)
                        {
                            row.CreateCell(colNumber, NPOI.SS.UserModel.CellType.String);
                        }

                        row.GetCell(ExpBookingSummaryNameColIndex).SetCellValue(summary.Name);
                        row.GetCell(ExpBookingSummaryQtyColIndex).SetCellValue(summary.Quantity);
                        row.GetCell(ExpBookingSummaryAmountColIndex).SetCellValue(Convert.ToDouble(summary.Amount));
                    }

                    #endregion

                    // sheetDeliveryBillsSummary

                    #region Delivery Summary

                    rowNumber = 0;

                    var billsDeliveredSummary = new List<ExportBillSummary>
                    {
                        new ExportBillSummary
                        {
                            Name = "SUITS",
                            Quantity = billsDelivered.Sum(x => x.NumberOfSuits),
                            Amount = billsDelivered.Sum(x => x.AmountForSuits)
                        },
                        new ExportBillSummary
                        {
                            Name = "JACKETS",
                            Quantity = billsDelivered.Sum(x => x.NumberOfJackets),
                            Amount = billsDelivered.Sum(x => x.AmountForJackets)
                        },
                        new ExportBillSummary
                        {
                            Name = "SAFARIES",
                            Quantity = billsDelivered.Sum(x => x.NumberOfSafary),
                            Amount = billsDelivered.Sum(x => x.AmountForSafaries)
                        },
                        new ExportBillSummary
                        {
                            Name = "TROUSERS",
                            Quantity = billsDelivered.Sum(x => x.NumberOfTrousers),
                            Amount = billsDelivered.Sum(x => x.AmountForTrousers)
                        },
                        new ExportBillSummary
                        {
                            Name = "SHIRTS",
                            Quantity = billsDelivered.Sum(x => x.NumberOfShirts),
                            Amount = billsDelivered.Sum(x => x.AmountForShirts)
                        },
                        new ExportBillSummary
                        {
                            Name = "OTHERS",
                            Quantity = billsDelivered.Sum(x => x.NumberOfOthers),
                            Amount = billsDelivered.Sum(x => x.AmountForOthers)
                        }
                    };

                    var totalQtyDeliveredSummary = billsDeliveredSummary.Sum(x => x.Quantity);
                    var totalAmountDeliveredSummary = billsDeliveredSummary.Sum(x => x.Amount);

                    billsDeliveredSummary.Add(new ExportBillSummary
                    {
                        Name = "TOTAL",
                        Quantity = totalQtyDeliveredSummary,
                        Amount = totalAmountDeliveredSummary
                    });

                    foreach (var summary in billsDeliveredSummary)
                    {
                        rowNumber++;

                        var row = sheetDeliveryBillsSummary.CreateRow(rowNumber);

                        for (var colNumber = 0; colNumber < ExpDeliveredSummaryTotalColCount; colNumber++)
                        {
                            row.CreateCell(colNumber, NPOI.SS.UserModel.CellType.String);
                        }

                        row.GetCell(ExpDeliveredSummaryNameColIndex).SetCellValue(summary.Name);
                        row.GetCell(ExpDeliveredSummaryQtyColIndex).SetCellValue(summary.Quantity);
                        row.GetCell(ExpDeliveredSummaryAmountColIndex).SetCellValue(Convert.ToDouble(summary.Amount));
                    }


                    #endregion

                    wb.Write(ms);

                    return new FileExportResponse()
                    {
                        Data = ms.ToArray(),
                        FileName =
                            string.Format(
                                $"TailorSoft Bills From {start.ToString("yyyy-dd-M--HH-mm-ss")} to {end.ToString("yyyy-dd-M--HH-mm-ss")}.xlsx")
                    };
                }

                catch (Exception ex)
                {
                    _logManager.LogMessage("EXPORT FAILED - " + ex.Message,
                        ex.InnerException != null ? ex.InnerException.ToString() : null);

                    throw new Exception("Error occurred while exporting monthly bills.");
                }
            }
        }

        #region Private Members

        private static void SetExcelSheetHeadersBookingBillsDetails(ISheet sh)
        {
            var headerRow = sh.CreateRow(0);

            for (var colNumber = 0; colNumber < ExpTotalColCount; colNumber++)
            {
                headerRow.CreateCell(colNumber, NPOI.SS.UserModel.CellType.String);
            }

            headerRow.GetCell(ExpCustomerNameColIndex).SetCellValue("Customer Name");
            headerRow.GetCell(ExpBillNumberColIndex).SetCellValue("Bill Number");
            headerRow.GetCell(ExpBillDtColIndex).SetCellValue("Bill Date");
            headerRow.GetCell(ExpBillStatusColIndex).SetCellValue("Bill Status");

            headerRow.GetCell(ExpNumberOfSuitsColIndex).SetCellValue("Number of Suits");
            headerRow.GetCell(ExpSuitRateColIndex).SetCellValue("Suit Rate");
            headerRow.GetCell(ExpAmountForSuitsColIndex).SetCellValue("Amount for Suits");

            headerRow.GetCell(ExpNumberOfJacketsColIndex).SetCellValue("Number of Jackets");
            headerRow.GetCell(ExpJacketRateColIndex).SetCellValue("Jacket Rate");
            headerRow.GetCell(ExpAmountForJacketsColIndex).SetCellValue("Amount for Jackets");

            headerRow.GetCell(ExpNumberOfSafaryColIndex).SetCellValue("Number of Safaries");
            headerRow.GetCell(ExpSafaryRateColIndex).SetCellValue("Safary Rate");
            headerRow.GetCell(ExpAmountForSafariesColIndex).SetCellValue("Amount for Safaries");

            headerRow.GetCell(ExpNumberOfTrousersColIndex).SetCellValue("Number of Trousers");
            headerRow.GetCell(ExpTrouserRateColIndex).SetCellValue("Trouser Rate");
            headerRow.GetCell(ExpAmountForTrousersColIndex).SetCellValue("Amount for Trousers");

            headerRow.GetCell(ExpNumberOfShirtsColIndex).SetCellValue("Number of Shirts");
            headerRow.GetCell(ExpShirtRateColIndex).SetCellValue("Shirt Rate");
            headerRow.GetCell(ExpAmountForShirtsColIndex).SetCellValue("Amount for Shirts");

            headerRow.GetCell(ExpNumberOfOthersColIndex).SetCellValue("Number of Others");
            headerRow.GetCell(ExpOtherRateColIndex).SetCellValue("Other Rate");
            headerRow.GetCell(ExpAmountForOthersColIndex).SetCellValue("Amount for Others");

            headerRow.GetCell(ExpCustomerIdColIndex).SetCellValue("Internal Customer ID");
            headerRow.GetCell(ExpBillIdColIndex).SetCellValue("Internal Bill ID");
        }

        private static void SetExcelSheetStylesBookingBillsDetails(ISheet sh)
        {
            // 0.72 is base width of column
            // 1/256 character factor
            sh.SetColumnWidth(ExpCustomerNameColIndex, (int) ((50 + 0.72)*256));
            sh.SetColumnWidth(ExpBillNumberColIndex, (int) ((11 + 0.72)*256));
            sh.SetColumnWidth(ExpBillDtColIndex, (int) ((50 + 0.72)*256));
            sh.SetColumnWidth(ExpBillStatusColIndex, (int) ((30 + 0.72)*256));

            sh.SetColumnWidth(ExpNumberOfSuitsColIndex, (int) ((18 + 0.72)*256));
            sh.SetColumnWidth(ExpSuitRateColIndex, (int) ((15 + 0.72)*256));
            sh.SetColumnWidth(ExpAmountForSuitsColIndex, (int) ((30 + 0.72)*256));

            sh.SetColumnWidth(ExpNumberOfJacketsColIndex, (int) ((20 + 0.72)*256));
            sh.SetColumnWidth(ExpJacketRateColIndex, (int) ((15 + 0.72)*256));
            sh.SetColumnWidth(ExpAmountForJacketsColIndex, (int) ((30 + 0.72)*256));

            sh.SetColumnWidth(ExpNumberOfSafaryColIndex, (int) ((20 + 0.72)*256));
            sh.SetColumnWidth(ExpSafaryRateColIndex, (int) ((15 + 0.72)*256));
            sh.SetColumnWidth(ExpAmountForSafariesColIndex, (int) ((30 + 0.72)*256));

            sh.SetColumnWidth(ExpNumberOfTrousersColIndex, (int) ((20 + 0.72)*256));
            sh.SetColumnWidth(ExpTrouserRateColIndex, (int) ((15 + 0.72)*256));
            sh.SetColumnWidth(ExpAmountForTrousersColIndex, (int) ((30 + 0.72)*256));

            sh.SetColumnWidth(ExpNumberOfShirtsColIndex, (int) ((20 + 0.72)*256));
            sh.SetColumnWidth(ExpShirtRateColIndex, (int) ((15 + 0.72)*256));
            sh.SetColumnWidth(ExpAmountForShirtsColIndex, (int) ((30 + 0.72)*256));

            sh.SetColumnWidth(ExpNumberOfOthersColIndex, (int) ((20 + 0.72)*256));
            sh.SetColumnWidth(ExpOtherRateColIndex, (int) ((15 + 0.72)*256));
            sh.SetColumnWidth(ExpAmountForOthersColIndex, (int) ((30 + 0.72)*256));

            sh.SetColumnWidth(ExpCustomerIdColIndex, (int) ((45 + 0.72)*256));
            sh.SetColumnWidth(ExpBillIdColIndex, (int) ((45 + 0.72)*256));
        }

        private static void SetExcelSheetHeadersBookingBillsSummary(ISheet sh)
        {
            var headerRow = sh.CreateRow(0);

            for (var colNumber = 0; colNumber < ExpBookingSummaryTotalColCount; colNumber++)
            {
                headerRow.CreateCell(colNumber, NPOI.SS.UserModel.CellType.String);
            }

            headerRow.GetCell(ExpBookingSummaryNameColIndex).SetCellValue("Name");
            headerRow.GetCell(ExpBookingSummaryQtyColIndex).SetCellValue("Qty");
            headerRow.GetCell(ExpBookingSummaryAmountColIndex).SetCellValue("Amount");
        }

        private static void SetExcelSheetStylesBookingBillsSummary(ISheet sh)
        {
            // 0.72 is base width of column
            // 1/256 character factor
            sh.SetColumnWidth(ExpBookingSummaryNameColIndex, (int)((20 + 0.72) * 256));
            sh.SetColumnWidth(ExpBookingSummaryQtyColIndex, (int)((20 + 0.72) * 256));
            sh.SetColumnWidth(ExpBookingSummaryAmountColIndex, (int)((30 + 0.72) * 256));
        }

        private static void SetExcelSheetHeadersDeliveryBillsSummary(ISheet sh)
        {
            var headerRow = sh.CreateRow(0);

            for (var colNumber = 0; colNumber < ExpBookingSummaryTotalColCount; colNumber++)
            {
                headerRow.CreateCell(colNumber, NPOI.SS.UserModel.CellType.String);
            }

            headerRow.GetCell(ExpDeliveredSummaryNameColIndex).SetCellValue("Name");
            headerRow.GetCell(ExpDeliveredSummaryQtyColIndex).SetCellValue("Qty");
            headerRow.GetCell(ExpDeliveredSummaryAmountColIndex).SetCellValue("Amount");
        }

        private static void SetExcelSheetStylesDeliveryBillsSummary(ISheet sh)
        {
            // 0.72 is base width of column
            // 1/256 character factor
            sh.SetColumnWidth(ExpDeliveredSummaryNameColIndex, (int) ((20 + 0.72)*256));
            sh.SetColumnWidth(ExpDeliveredSummaryQtyColIndex, (int) ((20 + 0.72)*256));
            sh.SetColumnWidth(ExpDeliveredSummaryAmountColIndex, (int) ((30 + 0.72)*256));
        }

        #endregion
    }
}
