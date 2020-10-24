using System;

namespace StockTask.Domain.Models
{
    public class ToStockItem
    {
        public int Id { get; set; }
        public string Name { get; }
        public DateTime ToStockTime 
        { 
            get { return ToStockTime; } 
            set { ToStockTime = DateTime.Now; } 
        }
    }
}
