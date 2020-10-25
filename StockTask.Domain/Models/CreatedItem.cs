using System;

namespace StockTask.Domain.Models
{
    public class CreatedItem:TableDomainObject
    {
        public string Name { get; set; }
        public DateTime ReceivingDate { get; private set; }
        public CreatedItem()
        {
            ReceivingDate = DateTime.Now;
        }
    }
}
