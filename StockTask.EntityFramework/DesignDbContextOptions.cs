using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace StockTask.EntityFramework
{
    public class DesignDbContextOptions : IDesignTimeDbContextFactory<StockTaskDbContext>
    {
        public StockTaskDbContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<StockTaskDbContext>();
            options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=StockItemsDB;Integrated Security=True; Database=StockItemsDB");
            return new StockTaskDbContext(options.Options);
        }
    }
}
