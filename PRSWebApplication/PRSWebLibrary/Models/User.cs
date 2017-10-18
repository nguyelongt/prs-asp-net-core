using System.ComponentModel.DataAnnotations;

namespace PRSWebLibrary.Models
{

    public class User
    {
        public int Id { get; set; }

        [StringLength(30)]
        [Required]
        public string UserName { get; set; }

        [StringLength(30)]
        [Required]
        public string Password { get; set; }

        [StringLength(30)]
        [Required]
        public string FirstName { get; set; }

        [StringLength(30)]
        [Required]
        public string LastName { get; set; }

        [StringLength(12)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "You must provide your phone number.")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "You must provide a proper phone number.")]
        [RegularExpression("^\\D?(\\d{3})\\D?\\D?(\\d{3})\\D?(\\d{4})$", ErrorMessage = "You must provide a proper phone number.")]
        public string Phone { get; set; }

        [StringLength(30)]
        [Required]
        public string Email { get; set; }

        [Required]
        public bool IsReviewer { get; set; }

        [Required]
        public bool IsAdmin { get; set; }
    }
}
