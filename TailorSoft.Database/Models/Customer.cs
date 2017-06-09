using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TailorSoft.Database.Models
{
    public class Customer
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(1000)]
        public string Address { get; set; }

        [Required]
        [MaxLength(15)]
        [Index("UX_Customer_PrimaryPhone", IsUnique = true)]
        public string PrimaryPhone { get; set; }

        [MaxLength(15)]
        public string OtherPhone { get; set; }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedDt { get; set; }

        public DateTime? DeletedDt { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }
    }
}