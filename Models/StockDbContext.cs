using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stock_App.Models
{
    public class StockDbContext:DbContext
    {
        public StockDbContext(DbContextOptions<StockDbContext> options):base(options)
        {

        }

        public DbSet<StockSale> StockSales { get; set; }
    }
}
