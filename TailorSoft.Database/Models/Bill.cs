using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TailorSoft.Database.Models
{
    public class Bill
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Index("IX_Bill_BillNumber", IsUnique = false)]
        public int BillNumber { get; set; }

        public Guid CustomerId { get; set; }

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

        public string BillStatus { get; set; }

        public string Notes { get; set; }

        [Required]
        [Index("IX_Bill_CreatedDt", IsUnique = false)]
        public DateTime CreatedDt { get; set; }

        [Required]
        [Index("IX_Bill_BillDt", IsUnique = false)]
        public DateTime BillDt { get; set; }

        [Required]
        [Index("IX_Bill_PreferredDeliveryDt", IsUnique = false)]
        public DateTime PreferredDeliveryDt { get; set; }

        [Index("IX_Bill_PreferredInternalDeliveryDt", IsUnique = false)]
        public DateTime? PreferredInternalDeliveryDt { get; set; }

        [Index("IX_Bill_SentToTailorDt", IsUnique = false)]
        public DateTime? SentToTailorDt { get; set; }

        [Index("IX_Bill_ReadyForDeliveryDt", IsUnique = false)]
        public DateTime? ReadyForDeliveryDt { get; set; }

        [Index("IX_Bill_DeliveredDt", IsUnique = false)]
        public DateTime? DeliveredDt { get; set; }

        public DateTime? DeletedDt { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
    }
}