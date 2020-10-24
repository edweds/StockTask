using Microsoft.EntityFrameworkCore;
using StockTask.Domain.Models;

namespace StockTask.EntityFramework
{
    class StockTaskDbContext:DbContext
    {
        public DbSet<CreatedItem> CreatedItems { get; set; }
        public DbSet<ToStockItem> ToStockItems { get; set; }
        public DbSet<SoldItem> SoldItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=StockItemsDB;Integrated Security=True; Database=StockItemsDB");
            base.OnConfiguring(optionsBuilder);
        }

    }
}