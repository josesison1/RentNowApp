using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RentNowApp.Models
{
    public partial class RentNowAppContext : IdentityDbContext
    {
        public RentNowAppContext(DbContextOptions<RentNowAppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Transactions> Transactions { get; set; }
    }
}
