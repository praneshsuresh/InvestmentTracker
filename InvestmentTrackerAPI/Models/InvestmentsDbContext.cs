using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvestmentTrackerAPI.Models
{
    public class InvestmentsDbContext : DbContext
    {
        public InvestmentsDbContext(DbContextOptions<InvestmentsDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Stock> Stocks { get; set; }
    }
}
