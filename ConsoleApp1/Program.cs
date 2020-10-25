using StockTask.Domain.Models;
using StockTask.Domain.Services;
using StockTask.EntityFramework;
using StockTask.EntityFramework.Services;
using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataService<CreatedItem> createdItemService = new GenericDataService<CreatedItem>(new DesignDbContextOptions());
            Console.WriteLine(createdItemService.Delete(2).Result);
            Console.ReadLine();
        }
    }
}
