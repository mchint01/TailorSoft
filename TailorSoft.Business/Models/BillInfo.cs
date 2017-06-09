using System;

namespace TailorSoft.Business.Models
{
    public class BillInfo
    {
        public Guid Id { get; set; }

        public int BillNumber { get; set; }

        public Guid CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string BillStatus { get; set; }

        public string SuitMeasurements { get; set; }

        public string JacketMeasurements { get; set; }

        public string SafaryMeasurements { get; set; }

        public string TrouserMeasurements { get; set; }

        public string ShirtMeasurements { get; set; }

        public string OtherMeasurements { get; set; }

        public decimal SuitRate { get; set; }

        public int? NumberOfSuits { get; set; }

        public decimal JacketRate { get; set; }

        public int? NumberOfJackets { get; set; }

        public decimal SafaryRate { get; set; }

        public int? NumberOfSafary { get; set; }

        public decimal TrouserRate { get; set; }

        public int? NumberOfTrousers { get; set; }

        public decimal ShirtRate { get; set; }

        public int? NumberOfShirts { get; set; }

        public decimal OtherRate { get; set; }

        public int? NumberOfOthers { get; set; }

        public string Notes { get; set; }

        public DateTime BillDt { get; set; }

        public DateTime PreferredDeliveryDt { get; set; }

        public DateTime? PreferredInternalDeliveryDt { get; set; }

        public DateTime? SentToTailorDt { get; set; }

        public DateTime? ReadyForDeliveryDt { get; set; }

        public DateTime? DeliveredDt { get; set; }
    }
}
