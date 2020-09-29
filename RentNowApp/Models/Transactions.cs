using System;
using System.Collections.Generic;

namespace RentNowApp.Models
{
    public partial class Transactions
    {
        public int TransactionId { get; set; }
        public int? RentalLength { get; set; }
        public int? UserId { get; set; }
        public int? ProductId { get; set; }

        public virtual Products Product { get; set; }
        public virtual Users User { get; set; }
    }
}
