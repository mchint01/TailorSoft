using System;

namespace TailorSoft.Business.Models
{
    public class ExportBillInfo
    {
        public string CustomerName { get; set; }

        public int BillNumber { get; set; }

        public DateTime BillDt { get; set; }

        public string BillStatus { get; set; }

        public int NumberOfSuits { get; set; }

        public decimal SuitRate { get; set; }

        public decimal AmountForSuits { get; set; }

        public int NumberOfJackets { get; set; }

        public decimal JacketRate { get; set; }

        public decimal AmountForJackets { get; set; }

        public int NumberOfSafary { get; set; }

        public decimal SafaryRate { get; set; }

        public decimal AmountForSafaries { get; set; }

        public int NumberOfTrousers { get; set; }

        public decimal TrouserRate { get; set; }

        public decimal AmountForTrousers { get; set; }

        public int NumberOfShirts { get; set; }

        public decimal ShirtRate { get; set; }

        public decimal AmountForShirts { get; set; }

        public int NumberOfOthers { get; set; }

        public decimal OtherRate { get; set; }

        public decimal AmountForOthers { get; set; }

        public Guid CustomerId { get; set; }

        public Guid BillId { get; set; }
    }
}
