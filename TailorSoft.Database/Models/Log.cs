using System;
using System.ComponentModel.DataAnnotations;

namespace TailorSoft.Database.Models
{
    public class Log
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Message { get; set; }

        public string MessageExtension { get; set; }

        [Required]
        public DateTime CreatedDt { get; set; }
    }
}