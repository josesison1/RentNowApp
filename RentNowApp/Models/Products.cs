using System;
using System.Collections.Generic;

namespace RentNowApp.Models
{
    public partial class Products
    {
        public Products()
        {
            Transactions = new HashSet<Transactions>();
        }

        public int ProductId { get; set; }
        public int? CategoryId { get; set; }
        public string ProductName { get; set; }
        public string Descriptions { get; set; }
        public int? Quantity { get; set; }

        public virtual Categories Category { get; set; }
        public virtual ICollection<Transactions> Transactions { get; set; }
    }
}
