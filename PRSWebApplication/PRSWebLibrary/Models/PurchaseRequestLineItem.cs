﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PRSWebLibrary.Models
{
    public class PurchaseRequestLineItem
    {
        [Key]
        public int Id { get; set; }
        public int Quantity { get; set; }

        public int PurchaseRequestId { get; set; }
        public PurchaseRequest PurchaseRequest { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
