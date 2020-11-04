using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentNowApp.Models
{
    public partial class Transactions
    {
        [Key]
        public int TransactionId { get; set; }
        public int? RentalLength { get; set; }
        public string UserId { get; set; }

        //public int? ProductId { get; set; }
        //[ForeignKey("ProductId")]
        //public virtual Products Product { get; set; }
        [ForeignKey("UserId")]
        public virtual IdentityUser User { get; set; }
    }
}
