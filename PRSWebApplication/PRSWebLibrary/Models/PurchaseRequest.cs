using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PRSWebLibrary.Models
{
    public class PurchaseRequest
    {
        public int Id { get; set; }

        [StringLength(80)]
        [Required]
        public string Description { get; set; }

        [StringLength(80)]
        public string Justification { get; set; }

        [StringLength(80)]
        public string RejectionReason { get; set; }

        [Required]
        public DateTime DateNeeded { get; set; }

        [StringLength(20)]
        [Required]
        public string DeliveryMode { get; set; }

        [StringLength(15)]
        [Required]
        public string Status { get; set; }

        [Required]
        public double Total { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
