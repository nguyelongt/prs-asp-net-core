using System;
using System.ComponentModel.DataAnnotations;

namespace PRSWebLibrary.Models
{
    public class PurchaseRequest
    {
        [Key]
        public int Id { get; set; }

        [StringLength(80)]
        [Required]
        public string Description { get; set; }

        [StringLength(80)]
        public string Justification { get; set; }

        [StringLength(80)]
        public string RejectionReason { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateNeeded { get; set; }

        [StringLength(20)]
        [Required]
        public string DeliveryMode { get; set; }

        [StringLength(15)]
        [Required]
        public string Status { get; set; }

        [Required]
        public decimal? Total { get; set; }

        [Required]
        public DateTime SubmittedDate { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
