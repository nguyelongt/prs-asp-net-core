using System;
using System.ComponentModel.DataAnnotations;

namespace PRSWebLibrary.Models
{
    public class Vendor
    {
        [Key]
        public int Id { get; set; }

        [StringLength(10)]
        [Required]
        public string Code { get; set; }

        [StringLength(255)]
        [Required]
        public string Name { get; set; }

        [StringLength(255)]
        [Required]
        public string Address { get; set; }

        [StringLength(255)]
        [Required]
        public string City { get; set; }

        [StringLength(2)]
        [Required]
        public string State { get; set; }

        [StringLength(5)]
        [Required]
        public string Zip { get; set; }

        [StringLength(12)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "You must provide your phone number.")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "You must provide a proper phone number.")]
        [RegularExpression("^\\D?(\\d{3})\\D?\\D?(\\d{3})\\D?(\\d{4})$", ErrorMessage = "You must provide a proper phone number.")]
        public string Phone { get; set; }

        [StringLength(100)]
        [Required]
        public string Email { get; set; }

        [Required]
        public bool IsPreApproved { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        [Required]
        public DateTime DateUpdated { get; set; }

        [Required]
        public int UpdatedByUser { get; set; }
    }
}
