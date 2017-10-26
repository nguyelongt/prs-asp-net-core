using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRSWebLibrary.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        
        [ForeignKey("Vendor")]
        public int VendorId { get; set; }
        
        [StringLength(50)]
        [Required]
        public string PartNumber { get; set; }
        
        [StringLength(150)]
        [Required]
        public string Name { get; set; }
       
        [Required]
        public decimal? Price { get; set; }
        
        [StringLength(255)]
        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = true)]
        public string Unit { get; set; }

        [StringLength(255)]
        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = true)]
        public string PhotoPath { get; set; }

        public bool IsActive { get; set; }
        
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? DateCreated { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? DateUpdated { get; set; }
        
        public int UpdatedByUser { get; set; }
        
    }
}