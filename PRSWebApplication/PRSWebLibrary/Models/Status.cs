using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PRSWebLibrary.Models
{
    public class Status
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
