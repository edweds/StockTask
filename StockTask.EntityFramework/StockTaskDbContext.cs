using Microsoft.EntityFrameworkCore;
using StockTask.Domain.Models;

namespace StockTask.EntityFramework
{
    public class StockTaskDbContext:DbContext
    {
        
        public DbSet<CreatedItem> CreatedItems { get; set; }
        public DbSet<ToStockItem> ToStockItems { get; set; }
        public DbSet<SoldItem> SoldItems { get; set; }
        public StockTaskDbContext(DbContextOptions options) : base(options) {}

    }
}