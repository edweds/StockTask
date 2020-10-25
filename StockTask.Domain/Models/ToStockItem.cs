using System;

namespace StockTask.Domain.Models
{
    public class ToStockItem:TableDomainObject
    {
        public string Name { get; }
        public DateTime ToStockTime { get; private set; }
        public ToStockItem()
        {
            ToStockTime = DateTime.Now;
        }
    }
}
