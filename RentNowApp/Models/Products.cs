using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentNowApp.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public int? CategoryId { get; set; }
        public string ProductName { get; set; }
        public string Descriptions { get; set; }
        public int? Quantity { get; set; }
    }
}
